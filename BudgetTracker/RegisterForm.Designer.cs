namespace BudgetTracker
{
    partial class RegisterForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            register_loginBtn = new Button();
            register_password = new TextBox();
            register_username = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            register_signUpBtn = new Button();
            register_show_password = new CheckBox();
            register_password_again = new TextBox();
            label5 = new Label();
            close_Btn = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(register_loginBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 464);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
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
            // register_loginBtn
            // 
            register_loginBtn.BackColor = Color.SeaGreen;
            register_loginBtn.FlatStyle = FlatStyle.Flat;
            register_loginBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_loginBtn.ForeColor = SystemColors.ButtonHighlight;
            register_loginBtn.Location = new Point(60, 383);
            register_loginBtn.Name = "register_loginBtn";
            register_loginBtn.Size = new Size(163, 46);
            register_loginBtn.TabIndex = 16;
            register_loginBtn.Text = "Giriş Sayfası";
            register_loginBtn.UseVisualStyleBackColor = false;
            register_loginBtn.Click += register_loginBtn_Click;
            // 
            // register_password
            // 
            register_password.Location = new Point(308, 181);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(403, 27);
            register_password.TabIndex = 15;
            // 
            // register_username
            // 
            register_username.Location = new Point(308, 99);
            register_username.Name = "register_username";
            register_username.Size = new Size(403, 27);
            register_username.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(308, 140);
            label4.Name = "label4";
            label4.Size = new Size(73, 38);
            label4.TabIndex = 13;
            label4.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(308, 58);
            label3.Name = "label3";
            label3.Size = new Size(169, 38);
            label3.TabIndex = 12;
            label3.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(913, 7);
            label1.Name = "label1";
            label1.Size = new Size(26, 26);
            label1.TabIndex = 11;
            label1.Text = "X";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // register_signUpBtn
            // 
            register_signUpBtn.BackColor = Color.SeaGreen;
            register_signUpBtn.FlatStyle = FlatStyle.Flat;
            register_signUpBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_signUpBtn.ForeColor = Color.SeaShell;
            register_signUpBtn.Location = new Point(308, 328);
            register_signUpBtn.Name = "register_signUpBtn";
            register_signUpBtn.Size = new Size(163, 46);
            register_signUpBtn.TabIndex = 18;
            register_signUpBtn.Text = "Kayıt Ol";
            register_signUpBtn.UseVisualStyleBackColor = false;
            register_signUpBtn.Click += register_signUpBtn_Click;
            // 
            // register_show_password
            // 
            register_show_password.AutoSize = true;
            register_show_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            register_show_password.Location = new Point(560, 285);
            register_show_password.Name = "register_show_password";
            register_show_password.Size = new Size(151, 32);
            register_show_password.TabIndex = 17;
            register_show_password.Text = "Şifreyi Göster";
            register_show_password.UseVisualStyleBackColor = true;
            register_show_password.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // register_password_again
            // 
            register_password_again.Location = new Point(308, 252);
            register_password_again.Name = "register_password_again";
            register_password_again.PasswordChar = '*';
            register_password_again.Size = new Size(403, 27);
            register_password_again.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(308, 211);
            label5.Name = "label5";
            label5.Size = new Size(163, 38);
            label5.TabIndex = 19;
            label5.Text = "Şifre Tekrarı";
            // 
            // close_Btn
            // 
            close_Btn.AutoSize = true;
            close_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            close_Btn.Location = new Point(706, 7);
            close_Btn.Name = "close_Btn";
            close_Btn.Size = new Size(19, 20);
            close_Btn.TabIndex = 21;
            close_Btn.Text = "X";
            close_Btn.Click += close_Btn_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 464);
            Controls.Add(close_Btn);
            Controls.Add(register_password_again);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(register_password);
            Controls.Add(register_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(register_signUpBtn);
            Controls.Add(register_show_password);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox register_password;
        private TextBox register_username;
        private Label label4;
        private Label label3;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private Button register_signUpBtn;
        private CheckBox register_show_password;
        private Button register_loginBtn;
        private TextBox register_password_again;
        private Label label5;
        private Label close_Btn;
    }
}