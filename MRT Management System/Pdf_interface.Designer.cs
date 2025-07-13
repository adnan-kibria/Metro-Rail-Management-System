namespace MRT_Management_System
{
    partial class Pdf_interface
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
            this.dGVPDF = new System.Windows.Forms.DataGridView();
            this.btnint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPDF)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVPDF
            // 
            this.dGVPDF.BackgroundColor = System.Drawing.Color.White;
            this.dGVPDF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPDF.Location = new System.Drawing.Point(0, 96);
            this.dGVPDF.Margin = new System.Windows.Forms.Padding(2);
            this.dGVPDF.Name = "dGVPDF";
            this.dGVPDF.RowHeadersWidth = 62;
            this.dGVPDF.RowTemplate.Height = 28;
            this.dGVPDF.Size = new System.Drawing.Size(656, 209);
            this.dGVPDF.TabIndex = 1;
            // 
            // btnint
            // 
            this.btnint.BackColor = System.Drawing.Color.Crimson;
            this.btnint.FlatAppearance.BorderSize = 0;
            this.btnint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnint.Location = new System.Drawing.Point(591, 309);
            this.btnint.Margin = new System.Windows.Forms.Padding(2);
            this.btnint.Name = "btnint";
            this.btnint.Size = new System.Drawing.Size(57, 18);
            this.btnint.TabIndex = 2;
            this.btnint.Text = "Print";
            this.btnint.UseVisualStyleBackColor = false;
            this.btnint.Click += new System.EventHandler(this.btnint_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 68);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metro Rail Bangladesh";
            // 
            // Pdf_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MRT_Management_System.Properties.Resources.output_onlinepngtools;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnint);
            this.Controls.Add(this.dGVPDF);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pdf_interface";
            this.Text = "Pdf_Imterface";
            this.Load += new System.EventHandler(this.Pdf_interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPDF)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dGVPDF;
    }
}

