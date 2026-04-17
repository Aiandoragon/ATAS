using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ATAS
{
    public partial class AddRowTourForm : Form
    {
        MainForm MF;
        Misc _misc = new Misc();
        DataBase _db = new DataBase();
        private int unicId;
       

        public AddRowTourForm(MainForm owner)
        {
            MF = owner;
            InitializeComponent();
             
        }
        private void AddRowTourForm_Load(object sender, EventArgs e)
        {
            _db.setItemsforComboBox(transportComboBox, "transport", "name");
            _db.refreshTableCustom(dgvHotel, "hotel", "id, name");
            if (MF.statusChangeWindow == "add")
            {
                try
                {
                    unicId = 1 + Convert.ToInt32(_db.findTheOnlyOneRows("tours", "max(unic_tour_id)"));
                }
                catch
                {
                    unicId = 0;
                }
                //MessageBox.Show($"Новая запись с unic_id = {unicId}");
            }
            if (MF.statusChangeWindow == "upd")
            {
                acceptButton.Text = "Изменить";
                DataGridView dgw = MF.tempDGW;
                try
                {
                    string[] info = dgw.SelectedRows[0].Cells[3].Value.ToString().Split(',');
                    List<string> items = new List<string>();
                    for (int i = 0; i < info.Length; i++)
                    {
                        items.Add(info[i].Replace(" ", ""));
                    }
                    for (int i = 0; i < dgvHotel.RowCount; i++)
                    {
                        string item = dgvHotel.Rows[i].Cells[2].Value.ToString();
                        if (_misc.checkIteminItemList(items, item))
                        {
                            dgvHotel.Rows[i].Cells[0].Value = true;
                        }
                    }
                    unicId = Convert.ToInt32(dgw.SelectedRows[0].Cells[1].Value);
                    nameTourTextBox.Text = dgw.SelectedRows[0].Cells[2].Value.ToString();
                    transportComboBox.Text = dgw.SelectedRows[0].Cells[5].Value.ToString();
                    countDayTextBox.Text = dgw.SelectedRows[0].Cells[4].Value.ToString();
                    descriptonTourTextBox.Text = dgw.SelectedRows[0].Cells[6].Value.ToString();

                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            string table = "tours";
            List<string> checkedIdList = _misc.checkedItemsFromDGW(dgvHotel, 0, 1);
            List<string> list = _db.getColumnsFromTable(table);
            list.RemoveAt(0);
            string columns = _misc.shaklesString(_misc.convertListToString(list));
            //string columns = "";
            //string transportId = "";
            if (MF.statusChangeWindow == "add")
            {
                
            }
            if (MF.statusChangeWindow == "upd")
            {
                string ids = _misc.shaklesString(unicId.ToString());
                try
                {
                    _db.deleteSQLRow(table, ids, "unic_tour_id");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка на первом этапе изменения: {ex.Message}");
                }
            }
            string values = "";
            foreach (string id in checkedIdList)
            {
                string transportId = _db.getIdOnName(_misc.getMasterTableNameByDependentTableName(table), transportComboBox.Text);
                string name = nameTourTextBox.Text;
                string countDay = countDayTextBox.Text;
                string description = descriptonTourTextBox.Text;
                values += $"({unicId}, N'{name}', {id}, {countDay}, {transportId}, N'{description}')";
                values += ", ";
            }
            values = values.Remove(values.Length - 2);
            MessageBox.Show($"insert into {table} {columns} values {values}");
            //_db.insertInTable(table, columns, values);
            //MF.statusChangeWindow = "";
            //Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MF.statusChangeWindow = "";
            MF.tempDGW = null;
            Close();
        }

        private void transportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string transportId = _db.getIdOnName(_misc.getMasterTableNameByDependentTableName("tours"), transportComboBox.Text);
        }
    }
}
