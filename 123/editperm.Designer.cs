
namespace _123
{
    partial class editperm
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
            this.cButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.ValidCB = new System.Windows.Forms.CheckBox();
            this.AdminACB = new System.Windows.Forms.CheckBox();
            this.loginText = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cButton
            // 
            this.cButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.cButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cButton.Location = new System.Drawing.Point(69, 187);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(167, 37);
            this.cButton.TabIndex = 24;
            this.cButton.Text = "Change permission";
            this.cButton.UseVisualStyleBackColor = false;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backButton.Location = new System.Drawing.Point(69, 349);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(167, 37);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ValidCB
            // 
            this.ValidCB.AutoSize = true;
            this.ValidCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidCB.Location = new System.Drawing.Point(58, 138);
            this.ValidCB.Name = "ValidCB";
            this.ValidCB.Size = new System.Drawing.Size(89, 24);
            this.ValidCB.TabIndex = 26;
            this.ValidCB.Text = "Is Valid?";
            this.ValidCB.UseVisualStyleBackColor = true;
            // 
            // AdminACB
            // 
            this.AdminACB.AutoSize = true;
            this.AdminACB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminACB.Location = new System.Drawing.Point(58, 115);
            this.AdminACB.Name = "AdminACB";
            this.AdminACB.Size = new System.Drawing.Size(184, 24);
            this.AdminACB.TabIndex = 25;
            this.AdminACB.Text = "Is an Admin Account?";
            this.AdminACB.UseVisualStyleBackColor = true;
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginText.Location = new System.Drawing.Point(29, 63);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(79, 16);
            this.loginText.TabIndex = 29;
            this.loginText.Text = "Username";
            // 
            // usernameTb
            // 
            this.usernameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.Location = new System.Drawing.Point(32, 81);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(245, 22);
            this.usernameTb.TabIndex = 28;
            this.usernameTb.TextChanged += new System.EventHandler(this.usernameTb_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(32, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 2);
            this.panel1.TabIndex = 27;
            // 
            // editperm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(305, 421);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ValidCB);
            this.Controls.Add(this.AdminACB);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.backButton);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editperm";
            this.Text = "editperm";
            this.Load += new System.EventHandler(this.editperm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.CheckBox ValidCB;
        private System.Windows.Forms.CheckBox AdminACB;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Panel panel1;
    }
}