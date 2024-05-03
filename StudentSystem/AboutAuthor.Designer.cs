namespace StudentSystem
{
    partial class AboutAuthor
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
            this.authorsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorsLabel
            // 
            this.authorsLabel.AutoSize = true;
            this.authorsLabel.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorsLabel.Location = new System.Drawing.Point(40, 97);
            this.authorsLabel.Name = "authorsLabel";
            this.authorsLabel.Size = new System.Drawing.Size(370, 175);
            this.authorsLabel.TabIndex = 0;
            this.authorsLabel.Text = "Над системой работали такие студенты:\r\n\r\nДубинский Кирилл Алексеевич\r\n\r\nКанатьев " +
    "Николай Сергеевич\r\n\r\nТарапата Никита Евгеньевич\r\n";
            // 
            // AboutAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authorsLabel);
            this.MaximizeBox = false;
            this.Name = "AboutAuthor";
            this.Resizable = false;
            this.Text = "Об авторах";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutAuthor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorsLabel;
    }
}