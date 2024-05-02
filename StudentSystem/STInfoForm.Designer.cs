
namespace StudentSystem
{
    partial class STInfoForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LALFIO = new System.Windows.Forms.Label();
            this.CBCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBGroup = new System.Windows.Forms.ComboBox();
            this.CBYearStudy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CodSpec = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BTNInsertST = new System.Windows.Forms.Button();
            this.BTNBacMain1 = new System.Windows.Forms.Button();
            this.DTPDateBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 0;
            // 
            // LALFIO
            // 
            this.LALFIO.AutoSize = true;
            this.LALFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LALFIO.Location = new System.Drawing.Point(45, 36);
            this.LALFIO.Name = "LALFIO";
            this.LALFIO.Size = new System.Drawing.Size(47, 20);
            this.LALFIO.TabIndex = 1;
            this.LALFIO.Text = "ФИО";
            // 
            // CBCourse
            // 
            this.CBCourse.FormattingEnabled = true;
            this.CBCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CBCourse.Location = new System.Drawing.Point(49, 135);
            this.CBCourse.Name = "CBCourse";
            this.CBCourse.Size = new System.Drawing.Size(43, 21);
            this.CBCourse.TabIndex = 6;
            this.CBCourse.SelectedIndexChanged += new System.EventHandler(this.CBCourse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Курс";
            // 
            // CBGroup
            // 
            this.CBGroup.FormattingEnabled = true;
            this.CBGroup.Location = new System.Drawing.Point(115, 135);
            this.CBGroup.Name = "CBGroup";
            this.CBGroup.Size = new System.Drawing.Size(87, 21);
            this.CBGroup.TabIndex = 8;
            this.CBGroup.SelectedIndexChanged += new System.EventHandler(this.CBGroup_SelectedIndexChanged);
            // 
            // CBYearStudy
            // 
            this.CBYearStudy.FormattingEnabled = true;
            this.CBYearStudy.Location = new System.Drawing.Point(222, 135);
            this.CBYearStudy.Name = "CBYearStudy";
            this.CBYearStudy.Size = new System.Drawing.Size(136, 21);
            this.CBYearStudy.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(129, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(239, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Год обучения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(46, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Код специальности/профессии";
            // 
            // CodSpec
            // 
            this.CodSpec.AutoSize = true;
            this.CodSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodSpec.Location = new System.Drawing.Point(283, 172);
            this.CodSpec.Name = "CodSpec";
            this.CodSpec.Size = new System.Drawing.Size(29, 15);
            this.CodSpec.TabIndex = 13;
            this.CodSpec.Text = "Код";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(46, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Код студенческого билета";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 15;
            // 
            // BTNInsertST
            // 
            this.BTNInsertST.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNInsertST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNInsertST.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNInsertST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNInsertST.Location = new System.Drawing.Point(115, 471);
            this.BTNInsertST.Name = "BTNInsertST";
            this.BTNInsertST.Size = new System.Drawing.Size(180, 33);
            this.BTNInsertST.TabIndex = 18;
            this.BTNInsertST.Text = "Добавить студента";
            this.BTNInsertST.UseVisualStyleBackColor = false;
            // 
            // BTNBacMain1
            // 
            this.BTNBacMain1.BackColor = System.Drawing.Color.White;
            this.BTNBacMain1.Location = new System.Drawing.Point(162, 520);
            this.BTNBacMain1.Name = "BTNBacMain1";
            this.BTNBacMain1.Size = new System.Drawing.Size(93, 23);
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
            this.DTPDateBirth.Location = new System.Drawing.Point(168, 70);
            this.DTPDateBirth.Name = "DTPDateBirth";
            this.DTPDateBirth.Size = new System.Drawing.Size(99, 20);
            this.DTPDateBirth.TabIndex = 22;
            this.DTPDateBirth.Value = new System.DateTime(6666, 9, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(46, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Дата рождения";
            // 
            // STInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 552);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DTPDateBirth);
            this.Controls.Add(this.BTNBacMain1);
            this.Controls.Add(this.BTNInsertST);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CodSpec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBYearStudy);
            this.Controls.Add(this.CBGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBCourse);
            this.Controls.Add(this.LALFIO);
            this.Controls.Add(this.textBox1);
            this.Name = "STInfoForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LALFIO;
        private System.Windows.Forms.ComboBox CBCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBGroup;
        private System.Windows.Forms.ComboBox CBYearStudy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CodSpec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BTNInsertST;
        private System.Windows.Forms.Button BTNBacMain1;
        private System.Windows.Forms.DateTimePicker DTPDateBirth;
        private System.Windows.Forms.Label label7;
    }
}