
namespace StudentSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVStudentList = new System.Windows.Forms.DataGridView();
            this.BTNInsertST = new System.Windows.Forms.Button();
            this.BTNSTInfo = new System.Windows.Forms.Button();
            this.SearchST = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.перенестиВОтчисленныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.темаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тёмнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светлаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CBGroup = new MetroFramework.Controls.MetroComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиПодключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвторахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСпециальностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TCST = new MetroFramework.Controls.MetroTabControl();
            this.TPAllST = new MetroFramework.Controls.MetroTabPage();
            this.TPEXST = new MetroFramework.Controls.MetroTabPage();
            this.DGVExpelledtList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтудентаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.TCST.SuspendLayout();
            this.TPAllST.SuspendLayout();
            this.TPEXST.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVExpelledtList)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVStudentList
            // 
            this.DGVStudentList.AllowUserToAddRows = false;
            this.DGVStudentList.AllowUserToDeleteRows = false;
            this.DGVStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVStudentList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVStudentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVStudentList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVStudentList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVStudentList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DGVStudentList.Location = new System.Drawing.Point(0, 3);
            this.DGVStudentList.MultiSelect = false;
            this.DGVStudentList.Name = "DGVStudentList";
            this.DGVStudentList.ReadOnly = true;
            this.DGVStudentList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVStudentList.Size = new System.Drawing.Size(687, 412);
            this.DGVStudentList.TabIndex = 0;
            this.DGVStudentList.TabStop = false;
            this.DGVStudentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStudentList_CellClick);
            this.DGVStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStudentList_CellContentClick);
            this.DGVStudentList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVStudentList_CellMouseClick);
            // 
            // BTNInsertST
            // 
            this.BTNInsertST.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNInsertST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNInsertST.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNInsertST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNInsertST.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.BTNInsertST.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNInsertST.Location = new System.Drawing.Point(34, 580);
            this.BTNInsertST.Name = "BTNInsertST";
            this.BTNInsertST.Size = new System.Drawing.Size(207, 32);
            this.BTNInsertST.TabIndex = 3;
            this.BTNInsertST.TabStop = false;
            this.BTNInsertST.Text = "Добавить студента";
            this.BTNInsertST.UseVisualStyleBackColor = false;
            this.BTNInsertST.Click += new System.EventHandler(this.BTNInsertST_Click);
            // 
            // BTNSTInfo
            // 
            this.BTNSTInfo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNSTInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSTInfo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNSTInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSTInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.BTNSTInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNSTInfo.Location = new System.Drawing.Point(34, 527);
            this.BTNSTInfo.Name = "BTNSTInfo";
            this.BTNSTInfo.Size = new System.Drawing.Size(207, 32);
            this.BTNSTInfo.TabIndex = 4;
            this.BTNSTInfo.TabStop = false;
            this.BTNSTInfo.Text = "Подробная информация";
            this.BTNSTInfo.UseVisualStyleBackColor = false;
            this.BTNSTInfo.Click += new System.EventHandler(this.BTNSTInfo_Click);
            // 
            // SearchST
            // 
            this.SearchST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchST.Location = new System.Drawing.Point(0, 20);
            this.SearchST.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.SearchST.Multiline = true;
            this.SearchST.Name = "SearchST";
            this.SearchST.Size = new System.Drawing.Size(382, 21);
            this.SearchST.TabIndex = 8;
            this.SearchST.TextChanged += new System.EventHandler(this.SearchST_TextChanged);
            this.SearchST.Leave += new System.EventHandler(this.SearchST_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Поиск";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перенестиВОтчисленныеToolStripMenuItem,
            this.удалитьСтудентаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // перенестиВОтчисленныеToolStripMenuItem
            // 
            this.перенестиВОтчисленныеToolStripMenuItem.Name = "перенестиВОтчисленныеToolStripMenuItem";
            this.перенестиВОтчисленныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.перенестиВОтчисленныеToolStripMenuItem.Text = "В \"Отчисленные\"";
            this.перенестиВОтчисленныеToolStripMenuItem.Click += new System.EventHandler(this.перенестиВОтчисленныеToolStripMenuItem_Click);
            // 
            // удалитьСтудентаToolStripMenuItem
            // 
            this.удалитьСтудентаToolStripMenuItem.Name = "удалитьСтудентаToolStripMenuItem";
            this.удалитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьСтудентаToolStripMenuItem.Text = "Удалить студента";
            this.удалитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.удалитьСтудентаToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Поиск по";
            // 
            // темаToolStripMenuItem
            // 
            this.темаToolStripMenuItem.Name = "темаToolStripMenuItem";
            this.темаToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // тёмнаяToolStripMenuItem
            // 
            this.тёмнаяToolStripMenuItem.Name = "тёмнаяToolStripMenuItem";
            this.тёмнаяToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // светлаяToolStripMenuItem
            // 
            this.светлаяToolStripMenuItem.Name = "светлаяToolStripMenuItem";
            this.светлаяToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.SearchST);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(585, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(382, 41);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.CBGroup);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(273, 104);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(149, 52);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // CBGroup
            // 
            this.CBGroup.FormattingEnabled = true;
            this.CBGroup.ItemHeight = 23;
            this.CBGroup.Items.AddRange(new object[] {
            "Группам",
            "ФИО"});
            this.CBGroup.Location = new System.Drawing.Point(0, 23);
            this.CBGroup.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.CBGroup.Name = "CBGroup";
            this.CBGroup.Size = new System.Drawing.Size(121, 29);
            this.CBGroup.TabIndex = 16;
            this.CBGroup.SelectedIndexChanged += new System.EventHandler(this.CBGroup_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиПодключенияToolStripMenuItem,
            this.обАвторахToolStripMenuItem,
            this.jToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(19, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(355, 27);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиПодключенияToolStripMenuItem
            // 
            this.настройкиПодключенияToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.настройкиПодключенияToolStripMenuItem.Name = "настройкиПодключенияToolStripMenuItem";
            this.настройкиПодключенияToolStripMenuItem.Size = new System.Drawing.Size(183, 23);
            this.настройкиПодключенияToolStripMenuItem.Text = "Настройки подключения";
            this.настройкиПодключенияToolStripMenuItem.Click += new System.EventHandler(this.настройкиПодключенияToolStripMenuItem_Click);
            // 
            // обАвторахToolStripMenuItem
            // 
            this.обАвторахToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.обАвторахToolStripMenuItem.Name = "обАвторахToolStripMenuItem";
            this.обАвторахToolStripMenuItem.Size = new System.Drawing.Size(95, 23);
            this.обАвторахToolStripMenuItem.Text = "Об авторах";
            // 
            // jToolStripMenuItem
            // 
            this.jToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьГруппуToolStripMenuItem,
            this.добавитьСпециальностьToolStripMenuItem});
            this.jToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.jToolStripMenuItem.Name = "jToolStripMenuItem";
            this.jToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.jToolStripMenuItem.Text = "Группы";
            // 
            // добавитьГруппуToolStripMenuItem
            // 
            this.добавитьГруппуToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.добавитьГруппуToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.добавитьГруппуToolStripMenuItem.Name = "добавитьГруппуToolStripMenuItem";
            this.добавитьГруппуToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.добавитьГруппуToolStripMenuItem.Text = "Добавить Группу";
            this.добавитьГруппуToolStripMenuItem.Click += new System.EventHandler(this.добавитьГруппуToolStripMenuItem_Click);
            // 
            // добавитьСпециальностьToolStripMenuItem
            // 
            this.добавитьСпециальностьToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.добавитьСпециальностьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.добавитьСпециальностьToolStripMenuItem.Name = "добавитьСпециальностьToolStripMenuItem";
            this.добавитьСпециальностьToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.добавитьСпециальностьToolStripMenuItem.Text = "Добавить Специальность";
            this.добавитьСпециальностьToolStripMenuItem.Click += new System.EventHandler(this.добавитьСпециальностьToolStripMenuItem_Click);
            // 
            // TCST
            // 
            this.TCST.Controls.Add(this.TPAllST);
            this.TCST.Controls.Add(this.TPEXST);
            this.TCST.Location = new System.Drawing.Point(269, 162);
            this.TCST.Name = "TCST";
            this.TCST.SelectedIndex = 0;
            this.TCST.Size = new System.Drawing.Size(698, 450);
            this.TCST.TabIndex = 17;
            this.TCST.SelectedIndexChanged += new System.EventHandler(this.TCST_SelectedIndexChanged);
            // 
            // TPAllST
            // 
            this.TPAllST.Controls.Add(this.DGVStudentList);
            this.TPAllST.HorizontalScrollbarBarColor = true;
            this.TPAllST.Location = new System.Drawing.Point(4, 35);
            this.TPAllST.Name = "TPAllST";
            this.TPAllST.Size = new System.Drawing.Size(690, 411);
            this.TPAllST.TabIndex = 0;
            this.TPAllST.Text = "Все студенты";
            this.TPAllST.VerticalScrollbarBarColor = true;
            // 
            // TPEXST
            // 
            this.TPEXST.Controls.Add(this.DGVExpelledtList);
            this.TPEXST.HorizontalScrollbarBarColor = true;
            this.TPEXST.Location = new System.Drawing.Point(4, 35);
            this.TPEXST.Name = "TPEXST";
            this.TPEXST.Size = new System.Drawing.Size(690, 411);
            this.TPEXST.TabIndex = 1;
            this.TPEXST.Text = "Отчисленные";
            this.TPEXST.VerticalScrollbarBarColor = true;
            // 
            // DGVExpelledtList
            // 
            this.DGVExpelledtList.AllowUserToAddRows = false;
            this.DGVExpelledtList.AllowUserToDeleteRows = false;
            this.DGVExpelledtList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVExpelledtList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVExpelledtList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVExpelledtList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVExpelledtList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVExpelledtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVExpelledtList.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVExpelledtList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DGVExpelledtList.Location = new System.Drawing.Point(0, 3);
            this.DGVExpelledtList.MultiSelect = false;
            this.DGVExpelledtList.Name = "DGVExpelledtList";
            this.DGVExpelledtList.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVExpelledtList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVExpelledtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVExpelledtList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVExpelledtList.Size = new System.Drawing.Size(687, 405);
            this.DGVExpelledtList.TabIndex = 2;
            this.DGVExpelledtList.TabStop = false;
            this.DGVExpelledtList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVExpelledtList_CellMouseClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.удалитьСтудентаToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip2.Size = new System.Drawing.Size(208, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.toolStripMenuItem1.Text = "Отменить изменения";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.отменитьИзмененияToolStripMenuItem_Click);
            // 
            // удалитьСтудентаToolStripMenuItem1
            // 
            this.удалитьСтудентаToolStripMenuItem1.Name = "удалитьСтудентаToolStripMenuItem1";
            this.удалитьСтудентаToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.удалитьСтудентаToolStripMenuItem1.Text = "Удалить студента";
            this.удалитьСтудентаToolStripMenuItem1.Click += new System.EventHandler(this.удалитьСтудентаToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 655);
            this.Controls.Add(this.TCST);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BTNSTInfo);
            this.Controls.Add(this.BTNInsertST);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(19, 60, 19, 20);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Учёт студентов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TCST.ResumeLayout(false);
            this.TPAllST.ResumeLayout(false);
            this.TPEXST.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVExpelledtList)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNInsertST;
        private System.Windows.Forms.Button BTNSTInfo;
        private System.Windows.Forms.TextBox SearchST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem перенестиВОтчисленныеToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem темаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тёмнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem светлаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиПодключенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвторахToolStripMenuItem;
        private MetroFramework.Controls.MetroComboBox CBGroup;
        private MetroFramework.Controls.MetroTabControl TCST;
        private MetroFramework.Controls.MetroTabPage TPAllST;
        private MetroFramework.Controls.MetroTabPage TPEXST;
        private System.Windows.Forms.DataGridView DGVExpelledtList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтудентаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСпециальностьToolStripMenuItem;
        public System.Windows.Forms.DataGridView DGVStudentList;
    }
}

