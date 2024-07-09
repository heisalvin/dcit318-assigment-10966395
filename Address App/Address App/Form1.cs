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

namespace Address_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveTextBox_Click(object sender, EventArgs e)
        {
            String Name = nameTextBox.Text;
            String Email = emailTextBox.Text;
            String PhoneNumber = phoneTextBox.Text;


            MessageBox.Show($"Name: {Name} \nEmail: {Email} \nPhone Number: {PhoneNumber}", "Saved Info");
        }
    }
}
