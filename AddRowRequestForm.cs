using ATAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class AddRowRequestForm : Form
    {
        MainForm MF;
        Misc _misc = new Misc();
        DataBase _db = new DataBase();
        private int unicId;

        public AddRowRequestForm(MainForm owner)
        {
            MF = owner;
            InitializeComponent();   
        }

        private void addRowRequestForm_Load(object sender, EventArgs e)
        {
            _db.setItemsforComboBox(tourComboBox, "tours", "name");
            _db.refreshTableCustom(clientRequestGridView, "Client", "Id, name + ' ' + surname, passport");
            if (MF.statusChangeWindow == "add")
            {
                
                try
                {
                    unicId = 1 + Convert.ToInt32(_db.findTheOnlyOneRows("request", "max(unic_id)"));
                }
                catch
                {
                    unicId = 0;
                }
                acceptButton.Text = "Добавить";
            }
            if (MF.statusChangeWindow == "upd")
            {
                acceptButton.Text = "Изменить";
                DataGridView dgw = MF.tempDGW;
                try
                {
                    string[] info = dgw.SelectedRows[0].Cells[2].Value.ToString().Split('|');
                    List<string> passport = new List<string>();
                    for (int i = 0; i < info.Length; i++)
                    {
                        string[] tempInfo = info[i].Split(',');
                        passport.Add(tempInfo[1].Replace(" ",""));
                    }
                    for (int i = 0; i < clientRequestGridView.RowCount; i++) 
                    {
                        string item = clientRequestGridView.Rows[i].Cells[3].Value.ToString();
                        if (_misc.checkIteminItemList(passport, item))
                        {
                            //MessageBox.Show($"{i}");
                            clientRequestGridView.Rows[i].Cells[0].Value = true;
                        }
                    }
                    unicId = Convert.ToInt32(dgw.SelectedRows[0].Cells[1].Value.ToString());
                    tourComboBox.Text = dgw.SelectedRows[0].Cells[3].Value.ToString();
                    dateTimePickerStartTour.Value = Convert.ToDateTime(dgw.SelectedRows[0].Cells[4].Value);
                    dateTimePickerFinishTour.Value = Convert.ToDateTime(dgw.SelectedRows[0].Cells[5].Value);
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
            
        }


        private void cancelbutton_Click(object sender, EventArgs e)
        {
            MF.statusChangeWindow = "";
            MF.tempDGW = null;
            Close();  
        }


        private void acceptbutton_Click(object sender, EventArgs e)
        {
            string table = "request";
            string tourId = _db.getIdOnName("tours", tourComboBox.Text);
            string startDate = dateTimePickerStartTour.Value.ToShortDateString();
            string finishDate = dateTimePickerFinishTour.Value.ToShortDateString();
            int addIndex = _misc.getIndexByColumnName(clientRequestGridView, addClient);
            int IdIndex = _misc.getIndexByColumnName(clientRequestGridView, clientId);
            List<string> clientIds = _misc.checkedItemsFromDGW(clientRequestGridView, addIndex, IdIndex);
            List<string> list = _db.getColumnsFromTable(table);
            list.RemoveAt(0);
            string columns = _misc.shaklesString(_misc.convertListToString(list));
            foreach (string id in clientIds)
            {
                if (MF.statusChangeWindow == "add")
                {
                    string values = $"({unicId}, {id}, {tourId}, CONVERT(DATE, '{startDate}', 103), CONVERT(DATE,'{finishDate}', 103), null)";
                    try
                    {
                        _db.insertInTable(table, columns, values);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                        MessageBox.Show($"insert into {table} {columns} values {values}");
                    }
                }
                if (MF.statusChangeWindow == "upd")
                {
                    string ids = _misc.shaklesString(unicId.ToString());
                    _db.deleteSQLRow(table, ids, "unic_id");
                    string values = $"({unicId}, {id}, {tourId}, CONVERT(DATE, '{startDate}', 103), CONVERT(DATE,'{finishDate}', 103), null)";
                    try
                    {
                        _db.insertInTable(table, columns, values);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                        MessageBox.Show($"insert into {table} {columns} values {values}");
                    }
                    //MessageBox.Show(unicId.ToString());
                }
            }
            MF.statusChangeWindow = "";
            MF.tempDGW = null;
            Close();
        }
    }
}
