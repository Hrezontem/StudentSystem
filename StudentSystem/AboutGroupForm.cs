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
using Npgsql;

namespace StudentSystem
{
    public partial class AboutGroupForm : MetroForm
    {
        //*****************************************Подключение Базы Данных*********************************************
        private string connstring = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4}",
            $"{Properties.Settings.Default.address_base}", $"{Properties.Settings.Default.port_base}", $"{Properties.Settings.Default.login_base}",
            $"{Properties.Settings.Default.password_base}", $"{Properties.Settings.Default.name_base}");

        //*****************************************Локальные переменные*********************************************
        private NpgsqlConnection sqlConnection;
        private NpgsqlDataAdapter da = null;
        private string sql;
        NpgsqlCommand cmd = new NpgsqlCommand();
        DataTable dt = new DataTable();
        private DataTable table = null;
        private string sort_textbox;
        private int rowIndex = -1;
        public string group_id_text;

        public AboutGroupForm()
        {
            InitializeComponent();
        }

        private void AboutGroupForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new NpgsqlConnection(connstring);
        }

        private void AboutGroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void BTNSTInfo_Click(object sender, EventArgs e)
        {
                    try
                    {
                        sqlConnection.Open();
                        sql = $"select * from group_update('{MTBDateStudy.Text.ToString()}', {group_id_text})";
                        cmd = new NpgsqlCommand(sql, sqlConnection);
                        cmd.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("Изменено");
                        Select();


                    }
                    catch (Exception ex)
                    {
                        sqlConnection.Close();
                        MessageBox.Show("Ошибка доступа. Ошибка: " + ex.Message);
                    }
                
        }
    }
}
