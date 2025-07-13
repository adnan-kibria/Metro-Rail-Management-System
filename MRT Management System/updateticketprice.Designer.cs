namespace MRT_Management_System
{
    partial class updateticketprice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateticketprice));
            this.pnladdticketprice = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblupdateticketprice = new System.Windows.Forms.Label();
            this.txtenterpriceupdate = new System.Windows.Forms.TextBox();
            this.lblfromstation = new System.Windows.Forms.Label();
            this.txttostationupdate = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtfromstationupdate = new System.Windows.Forms.TextBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.pnladdticketprice.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnladdticketprice
            // 
            this.pnladdticketprice.BackColor = System.Drawing.Color.SeaGreen;
            this.pnladdticketprice.Controls.Add(this.label1);
            this.pnladdticketprice.Controls.Add(this.lblupdateticketprice);
            this.pnladdticketprice.Controls.Add(this.txtenterpriceupdate);
            this.pnladdticketprice.Controls.Add(this.lblfromstation);
            this.pnladdticketprice.Controls.Add(this.txttostationupdate);
            this.pnladdticketprice.Controls.Add(this.btnupdate);
            this.pnladdticketprice.Controls.Add(this.txtfromstationupdate);
            this.pnladdticketprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnladdticketprice.Location = new System.Drawing.Point(203, 59);
            this.pnladdticketprice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnladdticketprice.Name = "pnladdticketprice";
            this.pnladdticketprice.Size = new System.Drawing.Size(344, 288);
            this.pnladdticketprice.TabIndex = 14;
            this.pnladdticketprice.Paint += new System.Windows.Forms.PaintEventHandler(this.pnladdticketprice_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = " To   Station";
            // 
            // lblupdateticketprice
            // 
            this.lblupdateticketprice.AutoSize = true;
            this.lblupdateticketprice.BackColor = System.Drawing.Color.White;
            this.lblupdateticketprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdateticketprice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblupdateticketprice.Location = new System.Drawing.Point(85, 164);
            this.lblupdateticketprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblupdateticketprice.Name = "lblupdateticketprice";
            this.lblupdateticketprice.Size = new System.Drawing.Size(182, 17);
            this.lblupdateticketprice.TabIndex = 17;
            this.lblupdateticketprice.Text = "Enter  Update  Ticket  Price";
            this.lblupdateticketprice.Click += new System.EventHandler(this.lblupdateticketprice_Click);
            // 
            // txtenterpriceupdate
            // 
            this.txtenterpriceupdate.Location = new System.Drawing.Point(62, 164);
            this.txtenterpriceupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtenterpriceupdate.Multiline = true;
            this.txtenterpriceupdate.Name = "txtenterpriceupdate";
            this.txtenterpriceupdate.Size = new System.Drawing.Size(228, 33);
            this.txtenterpriceupdate.TabIndex = 16;
            this.txtenterpriceupdate.TextChanged += new System.EventHandler(this.txtenterpriceupdate_TextChanged);
            // 
            // lblfromstation
            // 
            this.lblfromstation.AutoSize = true;
            this.lblfromstation.BackColor = System.Drawing.Color.SeaGreen;
            this.lblfromstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfromstation.ForeColor = System.Drawing.Color.White;
            this.lblfromstation.Location = new System.Drawing.Point(54, 43);
            this.lblfromstation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfromstation.Name = "lblfromstation";
            this.lblfromstation.Size = new System.Drawing.Size(100, 17);
            this.lblfromstation.TabIndex = 14;
            this.lblfromstation.Text = " From   Station";
            // 
            // txttostationupdate
            // 
            this.txttostationupdate.Enabled = false;
            this.txttostationupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttostationupdate.Location = new System.Drawing.Point(165, 106);
            this.txttostationupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttostationupdate.Multiline = true;
            this.txttostationupdate.Name = "txttostationupdate";
            this.txttostationupdate.ReadOnly = true;
            this.txttostationupdate.Size = new System.Drawing.Size(125, 24);
            this.txttostationupdate.TabIndex = 3;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Red;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(62, 219);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(227, 36);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtfromstationupdate
            // 
            this.txtfromstationupdate.Enabled = false;
            this.txtfromstationupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfromstationupdate.Location = new System.Drawing.Point(165, 53);
            this.txtfromstationupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtfromstationupdate.Multiline = true;
            this.txtfromstationupdate.Name = "txtfromstationupdate";
            this.txtfromstationupdate.ReadOnly = true;
            this.txtfromstationupdate.Size = new System.Drawing.Size(125, 24);
            this.txtfromstationupdate.TabIndex = 0;
            this.txtfromstationupdate.TextChanged += new System.EventHandler(this.txtfromstationupdate_TextChanged);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Red;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(643, 413);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(68, 27);
            this.btnlogout.TabIndex = 19;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Red;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(25, 413);
            this.btnback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(70, 27);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // updateticketprice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.pnladdticketprice);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "updateticketprice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateticketprice";
            this.Load += new System.EventHandler(this.updateticketprice_Load);
            this.pnladdticketprice.ResumeLayout(false);
            this.pnladdticketprice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnladdticketprice;
        private System.Windows.Forms.Label lblupdateticketprice;
        private System.Windows.Forms.TextBox txtenterpriceupdate;
        private System.Windows.Forms.Label lblfromstation;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnback;
        public System.Windows.Forms.TextBox txttostationupdate;
        public System.Windows.Forms.TextBox txtfromstationupdate;
    }
}