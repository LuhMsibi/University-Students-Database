using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_student
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void memberbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MM mm = new MM();
            mm.Show();
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin mem = new Admin();
            mem.Show();
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report rep = new Report();
            rep.Show();
        }

        private void memlogoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
            if (Dbconnect.USERTYPE == "A")
            {
                reportbtn.Visible = true;
                adminbtn.Visible = true;
                memberbtn.Visible = true;
            }
            else if (Dbconnect.USERTYPE == "U")
            {
                reportbtn.Visible = false;
                adminbtn.Visible = true;
                memberbtn.Visible = true;
                pictureBox3.Visible = true;
            }
        }
    }
}
