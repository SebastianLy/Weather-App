using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == textBox9.Text)
            {
                User user = new User(textBox3.Text, textBox5.Text, textBox7.Text);
                await User.AddUser(user);
                Close();
            }
        }
    }
}
