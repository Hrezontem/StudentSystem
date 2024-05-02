using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Npgsql;

namespace StudentSystem
{
    public partial class STNewStForm : MetroForm
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
        private string group_id_text;

        public STNewStForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;



        }
        


        private void STNewStForm_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in DGVGroups.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            sqlConnection = new NpgsqlConnection(connstring);
            SelectGroup();
            
        }

        private void SelectGroup()
        {
            try
            {
                sqlConnection.Open();
                sql = @"select * from group_select()";
                cmd = new NpgsqlCommand(sql, sqlConnection);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                sqlConnection.Close();
                DGVGroups.DataSource = null;
                DGVGroups.DataSource = dt;
                DGVGroups.Columns["group_id"].Visible = false;
                DGVGroups.Columns["group_course"].Visible = false;
                DGVGroups.Columns["group_full_name"].HeaderText = "Группы";
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

        private void CBGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CodSpecLB_Click(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------ДОБАВИТЬ СТУДЕНТА------------------

        private void BTNInsertST_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                sql = $"select * from students_insert('{STFIOTextBox.Text.ToString()}', {group_id_text}, '{STBiletTextBox.Text.ToString()}', '{DTPDateBirth.Value.ToString()}')";
                cmd = new NpgsqlCommand(sql, sqlConnection);
                cmd.ExecuteNonQuery();
                //cmd.Parameters.AddWithValue("_students_name", STFIOTextBox.Text.ToString());
                //cmd.Parameters.AddWithValue("_group_id", int.Parse(group_id_text));
                //cmd.Parameters.AddWithValue("_students_card", STBiletTextBox.Text.ToString());
                MessageBox.Show("Добавлено");

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("ОШИБКА. Error: " + ex.Message);

            }

        }

        private void DGVGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void DGVGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                CodSpecLB.Text = DGVGroups.Rows[e.RowIndex].Cells["group_code"].Value.ToString();
                fullspecnameLB.Text = DGVGroups.Rows[e.RowIndex].Cells["group_spec_name"].Value.ToString();
                group_id_text = DGVGroups.Rows[e.RowIndex].Cells["group_id"].Value.ToString();
            }
        }

        private void SearchGroup_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = $"group_full_name LIKE '" + SearchGroup.Text + "%'";
            DGVGroups.DataSource = dv;
        }

        private void STFIOTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
