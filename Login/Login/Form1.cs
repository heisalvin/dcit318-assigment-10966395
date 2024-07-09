using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String Username = usernameTextBox.Text;
            String Password = passwordTextBox.Text;
            

            MessageBox.Show($"Username: {Username} \nPassword: {Password}", "Login");
        }
    }
}
