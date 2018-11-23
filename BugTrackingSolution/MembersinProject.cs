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
    public partial class MembersinProject : Form
    {
        public MembersinProject()
        {
            InitializeComponent();
        }
        ProjectMemberClass projectMemberClass = new ProjectMemberClass();
        MemberClass memberClass = new MemberClass();
        ProjectClass projectClass = new ProjectClass();
        UserRoleClass userRoleClass = new UserRoleClass();
        BusinessLogicClass businessLogicClass = new BusinessLogicClass();
        public int memberId;
        private void MembersinProject_Load(object sender, EventArgs e)
        {
            dgvMembersInProejctInformation.DataSource = projectMemberClass.getAllMembersInProject();
            cmbmember.DataSource = memberClass.getAllMembers();
            cmbmember.ValueMember = "memberId";
            cmbmember.DisplayMember = "memberName";
            cmbmember.SelectedIndex = -1;

            cmbproject.DataSource = projectClass.getAllProjects();
            cmbproject.ValueMember = "projectId";
            cmbproject.DisplayMember = "projectName";
            cmbproject.SelectedIndex = -1;

            cmbmemberrole.DataSource = userRoleClass.getAllUserRoles();
            cmbmemberrole.ValueMember = "userRoleId";
            cmbmemberrole.DisplayMember = "userRole";
            cmbmemberrole.SelectedIndex = -1;

        }

        private void dgvMembersInProejctInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                memberId = Convert.ToInt32(dgvMembersInProejctInformation.SelectedRows[0].Cells["id"].Value.ToString());
                cmbproject.Text = dgvMembersInProejctInformation.SelectedRows[0].Cells["projectName"].Value.ToString();
                cmbmember.Text = dgvMembersInProejctInformation.SelectedRows[0].Cells["memberName"].Value.ToString();
                cmbmemberrole.Text = dgvMembersInProejctInformation.SelectedRows[0].Cells["memberRole"].Value.ToString();
                txtresposibilities.Text = dgvMembersInProejctInformation.SelectedRows[0].Cells["memberResponsibilities"].Value.ToString();
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
            else if (cmbmember.Text == "")
                MessageBox.Show("Please Select Member");
            else if (cmbmemberrole.Text == "")
                MessageBox.Show("Please Select Member Role");
            else if (txtresposibilities.Text == "")
                MessageBox.Show("Please Provide Description");
            else
            {

                bool result = businessLogicClass.manageProjectMembers(0, Convert.ToInt32(cmbproject.SelectedValue.ToString()), Convert.ToInt32(cmbmember.SelectedValue.ToString()), cmbmemberrole.Text, txtresposibilities.Text, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW MEMBER HAS BEEN ADDED TO THE PROJECT");
                    dgvMembersInProejctInformation.DataSource = projectMemberClass.getAllMembersInProject();
                    AssistantClass.makeFieldsBlank(gbMembersInProejct);
                }
                else
                {
                    MessageBox.Show("ERROR IN ADDING MEMBER IN THE PROJECT");
                    dgvMembersInProejctInformation.DataSource = projectMemberClass.getAllMembersInProject();
                    AssistantClass.makeFieldsBlank(gbMembersInProejct);
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (cmbproject.Text == "")
                MessageBox.Show("Please Provide Project Name");
            else if (cmbmember.Text == "")
                MessageBox.Show("Please Select Member");
            else if (cmbmemberrole.Text == "")
                MessageBox.Show("Please Select Member Role");
            else if (txtresposibilities.Text == "")
                MessageBox.Show("Please Provide Description");
            else
            {

                bool result = businessLogicClass.manageProjectMembers(memberId, Convert.ToInt32(cmbproject.SelectedValue.ToString()), Convert.ToInt32(cmbmember.SelectedValue.ToString()), cmbmemberrole.Text, txtresposibilities.Text, 2);
                if (result == true)
                {
                    MessageBox.Show("MEMBER INFORMATION IN THE PROJECT HAS BEEN MODIFIED");
                    dgvMembersInProejctInformation.DataSource = projectMemberClass.getAllMembersInProject();
                    AssistantClass.makeFieldsBlank(gbMembersInProejct);
                }
                else
                {
                    MessageBox.Show("ERROR IN MODIFYING MEMBER INFORMATION OF THE PROJECT");
                    dgvMembersInProejctInformation.DataSource = projectMemberClass.getAllMembersInProject();
                    AssistantClass.makeFieldsBlank(gbMembersInProejct);
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            bool result = businessLogicClass.manageProjectMembers(memberId, Convert.ToInt32(cmbproject.SelectedValue.ToString()), Convert.ToInt32(cmbmember.SelectedValue.ToString()), cmbmemberrole.Text, txtresposibilities.Text, 3);
            if (result == true)
            {
                MessageBox.Show("MEMBER INFORMATION IN THE PROJECT HAS BEEN REMOVED");
                dgvMembersInProejctInformation.DataSource = projectMemberClass.getAllMembersInProject();
                AssistantClass.makeFieldsBlank(gbMembersInProejct);
            }
            else
            {
                MessageBox.Show("ERROR IN REMOVING MEMBER INFORMATION OF THE PROJECT");
                dgvMembersInProejctInformation.DataSource = projectMemberClass.getAllMembersInProject();
                AssistantClass.makeFieldsBlank(gbMembersInProejct);
            }
        }
    }
}
