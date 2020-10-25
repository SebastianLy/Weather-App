using System;
using System.Windows.Forms;
using System.Drawing;

namespace Weather_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void signUpButton_Click(object sender, EventArgs e)
        {
            if (passwordInputTextBox.Text != password2InputTextBox.Text || passwordInputTextBox.Text == "")
            {
                failedPasswordTextBox.Visible = true;
                failedPasswordTextBox.BackColor = failedPasswordTextBox.BackColor;
                failedPasswordTextBox.ForeColor = Color.Red;
            }
            else
                failedPasswordTextBox.Visible = false;            
            User user = new User(loginInputTextBox.Text, emailInputTextBox.Text, passwordInputTextBox.Text);
            bool[] unique = User.IsUserUnique(user);
            if (unique[0] == false || loginInputTextBox.Text == "")
            {
                failedLoginTextBox.Visible = true;
                failedLoginTextBox.BackColor = failedLoginTextBox.BackColor;
                failedLoginTextBox.ForeColor = Color.Red;
            }
            else
                failedLoginTextBox.Visible = false;
            if (unique[1] == false || emailInputTextBox.Text == "")
            {
                failedEmailTextBox.Visible = true;
                failedEmailTextBox.BackColor = failedEmailTextBox.BackColor;
                failedEmailTextBox.ForeColor = Color.Red;
            }
            else
                failedEmailTextBox.Visible = false;
            if (unique[0] == true && unique[1] == true && passwordInputTextBox.Text == password2InputTextBox.Text && 
                loginInputTextBox.Text != "" && emailInputTextBox.Text != "" && passwordInputTextBox.Text != "")
            {
                string password = User.Encode(passwordInputTextBox.Text);
                user.Password = password;
                await User.AddUser(user);
                Close();
            }
        }
    }
}
