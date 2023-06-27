namespace University_student
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.regcheck = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.coursebox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regpasstxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.createCreatebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createbtn = new System.Windows.Forms.Button();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.regstuId = new System.Windows.Forms.Label();
            this.fnametxt = new System.Windows.Forms.TextBox();
            this.Regstudidtxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.regcheck);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.coursebox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.regpasstxt);
            this.panel1.Controls.Add(this.phonetxt);
            this.panel1.Controls.Add(this.lastnametxt);
            this.panel1.Controls.Add(this.emailtxt);
            this.panel1.Controls.Add(this.createCreatebtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.createbtn);
            this.panel1.Controls.Add(this.fnamelbl);
            this.panel1.Controls.Add(this.regstuId);
            this.panel1.Controls.Add(this.fnametxt);
            this.panel1.Controls.Add(this.Regstudidtxt);
            this.panel1.Location = new System.Drawing.Point(117, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 482);
            this.panel1.TabIndex = 2;
            // 
            // regcheck
            // 
            this.regcheck.AutoSize = true;
            this.regcheck.Location = new System.Drawing.Point(85, 321);
            this.regcheck.Name = "regcheck";
            this.regcheck.Size = new System.Drawing.Size(102, 17);
            this.regcheck.TabIndex = 20;
            this.regcheck.Text = "Show Password";
            this.regcheck.UseVisualStyleBackColor = true;
            this.regcheck.CheckedChanged += new System.EventHandler(this.regcheck_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(82, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Choose Course: ";
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
            this.coursebox.Location = new System.Drawing.Point(85, 356);
            this.coursebox.Name = "coursebox";
            this.coursebox.Size = new System.Drawing.Size(152, 21);
            this.coursebox.TabIndex = 18;
            this.toolTip2.SetToolTip(this.coursebox, "For Users Only");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(82, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Last Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(82, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(82, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Phone: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(82, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password: ";
            // 
            // regpasstxt
            // 
            this.regpasstxt.ForeColor = System.Drawing.Color.Gray;
            this.regpasstxt.Location = new System.Drawing.Point(85, 295);
            this.regpasstxt.Name = "regpasstxt";
            this.regpasstxt.Size = new System.Drawing.Size(152, 20);
            this.regpasstxt.TabIndex = 11;
            this.regpasstxt.UseSystemPasswordChar = true;
            // 
            // phonetxt
            // 
            this.phonetxt.ForeColor = System.Drawing.Color.Gray;
            this.phonetxt.Location = new System.Drawing.Point(85, 256);
            this.phonetxt.MaxLength = 10;
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(152, 20);
            this.phonetxt.TabIndex = 10;
            // 
            // lastnametxt
            // 
            this.lastnametxt.ForeColor = System.Drawing.Color.Gray;
            this.lastnametxt.Location = new System.Drawing.Point(85, 171);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(152, 20);
            this.lastnametxt.TabIndex = 9;
            // 
            // emailtxt
            // 
            this.emailtxt.ForeColor = System.Drawing.Color.Gray;
            this.emailtxt.Location = new System.Drawing.Point(85, 214);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(152, 20);
            this.emailtxt.TabIndex = 8;
            // 
            // createCreatebtn
            // 
            this.createCreatebtn.FlatAppearance.BorderSize = 0;
            this.createCreatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCreatebtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createCreatebtn.Location = new System.Drawing.Point(44, 446);
            this.createCreatebtn.Name = "createCreatebtn";
            this.createCreatebtn.Size = new System.Drawing.Size(193, 23);
            this.createCreatebtn.TabIndex = 7;
            this.createCreatebtn.Text = "Already have an account ? Sign In";
            this.createCreatebtn.UseVisualStyleBackColor = true;
            this.createCreatebtn.Click += new System.EventHandler(this.createCreatebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please enter your credentials.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sign Up";
            // 
            // createbtn
            // 
            this.createbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.createbtn.FlatAppearance.BorderSize = 0;
            this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.Location = new System.Drawing.Point(162, 394);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(75, 34);
            this.createbtn.TabIndex = 4;
            this.createbtn.Text = "Create";
            this.createbtn.UseVisualStyleBackColor = false;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnamelbl.ForeColor = System.Drawing.Color.Gray;
            this.fnamelbl.Location = new System.Drawing.Point(82, 116);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(75, 13);
            this.fnamelbl.TabIndex = 3;
            this.fnamelbl.Text = "First Name: ";
            // 
            // regstuId
            // 
            this.regstuId.AutoSize = true;
            this.regstuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regstuId.ForeColor = System.Drawing.Color.Gray;
            this.regstuId.Location = new System.Drawing.Point(82, 76);
            this.regstuId.Name = "regstuId";
            this.regstuId.Size = new System.Drawing.Size(72, 13);
            this.regstuId.TabIndex = 2;
            this.regstuId.Text = "Student ID:";
            // 
            // fnametxt
            // 
            this.fnametxt.ForeColor = System.Drawing.Color.Gray;
            this.fnametxt.Location = new System.Drawing.Point(85, 132);
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(152, 20);
            this.fnametxt.TabIndex = 1;
            // 
            // Regstudidtxt
            // 
            this.Regstudidtxt.Location = new System.Drawing.Point(85, 92);
            this.Regstudidtxt.MaxLength = 10;
            this.Regstudidtxt.Name = "Regstudidtxt";
            this.Regstudidtxt.Size = new System.Drawing.Size(152, 20);
            this.Regstudidtxt.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 570);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regpasstxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Button createCreatebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Label fnamelbl;
        private System.Windows.Forms.Label regstuId;
        private System.Windows.Forms.TextBox fnametxt;
        private System.Windows.Forms.TextBox Regstudidtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox coursebox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox regcheck;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}