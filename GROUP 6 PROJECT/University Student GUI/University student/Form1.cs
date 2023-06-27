using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_student
{
    public partial class Login : Form
    {
        public static string id = "";
        public static string password = "";

        public Login()
        {
            InitializeComponent();
        }

        private void logCreatebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Show();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            id = LoginIdtxt.Text;
            password = Logpasstxt.Text;
            string usertype = logusrtyptxt.Text.ToUpper();
            Dbconnect connect = new Dbconnect();

            bool valid = Validation(id, password);
            if (valid)
            {
                if (usertype == "USER")
                {
                    string encrypted_password = Register.encrypt_password(password);
                    bool autho = connect.LogUser(id, encrypted_password);
                    if (autho)
                    {
                        this.Hide();
                        MainMenu main = new MainMenu();
                        main.Show();
                    }
                    
                }
                else if (usertype == "ADMIN")
                {
                    //im gonna remove the encryption for the admin
                    //string encrypted_password = Register.encrypt_password(password);
                    bool autho = connect.LogAdmin(id, password);
                    if (autho)
                    {
                        this.Hide();
                        MainMenu main = new MainMenu();
                        main.Show();
                    }

                }

            }
            Dbconnect.con.Close();
        }

        private bool Validation(string id, string password)
        {
            if (id == "" || password == "")
            {
                MessageBox.Show("All fields are required");
                return false;
            }
            return true;
        }

        private void logcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (logcheck.Checked)
            {
                Logpasstxt.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
            }
            else
            {
                Logpasstxt.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
            }
        }
    }
}
