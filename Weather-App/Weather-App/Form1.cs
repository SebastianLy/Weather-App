using System;
using System.Windows.Forms;
using System.Drawing;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string password = User.Encode(passwordInputTextBox.Text);
            User user = User.SignIn(new User(loginInputTextBox.Text, password));
            if (user != null)
            {
                failedLoginTextBox.Visible = false;
                Hide();
                Form3 form3 = new Form3(user);
                form3.ShowDialog();
                Close();
            }
            else
            {
                failedLoginTextBox.Visible = true;
                failedLoginTextBox.BackColor = failedLoginTextBox.BackColor;
                failedLoginTextBox.ForeColor = Color.Red;
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
