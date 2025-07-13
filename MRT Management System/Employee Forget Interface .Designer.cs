namespace MRT_Management_System
{
    partial class Forgot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWar = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.txtupPass = new System.Windows.Forms.TextBox();
            this.txtupUser = new System.Windows.Forms.TextBox();
            this.labelMetroRailMS = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblWar);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.txtupPass);
            this.panel1.Controls.Add(this.txtupUser);
            this.panel1.Controls.Add(this.labelMetroRailMS);
            this.panel1.Location = new System.Drawing.Point(298, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 309);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            // 
            // lblWar
            // 
            this.lblWar.AutoSize = true;
            this.lblWar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWar.ForeColor = System.Drawing.Color.Crimson;
            this.lblWar.Location = new System.Drawing.Point(89, 217);
            this.lblWar.Name = "lblWar";
            this.lblWar.Size = new System.Drawing.Size(222, 17);
            this.lblWar.TabIndex = 6;
            this.lblWar.Text = "Something is wrong, please try again";
            this.lblWar.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Crimson;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(86, 243);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(220, 33);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // txtupPass
            // 
            this.txtupPass.BackColor = System.Drawing.Color.White;
            this.txtupPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtupPass.ForeColor = System.Drawing.Color.Black;
            this.txtupPass.Location = new System.Drawing.Point(86, 187);
            this.txtupPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtupPass.Name = "txtupPass";
            this.txtupPass.PasswordChar = '*';
            this.txtupPass.Size = new System.Drawing.Size(220, 26);
            this.txtupPass.TabIndex = 3;
            this.txtupPass.TextChanged += new System.EventHandler(this.textBoxNewPassword_TextChanged);
            this.txtupPass.Enter += new System.EventHandler(this.textBoxNewPassword_Enter);
            this.txtupPass.Leave += new System.EventHandler(this.textBoxNewPassword_Leave);
            // 
            // txtupUser
            // 
            this.txtupUser.BackColor = System.Drawing.Color.White;
            this.txtupUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtupUser.ForeColor = System.Drawing.Color.Black;
            this.txtupUser.Location = new System.Drawing.Point(86, 132);
            this.txtupUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtupUser.Name = "txtupUser";
            this.txtupUser.Size = new System.Drawing.Size(220, 26);
            this.txtupUser.TabIndex = 1;
            this.txtupUser.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            this.txtupUser.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.txtupUser.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // labelMetroRailMS
            // 
            this.labelMetroRailMS.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetroRailMS.ForeColor = System.Drawing.Color.White;
            this.labelMetroRailMS.Location = new System.Drawing.Point(34, 30);
            this.labelMetroRailMS.Margin = new System.Windows.Forms.Padding(3);
            this.labelMetroRailMS.Name = "labelMetroRailMS";
            this.labelMetroRailMS.Size = new System.Drawing.Size(324, 83);
            this.labelMetroRailMS.TabIndex = 0;
            this.labelMetroRailMS.Text = "Metro Rail Management System ";
            this.labelMetroRailMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMetroRailMS.Click += new System.EventHandler(this.labelMetroRailMS_Click);
            // 
            // Forgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Forgot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Forget_Interface";
            this.Load += new System.EventHandler(this.Employee_Forget_Interface_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtupUser;
        private System.Windows.Forms.Label labelMetroRailMS;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox txtupPass;
        private System.Windows.Forms.Label lblWar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}