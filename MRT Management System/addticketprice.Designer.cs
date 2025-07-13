namespace MRT_Management_System
{
    partial class addticketprice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addticketprice));
            this.pnladdticketprice = new System.Windows.Forms.Panel();
            this.lblticketprice = new System.Windows.Forms.Label();
            this.txtenterprice = new System.Windows.Forms.TextBox();
            this.lbltostation = new System.Windows.Forms.Label();
            this.lblfromstation = new System.Windows.Forms.Label();
            this.txttostation = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtfromstation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnladdticketprice.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnladdticketprice
            // 
            this.pnladdticketprice.BackColor = System.Drawing.Color.SeaGreen;
            this.pnladdticketprice.Controls.Add(this.lblticketprice);
            this.pnladdticketprice.Controls.Add(this.txtenterprice);
            this.pnladdticketprice.Controls.Add(this.lbltostation);
            this.pnladdticketprice.Controls.Add(this.lblfromstation);
            this.pnladdticketprice.Controls.Add(this.txttostation);
            this.pnladdticketprice.Controls.Add(this.btnadd);
            this.pnladdticketprice.Controls.Add(this.txtfromstation);
            this.pnladdticketprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnladdticketprice.Location = new System.Drawing.Point(199, 44);
            this.pnladdticketprice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnladdticketprice.Name = "pnladdticketprice";
            this.pnladdticketprice.Size = new System.Drawing.Size(344, 288);
            this.pnladdticketprice.TabIndex = 0;
            // 
            // lblticketprice
            // 
            this.lblticketprice.AutoSize = true;
            this.lblticketprice.BackColor = System.Drawing.Color.White;
            this.lblticketprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblticketprice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblticketprice.Location = new System.Drawing.Point(110, 164);
            this.lblticketprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblticketprice.Name = "lblticketprice";
            this.lblticketprice.Size = new System.Drawing.Size(128, 17);
            this.lblticketprice.TabIndex = 17;
            this.lblticketprice.Text = "Enter  Ticket  Price";
            // 
            // txtenterprice
            // 
            this.txtenterprice.Location = new System.Drawing.Point(62, 155);
            this.txtenterprice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtenterprice.Multiline = true;
            this.txtenterprice.Name = "txtenterprice";
            this.txtenterprice.Size = new System.Drawing.Size(218, 33);
            this.txtenterprice.TabIndex = 16;
            this.txtenterprice.TextChanged += new System.EventHandler(this.txtenterprice_TextChanged);
            // 
            // lbltostation
            // 
            this.lbltostation.AutoSize = true;
            this.lbltostation.BackColor = System.Drawing.Color.White;
            this.lbltostation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltostation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbltostation.Location = new System.Drawing.Point(110, 106);
            this.lbltostation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltostation.Name = "lbltostation";
            this.lbltostation.Size = new System.Drawing.Size(119, 17);
            this.lbltostation.TabIndex = 15;
            this.lbltostation.Text = "Enter  To  Station";
            // 
            // lblfromstation
            // 
            this.lblfromstation.AutoSize = true;
            this.lblfromstation.BackColor = System.Drawing.Color.White;
            this.lblfromstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfromstation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblfromstation.Location = new System.Drawing.Point(104, 43);
            this.lblfromstation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfromstation.Name = "lblfromstation";
            this.lblfromstation.Size = new System.Drawing.Size(134, 17);
            this.lblfromstation.TabIndex = 14;
            this.lblfromstation.Text = "Enter  From  Station";
            this.lblfromstation.Click += new System.EventHandler(this.lblfromstation_Click);
            // 
            // txttostation
            // 
            this.txttostation.Location = new System.Drawing.Point(62, 97);
            this.txttostation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttostation.Multiline = true;
            this.txttostation.Name = "txttostation";
            this.txttostation.Size = new System.Drawing.Size(218, 33);
            this.txttostation.TabIndex = 3;
            this.txttostation.TextChanged += new System.EventHandler(this.txttostation_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Red;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(62, 218);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(218, 37);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtfromstation
            // 
            this.txtfromstation.Location = new System.Drawing.Point(62, 33);
            this.txtfromstation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtfromstation.Multiline = true;
            this.txtfromstation.Name = "txtfromstation";
            this.txtfromstation.Size = new System.Drawing.Size(218, 36);
            this.txtfromstation.TabIndex = 0;
            this.txtfromstation.TextChanged += new System.EventHandler(this.txtfromstation_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 413);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(648, 413);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 27);
            this.button2.TabIndex = 15;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // addticketprice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnladdticketprice);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addticketprice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addticketprice";
            this.Load += new System.EventHandler(this.addticketprice_Load);
            this.pnladdticketprice.ResumeLayout(false);
            this.pnladdticketprice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnladdticketprice;
        private System.Windows.Forms.TextBox txttostation;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtfromstation;
        private System.Windows.Forms.Label lblfromstation;
        private System.Windows.Forms.Label lblticketprice;
        private System.Windows.Forms.TextBox txtenterprice;
        private System.Windows.Forms.Label lbltostation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}