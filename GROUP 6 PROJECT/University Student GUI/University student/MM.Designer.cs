namespace University_student
{
    partial class MM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mmlbl = new System.Windows.Forms.Label();
            this.mmsearchbtn = new System.Windows.Forms.Button();
            this.mmidtxt = new System.Windows.Forms.TextBox();
            this.mydetailsbtn = new System.Windows.Forms.Button();
            this.Detailsbtn = new System.Windows.Forms.Button();
            this.dataGridView1st = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.membackbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1st)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mmlbl);
            this.panel1.Controls.Add(this.mmsearchbtn);
            this.panel1.Controls.Add(this.mmidtxt);
            this.panel1.Controls.Add(this.mydetailsbtn);
            this.panel1.Controls.Add(this.Detailsbtn);
            this.panel1.Location = new System.Drawing.Point(8, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 161);
            this.panel1.TabIndex = 0;
            // 
            // mmlbl
            // 
            this.mmlbl.AutoSize = true;
            this.mmlbl.Location = new System.Drawing.Point(4, 98);
            this.mmlbl.Name = "mmlbl";
            this.mmlbl.Size = new System.Drawing.Size(59, 13);
            this.mmlbl.TabIndex = 4;
            this.mmlbl.Text = "Student Id:";
            // 
            // mmsearchbtn
            // 
            this.mmsearchbtn.Location = new System.Drawing.Point(4, 118);
            this.mmsearchbtn.Name = "mmsearchbtn";
            this.mmsearchbtn.Size = new System.Drawing.Size(179, 40);
            this.mmsearchbtn.TabIndex = 3;
            this.mmsearchbtn.Text = "Search Student";
            this.mmsearchbtn.UseVisualStyleBackColor = true;
            this.mmsearchbtn.Click += new System.EventHandler(this.mmsearchbtn_Click);
            // 
            // mmidtxt
            // 
            this.mmidtxt.Location = new System.Drawing.Point(69, 95);
            this.mmidtxt.Name = "mmidtxt";
            this.mmidtxt.Size = new System.Drawing.Size(114, 20);
            this.mmidtxt.TabIndex = 2;
            // 
            // mydetailsbtn
            // 
            this.mydetailsbtn.Location = new System.Drawing.Point(4, 3);
            this.mydetailsbtn.Name = "mydetailsbtn";
            this.mydetailsbtn.Size = new System.Drawing.Size(179, 40);
            this.mydetailsbtn.TabIndex = 1;
            this.mydetailsbtn.Text = "Show My Details";
            this.mydetailsbtn.UseVisualStyleBackColor = true;
            this.mydetailsbtn.Click += new System.EventHandler(this.mydetailsbtn_Click);
            // 
            // Detailsbtn
            // 
            this.Detailsbtn.Location = new System.Drawing.Point(4, 49);
            this.Detailsbtn.Name = "Detailsbtn";
            this.Detailsbtn.Size = new System.Drawing.Size(179, 40);
            this.Detailsbtn.TabIndex = 0;
            this.Detailsbtn.Text = "Show All Students";
            this.Detailsbtn.UseVisualStyleBackColor = true;
            this.Detailsbtn.Click += new System.EventHandler(this.Detailsbtn_Click);
            // 
            // dataGridView1st
            // 
            this.dataGridView1st.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1st.Location = new System.Drawing.Point(219, 107);
            this.dataGridView1st.Name = "dataGridView1st";
            this.dataGridView1st.Size = new System.Drawing.Size(913, 158);
            this.dataGridView1st.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 46);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT COURSE DETAILS";
            // 
            // membackbtn
            // 
            this.membackbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membackbtn.Location = new System.Drawing.Point(8, 4);
            this.membackbtn.Name = "membackbtn";
            this.membackbtn.Size = new System.Drawing.Size(75, 35);
            this.membackbtn.TabIndex = 5;
            this.membackbtn.Text = "Back";
            this.membackbtn.UseVisualStyleBackColor = true;
            this.membackbtn.Click += new System.EventHandler(this.regbackbtn_Click);
            // 
            // MM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 450);
            this.Controls.Add(this.membackbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1st);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MM";
            this.Load += new System.EventHandler(this.MM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1st)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Detailsbtn;
        private System.Windows.Forms.DataGridView dataGridView1st;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button membackbtn;
        private System.Windows.Forms.Button mydetailsbtn;
        private System.Windows.Forms.Label mmlbl;
        private System.Windows.Forms.Button mmsearchbtn;
        private System.Windows.Forms.TextBox mmidtxt;
    }
}