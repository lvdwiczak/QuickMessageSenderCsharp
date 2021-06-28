
namespace _123
{
    partial class deleteuser
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
            this.dButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.loginText = new System.Windows.Forms.Label();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // dButton
            // 
            this.dButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.dButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dButton.Location = new System.Drawing.Point(70, 148);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(167, 37);
            this.dButton.TabIndex = 32;
            this.dButton.Text = "Delete user";
            this.dButton.UseVisualStyleBackColor = false;
            this.dButton.Click += new System.EventHandler(this.dButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backButton.Location = new System.Drawing.Point(70, 320);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(167, 37);
            this.backButton.TabIndex = 31;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginText.Location = new System.Drawing.Point(30, 62);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(79, 16);
            this.loginText.TabIndex = 35;
            this.loginText.Text = "Username";
            // 
            // usernametb
            // 
            this.usernametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametb.Location = new System.Drawing.Point(33, 80);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(245, 22);
            this.usernametb.TabIndex = 34;
            this.usernametb.TextChanged += new System.EventHandler(this.Usernametb_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(33, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 2);
            this.panel1.TabIndex = 33;
            // 
            // deleteuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(305, 421);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dButton);
            this.Controls.Add(this.backButton);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deleteuser";
            this.Text = "deleteuser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.Panel panel1;
    }
}