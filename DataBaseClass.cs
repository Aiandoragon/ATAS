using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATAS
{
    
    internal class DataBase
    {
        Misc _misc = new Misc();
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionPath"].ConnectionString);

        public void openConnection() { if (sqlConnection.State != System.Data.ConnectionState.Open) sqlConnection.Open(); }

        public void closeConnection() { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }

        public SqlConnection getSqlConnection() { return sqlConnection; }

        public void deleteRows(string table, DataGridView dgw)
        {
            string ids = _misc.getIdsForDelete(dgw);
            deleteSQLRow(table,ids,"id");
        }

        public void deleteSQLRow(string table, string ids, string id)
        {
            openConnection();
            string sqlreq = $"DELETE FROM {table} WHERE {id} in {ids}";
            SqlCommand command = new SqlCommand(sqlreq, getSqlConnection());
            command.ExecuteNonQuery();
            closeConnection();
        }

        public List<string> getColumnsFromTable(string table)
        {
            List<string> answer = new List<string>();
            SqlDataReader reader;
            SqlCommand command;
            string request = $"select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{table}'";
            command = new SqlCommand(request, getSqlConnection());
            openConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                answer.Add(reader.GetString(0));
            }
            reader.Close();
            closeConnection();
            return answer;
        }

        public string getColumnTypeFromTable(string table, string name)
        {
            string answer = "";
            SqlDataReader reader;
            SqlCommand command;
            string request = $"select DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{table}' and COLUMN_NAME = '{name}'";
            command = new SqlCommand(request, getSqlConnection());
            openConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            { 
                answer = reader.GetValue(0).ToString();
            }
            reader.Close();
            closeConnection();
            return answer;
        }

        public void refreshTable(DataGridView dgw, string tab)
        {
            //определение переменных
            SqlDataReader reader;
            string sqlreq = $"select * from {tab}";
            SqlCommand command; 
            //очистка таблицы
            dgw.Rows.Clear();
            //заполнение пустыми строчками
            int countRows = findTheOnlyOneRows(tab,"count(*)");
            //формирование запроса к таблице
            if (_misc.checkTableNameForComboBox(tab))
            { 
                List<string> maincolname;
                List<string> seccolname;
                string sectab = _misc.getMasterTableNameByDependentTableName(tab);
                maincolname = getColumnsFromTable(tab);                
                seccolname = getColumnsFromTable(sectab);
                string id = seccolname[0];
                string items = "";
                string secid = "";
                for (int i = 0; i < maincolname.Count; i++)
                    if (_misc.checkColumnNameInComboBoxColumnNames(maincolname[i]))
                        secid = maincolname[i];
                //Поиск необходимых имен для обращения к таблицам
                for (int i = 0;i < maincolname.Count;i++)
                {
                    //MessageBox.Show(maincolname[i]);
                    if (!_misc.checkColumnNameInComboBoxColumnNames(maincolname[i]))
                        items += "M." + maincolname[i] + ", ";
                    else
                        items += "S." + "name" + ", ";
                }
                items = items.Remove(items.Length - 2);
                sqlreq = $"select {items} from {tab} M join {sectab} S on M.{secid} = S.{id}";
                //MessageBox.Show(sqlreq);
            }
            if (_misc.checkTableNameInTwoJoin(tab))
            {
                //for (int i = 0; i < countRows; i++) dgw.Rows.Add();
                if (tab == "tours")
                {
                    countRows = findTheOnlyOneRows(tab, "count(distinct unic_tour_id)");
                    sqlreq = 
                        $"select string_agg(M.id, ', '), M.unic_tour_id, M.name, " +
                        $"string_agg(S.name, ', '), count_day, F.name, description " +
                        $"from tours M join transport F on F.id = M.transport_id " +
                        $"join hotel S on S.id = M.hotels_id " +
                        $"group by M.unic_tour_id, M.name, count_day, F.name, description";
                }
                if (tab == "request")
                {
                    countRows = findTheOnlyOneRows(tab, "count(distinct unic_id)");
                    sqlreq = 
                        $"select STRING_AGG(R.id, ', '), unic_id, " +
                        $"STRING_AGG(C.name + ' ' + C.surname + ', ' + C.passport, ' | '), " +
                        $"T.name, R.start_date, R.finish_date, R.status " +
                        $"from Request R join Client C on R.client_ids = C.id " +
                        $"join Tours T on T.id = R.tour_id " +
                        $"group by unic_id, T.name, R.start_date, R.finish_date, R.status";
                }
                    //sqlreq = $"select id, name, string_agg(names, count_day, transport_name, descripion from tours M join ";
                    //MessageBox.Show("шиш");
                    /*$"join {firsttab} F on M.{firstidforeign} = F.{firstid} " +
                    $"join {secondtable} S on M.{secondIdForeing} = S.{secondid}";*/
            }
            //заполнение таблицы
            for (int i = 0; i < countRows; i++) dgw.Rows.Add();
            command = new SqlCommand(sqlreq, getSqlConnection());
            openConnection();
            reader = command.ExecuteReader();
            int rowsIndex = 0;
            int countColumn = dgw.Columns.Count - 1; //минус скрытая колонка для удаления
            while (reader.Read())
            {
                for (int columnIndex = 0; columnIndex < countColumn; columnIndex++)
                {
                    dgw.Rows[rowsIndex].Cells[columnIndex].Value = reader.GetValue(columnIndex);
                }
                rowsIndex++;
            }
            reader.Close();
            closeConnection();
        }

        public void refreshTableCustom(DataGridView dgw, string table, string body)
        {
            try
            {
                SqlDataReader reader;
                SqlCommand command;
                string sqlreq = $"select {body} from {table}";
                dgw.Rows.Clear();
                int rowsCount = findTheOnlyOneRows(table,"count(*)");
                for (int i = 0; i < rowsCount; i++) dgw.Rows.Add();
                command = new SqlCommand(sqlreq, getSqlConnection());
                openConnection();
                reader = command.ExecuteReader();
                int rowI = 0;
                int columnCount = dgw.Columns.Count; //минус строка выбора добавления
                while (reader.Read())
                {
                    for (int columnI = 1; columnI < columnCount; columnI++)
                    {
                        dgw.Rows[rowI].Cells[columnI].Value = reader.GetValue(columnI - 1);
                    }
                    rowI++;
                }
                reader.Close();
                closeConnection();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка обновления таблицы: " + ex.Message); }
        }

        public void refreshTableCustomUpdate(DataGridView dgw, string table, List<string> idsList)
        {
            try
            {
                SqlDataReader reader;
                SqlCommand command;
                dgw.Rows.Clear();
                int rowsCount = findTheOnlyOneRowsUpdate(table, "count(*)",idsList);
                for (int i = 0; i < rowsCount; i++) dgw.Rows.Add();
                string ids = _misc.shaklesString(_misc.convertListToString(idsList));
                string request = $"select * from {table} where id in {ids}";
                command = new SqlCommand(request, getSqlConnection());
                openConnection();
                reader = command.ExecuteReader();
                int rowI = 0;
                int columnCount = dgw.Columns.Count; //минус строка выбора добавления
                while (reader.Read())
                {
                    for (int columnI = 0; columnI < columnCount; columnI++)
                    {
                        dgw.Rows[rowI].Cells[columnI].Value = reader.GetValue(columnI);
                    }
                    rowI++;
                }
                reader.Close();
                closeConnection();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка обновления таблицы: " + ex.Message); }
        }

        public int findTheOnlyOneRows(string table, string body)
        {
            SqlCommand command;
            command = new SqlCommand($"select {body} 'c' from {table}", getSqlConnection());
            openConnection();
            SqlDataReader reader = command.ExecuteReader();
            int c = 0;
            while (reader.Read())
            {
                c = Convert.ToInt16(reader["c"]);
            }
            reader.Close();
            closeConnection();
            return c;
        }

        public int findTheOnlyOneRowsRquest(string request)
        {
            SqlCommand command;
            command = new SqlCommand(request, getSqlConnection());
            openConnection();
            SqlDataReader reader = command.ExecuteReader();
            int c = 0;
            while (reader.Read())
            {
                c = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            closeConnection();
            return c;
        }

        public List<int> findTheOnlyOneRowsRquestMajor(string request)
        {
            SqlCommand command;
            command = new SqlCommand(request, getSqlConnection());
            openConnection();
            SqlDataReader reader = command.ExecuteReader();
            List<int> c = new List<int>();
            while (reader.Read())
            {
                c.Add(Convert.ToInt32(reader[0]));
            }
            reader.Close();
            closeConnection();
            return c;
        }

        public int findTheOnlyOneRowsUpdate(string table, string body, List<string> idsList)
        {
            SqlCommand command;
            string ids = _misc.shaklesString(_misc.convertListToString(idsList));
            command = new SqlCommand($"select {body} 'c' from {table} where id in {ids}", getSqlConnection());
            openConnection();
            SqlDataReader reader = command.ExecuteReader();
            int c = 0;
            while (reader.Read())
            {
                c = Convert.ToInt16(reader["c"]);
            }
            reader.Close();
            closeConnection();
            return c;
        }

        public void setItemsforComboBoxColumn(DataGridViewComboBoxColumn storage, string table, string name)
        {
            storage.Items.Clear();
            SqlCommand command;
            SqlDataReader reader;
            command = new SqlCommand($"select {name} from {table}", getSqlConnection());
            openConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                storage.Items.Add(reader.GetString(0));
            }
            reader.Close();
            closeConnection();
        }

        public void setItemsforComboBox(System.Windows.Forms.ComboBox storage, string table, string name)
        {
            storage.Items.Clear();
            SqlCommand command;
            SqlDataReader reader;
            command = new SqlCommand($"select distinct {name} from {table}", getSqlConnection());
            openConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                storage.Items.Add(reader.GetString(0));
            }
            reader.Close();
            closeConnection();
        }

        public void setItemsforListCheckBoxMassive(CheckedListBox storage, string table)
        {
            storage.Items.Clear();
            int countColumn = getColumnsFromTable(table).Count - 4;
            string row = "";
            SqlCommand command;
            SqlDataReader reader;
            command = new SqlCommand($"select name, surname, patronymic, passport from {table}", getSqlConnection());
            openConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < countColumn; i++)
                {
                    row += reader.GetValue(i) + " ";
                }
                row = row.Remove(row.Length - 1);
                storage.Items.Add(row);
                row = "";
            }
            reader.Close();
            closeConnection();
        }

        public List<string> setItemsforListCheckBox(CheckedListBox storage, string table, string body)
        {
            storage.Items.Clear();
            List<string> Ids = new List<string>();
            SqlCommand command;
            SqlDataReader reader;
            command = new SqlCommand($"select {body} from {table}", getSqlConnection());
            openConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                storage.Items.Add(reader.GetValue(1));
                Ids.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
            closeConnection();
            return Ids;
        }

        public string getIdOnName(string table, string name)
        {
            string id = "";
            SqlCommand command;
            SqlDataReader reader;
            string request = $"select id from {table} where name = N'{name}'";
            command = new SqlCommand (request, getSqlConnection());
            openConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToString(reader[0]);
            }
            reader.Close();
            closeConnection();
            return id;
        }

        public object getNameOnId(string table, string id)
        {
            object name = null;
            openConnection();
            SqlCommand com;
            SqlDataReader reader;
            string req = $"select name from {table} where name = {id}";
            com = new SqlCommand(req, getSqlConnection());
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                name = reader[0];
            }
            reader.Close();
            closeConnection();
            return name;
        }

        public void insertInTable (string tab, string columns, string values)
        {
            openConnection();
            SqlCommand command = new SqlCommand($"insert into {tab} {columns} values {values}", getSqlConnection());
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void updateTable (string tab, string body, string id)
        {
            openConnection();
            SqlCommand command = new SqlCommand($"update {tab} SET {body} WHERE id = {id}",getSqlConnection());
            command.ExecuteNonQuery();
            closeConnection();
        }

        public DataGridView getDataTableBefore (string table, int columnCount)
        {
            DataGridView dgwBefore = new DataGridView();
            dgwBefore.ColumnCount = columnCount;
            dgwBefore.AllowUserToAddRows = false;
            refreshTable(dgwBefore,table);
            return dgwBefore;
        }

        public void selectChangedItemsAndUpdateThem (DataGridView dgw, string table, List<string> idsList)
        {
            string ids = _misc.shaklesString(_misc.convertListToString(idsList));
            /*MessageBox.Show($"Ids = {ids}");
            for (int i = 0; i < dgw.RowCount; i++)
            {
                for (int j = 1; j < dgw.ColumnCount - 1; j++)
                {
                    MessageBox.Show($"Значение ({i},{j}) = {dgw.Rows[i].Cells[j].Value}");
                }
            }*/
            int countRows = dgw.RowCount;
            int countColumns = dgw.ColumnCount - 1;
            List<string> columns = getColumnsFromTable(table);
            columns.RemoveAt(0);
            string columnNames = _misc.shaklesString(_misc.convertListToString(columns));

            for (int i = 0; i < countRows; i++)
            {
                if (_misc.checkIteminItemList(idsList, dgw.Rows[i].Cells[0].Value.ToString()))
                {
                    string body = "";
                    string value = "";
                    for (int j = 1; j < countColumns; j++)
                    {
                        string columnName = columns[j - 1];
                        string columnType = getColumnTypeFromTable(table, columnName);
                        try
                        {
                            value = dgw.Rows[i].Cells[j].Value.ToString();
                            if (_misc.checkColumnNameInComboBoxColumnNames(columnName))
                            {
                                value = getIdOnName(_misc.getMasterTableNameByDependentTableName(table), value);
                            }
                            switch (columnType)
                            {
                                case "int":

                                    break;
                                case "nvarchar":
                                    value = "N'" + value + "'";
                                    break;
                                case "bit":
                                    value = Convert.ToInt32(Convert.ToBoolean(value)).ToString();
                                    break;
                                case "date":
                                    value = "CONVERT(DATE, '" + value + "', 103)";
                                    break;
                                default:
                                    MessageBox.Show("Неизвестный тип данных");
                                    break;
                            }
                        }
                        catch
                        {
                            value = "null";
                            if (columnType == "bit")
                                value = "0";
                        }
                        body += $"{columnName} = {value}, ";
                    }
                    body = body.Remove(body.Length - 2);
                    string id = dgw.Rows[i].Cells[0].Value.ToString();
                    //MessageBox.Show($"update {table} set {body} where id = {dgw.Rows[i].Cells[0].Value.ToString()}");
                    updateTable(table, body, id);
                }
                else
                {
                    //MessageBox.Show($"Строка с id {dgw.Rows[i].Cells[0]} не была изменена");
                }
            }
                
            
        }

        public void addRows(string table, DataGridView dgw, int countRowBefore)
        {
                List<string> columns = new List<string>();
                columns = getColumnsFromTable(table);
                columns.RemoveAt(0);
                string columnNames = _misc.shaklesString(_misc.convertListToString(columns));
                string columnName;
                string columnType;
                string value;
                string values = "";
                for (int i = countRowBefore; i < dgw.Rows.Count - 1; i++)
                {
                    values += "(";
                    for (int j = 1; j < dgw.ColumnCount - 1; j++)
                    {
                        columnName = columns[j - 1];
                        columnType = getColumnTypeFromTable(table, columnName);
                        try
                        {
                            value = dgw.Rows[i].Cells[j].Value.ToString();
                            if (_misc.checkColumnNameInComboBoxColumnNames(columnName))
                            {
                                value = getIdOnName(_misc.getMasterTableNameByDependentTableName(table), value);
                            }
                            switch (columnType)
                            {
                                case "int":

                                    break;
                                case "nvarchar":
                                    value = "N'" + value + "'";
                                    break;
                                case "bit":
                                    value = Convert.ToInt32(Convert.ToBoolean(value)).ToString();
                                    break;
                                case "date":
                                    value = "CONVERT(DATE, '" + value + "', 103)";
                                    break;
                                default:
                                    MessageBox.Show("Неизвестный тип данных");
                                    break;
                            }
                        }
                        catch
                        {
                            value = "null";
                            if (columnType == "bit")
                                value = "0";
                        }
                        //MessageBox.Show(columnName + ": " + columnType + " =?= " + value);
                        values += value + ", ";
                    }
                    values = values.Remove(values.Length - 2);
                    values += "), ";
                }
                values = values.Remove(values.Length - 2);
                MessageBox.Show($"insert into {table} {columnNames} values {values}");
                insertInTable(table, columnNames, values);
                MessageBox.Show($"Таблица {table} изменена");
        }

        public void searchByContextMenu(DataGridView dgw, string table, string text)
        {
            SqlDataReader reader;
            SqlCommand command;
            string sqlRequest = "";
            string sqlRequestForCount = "";
            int countRowsToAdd = 0;
            dgw.Rows.Clear();
            switch (table)
            {
                case "city":
                    sqlRequest = 
                        $"select city.id, city.name, c.name " +
                        $"from city join countries c on c.id = city.country_id " +
                        $"where concat (city.id, city.name, c.name) like N'%{text}%'";
                    break;
                case "client":
                    sqlRequest = 
                        $"select * from client where " +
                        $"concat (id, name, surname, patronymic, birthday, passport, phone, email) like N'%{text}%'";
                    break;
                case "countries":
                    sqlRequest = 
                        $"select * from countries where " +
                        $"concat (id, name, code) like N'%{text}%'";
                    break;
                case "hotel":
                    sqlRequest = 
                        $"select H.id, H.name, C.name, H.food, H.price " +
                        $"from hotel H join city C on C.id = H.city_id " +
                        $"where concat (H.id, H.name, C.name, H.price) like N'%{text}%'";
                    break;
                case "request":
                    sqlRequest = 
                        $"select STRING_AGG(R.id, ', '), " +
                        $"R.unic_id, STRING_AGG(C.name + ' ' + C.surname + ', ' + C.passport, ' | '), " +
                        $"T.name, R.start_date, R.finish_date, R.status " +
                        $"from Request R join Client C on R.client_ids = C.id " +
                        $"join Tours T on T.id = R.tour_id " +
                        $"group by unic_id, T.name, R.start_date, R.finish_date, R.status " +
                        $"having concat (STRING_AGG(R.id, ', '), R.unic_id, " +
                        $"STRING_AGG(C.name + ' ' + C.surname + ', ' + C.passport, ' | '), " +
                        $"T.name, R.start_date, R.finish_date, R.status) like N'%{text}%'";
                    break;
                case "tours":
                    sqlRequest = 
                        $"select string_agg(M.id, ', '), M.unic_tour_id, M.name, " +
                        $"string_agg(S.name, ', '), count_day, F.name, description " +
                        $"from tours M join transport F on F.id = M.transport_id " +
                        $"join hotel S on S.id = M.hotels_id " +
                        $"group by M.unic_tour_id, M.name, count_day, F.name, description " +
                        $"having concat (string_agg(M.id, ', '), M.unic_tour_id, M.name, " +
                        $"string_agg(S.name, ', '), " +
                        $"count_day, F.name, description) like N'%{text}%'";
                    break;
                case "transport":
                    sqlRequest = $"select * from transport where concat (id, name, price) like N'%{text}%'";
                    break;
            }
            //для определения кол-ва строк
            switch (table)
            {
                case "city":
                    sqlRequestForCount = 
                        $"select count(*) from city join countries c on c.id = city.country_id " +
                        $"where concat (city.id, city.name, c.name) like N'%{text}%'";
                    break;
                case "client":
                    sqlRequestForCount = 
                        $"select count(*) from client " +
                        $"where concat (id, name, surname, patronymic, birthday, passport, phone, email) " +
                        $"like N'%{text}%'";
                    break;
                case "countries":
                    sqlRequestForCount = 
                        $"select count(*) from countries where concat (id, name, code) like N'%{text}%'";
                    break;
                case "hotel":
                    sqlRequestForCount = 
                        $"select count(*) from hotel H join city C on C.id = H.city_id " +
                        $"where concat (H.id, H.name, C.name, H.price) like N'%{text}%'";
                    break;
                case "request":
                    sqlRequestForCount = 
                        $"select count(distinct unic_id) " +
                        $"from Request R join Client C on R.client_ids = C.id " +
                        $"join Tours T on T.id = R.tour_id " +
                        $"group by unic_id, T.name, R.start_date, R.finish_date, R.status " +
                        $"having concat (STRING_AGG(R.id, ', '), R.unic_id, " +
                        $"STRING_AGG(C.name + ' ' + C.surname + ', ' + C.passport, ' | '), T.name, " +
                        $"R.start_date, R.finish_date, R.status) " +
                        $"like N'%{text}%'";
                    break;
                case "tours":
                    sqlRequestForCount = 
                        $"select count(distinct unic_tour_id) from tours M " +
                        $"join transport F on F.id = M.transport_id " +
                        $"join hotel S on S.id = M.hotels_id " +
                        $"group by M.unic_tour_id, M.name, count_day, F.name, description " +
                        $"having concat (string_agg(M.id, ', '), M.unic_tour_id, M.name, " +
                        $"string_agg(S.name, ', '), " +
                        $"count_day, F.name, description) " +
                        $"like N'%{text}%'";
                    break;
                case "transport":
                    sqlRequestForCount = 
                        $"select count(*) from transport where concat (id, name, price) like N'%{text}%'";
                    break;
                default:

                    break;
            }
            if (table == "tours" || table == "request")
            {
                countRowsToAdd = findTheOnlyOneRowsRquestMajor(sqlRequestForCount).Count;
            }
            else
            {
                countRowsToAdd = findTheOnlyOneRowsRquest(sqlRequestForCount);
            }
            
            for (int i = 0; i < countRowsToAdd; i++) dgw.Rows.Add();
            command = new SqlCommand(sqlRequest, getSqlConnection());
            openConnection();
            reader = command.ExecuteReader();
            int rowsIndex = 0;
            int countColumn = dgw.Columns.Count - 1; //минус скрытая колонка для удаления
            while (reader.Read())
            {
                for (int columnIndex = 0; columnIndex < countColumn; columnIndex++)
                {
                    dgw.Rows[rowsIndex].Cells[columnIndex].Value = reader.GetValue(columnIndex);
                }
                rowsIndex++;
            }
            reader.Close();
            closeConnection();

        }

        //-----------------------TRASH CAN-----------------------//



        /*public void requestSQL(string request)
        {
            openConnection();
            SqlCommand command = new SqlCommand(request, getSqlConnection());
            command.ExecuteNonQuery();
            closeConnection();
        }*/

        /*public void insertfromdgw (DataGridView dgw, string table) 
        {

        }*/

        /*public string listToString(List<string> list)
        {
            string answer = "(";
            foreach (string item in list) 
            {
                answer += item + ", ";
            }
            answer = answer.Remove(answer.Length - 2);
            answer += ")";
            return answer;
        }*/

        /*public object refreshTable(string req)
        {
            openConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(req, getSqlConnection());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            closeConnection();
            return ds.Tables[0];
        }*/

        /*public void readSingleRow(DataGridView dgw, IDataRecord record)
    {
        for (int i = 0;i < dgw.Columns.Count;i++)
        {
            //dgw.Rows[j].Cells[i].Value = (record[i]);
            //dgw.Rows.Add(record.GetValue(j));
        }          
    }

    public void RefreshDataGrid(DataGridView dgw, string requestString)
    {
        dgw.Rows.Clear();
        SqlDataReader reader;
        SqlCommand command;
        command = new SqlCommand(requestString, getSqlConnection());
        int count = findcountrows("countries");
        int cc = dgw.Columns.Count;
        openConnection();            
        int cont = 0;
        reader = command.ExecuteReader();
        while (reader.Read())
        {
            for (int i = 0; i < cc; i++)
            {
                MessageBox.Show(cont.ToString() + " - " + i.ToString());
                cont++;
            }

            //readSingleRow(dgw, reader); 
        }
        reader.Close();



        closeConnection();
        }*/

        /*public SqlDataReader findFromReqSQL(string obj, string table)
         {
             openConnection();
             SqlDataReader com;
             SqlDataReader reader;
             string req = $"select {obj} from {table} where";
         }*/
    }
}

