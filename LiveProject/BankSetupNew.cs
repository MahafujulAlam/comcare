using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiveProject
{
    public partial class BankSetupNew : Form
    {
        public BankSetupNew()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {           
                this.Close();
        
        }

        private void BankSetupNew_Load(object sender, EventArgs e)
        {

        }

        private void BankSetupNew_KeyDown(object sender, KeyEventArgs e)
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

        private void BankSetupNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to cancel ?", "Close window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-OJR6FSL\\SQLEXPRESS; Initial Catalog = comcare; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("banksetupsp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@typename", name.Text);
            SqlParameter param = new SqlParameter("@banksetupAccountName", SqlDbType.NVarChar);
            param.Value = name.Text;
            cmd.Parameters.Add(param);
            cmd.Parameters.AddWithValue("@banksetupAccountNo", acno.Text);
            cmd.Parameters.AddWithValue("@banksetupAccountType", actype.Text);
            cmd.Parameters.AddWithValue("@banksetupBankName", bankname.Text);
            cmd.Parameters.AddWithValue("@banksetupBranchName", branch.Text);
            cmd.Parameters.AddWithValue("@banksetupIFSCcode", ifsccode.Text);
            cmd.Parameters.AddWithValue("@banksetupMICRcode", micrcode.Text);
            cmd.Parameters.AddWithValue("@banksetupOpeningBalance", openingbal.Text);
            cmd.Parameters.AddWithValue("@banksetupAvailableBalance", avlbal.Text);
            cmd.Parameters.AddWithValue("@banksetupStatus", status.Text);
            cmd.Parameters.AddWithValue("@banksetupRemark", remark.Text);

            try
            {
                if (name.Text != "" && acno.Text != ""  && actype.Text != "" && avlbal.Text != "" && openingbal.Text != "" && bankname.Text != "" && micrcode.Text != "" && branch.Text != "" && ifsccode.Text != "" && status.Text != "")
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data Inserted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        name.Text = "";
                        acno.Text = "";
                        actype.Text = "";
                        bankname.Text = "";
                        branch.Text = "";
                        ifsccode.Text = "";
                        micrcode.Text = "";
                        openingbal.Text = "";
                        avlbal.Text = "";
                        status.Text = "";
                        remark.Text = "";

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
    }
}
