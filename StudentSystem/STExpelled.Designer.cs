namespace StudentSystem
{
    partial class STExpelled
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVExpelledtList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchEST = new System.Windows.Forms.TextBox();
            this.BTNSTInfo = new System.Windows.Forms.Button();
            this.BTNBacMain1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отменитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVExpelledtList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVExpelledtList
            // 
            this.DGVExpelledtList.AllowUserToAddRows = false;
            this.DGVExpelledtList.AllowUserToDeleteRows = false;
            this.DGVExpelledtList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVExpelledtList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVExpelledtList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVExpelledtList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVExpelledtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVExpelledtList.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVExpelledtList.Location = new System.Drawing.Point(285, 81);
            this.DGVExpelledtList.Name = "DGVExpelledtList";
            this.DGVExpelledtList.ReadOnly = true;
            this.DGVExpelledtList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVExpelledtList.Size = new System.Drawing.Size(670, 446);
            this.DGVExpelledtList.TabIndex = 1;
            this.DGVExpelledtList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStudentList_CellContentClick);
            this.DGVExpelledtList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVExpelledtList_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Поиск";
            // 
            // SearchEST
            // 
            this.SearchEST.Location = new System.Drawing.Point(3, 23);
            this.SearchEST.Multiline = true;
            this.SearchEST.Name = "SearchEST";
            this.SearchEST.Size = new System.Drawing.Size(231, 21);
            this.SearchEST.TabIndex = 10;
            this.SearchEST.TextChanged += new System.EventHandler(this.SearchEST_TextChanged);
            // 
            // BTNSTInfo
            // 
            this.BTNSTInfo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNSTInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSTInfo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNSTInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSTInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.BTNSTInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNSTInfo.Location = new System.Drawing.Point(42, 449);
            this.BTNSTInfo.Name = "BTNSTInfo";
            this.BTNSTInfo.Size = new System.Drawing.Size(201, 32);
            this.BTNSTInfo.TabIndex = 12;
            this.BTNSTInfo.Text = "Подробная информация";
            this.BTNSTInfo.UseVisualStyleBackColor = false;
            // 
            // BTNBacMain1
            // 
            this.BTNBacMain1.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTNBacMain1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNBacMain1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBacMain1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.BTNBacMain1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNBacMain1.Location = new System.Drawing.Point(42, 497);
            this.BTNBacMain1.Name = "BTNBacMain1";
            this.BTNBacMain1.Size = new System.Drawing.Size(201, 30);
            this.BTNBacMain1.TabIndex = 20;
            this.BTNBacMain1.Text = "Вернуться на главную";
            this.BTNBacMain1.UseVisualStyleBackColor = false;
            this.BTNBacMain1.Click += new System.EventHandler(this.BTNBacMain1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьИзмененияToolStripMenuItem,
            this.удалитьСтудентаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 48);
            // 
            // отменитьИзмененияToolStripMenuItem
            // 
            this.отменитьИзмененияToolStripMenuItem.Name = "отменитьИзмененияToolStripMenuItem";
            this.отменитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.отменитьИзмененияToolStripMenuItem.Text = "Отменить изменения";
            this.отменитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.отменитьИзмененияToolStripMenuItem_Click);
            // 
            // удалитьСтудентаToolStripMenuItem
            // 
            this.удалитьСтудентаToolStripMenuItem.Name = "удалитьСтудентаToolStripMenuItem";
            this.удалитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.удалитьСтудентаToolStripMenuItem.Text = "Удалить студента";
            this.удалитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.удалитьСтудентаToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.SearchEST);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(708, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(247, 51);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // STExpelled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 575);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BTNBacMain1);
            this.Controls.Add(this.BTNSTInfo);
            this.Controls.Add(this.DGVExpelledtList);
            this.MaximizeBox = false;
            this.Name = "STExpelled";
            this.Text = "Отчисленные студенты";
            this.Load += new System.EventHandler(this.STExpelled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVExpelledtList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVExpelledtList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchEST;
        private System.Windows.Forms.Button BTNSTInfo;
        private System.Windows.Forms.Button BTNBacMain1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отменитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}