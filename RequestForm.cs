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
    public partial class RequestForm : Form
    {
        MainForm MF;
        Misc _misc = new Misc();
        DataBase _db = new DataBase();
        private int id_request;
        private int count_day;

        public RequestForm(MainForm owner)
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
                id_request = 1 + Convert.ToInt32(_db.findTheOnlyOneRows("request", "max(id)"));
                acceptButton.Text = "Добавить";
            }
            if (MF.statusChangeWindow == "upd")
            {
                acceptButton.Text = "Изменить";
                DataGridView dgw = MF.tempDGW;
                try
                {
                    string[] info = dgw.SelectedRows[0].Cells[1].Value.ToString().Split('|');
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
                    id_request = Convert.ToInt32(dgw.SelectedRows[0].Cells[0].Value.ToString());
                    tourComboBox.Text = dgw.SelectedRows[0].Cells[2].Value.ToString();
                    dateTimePickerStartTour.Value = Convert.ToDateTime(dgw.SelectedRows[0].Cells[3].Value);
                    dateTimePickerFinishTour.Value = Convert.ToDateTime(dgw.SelectedRows[0].Cells[4].Value);
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
            List<string> clientIds = _misc.checkedItemsFromDGW(clientRequestGridView, 0, 1);
            if (clientIds.Count > 0)
            {
                try
                {
                    string tourId = _db.getIdOnName("tours", tourComboBox.Text);
                    string startDate = dateTimePickerStartTour.Value.ToShortDateString();
                    string finishDate = dateTimePickerFinishTour.Value.ToShortDateString();
                    List<string> list = _db.getColumnsFromTable(table);
                    string columns = _misc.shaklesString(_misc.convertListToString(list));
                    string ids = _misc.shaklesString(id_request.ToString());
                    if (MF.statusChangeWindow == "upd")
                    {
                        _db.deleteDefaultRow(table, ids);
                    }
                    string values = $"({id_request}, {tourId}, CONVERT(DATE, '{startDate}', 103), CONVERT(DATE,'{finishDate}', 103), null)";
                    _db.insertInTable(table, columns, values);
                    foreach (string id in clientIds)
                    {
                        _db.insertInTable("client_request", "(id_client, id_request)", $"({id},{id_request})");
                    }
                    MF.statusChangeWindow = "";
                    MF.tempDGW = null;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неверный ввод данных: "  + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Выберите хотя бы одного клиента");
            }
        }

        private void tourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            count_day = Convert.ToInt32(_db.getSQLrequest($"select count_day from tours where name = N'{tourComboBox.Text}'"));
            dateTimePickerFinishTour.Value = dateTimePickerStartTour.Value.AddDays(count_day);
            //1
            //select count_day from tours where name = name
            //2
            //select id from tours where name = name
            //select count_day from whre id = id
        }

        private void dateTimePickerStartTour_ValueChanged(object sender, EventArgs e)
        {
            count_day = Convert.ToInt32(_db.getSQLrequest($"select count_day from tours where name = N'{tourComboBox.Text}'"));
            dateTimePickerFinishTour.Value = dateTimePickerStartTour.Value.AddDays(count_day);
        }
    }
}
