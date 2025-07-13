namespace MRT_Management_System
{
    partial class Payment_interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_interface));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblinputamount = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.txtinputamount = new System.Windows.Forms.TextBox();
            this.txttotalcost = new System.Windows.Forms.TextBox();
            this.txttotalticket = new System.Windows.Forms.TextBox();
            this.lbltotalcost = new System.Windows.Forms.Label();
            this.lbltotalticket = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.lblinputamount);
            this.panel1.Controls.Add(this.btnconfirm);
            this.panel1.Controls.Add(this.txtinputamount);
            this.panel1.Controls.Add(this.txttotalcost);
            this.panel1.Controls.Add(this.txttotalticket);
            this.panel1.Controls.Add(this.lbltotalcost);
            this.panel1.Controls.Add(this.lbltotalticket);
            this.panel1.Location = new System.Drawing.Point(290, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 313);
            this.panel1.TabIndex = 0;
            // 
            // lblinputamount
            // 
            this.lblinputamount.AutoSize = true;
            this.lblinputamount.BackColor = System.Drawing.Color.White;
            this.lblinputamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinputamount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblinputamount.Location = new System.Drawing.Point(180, 187);
            this.lblinputamount.Name = "lblinputamount";
            this.lblinputamount.Size = new System.Drawing.Size(153, 20);
            this.lblinputamount.TabIndex = 1;
            this.lblinputamount.Text = "Input  amount  here";
            // 
            // btnconfirm
            // 
            this.btnconfirm.BackColor = System.Drawing.Color.Red;
            this.btnconfirm.FlatAppearance.BorderSize = 0;
            this.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirm.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirm.ForeColor = System.Drawing.Color.White;
            this.btnconfirm.Location = new System.Drawing.Point(79, 244);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(321, 51);
            this.btnconfirm.TabIndex = 30;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // txtinputamount
            // 
            this.txtinputamount.Location = new System.Drawing.Point(79, 187);
            this.txtinputamount.Multiline = true;
            this.txtinputamount.Name = "txtinputamount";
            this.txtinputamount.Size = new System.Drawing.Size(321, 29);
            this.txtinputamount.TabIndex = 4;
            this.txtinputamount.TextChanged += new System.EventHandler(this.txtinputamount_TextChanged);
            // 
            // txttotalcost
            // 
            this.txttotalcost.Location = new System.Drawing.Point(213, 130);
            this.txttotalcost.Multiline = true;
            this.txttotalcost.Name = "txttotalcost";
            this.txttotalcost.ReadOnly = true;
            this.txttotalcost.Size = new System.Drawing.Size(187, 30);
            this.txttotalcost.TabIndex = 3;
            this.txttotalcost.TextChanged += new System.EventHandler(this.txttotalcost_TextChanged);
            // 
            // txttotalticket
            // 
            this.txttotalticket.Location = new System.Drawing.Point(213, 65);
            this.txttotalticket.Multiline = true;
            this.txttotalticket.Name = "txttotalticket";
            this.txttotalticket.ReadOnly = true;
            this.txttotalticket.Size = new System.Drawing.Size(187, 30);
            this.txttotalticket.TabIndex = 2;
            // 
            // lbltotalcost
            // 
            this.lbltotalcost.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalcost.ForeColor = System.Drawing.Color.White;
            this.lbltotalcost.Location = new System.Drawing.Point(69, 118);
            this.lbltotalcost.Name = "lbltotalcost";
            this.lbltotalcost.Size = new System.Drawing.Size(128, 42);
            this.lbltotalcost.TabIndex = 1;
            this.lbltotalcost.Text = "Total  Cost";
            // 
            // lbltotalticket
            // 
            this.lbltotalticket.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalticket.ForeColor = System.Drawing.Color.White;
            this.lbltotalticket.Location = new System.Drawing.Point(69, 53);
            this.lbltotalticket.Name = "lbltotalticket";
            this.lbltotalticket.Size = new System.Drawing.Size(128, 42);
            this.lbltotalticket.TabIndex = 0;
            this.lbltotalticket.Text = "Total  Tickets";
            // 
            // Payment_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Payment_interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment_interface";
            this.Load += new System.EventHandler(this.Payment_interface_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltotalticket;
        private System.Windows.Forms.Label lbltotalcost;
        private System.Windows.Forms.TextBox txtinputamount;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Label lblinputamount;
        public System.Windows.Forms.TextBox txttotalticket;
        public System.Windows.Forms.TextBox txttotalcost;
    }
}