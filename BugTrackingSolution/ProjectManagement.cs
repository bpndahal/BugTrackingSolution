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

namespace BugTrackingSolution
{
    public partial class ProjectManagement : Form
    {
        public ProjectManagement()
        {
            InitializeComponent();
        }
        ProjectClass projectClass = new ProjectClass();
        BusinessLogicClass businessLogicClass = new BusinessLogicClass();
        public int projectId;

        private void ProjectManagement_Load(object sender, EventArgs e)
        {
            dgvProjectInformation.DataSource = projectClass.getAllProjects();

        }

        private void dgvProjectInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                projectId = Convert.ToInt32(dgvProjectInformation.SelectedRows[0].Cells["projectId"].Value.ToString());
                cmbpname.Text = dgvProjectInformation.SelectedRows[0].Cells["projectName"].Value.ToString();
                datestart.Text = dgvProjectInformation.SelectedRows[0].Cells["projectStartDate"].Value.ToString();
                dateend.Text = dgvProjectInformation.SelectedRows[0].Cells["projectEndDate"].Value.ToString();
                txtdescription.Text = dgvProjectInformation.SelectedRows[0].Cells["projectDescription"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void addProject()
        {
            try
            {
                bool result = businessLogicClass.manageProjects(0, cmbpname.Text, Convert.ToDateTime(datestart.Text), Convert.ToDateTime(dateend.Text), txtdescription.Text, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW PROJECT HAS BEEN SUCCESSFULLY ADDED");
                    dgvProjectInformation.DataSource = projectClass.getAllProjects();
                    AssistantClass.makeFieldsBlank(gbprojectmanage);
                }
                else
                {
                    MessageBox.Show("ERROR ON ADDING NEW PROJECT");
                    dgvProjectInformation.DataSource = projectClass.getAllProjects();
                    AssistantClass.makeFieldsBlank(gbprojectmanage);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cmbpname.Text == "")
                MessageBox.Show("Please Provide Project Name");
            else if (datestart.Text == "")
                MessageBox.Show("Please Select Start Date");
            else if (dateend.Text == "")
                MessageBox.Show("Please Select End Date");
            else if (txtdescription.Text == "")
                MessageBox.Show("Please Provide Description");
            else
            {
                try
                {
                    if (cmbpname.Text == "")
                    {
                        MessageBox.Show("Please Provide Project Name");
                        cmbpname.Focus();
                    }
                    else if (txtdescription.Text == "")
                    {
                        MessageBox.Show("Please Provide Description for " + cmbpname.Text);
                        txtdescription.Focus();
                    }
                    else if (datestart.Text == dateend.Text)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure the project will complete in a single day", "Consider the Project Interval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.No)
                        {
                            dateend.Focus();
                        }
                        else
                        {
                            addProject();
                        }
                    }
                    else
                    {
                        addProject();
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
            if (cmbpname.Text == "")
                MessageBox.Show("Please Provide Project Name");
            else if (datestart.Text == "")
                MessageBox.Show("Please Select Start Date");
            else if (dateend.Text == "")
                MessageBox.Show("Please Select End Date");
            else if (txtdescription.Text == "")
                MessageBox.Show("Please Provide Description");
            else
            {
                try
                {
                    bool result = businessLogicClass.manageProjects(projectId, cmbpname.Text, Convert.ToDateTime(datestart.Text), Convert.ToDateTime(dateend.Text), txtdescription.Text, 2);
                    if (result == true)
                    {
                        MessageBox.Show("PROJECT INFORMATION HAS BEEN SUCCESSFULLY UPDATED");
                        dgvProjectInformation.DataSource = projectClass.getAllProjects();
                        AssistantClass.makeFieldsBlank(gbprojectmanage);
                    }
                    else
                    {
                        MessageBox.Show("ERROR ON UPDATING PROJECT INFORMATION");
                        dgvProjectInformation.DataSource = projectClass.getAllProjects();
                        AssistantClass.makeFieldsBlank(gbprojectmanage);
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
                bool result = businessLogicClass.manageProjects(projectId, cmbpname.Text, Convert.ToDateTime(datestart.Text), Convert.ToDateTime(dateend.Text), txtdescription.Text,3);
                if (result == true)
                {
                    MessageBox.Show("PROJECT INFORMATION HAS BEEN SUCCESSFULLY DELETED");
                    dgvProjectInformation.DataSource = projectClass.getAllProjects();
                    AssistantClass.makeFieldsBlank(gbprojectmanage);
                }
                else
                {
                    MessageBox.Show("ERROR ON DELETING PROJECT INFORMATION");
                    dgvProjectInformation.DataSource = projectClass.getAllProjects();
                    AssistantClass.makeFieldsBlank(gbprojectmanage);
                }
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
    }
}
