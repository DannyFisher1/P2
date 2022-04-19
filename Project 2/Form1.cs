using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Project_2
{
    public partial class Form_login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\danielfisher\Source\Repos\DannyFisher1\P2\Project 2\Student.mdf;Integrated Security = True");
        public Form_login()
        {
            InitializeComponent();
        }

        private void button_course_Click(object sender, EventArgs e)
        {
            Form_student frs = new Form_student();
            frs.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (u.Text == "" || p.Text == "")
            {
                MessageBox.Show("Please put in your information");
                // the sql command you want to execute in DBMS
                SqlCommand cmd = new SqlCommand("SELECT EXISTS (SELECT * FROM Pword WHERE i_id = @u AND pass = @p)", con);

                //Assign values to variables. Give TextBox: username -> @username; TextBox: password-> @password
                cmd.Parameters.AddWithValue("@u", u.Text);
                cmd.Parameters.AddWithValue("@p", p.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("good");
                //open the connection to DB



            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_username_Click(object sender, EventArgs e)
        {

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Create_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register R = new Register();
            R.Show();
        }
    }
}
