namespace MRT_Management_System
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSReport = new System.Windows.Forms.Button();
            this.txtSReport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bRZone = new System.Windows.Forms.Button();
            this.dGVTSR = new System.Windows.Forms.DataGridView();
            this.bRBack = new System.Windows.Forms.Button();
            this.bRout = new System.Windows.Forms.Button();
            this.bRPrint = new System.Windows.Forms.Button();
            this.bRSort = new System.Windows.Forms.Button();
            this.bRFilter = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTSR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.bSReport);
            this.panel1.Controls.Add(this.txtSReport);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 105);
            this.panel1.TabIndex = 0;
            // 
            // bSReport
            // 
            this.bSReport.BackColor = System.Drawing.Color.White;
            this.bSReport.FlatAppearance.BorderSize = 0;
            this.bSReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSReport.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSReport.ForeColor = System.Drawing.Color.SeaGreen;
            this.bSReport.Location = new System.Drawing.Point(554, 59);
            this.bSReport.Name = "bSReport";
            this.bSReport.Size = new System.Drawing.Size(79, 29);
            this.bSReport.TabIndex = 2;
            this.bSReport.Text = "Search";
            this.bSReport.UseVisualStyleBackColor = false;
            // 
            // txtSReport
            // 
            this.txtSReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSReport.Location = new System.Drawing.Point(304, 59);
            this.txtSReport.Multiline = true;
            this.txtSReport.Name = "txtSReport";
            this.txtSReport.Size = new System.Drawing.Size(244, 29);
            this.txtSReport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metro Rail Bangladesh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ticket Sales Report";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bRZone
            // 
            this.bRZone.BackColor = System.Drawing.Color.SeaGreen;
            this.bRZone.FlatAppearance.BorderSize = 0;
            this.bRZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRZone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRZone.ForeColor = System.Drawing.Color.White;
            this.bRZone.Location = new System.Drawing.Point(181, 111);
            this.bRZone.Name = "bRZone";
            this.bRZone.Size = new System.Drawing.Size(163, 30);
            this.bRZone.TabIndex = 2;
            this.bRZone.Text = "Zone Based Analytics";
            this.bRZone.UseVisualStyleBackColor = false;
            this.bRZone.Click += new System.EventHandler(this.bRZone_Click);
            // 
            // dGVTSR
            // 
            this.dGVTSR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dGVTSR.BackgroundColor = System.Drawing.Color.White;
            this.dGVTSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTSR.Location = new System.Drawing.Point(0, 147);
            this.dGVTSR.Name = "dGVTSR";
            this.dGVTSR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVTSR.Size = new System.Drawing.Size(984, 322);
            this.dGVTSR.TabIndex = 3;
            // 
            // bRBack
            // 
            this.bRBack.BackColor = System.Drawing.Color.Crimson;
            this.bRBack.FlatAppearance.BorderSize = 0;
            this.bRBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRBack.ForeColor = System.Drawing.Color.White;
            this.bRBack.Location = new System.Drawing.Point(12, 521);
            this.bRBack.Name = "bRBack";
            this.bRBack.Size = new System.Drawing.Size(85, 28);
            this.bRBack.TabIndex = 4;
            this.bRBack.Text = "Back";
            this.bRBack.UseVisualStyleBackColor = false;
            this.bRBack.Click += new System.EventHandler(this.bRBack_Click);
            // 
            // bRout
            // 
            this.bRout.BackColor = System.Drawing.Color.Crimson;
            this.bRout.FlatAppearance.BorderSize = 0;
            this.bRout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRout.ForeColor = System.Drawing.Color.White;
            this.bRout.Location = new System.Drawing.Point(887, 521);
            this.bRout.Name = "bRout";
            this.bRout.Size = new System.Drawing.Size(85, 28);
            this.bRout.TabIndex = 5;
            this.bRout.Text = "Log out";
            this.bRout.UseVisualStyleBackColor = false;
            this.bRout.Click += new System.EventHandler(this.bRout_Click);
            // 
            // bRPrint
            // 
            this.bRPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.bRPrint.FlatAppearance.BorderSize = 0;
            this.bRPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRPrint.ForeColor = System.Drawing.Color.White;
            this.bRPrint.Location = new System.Drawing.Point(887, 475);
            this.bRPrint.Name = "bRPrint";
            this.bRPrint.Size = new System.Drawing.Size(85, 28);
            this.bRPrint.TabIndex = 6;
            this.bRPrint.Text = "Print";
            this.bRPrint.UseVisualStyleBackColor = false;
            this.bRPrint.Click += new System.EventHandler(this.bRPrint_Click);
            // 
            // bRSort
            // 
            this.bRSort.BackColor = System.Drawing.Color.SeaGreen;
            this.bRSort.FlatAppearance.BorderSize = 0;
            this.bRSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRSort.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRSort.ForeColor = System.Drawing.Color.White;
            this.bRSort.Location = new System.Drawing.Point(786, 127);
            this.bRSort.Name = "bRSort";
            this.bRSort.Size = new System.Drawing.Size(86, 20);
            this.bRSort.TabIndex = 7;
            this.bRSort.Text = "Sort";
            this.bRSort.UseVisualStyleBackColor = false;
            this.bRSort.Click += new System.EventHandler(this.button7_Click);
            // 
            // bRFilter
            // 
            this.bRFilter.BackColor = System.Drawing.Color.SeaGreen;
            this.bRFilter.FlatAppearance.BorderSize = 0;
            this.bRFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRFilter.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRFilter.ForeColor = System.Drawing.Color.White;
            this.bRFilter.Location = new System.Drawing.Point(887, 127);
            this.bRFilter.Name = "bRFilter";
            this.bRFilter.Size = new System.Drawing.Size(86, 20);
            this.bRFilter.TabIndex = 8;
            this.bRFilter.Text = "Filter";
            this.bRFilter.UseVisualStyleBackColor = false;
            this.bRFilter.Click += new System.EventHandler(this.button8_Click);
            // 
            // bLoad
            // 
            this.bLoad.BackColor = System.Drawing.Color.SeaGreen;
            this.bLoad.FlatAppearance.BorderSize = 0;
            this.bLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLoad.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLoad.ForeColor = System.Drawing.Color.White;
            this.bLoad.Location = new System.Drawing.Point(682, 127);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(86, 20);
            this.bLoad.TabIndex = 9;
            this.bLoad.Text = "Load";
            this.bLoad.UseVisualStyleBackColor = false;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MRT_Management_System.Properties.Resources.output_onlinepngtools;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.bRFilter);
            this.Controls.Add(this.bRSort);
            this.Controls.Add(this.bRPrint);
            this.Controls.Add(this.bRout);
            this.Controls.Add(this.bRBack);
            this.Controls.Add(this.dGVTSR);
            this.Controls.Add(this.bRZone);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTSR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSReport;
        private System.Windows.Forms.Button bSReport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bRZone;
        private System.Windows.Forms.Button bRBack;
        private System.Windows.Forms.Button bRout;
        private System.Windows.Forms.Button bRPrint;
        private System.Windows.Forms.Button bRSort;
        private System.Windows.Forms.Button bRFilter;
        public System.Windows.Forms.DataGridView dGVTSR;
        private System.Windows.Forms.Button bLoad;
    }
}