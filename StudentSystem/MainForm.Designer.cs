
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
            this.DGVStudentList = new System.Windows.Forms.DataGridView();
            this.BTNInsertST = new System.Windows.Forms.Button();
            this.BTNSTInfo = new System.Windows.Forms.Button();
            this.SearchST = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.перенестиВОтчисленныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.STExpelledBTN = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStudentList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DGVStudentList.Location = new System.Drawing.Point(269, 166);
            this.DGVStudentList.MultiSelect = false;
            this.DGVStudentList.Name = "DGVStudentList";
            this.DGVStudentList.ReadOnly = true;
            this.DGVStudentList.RowHeadersWidth = 51;
            this.DGVStudentList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVStudentList.Size = new System.Drawing.Size(698, 446);
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
            this.SearchST.Location = new System.Drawing.Point(0, 25);
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
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Поиск по ФИО";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перенестиВОтчисленныеToolStripMenuItem,
            this.удалитьСтудентаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 52);
            // 
            // перенестиВОтчисленныеToolStripMenuItem
            // 
            this.перенестиВОтчисленныеToolStripMenuItem.Name = "перенестиВОтчисленныеToolStripMenuItem";
            this.перенестиВОтчисленныеToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.перенестиВОтчисленныеToolStripMenuItem.Text = "В \"Отчисленные\"";
            this.перенестиВОтчисленныеToolStripMenuItem.Click += new System.EventHandler(this.перенестиВОтчисленныеToolStripMenuItem_Click);
            // 
            // удалитьСтудентаToolStripMenuItem
            // 
            this.удалитьСтудентаToolStripMenuItem.Name = "удалитьСтудентаToolStripMenuItem";
            this.удалитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.удалитьСтудентаToolStripMenuItem.Text = "Удалить студента";
            this.удалитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.удалитьСтудентаToolStripMenuItem_Click);
            // 
            // STExpelledBTN
            // 
            this.STExpelledBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.STExpelledBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.STExpelledBTN.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.STExpelledBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.STExpelledBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.STExpelledBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.STExpelledBTN.Location = new System.Drawing.Point(34, 473);
            this.STExpelledBTN.Name = "STExpelledBTN";
            this.STExpelledBTN.Size = new System.Drawing.Size(207, 32);
            this.STExpelledBTN.TabIndex = 11;
            this.STExpelledBTN.TabStop = false;
            this.STExpelledBTN.Text = "Список отчисленных";
            this.STExpelledBTN.UseVisualStyleBackColor = false;
            this.STExpelledBTN.Click += new System.EventHandler(this.STExpelledBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(582, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(385, 42);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.CBGroup);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(269, 105);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(149, 55);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // CBGroup
            // 
            this.CBGroup.FormattingEnabled = true;
            this.CBGroup.ItemHeight = 24;
            this.CBGroup.Items.AddRange(new object[] {
            "Группам",
            "ФИО"});
            this.CBGroup.Location = new System.Drawing.Point(0, 28);
            this.CBGroup.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.CBGroup.Name = "CBGroup";
            this.CBGroup.Size = new System.Drawing.Size(121, 30);
            this.CBGroup.TabIndex = 16;
            this.CBGroup.SelectedIndexChanged += new System.EventHandler(this.CBGroup_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиПодключенияToolStripMenuItem,
            this.обАвторахToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(19, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(367, 31);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиПодключенияToolStripMenuItem
            // 
            this.настройкиПодключенияToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.настройкиПодключенияToolStripMenuItem.Name = "настройкиПодключенияToolStripMenuItem";
            this.настройкиПодключенияToolStripMenuItem.Size = new System.Drawing.Size(238, 27);
            this.настройкиПодключенияToolStripMenuItem.Text = "Настройки подключения";
            this.настройкиПодключенияToolStripMenuItem.Click += new System.EventHandler(this.настройкиПодключенияToolStripMenuItem_Click);
            // 
            // обАвторахToolStripMenuItem
            // 
            this.обАвторахToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.обАвторахToolStripMenuItem.Name = "обАвторахToolStripMenuItem";
            this.обАвторахToolStripMenuItem.Size = new System.Drawing.Size(121, 27);
            this.обАвторахToolStripMenuItem.Text = "Об авторах";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 655);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.STExpelledBTN);
            this.Controls.Add(this.BTNSTInfo);
            this.Controls.Add(this.BTNInsertST);
            this.Controls.Add(this.DGVStudentList);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVStudentList;
        private System.Windows.Forms.Button BTNInsertST;
        private System.Windows.Forms.Button BTNSTInfo;
        private System.Windows.Forms.TextBox SearchST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem перенестиВОтчисленныеToolStripMenuItem;
        private System.Windows.Forms.Button STExpelledBTN;
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
    }
}

