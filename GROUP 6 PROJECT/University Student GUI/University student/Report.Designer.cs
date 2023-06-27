namespace University_student
{
    partial class Report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchbtn = new System.Windows.Forms.Button();
            this.usershowbtn = new System.Windows.Forms.Button();
            this.reportidtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lUNGISANIDataSet = new University_student.LUNGISANIDataSet();
            this.lUNGISANIDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regbackbtn = new System.Windows.Forms.Button();
            this.deregusersbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUNGISANIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUNGISANIDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.usershowbtn);
            this.panel1.Controls.Add(this.reportidtxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 209);
            this.panel1.TabIndex = 0;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.Control;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(175, 165);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 35);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // usershowbtn
            // 
            this.usershowbtn.BackColor = System.Drawing.SystemColors.Control;
            this.usershowbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usershowbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usershowbtn.Location = new System.Drawing.Point(5, 165);
            this.usershowbtn.Name = "usershowbtn";
            this.usershowbtn.Size = new System.Drawing.Size(104, 35);
            this.usershowbtn.TabIndex = 2;
            this.usershowbtn.Text = "Show All Students";
            this.usershowbtn.UseVisualStyleBackColor = false;
            this.usershowbtn.Click += new System.EventHandler(this.usershowbtn_Click);
            // 
            // reportidtxt
            // 
            this.reportidtxt.Location = new System.Drawing.Point(59, 65);
            this.reportidtxt.Name = "reportidtxt";
            this.reportidtxt.Size = new System.Drawing.Size(139, 20);
            this.reportidtxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(734, 209);
            this.dataGridView1.TabIndex = 1;
            // 
            // lUNGISANIDataSet
            // 
            this.lUNGISANIDataSet.DataSetName = "LUNGISANIDataSet";
            this.lUNGISANIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lUNGISANIDataSetBindingSource
            // 
            this.lUNGISANIDataSetBindingSource.DataSource = this.lUNGISANIDataSet;
            this.lUNGISANIDataSetBindingSource.Position = 0;
            // 
            // regbackbtn
            // 
            this.regbackbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbackbtn.Location = new System.Drawing.Point(28, 12);
            this.regbackbtn.Name = "regbackbtn";
            this.regbackbtn.Size = new System.Drawing.Size(75, 35);
            this.regbackbtn.TabIndex = 4;
            this.regbackbtn.Text = "Back";
            this.regbackbtn.UseVisualStyleBackColor = true;
            this.regbackbtn.Click += new System.EventHandler(this.regbackbtn_Click);
            // 
            // deregusersbtn
            // 
            this.deregusersbtn.BackColor = System.Drawing.SystemColors.Control;
            this.deregusersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deregusersbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deregusersbtn.Location = new System.Drawing.Point(584, 331);
            this.deregusersbtn.Name = "deregusersbtn";
            this.deregusersbtn.Size = new System.Drawing.Size(171, 35);
            this.deregusersbtn.TabIndex = 7;
            this.deregusersbtn.Text = "Show De-Registred students";
            this.deregusersbtn.UseVisualStyleBackColor = false;
            this.deregusersbtn.Click += new System.EventHandler(this.deregusersbtn_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 378);
            this.Controls.Add(this.deregusersbtn);
            this.Controls.Add(this.regbackbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUNGISANIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUNGISANIDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button usershowbtn;
        private System.Windows.Forms.TextBox reportidtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lUNGISANIDataSetBindingSource;
        private LUNGISANIDataSet lUNGISANIDataSet;
        private System.Windows.Forms.Button regbackbtn;
        private System.Windows.Forms.Button deregusersbtn;
    }
}