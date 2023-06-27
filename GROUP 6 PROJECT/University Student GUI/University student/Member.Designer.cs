namespace University_student
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.label1 = new System.Windows.Forms.Label();
            this.adidtxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.memcheck = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.coursebox = new System.Windows.Forms.ComboBox();
            this.adinsertbtn = new System.Windows.Forms.Button();
            this.addeletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.adpasstxt = new System.Windows.Forms.TextBox();
            this.adfnametxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ademailtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adphonetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adlnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adbackbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.genpassbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(112, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID: ";
            // 
            // adidtxt
            // 
            this.adidtxt.Location = new System.Drawing.Point(115, 39);
            this.adidtxt.MaxLength = 10;
            this.adidtxt.Name = "adidtxt";
            this.adidtxt.Size = new System.Drawing.Size(162, 20);
            this.adidtxt.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.genpassbtn);
            this.panel1.Controls.Add(this.memcheck);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.coursebox);
            this.panel1.Controls.Add(this.adinsertbtn);
            this.panel1.Controls.Add(this.addeletebtn);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.adpasstxt);
            this.panel1.Controls.Add(this.adfnametxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ademailtxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.adphonetxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.adlnametxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.adidtxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(152, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 416);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // memcheck
            // 
            this.memcheck.AutoSize = true;
            this.memcheck.Location = new System.Drawing.Point(116, 286);
            this.memcheck.Name = "memcheck";
            this.memcheck.Size = new System.Drawing.Size(102, 17);
            this.memcheck.TabIndex = 22;
            this.memcheck.Text = "Show Password";
            this.memcheck.UseVisualStyleBackColor = true;
            this.memcheck.CheckedChanged += new System.EventHandler(this.regcheck_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(113, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Choose Course: ";
            // 
            // coursebox
            // 
            this.coursebox.FormattingEnabled = true;
            this.coursebox.Items.AddRange(new object[] {
            "Mathematics",
            "Physics",
            "Chemistry",
            "Biology",
            "Computer Science",
            "English",
            "History",
            "Geography",
            "Economics",
            "Business Administration"});
            this.coursebox.Location = new System.Drawing.Point(116, 322);
            this.coursebox.Name = "coursebox";
            this.coursebox.Size = new System.Drawing.Size(161, 21);
            this.coursebox.TabIndex = 20;
            this.toolTip1.SetToolTip(this.coursebox, "Choose a Course");
            // 
            // adinsertbtn
            // 
            this.adinsertbtn.Location = new System.Drawing.Point(79, 368);
            this.adinsertbtn.Name = "adinsertbtn";
            this.adinsertbtn.Size = new System.Drawing.Size(75, 34);
            this.adinsertbtn.TabIndex = 14;
            this.adinsertbtn.Text = "Insert";
            this.adinsertbtn.UseVisualStyleBackColor = true;
            this.adinsertbtn.Click += new System.EventHandler(this.adinsertbtn_Click);
            // 
            // addeletebtn
            // 
            this.addeletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addeletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addeletebtn.Location = new System.Drawing.Point(241, 368);
            this.addeletebtn.Name = "addeletebtn";
            this.addeletebtn.Size = new System.Drawing.Size(75, 34);
            this.addeletebtn.TabIndex = 13;
            this.addeletebtn.Text = "De Register";
            this.addeletebtn.UseVisualStyleBackColor = false;
            this.addeletebtn.Click += new System.EventHandler(this.addeletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Location = new System.Drawing.Point(160, 368);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 34);
            this.updatebtn.TabIndex = 12;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(113, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // adpasstxt
            // 
            this.adpasstxt.Location = new System.Drawing.Point(115, 259);
            this.adpasstxt.Name = "adpasstxt";
            this.adpasstxt.Size = new System.Drawing.Size(162, 20);
            this.adpasstxt.TabIndex = 10;
            this.adpasstxt.UseSystemPasswordChar = true;
            // 
            // adfnametxt
            // 
            this.adfnametxt.Location = new System.Drawing.Point(115, 82);
            this.adfnametxt.Name = "adfnametxt";
            this.adfnametxt.Size = new System.Drawing.Size(162, 20);
            this.adfnametxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(112, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "First Name: ";
            // 
            // ademailtxt
            // 
            this.ademailtxt.Location = new System.Drawing.Point(115, 165);
            this.ademailtxt.Name = "ademailtxt";
            this.ademailtxt.Size = new System.Drawing.Size(162, 20);
            this.ademailtxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(113, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone: ";
            // 
            // adphonetxt
            // 
            this.adphonetxt.Location = new System.Drawing.Point(115, 213);
            this.adphonetxt.MaxLength = 10;
            this.adphonetxt.Name = "adphonetxt";
            this.adphonetxt.Size = new System.Drawing.Size(162, 20);
            this.adphonetxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(113, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email: ";
            // 
            // adlnametxt
            // 
            this.adlnametxt.Location = new System.Drawing.Point(115, 125);
            this.adlnametxt.Name = "adlnametxt";
            this.adlnametxt.Size = new System.Drawing.Size(162, 20);
            this.adlnametxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(113, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // adbackbtn
            // 
            this.adbackbtn.Location = new System.Drawing.Point(12, 12);
            this.adbackbtn.Name = "adbackbtn";
            this.adbackbtn.Size = new System.Drawing.Size(75, 34);
            this.adbackbtn.TabIndex = 13;
            this.adbackbtn.Text = "Back";
            this.adbackbtn.UseVisualStyleBackColor = true;
            this.adbackbtn.Click += new System.EventHandler(this.membackbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(404, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "INSERT UPDATE AND DELETE STUDENTS DETAILS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(152, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 39);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(681, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // genpassbtn
            // 
            this.genpassbtn.Location = new System.Drawing.Point(296, 259);
            this.genpassbtn.Name = "genpassbtn";
            this.genpassbtn.Size = new System.Drawing.Size(75, 20);
            this.genpassbtn.TabIndex = 23;
            this.genpassbtn.Text = "Generate ";
            this.genpassbtn.UseVisualStyleBackColor = true;
            this.genpassbtn.Click += new System.EventHandler(this.genpassbtn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 599);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.adbackbtn);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adidtxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox adfnametxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ademailtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adphonetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adlnametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adpasstxt;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button adbackbtn;
        private System.Windows.Forms.Button addeletebtn;
        private System.Windows.Forms.Button adinsertbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox coursebox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox memcheck;
        private System.Windows.Forms.Button genpassbtn;
    }
}