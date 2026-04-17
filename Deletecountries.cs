using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ATAS
{
    public partial class Deletecountries : Form
    {
        MainForm MF;
        private SqlConnection sqlConnection;
        private string table;
        DataBase db = new DataBase();
        public Deletecountries(MainForm owner)
        {
            MF = owner;
            table = "Countries";
            InitializeComponent();
            
        }

        private void Deletecountries_Load(object sender, EventArgs e)
        {


            //this.сountriesTableAdapter.Fill(this.dBATASDataSet.Сountries);
            /*sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionPath"].ConnectionString);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Сountries", sqlConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            deleteGridView.DataSource = ds.Tables[0];

            sqlConnection.Close();*/

            /*db.refreshTable("Countries", deleteGridView.DataSource);*/
            
            
            db.openConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Countries", db.getSqlConnection());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            deleteGridView.DataSource = ds.Tables[0];

            db.closeConnection();

            /*SqlDataReader dataReader = null;

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Сountries", sqlConnection);

                dataReader = command.ExecuteReader();

                deletelistcountries.Items.Clear();

                while (dataReader.Read())
                {
                    deletelistcountries.Items.Add(Convert.ToString(dataReader["id"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                if (dataReader != null && !dataReader.IsClosed) 
                {
                    dataReader.Close();
                }
            }
            sqlConnection.Close();*/

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            db.deleteRows(table, deleteGridView);
            //MF.countriesGridView.DataSource = db.refreshTable(table);
            /*string ids = "(";
            for (int i = 0; i < deleteGridView.Rows.Count; i++)
            {
                if (Convert.ToBoolean(deleteGridView.Rows[i].Cells[3].Value) == true)
                {
                    ids += deleteGridView.Rows[i].Cells[0].Value.ToString() + ",";
                }
            }
            ids = ids.Remove(ids.Length - 1);
            ids += ")";
            if (ids == ")")
            {
                MessageBox.Show("Ничего не выбрано");
            }
            else
            {
                /*sqlConnection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Сountries WHERE id in " + ids, sqlConnection);
                command.ExecuteNonQuery();


                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Сountries", sqlConnection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                MF.countriestablegridview.DataSource = ds.Tables[0];
                sqlConnection.Close();

                Close();*/

            /*db.openConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Countries WHERE id in " + ids, db.getSqlConnection());
            command.ExecuteNonQuery();


            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Countries", db.getSqlConnection());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            MF.countriestablegridview.DataSource = ds.Tables[0];
            db.closeConnection();


        }*/
            Close();

            /*if (deletelistcountries.CheckedItems.Count == 0)
            {
                string ids = "(";
                for (int i = 0; i < deleteGridView.Rows.Count; i++)
                {
                    if (Convert.ToBoolean( deleteGridView.Rows[i].Cells[3].Value) == true) 
                    {
                        ids += deleteGridView.Rows[i].Cells[0].Value.ToString() + ",";
                    }
                }
                ids = ids.Remove(ids.Length - 1);
                ids += ")";
                if (ids == ")")
                {
                    MessageBox.Show("Ничего не выбрано");
                }


            }
            else
            {
                sqlConnection.Open();
                string buf = "(";
                foreach (var item in deletelistcountries.CheckedItems)
                {
                    buf += item.ToString() + ",";
                }
                buf = buf.Remove(buf.Length - 1);
                buf += ")";
                SqlCommand command = new SqlCommand("DELETE FROM Сountries WHERE id in " + buf, sqlConnection);
                command.ExecuteNonQuery();


                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Сountries", sqlConnection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                MF.countriestablegridview.DataSource = ds.Tables[0];
                sqlConnection.Close();

                Close();*/

        }
    }
}
