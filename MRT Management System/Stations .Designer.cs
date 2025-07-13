namespace MRT_Management_System
{
    partial class Stations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stations));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSearchHere = new System.Windows.Forms.TextBox();
            this.labelMRB = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
            this.dGVS = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.textBoxSearchHere);
            this.panel1.Controls.Add(this.labelMRB);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 105);
            this.panel1.TabIndex = 0;
            // 
            // textBoxSearchHere
            // 
            this.textBoxSearchHere.BackColor = System.Drawing.Color.White;
            this.textBoxSearchHere.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchHere.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxSearchHere.Location = new System.Drawing.Point(304, 59);
            this.textBoxSearchHere.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearchHere.Name = "textBoxSearchHere";
            this.textBoxSearchHere.Size = new System.Drawing.Size(328, 21);
            this.textBoxSearchHere.TabIndex = 1;
            this.textBoxSearchHere.Text = "Search Here";
            this.textBoxSearchHere.TextChanged += new System.EventHandler(this.textBoxSearchHere_TextChanged);
            // 
            // labelMRB
            // 
            this.labelMRB.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMRB.ForeColor = System.Drawing.Color.White;
            this.labelMRB.Location = new System.Drawing.Point(298, 9);
            this.labelMRB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMRB.Name = "labelMRB";
            this.labelMRB.Size = new System.Drawing.Size(334, 39);
            this.labelMRB.TabIndex = 0;
            this.labelMRB.Text = "Metro Rail Bangladesh";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Crimson;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(12, 521);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(85, 28);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Crimson;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(887, 521);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(85, 28);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 109);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Station Details";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bPrint
            // 
            this.bPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.bPrint.FlatAppearance.BorderSize = 0;
            this.bPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrint.ForeColor = System.Drawing.Color.White;
            this.bPrint.Location = new System.Drawing.Point(887, 475);
            this.bPrint.Margin = new System.Windows.Forms.Padding(2);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(85, 28);
            this.bPrint.TabIndex = 4;
            this.bPrint.Text = "Print";
            this.bPrint.UseVisualStyleBackColor = false;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // dGVS
            // 
            this.dGVS.BackgroundColor = System.Drawing.Color.White;
            this.dGVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVS.Location = new System.Drawing.Point(0, 147);
            this.dGVS.Name = "dGVS";
            this.dGVS.Size = new System.Drawing.Size(984, 322);
            this.dGVS.TabIndex = 5;
            this.dGVS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVS_CellContentClick);
            // 
            // Stations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MRT_Management_System.Properties.Resources.output_onlinepngtools;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dGVS);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Stations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stations";
            this.Load += new System.EventHandler(this.Stations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMRB;
        private System.Windows.Forms.TextBox textBoxSearchHere;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button bPrint;
        public System.Windows.Forms.DataGridView dGVS;
    }
}