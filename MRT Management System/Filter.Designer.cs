namespace MRT_Management_System
{
    partial class Filter
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.bFapply = new System.Windows.Forms.Button();
            this.bFX = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter";
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDay.ForeColor = System.Drawing.Color.White;
            this.rbDay.Location = new System.Drawing.Point(67, 74);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(51, 21);
            this.rbDay.TabIndex = 1;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "Day";
            this.rbDay.UseVisualStyleBackColor = true;
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMonth.ForeColor = System.Drawing.Color.White;
            this.rbMonth.Location = new System.Drawing.Point(67, 101);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(64, 21);
            this.rbMonth.TabIndex = 2;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "Month";
            this.rbMonth.UseVisualStyleBackColor = true;
            // 
            // rbYear
            // 
            this.rbYear.AutoSize = true;
            this.rbYear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYear.ForeColor = System.Drawing.Color.White;
            this.rbYear.Location = new System.Drawing.Point(67, 128);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(54, 21);
            this.rbYear.TabIndex = 3;
            this.rbYear.TabStop = true;
            this.rbYear.Text = "Year";
            this.rbYear.UseVisualStyleBackColor = true;
            // 
            // bFapply
            // 
            this.bFapply.BackColor = System.Drawing.Color.Crimson;
            this.bFapply.FlatAppearance.BorderSize = 0;
            this.bFapply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFapply.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFapply.ForeColor = System.Drawing.Color.White;
            this.bFapply.Location = new System.Drawing.Point(106, 167);
            this.bFapply.Name = "bFapply";
            this.bFapply.Size = new System.Drawing.Size(75, 26);
            this.bFapply.TabIndex = 4;
            this.bFapply.Text = "Apply";
            this.bFapply.UseVisualStyleBackColor = false;
            this.bFapply.Click += new System.EventHandler(this.button1_Click);
            // 
            // bFX
            // 
            this.bFX.BackColor = System.Drawing.Color.Crimson;
            this.bFX.FlatAppearance.BorderSize = 0;
            this.bFX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFX.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFX.Location = new System.Drawing.Point(171, 0);
            this.bFX.Name = "bFX";
            this.bFX.Size = new System.Drawing.Size(23, 23);
            this.bFX.TabIndex = 5;
            this.bFX.Text = "X";
            this.bFX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bFX.UseVisualStyleBackColor = false;
            this.bFX.Click += new System.EventHandler(this.button2_Click);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.Crimson;
            this.bClear.FlatAppearance.BorderSize = 0;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.ForeColor = System.Drawing.Color.White;
            this.bClear.Location = new System.Drawing.Point(12, 167);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 26);
            this.bClear.TabIndex = 6;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(193, 205);
            this.ControlBox = false;
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bFX);
            this.Controls.Add(this.bFapply);
            this.Controls.Add(this.rbYear);
            this.Controls.Add(this.rbMonth);
            this.Controls.Add(this.rbDay);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Filter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bFapply;
        private System.Windows.Forms.Button bFX;
        private System.Windows.Forms.Button bClear;
        public System.Windows.Forms.RadioButton rbDay;
        public System.Windows.Forms.RadioButton rbMonth;
        public System.Windows.Forms.RadioButton rbYear;
    }
}