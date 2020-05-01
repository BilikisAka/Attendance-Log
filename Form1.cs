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


namespace AdminCopy
{
    public partial class Form1 : Form
    {
        private OleDbConnection connect = new OleDbConnection();
       

        public Form1()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Bibi\\Documents\\Visual Studio 2017\RegForm.accdb;
Persist Security Info=False;";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                 connect.Open();

            conTxt.Text ="Connection Succesful";
            connect.Close();
                
            }
            catch (Exception er)
            {
                MessageBox.Show("Error" + er);
            }
        }
         
        private void lgBtn_Click(object sender, EventArgs e)
        {

            if (usTb.Text == "" || pwTb.Text == "")
            {

                recordLbl.Text = "Enter UserName and Password ";
               
                return;
            }
            else if (usTb.Text == "" || pwTb.Text == "{@}")
            {
                MessageBox.Show("Enter Details Please");
           
            }
            try
            {
                
                connect.Open();
            OleDbCommand cmd = new OleDbCommand();
          
            cmd.Connection = connect;
            cmd.CommandText = "insert into AdminLogIn (UserName, [Password]) values('" + usTb.Text + "','" + pwTb.Text + "')";
            cmd.ExecuteNonQuery();
           
            connect.Close();
                MessageBox.Show ("Record inserted");
            }

            catch (Exception er)
            {
                MessageBox.Show("Error" + er);
            }
            finally
            {
                connect.Close();
            }


            /*OleDbDataReader read  =  new OleDbDataReader;
            int log = 0;
            while (read.Read())
            {
                log = log + 1;
            }

            if (log == 1)*/
            {
               

                connect.Dispose();
                this.Hide();
                RegForm form2 = new RegForm();
                form2.ShowDialog();
            }
            

        }

    private void pwTb_TextChanged(object sender, EventArgs e)
        {
            pwTb.PasswordChar = '*';
            pwTb.MaxLength = 5;
        }

        private void pwTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 0)
            {
                e.Handled = true;
            }
        }

        private void usTb_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
    
}
