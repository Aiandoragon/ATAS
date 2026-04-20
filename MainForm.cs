using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Data.Common;
using ATAS;
using System.Diagnostics.Eventing.Reader;

namespace ATAS
{
    

    public partial class MainForm : Form
    {
        //Важные переменыe
        DataBase _db = new DataBase();
        Misc _misc = new Misc();
        private int current_tab_id;
        private bool isChange = false;
        private string statuschange = "";
        private int countRowBefore = 0;
        public string statusChangeWindow;
        public string tempReference;
        public DataGridView tempDGW;

        private string changeStart(string status)
        {
            DataGridView dgw = getDataGridViewByTabControlPage(MainTabControl.SelectedTab.Name);
            string tablename = _misc.getNameTableByTabControlPageName(MainTabControl.SelectedTab.Name);
            DataGridViewTextBoxColumn idcolumn = getIDColumnByTabControlPage(MainTabControl.SelectedTab.Name);
            DataGridViewCheckBoxColumn deletecolumn = getCheckBoxColumnDeleteByTabControlPage(MainTabControl.SelectedTab.Name);
            //changePanel.Visible = true;
            aceptButton.Visible = true;
            cancelButton.Visible = true;
            mainmenustrip.Enabled = false;
            current_tab_id = MainTabControl.SelectedIndex;
            isChange = true;
            countRowBefore = dgw.RowCount;
            dgw.ReadOnly = false;
            switch (status) {
                case "add":
                    if (_misc.checkTableNameForComboBox(tablename))
                    {
                        DataGridViewComboBoxColumn comboBoxColumn = getComboBoxColumnNameByTableName(tablename);
                        _db.setItemsforComboBoxColumn(comboBoxColumn, _misc.getMasterTableNameByDependentTableName(tablename), "name");
                    }
                    idcolumn.Visible = false;
                    statuschange = "add";
                    dgw.AllowUserToAddRows = true;
                    break;
                case "del":
                    idcolumn.Visible = false;
                    deletecolumn.Visible = true;
                    statuschange = "del";
                    break;
                case "upd":
                    idcolumn.Visible = false;
                    statuschange = "upd";
                    break;
                default:
                    MessageBox.Show("Ошибка выбора типа изменения!");
                    statuschange = "";
                    break;
            }
            _db.refreshTable(dgw, tablename);
            return statuschange;
        }

        private void changeEnd() 
        {
            DataGridView dgw = getDataGridViewByTabControlPage(MainTabControl.SelectedTab.Name);
            DataGridViewCheckBoxColumn deletecolumn = getCheckBoxColumnDeleteByTabControlPage(MainTabControl.SelectedTab.Name);
            string tablename = _misc.getNameTableByTabControlPageName(MainTabControl.SelectedTab.Name);
            DataGridViewTextBoxColumn idcolumn = getIDColumnByTabControlPage(MainTabControl.SelectedTab.Name);
            //changePanel.Visible = false;
            aceptButton.Visible = false;
            cancelButton.Visible = false;
            mainmenustrip.Enabled = true;
            MainTabControl.Enabled = true;
            dgw.AllowUserToAddRows = false;
            dgw.ReadOnly = true;
            deletecolumn.Visible = false;
            isChange = false;
            idcolumn.Visible = true;
            countRowBefore = 0;
            statuschange = "";
            _db.refreshTable(dgw, tablename);
        }

        private DataGridView getDataGridViewByTabControlPage(string tabname)
        {
            DataGridView dataGridView = null;
            switch (tabname)
            {
                case "countriespage":
                    dataGridView = countriesGridView;
                break;
                case "citypage":
                    dataGridView = cityGridView;
                break;
                case "hotelpage":
                    dataGridView = hotelGridView;
                    break;
                case "transportpage":
                    dataGridView = transportGridView;
                    break;
                case "tourpage":
                    dataGridView = tourGridView;
                    break;
                case "clientpage":
                    dataGridView = clientGridView;
                    break;
                case "requestpage":
                    dataGridView = requestGridView;
                    break;
                default: MessageBox.Show("Ошибка выбора datagridview по tabcontrol");
                    break;
            }
            return dataGridView;
        }

