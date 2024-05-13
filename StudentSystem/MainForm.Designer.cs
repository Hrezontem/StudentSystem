
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.CBSelectSearch = new MetroFramework.Controls.MetroComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UserIndicator = new System.Windows.Forms.ToolStripMenuItem();
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
            this.TCSpecGroups = new MetroFramework.Controls.MetroTabControl();
            this.TCSpecGr = new MetroFramework.Controls.MetroTabPage();
            this.DGVSpec = new System.Windows.Forms.DataGridView();
            this.TCGroup = new MetroFramework.Controls.MetroTabPage();
            this.DGVGroups = new System.Windows.Forms.DataGridView();
            this.CMSChangeGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выпуститьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.настройкиПодключенияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.TCSpecGroups.SuspendLayout();
            this.TCSpecGr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSpec)).BeginInit();
            this.TCGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGroups)).BeginInit();
            this.CMSChangeGroup.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGVStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVStudentList.DefaultCellStyle = dataGridViewCellStyle13;
            this.DGVStudentList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DGVStudentList.Location = new System.Drawing.Point(3, 3);
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
            this.BTNInsertST.Location = new System.Drawing.Point(3, 41);
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
            this.BTNSTInfo.Location = new System.Drawing.Point(3, 3);
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
            this.SearchST.Size = new System.Drawing.Size(378, 21);
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
            this.flowLayoutPanel2.Controls.Add(this.CBSelectSearch);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(273, 104);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(149, 52);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // CBSelectSearch
            // 
            this.CBSelectSearch.FormattingEnabled = true;
            this.CBSelectSearch.ItemHeight = 23;
            this.CBSelectSearch.Items.AddRange(new object[] {
            "Группам",
            "ФИО"});
            this.CBSelectSearch.Location = new System.Drawing.Point(0, 23);
            this.CBSelectSearch.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.CBSelectSearch.Name = "CBSelectSearch";
            this.CBSelectSearch.Size = new System.Drawing.Size(121, 29);
            this.CBSelectSearch.TabIndex = 16;
            this.CBSelectSearch.SelectedIndexChanged += new System.EventHandler(this.CBSelectSearch_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserIndicator,
            this.jToolStripMenuItem,
            this.обАвторахToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(19, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(227, 27);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UserIndicator
            // 
            this.UserIndicator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиПодключенияToolStripMenuItem1});
            this.UserIndicator.ForeColor = System.Drawing.Color.White;
            this.UserIndicator.Name = "UserIndicator";
            this.UserIndicator.Size = new System.Drawing.Size(55, 23);
            this.UserIndicator.Text = "[user]";
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
            this.TCST.SelectedIndex = 1;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVExpelledtList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DGVExpelledtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVExpelledtList.DefaultCellStyle = dataGridViewCellStyle15;
            this.DGVExpelledtList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DGVExpelledtList.Location = new System.Drawing.Point(0, 3);
            this.DGVExpelledtList.MultiSelect = false;
            this.DGVExpelledtList.Name = "DGVExpelledtList";
            this.DGVExpelledtList.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVExpelledtList.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
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
            // TCSpecGroups
            // 
            this.TCSpecGroups.Controls.Add(this.TCSpecGr);
            this.TCSpecGroups.Controls.Add(this.TCGroup);
            this.TCSpecGroups.Location = new System.Drawing.Point(34, 162);
            this.TCSpecGroups.Name = "TCSpecGroups";
            this.TCSpecGroups.SelectedIndex = 0;
            this.TCSpecGroups.Size = new System.Drawing.Size(207, 289);
            this.TCSpecGroups.TabIndex = 18;
            this.TCSpecGroups.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // TCSpecGr
            // 
            this.TCSpecGr.Controls.Add(this.DGVSpec);
            this.TCSpecGr.HorizontalScrollbarBarColor = true;
            this.TCSpecGr.Location = new System.Drawing.Point(4, 35);
            this.TCSpecGr.Name = "TCSpecGr";
            this.TCSpecGr.Size = new System.Drawing.Size(199, 250);
            this.TCSpecGr.TabIndex = 0;
            this.TCSpecGr.Text = "Специальности";
            this.TCSpecGr.VerticalScrollbarBarColor = true;
            // 
            // DGVSpec
            // 
            this.DGVSpec.AllowUserToAddRows = false;
            this.DGVSpec.AllowUserToDeleteRows = false;
            this.DGVSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSpec.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVSpec.BackgroundColor = System.Drawing.Color.White;
            this.DGVSpec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVSpec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSpec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DGVSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSpec.ColumnHeadersVisible = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSpec.DefaultCellStyle = dataGridViewCellStyle18;
            this.DGVSpec.GridColor = System.Drawing.Color.White;
            this.DGVSpec.Location = new System.Drawing.Point(3, 3);
            this.DGVSpec.MultiSelect = false;
            this.DGVSpec.Name = "DGVSpec";
            this.DGVSpec.ReadOnly = true;
            this.DGVSpec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSpec.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DGVSpec.RowHeadersVisible = false;
            this.DGVSpec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVSpec.Size = new System.Drawing.Size(193, 247);
            this.DGVSpec.TabIndex = 48;
            this.DGVSpec.TabStop = false;
            this.DGVSpec.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVSpec_CellMouseClick);
            // 
            // TCGroup
            // 
            this.TCGroup.Controls.Add(this.DGVGroups);
            this.TCGroup.HorizontalScrollbarBarColor = true;
            this.TCGroup.Location = new System.Drawing.Point(4, 35);
            this.TCGroup.Name = "TCGroup";
            this.TCGroup.Size = new System.Drawing.Size(199, 250);
            this.TCGroup.TabIndex = 1;
            this.TCGroup.Text = "Группы";
            this.TCGroup.VerticalScrollbarBarColor = true;
            // 
            // DGVGroups
            // 
            this.DGVGroups.AllowUserToAddRows = false;
            this.DGVGroups.AllowUserToDeleteRows = false;
            this.DGVGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVGroups.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVGroups.BackgroundColor = System.Drawing.Color.White;
            this.DGVGroups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVGroups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.DGVGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGroups.ColumnHeadersVisible = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVGroups.DefaultCellStyle = dataGridViewCellStyle21;
            this.DGVGroups.GridColor = System.Drawing.Color.White;
            this.DGVGroups.Location = new System.Drawing.Point(3, 3);
            this.DGVGroups.MultiSelect = false;
            this.DGVGroups.Name = "DGVGroups";
            this.DGVGroups.ReadOnly = true;
            this.DGVGroups.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVGroups.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.DGVGroups.RowHeadersVisible = false;
            this.DGVGroups.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVGroups.Size = new System.Drawing.Size(193, 247);
            this.DGVGroups.TabIndex = 48;
            this.DGVGroups.TabStop = false;
            this.DGVGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGroups_CellClick);
            this.DGVGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGroups_CellContentClick);
            this.DGVGroups.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVGroups_CellMouseClick);
            // 
            // CMSChangeGroup
            // 
            this.CMSChangeGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьГруппуToolStripMenuItem,
            this.выпуститьГруппуToolStripMenuItem});
            this.CMSChangeGroup.Name = "contextMenuStrip3";
            this.CMSChangeGroup.Size = new System.Drawing.Size(174, 48);
            // 
            // изменитьГруппуToolStripMenuItem
            // 
            this.изменитьГруппуToolStripMenuItem.Name = "изменитьГруппуToolStripMenuItem";
            this.изменитьГруппуToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.изменитьГруппуToolStripMenuItem.Text = "Изменить группу";
            this.изменитьГруппуToolStripMenuItem.Click += new System.EventHandler(this.изменитьГруппуToolStripMenuItem_Click);
            // 
            // выпуститьГруппуToolStripMenuItem
            // 
            this.выпуститьГруппуToolStripMenuItem.Name = "выпуститьГруппуToolStripMenuItem";
            this.выпуститьГруппуToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.выпуститьГруппуToolStripMenuItem.Text = "Выпустить группу";
            this.выпуститьГруппуToolStripMenuItem.Click += new System.EventHandler(this.выпуститьГруппуToolStripMenuItem_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.BTNSTInfo);
            this.flowLayoutPanel3.Controls.Add(this.BTNInsertST);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(41, 530);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(222, 78);
            this.flowLayoutPanel3.TabIndex = 19;
            // 
            // настройкиПодключенияToolStripMenuItem1
            // 
            this.настройкиПодключенияToolStripMenuItem1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.настройкиПодключенияToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.настройкиПодключенияToolStripMenuItem1.Name = "настройкиПодключенияToolStripMenuItem1";
            this.настройкиПодключенияToolStripMenuItem1.Size = new System.Drawing.Size(240, 24);
            this.настройкиПодключенияToolStripMenuItem1.Text = "Настройки подключения";
            this.настройкиПодключенияToolStripMenuItem1.Click += new System.EventHandler(this.настройкиПодключенияToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 655);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.TCSpecGroups);
            this.Controls.Add(this.TCST);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.TCSpecGroups.ResumeLayout(false);
            this.TCSpecGr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSpec)).EndInit();
            this.TCGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGroups)).EndInit();
            this.CMSChangeGroup.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem UserIndicator;
        private System.Windows.Forms.ToolStripMenuItem обАвторахToolStripMenuItem;
        private MetroFramework.Controls.MetroComboBox CBSelectSearch;
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
        private MetroFramework.Controls.MetroTabControl TCSpecGroups;
        private MetroFramework.Controls.MetroTabPage TCSpecGr;
        private MetroFramework.Controls.MetroTabPage TCGroup;
        public System.Windows.Forms.DataGridView DGVSpec;
        public System.Windows.Forms.DataGridView DGVGroups;
        private System.Windows.Forms.ContextMenuStrip CMSChangeGroup;
        private System.Windows.Forms.ToolStripMenuItem изменитьГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выпуститьГруппуToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ToolStripMenuItem настройкиПодключенияToolStripMenuItem1;
    }
}

