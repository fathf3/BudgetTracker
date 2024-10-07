namespace BudgetTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            loginBtn = new Button();
            login_show_password = new CheckBox();
            login_registerBtn = new Button();
            closeBtn = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 464);
            panel1.TabIndex = 0;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(39, 230);
            label2.Name = "label2";
            label2.Size = new Size(207, 35);
            label2.TabIndex = 1;
            label2.Text = "Bütçe Hesaplama";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.budget;
            pictureBox1.Location = new Point(73, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1120, 7);
            label1.Name = "label1";
            label1.Size = new Size(26, 26);
            label1.TabIndex = 1;
            label1.Text = "X";
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(309, 66);
            label3.Name = "label3";
            label3.Size = new Size(169, 38);
            label3.TabIndex = 2;
            label3.Text = "Kullanıcı Adı";
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(309, 148);
            label4.Name = "label4";
            label4.Size = new Size(73, 38);
            label4.TabIndex = 3;
            label4.Text = "Şifre";
            
            // 
            // login_username
            // 
            login_username.Location = new Point(309, 107);
            login_username.Name = "login_username";
            login_username.Size = new Size(403, 27);
            login_username.TabIndex = 4;
            // 
            // login_password
            // 
            login_password.Location = new Point(309, 189);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(403, 27);
            login_password.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.SeaGreen;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.ForeColor = SystemColors.ButtonHighlight;
            loginBtn.Location = new Point(309, 277);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(163, 46);
            loginBtn.TabIndex = 7;
            loginBtn.Text = "Giriş Yap";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += button1_Click;
            // 
            // login_show_password
            // 
            login_show_password.AutoSize = true;
            login_show_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            login_show_password.Location = new Point(561, 222);
            login_show_password.Name = "login_show_password";
            login_show_password.Size = new Size(151, 32);
            login_show_password.TabIndex = 8;
            login_show_password.Text = "Şifreyi Göster";
            login_show_password.UseVisualStyleBackColor = true;
            login_show_password.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // login_registerBtn
            // 
            login_registerBtn.BackColor = Color.SeaGreen;
            login_registerBtn.FlatStyle = FlatStyle.Flat;
            login_registerBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            login_registerBtn.ForeColor = Color.SeaShell;
            login_registerBtn.Location = new Point(528, 277);
            login_registerBtn.Name = "login_registerBtn";
            login_registerBtn.Size = new Size(163, 46);
            login_registerBtn.TabIndex = 9;
            login_registerBtn.Text = "Kayıt Ol";
            login_registerBtn.UseVisualStyleBackColor = false;
            login_registerBtn.Click += login_registerBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.AutoSize = true;
            closeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeBtn.Location = new Point(703, 7);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(19, 20);
            closeBtn.TabIndex = 10;
            closeBtn.Text = "X";
            closeBtn.Click += label5_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 464);
            Controls.Add(closeBtn);
            Controls.Add(login_registerBtn);
            Controls.Add(login_show_password);
            Controls.Add(loginBtn);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox login_username;
        private TextBox login_password;
        private ContextMenuStrip contextMenuStrip1;
        private Button loginBtn;
        private CheckBox login_show_password;
        private Button login_registerBtn;
        private Label closeBtn;
    }
}
