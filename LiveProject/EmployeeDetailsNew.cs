using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiveProject
{
    public partial class EmployeeDetailsNew : Form
    {
        public EmployeeDetailsNew()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
           
                this.Close();
           
        }

        private void EmployeeDetailsNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to cancel ?", "Close window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void EmployeeDetailsNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-OJR6FSL\\SQLEXPRESS; Initial Catalog = comcare; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("employeedetailssp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@employeedetailsEmployeeID", SqlDbType.NVarChar);
            param.Value = empid.Text;
            cmd.Parameters.Add(param);
            cmd.Parameters.AddWithValue("@employeedetailsEmployeeName", empname.Text);
            cmd.Parameters.AddWithValue("@employeedetailsEmployeeFaterName", empfname.Text);
            string strdt = dob.Value.ToShortDateString();
            char[] chsep = { '-' };
            string[] strsep = strdt.Split(chsep);
            string strdt2 = strsep[2] + '-' + strsep[1] + '-' + strsep[0];

            cmd.Parameters.AddWithValue("@employeedetailsDOB", strdt2);
            cmd.Parameters.AddWithValue("@employeedetailsSex", sex.Text);
            cmd.Parameters.AddWithValue("@employeedetailsQualification", qualification.Text);
            cmd.Parameters.AddWithValue("@employeedetailsBloodGroup", bloodgroup.Text);
            cmd.Parameters.AddWithValue("@employeedetailsAddress", address.Text);
            cmd.Parameters.AddWithValue("@employeedetailsMobileNo", mobno.Text);
            cmd.Parameters.AddWithValue("@employeedetailsContactNo", contact.Text);

            string dateofjoining = dateofjoin.Value.ToShortDateString();
            char[] sep = { '-' };
            string[] datesep = dateofjoining.Split(sep);
            string dateofjoining2 = datesep[2] + '-' + datesep[1] + '-' + datesep[0];

            cmd.Parameters.AddWithValue("@employeedetailsDateOfJoining", dateofjoining2);

            MemoryStream ms = new MemoryStream(); //ram
            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] pic_array = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(pic_array,0, pic_array.Length);
            cmd.Parameters.AddWithValue("@employeedetailsPhoto", pic_array);
            cmd.Parameters.AddWithValue("@employeedetailsDesignation", designation.Text);
            cmd.Parameters.AddWithValue("@employeedetailsRemark", remark.Text);       
            //MemoryStream ms = new MemoryStream(); // ram
            //logo.Image.Save(ms, ImageFormat.Jpeg);
            //byte[] pic_array = new byte[ms.Length];
            //ms.Position = 0;
            //ms.Read(pic_array, 0, pic_array.Length);          

            try
            {
                if (empid.Text != "" && empname.Text != "" && empfname.Text != "" && dob.Text != "" && sex.Text != "" && qualification.Text != "" && mobno.Text != "" && designation.Text != "")
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data Inserted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                    else
                    {
                        MessageBox.Show("Try Again");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the mandatory details!");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
        }

        private void logobtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Your Company Logo";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt" + "|" +
                                    "Image Files (*.png;*.jpg)|*.png;*.jpg" + "|" +
                                    "All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openDialog.FileName);
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("U Didn't Select any kind of file.");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Update();
        }
    }
}
