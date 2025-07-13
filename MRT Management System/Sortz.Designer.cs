namespace MRT_Management_System
{
    partial class Sortz
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
            this.rbSzLH = new System.Windows.Forms.RadioButton();
            this.rbSzHL = new System.Windows.Forms.RadioButton();
            this.bSzapply = new System.Windows.Forms.Button();
            this.bSzX = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sort";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbSzLH
            // 
            this.rbSzLH.AutoSize = true;
            this.rbSzLH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSzLH.ForeColor = System.Drawing.Color.White;
            this.rbSzLH.Location = new System.Drawing.Point(31, 66);
            this.rbSzLH.Name = "rbSzLH";
            this.rbSzLH.Size = new System.Drawing.Size(94, 21);
            this.rbSzLH.TabIndex = 1;
            this.rbSzLH.Text = "Low - High";
            this.rbSzLH.UseVisualStyleBackColor = true;
            // 
            // rbSzHL
            // 
            this.rbSzHL.AutoSize = true;
            this.rbSzHL.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSzHL.ForeColor = System.Drawing.Color.White;
            this.rbSzHL.Location = new System.Drawing.Point(31, 93);
            this.rbSzHL.Name = "rbSzHL";
            this.rbSzHL.Size = new System.Drawing.Size(94, 21);
            this.rbSzHL.TabIndex = 2;
            this.rbSzHL.Text = "High - Low";
            this.rbSzHL.UseVisualStyleBackColor = true;
            // 
            // bSzapply
            // 
            this.bSzapply.BackColor = System.Drawing.Color.Crimson;
            this.bSzapply.FlatAppearance.BorderSize = 0;
            this.bSzapply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSzapply.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSzapply.ForeColor = System.Drawing.Color.White;
            this.bSzapply.Location = new System.Drawing.Point(86, 132);
            this.bSzapply.Name = "bSzapply";
            this.bSzapply.Size = new System.Drawing.Size(57, 26);
            this.bSzapply.TabIndex = 3;
            this.bSzapply.Text = "Apply";
            this.bSzapply.UseVisualStyleBackColor = false;
            this.bSzapply.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSzX
            // 
            this.bSzX.BackColor = System.Drawing.Color.Crimson;
            this.bSzX.FlatAppearance.BorderSize = 0;
            this.bSzX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSzX.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSzX.Location = new System.Drawing.Point(133, 0);
            this.bSzX.Name = "bSzX";
            this.bSzX.Size = new System.Drawing.Size(23, 23);
            this.bSzX.TabIndex = 4;
            this.bSzX.Text = "X";
            this.bSzX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSzX.UseVisualStyleBackColor = false;
            this.bSzX.Click += new System.EventHandler(this.button2_Click);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.Crimson;
            this.bClear.FlatAppearance.BorderSize = 0;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.ForeColor = System.Drawing.Color.White;
            this.bClear.Location = new System.Drawing.Point(12, 132);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(57, 26);
            this.bClear.TabIndex = 5;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // Sortz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(155, 174);
            this.ControlBox = false;
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bSzX);
            this.Controls.Add(this.bSzapply);
            this.Controls.Add(this.rbSzHL);
            this.Controls.Add(this.rbSzLH);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sortz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sortz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSzapply;
        private System.Windows.Forms.Button bSzX;
        public System.Windows.Forms.RadioButton rbSzLH;
        public System.Windows.Forms.RadioButton rbSzHL;
        private System.Windows.Forms.Button bClear;
    }
}