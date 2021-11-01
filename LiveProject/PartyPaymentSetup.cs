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
    public partial class PartyPaymentSetup : Form
    {
        public PartyPaymentSetup()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCF_Click(object sender, EventArgs e)
        {
            PartyPaymentSetupNew dlg = new PartyPaymentSetupNew();
            dlg.ShowDialog();
        }

        private void PartyPaymentSetup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
