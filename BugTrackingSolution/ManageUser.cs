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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        UserClass userClass = new UserClass();
        UserRoleClass userRoleClass = new UserRoleClass();
        MemberClass memberClass = new MemberClass();
        BusinessLogicClass businessLogicClass = new BusinessLogicClass();
        int userId;
        private void ManageUser_Load(object sender, EventArgs e)
        {
            dgvUserInformation.DataSource = userClass.getAllUsers();
            cmbfullname.DataSource = memberClass.getAllMembers();
            cmbfullname.ValueMember = "memberId";
            cmbfullname.DisplayMember = "memberName";
            cmbfullname.SelectedIndex = -1;
            cmbuserrole.DataSource = userRoleClass.getAllUserRoles();
            cmbuserrole.ValueMember = "userRoleId";
            cmbuserrole.DisplayMember = "userRole";
            cmbuserrole.SelectedIndex = -1;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            try
            {
                bool result = businessLogicClass.manageUsers(0, Convert.ToInt32(cmbuserrole.SelectedValue.ToString()), Convert.ToInt32(cmbfullname.SelectedValue.ToString()), txtusername.Text, txtpassword.Text, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW USER HAS BEEN ADDED");
                    dgvUserInformation.DataSource = userClass.getAllUsers();
                    AssistantClass.makeFieldsBlank(dbUserInfo);
                }
                else
                {
                    MessageBox.Show("ERROR ON ADDING NEW USER");
                    dgvUserInformation.DataSource = userClass.getAllUsers();
                    AssistantClass.makeFieldsBlank(dbUserInfo);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = businessLogicClass.manageUsers(userId, Convert.ToInt32(cmbuserrole.SelectedValue.ToString()), Convert.ToInt32(cmbfullname.SelectedValue.ToString()), txtusername.Text, txtpassword.Text, 2);
                if (result == true)
                {
                    MessageBox.Show("NEW USER HAS BEEN UPDATED");
                    dgvUserInformation.DataSource = userClass.getAllUsers();
                    AssistantClass.makeFieldsBlank(dbUserInfo);
                }
                else
                {
                    MessageBox.Show("ERROR ON ADDING NEW UPDAED");
                    dgvUserInformation.DataSource = userClass.getAllUsers();
                    AssistantClass.makeFieldsBlank(dbUserInfo);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = businessLogicClass.manageUsers(userId, Convert.ToInt32(cmbuserrole.SelectedValue.ToString()), Convert.ToInt32(cmbfullname.SelectedValue.ToString()), txtusername.Text, txtpassword.Text, 3);
                if (result == true)
                {
                    MessageBox.Show("NEW USER HAS BEEN DELETED");
                    dgvUserInformation.DataSource = userClass.getAllUsers();
                    AssistantClass.makeFieldsBlank(dbUserInfo);
                }
                else
                {
                    MessageBox.Show("ERROR ON ADDING NEW DELETED");
                    dgvUserInformation.DataSource = userClass.getAllUsers();
                    AssistantClass.makeFieldsBlank(dbUserInfo);
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

        private void dgvUserInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userId = Convert.ToInt32(dgvUserInformation.SelectedRows[0].Cells["ID"].Value.ToString());
                cmbuserrole.Text = dgvUserInformation.SelectedRows[0].Cells["Role"].Value.ToString();
                cmbfullname.Text = dgvUserInformation.SelectedRows[0].Cells["Name"].Value.ToString();
                txtusername.Text = dgvUserInformation.SelectedRows[0].Cells["Username"].Value.ToString();
                txtpassword.Text = dgvUserInformation.SelectedRows[0].Cells["Password"].Value.ToString();
                txtcpassword.Text = dgvUserInformation.SelectedRows[0].Cells["Password"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
