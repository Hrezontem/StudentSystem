
namespace StudentSystem
{
    partial class STDescription
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
            this.STFIOTextBox = new System.Windows.Forms.TextBox();
            this.LALFIO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CodSpecLB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.STBiletTextBox = new System.Windows.Forms.TextBox();
            this.DTPDateBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNBacMain1 = new System.Windows.Forms.Button();
            this.STSave = new System.Windows.Forms.Button();
            this.BTNActiovateIns = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVGroups = new System.Windows.Forms.DataGridView();
            this.SearchGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fullspecnameLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DateB = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Group = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGroups)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // STFIOTextBox
            // 
            this.STFIOTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.STFIOTextBox.Location = new System.Drawing.Point(38, 32);
            this.STFIOTextBox.Name = "STFIOTextBox";
            this.STFIOTextBox.Size = new System.Drawing.Size(243, 20);
            this.STFIOTextBox.TabIndex = 25;
            this.STFIOTextBox.TabStop = false;
            this.STFIOTextBox.TextChanged += new System.EventHandler(this.STFIOTextBox_TextChanged);
            // 
            // LALFIO
            // 
            this.LALFIO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LALFIO.AutoSize = true;
            this.LALFIO.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.LALFIO.Location = new System.Drawing.Point(35, 10);
            this.LALFIO.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.LALFIO.Name = "LALFIO";
            this.LALFIO.Size = new System.Drawing.Size(246, 19);
            this.LALFIO.TabIndex = 26;
            this.LALFIO.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(4, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Группа";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(35, 375);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Код специальности/профессии";
            // 
            // CodSpecLB
            // 
            this.CodSpecLB.AutoSize = true;
            this.CodSpecLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodSpecLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.CodSpecLB.Location = new System.Drawing.Point(3, 13);
            this.CodSpecLB.Margin = new System.Windows.Forms.Padding(0);
            this.CodSpecLB.Name = "CodSpecLB";
            this.CodSpecLB.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.CodSpecLB.Size = new System.Drawing.Size(36, 19);
            this.CodSpecLB.TabIndex = 34;
            this.CodSpecLB.Text = "Код";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(35, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Номер студенческого билета";
            // 
            // STBiletTextBox
            // 
            this.STBiletTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.STBiletTextBox.Location = new System.Drawing.Point(38, 151);
            this.STBiletTextBox.Name = "STBiletTextBox";
            this.STBiletTextBox.Size = new System.Drawing.Size(243, 20);
            this.STBiletTextBox.TabIndex = 36;
            // 
            // DTPDateBirth
            // 
            this.DTPDateBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPDateBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPDateBirth.CustomFormat = "yyyy-MM-dd";
            this.DTPDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDateBirth.Location = new System.Drawing.Point(38, 106);
            this.DTPDateBirth.Name = "DTPDateBirth";
            this.DTPDateBirth.Size = new System.Drawing.Size(243, 20);
            this.DTPDateBirth.TabIndex = 37;
            this.DTPDateBirth.Value = new System.DateTime(6666, 9, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(4, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 8, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Дата рождения";
            // 
            // BTNBacMain1
            // 
            this.BTNBacMain1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNBacMain1.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTNBacMain1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNBacMain1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBacMain1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.BTNBacMain1.ForeColor = System.Drawing.Color.White;
            this.BTNBacMain1.Location = new System.Drawing.Point(287, 52);
            this.BTNBacMain1.Name = "BTNBacMain1";
            this.BTNBacMain1.Size = new System.Drawing.Size(0, 30);
            this.BTNBacMain1.TabIndex = 41;
            this.BTNBacMain1.Text = "Вернуться";
            this.BTNBacMain1.UseVisualStyleBackColor = false;
            this.BTNBacMain1.Click += new System.EventHandler(this.BTNBacMain1_Click);
            // 
            // STSave
            // 
            this.STSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.STSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.STSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.STSave.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.STSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.STSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.STSave.ForeColor = System.Drawing.Color.Ivory;
            this.STSave.Location = new System.Drawing.Point(38, 611);
            this.STSave.Name = "STSave";
            this.STSave.Size = new System.Drawing.Size(243, 33);
            this.STSave.TabIndex = 43;
            this.STSave.TabStop = false;
            this.STSave.Text = "Сохранить изменения";
            this.STSave.UseVisualStyleBackColor = false;
            this.STSave.Click += new System.EventHandler(this.STSave_Click);
            // 
            // BTNActiovateIns
            // 
            this.BTNActiovateIns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNActiovateIns.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNActiovateIns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNActiovateIns.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BTNActiovateIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNActiovateIns.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.BTNActiovateIns.ForeColor = System.Drawing.Color.Ivory;
            this.BTNActiovateIns.Location = new System.Drawing.Point(38, 572);
            this.BTNActiovateIns.Name = "BTNActiovateIns";
            this.BTNActiovateIns.Size = new System.Drawing.Size(243, 33);
            this.BTNActiovateIns.TabIndex = 44;
            this.BTNActiovateIns.TabStop = false;
            this.BTNActiovateIns.Text = "Внести правки";
            this.BTNActiovateIns.UseVisualStyleBackColor = false;
            this.BTNActiovateIns.Click += new System.EventHandler(this.BTNActiovateIns_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.BackColor = System.Drawing.Color.LightSlateGray;
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.Cancel.ForeColor = System.Drawing.Color.Ivory;
            this.Cancel.Location = new System.Drawing.Point(287, 13);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(0, 33);
            this.Cancel.TabIndex = 45;
            this.Cancel.Text = "Отменить";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Полное название специальности";
            // 
            // DGVGroups
            // 
            this.DGVGroups.AllowUserToAddRows = false;
            this.DGVGroups.AllowUserToDeleteRows = false;
            this.DGVGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVGroups.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVGroups.BackgroundColor = System.Drawing.Color.White;
            this.DGVGroups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVGroups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGroups.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVGroups.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVGroups.GridColor = System.Drawing.Color.White;
            this.DGVGroups.Location = new System.Drawing.Point(38, 222);
            this.DGVGroups.MultiSelect = false;
            this.DGVGroups.Name = "DGVGroups";
            this.DGVGroups.ReadOnly = true;
            this.DGVGroups.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVGroups.RowHeadersVisible = false;
            this.DGVGroups.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVGroups.Size = new System.Drawing.Size(243, 95);
            this.DGVGroups.TabIndex = 47;
            this.DGVGroups.TabStop = false;
            this.DGVGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGroups_CellClick);
            this.DGVGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGroups_CellContentClick);
            // 
            // SearchGroup
            // 
            this.SearchGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchGroup.Location = new System.Drawing.Point(38, 196);
            this.SearchGroup.Name = "SearchGroup";
            this.SearchGroup.Size = new System.Drawing.Size(243, 20);
            this.SearchGroup.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(35, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "Поиск по группам";
            // 
            // fullspecnameLB
            // 
            this.fullspecnameLB.AutoEllipsis = true;
            this.fullspecnameLB.AutoSize = true;
            this.fullspecnameLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullspecnameLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.fullspecnameLB.Location = new System.Drawing.Point(3, 19);
            this.fullspecnameLB.MaximumSize = new System.Drawing.Size(200, 0);
            this.fullspecnameLB.Name = "fullspecnameLB";
            this.fullspecnameLB.Size = new System.Drawing.Size(200, 19);
            this.fullspecnameLB.TabIndex = 49;
            this.fullspecnameLB.Text = "Расшифровка специальности";
            this.fullspecnameLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fullspecnameLB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(38, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 104);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.LALFIO);
            this.flowLayoutPanel1.Controls.Add(this.STFIOTextBox);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.DTPDateBirth);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.STBiletTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.SearchGroup);
            this.flowLayoutPanel1.Controls.Add(this.DGVGroups);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.BTNActiovateIns);
            this.flowLayoutPanel1.Controls.Add(this.STSave);
            this.flowLayoutPanel1.Controls.Add(this.Cancel);
            this.flowLayoutPanel1.Controls.Add(this.BTNBacMain1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(35, 10, 50, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(318, 689);
            this.flowLayoutPanel1.TabIndex = 56;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DateB);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(38, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 42);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            // 
            // DateB
            // 
            this.DateB.AutoSize = true;
            this.DateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateB.Location = new System.Drawing.Point(127, 18);
            this.DateB.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DateB.Name = "DateB";
            this.DateB.Size = new System.Drawing.Size(39, 16);
            this.DateB.TabIndex = 59;
            this.DateB.Text = "Дата";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Group);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(38, 323);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 49);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            // 
            // Group
            // 
            this.Group.AutoSize = true;
            this.Group.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.Group.Location = new System.Drawing.Point(84, 19);
            this.Group.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(54, 19);
            this.Group.TabIndex = 57;
            this.Group.Text = "Группа";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CodSpecLB);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(38, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.groupBox2.Size = new System.Drawing.Size(243, 40);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            // 
            // STDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(358, 769);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "STDescription";
            this.Resizable = false;
            this.Text = "Информация о студенте";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.STDescription_FormClosing);
            this.Load += new System.EventHandler(this.STDescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGroups)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LALFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTNBacMain1;
        private System.Windows.Forms.Button STSave;
        private System.Windows.Forms.Button BTNActiovateIns;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label CodSpecLB;
        public System.Windows.Forms.TextBox STBiletTextBox;
        public System.Windows.Forms.Label fullspecnameLB;
        public System.Windows.Forms.TextBox STFIOTextBox;
        public System.Windows.Forms.DataGridView DGVGroups;
        public System.Windows.Forms.Label Group;
        public System.Windows.Forms.DateTimePicker DTPDateBirth;
        public System.Windows.Forms.Label DateB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}