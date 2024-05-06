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
    public partial class NewGroupCreate : MetroForm
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
        private string group_name_id_text;
        public NewGroupCreate()
        {
            InitializeComponent();
        }

        private void NewGroupCreate_Load(object sender, EventArgs e)
        {
            sqlConnection = new NpgsqlConnection(connstring);
            SelectGroup();

            DateStudyMTB.KeyDown += new KeyEventHandler(DateStudyMTB_KeyDown);
        }

        private void BTNBacMain1_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            this.Hide();
            MF.Show();
        }

        private void SelectGroup()
        {
            try
            {
                sqlConnection.Open();
                sql = @"select * from group_name";
                cmd = new NpgsqlCommand(sql, sqlConnection);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                sqlConnection.Close();
                DGVSpecNameGR.DataSource = null;
                DGVSpecNameGR.DataSource = dt;
                DGVSpecNameGR.Columns["group_name_id"].Visible = false;
                DGVSpecNameGR.Columns["group_name"].HeaderText = "Специальность";
                DGVSpecNameGR.Columns["group_spec_name"].Visible = false;
                DGVSpecNameGR.Columns["group_code"].Visible = false;
                DGVSpecNameGR.ClearSelection();

            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void NewSpecINSBTN_Click(object sender, EventArgs e)
        {
            if (Group.Text == "...")
            {
                MessageBox.Show("Не заполненное поле!!! 'Специальность'");
            }
            else if (fullspecnameLB.Text == "Расшифровка специальности")
            {
                MessageBox.Show("Не заполненное поле!!! 'Расшифровка специальности'");
            }
            else if (GroupNumTB.Text == "")
            {
                MessageBox.Show("Не заполненное поле!!!, 'Номер Группы'");
            }
            else if (DateStudyMTB.Text == "")
            {
                MessageBox.Show("Не заполненное поле!!!, 'Номер Группы'");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    sql = $"select * from group_insert({group_name_id_text}, '{GroupNumTB.Text.ToString()}', '{DateStudyMTB.Text.ToString()}' )";
                    cmd = new NpgsqlCommand(sql, sqlConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Добавлено");

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("ОШИБКА. Error: " + ex.Message);

                }
            }
        }

        private void DGVSpecNameGR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                CodSpecLB.Text = DGVSpecNameGR.Rows[e.RowIndex].Cells["group_code"].Value.ToString();
                fullspecnameLB.Text = DGVSpecNameGR.Rows[e.RowIndex].Cells["group_spec_name"].Value.ToString();
                group_name_id_text = DGVSpecNameGR.Rows[e.RowIndex].Cells["group_name_id"].Value.ToString();
                Group.Text = DGVSpecNameGR.Rows[e.RowIndex].Cells["group_name"].Value.ToString();
            }
        }

        private void DateStudyMTB_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void NewGroupCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm MF = new MainForm();
            this.Hide();
            MF.Show();
        }
    }
}
