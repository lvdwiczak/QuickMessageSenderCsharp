
namespace _123
{
    partial class QuickMessageSender
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showpasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.loginText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(54, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 2);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(54, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 2);
            this.panel2.TabIndex = 1;
            // 
            // showpasswordCheckbox
            // 
            this.showpasswordCheckbox.AutoSize = true;
            this.showpasswordCheckbox.FlatAppearance.BorderSize = 0;
            this.showpasswordCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showpasswordCheckbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showpasswordCheckbox.Location = new System.Drawing.Point(197, 266);
            this.showpasswordCheckbox.Name = "showpasswordCheckbox";
            this.showpasswordCheckbox.Size = new System.Drawing.Size(99, 17);
            this.showpasswordCheckbox.TabIndex = 2;
            this.showpasswordCheckbox.Text = "Show Password";
            this.showpasswordCheckbox.UseVisualStyleBackColor = true;
            this.showpasswordCheckbox.CheckedChanged += new System.EventHandler(this.showpasswordCheckbox_CheckedChanged);
            // 
            // PasswordTb
            // 
            this.PasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.Location = new System.Drawing.Point(54, 235);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(245, 22);
            this.PasswordTb.TabIndex = 3;
            this.PasswordTb.TextChanged += new System.EventHandler(this.PasswordTb_TextChanged);
            // 
            // loginTb
            // 
            this.loginTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTb.Location = new System.Drawing.Point(54, 153);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(245, 22);
            this.loginTb.TabIndex = 4;
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginText.Location = new System.Drawing.Point(51, 135);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(46, 16);
            this.loginText.TabIndex = 5;
            this.loginText.Text = "Login";
            this.loginText.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(51, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loginButton.Location = new System.Drawing.Point(90, 299);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(167, 37);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exitButton.Location = new System.Drawing.Point(90, 342);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(167, 37);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // QuickMessageSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(337, 499);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.showpasswordCheckbox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuickMessageSender";
            this.Text = "Quickmessagesender";
            this.Load += new System.EventHandler(this.QuickMessageSender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox showpasswordCheckbox;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

