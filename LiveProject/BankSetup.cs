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
    public partial class BankSetup : Form
    {
        public BankSetup()
        {
            InitializeComponent();
        }

        private void addCF_Click(object sender, EventArgs e)
        {
            BankSetupNew a = new BankSetupNew();
            a.ShowDialog();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BankSetup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void BankSetup_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
