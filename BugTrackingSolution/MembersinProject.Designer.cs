namespace BugTrackingSolution
{
    partial class MembersinProject
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
            this.dgvMembersInProejctInformation = new System.Windows.Forms.DataGridView();
            this.btnedit = new System.Windows.Forms.Button();
            this.txtresposibilities = new System.Windows.Forms.TextBox();
            this.cmbmemberrole = new System.Windows.Forms.ComboBox();
            this.cmbmember = new System.Windows.Forms.ComboBox();
            this.cmbproject = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbMembersInProejct = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersInProejctInformation)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbMembersInProejct.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMembersInProejctInformation
            // 
            this.dgvMembersInProejctInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembersInProejctInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembersInProejctInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembersInProejctInformation.Location = new System.Drawing.Point(0, 0);
            this.dgvMembersInProejctInformation.Name = "dgvMembersInProejctInformation";
            this.dgvMembersInProejctInformation.Size = new System.Drawing.Size(509, 226);
            this.dgvMembersInProejctInformation.TabIndex = 0;
            this.dgvMembersInProejctInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembersInProejctInformation_CellClick);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(152, 240);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 28;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txtresposibilities
            // 
            this.txtresposibilities.Location = new System.Drawing.Point(224, 100);
            this.txtresposibilities.Multiline = true;
            this.txtresposibilities.Name = "txtresposibilities";
            this.txtresposibilities.Size = new System.Drawing.Size(277, 73);
            this.txtresposibilities.TabIndex = 11;
            // 
            // cmbmemberrole
            // 
            this.cmbmemberrole.FormattingEnabled = true;
            this.cmbmemberrole.Location = new System.Drawing.Point(224, 75);
            this.cmbmemberrole.Name = "cmbmemberrole";
            this.cmbmemberrole.Size = new System.Drawing.Size(277, 21);
            this.cmbmemberrole.TabIndex = 10;
            // 
            // cmbmember
            // 
            this.cmbmember.FormattingEnabled = true;
            this.cmbmember.Location = new System.Drawing.Point(224, 48);
            this.cmbmember.Name = "cmbmember";
            this.cmbmember.Size = new System.Drawing.Size(277, 21);
            this.cmbmember.TabIndex = 10;
            // 
            // cmbproject
            // 
            this.cmbproject.FormattingEnabled = true;
            this.cmbproject.Location = new System.Drawing.Point(224, 21);
            this.cmbproject.Name = "cmbproject";
            this.cmbproject.Size = new System.Drawing.Size(277, 21);
            this.cmbproject.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Member Responsibilities:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Member:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(142, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Assign Members in Project";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(58, 240);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 22);
            this.btnadd.TabIndex = 27;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Member Role:";
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(346, 241);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 22);
            this.btncancel.TabIndex = 25;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Project:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMembersInProejctInformation);
            this.panel1.Location = new System.Drawing.Point(8, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 226);
            this.panel1.TabIndex = 31;
            // 
            // gbMembersInProejct
            // 
            this.gbMembersInProejct.Controls.Add(this.txtresposibilities);
            this.gbMembersInProejct.Controls.Add(this.cmbmemberrole);
            this.gbMembersInProejct.Controls.Add(this.cmbmember);
            this.gbMembersInProejct.Controls.Add(this.cmbproject);
            this.gbMembersInProejct.Controls.Add(this.label6);
            this.gbMembersInProejct.Controls.Add(this.label5);
            this.gbMembersInProejct.Controls.Add(this.label3);
            this.gbMembersInProejct.Controls.Add(this.label2);
            this.gbMembersInProejct.Location = new System.Drawing.Point(-2, 54);
            this.gbMembersInProejct.Name = "gbMembersInProejct";
            this.gbMembersInProejct.Size = new System.Drawing.Size(519, 180);
            this.gbMembersInProejct.TabIndex = 29;
            this.gbMembersInProejct.TabStop = false;
            this.gbMembersInProejct.Text = "Please Provide The  Required Details";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(247, 240);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 26;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 42);
            this.panel2.TabIndex = 30;
            // 
            // MembersinProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 500);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbMembersInProejct);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MembersinProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MembersinProject";
            this.Load += new System.EventHandler(this.MembersinProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersInProejctInformation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbMembersInProejct.ResumeLayout(false);
            this.gbMembersInProejct.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMembersInProejctInformation;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.TextBox txtresposibilities;
        private System.Windows.Forms.ComboBox cmbmemberrole;
        private System.Windows.Forms.ComboBox cmbmember;
        private System.Windows.Forms.ComboBox cmbproject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbMembersInProejct;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel panel2;
    }
}