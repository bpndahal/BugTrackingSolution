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
    public partial class ManageMember : Form
    {
        public ManageMember()
        {
            InitializeComponent();
        }
        MemberClass memberClass = new MemberClass();
        BusinessLogicClass businessLogicClass = new BusinessLogicClass();
        public int memberId;
        private void ManageMember_Load(object sender, EventArgs e)
        {
            dgvMemberInformation.DataSource = memberClass.getAllMembers();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pbProfilePicture.Image = Image.FromFile(ofd.FileName);

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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtfullname.Text == "")
                MessageBox.Show("Please Select Full Name");
            else if (txtaddress.Text == "")
                MessageBox.Show("Please Provide Address");
            else if (txtcontact.Text == "")
                MessageBox.Show("Please Provide Contact Details");
            else if (txtdescription.Text == "")
                MessageBox.Show("Please Provide Description");
            else if (txtemail.Text == "")
                MessageBox.Show("Please Provide Email Address");
            else if (cmbgender.Text == "")
                MessageBox.Show("Please Select Gender");
            else if (datedob.Text == "")
                MessageBox.Show("Please Provide Date of Birth");
            else if (datedoj.Text == "")
                MessageBox.Show("Please Provide DAte of Join");
            else if (pbProfilePicture.Image == null)
                MessageBox.Show("Please Upload");

            else
            {

                try
                {
                    bool result = businessLogicClass.manageMembers(0, txtfullname.Text, txtaddress.Text, txtcontact.Text, txtemail.Text, cmbgender.Text, Convert.ToDateTime(datedob.Text), Convert.ToDateTime(datedoj.Text), txtdescription.Text, AssistantClass.imageConverter(pbProfilePicture), 1);
                    if (result == true)
                    {
                        MessageBox.Show("NEW MEMBER HAS SUCCESSFULLY CREATED");
                        dgvMemberInformation.DataSource = memberClass.getAllMembers();
                        AssistantClass.makeFieldsBlank(pnlMemberInformation);
                        pbProfilePicture.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("ERROR IN CREATING MEMBER");
                        dgvMemberInformation.DataSource = memberClass.getAllMembers();
                        AssistantClass.makeFieldsBlank(pnlMemberInformation);
                        pbProfilePicture.Image = null;
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
                if (txtfullname.Text == "")
                    MessageBox.Show("Please Select Full Name");
                else if (txtaddress.Text == "")
                    MessageBox.Show("Please Provide Address");
                else if (txtcontact.Text == "")
                    MessageBox.Show("Please Provide Contact Details");
                else if (txtdescription.Text == "")
                    MessageBox.Show("Please Provide Description");
                else if (txtemail.Text == "")
                    MessageBox.Show("Please Provide Email Address");
                else if (cmbgender.Text == "")
                    MessageBox.Show("Please Select Gender");
                else if (datedob.Text == "")
                    MessageBox.Show("Please Provide Date of Birth");
                else if (datedoj.Text == "")
                    MessageBox.Show("Please Provide DAte of Join");
                else if (pbProfilePicture.Image == null)
                    MessageBox.Show("Please Upload");

                else
                {
                    try
                    {
                        bool result = businessLogicClass.manageMembers(memberId, txtfullname.Text, txtaddress.Text, txtcontact.Text, txtemail.Text, cmbgender.Text, Convert.ToDateTime(datedob.Text), Convert.ToDateTime(datedoj.Text), txtdescription.Text, AssistantClass.imageConverter(pbProfilePicture), 2);
                        if (result == true)
                        {
                            MessageBox.Show("EXISTING MEMBER HAS SUCCESSFULLY UPDATED");
                            dgvMemberInformation.DataSource = memberClass.getAllMembers();
                            AssistantClass.makeFieldsBlank(pnlMemberInformation);
                            pbProfilePicture.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("ERROR IN UPDATING MEMBER");
                            dgvMemberInformation.DataSource = memberClass.getAllMembers();
                            AssistantClass.makeFieldsBlank(pnlMemberInformation);
                            pbProfilePicture.Image = null;
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
                bool result = businessLogicClass.manageMembers(memberId, txtfullname.Text, txtaddress.Text, txtcontact.Text, txtemail.Text, cmbgender.Text, Convert.ToDateTime(datedob.Text), Convert.ToDateTime(datedoj.Text), txtdescription.Text, AssistantClass.imageConverter(pbProfilePicture), 3);
                if (result == true)
                {
                    MessageBox.Show("EXISTING MEMBER HAS SUCCESSFULLY DELETED");
                    dgvMemberInformation.DataSource = memberClass.getAllMembers();
                    AssistantClass.makeFieldsBlank(pnlMemberInformation);
                    pbProfilePicture.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN DELETING MEMBER");
                    dgvMemberInformation.DataSource = memberClass.getAllMembers();
                    AssistantClass.makeFieldsBlank(pnlMemberInformation);
                    pbProfilePicture.Image = null;
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

        private void dgvMemberInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                memberId = Convert.ToInt32(dgvMemberInformation.SelectedRows[0].Cells["memberId"].Value.ToString());
                txtfullname.Text = dgvMemberInformation.SelectedRows[0].Cells["memberName"].Value.ToString();
                txtaddress.Text = dgvMemberInformation.SelectedRows[0].Cells["memberAddress"].Value.ToString();
                txtcontact.Text = dgvMemberInformation.SelectedRows[0].Cells["contactNumber"].Value.ToString();
                txtemail.Text = dgvMemberInformation.SelectedRows[0].Cells["emailAddress"].Value.ToString();
                cmbgender.Text = dgvMemberInformation.SelectedRows[0].Cells["gender"].Value.ToString();
                datedob.Text = dgvMemberInformation.SelectedRows[0].Cells["dateOfBirth"].Value.ToString();
                datedoj.Text = dgvMemberInformation.SelectedRows[0].Cells["dateOfJoin"].Value.ToString();
                txtdescription.Text = dgvMemberInformation.SelectedRows[0].Cells["memberDesignation"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvMemberInformation.SelectedRows[0].Cells["profilePicture"].Value);
                pbProfilePicture.Image = Image.FromStream(memoryStream);
            
         }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
