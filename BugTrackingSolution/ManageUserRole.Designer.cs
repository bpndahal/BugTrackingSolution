namespace BugTrackingSolution
{
    partial class ManageUserRole
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.txtuserrole = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUserRole = new System.Windows.Forms.DataGridView();
            this.gbUserRoleInfo = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRole)).BeginInit();
            this.gbUserRoleInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Role Management";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(102, 79);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(289, 71);
            this.txtdescription.TabIndex = 2;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(318, 166);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(237, 166);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description:";
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(156, 166);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txtuserrole
            // 
            this.txtuserrole.Location = new System.Drawing.Point(102, 38);
            this.txtuserrole.Name = "txtuserrole";
            this.txtuserrole.Size = new System.Drawing.Size(289, 21);
            this.txtuserrole.TabIndex = 2;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(75, 166);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvUserRole);
            this.panel1.Location = new System.Drawing.Point(19, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 186);
            this.panel1.TabIndex = 8;
            // 
            // dgvUserRole
            // 
            this.dgvUserRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserRole.Location = new System.Drawing.Point(0, 0);
            this.dgvUserRole.Name = "dgvUserRole";
            this.dgvUserRole.Size = new System.Drawing.Size(410, 186);
            this.dgvUserRole.TabIndex = 0;
            this.dgvUserRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserRole_CellClick);
            // 
            // gbUserRoleInfo
            // 
            this.gbUserRoleInfo.Controls.Add(this.txtdescription);
            this.gbUserRoleInfo.Controls.Add(this.btncancel);
            this.gbUserRoleInfo.Controls.Add(this.label1);
            this.gbUserRoleInfo.Controls.Add(this.btndelete);
            this.gbUserRoleInfo.Controls.Add(this.label3);
            this.gbUserRoleInfo.Controls.Add(this.btnedit);
            this.gbUserRoleInfo.Controls.Add(this.txtuserrole);
            this.gbUserRoleInfo.Controls.Add(this.btnadd);
            this.gbUserRoleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserRoleInfo.Location = new System.Drawing.Point(19, 48);
            this.gbUserRoleInfo.Name = "gbUserRoleInfo";
            this.gbUserRoleInfo.Size = new System.Drawing.Size(410, 200);
            this.gbUserRoleInfo.TabIndex = 7;
            this.gbUserRoleInfo.TabStop = false;
            this.gbUserRoleInfo.Text = "Please provide user role details -";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 42);
            this.panel2.TabIndex = 9;
            // 
            // ManageUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbUserRoleInfo);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageUserRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUserRole";
            this.Load += new System.EventHandler(this.ManageUserRole_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRole)).EndInit();
            this.gbUserRoleInfo.ResumeLayout(false);
            this.gbUserRoleInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.TextBox txtuserrole;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUserRole;
        private System.Windows.Forms.GroupBox gbUserRoleInfo;
        private System.Windows.Forms.Panel panel2;
    }
}