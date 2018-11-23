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
using BusinessLogicLayer;
using System.IO;
namespace BugTrackingSolution
{
    public partial class RegisterBugSolution : Form
    {
        public RegisterBugSolution()
        {
            InitializeComponent();
        }
        int bugSolutionId;
        MemberClass memberClass = new MemberClass();
        ProjectClass projectClass = new ProjectClass();
        BugEntryClass bugEntryClass = new BugEntryClass();
        BugSolutionEntryClass bugSolutionEntryClass = new BugSolutionEntryClass();
        BusinessLogicClass businessLogicClass = new BusinessLogicClass();
        private void RegisterBugSolution_Load(object sender, EventArgs e)
        {
            dgvBugSolutions.DataSource = bugSolutionEntryClass.getAllBugSolutions();

            cmbproject.DataSource = projectClass.getAllProjects();
            cmbproject.ValueMember = "projectId";
            cmbproject.DisplayMember = "projectName";
            cmbproject.SelectedIndex = -1;

            cmbbugdetails.DataSource = bugEntryClass.getAllBugs();
            cmbbugdetails.ValueMember = "bugId";
            cmbbugdetails.DisplayMember = "bugDetails";
            cmbbugdetails.SelectedIndex = -1;

            cmbbugsolvedby.DataSource = memberClass.getAllMembers();
            cmbbugsolvedby.ValueMember = "memberId";
            cmbbugsolvedby.DisplayMember = "memberName";
            cmbbugsolvedby.SelectedIndex = -1;
        }

