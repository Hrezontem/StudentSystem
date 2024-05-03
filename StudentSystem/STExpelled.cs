using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Npgsql;

namespace StudentSystem
{
    public partial class STExpelled : MetroForm
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
        private int rowIndex = -1;

        public STExpelled()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }



        private void Select()
        {
            try
            {
                sqlConnection.Open();
                sql = @"select * from students_select(2)";
                cmd = new NpgsqlCommand(sql, sqlConnection);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                sqlConnection.Close();
                DGVExpelledtList.DataSource = null;
                DGVExpelledtList.DataSource = dt;
                DGVExpelledtList.Columns["students_id"].Visible = false;
                DGVExpelledtList.Columns["students_name"].HeaderText = "ФИО";
                DGVExpelledtList.Columns["group_spec_name"].Visible = false;
                DGVExpelledtList.Columns["group_code"].Visible = false;
                DGVExpelledtList.Columns["group_full_name"].HeaderText = "Группа";
                DGVExpelledtList.Columns["group_name"].Visible = false;
                DGVExpelledtList.Columns["group_name_id"].Visible = false;
                DGVExpelledtList.Columns["group_num"].Visible = false;
                DGVExpelledtList.Columns["student_card"].HeaderText = "Студенческий";
                DGVExpelledtList.Columns["group_years"].HeaderText = "Годы обучения";
                DGVExpelledtList.Columns["students_dateborn"].Visible = false;
                DGVExpelledtList.ClearSelection();

            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void STExpelled_Load(object sender, EventArgs e)
        {
            sqlConnection = new NpgsqlConnection(connstring);
            Select();
        }


        private void DGVStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNBacMain1_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            this.Hide();
            MF.Show();
        }

        private void DGVExpelledtList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void отменитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var drez1 = MessageBox.Show(
                "Я ЭТО ИЗМЕНИЛ???",
                "ВНИМАНИЕ!!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1
                );
            if (drez1 == DialogResult.Yes)
                foreach (DataGridViewRow row in DGVExpelledtList.SelectedRows)
                {
                    try
                    {
                        sqlConnection.Open();
                        sql = $"select * from students_update_isStudies({int.Parse(row.Cells["students_id"].Value.ToString())}, true, 2)";
                        cmd = new NpgsqlCommand(sql, sqlConnection);
                        cmd.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("Отменено");
                        Select();
                    }
                    catch (Exception ex)
                    {
                        sqlConnection.Close();
                        MessageBox.Show("Ошибка доступа. Ошибка: " + ex.Message);
                    }
                }
        }

        private void SearchEST_TextChanged(object sender, EventArgs e)
        {
            try
            {

                cmd = new NpgsqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandText = "Select * FROM students_select(2) WHERE students_name Like '%" + SearchEST.Text + "%'";
                da = new NpgsqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                DGVExpelledtList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            da.Dispose();
        }

        private void удалитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var drez = MessageBox.Show(
               "Вы уверены???",
               "ВНИМАНИЕ!!!",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button1
               );
            if (drez == DialogResult.Yes)
                foreach (DataGridViewRow row in DGVExpelledtList.SelectedRows)
                {

                    try
                    {
                        sqlConnection.Open();
                        sql = $"select * from students_delete({int.Parse(row.Cells["students_id"].Value.ToString())}, 2)";
                        cmd = new NpgsqlCommand(sql, sqlConnection);
                        cmd.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("Удалено успешно");
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
}
