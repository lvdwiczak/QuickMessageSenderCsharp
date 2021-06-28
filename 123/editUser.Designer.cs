
namespace _123
{
    partial class editUser
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
            this.euButton = new System.Windows.Forms.Button();
            this.epButton = new System.Windows.Forms.Button();
            this.enButton = new System.Windows.Forms.Button();
            this.edButton = new System.Windows.Forms.Button();
            this.duButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // euButton
            // 
            this.euButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.euButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.euButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.euButton.Location = new System.Drawing.Point(73, 61);
            this.euButton.Name = "euButton";
            this.euButton.Size = new System.Drawing.Size(167, 37);
            this.euButton.TabIndex = 12;
            this.euButton.Text = "Edit Username";
            this.euButton.UseVisualStyleBackColor = false;
            this.euButton.Click += new System.EventHandler(this.euButton_Click);
            // 
            // epButton
            // 
            this.epButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.epButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.epButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.epButton.Location = new System.Drawing.Point(73, 104);
            this.epButton.Name = "epButton";
            this.epButton.Size = new System.Drawing.Size(167, 37);
            this.epButton.TabIndex = 13;
            this.epButton.Text = "Edit Password";
            this.epButton.UseVisualStyleBackColor = false;
            this.epButton.Click += new System.EventHandler(this.epButton_Click);
            // 
            // enButton
            // 
            this.enButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.enButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.enButton.Location = new System.Drawing.Point(73, 147);
            this.enButton.Name = "enButton";
            this.enButton.Size = new System.Drawing.Size(167, 37);
            this.enButton.TabIndex = 14;
            this.enButton.Text = "Edit Name";
            this.enButton.UseVisualStyleBackColor = false;
            this.enButton.Click += new System.EventHandler(this.enButton_Click);
            // 
            // edButton
            // 
            this.edButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.edButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.edButton.Location = new System.Drawing.Point(73, 190);
            this.edButton.Name = "edButton";
            this.edButton.Size = new System.Drawing.Size(167, 37);
            this.edButton.TabIndex = 15;
            this.edButton.Text = "Edit  perm";
            this.edButton.UseVisualStyleBackColor = false;
            this.edButton.Click += new System.EventHandler(this.edButton_Click);
            // 
            // duButton
            // 
            this.duButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.duButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.duButton.Location = new System.Drawing.Point(73, 233);
            this.duButton.Name = "duButton";
            this.duButton.Size = new System.Drawing.Size(167, 37);
            this.duButton.TabIndex = 16;
            this.duButton.Text = "Delete User";
            this.duButton.UseVisualStyleBackColor = false;
            this.duButton.Click += new System.EventHandler(this.duButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exitButton.Location = new System.Drawing.Point(73, 319);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(167, 37);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(305, 421);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.duButton);
            this.Controls.Add(this.edButton);
            this.Controls.Add(this.enButton);
            this.Controls.Add(this.epButton);
            this.Controls.Add(this.euButton);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editUser";
            this.Text = "editUser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button euButton;
        private System.Windows.Forms.Button epButton;
        private System.Windows.Forms.Button enButton;
        private System.Windows.Forms.Button edButton;
        private System.Windows.Forms.Button duButton;
        private System.Windows.Forms.Button exitButton;
    }
}