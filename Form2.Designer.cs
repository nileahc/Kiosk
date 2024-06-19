namespace WF127
{
    partial class Form2
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
            monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            tbStart = new System.Windows.Forms.Label();
            tbEnd = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            monthCalendar1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            monthCalendar1.Location = new System.Drawing.Point(19, 63);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // tbStart
            // 
            tbStart.AutoSize = true;
            tbStart.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            tbStart.Location = new System.Drawing.Point(64, 396);
            tbStart.Name = "tbStart";
            tbStart.Size = new System.Drawing.Size(12, 15);
            tbStart.TabIndex = 1;
            tbStart.Text = "-";
            // 
            // tbEnd
            // 
            tbEnd.AutoSize = true;
            tbEnd.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            tbEnd.Location = new System.Drawing.Point(83, 422);
            tbEnd.Name = "tbEnd";
            tbEnd.Size = new System.Drawing.Size(12, 15);
            tbEnd.TabIndex = 1;
            tbEnd.Text = "-";
            // 
            // numericUpDown1
            // 
            numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            numericUpDown1.Location = new System.Drawing.Point(56, 522);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(99, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Olive;
            label1.Location = new System.Drawing.Point(19, 483);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 21);
            label1.TabIndex = 3;
            label1.Text = "인원 선택";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            label2.Location = new System.Drawing.Point(19, 524);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "성인";
            // 
            // numericUpDown2
            // 
            numericUpDown2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            numericUpDown2.Location = new System.Drawing.Point(56, 557);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(99, 23);
            numericUpDown2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            label3.Location = new System.Drawing.Point(20, 559);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "아동";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Olive;
            label4.Location = new System.Drawing.Point(19, 33);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 21);
            label4.TabIndex = 3;
            label4.Text = "날짜 선택";
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            button1.Location = new System.Drawing.Point(207, 597);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "선택 완료";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            label5.Location = new System.Drawing.Point(19, 396);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(46, 15);
            label5.TabIndex = 5;
            label5.Text = "체크인:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            label6.Location = new System.Drawing.Point(19, 422);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(58, 15);
            label6.TabIndex = 5;
            label6.Text = "체크아웃:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            label7.Location = new System.Drawing.Point(105, 489);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(143, 15);
            label7.TabIndex = 6;
            label7.Text = "최대 4인까지 가능합니다.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            label8.Location = new System.Drawing.Point(19, 437);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(32, 15);
            label8.TabIndex = 7;
            label8.Text = "(-박)";
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Window;
            ClientSize = new System.Drawing.Size(484, 632);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDown2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(tbEnd);
            Controls.Add(tbStart);
            Controls.Add(monthCalendar1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label tbStart;
        private System.Windows.Forms.Label tbEnd;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}