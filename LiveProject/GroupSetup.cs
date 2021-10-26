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
    public partial class GroupSetup : Form
    {
        public GroupSetup()
        {
            InitializeComponent();
        }

        private void addCF_Click(object sender, EventArgs e)
        {
            GroupSetupNew a = new GroupSetupNew();
            a.ShowDialog();
        }
    }
}
