using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveProject
{
    public partial class PartyDetails : Form
    {
        public PartyDetails()
        {
            InitializeComponent();
        }

        private void addCF_Click(object sender, EventArgs e)
        {
            PartyDetailsNew a = new PartyDetailsNew();
            a.ShowDialog();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCF_Click_1(object sender, EventArgs e)
        {
            PartyDetailsNew dlg = new PartyDetailsNew();
            dlg.ShowDialog();
        }

        private void PartyDetails_KeyDown(object sender, KeyEventArgs e)
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

        private void PartyDetails_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-OJR6FSL\SQLEXPRESS; Initial Catalog = comcare; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("Select * from PartyDetailsNew", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                da.Fill(dt);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                cmd.Dispose();
                con.Close();
                da.Dispose();

            }

            //dataGridView1.DataSource = dt;
            foreach (DataRow drow in dt.Rows)
            {
                string[] strdata = { drow["partydetailsPartyID"].ToString(), drow["partydetailsPartyName"].ToString(), drow["partydetailsPartyType"].ToString(),
                    drow["partydetailsContactNo"].ToString(), drow["partydetailsCountry"].ToString(),
                    drow["partydetailsState"].ToString(), drow["partydetailsDist"].ToString(),
                    drow["partydetailsPS"].ToString(), drow["partydetailsVillage"].ToString(),
                    drow["partydetailsPinNo"].ToString(), drow["partydetailsPanNo"].ToString(),
                    drow["partydetailsGSTNo"].ToString(), drow["partydetailsCINNo"].ToString(),
                    drow["partydetailsLicenseNo"].ToString(), drow["partydetailsStateCode"].ToString(),
                    drow["partydetailsEmailId"].ToString(), drow["partydetailsWebsite"].ToString(),
                    drow["partydetailsDLNo"].ToString(), drow["partydetailsFoodLicenseNo"].ToString(),
                    drow["partydetailsMFGLicenseNo"].ToString() };
                dataGridView1.Rows.Add(strdata);
            }


        }
    }
}
