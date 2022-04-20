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
            id.Text ="";
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
            if (id.Text == "" || sname.Text == "" || age.Text == "")
            {
                MessageBox.Show("Please Provide Your Information!");
            }
            try
            {
                con.Open();
                // search the student based on the student name
                cmd = new SqlCommand("INSERT INTO Students (Students.s_id, Students.s_name,Sstudents.s_age) VALUES (@s_id,@s_name,@s_age)", con);
                cmd.Parameters.AddWithValue("@s_id",id.Text);
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

        private void button_min_Click(object sender, EventArgs e)
        {
            if (id.Text != null)
            {
                cmd = new SqlCommand("DELETE FROM students WHERE Students.s_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record is Deleted!");
                show_data();
            }else{
                MessageBox.Show("Please Input the ID to Delete");
            }
        }

        private void button_avg_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT S.s_id AS ID, S.s_name AS Student, S.s_age AS age FROM Students S ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        private void min_Click(object sender, EventArgs e)
        {
            if (min.Text == "")
            {
                MessageBox.Show("Provide Name");
                return;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("EXEC studentmin @student = @s", con);
            cmd.Parameters.AddWithValue("@s", min.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            // if the class is not exist, show error message
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Can not find this class");
                con.Close();
                return;
            }
            // show query result
            MessageBox.Show(dt.Rows[0]["Student"].ToString() + " MIN:  " + dt.Rows[0]["Min_age"].ToString());
            con.Close();
        }

        private void avg_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE (SELECT AVG(S.s_id) FROM Students S", con);
           
        }
    }
}
