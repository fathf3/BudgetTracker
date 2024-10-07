namespace BudgetTracker
{
    partial class CategoryForm
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
            panel1 = new Panel();
            category_deleteBtn = new Button();
            category_clearBtn = new Button();
            category_addBtn = new Button();
            category_updateBtn = new Button();
            category_status = new ComboBox();
            label3 = new Label();
            category_type = new ComboBox();
            label2 = new Label();
            category_category = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(category_deleteBtn);
            panel1.Controls.Add(category_clearBtn);
            panel1.Controls.Add(category_addBtn);
            panel1.Controls.Add(category_updateBtn);
            panel1.Controls.Add(category_status);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(category_type);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(category_category);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 710);
            panel1.TabIndex = 0;
            // 
            // category_deleteBtn
            // 
            category_deleteBtn.BackColor = Color.SeaGreen;
            category_deleteBtn.FlatAppearance.BorderSize = 0;
            category_deleteBtn.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            category_deleteBtn.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            category_deleteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            category_deleteBtn.ForeColor = Color.White;
            category_deleteBtn.Location = new Point(172, 388);
            category_deleteBtn.Name = "category_deleteBtn";
            category_deleteBtn.Size = new Size(122, 47);
            category_deleteBtn.TabIndex = 10;
            category_deleteBtn.Text = "Sil";
            category_deleteBtn.UseVisualStyleBackColor = false;
            category_deleteBtn.Click += category_deleteBtn_Click;
            // 
            // category_clearBtn
            // 
            category_clearBtn.BackColor = Color.SeaGreen;
            category_clearBtn.FlatAppearance.BorderSize = 0;
            category_clearBtn.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            category_clearBtn.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            category_clearBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            category_clearBtn.ForeColor = Color.White;
            category_clearBtn.Location = new Point(30, 388);
            category_clearBtn.Name = "category_clearBtn";
            category_clearBtn.Size = new Size(122, 47);
            category_clearBtn.TabIndex = 9;
            category_clearBtn.Text = "Temizle";
            category_clearBtn.UseVisualStyleBackColor = false;
            category_clearBtn.Click += category_clearBtn_Click;
            // 
            // category_addBtn
            // 
            category_addBtn.BackColor = Color.SeaGreen;
            category_addBtn.FlatAppearance.BorderSize = 0;
            category_addBtn.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            category_addBtn.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            category_addBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            category_addBtn.ForeColor = Color.White;
            category_addBtn.Location = new Point(30, 316);
            category_addBtn.Name = "category_addBtn";
            category_addBtn.Size = new Size(122, 47);
            category_addBtn.TabIndex = 8;
            category_addBtn.Text = "Ekle";
            category_addBtn.UseVisualStyleBackColor = false;
            category_addBtn.Click += category_addBtn_Click;
            // 
            // category_updateBtn
            // 
            category_updateBtn.BackColor = Color.SeaGreen;
            category_updateBtn.FlatAppearance.BorderSize = 0;
            category_updateBtn.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            category_updateBtn.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            category_updateBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            category_updateBtn.ForeColor = Color.White;
            category_updateBtn.Location = new Point(172, 316);
            category_updateBtn.Name = "category_updateBtn";
            category_updateBtn.Size = new Size(122, 47);
            category_updateBtn.TabIndex = 7;
            category_updateBtn.Text = "Güncelle";
            category_updateBtn.UseVisualStyleBackColor = false;
            category_updateBtn.Click += category_updateBtn_Click;
            // 
            // category_status
            // 
            category_status.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            category_status.FormattingEnabled = true;
            category_status.Items.AddRange(new object[] { "Aktif", "Pasif" });
            category_status.Location = new Point(30, 258);
            category_status.Name = "category_status";
            category_status.Size = new Size(275, 39);
            category_status.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 213);
            label3.Name = "label3";
            label3.Size = new Size(84, 31);
            label3.TabIndex = 4;
            label3.Text = "Durum";
            // 
            // category_type
            // 
            category_type.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            category_type.FormattingEnabled = true;
            category_type.Items.AddRange(new object[] { "Gelir", "Gider" });
            category_type.Location = new Point(30, 158);
            category_type.Name = "category_type";
            category_type.Size = new Size(275, 39);
            category_type.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 113);
            label2.Name = "label2";
            label2.Size = new Size(52, 31);
            label2.TabIndex = 2;
            label2.Text = "Tipi";
            // 
            // category_category
            // 
            category_category.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            category_category.Location = new Point(30, 68);
            category_category.Name = "category_category";
            category_category.Size = new Size(275, 38);
            category_category.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(100, 31);
            label1.TabIndex = 0;
            label1.Text = "Kategori";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(358, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(733, 710);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 37);
            label4.Name = "label4";
            label4.Size = new Size(169, 31);
            label4.TabIndex = 11;
            label4.Text = "Kategori Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(17, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(702, 582);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CategoryForm";
            Size = new Size(1110, 750);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComboBox category_status;
        private Label label3;
        private ComboBox category_type;
        private Label label2;
        private TextBox category_category;
        private Label label1;
        private Button category_deleteBtn;
        private Button category_clearBtn;
        private Button category_addBtn;
        private Button category_updateBtn;
        private Label label4;
        private DataGridView dataGridView1;
    }
}
