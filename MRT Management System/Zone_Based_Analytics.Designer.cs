namespace MRT_Management_System
{
    partial class Zone_Based_Analytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zone_Based_Analytics));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSZone = new System.Windows.Forms.Button();
            this.txtSZone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bZReport = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dGVZBA = new System.Windows.Forms.DataGridView();
            this.bZPrint = new System.Windows.Forms.Button();
            this.bZBack = new System.Windows.Forms.Button();
            this.bZout = new System.Windows.Forms.Button();
            this.bZSort = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVZBA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.bSZone);
            this.panel1.Controls.Add(this.txtSZone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 105);
            this.panel1.TabIndex = 0;
            // 
            // bSZone
            // 
            this.bSZone.BackColor = System.Drawing.Color.White;
            this.bSZone.FlatAppearance.BorderSize = 0;
            this.bSZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSZone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSZone.ForeColor = System.Drawing.Color.SeaGreen;
            this.bSZone.Location = new System.Drawing.Point(554, 59);
            this.bSZone.Name = "bSZone";
            this.bSZone.Size = new System.Drawing.Size(79, 29);
            this.bSZone.TabIndex = 2;
            this.bSZone.Text = "Search";
            this.bSZone.UseVisualStyleBackColor = false;
            // 
            // txtSZone
            // 
            this.txtSZone.Location = new System.Drawing.Point(304, 59);
            this.txtSZone.Multiline = true;
            this.txtSZone.Name = "txtSZone";
            this.txtSZone.Size = new System.Drawing.Size(244, 29);
            this.txtSZone.TabIndex = 1;
            this.txtSZone.TextChanged += new System.EventHandler(this.txtSZone_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metro Rail Bangladesh";
            // 
            // bZReport
            // 
            this.bZReport.BackColor = System.Drawing.Color.SeaGreen;
            this.bZReport.FlatAppearance.BorderSize = 0;
            this.bZReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bZReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZReport.ForeColor = System.Drawing.Color.White;
            this.bZReport.Location = new System.Drawing.Point(12, 111);
            this.bZReport.Name = "bZReport";
            this.bZReport.Size = new System.Drawing.Size(163, 30);
            this.bZReport.TabIndex = 3;
            this.bZReport.Text = "Ticket Sales Report";
            this.bZReport.UseVisualStyleBackColor = false;
            this.bZReport.Click += new System.EventHandler(this.bZReport_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(181, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Zone Based Analytics";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dGVZBA
            // 
            this.dGVZBA.BackgroundColor = System.Drawing.Color.White;
            this.dGVZBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVZBA.Location = new System.Drawing.Point(0, 147);
            this.dGVZBA.Name = "dGVZBA";
            this.dGVZBA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVZBA.Size = new System.Drawing.Size(984, 322);
            this.dGVZBA.TabIndex = 5;
            // 
            // bZPrint
            // 
            this.bZPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.bZPrint.FlatAppearance.BorderSize = 0;
            this.bZPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bZPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZPrint.ForeColor = System.Drawing.Color.White;
            this.bZPrint.Location = new System.Drawing.Point(887, 475);
            this.bZPrint.Name = "bZPrint";
            this.bZPrint.Size = new System.Drawing.Size(85, 28);
            this.bZPrint.TabIndex = 6;
            this.bZPrint.Text = "Print";
            this.bZPrint.UseVisualStyleBackColor = false;
            this.bZPrint.Click += new System.EventHandler(this.bZPrint_Click);
            // 
            // bZBack
            // 
            this.bZBack.BackColor = System.Drawing.Color.Crimson;
            this.bZBack.FlatAppearance.BorderSize = 0;
            this.bZBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bZBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZBack.ForeColor = System.Drawing.Color.White;
            this.bZBack.Location = new System.Drawing.Point(12, 521);
            this.bZBack.Name = "bZBack";
            this.bZBack.Size = new System.Drawing.Size(85, 28);
            this.bZBack.TabIndex = 7;
            this.bZBack.Text = "Back";
            this.bZBack.UseVisualStyleBackColor = false;
            this.bZBack.Click += new System.EventHandler(this.bZBack_Click);
            // 
            // bZout
            // 
            this.bZout.BackColor = System.Drawing.Color.Crimson;
            this.bZout.FlatAppearance.BorderSize = 0;
            this.bZout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bZout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZout.ForeColor = System.Drawing.Color.White;
            this.bZout.Location = new System.Drawing.Point(887, 521);
            this.bZout.Name = "bZout";
            this.bZout.Size = new System.Drawing.Size(85, 28);
            this.bZout.TabIndex = 8;
            this.bZout.Text = "Log out";
            this.bZout.UseVisualStyleBackColor = false;
            this.bZout.Click += new System.EventHandler(this.bZout_Click);
            // 
            // bZSort
            // 
            this.bZSort.BackColor = System.Drawing.Color.SeaGreen;
            this.bZSort.FlatAppearance.BorderSize = 0;
            this.bZSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bZSort.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZSort.ForeColor = System.Drawing.Color.White;
            this.bZSort.Location = new System.Drawing.Point(887, 127);
            this.bZSort.Name = "bZSort";
            this.bZSort.Size = new System.Drawing.Size(86, 20);
            this.bZSort.TabIndex = 9;
            this.bZSort.Text = "Sort";
            this.bZSort.UseVisualStyleBackColor = false;
            this.bZSort.Click += new System.EventHandler(this.button7_Click);
            // 
            // Zone_Based_Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MRT_Management_System.Properties.Resources.output_onlinepngtools;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.bZSort);
            this.Controls.Add(this.bZout);
            this.Controls.Add(this.bZBack);
            this.Controls.Add(this.bZPrint);
            this.Controls.Add(this.dGVZBA);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bZReport);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zone_Based_Analytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zone_Based_Analytics";
            this.Load += new System.EventHandler(this.Zone_Based_Analytics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVZBA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSZone;
        private System.Windows.Forms.Button bSZone;
        private System.Windows.Forms.Button bZReport;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bZPrint;
        private System.Windows.Forms.Button bZBack;
        private System.Windows.Forms.Button bZout;
        private System.Windows.Forms.Button bZSort;
        public System.Windows.Forms.DataGridView dGVZBA;
    }
}