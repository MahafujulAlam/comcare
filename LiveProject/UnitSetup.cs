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
    public partial class UnitSetup : Form
    {
        public UnitSetup()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UnitSetup_KeyDown(object sender, KeyEventArgs e)
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

        private void addCF_Click(object sender, EventArgs e)
        {
            UnitSetupNew DLG = new UnitSetupNew();
            DLG.ShowDialog();
        }

        private void UnitSetup_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-OJR6FSL\SQLEXPRESS; Initial Catalog = comcare; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("Select * from UnitSetupNew",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();           
            //DataSet ds = new DataSet();
            try
            {
                con.Open();
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
                cmd.Dispose();
            }

            

            foreach (DataRow drow in dt.Rows)
            {

                string[] strdata = { drow["unitName"].ToString(), drow["selectPack"].ToString(), drow["unitStatus"].ToString(), drow["unitRemark"].ToString() };
                dataGridView1.Rows.Add(strdata);
            }
        }    
    }
}
