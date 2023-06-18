namespace WinFormsApp4
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_add = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label_add_info = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButton_INT = new System.Windows.Forms.RadioButton();
            this.radioButton_STR = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_add_first = new System.Windows.Forms.TextBox();
            this.textBox_add_last = new System.Windows.Forms.TextBox();
            this.button_add_first = new System.Windows.Forms.Button();
            this.button_add_last = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_rand = new System.Windows.Forms.TextBox();
            this.button_get_rand = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_get_N = new System.Windows.Forms.Button();
            this.textBox_get_N = new System.Windows.Forms.TextBox();
            this.numericUpDown_get_N = new System.Windows.Forms.NumericUpDown();
            this.button_get_max = new System.Windows.Forms.Button();
            this.textBox_get_max = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_get_min = new System.Windows.Forms.Button();
            this.textBox_get_min = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_get_count = new System.Windows.Forms.Button();
            this.textBox_get_count = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_get_N)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(321, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список";
            // 
            // textBox_add
            // 
            this.textBox_add.Location = new System.Drawing.Point(12, 43);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new System.Drawing.Size(194, 27);
            this.textBox_add.TabIndex = 2;
            this.textBox_add.TextChanged += new System.EventHandler(this.textBox_add_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Добавить элемент ";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(14, 86);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(191, 34);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_add_info
            // 
            this.label_add_info.AutoSize = true;
            this.label_add_info.Location = new System.Drawing.Point(223, 46);
            this.label_add_info.Name = "label_add_info";
            this.label_add_info.Size = new System.Drawing.Size(0, 20);
            this.label_add_info.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(229, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 244);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioButton_INT
            // 
            this.radioButton_INT.AutoSize = true;
            this.radioButton_INT.Checked = true;
            this.radioButton_INT.Location = new System.Drawing.Point(23, 154);
            this.radioButton_INT.Name = "radioButton_INT";
            this.radioButton_INT.Size = new System.Drawing.Size(47, 24);
            this.radioButton_INT.TabIndex = 7;
            this.radioButton_INT.TabStop = true;
            this.radioButton_INT.Text = "Int";
            this.radioButton_INT.UseVisualStyleBackColor = true;
            this.radioButton_INT.CheckedChanged += new System.EventHandler(this.radioButton_INT_CheckedChanged);
            // 
            // radioButton_STR
            // 
            this.radioButton_STR.AutoSize = true;
            this.radioButton_STR.Location = new System.Drawing.Point(23, 184);
            this.radioButton_STR.Name = "radioButton_STR";
            this.radioButton_STR.Size = new System.Drawing.Size(69, 24);
            this.radioButton_STR.TabIndex = 8;
            this.radioButton_STR.Text = "String";
            this.radioButton_STR.UseVisualStyleBackColor = true;
            this.radioButton_STR.CheckedChanged += new System.EventHandler(this.radioButton_INT_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Добавить элемент в начало:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Добавить элемент в конец:";
            // 
            // textBox_add_first
            // 
            this.textBox_add_first.Location = new System.Drawing.Point(223, 351);
            this.textBox_add_first.Name = "textBox_add_first";
            this.textBox_add_first.Size = new System.Drawing.Size(159, 27);
            this.textBox_add_first.TabIndex = 11;
            // 
            // textBox_add_last
            // 
            this.textBox_add_last.Location = new System.Drawing.Point(223, 394);
            this.textBox_add_last.Name = "textBox_add_last";
            this.textBox_add_last.Size = new System.Drawing.Size(159, 27);
            this.textBox_add_last.TabIndex = 12;
            // 
            // button_add_first
            // 
            this.button_add_first.Location = new System.Drawing.Point(388, 351);
            this.button_add_first.Name = "button_add_first";
            this.button_add_first.Size = new System.Drawing.Size(101, 29);
            this.button_add_first.TabIndex = 13;
            this.button_add_first.Text = "Добавить";
            this.button_add_first.UseVisualStyleBackColor = true;
            this.button_add_first.Click += new System.EventHandler(this.button_add_first_Click);
            // 
            // button_add_last
            // 
            this.button_add_last.Location = new System.Drawing.Point(388, 397);
            this.button_add_last.Name = "button_add_last";
            this.button_add_last.Size = new System.Drawing.Size(101, 29);
            this.button_add_last.TabIndex = 14;
            this.button_add_last.Text = "Добавить";
            this.button_add_last.UseVisualStyleBackColor = true;
            this.button_add_last.Click += new System.EventHandler(this.button_add_last_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(516, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Рандомный элемент:";
            // 
            // textBox_rand
            // 
            this.textBox_rand.Location = new System.Drawing.Point(517, 44);
            this.textBox_rand.Name = "textBox_rand";
            this.textBox_rand.Size = new System.Drawing.Size(271, 27);
            this.textBox_rand.TabIndex = 16;
            // 
            // button_get_rand
            // 
            this.button_get_rand.Location = new System.Drawing.Point(675, 11);
            this.button_get_rand.Name = "button_get_rand";
            this.button_get_rand.Size = new System.Drawing.Size(113, 31);
            this.button_get_rand.TabIndex = 17;
            this.button_get_rand.Text = "Получить";
            this.button_get_rand.UseVisualStyleBackColor = true;
            this.button_get_rand.Click += new System.EventHandler(this.button_get_rand_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(519, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "N-ый элемент:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "N =";
            // 
            // button_get_N
            // 
            this.button_get_N.Location = new System.Drawing.Point(675, 113);
            this.button_get_N.Name = "button_get_N";
            this.button_get_N.Size = new System.Drawing.Size(113, 31);
            this.button_get_N.TabIndex = 21;
            this.button_get_N.Text = "Получить";
            this.button_get_N.UseVisualStyleBackColor = true;
            this.button_get_N.Click += new System.EventHandler(this.button_get_N_Click);
            // 
            // textBox_get_N
            // 
            this.textBox_get_N.Location = new System.Drawing.Point(517, 151);
            this.textBox_get_N.Name = "textBox_get_N";
            this.textBox_get_N.Size = new System.Drawing.Size(271, 27);
            this.textBox_get_N.TabIndex = 22;
            // 
            // numericUpDown_get_N
            // 
            this.numericUpDown_get_N.Location = new System.Drawing.Point(560, 116);
            this.numericUpDown_get_N.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_get_N.Name = "numericUpDown_get_N";
            this.numericUpDown_get_N.Size = new System.Drawing.Size(39, 27);
            this.numericUpDown_get_N.TabIndex = 23;
            this.numericUpDown_get_N.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_get_max
            // 
            this.button_get_max.Location = new System.Drawing.Point(674, 191);
            this.button_get_max.Name = "button_get_max";
            this.button_get_max.Size = new System.Drawing.Size(113, 31);
            this.button_get_max.TabIndex = 26;
            this.button_get_max.Text = "Получить";
            this.button_get_max.UseVisualStyleBackColor = true;
            this.button_get_max.Click += new System.EventHandler(this.button_get_max_Click);
            // 
            // textBox_get_max
            // 
            this.textBox_get_max.Location = new System.Drawing.Point(516, 224);
            this.textBox_get_max.Name = "textBox_get_max";
            this.textBox_get_max.Size = new System.Drawing.Size(271, 27);
            this.textBox_get_max.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(515, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Макс. элемент:";
            // 
            // button_get_min
            // 
            this.button_get_min.Location = new System.Drawing.Point(673, 261);
            this.button_get_min.Name = "button_get_min";
            this.button_get_min.Size = new System.Drawing.Size(113, 31);
            this.button_get_min.TabIndex = 29;
            this.button_get_min.Text = "Получить";
            this.button_get_min.UseVisualStyleBackColor = true;
            this.button_get_min.Click += new System.EventHandler(this.button_get_min_Click);
            // 
            // textBox_get_min
            // 
            this.textBox_get_min.Location = new System.Drawing.Point(515, 294);
            this.textBox_get_min.Name = "textBox_get_min";
            this.textBox_get_min.Size = new System.Drawing.Size(271, 27);
            this.textBox_get_min.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(514, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Мин. элемент:";
            // 
            // button_get_count
            // 
            this.button_get_count.Location = new System.Drawing.Point(675, 327);
            this.button_get_count.Name = "button_get_count";
            this.button_get_count.Size = new System.Drawing.Size(113, 31);
            this.button_get_count.TabIndex = 32;
            this.button_get_count.Text = "Получить";
            this.button_get_count.UseVisualStyleBackColor = true;
            this.button_get_count.Click += new System.EventHandler(this.button_get_count_Click);
            // 
            // textBox_get_count
            // 
            this.textBox_get_count.Location = new System.Drawing.Point(517, 360);
            this.textBox_get_count.Name = "textBox_get_count";
            this.textBox_get_count.Size = new System.Drawing.Size(271, 27);
            this.textBox_get_count.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(516, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Общее кол-во:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_get_count);
            this.Controls.Add(this.textBox_get_count);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_get_min);
            this.Controls.Add(this.textBox_get_min);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_get_max);
            this.Controls.Add(this.textBox_get_max);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_get_N);
            this.Controls.Add(this.textBox_get_N);
            this.Controls.Add(this.button_get_N);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_get_rand);
            this.Controls.Add(this.textBox_rand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_add_last);
            this.Controls.Add(this.button_add_first);
            this.Controls.Add(this.textBox_add_last);
            this.Controls.Add(this.textBox_add_first);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton_STR);
            this.Controls.Add(this.radioButton_INT);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label_add_info);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_add);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "lab4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_get_N)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox textBox_add;
        private Label label2;
        private Button button_add;
        private Label label_add_info;
        private ListBox listBox1;
        private RadioButton radioButton_INT;
        private RadioButton radioButton_STR;
        private Label label4;
        private Label label3;
        private TextBox textBox_add_first;
        private TextBox textBox_add_last;
        private Button button_add_first;
        private Button button_add_last;
        private Label label5;
        private TextBox textBox_rand;
        private Button button_get_rand;
        private Label label6;
        private Label label7;
        private Button button_get_N;
        private TextBox textBox_get_N;
        private NumericUpDown numericUpDown_get_N;
        private Button button_get_max;
        private TextBox textBox_get_max;
        private Label label8;
        private Button button_get_min;
        private TextBox textBox_get_min;
        private Label label9;
        private Button button_get_count;
        private TextBox textBox_get_count;
        private Label label10;
    }
}