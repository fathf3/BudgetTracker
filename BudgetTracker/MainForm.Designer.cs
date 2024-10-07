namespace BudgetTracker
{
    partial class MainForm
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
            panel1 = new Panel();
            label1 = new Label();
            closeBtn = new Label();
            panel2 = new Panel();
            dashboard_username = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            category_btn = new Button();
            income_btn = new Button();
            expense_btn = new Button();
            dashboard_btn = new Button();
            panel3 = new Panel();
            dashboardForm1 = new DashboardForm();
            expensesForm1 = new ExpensesForm();
            ıncomeForm1 = new IncomeForm();
            categoryForm1 = new CategoryForm();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(closeBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 53);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(229, 31);
            label1.TabIndex = 12;
            label1.Text = "Bütçe Takip Programı";
            // 
            // closeBtn
            // 
            closeBtn.AutoSize = true;
            closeBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            closeBtn.Location = new Point(1333, 11);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(35, 38);
            closeBtn.TabIndex = 11;
            closeBtn.Text = "X";
            closeBtn.Click += closeBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Controls.Add(dashboard_username);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(category_btn);
            panel2.Controls.Add(income_btn);
            panel2.Controls.Add(expense_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 750);
            panel2.TabIndex = 1;
            // 
            // dashboard_username
            // 
            dashboard_username.AutoSize = true;
            dashboard_username.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dashboard_username.ForeColor = Color.Snow;
            dashboard_username.Location = new Point(122, 214);
            dashboard_username.Name = "dashboard_username";
            dashboard_username.Size = new Size(0, 25);
            dashboard_username.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(16, 214);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 5;
            label2.Text = "Hoşgeldin, ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.budget;
            pictureBox1.Location = new Point(67, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 162);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // category_btn
            // 
            category_btn.BackColor = Color.SeaGreen;
            category_btn.FlatAppearance.BorderSize = 0;
            category_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            category_btn.ForeColor = SystemColors.ButtonHighlight;
            category_btn.Image = Properties.Resources.options;
            category_btn.ImageAlign = ContentAlignment.MiddleLeft;
            category_btn.Location = new Point(12, 352);
            category_btn.Name = "category_btn";
            category_btn.Padding = new Padding(5, 0, 0, 0);
            category_btn.Size = new Size(244, 54);
            category_btn.TabIndex = 3;
            category_btn.Text = "Kategoriler";
            category_btn.UseVisualStyleBackColor = false;
            category_btn.Click += category_btn_Click;
            // 
            // income_btn
            // 
            income_btn.BackColor = Color.SeaGreen;
            income_btn.FlatAppearance.BorderSize = 0;
            income_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            income_btn.ForeColor = SystemColors.ButtonHighlight;
            income_btn.Image = Properties.Resources.profits;
            income_btn.ImageAlign = ContentAlignment.MiddleLeft;
            income_btn.Location = new Point(12, 412);
            income_btn.Name = "income_btn";
            income_btn.Padding = new Padding(5, 0, 0, 0);
            income_btn.Size = new Size(244, 54);
            income_btn.TabIndex = 2;
            income_btn.Text = "Gelir";
            income_btn.UseVisualStyleBackColor = false;
            income_btn.Click += income_btn_Click;
            // 
            // expense_btn
            // 
            expense_btn.BackColor = Color.SeaGreen;
            expense_btn.FlatAppearance.BorderSize = 0;
            expense_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            expense_btn.ForeColor = SystemColors.ButtonHighlight;
            expense_btn.Image = Properties.Resources.expense__1_;
            expense_btn.ImageAlign = ContentAlignment.MiddleLeft;
            expense_btn.Location = new Point(12, 472);
            expense_btn.Name = "expense_btn";
            expense_btn.Padding = new Padding(5, 0, 0, 0);
            expense_btn.Size = new Size(244, 54);
            expense_btn.TabIndex = 1;
            expense_btn.Text = "Gider";
            expense_btn.UseVisualStyleBackColor = false;
            expense_btn.Click += expense_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.SeaGreen;
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dashboard_btn.ForeColor = SystemColors.ButtonHighlight;
            dashboard_btn.Image = Properties.Resources.dashboard;
            dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard_btn.Location = new Point(12, 292);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Padding = new Padding(5, 0, 0, 0);
            dashboard_btn.Size = new Size(244, 54);
            dashboard_btn.TabIndex = 0;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboardForm1);
            panel3.Controls.Add(expensesForm1);
            panel3.Controls.Add(ıncomeForm1);
            panel3.Controls.Add(categoryForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(273, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(1109, 750);
            panel3.TabIndex = 2;
            // 
            // dashboardForm1
            // 
            dashboardForm1.Location = new Point(0, 0);
            dashboardForm1.Name = "dashboardForm1";
            dashboardForm1.Size = new Size(1388, 938);
            dashboardForm1.TabIndex = 3;
            // 
            // expensesForm1
            // 
            expensesForm1.Location = new Point(0, -1);
            expensesForm1.Name = "expensesForm1";
            expensesForm1.Size = new Size(1375, 938);
            expensesForm1.TabIndex = 2;
            // 
            // ıncomeForm1
            // 
            ıncomeForm1.Location = new Point(0, 0);
            ıncomeForm1.Name = "ıncomeForm1";
            ıncomeForm1.Size = new Size(1388, 938);
            ıncomeForm1.TabIndex = 1;
            // 
            // categoryForm1
            // 
            categoryForm1.Location = new Point(6, -1);
            categoryForm1.Name = "categoryForm1";
            categoryForm1.Size = new Size(1388, 938);
            categoryForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 803);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label closeBtn;
        private Label label1;
        private Panel panel2;
        private Button dashboard_btn;
        private Button category_btn;
        private Button income_btn;
        private Button expense_btn;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel3;
        private CategoryForm categoryForm1;
        private IncomeForm ıncomeForm1;
        private ExpensesForm expensesForm1;
        private DashboardForm dashboardForm1;
        private Label dashboard_username;
    }
}