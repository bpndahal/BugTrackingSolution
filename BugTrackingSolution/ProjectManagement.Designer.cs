namespace BugTrackingSolution
{
    partial class ProjectManagement
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.dateend = new System.Windows.Forms.DateTimePicker();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProjectInformation = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gbprojectmanage = new System.Windows.Forms.GroupBox();
            this.cmbpname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectInformation)).BeginInit();
            this.gbprojectmanage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(158, 239);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 20;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // dateend
            // 
            this.dateend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateend.Location = new System.Drawing.Point(143, 72);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(179, 20);
            this.dateend.TabIndex = 14;
            // 
            // datestart
            // 
            this.datestart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datestart.Location = new System.Drawing.Point(143, 48);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(179, 20);
            this.datestart.TabIndex = 14;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(175, 100);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(179, 73);
            this.txtdescription.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Project Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Start Date:";
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(350, 240);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 22);
            this.btncancel.TabIndex = 17;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(251, 239);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(62, 239);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 22);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "End Date:";
            // 
            // dgvProjectInformation
            // 
            this.dgvProjectInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjectInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjectInformation.Location = new System.Drawing.Point(0, 0);
            this.dgvProjectInformation.Name = "dgvProjectInformation";
            this.dgvProjectInformation.Size = new System.Drawing.Size(509, 191);
            this.dgvProjectInformation.TabIndex = 0;
            this.dgvProjectInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjectInformation_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Project Name:";
            // 
            // gbprojectmanage
            // 
            this.gbprojectmanage.Controls.Add(this.cmbpname);
            this.gbprojectmanage.Controls.Add(this.dateend);
            this.gbprojectmanage.Controls.Add(this.datestart);
            this.gbprojectmanage.Controls.Add(this.txtdescription);
            this.gbprojectmanage.Controls.Add(this.label6);
            this.gbprojectmanage.Controls.Add(this.label5);
            this.gbprojectmanage.Controls.Add(this.label3);
            this.gbprojectmanage.Controls.Add(this.label2);
            this.gbprojectmanage.Location = new System.Drawing.Point(62, 49);
            this.gbprojectmanage.Name = "gbprojectmanage";
            this.gbprojectmanage.Size = new System.Drawing.Size(363, 180);
            this.gbprojectmanage.TabIndex = 22;
            this.gbprojectmanage.TabStop = false;
            this.gbprojectmanage.Text = "Please Provide The  Required Details";
            // 
            // cmbpname
            // 
            this.cmbpname.Location = new System.Drawing.Point(143, 24);
            this.cmbpname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbpname.Name = "cmbpname";
            this.cmbpname.Size = new System.Drawing.Size(179, 20);
            this.cmbpname.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProjectInformation);
            this.panel1.Location = new System.Drawing.Point(1, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 191);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 42);
            this.panel2.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Project Management";
            // 
            // ProjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 473);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.gbprojectmanage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProjectManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectManagement";
            this.Load += new System.EventHandler(this.ProjectManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectInformation)).EndInit();
            this.gbprojectmanage.ResumeLayout(false);
            this.gbprojectmanage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProjectInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbprojectmanage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cmbpname;
    }
}