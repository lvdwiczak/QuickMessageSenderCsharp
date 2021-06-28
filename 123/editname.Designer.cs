
namespace _123
{
    partial class editname
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
            this.loginText = new System.Windows.Forms.Label();
            this.Usernametb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.newnameTB = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cButton
            // 
            this.cButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.cButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cButton.Location = new System.Drawing.Point(69, 167);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(167, 37);
            this.cButton.TabIndex = 30;
            this.cButton.Text = "Change name";
            this.cButton.UseVisualStyleBackColor = false;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backButton.Location = new System.Drawing.Point(69, 339);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(167, 37);
            this.backButton.TabIndex = 29;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginText.Location = new System.Drawing.Point(28, 45);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(79, 16);
            this.loginText.TabIndex = 25;
            this.loginText.Text = "Username";
            // 
            // Usernametb
            // 
            this.Usernametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usernametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametb.Location = new System.Drawing.Point(31, 63);
            this.Usernametb.Name = "Usernametb";
            this.Usernametb.Size = new System.Drawing.Size(245, 22);
            this.Usernametb.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(31, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 2);
            this.panel1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "New name";
            // 
            // newnameTB
            // 
            this.newnameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newnameTB.Location = new System.Drawing.Point(31, 123);
            this.newnameTB.Name = "newnameTB";
            this.newnameTB.Size = new System.Drawing.Size(245, 22);
            this.newnameTB.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(31, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 2);
            this.panel3.TabIndex = 31;
            // 
            // editname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(305, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newnameTB);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.Usernametb);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editname";
            this.Text = "editname";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.TextBox Usernametb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newnameTB;
        private System.Windows.Forms.Panel panel3;
    }
}