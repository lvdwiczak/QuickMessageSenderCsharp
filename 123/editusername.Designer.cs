
namespace _123
{
    partial class editusername
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
            this.loginText = new System.Windows.Forms.Label();
            this.oldUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.newUsername = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginText.Location = new System.Drawing.Point(29, 65);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(79, 16);
            this.loginText.TabIndex = 17;
            this.loginText.Text = "Username";
            // 
            // oldUsername
            // 
            this.oldUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldUsername.Location = new System.Drawing.Point(32, 83);
            this.oldUsername.Name = "oldUsername";
            this.oldUsername.Size = new System.Drawing.Size(245, 22);
            this.oldUsername.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(32, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 2);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(29, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "New username";
            // 
            // newUsername
            // 
            this.newUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUsername.Location = new System.Drawing.Point(32, 139);
            this.newUsername.Name = "newUsername";
            this.newUsername.Size = new System.Drawing.Size(245, 22);
            this.newUsername.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(32, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 2);
            this.panel2.TabIndex = 18;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backButton.Location = new System.Drawing.Point(70, 359);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(167, 37);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // cButton
            // 
            this.cButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.cButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cButton.Location = new System.Drawing.Point(69, 192);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(167, 37);
            this.cButton.TabIndex = 22;
            this.cButton.Text = "Change Username";
            this.cButton.UseVisualStyleBackColor = false;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // editusername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(305, 421);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newUsername);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.oldUsername);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editusername";
            this.Text = "editusername";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.TextBox oldUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button cButton;
    }
}