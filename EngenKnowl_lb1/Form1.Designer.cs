
namespace EngenKnowl_lb1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.A1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A1,
            this.A2,
            this.A3,
            this.A4,
            this.A5,
            this.A6,
            this.A7,
            this.BB,
            this.BP});
            this.dataGridView1.Location = new System.Drawing.Point(27, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 242);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // A1
            // 
            this.A1.Frozen = true;
            this.A1.HeaderText = "A1";
            this.A1.Name = "A1";
            this.A1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.A1.Width = 50;
            // 
            // A2
            // 
            this.A2.Frozen = true;
            this.A2.HeaderText = "A2";
            this.A2.Name = "A2";
            this.A2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.A2.Width = 50;
            // 
            // A3
            // 
            this.A3.Frozen = true;
            this.A3.HeaderText = "A3";
            this.A3.Name = "A3";
            this.A3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.A3.Width = 50;
            // 
            // A4
            // 
            this.A4.Frozen = true;
            this.A4.HeaderText = "A4";
            this.A4.Name = "A4";
            this.A4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.A4.Width = 50;
            // 
            // A5
            // 
            this.A5.Frozen = true;
            this.A5.HeaderText = "A5";
            this.A5.Name = "A5";
            this.A5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.A5.Width = 50;
            // 
            // A6
            // 
            this.A6.HeaderText = "A6";
            this.A6.Name = "A6";
            this.A6.Width = 50;
            // 
            // A7
            // 
            this.A7.HeaderText = "A7";
            this.A7.Name = "A7";
            this.A7.Width = 50;
            // 
            // BB
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BB.DefaultCellStyle = dataGridViewCellStyle9;
            this.BB.HeaderText = "BB";
            this.BB.Name = "BB";
            this.BB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BP
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BP.DefaultCellStyle = dataGridViewCellStyle10;
            this.BP.HeaderText = "BP";
            this.BP.Name = "BP";
            this.BP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 151);
            this.button1.TabIndex = 1;
            this.button1.Text = "NEXT STEP (Items Examination)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(27, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 347);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "ready";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(669, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 60);
            this.button3.TabIndex = 6;
            this.button3.Text = "next table";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(669, 454);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 60);
            this.button4.TabIndex = 7;
            this.button4.Text = "get desigion";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 673);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn A1;
        private System.Windows.Forms.DataGridViewTextBoxColumn A2;
        private System.Windows.Forms.DataGridViewTextBoxColumn A3;
        private System.Windows.Forms.DataGridViewTextBoxColumn A4;
        private System.Windows.Forms.DataGridViewTextBoxColumn A5;
        private System.Windows.Forms.DataGridViewTextBoxColumn A6;
        private System.Windows.Forms.DataGridViewTextBoxColumn A7;
        private System.Windows.Forms.DataGridViewTextBoxColumn BB;
        private System.Windows.Forms.DataGridViewTextBoxColumn BP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

