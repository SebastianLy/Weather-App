using System;
using System.Windows.Forms;

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
            User user = User.SignIn(new User(loginInputTextBox.Text, passwordInputTextBox.Text));
            if (user != null)
            {
                Hide();
                Form3 form3 = new Form3(user);
                form3.ShowDialog();
                Close();
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
