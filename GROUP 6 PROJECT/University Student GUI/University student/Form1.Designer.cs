namespace University_student
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.logusrtyptxt = new System.Windows.Forms.TextBox();
            this.logCreatebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.Logpasslbl = new System.Windows.Forms.Label();
            this.LogIDlbl = new System.Windows.Forms.Label();
            this.Logpasstxt = new System.Windows.Forms.TextBox();
            this.LoginIdtxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.logcheck = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.logcheck);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.logusrtyptxt);
            this.panel1.Controls.Add(this.logCreatebtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loginbtn);
            this.panel1.Controls.Add(this.Logpasslbl);
            this.panel1.Controls.Add(this.LogIDlbl);
            this.panel1.Controls.Add(this.Logpasstxt);
            this.panel1.Controls.Add(this.LoginIdtxt);
            this.panel1.Location = new System.Drawing.Point(84, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 317);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(50, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "User Type: ";
            // 
            // logusrtyptxt
            // 
            this.logusrtyptxt.Location = new System.Drawing.Point(125, 176);
            this.logusrtyptxt.Name = "logusrtyptxt";
            this.logusrtyptxt.Size = new System.Drawing.Size(152, 20);
            this.logusrtyptxt.TabIndex = 8;
            this.toolTip1.SetToolTip(this.logusrtyptxt, "User or Admin");
            // 
            // logCreatebtn
            // 
            this.logCreatebtn.FlatAppearance.BorderSize = 0;
            this.logCreatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logCreatebtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logCreatebtn.Location = new System.Drawing.Point(98, 251);
            this.logCreatebtn.Name = "logCreatebtn";
            this.logCreatebtn.Size = new System.Drawing.Size(193, 23);
            this.logCreatebtn.TabIndex = 7;
            this.logCreatebtn.Text = "Don\'t have an account ? Sign Up";
            this.logCreatebtn.UseVisualStyleBackColor = true;
            this.logCreatebtn.Click += new System.EventHandler(this.logCreatebtn_Click);
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
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sign in";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loginbtn.FlatAppearance.BorderSize = 0;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(202, 211);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 34);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // Logpasslbl
            // 
            this.Logpasslbl.AutoSize = true;
            this.Logpasslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logpasslbl.ForeColor = System.Drawing.Color.Gray;
            this.Logpasslbl.Location = new System.Drawing.Point(50, 123);
            this.Logpasslbl.Name = "Logpasslbl";
            this.Logpasslbl.Size = new System.Drawing.Size(69, 13);
            this.Logpasslbl.TabIndex = 3;
            this.Logpasslbl.Text = "Password: ";
            // 
            // LogIDlbl
            // 
            this.LogIDlbl.AutoSize = true;
            this.LogIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIDlbl.ForeColor = System.Drawing.Color.Gray;
            this.LogIDlbl.Location = new System.Drawing.Point(56, 80);
            this.LogIDlbl.Name = "LogIDlbl";
            this.LogIDlbl.Size = new System.Drawing.Size(63, 13);
            this.LogIDlbl.TabIndex = 2;
            this.LogIDlbl.Text = "Login ID: ";
            // 
            // Logpasstxt
            // 
            this.Logpasstxt.Location = new System.Drawing.Point(125, 120);
            this.Logpasstxt.Name = "Logpasstxt";
            this.Logpasstxt.Size = new System.Drawing.Size(152, 20);
            this.Logpasstxt.TabIndex = 1;
            this.Logpasstxt.UseSystemPasswordChar = true;
            // 
            // LoginIdtxt
            // 
            this.LoginIdtxt.Location = new System.Drawing.Point(125, 77);
            this.LoginIdtxt.MaxLength = 10;
            this.LoginIdtxt.Name = "LoginIdtxt";
            this.LoginIdtxt.Size = new System.Drawing.Size(152, 20);
            this.LoginIdtxt.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(499, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // logcheck
            // 
            this.logcheck.AutoSize = true;
            this.logcheck.Location = new System.Drawing.Point(125, 153);
            this.logcheck.Name = "logcheck";
            this.logcheck.Size = new System.Drawing.Size(102, 17);
            this.logcheck.TabIndex = 21;
            this.logcheck.Text = "Show Password";
            this.logcheck.UseVisualStyleBackColor = true;
            this.logcheck.CheckedChanged += new System.EventHandler(this.logcheck_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logCreatebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label Logpasslbl;
        private System.Windows.Forms.Label LogIDlbl;
        private System.Windows.Forms.TextBox Logpasstxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox logusrtyptxt;
        public System.Windows.Forms.TextBox LoginIdtxt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox logcheck;
    }
}

