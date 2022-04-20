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
            if(u.Text == "" || p.Text == "")
            {
                MessageBox.Show("Please show your information");
            }
            
            try

            {

                SqlCommand cmd = new SqlCommand("Select * from Pword where i_id = @username and pass = @password", con);

                //Assign values to variables. Give TextBox: username -> @username; TextBox: password-> @password
                cmd.Parameters.AddWithValue("@username", u.Text);
                cmd.Parameters.AddWithValue("@password", p.Text);

                //open the connection to DB
                con.Open();

               
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

            
                adapt.Fill(ds);

                con.Close();

        
                int count = ds.Tables[0].Rows.Count;

               
                if (count != 1)
                {
                    MessageBox.Show("Login Failed: Could Not Find Your Account!");
                }
                else
                {
                    MessageBox.Show("Login Successful!");
       
                }
                this.Hide();
                form_middle m = new form_middle();
                m.Show(); 
            }
            
            catch (Exception ex)
            {
              
                MessageBox.Show(ex.Message);
            }
          
        }


    

    private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_update f = new form_update();
            f.Show();
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

        private void p_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
