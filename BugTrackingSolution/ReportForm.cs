using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace BugTrackingSolution
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        ProjectClass projectClass = new ProjectClass();
        MemberClass memberClass = new MemberClass();
        BugEntryClass bugEntry = new BugEntryClass();
        BugSolutionEntryClass bugSolutionEntryClass = new BugSolutionEntryClass();
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvInformationDashboard.DataSource = bugSolutionEntryClass.searchBugSolutionByBugDetails(txtSearch.Text);
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            try
            {

                dgvInformationDashboard.DataSource = bugSolutionEntryClass.getAllBugSolutions();
                lblTotalProjects.Text = "TOTAL PORJECTS: " + projectClass.countNumberOfProjects().ToString();
                lblTotalNumberOfMembers.Text = "TOTAL MEMBERS: " + memberClass.totalMember();
                lblNumberOfBugRegistered.Text = "TOTAL REGISTERED BUGS: " + bugEntry.getAllBugs().Rows.Count.ToString();
                lblNumberOfBugFixed.Text = "TOTAL BUGS FIXED: " + bugSolutionEntryClass.getAllBugSolutions().Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
