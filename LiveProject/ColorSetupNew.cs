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
    public partial class ColorSetupNew : Form
    {
        //private ColorSetup colorSetup;
        public ColorSetupNew()
        {
            InitializeComponent();
            //this.colorSetup = colorSetup;
        }

        private void ColorADD_Load(object sender, EventArgs e)
        {
            //colorSetup.Visible = false;
        }

        private void statusCS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nameCS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void remarkCS_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitCS_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                this.Close();
           
        }

        private void ColorSetupNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to cancel ?", "Close window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ColorSetupNew_KeyDown(object sender, KeyEventArgs e)
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
            SqlCommand cmd = new SqlCommand("colorsetupnewsp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@typename", name.Text);
            SqlParameter param = new SqlParameter("@colorname", SqlDbType.NVarChar);
            param.Value = cname.Text;
            cmd.Parameters.Add(param);            
            cmd.Parameters.AddWithValue("@colorstatus", cstatus.Text);
            cmd.Parameters.AddWithValue("@colorremark", cremark.Text);

            try
            {
                if (cname.Text != "" && cstatus.Text != "")
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data Inserted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cname.Text = "";
                        cstatus.Text = "";
                        cremark.Text = "";

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
