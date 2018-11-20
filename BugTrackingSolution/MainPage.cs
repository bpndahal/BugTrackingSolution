using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSolution
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void manageMamberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMember MM = new ManageMember();
            MM.Show();
        }

        private void manageProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManagement PM = new ProjectManagement();
            PM.Show();
        }

        private void manageMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MembersinProject MP = new MembersinProject();
            MP.Show();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUser MU = new ManageUser();
            MU.Show();
        }

        private void manageUserRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUserRole MUR = new ManageUserRole();
            MUR.Show();
        }

        private void bugEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BugEntryForm BE = new BugEntryForm();
            BE.Show();
        }

        private void bugSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterBugSolution RBS = new RegisterBugSolution();
            RBS.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm frm = new LoginForm();
            frm.Show();
        }
    }
}
