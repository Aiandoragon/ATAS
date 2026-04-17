using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATAS
{
    internal class Misc
    {
        public string getDependentTableNameByMasterTableName(string tabname)
        {
            string name = null;
            switch (tabname)
            {
                case "countries":
                    name = "city";
                    break;
                case "city":
                    name = "hotel";
                    break;
                case "transport":
                    name = "tours";
                    break;
                case "tours":
                    name = "request";
                    break;
                default:
                    MessageBox.Show("Ошибка выбора зависимого города по названию главного");
                    break;
            }
            return name;
        }

        public string getMasterTableNameByDependentTableName(string table)
        {
            string name = null;
            switch (table)
            {
                case "city":
                    name = "countries";
                    break;
                case "hotel":
                    name = "city";
                    break;
                case "tours":
                    name = "transport";
                    break;
                case "request":
                    name = "tours";
                    break;
                default:
                    MessageBox.Show("Ошбика выбора главного города по названию зависимого");
                    break;
            }
            return name;
        }

        public string getSeondMasterTableNameByDependentTableName(string tabname)
        {
            string name = null;
            switch (tabname)
            {
                case "tours":
                    name = "hotel";
                    break;
                case "request":
                    name = "client";
                    break;
                default:
                    MessageBox.Show("Ошбика выбора главного города(2) по названию зависимого");
                    break;
            }
            return name;
        }

        public string getForiegnColumnInMasterTableName(string tabname)
        {
            string name = null;
            switch (tabname)
            {
                case "city":
                    name = "country_id";
                    break;
                case "hotel":
                    name = "city_id";
                    break;
                case "tours":
                    name = "transport_id";
                    break;
                case "request":
                    name = "tours_id";
                    break;
                default:
                    MessageBox.Show("Ошбика выбора зависимого города");
                    break;
            }
            return name;
        }

        public bool checkColumnNameInComboBoxColumnNames(string name)
        {
            List<string> names = new List<string>()
            {"city_id" , "country_id", "transport_id", "tour_id"};
            if (names.FindIndex(x => x == name) == -1) return false;
            else return true;
        }

        public bool checkTableNameForComboBox(string name)
        {
            List<string> names = new List<string>()
            {"city" , "hotel", "tours", "request"};
            if (names.FindIndex(x => x == name) == -1) return false;
            else return true;
        }

        public bool checkTableNameInTwoJoin(string name)
        {
            List<string> names = new List<string>()
            {"tours", "request"};
            if (names.FindIndex(x => x == name) == -1) return false;
            else return true;
        }

        public string getIdsForDelete (DataGridView dgw)
        {
            int lastColumnId = dgw.ColumnCount - 1;
            string ids = "(";
            for (int i = 0; i < dgw.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgw.Rows[i].Cells[lastColumnId].Value) == true)
                {
                    ids += dgw.Rows[i].Cells[0].Value.ToString() + ",";
                }
            }
            ids = ids.Remove(ids.Length - 1);
            ids += ")";
            return ids;
        }


        public bool checkIteminItemList(List<string> itemList, string item)
        {
            if (itemList.FindIndex(x => x == item) == -1) return false;
            else return true;
        }

        public string getNameTableByTabControlPageName(string tabname)
        {
            string name = null;
            switch (tabname)
            {
                case "countriespage":
                    name = "countries";
                    break;
                case "citypage":
                    name = "city";
                    break;
                case "hotelpage":
                    name = "hotel";
                    break;
                case "transportpage":
                    name = "transport";
                    break;
                case "tourpage":
                    name = "tours";
                    break;
                case "clientpage":
                    name = "client";
                    break;
                case "requestpage":
                    name = "request";
                    break;
                default:
                    MessageBox.Show("Ошибка выбора таблицы");
                    break;
            }
            return name;
        }

        public string convertListToString(List<string> items)
        {
            string stringItems = "";
            foreach (string s in items) stringItems += s + ", ";
            stringItems = stringItems.Remove(stringItems.Length - 2);
            return stringItems;
        }

        public string shaklesString(string str)
        {
            return "(" + str + ")";
        }

        public void clearPlaceHolderByTextBox(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        public void setPlaceHolderByTextBoxLeave(TextBox textBox, string placeholder)
        {
            if (textBox.Text == "")
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        public List<string> checkedItemsFromDGW(DataGridView dgw, int check, int item)
        {
            try
            {
                List<string> ids = new List<string>();
                int countChecked = 0;
                for (int i = 0; i < dgw.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgw.Rows[i].Cells[check].Value) == true)
                    {
                        ids.Add(dgw.Rows[i].Cells[item].Value.ToString());
                        countChecked++;
                    }
                }
                return ids;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ничего не выбрано :" + ex.Message);
                return null;
            }
        }

        public List<string> findIdByChangedItems (DataGridView dgwBefore, DataGridView dgw) 
        {
            List<string> Ids = new List<string>();
            int columnCount = dgw.ColumnCount - 1;
            int rowCount = dgw.Rows.Count;
            int status = 0;
            for (int i = 0; i < rowCount; i++)
            {             
                for (int j = 1; j < columnCount; j++)
                {
                    
                    if (dgwBefore.Rows[i].Cells[j].Value.ToString() != dgw.Rows[i].Cells[j].Value.ToString())
                    {
                        //MessageBox.Show($"{dgwBefore.Rows[i].Cells[j].Value} != {dgw.Rows[i].Cells[j].Value}");
                        status = 1;
                    }
                        
                }
                
                if (status == 1) 
                {
                    Ids.Add(dgw.Rows[i].Cells[0].Value.ToString());
                    //MessageBox.Show($"Id = {dgw.Rows[i].Cells[0].Value}"); 
                }
                status = 0;   
            }
            return Ids;
        }

        public int getIndexByColumnName(DataGridView dgw, DataGridViewColumn columnName)
        {
            int index = dgw.Columns.IndexOf(columnName);
            return index;
        }
        
    }
}
