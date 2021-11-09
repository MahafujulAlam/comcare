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
    public partial class HomeBG : Form
    {
        public HomeBG()
        {
            InitializeComponent();
        }

        private void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            db.MdiParent = this;
            db.Show();
        }

        private void cOMPANYPROFILESETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyProfile dlg = new CompanyProfile();
            dlg.MdiParent = this;
            dlg.Show();
        }
    }
}
