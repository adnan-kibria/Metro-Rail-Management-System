namespace MRT_Management_System
{
    partial class EnGP
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
            this.lblgp = new System.Windows.Forms.Label();
            this.btngp = new System.Windows.Forms.Button();
            this.textBoxgp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.lblgp);
            this.panel1.Controls.Add(this.btngp);
            this.panel1.Controls.Add(this.textBoxgp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(140, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 259);
            this.panel1.TabIndex = 2;
            // 
            // lblgp
            // 
            this.lblgp.AutoSize = true;
            this.lblgp.BackColor = System.Drawing.Color.White;
            this.lblgp.Location = new System.Drawing.Point(89, 123);
            this.lblgp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgp.Name = "lblgp";
            this.lblgp.Size = new System.Drawing.Size(112, 13);
            this.lblgp.TabIndex = 3;
            this.lblgp.Text = "Enter Tocken Number";
            // 
            // btngp
            // 
            this.btngp.BackColor = System.Drawing.Color.Red;
            this.btngp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btngp.Location = new System.Drawing.Point(29, 173);
            this.btngp.Margin = new System.Windows.Forms.Padding(2);
            this.btngp.Name = "btngp";
            this.btngp.Size = new System.Drawing.Size(297, 41);
            this.btngp.TabIndex = 2;
            this.btngp.Text = "Enter";
            this.btngp.UseVisualStyleBackColor = false;
            this.btngp.Click += new System.EventHandler(this.btngp_Click);
            // 
            // textBoxgp
            // 
            this.textBoxgp.Location = new System.Drawing.Point(29, 123);
            this.textBoxgp.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxgp.Name = "textBoxgp";
            this.textBoxgp.Size = new System.Drawing.Size(298, 20);
            this.textBoxgp.TabIndex = 1;
            this.textBoxgp.TextChanged += new System.EventHandler(this.textBoxgp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metro Rail Bangladesh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(652, 356);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 458);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EnGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EnGP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "entry_gate_pass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxgp;
        private System.Windows.Forms.Button btngp;
        private System.Windows.Forms.Label lblgp;
    }
}