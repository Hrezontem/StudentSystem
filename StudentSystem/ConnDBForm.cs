using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using StudentSystem.Properties;

namespace StudentSystem
{
    public partial class ConnDBForm : MetroForm
    {
        public ConnDBForm()
        {
            InitializeComponent();
        }
        
        private void BTNauth_Click(object sender, EventArgs e)
        {
            var var = Settings.Default;
            var.address_base = IPTextBox.Text;
            var.port_base =  PortTextBox.Text;
            var.name_base = DBTextBox.Text;
            var.login_base = LoginTextBox.Text;
            var.password_base = PasswordTextBox.Text;
            var.Save();
            

            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();

        }

        private void ConnDBForm_Load(object sender, EventArgs e)
        {
            var var = Settings.Default;
            IPTextBox.Text = var.address_base;
            PortTextBox.Text = var.port_base;
            DBTextBox.Text = var.name_base;
            LoginTextBox.Text = var.login_base;
            PasswordTextBox.Text = var.password_base;
        }
    }
}
