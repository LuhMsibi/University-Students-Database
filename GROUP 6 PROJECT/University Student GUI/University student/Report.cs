using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace University_student
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void usershowbtn_Click(object sender, EventArgs e)
        {
            /*Show All users in the data grid view*/
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DGV021E;Initial Catalog=University_StudentsS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENTS", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            
        }

        private void regbackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string id = reportidtxt.Text;
          
            // remove the if statement you can only search users 
            //if (usertype == "USER")
           // {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-DGV021E;Initial Catalog=University_StudentsS;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENTS WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                id = "";
               
           // }
            //else if (usertype == "ADMIN")
            //{
            //    SqlConnection con = new SqlConnection("Data Source=DESKTOP-DGV021E;Initial Catalog=University_StudentsS;Integrated Security=True");
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("SELECT * FROM REGISTERED_ADMIN WHERE ID=@ID", con);
            //    cmd.Parameters.AddWithValue("@ID", id);
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //    id = "";
            //    usertype = "";
            //}
            
        }

        private void stuffsearchbtn_Click(object sender, EventArgs e)
        {

        }

        private void deregusersbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DGV021E;Initial Catalog=University_StudentsS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM DELETED_STUDENTS", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
