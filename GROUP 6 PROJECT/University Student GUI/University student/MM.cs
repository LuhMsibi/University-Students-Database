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

namespace University_student
{
    public partial class MM : Form
    {
        public MM()
        {
            InitializeComponent();
        }

        private void Detailsbtn_Click(object sender, EventArgs e)
        {
            /*Show Course related info about all students in the database*/
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DGV021E;Initial Catalog=University_StudentsS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentCourseInfo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1st.DataSource = dt;
        }

        private void regbackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void mydetailsbtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            string id = Dbconnect.checkCourseId;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DGV021E;Initial Catalog=University_StudentsS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentCourseInfo WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1st.DataSource = dt;
        }

        private void MM_Load(object sender, EventArgs e)
        {
            if (Dbconnect.USERTYPE == "A")
            {
                mydetailsbtn.Visible = false;
                Detailsbtn.Visible = true;
                mmlbl.Visible = true;
                mmidtxt.Visible = true;
                mmsearchbtn.Visible = true;
            }
            else if (Dbconnect.USERTYPE == "U")
            {
                mydetailsbtn.Visible = true;
                Detailsbtn.Visible = false;
                mmlbl.Visible = false;
                mmidtxt.Visible = false;
                mmsearchbtn.Visible = false;
            }
        }

        private void mmsearchbtn_Click(object sender, EventArgs e)
        {
            string id = mmidtxt.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DGV021E;Initial Catalog=University_StudentsS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentCourseInfo WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1st.DataSource = dt;
            mmidtxt.Text = "";
        }
    }
}
