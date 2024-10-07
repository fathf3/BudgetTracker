namespace BudgetTracker
{
    partial class ExpensesForm
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
            label6 = new Label();
            expenses_date = new DateTimePicker();
            expenses_deleteBtn = new Button();
            expenses_clearBtn = new Button();
            expenses_updateBtn = new Button();
            expenses_addBtn = new Button();
            expenses_description = new TextBox();
            label5 = new Label();
            expenses_expenses = new TextBox();
            label4 = new Label();
            expenses_item = new TextBox();
            label3 = new Label();
            expenses_category = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // expenses_date
            // 
            expenses_date.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            expenses_date.Location = new Point(579, 192);
            expenses_date.Name = "expenses_date";
            expenses_date.Size = new Size(256, 31);
            expenses_date.TabIndex = 13;
            // 
            // expenses_deleteBtn
            // 
            expenses_deleteBtn.BackColor = Color.SeaGreen;
            expenses_deleteBtn.FlatAppearance.BorderColor = Color.SeaGreen;
            expenses_deleteBtn.FlatAppearance.BorderSize = 0;
            expenses_deleteBtn.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            expenses_deleteBtn.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            expenses_deleteBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            expenses_deleteBtn.ForeColor = Color.White;
            expenses_deleteBtn.Location = new Point(718, 249);
            expenses_deleteBtn.Name = "expenses_deleteBtn";
            expenses_deleteBtn.Size = new Size(117, 52);
            expenses_deleteBtn.TabIndex = 12;
            expenses_deleteBtn.Text = "Sil";
            expenses_deleteBtn.UseVisualStyleBackColor = false;
            // 
            // expenses_clearBtn
            // 
            expenses_clearBtn.BackColor = Color.SeaGreen;
            expenses_clearBtn.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            expenses_clearBtn.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            expenses_clearBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            expenses_clearBtn.ForeColor = Color.White;
            expenses_clearBtn.Location = new Point(533, 249);
            expenses_clearBtn.Name = "expenses_clearBtn";
            expenses_clearBtn.Size = new Size(117, 52);
            expenses_clearBtn.TabIndex = 11;
            expenses_clearBtn.Text = "Temizle";
            expenses_clearBtn.UseVisualStyleBackColor = false;
            // 
            // expenses_updateBtn
            // 
            expenses_updateBtn.BackColor = Color.SeaGreen;
            expenses_updateBtn.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            expenses_updateBtn.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            expenses_updateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            expenses_updateBtn.ForeColor = Color.White;
            expenses_updateBtn.Location = new Point(336, 249);
            expenses_updateBtn.Name = "expenses_updateBtn";
            expenses_updateBtn.Size = new Size(117, 52);
            expenses_updateBtn.TabIndex = 10;
            expenses_updateBtn.Text = "Güncelle";
            expenses_updateBtn.UseVisualStyleBackColor = false;
            // 
            // expenses_addBtn
            // 
            expenses_addBtn.BackColor = Color.SeaGreen;
            expenses_addBtn.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            expenses_addBtn.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            expenses_addBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            expenses_addBtn.ForeColor = Color.White;
            expenses_addBtn.Location = new Point(133, 249);
            expenses_addBtn.Name = "expenses_addBtn";
            expenses_addBtn.Size = new Size(117, 52);
            expenses_addBtn.TabIndex = 9;
            expenses_addBtn.Text = "Ekle";
            expenses_addBtn.UseVisualStyleBackColor = false;
            expenses_addBtn.Click += expenses_addBtn_Click;
            // 
            // expenses_description
            // 
            expenses_description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            expenses_description.Location = new Point(579, 42);
            expenses_description.Multiline = true;
            expenses_description.Name = "expenses_description";
            expenses_description.Size = new Size(398, 138);
            expenses_description.TabIndex = 8;
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
            // expenses_expenses
            // 
            expenses_expenses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            expenses_expenses.Location = new Point(133, 149);
            expenses_expenses.Name = "expenses_expenses";
            expenses_expenses.Size = new Size(204, 34);
            expenses_expenses.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 149);
            label4.Name = "label4";
            label4.Size = new Size(97, 31);
            label4.TabIndex = 5;
            label4.Text = "Miktar : ";
            // 
            // expenses_item
            // 
            expenses_item.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            expenses_item.Location = new Point(133, 95);
            expenses_item.Name = "expenses_item";
            expenses_item.Size = new Size(204, 34);
            expenses_item.TabIndex = 4;
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
            // expenses_category
            // 
            expenses_category.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            expenses_category.FormattingEnabled = true;
            expenses_category.Location = new Point(133, 43);
            expenses_category.Name = "expenses_category";
            expenses_category.Size = new Size(204, 36);
            expenses_category.TabIndex = 2;
            
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(139, 31);
            label1.TabIndex = 1;
            label1.Text = "Gider Listesi";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(expenses_date);
            panel2.Controls.Add(expenses_deleteBtn);
            panel2.Controls.Add(expenses_clearBtn);
            panel2.Controls.Add(expenses_updateBtn);
            panel2.Controls.Add(expenses_addBtn);
            panel2.Controls.Add(expenses_description);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(expenses_expenses);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(expenses_item);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(expenses_category);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(25, 411);
            panel2.Name = "panel2";
            panel2.Size = new Size(1050, 320);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(25, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 386);
            panel1.TabIndex = 3;
            // 
            // ExpensesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ExpensesForm";
            Size = new Size(1100, 750);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private DateTimePicker expenses_date;
        private Button expenses_deleteBtn;
        private Button expenses_clearBtn;
        private Button expenses_updateBtn;
        private Button expenses_addBtn;
        private TextBox expenses_description;
        private Label label5;
        private TextBox expenses_expenses;
        private Label label4;
        private TextBox expenses_item;
        private Label label3;
        private ComboBox expenses_category;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel1;
    }
}
