﻿namespace BugTrackingSolution
{
    partial class ManageMember
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
            this.dgvMemberInformation = new System.Windows.Forms.DataGridView();
            this.btncancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.pnlMemberInformation = new System.Windows.Forms.Panel();
            this.datedoj = new System.Windows.Forms.DateTimePicker();
            this.datedob = new System.Windows.Forms.DateTimePicker();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.pnlMemberInformation.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMemberInformation
            // 
            this.dgvMemberInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberInformation.Location = new System.Drawing.Point(0, 0);
            this.dgvMemberInformation.Name = "dgvMemberInformation";
            this.dgvMemberInformation.Size = new System.Drawing.Size(458, 111);
            this.dgvMemberInformation.TabIndex = 0;
            this.dgvMemberInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberInformation_CellClick);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(298, 362);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 20;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contact Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email Address:";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(203, 362);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(112, 362);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 22;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(14, 362);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 23;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(304, 183);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 16;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProfilePicture.Location = new System.Drawing.Point(260, 26);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(187, 151);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilePicture.TabIndex = 15;
            this.pbProfilePicture.TabStop = false;
            // 
            // pnlMemberInformation
            // 
            this.pnlMemberInformation.Controls.Add(this.btnbrowse);
            this.pnlMemberInformation.Controls.Add(this.pbProfilePicture);
            this.pnlMemberInformation.Controls.Add(this.label3);
            this.pnlMemberInformation.Controls.Add(this.datedoj);
            this.pnlMemberInformation.Controls.Add(this.label2);
            this.pnlMemberInformation.Controls.Add(this.datedob);
            this.pnlMemberInformation.Controls.Add(this.label4);
            this.pnlMemberInformation.Controls.Add(this.cmbgender);
            this.pnlMemberInformation.Controls.Add(this.label5);
            this.pnlMemberInformation.Controls.Add(this.txtemail);
            this.pnlMemberInformation.Controls.Add(this.label6);
            this.pnlMemberInformation.Controls.Add(this.txtcontact);
            this.pnlMemberInformation.Controls.Add(this.label7);
            this.pnlMemberInformation.Controls.Add(this.txtdescription);
            this.pnlMemberInformation.Controls.Add(this.label8);
            this.pnlMemberInformation.Controls.Add(this.txtaddress);
            this.pnlMemberInformation.Controls.Add(this.txtfullname);
            this.pnlMemberInformation.Controls.Add(this.label9);
            this.pnlMemberInformation.Location = new System.Drawing.Point(2, 55);
            this.pnlMemberInformation.Name = "pnlMemberInformation";
            this.pnlMemberInformation.Size = new System.Drawing.Size(458, 292);
            this.pnlMemberInformation.TabIndex = 19;
            // 
            // datedoj
            // 
            this.datedoj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedoj.Location = new System.Drawing.Point(141, 188);
            this.datedoj.Name = "datedoj";
            this.datedoj.Size = new System.Drawing.Size(100, 20);
            this.datedoj.TabIndex = 14;
            // 
            // datedob
            // 
            this.datedob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedob.Location = new System.Drawing.Point(141, 162);
            this.datedob.Name = "datedob";
            this.datedob.Size = new System.Drawing.Size(100, 20);
            this.datedob.TabIndex = 14;
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbgender.Location = new System.Drawing.Point(141, 138);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(100, 21);
            this.cmbgender.TabIndex = 13;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(141, 106);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gender:";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(141, 80);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(100, 20);
            this.txtcontact.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Date Of Birth:";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(141, 216);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(314, 69);
            this.txtdescription.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Date Of Join:";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(141, 52);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaddress.TabIndex = 4;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(141, 26);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(100, 20);
            this.txtfullname.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Description:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvMemberInformation);
            this.panel3.Location = new System.Drawing.Point(2, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 111);
            this.panel3.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Memeber";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 50);
            this.panel1.TabIndex = 18;
            // 
            // ManageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 522);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.pnlMemberInformation);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageMember";
            this.Load += new System.EventHandler(this.ManageMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.pnlMemberInformation.ResumeLayout(false);
            this.pnlMemberInformation.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMemberInformation;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Panel pnlMemberInformation;
        private System.Windows.Forms.DateTimePicker datedoj;
        private System.Windows.Forms.DateTimePicker datedob;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}