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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveProject
{
    public partial class CompanyProfile : Form
    {
        public CompanyProfile()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void logobtn_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dist_TextChanged(object sender, EventArgs e)
        {

        }

        private void state_TextChanged(object sender, EventArgs e)
        {

        }

        private void country_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact2_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void CompanyProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to cancel ?", "Close window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void CompanyProfile_KeyDown(object sender, KeyEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source = DESKTOP-OJR6FSL\\SQLEXPRESS; Initial Catalog = comcare; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("companypofilesp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@companyName", SqlDbType.NVarChar);
            param.Value = name.Text;
            cmd.Parameters.Add(param);
            cmd.Parameters.AddWithValue("@companyMobileNo", contact.Text);
            cmd.Parameters.AddWithValue("@companyContactNo", contact2.Text);
            cmd.Parameters.AddWithValue("@companyCountry", country.Text);
            cmd.Parameters.AddWithValue("@companyState", state.Text);
            cmd.Parameters.AddWithValue("@companyDist", dist.Text);
            cmd.Parameters.AddWithValue("@companyPS", ps.Text);
            cmd.Parameters.AddWithValue("@companyVillage", village.Text);
            cmd.Parameters.AddWithValue("@companyPINNO", pin.Text);
            cmd.Parameters.AddWithValue("@companyPANNO", pan.Text);
            cmd.Parameters.AddWithValue("@companyGSTNO", gstno.Text);
            cmd.Parameters.AddWithValue("@companyCINNO", cinno.Text);
            cmd.Parameters.AddWithValue("@companyLicenseNo", license.Text);
            cmd.Parameters.AddWithValue("@companyStateCode", statecode.Text);
            cmd.Parameters.AddWithValue("@companyEmailId", email.Text);
            cmd.Parameters.AddWithValue("@companyWebsite", website.Text);
            cmd.Parameters.AddWithValue("@companyTagLine", tagline.Text);

            MemoryStream ms = new MemoryStream(); // ram
            logo.Image.Save(ms,ImageFormat.Jpeg);
            byte[] pic_array = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(pic_array,0,pic_array.Length);
            
            cmd.Parameters.AddWithValue("@companyLogo", pic_array);
            cmd.Parameters.AddWithValue("@companyDLNO", dlno.Text);
            cmd.Parameters.AddWithValue("@companyFoodLicense", flicenseno.Text);
            cmd.Parameters.AddWithValue("@companyMFGLicenseNo", mfglicenseno.Text);
            cmd.Parameters.AddWithValue("@companyJurisdiction", jurisdiction.Text);

            try
            {
                if (name.Text != "" && contact.Text != "" && pin.Text != "" && pan.Text != "" && gstno.Text != "" && cinno.Text != "" && license.Text != "" && dlno.Text != "" )
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

        private void logobtn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Your Company Logo";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt" + "|" +
                                    "Image Files (*.png;*.jpg)|*.png;*.jpg" + "|" +
                                    "All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openDialog.FileName);
                logo.Image = Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("U Didn't Select any kind of file.");
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logo.Image = null;
            logo.Update();
        }
    }
}