        private DataGridView getDataGridViewByTableName(string tabname)
        {
            DataGridView dataGridView = null;
            switch (tabname)
            {
                case "countries":
                    dataGridView = countriesGridView;
                    break;
                case "city":
                    dataGridView = cityGridView;
                    break;
                case "hotel":
                    dataGridView = hotelGridView;
                    break;
                case "transport":
                    dataGridView = transportGridView;
                    break;
                case "tours":
                    dataGridView = tourGridView;
                    break;
                case "client":
                    dataGridView = clientGridView;
                    break;
                case "request":
                    dataGridView = requestGridView;
                    break;
                default:
                    MessageBox.Show("Ошибка выбора datagridview по названию таблицы");
                    break;
            }
            return dataGridView;
        }

        private DataGridViewCheckBoxColumn getCheckBoxColumnDeleteByTabControlPage(string tabname)
        {
            
            DataGridViewCheckBoxColumn deletecolumn = null;
            switch (tabname)
            {
                case "countriespage":
                    deletecolumn = deletecountry;
                    break;
                case "citypage":
                    deletecolumn = deletecity;
                    break;
                case "hotelpage":
                    deletecolumn = deletehotel;
                    break;
                case "transportpage":
                    deletecolumn = deletetransport;
                    break;
                case "tourpage":
                    deletecolumn = deletetour;
                    break;
                case "clientpage":
                    deletecolumn = deleteclient;
                    break;
                case "requestpage":
                    deletecolumn = deleterequest;
                    break;
                default:
                    MessageBox.Show("Ошибка выбора столбца удаления по tabcontrol");
                    break;
            }
            return deletecolumn;
        }


        private DataGridViewTextBoxColumn getIDColumnByTabControlPage(string tabname)
        {
            DataGridViewTextBoxColumn IDcolumn = null;
            switch (tabname)
            {
                case "countriespage":
                    IDcolumn = countryid;
                    break;
                case "citypage":
                    IDcolumn = cityid;
                    break;
                case "hotelpage":
                    IDcolumn = hotelid;
                    break;
                case "transportpage":
                    IDcolumn = transportid;
                    break;
                case "tourpage":
                    IDcolumn = tourid;
                    break;
                case "clientpage":
                    IDcolumn = clientId;
                    break;
                case "requestpage":
                    IDcolumn = requestid;
                    break;
                default:
                    MessageBox.Show("Ошибка выобра ID столбца");
                    break;
            }
            return IDcolumn;
        }

        private DataGridViewComboBoxColumn getComboBoxColumnNameByTabControlPage(string tabname)
        {
            DataGridViewComboBoxColumn IDcolumn = null;
            switch (tabname)
            {
                case "citypage":
                    IDcolumn = citycountryname;
                    break;
                case "hotelpage":
                    IDcolumn = hotelcityid;
                    break;
                case "tourpage":
                    IDcolumn = tourtransportid;
                    break;
                case "requestpage":
                    IDcolumn = requesttourid;
                    break;
                default:
                    MessageBox.Show("Ошибка выобра ID столбца combobox");
                    break;
            }
            return IDcolumn;
        }

        private DataGridViewComboBoxColumn getComboBoxColumnNameByTableName(string tabname)
        {
            DataGridViewComboBoxColumn IDcolumn = null;
            switch (tabname)
            {
                case "city":
                    IDcolumn = citycountryname;
                    break;
                case "hotel":
                    IDcolumn = hotelcityid;
                    break;
                case "tours":
                    IDcolumn = tourtransportid;
                    break;
                case "request":
                    IDcolumn = requesttourid;
                    break;
                default:
                    MessageBox.Show("Ошибка выобра ID столбца combobox");
                    break;
            }
            return IDcolumn;
        }

        private void allRefreshInTable()
        {
            string tablename = _misc.getNameTableByTabControlPageName(MainTabControl.SelectedTab.Name);
            try
            {
                if (_misc.checkTableNameForComboBox(tablename))
                {
                    DataGridViewComboBoxColumn comboBoxColumn = getComboBoxColumnNameByTableName(tablename);
                    _db.setItemsforComboBoxColumn(comboBoxColumn, _misc.getMasterTableNameByDependentTableName(tablename), "name");
                }

                _db.refreshTable(getDataGridViewByTableName(tablename), tablename);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении таблицы: {ex.Message}");
            }
        }

        public MainForm()
        { 
            InitializeComponent();
        }

        private List<string> tableNameForDataGridView = new List<string>
        {"city", "client", "hotel", "tours", "request", "countries", "transport"};

