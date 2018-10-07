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
    public partial class Form2 : Form
    {
        public delegate void Mydelg(string query = null);
        public Mydelg refGetAllItems;
        string query;
        public Form2()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ItemNameBox.Text) || string.IsNullOrEmpty(PayBox.Text))
                MessageBox.Show("The first 2 fields cannot be empty :v", "Null Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                    if(string.IsNullOrEmpty(DateBox.Text)) DateBox.Text= DateTime.Today.ToShortDateString();
                //try
                    string query = "Insert into ExpenditureTable (Item,Cash,[Date Purchase],[Note]) values (@item,@cash,@date,@note)";

                    using (OleDbConnection conn = new OleDbConnection(Form1.connectionString))
                    {
                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        conn.Open();
                        cmd.Parameters.Add("@item", OleDbType.VarChar, 30).Value = ItemNameBox.Text;
                        cmd.Parameters.Add("@cash", OleDbType.Double, 10).Value = PayBox.Text;
                        cmd.Parameters.Add("@date", OleDbType.Date, 20).Value = DateBox.Text;
                        cmd.Parameters.Add("@item", OleDbType.VarChar, 50).Value =  noteTxt.Text;
                        
                        int check = cmd.ExecuteNonQuery(); //execute cmd
                        conn.Close();
                        if (check > 0)
                        {
                            this.refGetAllItems();
                            this.Close();
                        }
                        else MessageBox.Show("Not inserted :v", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                //}
                //catch (Exception ex)
                //{
                //    //MessageBox.Show(ex.Message, "Message",MessageBoxButtons.OK , MessageBoxIcon.Error);
                //    //MessageBox.Show("Invalid input","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //}
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            ItemNameBox.Text = "";
            PayBox.Text = "";
            DateBox.Text = "";
            noteTxt.Text = "";
            ItemNameBox.Focus();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void PayBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void DateBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void noteTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void noteTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Datelb_Click(object sender, EventArgs e)
        {

        }

        private void DateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Notelb_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void dateInstr_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
