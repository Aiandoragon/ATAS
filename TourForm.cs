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
using ATAS;

namespace ATAS
{
    public partial class TourForm : Form
    {
        MainForm MF;
        Misc _misc = new Misc();
        DataBase _db = new DataBase();
        private int tour_id;
       

        public TourForm(MainForm owner)
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
                tour_id = 1 + Convert.ToInt32(_db.findTheOnlyOneRows("tours", "max(id)"));
                //MessageBox.Show($"Новая запись с unic_id = {unicId}");
            }
            if (MF.statusChangeWindow == "upd")
            {
                acceptButton.Text = "Изменить";
                DataGridView dgw = MF.tempDGW;
                try
                {
                    string[] info = dgw.SelectedRows[0].Cells[2].Value.ToString().Split(',');
                    List<string> items = new List<string>();
                    for (int i = 0; i < info.Length; i++)
                    {
                        items.Add(info[i].Trim());
                    }
                    for (int i = 0; i < dgvHotel.RowCount; i++)
                    {
                        string item = dgvHotel.Rows[i].Cells[2].Value.ToString();
                        if (_misc.checkIteminItemList(items, item))
                        {
                            dgvHotel.Rows[i].Cells[0].Value = true;
                        }
                    }
                    tour_id = Convert.ToInt32(dgw.SelectedRows[0].Cells[0].Value);
                    nameTourTextBox.Text = dgw.SelectedRows[0].Cells[1].Value.ToString();
                    transportComboBox.Text = dgw.SelectedRows[0].Cells[4].Value.ToString();
                    countDayTextBox.Text = dgw.SelectedRows[0].Cells[3].Value.ToString();
                    descriptonTourTextBox.Text = dgw.SelectedRows[0].Cells[5].Value.ToString();

                }
                catch
                {
                    MessageBox.Show("Ошибка с получением данных из DGW");
                }
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            string table = "tours";
            List<string> checkedIdList = _misc.checkedItemsFromDGW(dgvHotel, 0, 1);
            if (checkedIdList.Count > 0)
            {
                try
                {
                    List<string> list = _db.getColumnsFromTable(table);
                    string columns = _misc.shaklesString(_misc.convertListToString(list));
                    string transportId = _db.getIdOnName(_misc.getMasterTableNameByDependentTableName(table), transportComboBox.Text);
                    string name = nameTourTextBox.Text;
                    string countDay = countDayTextBox.Text;
                    string description = descriptonTourTextBox.Text;
                    if (MF.statusChangeWindow == "upd")
                    {
                        try
                        {
                            _db.deleteDefaultRow(table, $"({tour_id})");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка на первом этапе изменения: {ex.Message}");
                        }
                    }
                    string values = $"({tour_id}, N'{name}', {countDay}, {transportId}, N'{description}')";
                    _db.insertInTable(table, columns, values);
                    foreach (string id in checkedIdList)
                    {
                        _db.insertInTable("hotel_tours", "(id_tour, id_hotel)", $"({tour_id},{id})");
                    }
                    MF.tempDGW = null;
                    MF.statusChangeWindow = "";
                    Close();
                }
                catch ( Exception ex )
                {
                    MessageBox.Show("Неверный ввод данных: " + ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("Выберите хотя бы один отель");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MF.statusChangeWindow = "";
            MF.tempDGW = null;
            Close();
        }

        private void transportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string transportId = _db.getIdOnName(_misc.getMasterTableNameByDependentTableName("tours"), transportComboBox.Text);
        }
    }
}
