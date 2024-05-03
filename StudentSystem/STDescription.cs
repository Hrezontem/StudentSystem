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
    public partial class STDescription : MetroForm
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
        

        public STDescription()
        {
            InitializeComponent();

        }

        private void STDescription_Load(object sender, EventArgs e)
        {
            STFIOTextBox.Enabled = false;
            STBiletTextBox.Enabled = false;
            DTPDateBirth.Enabled = false;
            STSave.Visible = false;
            Cancel.Visible = false;
            BTNActiovateIns.Visible = true;
            SearchGroup.Visible = false;
            label1.Visible = false;
            DTPDateBirth.Visible = false;
            foreach (DataGridViewColumn column in DGVGroups.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            sqlConnection = new NpgsqlConnection(connstring);
            SelectGroup();

            DGVGroups.Visible = false;

        }

        private void STSave_Click(object sender, EventArgs e)
        {
            STFIOTextBox.Enabled = false;
            STBiletTextBox.Enabled = false;
            DTPDateBirth.Enabled = false;
            STSave.Visible = false;
            Cancel.Visible = false;
            BTNActiovateIns.Visible = true;
            DGVGroups.Visible = false;
            Group.Visible = true;
            SearchGroup.Visible = false;
            label1.Visible = false;
            DTPDateBirth.Visible = false;
            DateB.Visible = true;
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            STFIOTextBox.Enabled = false;
            STBiletTextBox.Enabled = false;
            DTPDateBirth.Enabled = false;
            STSave.Visible = false;
            Cancel.Visible = false;
            BTNActiovateIns.Visible = true;
            DGVGroups.Visible = false;
            Group.Visible = true;
            SearchGroup.Visible = false;
            label1.Visible = false;
            DTPDateBirth.Visible = false;
            DateB.Visible = true;
        }

        private void BTNActiovateIns_Click(object sender, EventArgs e)
        {
            STFIOTextBox.Enabled = true;
            STBiletTextBox.Enabled = true;
            DTPDateBirth.Enabled = true;
            STSave.Visible = true;
            Cancel.Visible = true;
            BTNActiovateIns.Visible = false;
            DGVGroups.Visible = true;
            Group.Visible = false;
            SearchGroup.Visible = true;
            label1.Visible = true;
            DTPDateBirth.Visible = true;
            DateB.Visible = false;

        }

        private void DGVGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void STFIOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
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

        private void STDescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
