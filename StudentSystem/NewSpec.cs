using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace StudentSystem
{
    public partial class NewSpec : MetroForm
    {
        private string connstring = String.Format("Server={0};Port={1};" +
        "User Id={2};Password={3};Database={4}",
        $"{Properties.Settings.Default.address_base}", $"{Properties.Settings.Default.port_base}", $"{Properties.Settings.Default.login_base}",
        $"{Properties.Settings.Default.password_base}", $"{Properties.Settings.Default.name_base}");

        private NpgsqlConnection sqlConnection;
        private NpgsqlDataAdapter da = null;
        private string sql;
        NpgsqlCommand cmd = new NpgsqlCommand();
        DataTable dt = new DataTable();
        private DataTable table = null;
        private string sort_textbox;
        private int rowIndex = -1;
        public NewSpec()
        {
            InitializeComponent();
        }

        private void NewSpec_Load(object sender, EventArgs e)
        {
            
        }

        private void NewSpecINSBTN_Click(object sender, EventArgs e)
        {
            if (SpecNameTB.Text == null)
            {
                MessageBox.Show("Есть не заполненные поля!!!");
            }
            else if (CodSpecTB.Text == null)
            {
                MessageBox.Show("Есть не заполненные поля!!!");
            }
            else if (FullSpecNameTB.Text == null)
            {
                MessageBox.Show("Есть не заполненные поля!!!");
            }
            else
            {
                
            }
        }

        private void BTNBacMain1_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            this.Hide();
            MF.Show();
        }
    }
}
