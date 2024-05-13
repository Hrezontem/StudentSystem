namespace StudentSystem
{
    partial class ConnDBForm
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
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DBTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.BTNauth = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPBase = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPAuth = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNchange = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.FLPBase.SuspendLayout();
            this.FLPAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(4, 74);
            this.IPTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(518, 24);
            this.IPTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(4, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP-адрес сервера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(4, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Порт";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(4, 125);
            this.PortTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(518, 24);
            this.PortTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название базы";
            // 
            // DBTextBox
            // 
            this.DBTextBox.Location = new System.Drawing.Point(4, 23);
            this.DBTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DBTextBox.Name = "DBTextBox";
            this.DBTextBox.Size = new System.Drawing.Size(518, 24);
            this.DBTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Логин";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginTextBox.Location = new System.Drawing.Point(4, 23);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(518, 24);
            this.LoginTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(4, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTextBox.Location = new System.Drawing.Point(4, 74);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(518, 24);
            this.PasswordTextBox.TabIndex = 8;
            // 
            // BTNauth
            // 
            this.BTNauth.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNauth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNauth.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BTNauth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNauth.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNauth.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNauth.Location = new System.Drawing.Point(4, 106);
            this.BTNauth.Margin = new System.Windows.Forms.Padding(4);
            this.BTNauth.Name = "BTNauth";
            this.BTNauth.Size = new System.Drawing.Size(518, 48);
            this.BTNauth.TabIndex = 19;
            this.BTNauth.Text = "Войти";
            this.BTNauth.UseVisualStyleBackColor = false;
            this.BTNauth.Click += new System.EventHandler(this.BTNauth_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.LoginTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.PasswordTextBox);
            this.flowLayoutPanel1.Controls.Add(this.BTNauth);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 220);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(526, 158);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // FLPBase
            // 
            this.FLPBase.Controls.Add(this.label3);
            this.FLPBase.Controls.Add(this.DBTextBox);
            this.FLPBase.Controls.Add(this.label1);
            this.FLPBase.Controls.Add(this.IPTextBox);
            this.FLPBase.Controls.Add(this.label2);
            this.FLPBase.Controls.Add(this.PortTextBox);
            this.FLPBase.Enabled = false;
            this.FLPBase.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPBase.Location = new System.Drawing.Point(3, 3);
            this.FLPBase.Name = "FLPBase";
            this.FLPBase.Size = new System.Drawing.Size(526, 155);
            this.FLPBase.TabIndex = 21;
            // 
            // FLPAuth
            // 
            this.FLPAuth.Controls.Add(this.FLPBase);
            this.FLPAuth.Controls.Add(this.BTNchange);
            this.FLPAuth.Controls.Add(this.flowLayoutPanel1);
            this.FLPAuth.Location = new System.Drawing.Point(21, 54);
            this.FLPAuth.Name = "FLPAuth";
            this.FLPAuth.Size = new System.Drawing.Size(529, 459);
            this.FLPAuth.TabIndex = 22;
            // 
            // BTNchange
            // 
            this.BTNchange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNchange.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNchange.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BTNchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNchange.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNchange.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNchange.Location = new System.Drawing.Point(415, 165);
            this.BTNchange.Margin = new System.Windows.Forms.Padding(415, 4, 4, 4);
            this.BTNchange.Name = "BTNchange";
            this.BTNchange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTNchange.Size = new System.Drawing.Size(110, 48);
            this.BTNchange.TabIndex = 20;
            this.BTNchange.Text = "Изменить";
            this.BTNchange.Click += new System.EventHandler(this.BTNchange_Click);
            // 
            // ConnDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(580, 702);
            this.Controls.Add(this.FLPAuth);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ConnDBForm";
            this.Padding = new System.Windows.Forms.Padding(27, 88, 27, 29);
            this.Resizable = false;
            this.Text = "Авторизация";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.ConnDBForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.FLPBase.ResumeLayout(false);
            this.FLPBase.PerformLayout();
            this.FLPAuth.ResumeLayout(false);
            this.FLPAuth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DBTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button BTNauth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel FLPBase;
        private System.Windows.Forms.FlowLayoutPanel FLPAuth;
        private System.Windows.Forms.Button BTNchange;
    }
}