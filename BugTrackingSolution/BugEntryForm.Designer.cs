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
            this.label2.Location = new System.Drawing.Point(88, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Snap Of Error Message:";
            // 
            // picsnap
            // 
            this.picsnap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picsnap.Location = new System.Drawing.Point(7, 30);
            this.picsnap.Name = "picsnap";
            this.picsnap.Size = new System.Drawing.Size(355, 242);
            this.picsnap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picsnap.TabIndex = 15;
            this.picsnap.TabStop = false;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(145, 278);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
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
            this.pnlsnapinfo.Location = new System.Drawing.Point(334, 57);
            this.pnlsnapinfo.Name = "pnlsnapinfo";
            this.pnlsnapinfo.Size = new System.Drawing.Size(367, 305);
            this.pnlsnapinfo.TabIndex = 29;
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(123, 246);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(200, 132);
            this.txtcode.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 254);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 16);
            this.label20.TabIndex = 20;
            this.label20.Text = "Code:";
            // 
            // txtbugdetails
            // 
            this.txtbugdetails.Location = new System.Drawing.Point(123, 221);
            this.txtbugdetails.Name = "txtbugdetails";
            this.txtbugdetails.Size = new System.Drawing.Size(200, 20);
            this.txtbugdetails.TabIndex = 19;
            // 
            // txtlinenumber
            // 
            this.txtlinenumber.Location = new System.Drawing.Point(123, 195);
            this.txtlinenumber.Name = "txtlinenumber";
            this.txtlinenumber.Size = new System.Drawing.Size(200, 20);
            this.txtlinenumber.TabIndex = 19;
            // 
            // txtblock
            // 
            this.txtblock.Location = new System.Drawing.Point(123, 168);
            this.txtblock.Name = "txtblock";
            this.txtblock.Size = new System.Drawing.Size(200, 20);
            this.txtblock.TabIndex = 19;
            // 
            // txtmethod
            // 
            this.txtmethod.Location = new System.Drawing.Point(123, 140);
            this.txtmethod.Name = "txtmethod";
            this.txtmethod.Size = new System.Drawing.Size(200, 20);
            this.txtmethod.TabIndex = 19;
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(123, 114);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(200, 20);
            this.txtclass.TabIndex = 19;
            // 
            // txtclasslibrary
            // 
            this.txtclasslibrary.Location = new System.Drawing.Point(123, 85);
            this.txtclasslibrary.Name = "txtclasslibrary";
            this.txtclasslibrary.Size = new System.Drawing.Size(200, 20);
            this.txtclasslibrary.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 50);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug Entry Form";
            // 
            // dgvDetectedBugInfo
            // 
            this.dgvDetectedBugInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetectedBugInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetectedBugInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetectedBugInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvDetectedBugInfo.Name = "dgvDetectedBugInfo";
            this.dgvDetectedBugInfo.Size = new System.Drawing.Size(698, 111);
            this.dgvDetectedBugInfo.TabIndex = 0;
            this.dgvDetectedBugInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetectedBugInfo_CellClick);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(622, 367);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
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
            this.pnlbuginfo.Location = new System.Drawing.Point(2, 57);
            this.pnlbuginfo.Name = "pnlbuginfo";
            this.pnlbuginfo.Size = new System.Drawing.Size(326, 381);
            this.pnlbuginfo.TabIndex = 26;
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Location = new System.Drawing.Point(123, 57);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(200, 21);
            this.cmbProjectName.TabIndex = 18;
            // 
            // cmbBugIdentifiedBy
            // 
            this.cmbBugIdentifiedBy.FormattingEnabled = true;
            this.cmbBugIdentifiedBy.Location = new System.Drawing.Point(123, 30);
            this.cmbBugIdentifiedBy.Name = "cmbBugIdentifiedBy";
            this.cmbBugIdentifiedBy.Size = new System.Drawing.Size(200, 21);
            this.cmbBugIdentifiedBy.TabIndex = 18;
            // 
            // datedate
            // 
            this.datedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedate.Location = new System.Drawing.Point(123, 2);
            this.datedate.Name = "datedate";
            this.datedate.Size = new System.Drawing.Size(200, 20);
            this.datedate.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Identified By:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Project:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Class Library:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Class:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Method:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "Block:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(18, 221);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 16);
            this.label18.TabIndex = 3;
            this.label18.Text = "Bug Details:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 195);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "Line Number:";
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(436, 367);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 30;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(526, 368);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 22);
            this.btndelete.TabIndex = 28;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(341, 367);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 31;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDetectedBugInfo);
            this.panel3.Location = new System.Drawing.Point(2, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(698, 111);
            this.panel3.TabIndex = 32;
            // 
            // BugEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 565);
            this.Controls.Add(this.pnlsnapinfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.pnlbuginfo);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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