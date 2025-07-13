namespace MRT_Management_System
{
    partial class Passenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passenger));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSP = new System.Windows.Forms.Button();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.lblPtitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bPVip = new System.Windows.Forms.Button();
            this.bPPp = new System.Windows.Forms.Button();
            this.dGVP = new System.Windows.Forms.DataGridView();
            this.bPPrint = new System.Windows.Forms.Button();
            this.bPBack = new System.Windows.Forms.Button();
            this.bPout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.bSP);
            this.panel1.Controls.Add(this.txtSP);
            this.panel1.Controls.Add(this.lblPtitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 105);
            this.panel1.TabIndex = 0;
            // 
            // bSP
            // 
            this.bSP.BackColor = System.Drawing.Color.White;
            this.bSP.FlatAppearance.BorderSize = 0;
            this.bSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSP.ForeColor = System.Drawing.Color.SeaGreen;
            this.bSP.Location = new System.Drawing.Point(554, 59);
            this.bSP.Name = "bSP";
            this.bSP.Size = new System.Drawing.Size(79, 29);
            this.bSP.TabIndex = 2;
            this.bSP.Text = "Search";
            this.bSP.UseVisualStyleBackColor = false;
            // 
            // txtSP
            // 
            this.txtSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSP.Location = new System.Drawing.Point(304, 59);
            this.txtSP.Multiline = true;
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(244, 29);
            this.txtSP.TabIndex = 1;
            this.txtSP.TextChanged += new System.EventHandler(this.txtSP_TextChanged);
            this.txtSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSP_KeyPress);
            this.txtSP.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtSP_PreviewKeyDown);
            // 
            // lblPtitle
            // 
            this.lblPtitle.AutoSize = true;
            this.lblPtitle.BackColor = System.Drawing.Color.SeaGreen;
            this.lblPtitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtitle.ForeColor = System.Drawing.Color.White;
            this.lblPtitle.Location = new System.Drawing.Point(298, 9);
            this.lblPtitle.Name = "lblPtitle";
            this.lblPtitle.Size = new System.Drawing.Size(332, 36);
            this.lblPtitle.TabIndex = 0;
            this.lblPtitle.Text = "Metro Rail Bangladesh";
            this.lblPtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPtitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Passenger Records";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bPVip
            // 
            this.bPVip.BackColor = System.Drawing.Color.SeaGreen;
            this.bPVip.FlatAppearance.BorderSize = 0;
            this.bPVip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPVip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPVip.ForeColor = System.Drawing.Color.White;
            this.bPVip.Location = new System.Drawing.Point(181, 111);
            this.bPVip.Name = "bPVip";
            this.bPVip.Size = new System.Drawing.Size(163, 30);
            this.bPVip.TabIndex = 2;
            this.bPVip.Text = "VIP Passenger";
            this.bPVip.UseVisualStyleBackColor = false;
            this.bPVip.Click += new System.EventHandler(this.bPVip_Click);
            // 
            // bPPp
            // 
            this.bPPp.BackColor = System.Drawing.Color.SeaGreen;
            this.bPPp.FlatAppearance.BorderSize = 0;
            this.bPPp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPPp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPPp.ForeColor = System.Drawing.Color.White;
            this.bPPp.Location = new System.Drawing.Point(350, 111);
            this.bPPp.Name = "bPPp";
            this.bPPp.Size = new System.Drawing.Size(163, 30);
            this.bPPp.TabIndex = 3;
            this.bPPp.Text = "Probation Passenger";
            this.bPPp.UseVisualStyleBackColor = false;
            this.bPPp.Click += new System.EventHandler(this.bPPp_Click);
            // 
            // dGVP
            // 
            this.dGVP.BackgroundColor = System.Drawing.Color.White;
            this.dGVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVP.Location = new System.Drawing.Point(0, 147);
            this.dGVP.Name = "dGVP";
            this.dGVP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGVP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVP.Size = new System.Drawing.Size(984, 322);
            this.dGVP.TabIndex = 5;
            // 
            // bPPrint
            // 
            this.bPPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.bPPrint.FlatAppearance.BorderSize = 0;
            this.bPPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPPrint.ForeColor = System.Drawing.Color.White;
            this.bPPrint.Location = new System.Drawing.Point(887, 475);
            this.bPPrint.Name = "bPPrint";
            this.bPPrint.Size = new System.Drawing.Size(85, 28);
            this.bPPrint.TabIndex = 7;
            this.bPPrint.Text = "Print";
            this.bPPrint.UseVisualStyleBackColor = false;
            this.bPPrint.Click += new System.EventHandler(this.bPPrint_Click);
            // 
            // bPBack
            // 
            this.bPBack.BackColor = System.Drawing.Color.Crimson;
            this.bPBack.FlatAppearance.BorderSize = 0;
            this.bPBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPBack.ForeColor = System.Drawing.Color.White;
            this.bPBack.Location = new System.Drawing.Point(12, 521);
            this.bPBack.Name = "bPBack";
            this.bPBack.Size = new System.Drawing.Size(85, 28);
            this.bPBack.TabIndex = 8;
            this.bPBack.Text = "Back";
            this.bPBack.UseVisualStyleBackColor = false;
            this.bPBack.Click += new System.EventHandler(this.bPBack_Click);
            // 
            // bPout
            // 
            this.bPout.BackColor = System.Drawing.Color.Crimson;
            this.bPout.FlatAppearance.BorderSize = 0;
            this.bPout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPout.ForeColor = System.Drawing.Color.White;
            this.bPout.Location = new System.Drawing.Point(887, 521);
            this.bPout.Name = "bPout";
            this.bPout.Size = new System.Drawing.Size(85, 28);
            this.bPout.TabIndex = 9;
            this.bPout.Text = "Log out";
            this.bPout.UseVisualStyleBackColor = false;
            this.bPout.Click += new System.EventHandler(this.bPout_Click);
            // 
            // Passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MRT_Management_System.Properties.Resources.output_onlinepngtools;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.bPout);
            this.Controls.Add(this.bPBack);
            this.Controls.Add(this.bPPrint);
            this.Controls.Add(this.dGVP);
            this.Controls.Add(this.bPPp);
            this.Controls.Add(this.bPVip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Passenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passenger";
            this.Load += new System.EventHandler(this.Passenger_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPtitle;
        private System.Windows.Forms.Button bSP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bPVip;
        private System.Windows.Forms.Button bPPp;
        private System.Windows.Forms.Button bPPrint;
        private System.Windows.Forms.Button bPBack;
        private System.Windows.Forms.Button bPout;
        private System.Windows.Forms.TextBox txtSP;
        public System.Windows.Forms.DataGridView dGVP;
    }
}