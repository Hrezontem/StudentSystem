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
        private string group_code_string;
        private string group_spec_name_string;
        private string student_card_string;
        private string students_name_string;
        private string group_full_name_string;
        private DateTime students_dateborn_string;
        private string students_id_text;
        private string group_id_text;


        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            светлаяToolStripMenuItem.Enabled = false;
            
        }

        //*****************************************Выборка. Актульные студенты/Отчисленные*********************************************
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
                DGVStudentList.Columns["group_id"].Visible = false;
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
                DGVExpelledtList.Columns["group_num"].Visible = false;
                DGVExpelledtList.Columns["group_id"].Visible = false;
                DGVExpelledtList.Columns["student_card"].HeaderText = "Студенческий";
                DGVExpelledtList.Columns["group_years"].HeaderText = "Годы обучения";
                DGVExpelledtList.Columns["group_years"].Visible = false;
                DGVExpelledtList.Columns["students_dateborn"].Visible = false;
                DGVExpelledtList.ClearSelection();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        //---------------------------------------------Выборка Групп------------------------------------------------------
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

        //------------------------------------------Выборка Специальностей-----------------------------------------------
        private void SelectSpec()
        {
            var dt = new DataTable();
            try
            {
                sqlConnection.Open();
                sql = @"select * from group_name";
                cmd = new NpgsqlCommand(sql, sqlConnection);
                dt.Load(cmd.ExecuteReader());
                sqlConnection.Close();
                DGVSpec.DataSource = null;
                DGVSpec.DataSource = dt;
                DGVSpec.Columns["group_name"].HeaderText = "Специальности";
                DGVSpec.Columns["group_spec_name"].Visible = false;
                DGVSpec.Columns["group_name_id"].Visible = false;
                DGVSpec.Columns["group_code"].Visible = false;

                DGVSpec.ClearSelection();

            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        //---------------------------------------------------Объявление Формы--------------------------------------------------------
        private void MainForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new NpgsqlConnection(connstring);
            if(Properties.Settings.Default.login_base == "client")
            {
                UserIndicator.Text = "Клиент";
                BTNInsertST.Visible = false;
                jToolStripMenuItem.Visible = false;
                contextMenuStrip1.Enabled = false;
                contextMenuStrip2.Enabled = false;
                CMSChangeGroup.Enabled = false;
            } 
            else
            {
                UserIndicator.Text = "Админ";

            }
            Select();
            SelectSpec();
            SelectGroups();
            CBSelectSearch.SelectedIndex = 0;
        }

        //---------------------------------------Переход на форму. Добавление студента-----------------------------------------------
        private void BTNInsertST_Click(object sender, EventArgs e)
        {
            STNewStForm STI = new STNewStForm();
            this.Hide();
            STI.Show();
        }

        //---------------------------------------------------------Поиск-------------------------------------------------------------
        private void SearchST_TextChanged(object sender, EventArgs e)
        {



            DataView dv = dt.DefaultView;
            dv.RowFilter = $"{sort_textbox} LIKE '" + SearchST.Text + "%'";
            DGVStudentList.DataSource = dv;
        }

        //----------------------------------------------Контекст Меню "Отчислить"----------------------------------------------------
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

        //--------------------------------------Контекст меню "Отчислить/Удалить" в DGVStudentList-----------------------------------

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

        //---------------------------------------------------------------------------------------------------------------------------

        private void CBCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
     

        }


        //------------------------------------------Удаление студента из базы в DGVStudentList---------------------------------------
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

        //---------------------------------------------Подробная информация о студенте----------------------------------------------
        private void BTNSTInfo_Click(object sender, EventArgs e)
        {
            
            STDescription STD = new STDescription();
            STD.group_id_text = group_id_text;
            STD.students_id_text1 = students_id_text;
            STD.CodSpecLB.Text = group_code_string;
            STD.fullspecnameLB.Text = group_spec_name_string;
            STD.STBiletTextBox.Text = student_card_string;
            STD.STFIOTextBox.Text = students_name_string;
            STD.Group.Text = group_full_name_string;
            STD.DateB.Text = students_dateborn_string.ToShortDateString();
            if (STD.STFIOTextBox.Text == "")
            { 
            MessageBox.Show("Вы не выбрали студента!!!");
            }
            else
            {
                STD.DTPDateBirth.Value = DateTime.Parse(students_dateborn_string.ToShortDateString());
                this.Hide();
                STD.Show();
            }
            
        }

        private void DGVStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //-----------------------------------Захват Данных с DGVStudentList для STDescription-------------------------------------
        private void DGVStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                students_id_text = DGVStudentList.Rows[e.RowIndex].Cells["students_id"].Value.ToString();
                group_code_string = DGVStudentList.Rows[e.RowIndex].Cells["group_code"].Value.ToString();
                group_spec_name_string = DGVStudentList.Rows[e.RowIndex].Cells["group_spec_name"].Value.ToString();
                student_card_string = DGVStudentList.Rows[e.RowIndex].Cells["student_card"].Value.ToString();
                students_name_string = DGVStudentList.Rows[e.RowIndex].Cells["students_name"].Value.ToString();
                group_full_name_string = DGVStudentList.Rows[e.RowIndex].Cells["group_full_name"].Value.ToString();
                students_dateborn_string = DGVStudentList.Rows[e.RowIndex].Cells["students_dateborn"].Value is DateTime ? (DateTime)DGVStudentList.Rows[e.RowIndex].Cells["students_dateborn"].Value : new DateTime(1753, 01, 01);
                group_id_text = DGVStudentList.Rows[e.RowIndex].Cells["group_id"].Value.ToString();
            }
        }

        //---------------------------------Переход на форму "Настройки подключения"----------------------------------------------
        private void настройкиПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnDBForm connDBForm = new ConnDBForm();
            this.Hide();
            connDBForm.Show();
        }

        //-------------------------------------Тип Поиска по "ФИО" и "Группам"---------------------------------------------------
        private void CBSelectSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBSelectSearch.SelectedIndex == 0)
            {
                sort_textbox = "group_full_name";
            }
            else if (CBSelectSearch.SelectedIndex == 1)
            {
                sort_textbox = "students_name";

            }
        }

        //-------------------------------------Отмена Отчисления в DGVExpelledtList---------------------------------------------------
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

        //-----------------------------------------Удаление студента из базы в DGVExpelledtList-------------------------------------
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

        //-------------------------Выборка актуальных студентов в DGVStudentList и отчисленных в DGVExpelledtList-------------------
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

        //--------------------------------------Контекст меню "Отчислить/Удалить" в DGVExpelledtList-----------------------------------
        private void DGVExpelledtList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip2.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        //--------------------------------------------------Добавление группы студентов------------------------------------------------
        private void добавитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGroupCreate NGC = new NewGroupCreate();
            this.Hide();
            NGC.Show();
        }

        //-----------------------------------------------Добавление специальности студентов--------------------------------------------
        private void добавитьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSpec NSC = new NewSpec();
            this.Hide();
            NSC.Show();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //------------------------------------------Выборка групп в DGVGroups и специальностей в DGVSpec-------------------------------
        private void TCSpecGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TCSpecGroups.SelectedTab == TCSpecGr)
            {
                SelectSpec();
            }
            else
            {
                SelectGroups();
            }
        }

        //------------------------------------Удаление группы со студентами в DGVGroups и их отчисление-------------------------------
        private void изменитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutGroupForm AGF = new AboutGroupForm();
            AGF.group_id_text = group_id_text;
            AGF.Group_Text.Text = group_full_name_string;
            AGF.Show();
        }

        //--------------------------------------Контекст Меню "Удалить Специальность"-------------------------------------------------
        private void DGVSpec_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        //--------------------------------------Контекст Меню "Удалить Группу"--------------------------------------------------------
        private void DGVGroups_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CMSChangeGroup.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        //-------------Удаление специальности в DGVSpec и удаление групп со студентами в DGVGroups и их отчисление-------------------


        private void DGVGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                group_id_text = DGVGroups.Rows[e.RowIndex].Cells["group_id"].Value.ToString();
                group_full_name_string = DGVGroups.Rows[e.RowIndex].Cells["group_full_name"].Value.ToString();

            }
        }

        private void DGVGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void выпуститьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var drez = MessageBox.Show(
   "Вы уверены???",
   "ВНИМАНИЕ!!!",
   MessageBoxButtons.YesNo,
   MessageBoxIcon.Warning,
   MessageBoxDefaultButton.Button1
   );
            if (drez == DialogResult.Yes)
                    try
                    {
                        sqlConnection.Open();
                        sql = $"update students set \"students_isStudies\" = false where group_id = {group_id_text}";
                        //sql = $"select * from students_expulsion({group_id_text})";
                        cmd = new NpgsqlCommand(sql, sqlConnection);
                        cmd.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("Выпущены успешно");
                        SelectEx();
                    }
                    catch (Exception ex)
                    {
                        sqlConnection.Close();
                        MessageBox.Show("Ошибка доступа. Ошибка: " + ex.Message);
                    }
        }
    }

}

