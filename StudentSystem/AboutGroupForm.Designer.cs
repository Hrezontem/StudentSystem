namespace StudentSystem
{
    partial class AboutGroupForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MTBDateStudy = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNSTInfo = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.Group_Text = new System.Windows.Forms.Label();
            this.DGVFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.DGVGroups = new System.Windows.Forms.DataGridView();
            this.grouplabel = new System.Windows.Forms.Label();
            this.BTNChange = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.DGVFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // MTBDateStudy
            // 
            this.MTBDateStudy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MTBDateStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MTBDateStudy.Location = new System.Drawing.Point(113, 3);
            this.MTBDateStudy.Mask = "(0000-0000)";
            this.MTBDateStudy.Name = "MTBDateStudy";
            this.MTBDateStudy.Size = new System.Drawing.Size(75, 15);
            this.MTBDateStudy.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Года обучения";
            // 
            // BTNSTInfo
            // 
            this.BTNSTInfo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNSTInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSTInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNSTInfo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNSTInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSTInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.BTNSTInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNSTInfo.Location = new System.Drawing.Point(3, 247);
            this.BTNSTInfo.Name = "BTNSTInfo";
            this.BTNSTInfo.Size = new System.Drawing.Size(217, 36);
            this.BTNSTInfo.TabIndex = 5;
            this.BTNSTInfo.TabStop = false;
            this.BTNSTInfo.Text = "Сохранить";
            this.BTNSTInfo.UseVisualStyleBackColor = false;
            this.BTNSTInfo.Click += new System.EventHandler(this.BTNSTInfo_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.MTBDateStudy);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(217, 27);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.grouplabel);
            this.flowLayoutPanel2.Controls.Add(this.DGVFlowLayout);
            this.flowLayoutPanel2.Controls.Add(this.BTNChange);
            this.flowLayoutPanel2.Controls.Add(this.BTNSTInfo);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(20, 60);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(223, 290);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.Group_Text);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(217, 24);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выбранная группа:";
            // 
            // Group_Text
            // 
            this.Group_Text.AutoSize = true;
            this.Group_Text.Location = new System.Drawing.Point(126, 0);
            this.Group_Text.Name = "Group_Text";
            this.Group_Text.Size = new System.Drawing.Size(16, 13);
            this.Group_Text.TabIndex = 7;
            this.Group_Text.Text = "...";
            // 
            // DGVFlowLayout
            // 
            this.DGVFlowLayout.Controls.Add(this.DGVGroups);
            this.DGVFlowLayout.Location = new System.Drawing.Point(3, 82);
            this.DGVFlowLayout.Name = "DGVFlowLayout";
            this.DGVFlowLayout.Size = new System.Drawing.Size(217, 117);
            this.DGVFlowLayout.TabIndex = 10;
            this.DGVFlowLayout.Visible = false;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGroups.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVGroups.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVGroups.GridColor = System.Drawing.Color.White;
            this.DGVGroups.Location = new System.Drawing.Point(0, 0);
            this.DGVGroups.Margin = new System.Windows.Forms.Padding(0);
            this.DGVGroups.MultiSelect = false;
            this.DGVGroups.Name = "DGVGroups";
            this.DGVGroups.ReadOnly = true;
            this.DGVGroups.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVGroups.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVGroups.RowHeadersVisible = false;
            this.DGVGroups.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVGroups.Size = new System.Drawing.Size(217, 117);
            this.DGVGroups.TabIndex = 49;
            this.DGVGroups.TabStop = false;
            this.DGVGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGroups_CellClick);
            // 
            // grouplabel
            // 
            this.grouplabel.AutoSize = true;
            this.grouplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grouplabel.Location = new System.Drawing.Point(3, 63);
            this.grouplabel.Name = "grouplabel";
            this.grouplabel.Size = new System.Drawing.Size(189, 16);
            this.grouplabel.TabIndex = 11;
            this.grouplabel.Text = "Замена у студентов группу";
            this.grouplabel.Visible = false;
            // 
            // BTNChange
            // 
            this.BTNChange.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNChange.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNChange.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.BTNChange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNChange.Location = new System.Drawing.Point(3, 205);
            this.BTNChange.Name = "BTNChange";
            this.BTNChange.Size = new System.Drawing.Size(217, 36);
            this.BTNChange.TabIndex = 12;
            this.BTNChange.TabStop = false;
            this.BTNChange.Text = "Перевести студентов";
            this.BTNChange.UseVisualStyleBackColor = false;
            this.BTNChange.Click += new System.EventHandler(this.BTNChange_Click);
            // 
            // AboutGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(263, 370);
            this.Controls.Add(this.flowLayoutPanel2);
            this.MaximizeBox = false;
            this.Name = "AboutGroupForm";
            this.Resizable = false;
            this.Text = "Изменение группы";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutGroupForm_FormClosing);
            this.Load += new System.EventHandler(this.AboutGroupForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.DGVFlowLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MTBDateStudy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNSTInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label Group_Text;
        private System.Windows.Forms.FlowLayoutPanel DGVFlowLayout;
        public System.Windows.Forms.DataGridView DGVGroups;
        private System.Windows.Forms.Label grouplabel;
        private System.Windows.Forms.Button BTNChange;
    }
}