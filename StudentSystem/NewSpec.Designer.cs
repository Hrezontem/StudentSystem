namespace StudentSystem
{
    partial class NewSpec
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
            this.NewSpecINSBTN = new System.Windows.Forms.Button();
            this.BTNBacMain1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FullSpecNameTB = new System.Windows.Forms.TextBox();
            this.CodSpecTB = new System.Windows.Forms.TextBox();
            this.SpecNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewSpecINSBTN
            // 
            this.NewSpecINSBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.NewSpecINSBTN.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.NewSpecINSBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewSpecINSBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewSpecINSBTN.ForeColor = System.Drawing.Color.White;
            this.NewSpecINSBTN.Location = new System.Drawing.Point(44, 411);
            this.NewSpecINSBTN.Name = "NewSpecINSBTN";
            this.NewSpecINSBTN.Size = new System.Drawing.Size(195, 30);
            this.NewSpecINSBTN.TabIndex = 29;
            this.NewSpecINSBTN.Text = "Добавить";
            this.NewSpecINSBTN.UseVisualStyleBackColor = false;
            this.NewSpecINSBTN.Click += new System.EventHandler(this.NewSpecINSBTN_Click);
            // 
            // BTNBacMain1
            // 
            this.BTNBacMain1.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTNBacMain1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNBacMain1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBacMain1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNBacMain1.ForeColor = System.Drawing.Color.White;
            this.BTNBacMain1.Location = new System.Drawing.Point(44, 447);
            this.BTNBacMain1.Name = "BTNBacMain1";
            this.BTNBacMain1.Size = new System.Drawing.Size(195, 30);
            this.BTNBacMain1.TabIndex = 28;
            this.BTNBacMain1.Text = "Отмена";
            this.BTNBacMain1.UseVisualStyleBackColor = false;
            this.BTNBacMain1.Click += new System.EventHandler(this.BTNBacMain1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Полное наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Код специальности:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Наименование:";
            // 
            // FullSpecNameTB
            // 
            this.FullSpecNameTB.Location = new System.Drawing.Point(44, 202);
            this.FullSpecNameTB.Multiline = true;
            this.FullSpecNameTB.Name = "FullSpecNameTB";
            this.FullSpecNameTB.Size = new System.Drawing.Size(195, 74);
            this.FullSpecNameTB.TabIndex = 24;
            // 
            // CodSpecTB
            // 
            this.CodSpecTB.Location = new System.Drawing.Point(44, 145);
            this.CodSpecTB.Name = "CodSpecTB";
            this.CodSpecTB.Size = new System.Drawing.Size(195, 20);
            this.CodSpecTB.TabIndex = 23;
            // 
            // SpecNameTB
            // 
            this.SpecNameTB.Location = new System.Drawing.Point(44, 92);
            this.SpecNameTB.Name = "SpecNameTB";
            this.SpecNameTB.Size = new System.Drawing.Size(195, 20);
            this.SpecNameTB.TabIndex = 22;
            // 
            // NewSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 499);
            this.Controls.Add(this.NewSpecINSBTN);
            this.Controls.Add(this.BTNBacMain1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FullSpecNameTB);
            this.Controls.Add(this.CodSpecTB);
            this.Controls.Add(this.SpecNameTB);
            this.MaximizeBox = false;
            this.Name = "NewSpec";
            this.Resizable = false;
            this.Text = "Новая специальность";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewSpec_FormClosing);
            this.Load += new System.EventHandler(this.NewSpec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewSpecINSBTN;
        private System.Windows.Forms.Button BTNBacMain1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FullSpecNameTB;
        private System.Windows.Forms.TextBox CodSpecTB;
        private System.Windows.Forms.TextBox SpecNameTB;
    }
}