        private void cmbproject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbbugdetails.DataSource = bugEntryClass.getBugsInProjectByProjectId(Convert.ToInt32(cmbproject.SelectedValue.ToString()));
                cmbbugdetails.ValueMember = "bugId";
                cmbbugdetails.DisplayMember = "bugDetails";
                cmbbugdetails.SelectedIndex = -1;
            }
            catch (NullReferenceException)
            {


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void cmbbugdetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream((byte[])bugEntryClass.getBugsInProjectByProjectId(cmbproject.SelectedIndex).Rows[0]["snapShotOfBugMessage"]);
                picsnap.Image = Image.FromStream(memoryStream);
                picsnap.Visible = true;
            }
            catch (NullReferenceException)
            {


            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message);
            }
        }

        public void AddBugSolution()
        {

            try
            {
                 if (cmbproject.SelectedIndex < 0)
                {
                    MessageBox.Show("Please choose Project");
                    cmbproject.Focus();
                }
                else if (cmbbugdetails.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select the Bug");
                    cmbbugdetails.Focus();
                }
                else if (txtsolutiondetails.Text == "")
                {
                    MessageBox.Show("Please provide the bug solution");
                    txtsolutiondetails.Focus();
                }
                else if (txtcode.Text == "")
                {
                    MessageBox.Show("Please method the block which was modified after solving bug");
                    txtcode.Focus();
                }
                else
                {
                    AddBugSolution();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cmbproject.Text == "")
                MessageBox.Show("Please Provide Project Name");
            else if (datedate.Text == "")
                MessageBox.Show("Please Select Date");
            else if (cmbbugdetails.Text == "")
                MessageBox.Show("Please Select Big Details");
            else if (cmbbugsolvedby.Text == "")
                MessageBox.Show("Please select Member NAme");
            else if (txtcode.Text == "")
                MessageBox.Show("Please Provide Code");
            else if (picsnap.Image == null)
                MessageBox.Show("Please Upload Screenshot of Bug Occured");
            else
            {

                try
                {
                    bool result = businessLogicClass.manageBugSolutions(0, Convert.ToDateTime(datedate.Text), Convert.ToInt32(cmbproject.SelectedValue.ToString()), Convert.ToInt32(cmbbugdetails.SelectedValue.ToString()), Convert.ToInt32(cmbbugsolvedby.SelectedValue.ToString()), txtsolutiondetails.Text, txtcode.Text, 1);
                    if (result == true)
                    {
                        MessageBox.Show("NEW BUG SOLUTION HAS BEEN REGISTERED");
                        AssistantClass.makeFieldsBlank(gbbugsolninfo);
                        dgvBugSolutions.DataSource = bugSolutionEntryClass.getAllBugSolutions();
                        datedate.Focus();
                    }
                    else
                    {

                        MessageBox.Show("ERROR IN REGISTERING BUG SOLUTION");
                        dgvBugSolutions.DataSource = bugSolutionEntryClass.getAllBugSolutions();
                        AssistantClass.makeFieldsBlank(gbbugsolninfo);
                        datedate.Focus();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (cmbproject.Text == "")
                MessageBox.Show("Please Provide Project Name");
            else if (datedate.Text == "")
                MessageBox.Show("Please Select Date");
            else if (cmbbugdetails.Text == "")
                MessageBox.Show("Please Select Big Details");
            else if (cmbbugsolvedby.Text == "")
                MessageBox.Show("Please select Member NAme");
            else if (txtcode.Text == "")
                MessageBox.Show("Please Provide Code");
            else if (picsnap.Image == null)
                MessageBox.Show("Please Upload Screenshot of Bug Occured");
            else
            {
                try
                {
                    bool result = businessLogicClass.manageBugSolutions(bugSolutionId, Convert.ToDateTime(datedate.Text), Convert.ToInt32(cmbproject.SelectedValue.ToString()), Convert.ToInt32(cmbbugdetails.SelectedValue.ToString()), Convert.ToInt32(cmbbugsolvedby.SelectedValue.ToString()), txtsolutiondetails.Text, txtcode.Text, 2);
                    if (result == true)
                    {
                        MessageBox.Show("EXISTING BUG SOLUTION HAS BEEN MODIFIED");
                        AssistantClass.makeFieldsBlank(gbbugsolninfo);
                        dgvBugSolutions.DataSource = bugSolutionEntryClass.getAllBugSolutions();
                        datedate.Focus();
                    }
                    else
                    {

                        MessageBox.Show("ERROR IN MODIFYING EXISTING BUG SOLUTION");
                        dgvBugSolutions.DataSource = bugSolutionEntryClass.getAllBugSolutions();
                        AssistantClass.makeFieldsBlank(gbbugsolninfo);
                        datedate.Focus();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = businessLogicClass.manageBugSolutions(bugSolutionId, Convert.ToDateTime(datedate.Text), Convert.ToInt32(cmbproject.SelectedValue.ToString()), Convert.ToInt32(cmbbugdetails.SelectedValue.ToString()), Convert.ToInt32(cmbbugsolvedby.SelectedValue.ToString()), txtsolutiondetails.Text, txtcode.Text, 3);
                if (result == true)
                {
                    MessageBox.Show("EXISTING BUG SOLUTION HAS BEEN REMOVED");
                    AssistantClass.makeFieldsBlank(gbbugsolninfo);
                    dgvBugSolutions.DataSource = bugSolutionEntryClass.getAllBugSolutions();
                    datedate.Focus();
                }
                else
                {

                    MessageBox.Show("ERROR IN REMOVING EXISTING BUG SOLUTION");
                    dgvBugSolutions.DataSource = bugSolutionEntryClass.getAllBugSolutions();
                    AssistantClass.makeFieldsBlank(gbbugsolninfo);
                    datedate.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBugSolutions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bugSolutionId = Convert.ToInt32(dgvBugSolutions.SelectedRows[0].Cells["bugSolutionId"].Value.ToString());
                cmbbugsolvedby.Text = dgvBugSolutions.SelectedRows[0].Cells["memberName"].Value.ToString();
                datedate.Text = dgvBugSolutions.SelectedRows[0].Cells["dateOfSolutionIdentified"].Value.ToString();
                cmbproject.Text = dgvBugSolutions.SelectedRows[0].Cells["projectName"].Value.ToString();
                cmbbugdetails.Text = dgvBugSolutions.SelectedRows[0].Cells["bugDetails"].Value.ToString();
                txtsolutiondetails.Text = dgvBugSolutions.SelectedRows[0].Cells["solutionDetails"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvBugSolutions.SelectedRows[0].Cells["snapShotOfBugMessage"].Value);
               picsnap.Image = Image.FromStream(memoryStream);
                txtcode.Text = dgvBugSolutions.SelectedRows[0].Cells["codeAfterFixingBug"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
