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
    public partial class PartyDetailsNew : Form
    {
        public PartyDetailsNew()
        {
            InitializeComponent();
        }

        private void tagline_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                this.Close();
            
        }

        private void PartyDetailsNew_KeyDown(object sender, KeyEventArgs e)
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

        private void PartyDetailsNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to cancel ?", "Close window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-OJR6FSL\\SQLEXPRESS; Initial Catalog = comcare; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("partydetailssp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@partydetailsPartyID", SqlDbType.NVarChar);
            param.Value = partyid.Text;
            cmd.Parameters.Add(param);
            cmd.Parameters.AddWithValue("@partydetailsPartyName", name.Text);
            cmd.Parameters.AddWithValue("@partydetailsPartyType", partytype.Text);
            cmd.Parameters.AddWithValue("@partydetailsContactNo", contact.Text);
            cmd.Parameters.AddWithValue("@partydetailsCountry", country.Text);
            cmd.Parameters.AddWithValue("@partydetailsState", state.Text);
            cmd.Parameters.AddWithValue("@partydetailsDist", dist.Text);
            cmd.Parameters.AddWithValue("@partydetailsPS", ps.Text);
            cmd.Parameters.AddWithValue("@partydetailsVillage", village.Text);
            cmd.Parameters.AddWithValue("@partydetailsPinNo", pin.Text);
            cmd.Parameters.AddWithValue("@partydetailsPanNo", pan.Text);
            cmd.Parameters.AddWithValue("@partydetailsGSTNo", gstno.Text);
            cmd.Parameters.AddWithValue("@partydetailsCINNo", cnno.Text);
            cmd.Parameters.AddWithValue("@partydetailsLicenseNo", license.Text);
            cmd.Parameters.AddWithValue("@partydetailsStateCode", statecode.Text);
            cmd.Parameters.AddWithValue("@partydetailsEmailId", email.Text);
            cmd.Parameters.AddWithValue("@partydetailsWebsite", website.Text);
            cmd.Parameters.AddWithValue("@partydetailsDLNo", dlno.Text);
            cmd.Parameters.AddWithValue("@partydetailsFoodLicenseNo", flicenseno.Text);
            cmd.Parameters.AddWithValue("@partydetailsMFGLicenseNo", mfglicenseno.Text);

            //MemoryStream ms = new MemoryStream(); // ram
            //logo.Image.Save(ms, ImageFormat.Jpeg);
            //byte[] pic_array = new byte[ms.Length];
            //ms.Position = 0;
            //ms.Read(pic_array, 0, pic_array.Length);
            //cmd.Parameters.AddWithValue("@companyLogo", pic_array);
            
            try
            {
                if (partyid.Text != "" && name.Text != "" && pin.Text != "" && country.Text != "" && state.Text != "" && dist.Text != "" && ps.Text != "" && village.Text != "" && pan.Text != "" && gstno.Text != "" && cnno.Text != "" && license.Text != "" && dlno.Text != "")
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data Inserted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        partyid.Text = "";
                        name.Text = "";
                        partytype.Text = "";
                        contact.Text = "";
                        country.Text = "";
                        state.Text = "";
                        dist.Text = "";
                        ps.Text = "";
                        village.Text = "";
                        pin.Text = "";
                        pan.Text = "";
                        gstno.Text = "";
                        cnno.Text = "";
                        license.Text = "";
                        statecode.Text = "";
                        email.Text = "";
                        website.Text = "";
                        dlno.Text = "";
                        flicenseno.Text = "";
                        mfglicenseno.Text = "";
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
