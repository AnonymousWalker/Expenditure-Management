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
    public partial class Form3 : Form
    {
        public delegate void Mydelg();
        public Mydelg refGetAllItems;
        private DataGridViewRow rowData;
        public Form3(DataGridViewRow rowdata)
        {
            InitializeComponent();
            this.rowData = rowdata;
            NameTxt.Text = rowdata.Cells[1].Value.ToString();
            CashTxt.Text = rowdata.Cells[2].Value.ToString();
            if (rowdata.Cells[3].Value.ToString() != "")
            {
                var dateValue = Convert.ToDateTime(rowdata.Cells[3].Value);
                dateTxt.Text = string.Format("{0}/{1}/{2}", dateValue.Day, dateValue.Month, dateValue.Year % 100);
            }
            noteTxt.Text = rowdata.Cells[4].Value.ToString();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTxt.Text) || string.IsNullOrEmpty(CashTxt.Text)
                || string.IsNullOrEmpty(dateTxt.Text))
                MessageBox.Show("The first 3 fields cannot be empty :v","Null Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                string Query = "UPDATE ExpenditureTable SET Item = '" + NameTxt.Text + "',Cash = '" + CashTxt.Text + "',[Date Purchase] = '" + dateTxt.Text + "',[Note] = '" + noteTxt.Text + "'WHERE ID = " + Convert.ToInt32(this.rowData.Cells[0].Value) + "";
                using (OleDbConnection conn = new OleDbConnection(Form1.connectionString))
                {
                    OleDbCommand cmd = new OleDbCommand(Query,conn);
                    conn.Open();
                    try
                    {
                        int check = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (check > 0)
                        {
                            MessageBox.Show("Sucessfully updated :D");
                            this.Close();
                        }
                        else MessageBox.Show("Error, please try again :(","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                refGetAllItems();
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void CashTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void dateTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void noteTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
