namespace MRT_Management_System
{
    partial class DiffPassenger
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblw = new System.Windows.Forms.Label();
            this.txtPhn = new System.Windows.Forms.TextBox();
            this.bVP = new System.Windows.Forms.Button();
            this.bRP = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.lblw);
            this.panel1.Controls.Add(this.txtPhn);
            this.panel1.Controls.Add(this.bVP);
            this.panel1.Controls.Add(this.bRP);
            this.panel1.Location = new System.Drawing.Point(321, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 252);
            this.panel1.TabIndex = 0;
            // 
            // lblw
            // 
            this.lblw.AutoSize = true;
            this.lblw.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblw.ForeColor = System.Drawing.Color.White;
            this.lblw.Location = new System.Drawing.Point(89, 31);
            this.lblw.Name = "lblw";
            this.lblw.Size = new System.Drawing.Size(155, 15);
            this.lblw.TabIndex = 3;
            this.lblw.Text = "Please enter phone number";
            // 
            // txtPhn
            // 
            this.txtPhn.ForeColor = System.Drawing.Color.Black;
            this.txtPhn.Location = new System.Drawing.Point(86, 53);
            this.txtPhn.Name = "txtPhn";
            this.txtPhn.Size = new System.Drawing.Size(177, 20);
            this.txtPhn.TabIndex = 2;
            this.txtPhn.TextChanged += new System.EventHandler(this.txtPhn_TextChanged);
            // 
            // bVP
            // 
            this.bVP.BackColor = System.Drawing.Color.Crimson;
            this.bVP.FlatAppearance.BorderSize = 0;
            this.bVP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVP.ForeColor = System.Drawing.Color.White;
            this.bVP.Location = new System.Drawing.Point(86, 148);
            this.bVP.Name = "bVP";
            this.bVP.Size = new System.Drawing.Size(177, 34);
            this.bVP.TabIndex = 1;
            this.bVP.Text = "VIP Passenger";
            this.bVP.UseVisualStyleBackColor = false;
            this.bVP.Click += new System.EventHandler(this.bVP_Click);
            // 
            // bRP
            // 
            this.bRP.BackColor = System.Drawing.Color.Crimson;
            this.bRP.FlatAppearance.BorderSize = 0;
            this.bRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRP.ForeColor = System.Drawing.Color.White;
            this.bRP.Location = new System.Drawing.Point(86, 97);
            this.bRP.Name = "bRP";
            this.bRP.Size = new System.Drawing.Size(177, 34);
            this.bRP.TabIndex = 0;
            this.bRP.Text = "Regular Passenger";
            this.bRP.UseVisualStyleBackColor = false;
            this.bRP.Click += new System.EventHandler(this.bRP_Click);
            // 
            // DiffPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MRT_Management_System.Properties.Resources.output_onlinepngtools;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "DiffPassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiffPassenger";
            this.Load += new System.EventHandler(this.DiffPassenger_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bVP;
        private System.Windows.Forms.Button bRP;
        private System.Windows.Forms.TextBox txtPhn;
        private System.Windows.Forms.Label lblw;
    }
}