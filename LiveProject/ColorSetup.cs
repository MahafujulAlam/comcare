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
    public partial class ColorSetup : Form
    {
        public ColorSetup()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            //jhgjhgjhgjhg
        }

        private void addCF_Click(object sender, EventArgs e)
        {
            ColorSetupNew dlg = new ColorSetupNew();
            dlg.ShowDialog();
        }

        private void ColorSetup_KeyDown(object sender, KeyEventArgs e)
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

        private void ColorSetup_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-OJR6FSL\SQLEXPRESS; Initial Catalog = comcare; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("Select * from ColorSetupNew", con);
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
                string[] strdata = { drow["colorName"].ToString(), drow["colorStatus"].ToString(), drow["colorRemark"].ToString() };
                dataGridView1.Rows.Add(strdata);
            }


        }
    }
}
