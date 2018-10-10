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

        void GetData(string query = null)
        {
            table = new DataTable();
            if (query == null) query = "Select * from ExpenditureTable order by [Date Purchase] desc";
            
            using (connection = new OleDbConnection())  //close connection when finish
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                adapter = new OleDbDataAdapter(query,connection);
                adapter.Fill(table);
                connection.Close();
            }
            dataGridView1.DataSource = table;
            double total = CalculateSum();
            double initial = double.Parse(InitialTxt.Text);
            SumTxt.Text = total.ToString();
            RemainedCash.Text = CalculateRemainer(initial,total).ToString();
        }

        private double CalculateSum()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[2].Value);
            }
            return Math.Round(sum,2);
        }

        private double CalculateRemainer(double initial, double total)
        {
            double remain = 0;
            remain = initial - total;
            return Math.Round(remain, 2);
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
                        int RowId = Convert.ToInt32(delrow.Cells[0].Value);
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

        private void RemainedCash_Click(object sender, EventArgs e)
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

        private void FilterByDateTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(FilterByDateTxt.Text))
                {
                    GetData();
                    return;
                }
                try
                {
                    //DateTime inputDate = Convert.ToDateTime(FilterByDateTxt.Text);
                    string query = "SELECT * FROM ExpenditureTable WHERE [Date Purchase]='" + FilterByDateTxt.Text +"'";
                    using (connection = new OleDbConnection())  //close connection when finish
                    {
                        connection.ConnectionString = connectionString;
                        connection.Open();
                        #region Check result
                        //OleDbCommand command = new OleDbCommand(query, connection);
                        //OleDbDataReader reader = command.ExecuteReader();

                        //while (reader.Read())
                        //{
                        //    string companyCode = reader.GetValue(0).ToString();
                        //    string agentId = reader.GetString(1);
                        //    string firstName = reader.GetString(2);
                        //    string lastName = reader.GetString(3);
                        //    string nameSuffix = reader.GetString(4);
                        //    string corporateName = reader.GetString(5);
                        //    string entityType = reader.GetString(6);
                        //    string obfSSN = reader.GetString(7);
                        //    string obfFEIN = reader.GetString(8);
                        //    string dummyIndicator = reader.GetString(9);
                        //    // Insert code to process data.
                        //}
                        //reader.Close();

                        #endregion
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
                GetData(query);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void InitialTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            try
            {
                double total = double.Parse(SumTxt.Text);
                double initial = double.Parse(InitialTxt.Text);
                RemainedCash.Text = CalculateRemainer(initial,total).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NameFilterTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (string.IsNullOrEmpty(NameFilterTxt.Text))
            {
                GetData();
                return;
            }
            try
            {
                string query = "SELECT * FROM ExpenditureTable WHERE [Item] like '%" + NameFilterTxt.Text + "%'";
                GetData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}