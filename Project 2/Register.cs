using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Project_2
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\danielfisher\Source\Repos\DannyFisher1\P2\Project 2\Student.mdf;Integrated Security = True");

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label_username_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(d.Text == "" || p.Text =="" || iid.Text == "" || d.Text == "")
            {
                MessageBox.Show("Please put your Information");
            }

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Pword(i_id,pass) VALUES (@iid,@p)", con);
                cmd.Parameters.AddWithValue("@iid", iid.Text);
                cmd.Parameters.AddWithValue("@p", p.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted");

                this.Hide();
                Form_login f = new Form_login();
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
this.Hide();
                Form_login f = new Form_login();
                f.Show();

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
