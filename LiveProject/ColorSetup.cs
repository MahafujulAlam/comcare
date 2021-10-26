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
    }
}
