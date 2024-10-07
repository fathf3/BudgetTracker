namespace BudgetTracker
{
    partial class IncomeForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label6 = new Label();
            income_date = new DateTimePicker();
            income_deleteBtn = new Button();
            income_clearBtn = new Button();
            income_updateBtn = new Button();
            income_addBtn = new Button();
            income_description = new TextBox();
            label5 = new Label();
            income_income = new TextBox();
            label4 = new Label();
            income_item = new TextBox();
            label3 = new Label();
            income_category = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(28, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 386);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 1;
            label1.Text = "Gelir Listesi";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SeaGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(15, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1020, 325);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(income_date);
            panel2.Controls.Add(income_deleteBtn);
            panel2.Controls.Add(income_clearBtn);
            panel2.Controls.Add(income_updateBtn);
            panel2.Controls.Add(income_addBtn);
            panel2.Controls.Add(income_description);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(income_income);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(income_item);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(income_category);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(28, 407);
            panel2.Name = "panel2";
            panel2.Size = new Size(1050, 320);
            panel2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(500, 192);
            label6.Name = "label6";
            label6.Size = new Size(73, 31);
            label6.TabIndex = 14;
            label6.Text = "Tarih :";
            // 
            // income_date
            // 
            income_date.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            income_date.Location = new Point(579, 192);
            income_date.Name = "income_date";
            income_date.Size = new Size(256, 31);
            income_date.TabIndex = 13;
            // 
            // income_deleteBtn
            // 
            income_deleteBtn.BackColor = Color.SeaGreen;
            income_deleteBtn.FlatAppearance.BorderColor = Color.SeaGreen;
            income_deleteBtn.FlatAppearance.BorderSize = 0;
            income_deleteBtn.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            income_deleteBtn.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            income_deleteBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            income_deleteBtn.ForeColor = Color.White;
            income_deleteBtn.Location = new Point(718, 249);
            income_deleteBtn.Name = "income_deleteBtn";
            income_deleteBtn.Size = new Size(117, 52);
            income_deleteBtn.TabIndex = 12;
            income_deleteBtn.Text = "Sil";
            income_deleteBtn.UseVisualStyleBackColor = false;
            income_deleteBtn.Click += income_deleteBtn_Click;
            // 
            // income_clearBtn
            // 
            income_clearBtn.BackColor = Color.SeaGreen;
            income_clearBtn.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            income_clearBtn.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            income_clearBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            income_clearBtn.ForeColor = Color.White;
            income_clearBtn.Location = new Point(533, 249);
            income_clearBtn.Name = "income_clearBtn";
            income_clearBtn.Size = new Size(117, 52);
            income_clearBtn.TabIndex = 11;
            income_clearBtn.Text = "Temizle";
            income_clearBtn.UseVisualStyleBackColor = false;
            income_clearBtn.Click += income_clearBtn_Click;
            // 
            // income_updateBtn
            // 
            income_updateBtn.BackColor = Color.SeaGreen;
            income_updateBtn.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            income_updateBtn.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            income_updateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            income_updateBtn.ForeColor = Color.White;
            income_updateBtn.Location = new Point(336, 249);
            income_updateBtn.Name = "income_updateBtn";
            income_updateBtn.Size = new Size(117, 52);
            income_updateBtn.TabIndex = 10;
            income_updateBtn.Text = "Güncelle";
            income_updateBtn.UseVisualStyleBackColor = false;
            income_updateBtn.Click += income_updateBtn_Click;
            // 
            // income_addBtn
            // 
            income_addBtn.BackColor = Color.SeaGreen;
            income_addBtn.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            income_addBtn.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            income_addBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            income_addBtn.ForeColor = Color.White;
            income_addBtn.Location = new Point(133, 249);
            income_addBtn.Name = "income_addBtn";
            income_addBtn.Size = new Size(117, 52);
            income_addBtn.TabIndex = 9;
            income_addBtn.Text = "Ekle";
            income_addBtn.UseVisualStyleBackColor = false;
            income_addBtn.Click += income_addBtn_Click;
            // 
            // income_description
            // 
            income_description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            income_description.Location = new Point(579, 42);
            income_description.Multiline = true;
            income_description.Name = "income_description";
            income_description.Size = new Size(398, 138);
            income_description.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(449, 44);
            label5.Name = "label5";
            label5.Size = new Size(124, 31);
            label5.TabIndex = 7;
            label5.Text = "Açıklama : ";
            // 
            // income_income
            // 
            income_income.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            income_income.Location = new Point(133, 149);
            income_income.Name = "income_income";
            income_income.Size = new Size(204, 34);
            income_income.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 149);
            label4.Name = "label4";
            label4.Size = new Size(97, 31);
            label4.TabIndex = 5;
            label4.Text = "Miktar : ";
            // 
            // income_item
            // 
            income_item.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            income_item.Location = new Point(133, 95);
            income_item.Name = "income_item";
            income_item.Size = new Size(204, 34);
            income_item.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 95);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 3;
            label3.Text = "İşlem :";
            // 
            // income_category
            // 
            income_category.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            income_category.FormattingEnabled = true;
            income_category.Location = new Point(133, 43);
            income_category.Name = "income_category";
            income_category.Size = new Size(204, 36);
            income_category.TabIndex = 2;
            income_category.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 43);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 1;
            label2.Text = "Kategori : ";
            // 
            // IncomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IncomeForm";
            Size = new Size(1110, 750);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label2;
        private ComboBox income_category;
        private Button income_addBtn;
        private TextBox income_description;
        private Label label5;
        private TextBox income_income;
        private Label label4;
        private TextBox income_item;
        private Label label3;
        private Button income_deleteBtn;
        private Button income_clearBtn;
        private Button income_updateBtn;
        private Label label6;
        private DateTimePicker income_date;
    }
}
