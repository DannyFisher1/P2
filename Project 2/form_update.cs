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
    public partial class form_update : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\danielfisher\Source\Repos\DannyFisher1\P2\Project 2\Student.mdf;Integrated Security = True");
        SqlCommand cmd;
        public form_update()
        {
            InitializeComponent();
        }
        private void show_data()
        {
            con.Open();
            // search the student based on the student name
            SqlCommand cmd = new SqlCommand("SELECT Students.s_id as ID, Students.s_name AS Name, Students.s_age AS Age FROM Students", con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearData()
        {
            sid.Text ="";
            sname.Text = "";
            age.Text = "";

        }
        private void textBox_name_TextChanged_1(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Please provide student name");
                return;
            }
            
            // search the student based on the student name
            SqlCommand cmd = new SqlCommand("EXEC studentinfo @student = @name;", con);
            cmd.Parameters.AddWithValue("@name", name.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {

            
        }

        private void form_update_Load(object sender, EventArgs e)
        {

        }

        private void button_max_Click(object sender, EventArgs e)
        {
            if (sid.Text == "" || sname.Text == "" || age.Text == "")
            {
                MessageBox.Show("Please Provide Your Information!");
            }
            try
            {
                con.Open();
                // search the student based on the student name
                cmd = new SqlCommand("INSERT INTO Students (Students.s_id, Students.s_name,Sstudents.s_age) VALUES (@s_id,@s_name,@s_age)", con);
                cmd.Parameters.AddWithValue("@s_id",sid.Text);
                cmd.Parameters.AddWithValue("@s_name",sname.Text);
                cmd.Parameters.AddWithValue("@s_age", age.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insert Successfully");
                // clear the content in textbox
                ClearData();
                // refresh the datagridview
                show_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                ClearData();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
