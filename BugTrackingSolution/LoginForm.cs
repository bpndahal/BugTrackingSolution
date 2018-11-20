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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        UserClass uc = new UserClass();

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable result = uc.userType(txtUserName.Text, txtPassword.Text);
                String Role = result.Rows[0]["userRole"].ToString();

                if (Role == "Project Manager")
                {
                    MainPage DAS = new MainPage();
                    DAS.lblCurrentUser.Text = txtPassword.Text;
                    this.Hide();
                    DAS.Show();
                }
                if (Role == "Developer")
                {
                    MainPage DAS = new MainPage();
                    this.Hide();
                    DAS.lblCurrentUser.Text = txtPassword.Text;
                    DAS.Show();
                }
                if (Role == "Tester")
                {
                    MainPage DAS = new MainPage(); this.Hide();
                    
                    DAS.Show();
                    DAS.lblCurrentUser.Text = txtPassword.Text;
                    this.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid User Name or Password");
            }
        }
    }
}
