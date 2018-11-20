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
    public partial class ManageUserRole : Form
    {
        public ManageUserRole()
        {
            InitializeComponent();
        }
        UserRoleClass userRoleClass = new UserRoleClass();
        BusinessLogicClass businessLogicClass = new BusinessLogicClass();
        int userRoleId;


        private void ManageUserRole_Load(object sender, EventArgs e)
        {
            dgvUserRole.DataSource = userRoleClass.getAllUserRoles();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
             try
            {
                bool result = businessLogicClass.manageUserRole(0, txtuserrole.Text, txtdescription.Text, 1);
                if(result==true)
                {
                    MessageBox.Show("NEW USER ROLE HAS BEEN ADDED");
                    dgvUserRole.DataSource = userRoleClass.getAllUserRoles();
                    AssistantClass.makeFieldsBlank(gbUserRoleInfo);
                }
                else
                {
                    MessageBox.Show("ERROR IN ADDING USER ROLE");
                    dgvUserRole.DataSource = userRoleClass.getAllUserRoles();
                    AssistantClass.makeFieldsBlank(gbUserRoleInfo);
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
                bool result = businessLogicClass.manageUserRole(userRoleId, txtuserrole.Text, txtdescription.Text, 2);
                if (result == true)
                {
                    MessageBox.Show("EXISTING USER ROLE HAS BEEN UPDATED");
                    dgvUserRole.DataSource = userRoleClass.getAllUserRoles();
                    AssistantClass.makeFieldsBlank(gbUserRoleInfo);
                }
                else
                {
                    MessageBox.Show("ERROR IN UPDATING USER ROLE");
                    dgvUserRole.DataSource = userRoleClass.getAllUserRoles();
                    AssistantClass.makeFieldsBlank(gbUserRoleInfo);
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
                bool result = businessLogicClass.manageUserRole(userRoleId, txtuserrole.Text, txtdescription.Text, 3);
                if (result == true)
                {
                    MessageBox.Show("EXISTING USER ROLE HAS BEEN DELETED");
                    dgvUserRole.DataSource = userRoleClass.getAllUserRoles();
                    AssistantClass.makeFieldsBlank(gbUserRoleInfo);
                }
                else
                {
                    MessageBox.Show("ERROR IN DELETING USER ROLE");
                    dgvUserRole.DataSource = userRoleClass.getAllUserRoles();
                    AssistantClass.makeFieldsBlank(gbUserRoleInfo);
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

        private void dgvUserRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userRoleId = Convert.ToInt32(dgvUserRole.SelectedRows[0].Cells["userRoleId"].Value.ToString());
                txtuserrole.Text = dgvUserRole.SelectedRows[0].Cells["userRole"].Value.ToString();
                txtdescription.Text = dgvUserRole.SelectedRows[0].Cells["roleDescription"].Value.ToString();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
