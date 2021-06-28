
namespace _123
{
    partial class AdminPanel
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
            this.caButton = new System.Windows.Forms.Button();
            this.eaButton = new System.Windows.Forms.Button();
            this.smButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caButton
            // 
            this.caButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.caButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.caButton.Location = new System.Drawing.Point(82, 105);
            this.caButton.Name = "caButton";
            this.caButton.Size = new System.Drawing.Size(167, 37);
            this.caButton.TabIndex = 8;
            this.caButton.Text = "Create Account";
            this.caButton.UseVisualStyleBackColor = false;
            this.caButton.Click += new System.EventHandler(this.caButton_Click);
            // 
            // eaButton
            // 
            this.eaButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.eaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eaButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.eaButton.Location = new System.Drawing.Point(82, 148);
            this.eaButton.Name = "eaButton";
            this.eaButton.Size = new System.Drawing.Size(167, 37);
            this.eaButton.TabIndex = 9;
            this.eaButton.Text = "Edit Account";
            this.eaButton.UseVisualStyleBackColor = false;
            this.eaButton.Click += new System.EventHandler(this.eaButton_Click);
            // 
            // smButton
            // 
            this.smButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.smButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smButton.Location = new System.Drawing.Point(82, 191);
            this.smButton.Name = "smButton";
            this.smButton.Size = new System.Drawing.Size(167, 37);
            this.smButton.TabIndex = 10;
            this.smButton.Text = "Send Message";
            this.smButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExitButton.Location = new System.Drawing.Point(82, 337);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(167, 37);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logoutButton.Location = new System.Drawing.Point(82, 234);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(167, 37);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(321, 460);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.smButton);
            this.Controls.Add(this.eaButton);
            this.Controls.Add(this.caButton);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button caButton;
        private System.Windows.Forms.Button eaButton;
        private System.Windows.Forms.Button smButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button logoutButton;
    }
}