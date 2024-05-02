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
using Npgsql;

namespace StudentSystem
{
    public partial class STInfoForm : MetroForm
    {
        private string connstring = String.Format("Server={0};Port={1};" +
        "User Id={2};Password={3};Database={4}",
        "localhost", 5432, "postgres",
        "123", "StudentsBeta");

        private NpgsqlConnection sqlConnection;
        private NpgsqlDataAdapter da = null;
        private string sql;
        NpgsqlCommand cmd = new NpgsqlCommand();
        private DataTable table = null;
        private int rowIndex = -1;
        public STInfoForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            CBGroup.Enabled = false;
            CBYearStudy.Enabled = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNBacMain1_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            this.Hide();
            MF.Show();
        }

        private void CBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TBPricaz_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CBCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCourse.SelectedIndex == 1)
            {
                CBGroup.Enabled = true;
                sqlConnection.Open();
                DataTable dt = new DataTable();

                sql = @"select group_name from group_name";
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES ORDER BY TABLE_NAME", sqlConnection);
                NpgsqlDataReader reader = command.ExecuteReader();
                string[] group_names;
                while (reader.Read())
                {
                    for (int i = 0; i < reader.length(); i++)
                    {
                        group_names[i] = reader[i];
                    }
                }
                sqlConnection.Close();
            }
            else if (CBCourse.SelectedIndex == 2)
            {
                CBGroup.Enabled = true;
                sqlConnection.Open();
                sql = @"select * from group where group_course = 2";
                cmd = new NpgsqlCommand(sql, sqlConnection);
                sqlConnection.Close();
            }
            else if (CBCourse.SelectedIndex == 3)
            {
                CBGroup.Enabled = true;
                sqlConnection.Open();
                sql = @"select * from group where group_course = 3";
                cmd = new NpgsqlCommand(sql, sqlConnection);
                sqlConnection.Close();
            }
            else if (CBCourse.SelectedIndex == 4)
            {
                CBGroup.Enabled = true;
                sqlConnection.Open();
                sql = @"select * from group where group_course = 4";
                cmd = new NpgsqlCommand(sql, sqlConnection);
                sqlConnection.Close();
            }
        }
        private void CBGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
