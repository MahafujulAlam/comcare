using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiveProject
{
    public partial class EmployeeSalaryDue : Form
    {
        public EmployeeSalaryDue()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCF_Click(object sender, EventArgs e)
        {
            EmployeeSalaryDueNew dlg = new EmployeeSalaryDueNew();
            dlg.ShowDialog();
        }

        private void EmployeeSalaryDue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
