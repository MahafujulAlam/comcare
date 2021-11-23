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
    public partial class CurrencySetupNew : Form
    {
        public CurrencySetupNew()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CurrencySetupNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to cancel ?", "Close window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void CurrencySetupNew_KeyDown(object sender, KeyEventArgs e)
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

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-OJR6FSL\\SQLEXPRESS; Initial Catalog = comcare; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("currencysetupsp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@typename", name.Text);
            SqlParameter param = new SqlParameter("@currencyName", SqlDbType.NVarChar);
            param.Value = name.Text;
            cmd.Parameters.Add(param);
            cmd.Parameters.AddWithValue("@currencyStatus", status.Text);
            cmd.Parameters.AddWithValue("@currencyRemark", remark.Text);

            try
            {
                if (name.Text != "" && status.Text != "")
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data Inserted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        name.Text = "";                        
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
