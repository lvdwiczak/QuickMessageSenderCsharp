
namespace _123
{
    partial class UserPanel
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
            this.exitButton = new System.Windows.Forms.Button();
            this.RMbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exitButton.Location = new System.Drawing.Point(82, 398);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(167, 37);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // RMbutton
            // 
            this.RMbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.RMbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RMbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RMbutton.Location = new System.Drawing.Point(82, 319);
            this.RMbutton.Name = "RMbutton";
            this.RMbutton.Size = new System.Drawing.Size(167, 37);
            this.RMbutton.TabIndex = 10;
            this.RMbutton.Text = "Read Message";
            this.RMbutton.UseVisualStyleBackColor = false;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(321, 460);
            this.Controls.Add(this.RMbutton);
            this.Controls.Add(this.exitButton);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button RMbutton;
    }
}