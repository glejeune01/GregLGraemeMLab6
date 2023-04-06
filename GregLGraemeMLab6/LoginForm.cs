using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            Program.userArray = FileHandler.ImportUsers(filePath: "C:\\files\\Users.txt");
        }

        //Logging the user in, creates two new user objects and compares against entry from user
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsernameEntry.Text;
            string password = txtPasswordEntry.Text;
            Validation validator = new Validation();

            foreach (UserCreds user in Program.userArray)
            {
                if (user.Group == "admin")
                {
                    if (validator.ValidateCredentials(user, username, password))
                    {
                        MessageBox.Show("Login successful!");
                        AdminPanel adminPanel = new AdminPanel();
                        this.Hide();
                        adminPanel.Show();
                        return;
                    }
                }
                else if (user.Group == "customer")
                {
                    if (validator.ValidateCredentials(user, username, password))
                    {
                        MessageBox.Show("Login successful!");
                        OrderForm orderForm = new OrderForm();
                        this.Hide(); // hide the LoginForm
                        orderForm.ShowDialog();
                        return;
                    }
                }
            }

            MessageBox.Show("Invalid username or password.");
        }
            //Validates the username and password
    }
}
