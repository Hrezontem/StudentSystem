
namespace StudentSystem
{
    partial class STNewStForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.STFIOTextBox = new System.Windows.Forms.TextBox();
            this.LALFIO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CodSpecLB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.STBiletTextBox = new System.Windows.Forms.TextBox();
            this.BTNInsertST = new System.Windows.Forms.Button();
            this.BTNBacMain1 = new System.Windows.Forms.Button();
            this.DTPDateBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVGroups = new System.Windows.Forms.DataGridView();
            this.fullspecnameLB = new System.Windows.Forms.Label();
            this.SearchGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGroups)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // STFIOTextBox
            // 
            this.STFIOTextBox.Location = new System.Drawing.Point(53, 42);
            this.STFIOTextBox.Name = "STFIOTextBox";
            this.STFIOTextBox.Size = new System.Drawing.Size(201, 20);
            this.STFIOTextBox.TabIndex = 0;
            this.STFIOTextBox.TextChanged += new System.EventHandler(this.STFIOTextBox_TextChanged);
            // 
            // LALFIO
            // 
            this.LALFIO.AutoSize = true;
            this.LALFIO.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LALFIO.Location = new System.Drawing.Point(50, 20);
            this.LALFIO.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.LALFIO.Name = "LALFIO";
            this.LALFIO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LALFIO.Size = new System.Drawing.Size(41, 19);
            this.LALFIO.TabIndex = 1;
            this.LALFIO.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Группа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(53, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "Код специальности/профессии";
            // 
            // CodSpecLB
            // 
            this.CodSpecLB.AutoSize = true;
            this.CodSpecLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodSpecLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodSpecLB.Location = new System.Drawing.Point(3, 13);
            this.CodSpecLB.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.CodSpecLB.Name = "CodSpecLB";
            this.CodSpecLB.Size = new System.Drawing.Size(33, 19);
            this.CodSpecLB.TabIndex = 13;
            this.CodSpecLB.Text = "Код";
            this.CodSpecLB.Click += new System.EventHandler(this.CodSpecLB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(50, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Номер студенческого билета";
            // 
            // STBiletTextBox
            // 
            this.STBiletTextBox.Location = new System.Drawing.Point(53, 132);
            this.STBiletTextBox.Name = "STBiletTextBox";
            this.STBiletTextBox.Size = new System.Drawing.Size(201, 20);
            this.STBiletTextBox.TabIndex = 15;
            // 
            // BTNInsertST
            // 
            this.BTNInsertST.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNInsertST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNInsertST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNInsertST.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BTNInsertST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNInsertST.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNInsertST.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNInsertST.Location = new System.Drawing.Point(53, 594);
            this.BTNInsertST.Name = "BTNInsertST";
            this.BTNInsertST.Size = new System.Drawing.Size(206, 33);
            this.BTNInsertST.TabIndex = 18;
            this.BTNInsertST.Text = "Добавить студента";
            this.BTNInsertST.UseVisualStyleBackColor = false;
            this.BTNInsertST.Click += new System.EventHandler(this.BTNInsertST_Click);
            // 
            // BTNBacMain1
            // 
            this.BTNBacMain1.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTNBacMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNBacMain1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNBacMain1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBacMain1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNBacMain1.ForeColor = System.Drawing.Color.White;
            this.BTNBacMain1.Location = new System.Drawing.Point(53, 633);
            this.BTNBacMain1.Name = "BTNBacMain1";
            this.BTNBacMain1.Size = new System.Drawing.Size(206, 30);
            this.BTNBacMain1.TabIndex = 19;
            this.BTNBacMain1.Text = "Отмена";
            this.BTNBacMain1.UseVisualStyleBackColor = false;
            this.BTNBacMain1.Click += new System.EventHandler(this.BTNBacMain1_Click);
            // 
            // DTPDateBirth
            // 
            this.DTPDateBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPDateBirth.CustomFormat = "dd--MM-yyyy";
            this.DTPDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDateBirth.Location = new System.Drawing.Point(53, 87);
            this.DTPDateBirth.Name = "DTPDateBirth";
            this.DTPDateBirth.Size = new System.Drawing.Size(201, 20);
            this.DTPDateBirth.TabIndex = 22;
            this.DTPDateBirth.Value = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(50, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(53, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 38);
            this.label3.TabIndex = 25;
            this.label3.Text = "Полное название специальности";
            // 
            // DGVGroups
            // 
            this.DGVGroups.AllowUserToAddRows = false;
            this.DGVGroups.AllowUserToDeleteRows = false;
            this.DGVGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVGroups.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVGroups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGroups.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVGroups.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVGroups.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVGroups.Location = new System.Drawing.Point(53, 222);
            this.DGVGroups.Name = "DGVGroups";
            this.DGVGroups.ReadOnly = true;
            this.DGVGroups.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVGroups.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVGroups.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVGroups.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVGroups.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVGroups.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVGroups.Size = new System.Drawing.Size(201, 155);
            this.DGVGroups.TabIndex = 48;
            this.DGVGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGroups_CellClick);
            this.DGVGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGroups_CellContentClick);
            // 
            // fullspecnameLB
            // 
            this.fullspecnameLB.AutoEllipsis = true;
            this.fullspecnameLB.AutoSize = true;
            this.fullspecnameLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullspecnameLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullspecnameLB.Location = new System.Drawing.Point(3, 16);
            this.fullspecnameLB.MaximumSize = new System.Drawing.Size(200, 0);
            this.fullspecnameLB.Name = "fullspecnameLB";
            this.fullspecnameLB.Size = new System.Drawing.Size(200, 19);
            this.fullspecnameLB.TabIndex = 49;
            this.fullspecnameLB.Text = "Расшифровка специальности";
            this.fullspecnameLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchGroup
            // 
            this.SearchGroup.Location = new System.Drawing.Point(53, 177);
            this.SearchGroup.Name = "SearchGroup";
            this.SearchGroup.Size = new System.Drawing.Size(201, 20);
            this.SearchGroup.TabIndex = 50;
            this.SearchGroup.TextChanged += new System.EventHandler(this.SearchGroup_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "Поиск по группам";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LALFIO);
            this.flowLayoutPanel1.Controls.Add(this.STFIOTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.DTPDateBirth);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.STBiletTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.SearchGroup);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.DGVGroups);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.BTNInsertST);
            this.flowLayoutPanel1.Controls.Add(this.BTNBacMain1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 20, 50, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(309, 677);
            this.flowLayoutPanel1.TabIndex = 53;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CodSpecLB);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(53, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(206, 39);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fullspecnameLB);
            this.groupBox1.Location = new System.Drawing.Point(53, 504);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 84);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // STNewStForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(349, 757);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "STNewStForm";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Добавление студента";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.STNewStForm_FormClosing);
            this.Load += new System.EventHandler(this.STNewStForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGroups)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox STFIOTextBox;
        private System.Windows.Forms.Label LALFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CodSpecLB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox STBiletTextBox;
        private System.Windows.Forms.Button BTNInsertST;
        private System.Windows.Forms.Button BTNBacMain1;
        private System.Windows.Forms.DateTimePicker DTPDateBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVGroups;
        private System.Windows.Forms.Label fullspecnameLB;
        private System.Windows.Forms.TextBox SearchGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}