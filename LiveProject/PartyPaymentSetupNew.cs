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
    public partial class PartyPaymentSetupNew : Form
    {
        public PartyPaymentSetupNew()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
           
                this.Close();
            
        }

        private void PartyPaymentSetupNew_KeyDown(object sender, KeyEventArgs e)
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

        private void PartyPaymentSetupNew_FormClosing(object sender, FormClosingEventArgs e)
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
            SqlCommand cmd = new SqlCommand("partypaymentsetupsp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@typename", name.Text);
            SqlParameter param = new SqlParameter("@partypaymentsetupPartyId", SqlDbType.NVarChar);
            param.Value = partyid.Text;
            cmd.Parameters.Add(param);
            cmd.Parameters.AddWithValue("@partypaymentsetupPartyName", partyname.Text);
            cmd.Parameters.AddWithValue("@partypaymentsetupPaymentMode", paymentmode.Text);
            cmd.Parameters.AddWithValue("@partypaymentsetupPaymentBy", paymentby.Text);
            cmd.Parameters.AddWithValue("@partypaymentsetupAccountNo", accno.Text);
            cmd.Parameters.AddWithValue("@partypaymentsetupBankName", bankname.Text);
            cmd.Parameters.AddWithValue("@partypaymentsetupBranchName", branch.Text);
            cmd.Parameters.AddWithValue("@partypaymentsetupIFSCCode", ifsccode.Text);
            cmd.Parameters.AddWithValue("@partypaymentsetupMICRCODE", micrcode.Text);
            cmd.Parameters.AddWithValue("@partypaymentsetupStatus", status.Text);
            cmd.Parameters.AddWithValue("@partypaymentsetupRemark", remark.Text);

            try
            {
                if (partyid.Text != "" && partyname.Text != "" && paymentmode.Text != "" && paymentby.Text != "" && accno.Text != "" && bankname.Text != "" && micrcode.Text != "" && branch.Text != "" && ifsccode.Text != "" && status.Text != "")
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data Inserted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        partyid.Text = "";
                        partyname.Text = "";
                        paymentmode.Text = "";
                        bankname.Text = "";
                        branch.Text = "";
                        ifsccode.Text = "";
                        micrcode.Text = "";
                        paymentby.Text = "";
                        accno.Text = "";
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
