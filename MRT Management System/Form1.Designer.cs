namespace MRT_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblbangladesh = new System.Windows.Forms.Label();
            this.lblwelcometometro = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnride = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblbangladesh
            // 
            this.lblbangladesh.Font = new System.Drawing.Font("Sans Serif Collection", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbangladesh.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblbangladesh.Location = new System.Drawing.Point(229, 91);
            this.lblbangladesh.Name = "lblbangladesh";
            this.lblbangladesh.Size = new System.Drawing.Size(507, 75);
            this.lblbangladesh.TabIndex = 3;
            this.lblbangladesh.Text = "Bangladesh";
            this.lblbangladesh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblwelcometometro
            // 
            this.lblwelcometometro.Font = new System.Drawing.Font("Sans Serif Collection", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcometometro.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblwelcometometro.Location = new System.Drawing.Point(229, 9);
            this.lblwelcometometro.Name = "lblwelcometometro";
            this.lblwelcometometro.Size = new System.Drawing.Size(507, 82);
            this.lblwelcometometro.TabIndex = 2;
            this.lblwelcometometro.Text = "Welcome to - Matro Rail ";
            this.lblwelcometometro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(544, 369);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(258, 65);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Want to Exit ?";
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // btnride
            // 
            this.btnride.BackColor = System.Drawing.Color.Red;
            this.btnride.FlatAppearance.BorderSize = 0;
            this.btnride.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnride.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnride.ForeColor = System.Drawing.Color.White;
            this.btnride.Location = new System.Drawing.Point(225, 369);
            this.btnride.Name = "btnride";
            this.btnride.Size = new System.Drawing.Size(258, 67);
            this.btnride.TabIndex = 0;
            this.btnride.Text = "Want to Ride ?";
            this.btnride.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 681);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lblbangladesh);
            this.Controls.Add(this.btnride);
            this.Controls.Add(this.lblwelcometometro);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblbangladesh;
        private System.Windows.Forms.Label lblwelcometometro;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnride;
    }
}

