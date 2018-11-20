namespace BugTrackingSolution
{
    partial class BugEntryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.picsnap = new System.Windows.Forms.PictureBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.pnlsnapinfo = new System.Windows.Forms.Panel();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtbugdetails = new System.Windows.Forms.TextBox();
            this.txtlinenumber = new System.Windows.Forms.TextBox();
            this.txtblock = new System.Windows.Forms.TextBox();
            this.txtmethod = new System.Windows.Forms.TextBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.txtclasslibrary = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetectedBugInfo = new System.Windows.Forms.DataGridView();
            this.btncancel = new System.Windows.Forms.Button();
            this.pnlbuginfo = new System.Windows.Forms.Panel();
            this.cmbProjectName = new System.Windows.Forms.ComboBox();
            this.cmbBugIdentifiedBy = new System.Windows.Forms.ComboBox();
            this.datedate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picsnap)).BeginInit();
            this.pnlsnapinfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetectedBugInfo)).BeginInit();
            this.pnlbuginfo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Snap Of Error Message:";
            // 
            // picsnap
            // 
            this.picsnap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picsnap.Location = new System.Drawing.Point(9, 37);
            this.picsnap.Margin = new System.Windows.Forms.Padding(4);
            this.picsnap.Name = "picsnap";
            this.picsnap.Size = new System.Drawing.Size(473, 297);
            this.picsnap.TabIndex = 15;
            this.picsnap.TabStop = false;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(193, 342);
            this.btnbrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(100, 28);
            this.btnbrowse.TabIndex = 16;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // pnlsnapinfo
            // 
            this.pnlsnapinfo.Controls.Add(this.label2);
            this.pnlsnapinfo.Controls.Add(this.picsnap);
            this.pnlsnapinfo.Controls.Add(this.btnbrowse);
            this.pnlsnapinfo.Location = new System.Drawing.Point(446, 70);
            this.pnlsnapinfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlsnapinfo.Name = "pnlsnapinfo";
            this.pnlsnapinfo.Size = new System.Drawing.Size(489, 375);
            this.pnlsnapinfo.TabIndex = 29;
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(164, 303);
            this.txtcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(265, 162);
            this.txtcode.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(24, 313);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 20);
            this.label20.TabIndex = 20;
            this.label20.Text = "Code:";
            // 
            // txtbugdetails
            // 
            this.txtbugdetails.Location = new System.Drawing.Point(164, 272);
            this.txtbugdetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtbugdetails.Name = "txtbugdetails";
            this.txtbugdetails.Size = new System.Drawing.Size(265, 22);
            this.txtbugdetails.TabIndex = 19;
            // 
            // txtlinenumber
            // 
            this.txtlinenumber.Location = new System.Drawing.Point(164, 240);
            this.txtlinenumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtlinenumber.Name = "txtlinenumber";
            this.txtlinenumber.Size = new System.Drawing.Size(265, 22);
            this.txtlinenumber.TabIndex = 19;
            // 
            // txtblock
            // 
            this.txtblock.Location = new System.Drawing.Point(164, 207);
            this.txtblock.Margin = new System.Windows.Forms.Padding(4);
            this.txtblock.Name = "txtblock";
            this.txtblock.Size = new System.Drawing.Size(265, 22);
            this.txtblock.TabIndex = 19;
            // 
            // txtmethod
            // 
            this.txtmethod.Location = new System.Drawing.Point(164, 172);
            this.txtmethod.Margin = new System.Windows.Forms.Padding(4);
            this.txtmethod.Name = "txtmethod";
            this.txtmethod.Size = new System.Drawing.Size(265, 22);
            this.txtmethod.TabIndex = 19;
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(164, 140);
            this.txtclass.Margin = new System.Windows.Forms.Padding(4);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(265, 22);
            this.txtclass.TabIndex = 19;
            // 
            // txtclasslibrary
            // 
            this.txtclasslibrary.Location = new System.Drawing.Point(164, 105);
            this.txtclasslibrary.Margin = new System.Windows.Forms.Padding(4);
            this.txtclasslibrary.Name = "txtclasslibrary";
            this.txtclasslibrary.Size = new System.Drawing.Size(265, 22);
            this.txtclasslibrary.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 62);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug Entry Form";
            // 
            // dgvDetectedBugInfo
            // 
            this.dgvDetectedBugInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetectedBugInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetectedBugInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetectedBugInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvDetectedBugInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetectedBugInfo.Name = "dgvDetectedBugInfo";
            this.dgvDetectedBugInfo.Size = new System.Drawing.Size(931, 137);
            this.dgvDetectedBugInfo.TabIndex = 0;
            this.dgvDetectedBugInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetectedBugInfo_CellClick);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(829, 452);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(100, 28);
            this.btncancel.TabIndex = 27;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // pnlbuginfo
            // 
            this.pnlbuginfo.Controls.Add(this.txtcode);
            this.pnlbuginfo.Controls.Add(this.label20);
            this.pnlbuginfo.Controls.Add(this.txtbugdetails);
            this.pnlbuginfo.Controls.Add(this.txtlinenumber);
            this.pnlbuginfo.Controls.Add(this.txtblock);
            this.pnlbuginfo.Controls.Add(this.txtmethod);
            this.pnlbuginfo.Controls.Add(this.txtclass);
            this.pnlbuginfo.Controls.Add(this.txtclasslibrary);
            this.pnlbuginfo.Controls.Add(this.cmbProjectName);
            this.pnlbuginfo.Controls.Add(this.cmbBugIdentifiedBy);
            this.pnlbuginfo.Controls.Add(this.datedate);
            this.pnlbuginfo.Controls.Add(this.label11);
            this.pnlbuginfo.Controls.Add(this.label12);
            this.pnlbuginfo.Controls.Add(this.label13);
            this.pnlbuginfo.Controls.Add(this.label14);
            this.pnlbuginfo.Controls.Add(this.label15);
            this.pnlbuginfo.Controls.Add(this.label16);
            this.pnlbuginfo.Controls.Add(this.label17);
            this.pnlbuginfo.Controls.Add(this.label18);
            this.pnlbuginfo.Controls.Add(this.label19);
            this.pnlbuginfo.Location = new System.Drawing.Point(3, 70);
            this.pnlbuginfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlbuginfo.Name = "pnlbuginfo";
            this.pnlbuginfo.Size = new System.Drawing.Size(435, 469);
            this.pnlbuginfo.TabIndex = 26;
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Location = new System.Drawing.Point(164, 70);
            this.cmbProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(265, 24);
            this.cmbProjectName.TabIndex = 18;
            // 
            // cmbBugIdentifiedBy
            // 
            this.cmbBugIdentifiedBy.FormattingEnabled = true;
            this.cmbBugIdentifiedBy.Location = new System.Drawing.Point(164, 37);
            this.cmbBugIdentifiedBy.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBugIdentifiedBy.Name = "cmbBugIdentifiedBy";
            this.cmbBugIdentifiedBy.Size = new System.Drawing.Size(265, 24);
            this.cmbBugIdentifiedBy.TabIndex = 18;
            // 
            // datedate
            // 
            this.datedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedate.Location = new System.Drawing.Point(164, 2);
            this.datedate.Margin = new System.Windows.Forms.Padding(4);
            this.datedate.Name = "datedate";
            this.datedate.Size = new System.Drawing.Size(265, 22);
            this.datedate.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Identified By:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 66);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Project:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 103);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Class Library:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 138);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Class:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 172);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Method:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 207);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Block:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(24, 272);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 20);
            this.label18.TabIndex = 3;
            this.label18.Text = "Bug Details:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(21, 240);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 20);
            this.label19.TabIndex = 3;
            this.label19.Text = "Line Number:";
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(581, 452);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(100, 28);
            this.btnedit.TabIndex = 30;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(702, 453);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 27);
            this.btndelete.TabIndex = 28;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(455, 452);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 28);
            this.btnadd.TabIndex = 31;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDetectedBugInfo);
            this.panel3.Location = new System.Drawing.Point(3, 546);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(931, 137);
            this.panel3.TabIndex = 32;
            // 
            // BugEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 695);
            this.Controls.Add(this.pnlsnapinfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.pnlbuginfo);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panel3);
            this.Name = "BugEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BugEntryForm";
            this.Load += new System.EventHandler(this.BugEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picsnap)).EndInit();
            this.pnlsnapinfo.ResumeLayout(false);
            this.pnlsnapinfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetectedBugInfo)).EndInit();
            this.pnlbuginfo.ResumeLayout(false);
            this.pnlbuginfo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picsnap;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Panel pnlsnapinfo;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtbugdetails;
        private System.Windows.Forms.TextBox txtlinenumber;
        private System.Windows.Forms.TextBox txtblock;
        private System.Windows.Forms.TextBox txtmethod;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.TextBox txtclasslibrary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetectedBugInfo;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Panel pnlbuginfo;
        private System.Windows.Forms.ComboBox cmbProjectName;
        private System.Windows.Forms.ComboBox cmbBugIdentifiedBy;
        private System.Windows.Forms.DateTimePicker datedate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel3;
    }
}