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
    public partial class UnitSetupNew : Form
    {
        public UnitSetupNew()
        {
            InitializeComponent();
        }

        private void UnitSetupNew_KeyDown(object sender, KeyEventArgs e)
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

        private void UnitSetupNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel ?", "Close window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UnitSetupNew_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-OJR6FSL\SQLEXPRESS; Initial Catalog = comcare; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("Select packName from PackSetupNew", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            try
            {
                con.Open();
                da.Fill(ds);
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

            selectpack.DataSource = ds.Tables[0];
            selectpack.DisplayMember = "packName";
            selectpack.ValueMember = "packName";

            //foreach (DataRow drow in dt.Rows)
            //{
            //    string[] strdata = { drow["typeName"].ToString(), drow["typeCode"].ToString(), drow["typeStatus"].ToString(), drow["typeRemark"].ToString() };
            //    dataGridView1.Rows.Add(strdata);
            //}


        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-OJR6FSL\SQLEXPRESS; Initial Catalog = comcare; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("unitsetupnewsp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "typesetupnewsp";
            //cmd.Connection = con;
            cmd.Parameters.AddWithValue("@unitname", uname.Text);
            //SqlParameter param = new SqlParameter("@typename", SqlDbType.NVarChar);
            //param.Value = name.Text;
            //cmd.Parameters.Add(param);
            cmd.Parameters.AddWithValue("@selectpack", selectpack.Text);
            cmd.Parameters.AddWithValue("@unitstatus", ustatus.Text);
            cmd.Parameters.AddWithValue("@unitremark", uremark.Text);
            try
            {
                if (uname.Text != "" && selectpack.Text != "" && ustatus.Text != "")
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data Inserted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        uname.Text = "";
                        selectpack.Text = "";
                        ustatus.Text = "";
                        uremark.Text = "";
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
