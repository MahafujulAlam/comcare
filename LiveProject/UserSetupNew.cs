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
    public partial class UserSetupNew : Form
    {
        private User parent;
        public UserSetupNew(User parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            parent.Visible = false;

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact2_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
