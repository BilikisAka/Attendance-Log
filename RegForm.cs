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
using System.IO;
using System.Runtime.InteropServices;



namespace AdminCopy
{
    public partial class RegForm : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        int count = 0;
        

        public RegForm()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Bibi\\Documents\\Visual Studio 2017\RegForm.accdb;
Persist Security Info=False;";
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'regFormDataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.regFormDataSet.Attendance);
            // TODO: This line of code loads data into the 'regFormDataSet.Attendance' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'regFormDataSet.AdminLogIn' table. You can move, or remove it, as needed.

            try
            {

                connect.Open();
                MessageBox.Show("Connection Successful");

                connect.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error" + er);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tPage2_Click(object sender, EventArgs e)
        {
           /* nameTxt2.Text = RegForm.setValueFornameLbl;
            matTxt2.Text = RegForm.setValueFormatLbl;
            lvlTb.Text = RegForm.setValueFornamelvlLb;*/
        }

        private void lvlLb_Click(object sender, EventArgs e)
        {
            lvlLb.Text = "";
        }

        private void fingerBtn_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();

            byte[] photo_aray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo_aray, 0, photo_aray.Length);
            /*if (!IsRegister)
            {
                IsRegister = true;
                RegisterCount = 0;
                cbRegTmp = 0;
                textTips.Text = "将手指放在指纹感应器上,使用同一手指的不同区块重复3次此操作，直到指纹成功录入";
            }*/
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
           /* setValueFornameLbl = nameTxt.Text;
         setValueFormatLbl = matTxt.Text;
         setValueFornamelvlLb = lvlTb.Text;
        setValueFornamegderLbl = lvlGe.Text;
        setValueFornamedeptLvl = lvlDept.Text;
         setValueFornamepareLbl = ppnTxt.Text;
         setValueFornameparentLbl = peTxt.Text;*/
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                cmd.CommandText = "INSERT INTO Regform  ( S_Name, Matric, [Level],Gender,Department, ParentNo,ParentEmail,[Image]) VALUES ('" + nameTxt.Text + "','" + matTxt.Text + "','" + lvlCb.Text + "','" + lvlGe.Text + "','" + lvlDept.Text + "','" + ppnTxt.Text + "','" + peTxt.Text + "','" + pBox1.Text + "')";
           
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Record inserted");

                //,[Image] ,'" + pBox1.Text + "'
            }

            catch (Exception er)
            {
                MessageBox.Show("Error" + er);
            }
            finally
            {
                connect.Close();
            }
           
        }

        private void spnTxt_TextChanged(object sender, EventArgs e)
        {
            ppnTxt.MaxLength = 11;
        }

        private void ppnTxt_TextChanged(object sender, EventArgs e)
        {
            peTxt.MaxLength = 11;
        }

        private void imgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            //"jpg| *.jpg";
            DialogResult result = openFD.ShowDialog();
            if (result == DialogResult.OK)
            {
                pBox1.Image = Image.FromFile(openFD.FileName);
            }
            MemoryStream ms = new MemoryStream();
            
            byte[] photo_aray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo_aray, 0, photo_aray.Length);
        }

        private void pBox1_Click(object sender, EventArgs e)
        {

           pBox1.Image = Image.FromFile("‪");
           
            pBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void matTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void matTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 0 && !char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void matTxt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 0 && !char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        

        private void lgBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MAS-SALAM.\n YOU HAVE SUCCESSFULLY LOGGED OUT");
            this.Close();
        }

        
       /* public static string setValueFornameLbl = "";
        public static string setValueFormatLbl = "";
        public static string setValueFornamelvlLb = "";
        public static string setValueFornamegderLbl = "";
        public static string setValueFornamedeptLvl = "";
        public static string setValueFornamepareLbl = "";
        public static string setValueFornameparentLbl = "";*/

        private void tPage1_Click(object sender, EventArgs e)
        {
            connect.Open();
            OleDbCommand cmd = new OleDbCommand();
            
            connect.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                cmd.CommandText = "INSERT INTO Attendance  (S_Name, Matric, [Level], Course, Status, AttDate,Finger)VALUES('" + nameTxt2.Text + "','" + matTxt2.Text + "','" + lvlTb.Text + "','" + courseTb.Text + "','" + statsTxt +"','" + dtPicker.Text + "','" + fingerBox.Text + "')";

                cmd.ExecuteNonQuery();
                connect.Close();
                RecLbl.Text = " Record inserted";

            }

            catch (Exception er)
            {
               // MessageBox.Show(er.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
               // attendanceBindingSource.ResetBindings(false);
            }
            finally
            {
                connect.Close();
            }
            //this.Close();
        }

        private void fingerBox_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged_1(object sender, EventArgs e)
        {
            count = 0;
            connect.Open();
            OleDbCommand cmd = connect.CreateCommand();
            cmd.CommandText = "Select from Attendance where S_Name = '" + nameTxt2.Text + "'and  Matric = '" + matTxt2.Text + "' and Course = '" + courseTb.Text + "' and [Level] = '" + lvlTb.Text + "'and Present = '"+ statsTxt.Text + "' and Date = '" + dtPicker.Text + "' and Finger = '" + fingerBox.Text + "'";

            DataTable dataT = new DataTable();
            OleDbDataAdapter dataAd = new OleDbDataAdapter(cmd);
            dataAd.Fill(dataT);
           // count = Convert.ToInt32(dataT.Rows.Count.ToString());
            //dataGridView1.DataSource = dataT;
        }

        private void searchLbl_Click(object sender, EventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            connect.Open();
            OleDbCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select * from Attendance";

            cmd.ExecuteReader();
            DataTable dataT = new DataTable();
            OleDbDataAdapter dataAd = new OleDbDataAdapter(cmd);
            dataAd.Fill(dataT);
            dataGridView1.DataSource = dataT;

            connect.Close();
        }


        private void deleBtn_Click(object sender, EventArgs e)
        {
            connect.Open();
            OleDbCommand cmd = connect.CreateCommand();
            cmd.CommandText = "Delete from Attendance  where S_Name = '" + nameTxt2.Text + "'and  Matric = '" + matTxt2.Text + "' and Course = '" + courseTb.Text + "' and [Level] = '" + lvlTb.Text + "' and Finger = '" + fingerBox.Text + "'";

            //cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted successfully");
            DataTable dataT = new DataTable();
            OleDbDataAdapter dataAd = new OleDbDataAdapter(cmd);
            dataAd.Fill(dataT);
            dataGridView1.DataSource = dataT;

            connect.Close();
        }

        private void courseTb_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void courseTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 0 && !char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }
        int i;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*i = dataGridView1.SelectedCells[0].RowIndex;
            nameTxt2.Text = dataGridView1.Rows[i].Cells[0].Value.ToString() ;
            matTxt2.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            lvlTb.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
           courseTb.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            fingerBox.Image = (Image)dataGridView1.Rows[i].Cells[4].Value;*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged_2(object sender, EventArgs e)
        {

        }

   
    }
        }
