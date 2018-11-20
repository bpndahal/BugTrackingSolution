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
    public partial class BugEntryForm : Form
    {
        public BugEntryForm()
        {
            InitializeComponent();
        }
        ProjectClass projectClass = new ProjectClass();
        MemberClass memberClass = new MemberClass();
        BugEntryClass bugEntryClass = new BugEntryClass();
        BusinessLogicClass businessLogicClass = new BusinessLogicClass();
        int bugId;

        private void BugEntryForm_Load(object sender, EventArgs e)
        {
            dgvDetectedBugInfo.DataSource = bugEntryClass.getAllBugs();
            cmbBugIdentifiedBy.DataSource = memberClass.getAllMembers();
            cmbBugIdentifiedBy.DisplayMember = "memberName";
            cmbBugIdentifiedBy.ValueMember = "memberId";
            cmbBugIdentifiedBy.SelectedIndex = -1;
            cmbProjectName.DataSource = projectClass.getAllProjects();
            cmbProjectName.ValueMember = "projectId";
            cmbProjectName.DisplayMember = "projectName";
            cmbProjectName.SelectedIndex = -1;
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picsnap.Image = Image.FromFile(ofd.FileName);

                }
                else
                {
                    MessageBox.Show("Please select a profile picture");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                bool result = businessLogicClass.manageBugs(0, Convert.ToDateTime(datedate.Text), Convert.ToInt32(cmbBugIdentifiedBy.SelectedValue.ToString()), Convert.ToInt32(cmbProjectName.SelectedValue.ToString()), txtclasslibrary.Text, txtclass.Text, txtmethod.Text, txtblock.Text, txtlinenumber.Text, txtbugdetails.Text, AssistantClass.imageConverter(picsnap), txtcode.Text, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW BUG RECORD HAS BEEN ADDED");
                    dgvDetectedBugInfo.DataSource = bugEntryClass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlsnapinfo);
                    AssistantClass.makeFieldsBlank(pnlbuginfo);

                    picsnap.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN ADDING BUG RECORD");
                    dgvDetectedBugInfo.DataSource = bugEntryClass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlsnapinfo);
                    AssistantClass.makeFieldsBlank(pnlbuginfo);
                    picsnap.Image = null;
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Some fields cann't be null");
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {

                bool result = businessLogicClass.manageBugs(bugId, Convert.ToDateTime(datedate.Text), Convert.ToInt32(cmbBugIdentifiedBy.SelectedValue.ToString()), Convert.ToInt32(cmbProjectName.SelectedValue.ToString()), txtclasslibrary.Text, txtclass.Text, txtmethod.Text, txtblock.Text, txtlinenumber.Text, txtbugdetails.Text, AssistantClass.imageConverter(picsnap), txtcode.Text, 2);
                if (result == true)
                {
                    MessageBox.Show("EXISTING BUG RECORD HAS BEEN UPDATED");
                    dgvDetectedBugInfo.DataSource = bugEntryClass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlsnapinfo);
                    AssistantClass.makeFieldsBlank(pnlbuginfo);

                    picsnap.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN UPDATING BUG RECORD");
                    dgvDetectedBugInfo.DataSource = bugEntryClass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlsnapinfo);
                    AssistantClass.makeFieldsBlank(pnlbuginfo);
                    picsnap.Image = null;
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Some fields cann't be null");
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                bool result = businessLogicClass.manageBugs(bugId, Convert.ToDateTime(datedate.Text), Convert.ToInt32(cmbBugIdentifiedBy.SelectedValue.ToString()), Convert.ToInt32(cmbProjectName.SelectedValue.ToString()), txtclasslibrary.Text, txtclass.Text, txtmethod.Text, txtblock.Text, txtlinenumber.Text, txtbugdetails.Text, AssistantClass.imageConverter(picsnap), txtcode.Text, 3);
                if (result == true)
                {
                    MessageBox.Show("EXISTING BUG RECORD HAS BEEN DELETED");
                    dgvDetectedBugInfo.DataSource = bugEntryClass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlsnapinfo);
                    AssistantClass.makeFieldsBlank(pnlbuginfo);

                    picsnap.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN DELETING BUG RECORD");
                    dgvDetectedBugInfo.DataSource = bugEntryClass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlsnapinfo);
                    AssistantClass.makeFieldsBlank(pnlbuginfo);
                    picsnap.Image = null;
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Some fields cann't be null");
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDetectedBugInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bugId = Convert.ToInt32(dgvDetectedBugInfo.SelectedRows[0].Cells["bugId"].Value.ToString());
                datedate.Text = dgvDetectedBugInfo.SelectedRows[0].Cells["bugIdentifiedDate"].Value.ToString();
                cmbBugIdentifiedBy.Text = dgvDetectedBugInfo.SelectedRows[0].Cells["projectName"].Value.ToString();
                cmbProjectName.Text = dgvDetectedBugInfo.SelectedRows[0].Cells["projectName"].Value.ToString();
                txtclasslibrary.Text = dgvDetectedBugInfo.SelectedRows[0].Cells["classLibraryName"].Value.ToString();
                txtclass.Text = dgvDetectedBugInfo.SelectedRows[0].Cells["className"].Value.ToString();
                txtmethod.Text = dgvDetectedBugInfo.SelectedRows[0].Cells["methodName"].Value.ToString();
                txtblock.Text = dgvDetectedBugInfo.SelectedRows[0].Cells["blockName"].Value.ToString();
                txtlinenumber.Text = dgvDetectedBugInfo.SelectedRows[0].Cells["lineNumber"].Value.ToString();
                txtbugdetails.Text = dgvDetectedBugInfo.SelectedRows[0].Cells["bugDetails"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvDetectedBugInfo.SelectedRows[0].Cells["snapShotOfBugMessage"].Value);
                picsnap.Image = Image.FromStream(memoryStream);
                txtcode.Text = dgvDetectedBugInfo.SelectedRows[0].Cells["codeContainingBug"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
