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
        private string A;
        private string B;
        private string C;
        private string D;
        private string E;
        private string F;


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

        private void STExpelledBTN_Click(object sender, EventArgs e)
        {
            STExpelled STE = new STExpelled();
            this.Hide();
            STE.Show();
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
                        MessageBox.Show("Удалено sas");
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
                        this.Hide();
                        STD.CodSpecLB.Text = A;
                        STD.fullspecnameLB.Text = B;
                        STD.STBiletTextBox.Text = C;
                        STD.STFIOTextBox.Text = D;
                        STD.Group.Text = E;
                        STD.DateB.Text = F;
                        STD.Show();
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
                A = DGVStudentList.Rows[e.RowIndex].Cells["group_code"].Value.ToString();
                B = DGVStudentList.Rows[e.RowIndex].Cells["group_spec_name"].Value.ToString();
                C = DGVStudentList.Rows[e.RowIndex].Cells["student_card"].Value.ToString();
                D = DGVStudentList.Rows[e.RowIndex].Cells["students_name"].Value.ToString();
                E = DGVStudentList.Rows[e.RowIndex].Cells["group_full_name"].Value.ToString();
                F = DGVStudentList.Rows[e.RowIndex].Cells["students_dateborn"].Value.ToString();
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
    }

}

