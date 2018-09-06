using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Expenditure_Management
{
    public partial class Form1 : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter adapter;
        DataTable table;
        public static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|AppData.accdb";
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView1.RowHeadersDefaultCellStyle.Font = new Font("Calibri", 11);
        }

        void GetData()
        {
            table = new DataTable();
            string query = "Select * from ExpenditureTable order by [Date Purchase] desc";

            using (connection = new OleDbConnection())  //close connection when finish
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                adapter = new OleDbDataAdapter(query,connection);
                    //DataSet ds = new DataSet();
                    //adapter.Fill(ds);
                adapter.Fill(table);
                connection.Close();
            }
            dataGridView1.DataSource = table;
            SumTxt.Text = "$" + CalculateSum().ToString();
        }

        private double CalculateSum()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Width = 100;

            dataGridView1.Columns[2].DefaultCellStyle.Format = "0.00";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";

            dataGridView1.Columns[0].Visible = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.refGetAllItems = new Form2.Mydelg(GetData);
            form2.ShowDialog(this);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Equals(null)||dataGridView1.RowCount==0)
                MessageBox.Show("Please select an item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                DataGridViewRow rowData = dataGridView1.SelectedRows[0];
                Form3 form3 = new Form3(rowData);
                form3.refGetAllItems = new Form3.Mydelg(GetData);
                form3.ShowDialog(this);
            }
            
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Equals(null) || dataGridView1.RowCount == 0) MessageBox.Show("Please select an item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            int checkDel = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            { 
                using (connection = new OleDbConnection(Form1.connectionString))
                {
                    OleDbCommand cmd = new OleDbCommand();
                    DataGridViewRow delrow = dataGridView1.Rows[i]; //point to a row
                    while (delrow.Selected == true)
                    {
                        int RowId = Convert.ToInt32(delrow.Cells[0].Value);//Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        dataGridView1.Rows.RemoveAt(i);
                        try
                        {
                            cmd.CommandText = "DELETE FROM ExpenditureTable WHERE [ID]=" + RowId + ""; //here 
                            cmd.Connection = connection;
                            connection.Open();
                            checkDel = cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }
            }
            if (checkDel > 0)
            {
                this.GetData();
            }
            else if (dataGridView1.SelectedRows.Equals(null)) MessageBox.Show("Not removed :v", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            GetData();
        }
        

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void FilterByDateTxt_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FilterByMonthTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (string.IsNullOrEmpty(FilterByMonthTxt.Text))
            {
                GetData();
                return;
            }
            try
            {
                string query = "select * from ExpenditureTable where MONTH([Date Purchase]) = " + Convert.ToInt32(FilterByMonthTxt.Text);
                using (connection = new OleDbConnection())  //close connection when finish
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    adapter = new OleDbDataAdapter(query, connection);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connection.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

    }
}