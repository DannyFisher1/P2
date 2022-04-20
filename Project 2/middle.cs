using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class form_middle : Form
    {
        public form_middle()
        {
            InitializeComponent();
        }

        private void middle_Load(object sender, EventArgs e)
        {

        }

        private void r_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //if yes, hide this form
                this.Hide();
                Form_login fl = new Form_login();
                // show login window
                fl.Show();
            }

        }
    }
}
