using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_student
{
    public partial class Register : Form
    {
       
        public Register()
        {
            InitializeComponent();
        }

        private void createCreatebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            Dbconnect connect = new Dbconnect();
            string id = Regstudidtxt.Text;
            string fname = fnametxt.Text;
            string lname = lastnametxt.Text;
            string email = emailtxt.Text;
            string phone = phonetxt.Text;
            string password = regpasstxt.Text;
           
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
            {   /* i AM REMOVING THE IF STATEMENT HERE*/
                //if (usertype == "USER")
                //{
                    string encrypted_passoword = encrypt_password(password);
                    connect.AddUser(id, fname, lname, email, phone, encrypted_passoword, courseid);
                    Regstudidtxt.Text = "";
                    fnametxt.Text = "";
                    lastnametxt.Text = "";
                    emailtxt.Text = "";
                    phonetxt.Text = "";
                    regpasstxt.Text = ""; 
                    coursebox.Text = "";

                    

                //}

                /*ALO COMMENTED OUT THIS */
                //else if (usertype == "ADMIN")
                //{
                //    string encrypted_passoword = encrypt_password(password);
                //    connect.AddAdmin(id, fname, lname, email, phone, encrypted_passoword, usertype);
                //    Regstudidtxt.Text = "";
                //    fnametxt.Text = "";
                //    lastnametxt.Text = "";
                //    emailtxt.Text = "";
                //    phonetxt.Text = "";
                //    regpasstxt.Text = "";
                //    regustypetxt.Text = "";
                //    coursebox.Text = "";

                    
                //}
            }
        }

        public static string encrypt_password(string password)
        {
            var hash = SHA256.Create();
            var byteArray = Encoding.Default.GetBytes(password);
            var encrypted_password = hash.ComputeHash(byteArray);
            return Convert.ToBase64String(encrypted_password);
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
            //if (dropmenu == "")
            //{
            //    MessageBox.Show("dropmenu required");
            //    return false;

            //}
            return true;
        }

        private void regcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (regcheck.Checked)
            {
                regpasstxt.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
            }
            else
            {
                regpasstxt.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
            }
        }
    }
}
