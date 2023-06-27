using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace University_student
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string id = adidtxt.Text;
            string fname = adfnametxt.Text;
            string lname = adlnametxt.Text;
            string email = ademailtxt.Text;
            string phone = adphonetxt.Text;
            string password = adpasstxt.Text;

            string encrypted_password = Register.encrypt_password(password);

            Dbconnect db = new Dbconnect();
            //db.updatetable(id, fname, lname, email, phone, encrypted_password);


            /*thhe following code checkss if the textbox is empty or not if it is not it updates the table qith the informtion in that text box*/ 

            if (!string.IsNullOrEmpty(fname))
            {
                db.updateFirstName(id, fname);
            }
            if (!string.IsNullOrEmpty(lname))
            {
                db.updateLastName(id, lname);
            }
            if (!string.IsNullOrEmpty(email))
            {
                db.updateEmail(id, email);
            }
            if (!string.IsNullOrEmpty(phone))
            {
                db.updatePhone(id, phone);
            }
            if (!string.IsNullOrEmpty(password))
            {
                db.updatePassword(id, encrypted_password);
            }
            MessageBox.Show("Updated Sucessfully");

            /*ends here*/

          
        }

        private void membackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void addeletebtn_Click(object sender, EventArgs e)
        {
            Dbconnect db = new Dbconnect();
            string id = adidtxt.Text;
            if(MessageBox.Show("Are sure you want to De-register this student", "De-register Student", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(id))
                {
                    db.DeleteTable(id);
                }
            }
            else
            {
                MessageBox.Show("Student Not De-registred", "De-register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            Dbconnect.con.Close();
        }

        private void adinsertbtn_Click(object sender, EventArgs e)
        {
            Dbconnect connect = new Dbconnect();
            string id = adidtxt.Text;
            string fname = adfnametxt.Text;
            string lname = adlnametxt.Text;
            string email = ademailtxt.Text;
            string phone = adphonetxt.Text;
            string password = adpasstxt.Text; 
            string dropmenu = coursebox.Text;
            int courseid = 0;
            if (dropmenu == "Mathematics")
            {
                courseid = 1;
            }
            else if (dropmenu == "Physics")
            {
                courseid = 2;
            }
            else if (dropmenu == "Chemistry")
            {
                courseid = 3;
            }
            else if (dropmenu == "Biology")
            {
                courseid = 4;
            }

            /**/

            else if (dropmenu == "Computer Science")
            {
                courseid = 5;
            }
            else if (dropmenu == "English")
            {
                courseid = 6;
            }
            else if (dropmenu == "History")
            {
                courseid = 7;
            }
            else if (dropmenu == "Geography")
            {
                courseid = 8;
            }
            else if (dropmenu == "Economics")
            {
                courseid = 9;
            }
            else if (dropmenu == "Business Administration")
            {
                courseid = 10;
            }


            bool valid = Validation(id, fname, lname, email, phone, password);
            if (valid)
            {
                string encrypted_passoword = Register.encrypt_password(password);
                connect.AddUser(id, fname, lname, email, phone, encrypted_passoword, courseid);
                adidtxt.Text = "";
                adfnametxt.Text = "";
                adlnametxt.Text = "";
                ademailtxt.Text = "";
                adphonetxt.Text = "";
                adpasstxt.Text = "";
                coursebox.Text = "";
            }
            Dbconnect.con.Close();
        }


        private bool Validation(string id, string fname, string lname, string email, string phone, string password)
        {
            Regex reg = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (email == "")
            {
                MessageBox.Show("Email required");
                return false;
            }
            else if (!reg.Match(email).Success)
            {
                MessageBox.Show("Invalid Email address");
                return false;
            }
            if (id == "")
            {
                MessageBox.Show("id required");
                return false;
            }
            if (fname == "")
            {
                MessageBox.Show("First name required");
                return false;
            }
            if (lname == "")
            {
                MessageBox.Show("Last name required");
                return false;
            }
            
            if (phone == "")
            {
                MessageBox.Show("phone required");
                return false;

            }
            if (password == "")
            {
                MessageBox.Show("password required");
                return false;

            }
            //if (usertype == "")
            //{
            //    MessageBox.Show("usertype required");
            //    return false;

            //}
           
            return true;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            if (Dbconnect.USERTYPE == "A")
            {
                addeletebtn.Visible = true;
                updatebtn.Visible = true;
                adinsertbtn.Visible = true;
                genpassbtn.Visible = true;
            }
            else if (Dbconnect.USERTYPE == "U")
            {
                addeletebtn.Visible = false;
                updatebtn.Visible = true;
                adinsertbtn.Visible = false;
                genpassbtn.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (memcheck.Checked)
            {
                adpasstxt.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;


            }
            else
            {
                adpasstxt.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;

            }
        }

        private void genpassbtn_Click(object sender, EventArgs e)
        {
            int len = 10;
            
            
            const string PasswordChar = "abcdefghigklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //for less memory usage I will use string Builder
            StringBuilder resulst = new StringBuilder();
            Random rand = new Random();
            while (0<len--)
            {
                resulst.Append(PasswordChar[rand.Next(PasswordChar.Length)]);
            }
            //string newpass = Register.encrypt_password(resulst.ToString());
            adpasstxt.Text = resulst.ToString();
        }
    }
}
