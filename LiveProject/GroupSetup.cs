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
    public partial class GroupSetup : Form
    {
        public GroupSetup()
        {
            InitializeComponent();
        }

        private void addCF_Click(object sender, EventArgs e)
        {
            GroupSetupNew a = new GroupSetupNew();
            a.ShowDialog();
        }

        private void GroupSetup_KeyDown(object sender, KeyEventArgs e)
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupSetup_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-OJR6FSL\SQLEXPRESS; Initial Catalog = comcare; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("Select * from GroupSetupNew", con);
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
                string[] strdata = { drow["groupName"].ToString(), drow["groupStatus"].ToString(), drow["groupRemark"].ToString() };
                dataGridView1.Rows.Add(strdata);
            }
        }
    }
}
