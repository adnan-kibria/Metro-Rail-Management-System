namespace MRT_Management_System
{
    partial class pw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pw));
            this.pnlwelcome = new System.Windows.Forms.Panel();
            this.lblbangladesh = new System.Windows.Forms.Label();
            this.lblwelcometometro = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnride = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlwelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlwelcome
            // 
            this.pnlwelcome.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlwelcome.Controls.Add(this.button1);
            this.pnlwelcome.Controls.Add(this.lblbangladesh);
            this.pnlwelcome.Controls.Add(this.lblwelcometometro);
            this.pnlwelcome.Controls.Add(this.btnexit);
            this.pnlwelcome.Controls.Add(this.btnride);
            this.pnlwelcome.Location = new System.Drawing.Point(172, 28);
            this.pnlwelcome.Margin = new System.Windows.Forms.Padding(2);
            this.pnlwelcome.Name = "pnlwelcome";
            this.pnlwelcome.Size = new System.Drawing.Size(385, 375);
            this.pnlwelcome.TabIndex = 0;
            this.pnlwelcome.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblbangladesh
            // 
            this.lblbangladesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbangladesh.ForeColor = System.Drawing.Color.White;
            this.lblbangladesh.Location = new System.Drawing.Point(7, 42);
            this.lblbangladesh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbangladesh.Name = "lblbangladesh";
            this.lblbangladesh.Size = new System.Drawing.Size(378, 54);
            this.lblbangladesh.TabIndex = 3;
            this.lblbangladesh.Text = "Bangladesh";
            this.lblbangladesh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblwelcometometro
            // 
            this.lblwelcometometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcometometro.ForeColor = System.Drawing.Color.White;
            this.lblwelcometometro.Location = new System.Drawing.Point(2, 3);
            this.lblwelcometometro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblwelcometometro.Name = "lblwelcometometro";
            this.lblwelcometometro.Size = new System.Drawing.Size(380, 51);
            this.lblwelcometometro.TabIndex = 2;
            this.lblwelcometometro.Text = "Welcome to - Matro Rail ";
            this.lblwelcometometro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblwelcometometro.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(104, 261);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(194, 48);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Want to Exit ?";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnride
            // 
            this.btnride.BackColor = System.Drawing.Color.Red;
            this.btnride.FlatAppearance.BorderSize = 0;
            this.btnride.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnride.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnride.ForeColor = System.Drawing.Color.White;
            this.btnride.Location = new System.Drawing.Point(104, 168);
            this.btnride.Margin = new System.Windows.Forms.Padding(2);
            this.btnride.Name = "btnride";
            this.btnride.Size = new System.Drawing.Size(194, 49);
            this.btnride.TabIndex = 0;
            this.btnride.Text = "Want to Ride ?";
            this.btnride.UseVisualStyleBackColor = false;
            this.btnride.Click += new System.EventHandler(this.btnride_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(155, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.pnlwelcome);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "pw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "passenger_welcome";
            this.Load += new System.EventHandler(this.passenger_welcome_Load);
            this.pnlwelcome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlwelcome;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnride;
        private System.Windows.Forms.Label lblwelcometometro;
        private System.Windows.Forms.Label lblbangladesh;
        private System.Windows.Forms.Button button1;
    }
}