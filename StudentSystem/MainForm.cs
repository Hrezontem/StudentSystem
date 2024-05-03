using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MetroFramework.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentSystem
{

    public partial class MainForm : MetroForm
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
        private string group_code_string;
        private string group_spec_name_string;
        private string student_card_string;
        private string students_name_string;
        private string group_full_name_string;
        private string students_dateborn_string;


        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            светлаяToolStripMenuItem.Enabled = false;
            
        }


        private void Select()
        {
            try
            {
                sqlConnection.Open();
                sql = @"select * from students_select(1)";
                cmd = new NpgsqlCommand(sql, sqlConnection);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                sqlConnection.Close();
                DGVStudentList.DataSource = null;
                DGVStudentList.DataSource = dt;
                DGVStudentList.Columns["students_id"].Visible = false;
                DGVStudentList.Columns["students_name"].HeaderText = "ФИО";
                DGVStudentList.Columns["group_spec_name"].Visible = false;
                DGVStudentList.Columns["group_code"].Visible = false;
                DGVStudentList.Columns["group_full_name"].HeaderText = "Группа";
                DGVStudentList.Columns["group_name"].Visible = false;
                DGVStudentList.Columns["group_name_id"].Visible = false;
                DGVStudentList.Columns["group_num"].Visible = false;
                DGVStudentList.Columns["student_card"].HeaderText = "Студенческий";
                DGVStudentList.Columns["group_years"].HeaderText = "Годы обучения";
                DGVStudentList.Columns["students_dateborn"].Visible = false;
                DGVStudentList.ClearSelection();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
        private void SelectEx()
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
                DGVExpelledtList.Columns["group_course"].Visible = false;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new NpgsqlConnection(connstring);
            Select();
            CBGroup.SelectedIndex = 0;



        }

        private void BTNInsertST_Click(object sender, EventArgs e)
        {
            STNewStForm STI = new STNewStForm();
            this.Hide();
            STI.Show();
        }

        private void SearchST_TextChanged(object sender, EventArgs e)
        {



            DataView dv = dt.DefaultView;
            dv.RowFilter = $"{sort_textbox} LIKE '" + SearchST.Text + "%'";
            DGVStudentList.DataSource = dv;
        }

        private void перенестиВОтчисленныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var drez1 = MessageBox.Show(
                "Вы уверены???",
                "ВНИМАНИЕ!!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1
                );
            if (drez1 == DialogResult.Yes)
                foreach (DataGridViewRow row in DGVStudentList.SelectedRows)
                {

                    try
                    {
                        sqlConnection.Open();
                        sql = $"select * from students_update_isStudies({int.Parse(row.Cells["students_id"].Value.ToString())}, false, 1)";
                        cmd = new NpgsqlCommand(sql, sqlConnection);
                        cmd.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("Отчислен");
                        Select();


                    }
                    catch (Exception ex)
                    {
                        sqlConnection.Close();
                        MessageBox.Show("Ошибка доступа. Ошибка: " + ex.Message);
                    }
                }
        }

        private void DGVStudentList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void SearchST_Leave(object sender, EventArgs e)
        {
            SearchST.ForeColor = Color.Black;
        }

        //***************************************************************************************************************

        private void CBCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
     

        }
    
    

        private void удалитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var drez = MessageBox.Show(
               "Вы уверены, что хотите удалить студента?",
               "ВНИМАНИЕ",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button1);

            if (drez == DialogResult.Yes)
                foreach (DataGridViewRow row in DGVStudentList.SelectedRows)
                {

                    try
                    {
                        // Console.WriteLine(int.Parse(row.Cells["students_id"].Value.ToString()));
                        sqlConnection.Open();
                        sql = $"select * from students_delete({int.Parse(row.Cells["students_id"].Value.ToString())}, 1)";
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

        private void BTNSTInfo_Click(object sender, EventArgs e)
        {
            
            STDescription STD = new STDescription();
            STD.CodSpecLB.Text = group_code_string;
            STD.fullspecnameLB.Text = group_spec_name_string;
            STD.STBiletTextBox.Text = student_card_string;
            STD.STFIOTextBox.Text = students_name_string;
            STD.Group.Text = group_full_name_string;
            STD.DateB.Text = students_dateborn_string;
            if (STD.STFIOTextBox.Text == "")
            { 
            MessageBox.Show("Вы не выбрали студента!!!");
            }
            else
            {
                this.Hide();

                STD.Show();
            }
            
        }

        private void DGVStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            STDescription ST = new STDescription();
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                group_code_string = DGVStudentList.Rows[e.RowIndex].Cells["group_code"].Value.ToString();
                group_spec_name_string = DGVStudentList.Rows[e.RowIndex].Cells["group_spec_name"].Value.ToString();
                student_card_string = DGVStudentList.Rows[e.RowIndex].Cells["student_card"].Value.ToString();
                students_name_string = DGVStudentList.Rows[e.RowIndex].Cells["students_name"].Value.ToString();
                group_full_name_string = DGVStudentList.Rows[e.RowIndex].Cells["group_full_name"].Value.ToString();
                students_dateborn_string = DGVStudentList.Rows[e.RowIndex].Cells["students_dateborn"].Value.ToString();
            }
        }

        private void настройкиПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnDBForm connDBForm = new ConnDBForm();
            this.Hide();
            connDBForm.Show();
        }

        private void CBGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBGroup.SelectedIndex == 0)
            {
                sort_textbox = "group_full_name";
            }
            else if (CBGroup.SelectedIndex == 1)
            {
                sort_textbox = "students_name";

            }
        }

        private void отменитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var drez1 = MessageBox.Show(
                "Вы уверены???",
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
                        SelectEx();
                    }
                    catch (Exception ex)
                    {
                        sqlConnection.Close();
                        MessageBox.Show("Ошибка доступа. Ошибка: " + ex.Message);
                    }
                }
        }

        private void удалитьСтудентаToolStripMenuItem1_Click(object sender, EventArgs e)
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
                        SelectEx();
                    }
                    catch (Exception ex)
                    {
                        sqlConnection.Close();
                        MessageBox.Show("Ошибка доступа. Ошибка: " + ex.Message);
                    }
                }
        }

        private void TCST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TCST.SelectedTab == TPAllST)
            {
                Select();
            } else
            {
                SelectEx();
            }
        }

        private void DGVExpelledtList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip2.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void добавитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGroupCreate NGC = new NewGroupCreate();
            this.Hide();
            NGC.Show();
        }

        private void добавитьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSpec NSC = new NewSpec();
            this.Hide();
            NSC.Show();
        }
    }

}

