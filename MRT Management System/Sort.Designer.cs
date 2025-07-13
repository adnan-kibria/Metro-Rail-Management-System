namespace MRT_Management_System
{
    partial class Sort
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
            this.rbSLH = new System.Windows.Forms.RadioButton();
            this.rbSHL = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bSapply = new System.Windows.Forms.Button();
            this.bSx = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbSLH
            // 
            this.rbSLH.AutoSize = true;
            this.rbSLH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSLH.ForeColor = System.Drawing.Color.White;
            this.rbSLH.Location = new System.Drawing.Point(30, 67);
            this.rbSLH.Name = "rbSLH";
            this.rbSLH.Size = new System.Drawing.Size(94, 21);
            this.rbSLH.TabIndex = 0;
            this.rbSLH.TabStop = true;
            this.rbSLH.Text = "Low - High";
            this.rbSLH.UseVisualStyleBackColor = true;
            // 
            // rbSHL
            // 
            this.rbSHL.AutoSize = true;
            this.rbSHL.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSHL.ForeColor = System.Drawing.Color.White;
            this.rbSHL.Location = new System.Drawing.Point(30, 94);
            this.rbSHL.Name = "rbSHL";
            this.rbSHL.Size = new System.Drawing.Size(94, 21);
            this.rbSHL.TabIndex = 2;
            this.rbSHL.TabStop = true;
            this.rbSHL.Text = "High - Low";
            this.rbSHL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sort";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bSapply
            // 
            this.bSapply.BackColor = System.Drawing.Color.Crimson;
            this.bSapply.FlatAppearance.BorderSize = 0;
            this.bSapply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSapply.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSapply.ForeColor = System.Drawing.Color.White;
            this.bSapply.Location = new System.Drawing.Point(86, 133);
            this.bSapply.Name = "bSapply";
            this.bSapply.Size = new System.Drawing.Size(57, 26);
            this.bSapply.TabIndex = 3;
            this.bSapply.Text = "Apply";
            this.bSapply.UseVisualStyleBackColor = false;
            this.bSapply.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSx
            // 
            this.bSx.BackColor = System.Drawing.Color.Crimson;
            this.bSx.FlatAppearance.BorderSize = 0;
            this.bSx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSx.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSx.Location = new System.Drawing.Point(132, 0);
            this.bSx.Name = "bSx";
            this.bSx.Size = new System.Drawing.Size(23, 23);
            this.bSx.TabIndex = 4;
            this.bSx.Text = "X";
            this.bSx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSx.UseVisualStyleBackColor = false;
            this.bSx.Click += new System.EventHandler(this.button2_Click);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.Crimson;
            this.bClear.FlatAppearance.BorderSize = 0;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.ForeColor = System.Drawing.Color.White;
            this.bClear.Location = new System.Drawing.Point(12, 133);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(57, 26);
            this.bClear.TabIndex = 5;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(155, 174);
            this.ControlBox = false;
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bSx);
            this.Controls.Add(this.bSapply);
            this.Controls.Add(this.rbSHL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbSLH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSapply;
        private System.Windows.Forms.Button bSx;
        public System.Windows.Forms.RadioButton rbSLH;
        public System.Windows.Forms.RadioButton rbSHL;
        private System.Windows.Forms.Button bClear;
    }
}