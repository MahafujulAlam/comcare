using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }
    }
}
