namespace MRT_Management_System
{
    partial class fare_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fare_management));
            this.pnlmatrorailbd = new System.Windows.Forms.Panel();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtsearchfare = new System.Windows.Forms.TextBox();
            this.lblmatrorailbd = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnfaremanagement = new System.Windows.Forms.Button();
            this.btnrevenuetracking = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.txtto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlmatrorailbd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmatrorailbd
            // 
            this.pnlmatrorailbd.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlmatrorailbd.Controls.Add(this.lblsearch);
            this.pnlmatrorailbd.Controls.Add(this.txtsearchfare);
            this.pnlmatrorailbd.Controls.Add(this.lblmatrorailbd);
            this.pnlmatrorailbd.Location = new System.Drawing.Point(-1, 0);
            this.pnlmatrorailbd.Margin = new System.Windows.Forms.Padding(2);
            this.pnlmatrorailbd.Name = "pnlmatrorailbd";
            this.pnlmatrorailbd.Size = new System.Drawing.Size(737, 88);
            this.pnlmatrorailbd.TabIndex = 0;
            // 
            // lblsearch
            // 
            this.lblsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsearch.BackColor = System.Drawing.Color.White;
            this.lblsearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblsearch.Location = new System.Drawing.Point(332, 46);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(89, 20);
            this.lblsearch.TabIndex = 5;
            this.lblsearch.Text = "Search";
            this.lblsearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsearchfare
            // 
            this.txtsearchfare.Location = new System.Drawing.Point(305, 40);
            this.txtsearchfare.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearchfare.Multiline = true;
            this.txtsearchfare.Name = "txtsearchfare";
            this.txtsearchfare.Size = new System.Drawing.Size(151, 28);
            this.txtsearchfare.TabIndex = 4;
            this.txtsearchfare.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtsearchfare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblmatrorailbd
            // 
            this.lblmatrorailbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatrorailbd.ForeColor = System.Drawing.Color.White;
            this.lblmatrorailbd.Location = new System.Drawing.Point(192, -8);
            this.lblmatrorailbd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmatrorailbd.Name = "lblmatrorailbd";
            this.lblmatrorailbd.Size = new System.Drawing.Size(382, 46);
            this.lblmatrorailbd.TabIndex = 3;
            this.lblmatrorailbd.Text = " Matro Rail  Bangladesh";
            this.lblmatrorailbd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Gray;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(486, 375);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(48, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Gray;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(561, 375);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(62, 23);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnfaremanagement
            // 
            this.btnfaremanagement.BackColor = System.Drawing.Color.SeaGreen;
            this.btnfaremanagement.FlatAppearance.BorderSize = 0;
            this.btnfaremanagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfaremanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfaremanagement.ForeColor = System.Drawing.Color.White;
            this.btnfaremanagement.Location = new System.Drawing.Point(31, 93);
            this.btnfaremanagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnfaremanagement.Name = "btnfaremanagement";
            this.btnfaremanagement.Size = new System.Drawing.Size(154, 37);
            this.btnfaremanagement.TabIndex = 0;
            this.btnfaremanagement.Text = "Fare  Management";
            this.btnfaremanagement.UseVisualStyleBackColor = false;
            this.btnfaremanagement.Click += new System.EventHandler(this.btnfaremanagement_Click);
            // 
            // btnrevenuetracking
            // 
            this.btnrevenuetracking.BackColor = System.Drawing.Color.SeaGreen;
            this.btnrevenuetracking.FlatAppearance.BorderSize = 0;
            this.btnrevenuetracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrevenuetracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrevenuetracking.ForeColor = System.Drawing.Color.White;
            this.btnrevenuetracking.Location = new System.Drawing.Point(204, 93);
            this.btnrevenuetracking.Margin = new System.Windows.Forms.Padding(2);
            this.btnrevenuetracking.Name = "btnrevenuetracking";
            this.btnrevenuetracking.Size = new System.Drawing.Size(162, 37);
            this.btnrevenuetracking.TabIndex = 2;
            this.btnrevenuetracking.Text = "Revenue  Tracking";
            this.btnrevenuetracking.UseVisualStyleBackColor = false;
            this.btnrevenuetracking.Click += new System.EventHandler(this.btnrevenuetracking_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Red;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(652, 414);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(68, 26);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Red;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(16, 414);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(70, 26);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 145);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(728, 217);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txtfrom
            // 
            this.txtfrom.Location = new System.Drawing.Point(177, 414);
            this.txtfrom.Margin = new System.Windows.Forms.Padding(2);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(76, 20);
            this.txtfrom.TabIndex = 7;
            this.txtfrom.Visible = false;
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(314, 414);
            this.txtto.Margin = new System.Windows.Forms.Padding(2);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(76, 20);
            this.txtto.TabIndex = 8;
            this.txtto.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(652, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fare_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnrevenuetracking);
            this.Controls.Add(this.btnfaremanagement);
            this.Controls.Add(this.pnlmatrorailbd);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fare_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fare_management";
            this.Load += new System.EventHandler(this.fare_management_Load);
            this.pnlmatrorailbd.ResumeLayout(false);
            this.pnlmatrorailbd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlmatrorailbd;
        private System.Windows.Forms.Label lblmatrorailbd;
        private System.Windows.Forms.Button btnfaremanagement;
        private System.Windows.Forms.Button btnrevenuetracking;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtsearchfare;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.Label lblsearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}