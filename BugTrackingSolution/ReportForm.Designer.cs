namespace BugTrackingSolution
{
    partial class ReportForm
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
            this.lblNumberOfBugFixed = new System.Windows.Forms.Label();
            this.lblTotalNumberOfMembers = new System.Windows.Forms.Label();
            this.lblNumberOfBugRegistered = new System.Windows.Forms.Label();
            this.lblTotalProjects = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvInformationDashboard = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformationDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfBugFixed
            // 
            this.lblNumberOfBugFixed.AutoSize = true;
            this.lblNumberOfBugFixed.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfBugFixed.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfBugFixed.Location = new System.Drawing.Point(309, 41);
            this.lblNumberOfBugFixed.Name = "lblNumberOfBugFixed";
            this.lblNumberOfBugFixed.Size = new System.Drawing.Size(188, 22);
            this.lblNumberOfBugFixed.TabIndex = 2;
            this.lblNumberOfBugFixed.Text = "TOTAL BUG FIXED : 0";
            // 
            // lblTotalNumberOfMembers
            // 
            this.lblTotalNumberOfMembers.AutoSize = true;
            this.lblTotalNumberOfMembers.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumberOfMembers.ForeColor = System.Drawing.Color.White;
            this.lblTotalNumberOfMembers.Location = new System.Drawing.Point(309, 7);
            this.lblTotalNumberOfMembers.Name = "lblTotalNumberOfMembers";
            this.lblTotalNumberOfMembers.Size = new System.Drawing.Size(183, 22);
            this.lblTotalNumberOfMembers.TabIndex = 3;
            this.lblTotalNumberOfMembers.Text = "TOTAL MEMBERS : 0";
            // 
            // lblNumberOfBugRegistered
            // 
            this.lblNumberOfBugRegistered.AutoSize = true;
            this.lblNumberOfBugRegistered.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfBugRegistered.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfBugRegistered.Location = new System.Drawing.Point(16, 42);
            this.lblNumberOfBugRegistered.Name = "lblNumberOfBugRegistered";
            this.lblNumberOfBugRegistered.Size = new System.Drawing.Size(248, 22);
            this.lblNumberOfBugRegistered.TabIndex = 4;
            this.lblNumberOfBugRegistered.Text = "TOTAL BUG REGISTERED : 0";
            // 
            // lblTotalProjects
            // 
            this.lblTotalProjects.AutoSize = true;
            this.lblTotalProjects.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProjects.ForeColor = System.Drawing.Color.White;
            this.lblTotalProjects.Location = new System.Drawing.Point(16, 7);
            this.lblTotalProjects.Name = "lblTotalProjects";
            this.lblTotalProjects.Size = new System.Drawing.Size(182, 22);
            this.lblTotalProjects.TabIndex = 5;
            this.lblTotalProjects.Text = "TOTAL PROJECTS : 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(533, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Search Bug";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(645, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(273, 30);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvInformationDashboard);
            this.panel1.Location = new System.Drawing.Point(20, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 430);
            this.panel1.TabIndex = 8;
            // 
            // dgvInformationDashboard
            // 
            this.dgvInformationDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInformationDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformationDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInformationDashboard.Location = new System.Drawing.Point(0, 0);
            this.dgvInformationDashboard.Name = "dgvInformationDashboard";
            this.dgvInformationDashboard.Size = new System.Drawing.Size(898, 430);
            this.dgvInformationDashboard.TabIndex = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblNumberOfBugFixed);
            this.Controls.Add(this.lblTotalNumberOfMembers);
            this.Controls.Add(this.lblNumberOfBugRegistered);
            this.Controls.Add(this.lblTotalProjects);
            this.Controls.Add(this.label5);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformationDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumberOfBugFixed;
        private System.Windows.Forms.Label lblTotalNumberOfMembers;
        private System.Windows.Forms.Label lblNumberOfBugRegistered;
        private System.Windows.Forms.Label lblTotalProjects;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvInformationDashboard;
    }
}