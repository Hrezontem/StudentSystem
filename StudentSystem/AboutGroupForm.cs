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
        private string group_id_choice;

        public AboutGroupForm()
        {
            InitializeComponent();
        }

        private void AboutGroupForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new NpgsqlConnection(connstring);
            SelectGroups();
        }

        private void AboutGroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void SelectGroups()
        {
            var dt = new DataTable();
            try
            {
                sqlConnection.Open();
                sql = @"select * from group_select()";
                cmd = new NpgsqlCommand(sql, sqlConnection);
                dt.Load(cmd.ExecuteReader());
                sqlConnection.Close();
                DGVGroups.DataSource = null;
                DGVGroups.DataSource = dt;
                DGVGroups.Columns["group_id"].Visible = false;
                DGVGroups.Columns["group_full_name"].HeaderText = "Группа";
                DGVGroups.Columns["group_spec_name"].Visible = false;
                DGVGroups.Columns["group_code"].Visible = false;
                DGVGroups.ClearSelection();

            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void BTNSTInfo_Click(object sender, EventArgs e)
        {
            if (DGVFlowLayout.Visible == true)
            {
                try
                {
                    sqlConnection.Open();
                    sql = $"select * from group_update('{MTBDateStudy.Text.ToString()}', {group_id_text})";
                    cmd = new NpgsqlCommand(sql, sqlConnection);
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    sqlConnection.Open();
                    sql = $"select * from students_group_update('{group_id_choice}', {group_id_text})";
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
            else
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

        private void BTNChange_Click(object sender, EventArgs e)
        {
            grouplabel.Visible = !grouplabel.Visible;
            DGVFlowLayout.Visible = !DGVFlowLayout.Visible;
        }

        private void DGVGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                group_id_choice = DGVGroups.Rows[e.RowIndex].Cells["group_id"].Value.ToString();

            }
        }
    }
}
