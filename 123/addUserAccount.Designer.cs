
namespace _123
{
    partial class addUserAccount
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
            this.auButton = new System.Windows.Forms.Button();
            this.loginText = new System.Windows.Forms.Label();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.Label();
            this.passwdTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdminACB = new System.Windows.Forms.CheckBox();
            this.ValidCB = new System.Windows.Forms.CheckBox();
            this.NameofUser = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // auButton
            // 
            this.auButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.auButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.auButton.Location = new System.Drawing.Point(74, 345);
            this.auButton.Name = "auButton";
            this.auButton.Size = new System.Drawing.Size(167, 37);
            this.auButton.TabIndex = 11;
            this.auButton.Text = "Add User";
            this.auButton.UseVisualStyleBackColor = false;
            this.auButton.Click += new System.EventHandler(this.auButton_Click);
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginText.Location = new System.Drawing.Point(24, 64);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(80, 16);
            this.loginText.TabIndex = 14;
            this.loginText.Text = "Username";
            this.loginText.Click += new System.EventHandler(this.loginText_Click);
            // 
            // loginTb
            // 
            this.loginTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTb.Location = new System.Drawing.Point(27, 82);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(245, 22);
            this.loginTb.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(27, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 2);
            this.panel1.TabIndex = 12;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Password.Location = new System.Drawing.Point(24, 116);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(77, 16);
            this.Password.TabIndex = 17;
            this.Password.Text = "Password";
            // 
            // passwdTB
            // 
            this.passwdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdTB.Location = new System.Drawing.Point(27, 134);
            this.passwdTB.Name = "passwdTB";
            this.passwdTB.Size = new System.Drawing.Size(245, 22);
            this.passwdTB.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(27, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 2);
            this.panel2.TabIndex = 15;
            // 
            // AdminACB
            // 
            this.AdminACB.AutoSize = true;
            this.AdminACB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminACB.Location = new System.Drawing.Point(27, 212);
            this.AdminACB.Name = "AdminACB";
            this.AdminACB.Size = new System.Drawing.Size(184, 24);
            this.AdminACB.TabIndex = 18;
            this.AdminACB.Text = "Is an Admin Account?";
            this.AdminACB.UseVisualStyleBackColor = true;
            // 
            // ValidCB
            // 
            this.ValidCB.AutoSize = true;
            this.ValidCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidCB.Location = new System.Drawing.Point(27, 235);
            this.ValidCB.Name = "ValidCB";
            this.ValidCB.Size = new System.Drawing.Size(89, 24);
            this.ValidCB.TabIndex = 19;
            this.ValidCB.Text = "Is Valid?";
            this.ValidCB.UseVisualStyleBackColor = true;
            // 
            // NameofUser
            // 
            this.NameofUser.AutoSize = true;
            this.NameofUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameofUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NameofUser.Location = new System.Drawing.Point(24, 166);
            this.NameofUser.Name = "NameofUser";
            this.NameofUser.Size = new System.Drawing.Size(50, 16);
            this.NameofUser.TabIndex = 22;
            this.NameofUser.Text = "Name";
            // 
            // nameTB
            // 
            this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(27, 184);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(245, 22);
            this.nameTB.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(27, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 2);
            this.panel3.TabIndex = 20;
            // 
            // addUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(305, 421);
            this.Controls.Add(this.NameofUser);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ValidCB);
            this.Controls.Add(this.AdminACB);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.passwdTB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.auButton);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addUserAccount";
            this.Text = "addUserAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button auButton;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox passwdTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox AdminACB;
        private System.Windows.Forms.CheckBox ValidCB;
        private System.Windows.Forms.Label NameofUser;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Panel panel3;
    }
}