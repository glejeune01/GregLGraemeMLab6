using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GregLGraemeMLab6
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Logging the user in, creates two new user objects and compares against entry from user
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserCreds adminUser = new UserCreds("admin", "admin", "admin");
            UserCreds customerUser = new UserCreds("cathy", "cathy", "customer");

            string enteredUsername = txtUsernameEntry.Text;
            string enteredPassword = txtPasswordEntry.Text;

            if (ValidateCredentials(adminUser, enteredUsername, enteredPassword) || ValidateCredentials(customerUser, enteredUsername, enteredPassword))
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        //Validates the username and password
        public bool ValidateCredentials(UserCreds user, string enteredUsername, string enteredPassword)
        {
            if (user.Username == enteredUsername && user.Password == enteredPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
