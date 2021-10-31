using System;
using System.Windows.Forms;

namespace LiveProject
{
    public partial class EmployeeSalaryPay : Form
    {
        public EmployeeSalaryPay()
        {
            InitializeComponent();
        }

        private void addCF_Click(object sender, EventArgs e)
        {
            EmployeeSalaryPayNew dlg = new EmployeeSalaryPayNew();
            dlg.ShowDialog();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeSalaryPay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
