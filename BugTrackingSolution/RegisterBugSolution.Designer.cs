namespace BugTrackingSolution
{
    partial class RegisterBugSolution
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
            this.picsnap = new System.Windows.Forms.PictureBox();
            this.cmbproject = new System.Windows.Forms.ComboBox();
            this.dgvBugSolutions = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.datedate = new System.Windows.Forms.DateTimePicker();
            this.txtsolutiondetails = new System.Windows.Forms.TextBox();
            this.cmbbugdetails = new System.Windows.Forms.ComboBox();
            this.cmbbugsolvedby = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbbugsolninfo = new System.Windows.Forms.GroupBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picsnap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugSolutions)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbbugsolninfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picsnap
            // 
            this.picsnap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picsnap.Location = new System.Drawing.Point(32, 199);
            this.picsnap.Margin = new System.Windows.Forms.Padding(4);
            this.picsnap.Name = "picsnap";
            this.picsnap.Size = new System.Drawing.Size(439, 237);
            this.picsnap.TabIndex = 41;
            this.picsnap.TabStop = false;
            // 
            // cmbproject
            // 
            this.cmbproject.FormattingEnabled = true;
            this.cmbproject.Location = new System.Drawing.Point(203, 60);
            this.cmbproject.Margin = new System.Windows.Forms.Padding(4);
            this.cmbproject.Name = "cmbproject";
            this.cmbproject.Size = new System.Drawing.Size(268, 24);
            this.cmbproject.TabIndex = 10;
            this.cmbproject.SelectedIndexChanged += new System.EventHandler(this.cmbproject_SelectedIndexChanged);
            // 
            // dgvBugSolutions
            // 
            this.dgvBugSolutions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBugSolutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBugSolutions.Location = new System.Drawing.Point(0, 0);
            this.dgvBugSolutions.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBugSolutions.Name = "dgvBugSolutions";
            this.dgvBugSolutions.Size = new System.Drawing.Size(1049, 218);
            this.dgvBugSolutions.TabIndex = 1;
            this.dgvBugSolutions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBugSolutions_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvBugSolutions);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(13, 538);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 218);
            this.panel1.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 229);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(956, 229);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 28);
            this.btndelete.TabIndex = 35;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // datedate
            // 
            this.datedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedate.Location = new System.Drawing.Point(203, 31);
            this.datedate.Margin = new System.Windows.Forms.Padding(4);
            this.datedate.Name = "datedate";
            this.datedate.Size = new System.Drawing.Size(268, 22);
            this.datedate.TabIndex = 32;
            // 
            // txtsolutiondetails
            // 
            this.txtsolutiondetails.Location = new System.Drawing.Point(203, 92);
            this.txtsolutiondetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtsolutiondetails.Multiline = true;
            this.txtsolutiondetails.Name = "txtsolutiondetails";
            this.txtsolutiondetails.Size = new System.Drawing.Size(268, 86);
            this.txtsolutiondetails.TabIndex = 31;
            // 
            // cmbbugdetails
            // 
            this.cmbbugdetails.FormattingEnabled = true;
            this.cmbbugdetails.Location = new System.Drawing.Point(678, 61);
            this.cmbbugdetails.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbugdetails.Name = "cmbbugdetails";
            this.cmbbugdetails.Size = new System.Drawing.Size(236, 24);
            this.cmbbugdetails.TabIndex = 10;
            this.cmbbugdetails.SelectedIndexChanged += new System.EventHandler(this.cmbbugdetails_SelectedIndexChanged);
            // 
            // cmbbugsolvedby
            // 
            this.cmbbugsolvedby.FormattingEnabled = true;
            this.cmbbugsolvedby.Location = new System.Drawing.Point(678, 31);
            this.cmbbugsolvedby.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbugsolvedby.Name = "cmbbugsolvedby";
            this.cmbbugsolvedby.Size = new System.Drawing.Size(236, 24);
            this.cmbbugsolvedby.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Solution Details:";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(956, 115);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 27);
            this.btnadd.TabIndex = 36;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 33;
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(956, 171);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(100, 28);
            this.btnedit.TabIndex = 37;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(515, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bug Details:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Project:";
            // 
            // gbbugsolninfo
            // 
            this.gbbugsolninfo.Controls.Add(this.txtcode);
            this.gbbugsolninfo.Controls.Add(this.label7);
            this.gbbugsolninfo.Controls.Add(this.picsnap);
            this.gbbugsolninfo.Controls.Add(this.datedate);
            this.gbbugsolninfo.Controls.Add(this.txtsolutiondetails);
            this.gbbugsolninfo.Controls.Add(this.cmbbugdetails);
            this.gbbugsolninfo.Controls.Add(this.cmbproject);
            this.gbbugsolninfo.Controls.Add(this.cmbbugsolvedby);
            this.gbbugsolninfo.Controls.Add(this.label1);
            this.gbbugsolninfo.Controls.Add(this.label6);
            this.gbbugsolninfo.Controls.Add(this.label5);
            this.gbbugsolninfo.Controls.Add(this.label3);
            this.gbbugsolninfo.Controls.Add(this.label2);
            this.gbbugsolninfo.Location = new System.Drawing.Point(13, 66);
            this.gbbugsolninfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbbugsolninfo.Name = "gbbugsolninfo";
            this.gbbugsolninfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbbugsolninfo.Size = new System.Drawing.Size(930, 464);
            this.gbbugsolninfo.TabIndex = 38;
            this.gbbugsolninfo.TabStop = false;
            this.gbbugsolninfo.Text = "Please Provide The  Required Details";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(499, 136);
            this.txtcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(415, 300);
            this.txtcode.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(578, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Code After Bug Solved:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bug Solved By:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(302, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 31);
            this.label8.TabIndex = 1;
            this.label8.Text = "Register Bug Solution";
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(956, 279);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(100, 27);
            this.btncancel.TabIndex = 34;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(-7, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 52);
            this.panel2.TabIndex = 39;
            // 
            // RegisterBugSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 769);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.gbbugsolninfo);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.panel2);
            this.Name = "RegisterBugSolution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterBugSolution";
            this.Load += new System.EventHandler(this.RegisterBugSolution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picsnap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugSolutions)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbbugsolninfo.ResumeLayout(false);
            this.gbbugsolninfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picsnap;
        private System.Windows.Forms.ComboBox cmbproject;
        private System.Windows.Forms.DataGridView dgvBugSolutions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DateTimePicker datedate;
        private System.Windows.Forms.TextBox txtsolutiondetails;
        private System.Windows.Forms.ComboBox cmbbugdetails;
        private System.Windows.Forms.ComboBox cmbbugsolvedby;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbbugsolninfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label7;
    }
}