        private void MainForm_Load(object sender, EventArgs e)
        {
            statusChangeWindow = "";
            tempReference = "";
            tempDGW = null;
            foreach (string item in tableNameForDataGridView)
            {
                try
                { 
                    if (_misc.checkTableNameForComboBox(item))
                        _db.setItemsforComboBoxColumn(getComboBoxColumnNameByTableName(item),
                            _misc.getMasterTableNameByDependentTableName(item), "name");
                    _db.refreshTable(getDataGridViewByTableName(item), item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка(" + item + "): " + ex.Message);
                }
            }
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Изменение в рабочем поле
            DataGridView dgw = getDataGridViewByTabControlPage(MainTabControl.SelectedTab.Name);
            string tablename = _misc.getNameTableByTabControlPageName(MainTabControl.SelectedTab.Name);
            if (!(tablename == "tours" || tablename == "request"))
            {
                statuschange = changeStart("add");
            }
            else
            {
                switch (tablename)
                {
                    case "tours":
                        statusChangeWindow = "add";
                        new TourForm(this).ShowDialog();
                        _db.refreshTable(dgw, tablename);
                        break;
                    case "request":
                        statusChangeWindow = "add";
                        new RequestForm(this).ShowDialog();
                        _db.refreshTable(dgw, tablename);
                        break;
                    default:
                        MessageBox.Show("Неизвестная таблица");
                        break;
                }
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tablename = _misc.getNameTableByTabControlPageName(MainTabControl.SelectedTab.Name);
            try
            {
                if (_misc.checkTableNameForComboBox(tablename))
                {
                    DataGridViewComboBoxColumn comboBoxColumn = getComboBoxColumnNameByTableName(tablename);
                    _db.setItemsforComboBoxColumn(comboBoxColumn, _misc.getMasterTableNameByDependentTableName(tablename), "name");
                }
                _db.refreshTable(getDataGridViewByTableName(tablename), tablename);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении таблицы: {ex.Message}");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            changeEnd();
        }

        private void acсeptButton_Click(object sender, EventArgs e)
        {
            DataGridView dgw = getDataGridViewByTabControlPage(MainTabControl.SelectedTab.Name);
            string table = _misc.getNameTableByTabControlPageName(MainTabControl.SelectedTab.Name);
            DataGridView dgwBefore = new DataGridView();
            switch (statuschange)
            {
                case "add":
                    try
                    {
                        _db.addRows(table, dgw, countRowBefore);
                        changeEnd();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Неверный формат данных {ex.Message}");
                    } 
                break;
                case "del":
                    try
                    {
                        _db.deleteRows(table, dgw);
                        changeEnd();
                    }
                    catch
                    {
                        MessageBox.Show("Ничего не выбрано");
                        //MessageBox.Show($"Данные используються в другой таблице {ex.Message}");
                    }
                    break;
                case "upd":
                    try
                    {
                        dgwBefore = _db.getDataTableBefore(table,dgw.ColumnCount);
                        List<string> idsList = _misc.findIdByChangedItems(dgwBefore, dgw);
                        _db.selectChangedItemsAndUpdateThem(dgw, table, idsList);
                        changeEnd();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Невозможно обновить данные: {ex.Message}");
                    }
                    break;
                default:
                    MessageBox.Show("Ошибка при выборе действия");
                    break;
            }
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isChange == true)
                MainTabControl.SelectTab(current_tab_id);
            else
            {
                allRefreshInTable();
            }
        }

        private void delToolStripMenuitem_Click(object sender, EventArgs e)
        {
            statuschange = changeStart("del");
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgw = getDataGridViewByTabControlPage(MainTabControl.SelectedTab.Name);
            string tablename = _misc.getNameTableByTabControlPageName(MainTabControl.SelectedTab.Name);
            tempDGW = dgw;
            if (dgw.Rows.Count == 0)
            {
                MessageBox.Show("Нечего изменять");
            }
            else
            {
                if (!(tablename == "tours" || tablename == "request"))
                {
                    statuschange = changeStart("upd");
                }
                else
                {
                    switch (tablename)
                    {
                        case "tours":
                            //MessageBox.Show("В разработке");
                            statusChangeWindow = "upd";
                            new TourForm(this).ShowDialog();
                            _db.refreshTable(dgw, tablename);
                            break;
                        case "request":
                            statusChangeWindow = "upd";
                            new RequestForm(this).ShowDialog();
                            _db.refreshTable(dgw, tablename);
                            //MessageBox.Show("В разработке");
                            break;
                        default:
                            MessageBox.Show("Неизвестная таблица");
                            break;
                    }
                }
            }
        }

        private void searchContextTextBox_TextChanged(object sender, EventArgs e)
        {
            DataGridView dgw = getDataGridViewByTabControlPage(MainTabControl.SelectedTab.Name);
            string tablename = _misc.getNameTableByTabControlPageName(MainTabControl.SelectedTab.Name);
            _db.searchByContextMenu(dgw, tablename, contextSearchTextBox.Text);
        }

        //---TRASH CAN---//

        /*string fortablename = _ICDBAMF.getMasterTableNameByDependentTableName(tablename);
            DataGridViewTextBoxColumn idcolumn = getIDColumnByTabControlPage(MainTabControl.SelectedTab.Name);
            DataGridViewCheckBoxColumn deletecolumn = getCheckBoxColumnDeleteByTabControlPage(MainTabControl.SelectedTab.Name);
            changePanel.Visible = false;
            mainmenustrip.Enabled = true;
            MainTabControl.Enabled = true;
            dgw.AllowUserToAddRows = false;
            deletecolumn.Visible = false;
            idcolumn.Visible = true;
            isChange = false;
            MessageBox.Show(statuschange);

            if (statuschange == "add")
            {
                if (!(tablename == "tours" || tablename == "request"))
                {

                    //_db.addColumns(tablename,dgw,countRowBefore);
                    MessageBox.Show(dgw.Rows.Count.ToString() + " == " + countRowBefore.ToString());
                    List<string> columns;
                    columns = _db.getColumnsFromTable(tablename);
                    columns.RemoveAt(0);
                    string columnNames = _ICDBAMF.shacklesItems(columns);      
                    string columnName;  
                    string columnType;
                    string value;
                    string values = "";
                    for (int i = countRowBefore; i < dgw.Rows.Count; i++)
                    {  
                        values += "(";
                        for (int j = 1; j < dgw.ColumnCount - 1; j++)
                        {
                            columnName = columns[j - 1];
                            columnType = _db.getColumnTypeFromTable(tablename, columnName);
                            try
                            {
                                value = dgw.Rows[i].Cells[j].Value.ToString();
                                if (_ICDBAMF.checkColumnNameInComboBoxColumnNames(columnName))
                                {
                                    value = _db.getIdOnName(fortablename, value);
                                }
                                switch (columnType)
                                {
                                    case "int":
                                        break;
                                    case "nchar":
                                        value = "'" + value + "'";
                                        break;
                                    default:
                                        MessageBox.Show("Error");
                                        break;
                                }
                            }
                            catch
                            {
                                value = "ПУСТО";
                            }
                            values += value + ", ";
                        }
                        values = values.Remove(values.Length - 2);
                        values += "), ";
                        //MessageBox.Show($"Добавлена {(i + 1).ToString()} строка!");
                    }
                    values = values.Remove(values.Length - 2);
                    //MessageBox.Show($"insert into {tablename} {namescol} values {values}");
                    
                    
                    _db.insertInToTable(tablename, columnNames, values);
                }
                else if (tablename == "tours")
                {
                    MessageBox.Show(tablename + "Уникальное Добавление");
                }
                else if (tablename == "request")
                {
                    MessageBox.Show(tablename + "Уникальное Добавление");
                }
                else
                {
                    MessageBox.Show("Неизвестная таблица");
                }
                
            }
            else if (statuschange == "del")
            {
                _db.deleteRows(tablename, dgw);
            }
            else
            {
                MessageBox.Show("Ошибка выбора действий!");
            }
            statuschange = "";
            _db.RefTable(dgw , tablename);
            countRowBefore = 0;*/


        /*if (_comm.isComboBoxTable(tablename))
        {
            _db.getItemsforColumn(getComboBoxColumnNameFromTable(_comm.getForgenTable(tablename)), tablename, _comm.getForgenTable(tablename));
        }*/

        //tablename = getNameTable(MainTabControl.SelectedTab.Name);

        //MessageBox.Show("Ошибка при переходе на состаяние добавление!");
        // ++string tabname = MainTabControl.SelectedTab.Name
    }
}
