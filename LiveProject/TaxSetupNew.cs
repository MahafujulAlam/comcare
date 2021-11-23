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
    public partial class TaxSetupNew : Form
    {
        public TaxSetupNew()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaxSetupNew_KeyDown(object sender, KeyEventArgs e)
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

        private void TaxSetupNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel ?", "Close window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-OJR6FSL\\SQLEXPRESS; Initial Catalog = comcare; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("taxsetupsp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@typename", name.Text);
            SqlParameter param = new SqlParameter("@taxName", SqlDbType.NVarChar);
            param.Value = name.Text;
            cmd.Parameters.Add(param);
            cmd.Parameters.AddWithValue("@taxRate", rate.Text);
            cmd.Parameters.AddWithValue("@taxStatus", status.Text);
            cmd.Parameters.AddWithValue("@taxRemark", remark.Text);

            try
            {
                if (name.Text != "" && rate.Text != "" && status.Text != "")
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data Inserted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        name.Text = "";
                        rate.Text = "";
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
