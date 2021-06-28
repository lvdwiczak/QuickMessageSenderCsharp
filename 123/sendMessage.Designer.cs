
namespace _123
{
    partial class sendMessage
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
            this.smButton = new System.Windows.Forms.Button();
            this.loginText = new System.Windows.Forms.Label();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.messageTb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // smButton
            // 
            this.smButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.smButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smButton.Location = new System.Drawing.Point(70, 266);
            this.smButton.Name = "smButton";
            this.smButton.Size = new System.Drawing.Size(167, 37);
            this.smButton.TabIndex = 11;
            this.smButton.Text = "Send Message";
            this.smButton.UseVisualStyleBackColor = false;
            this.smButton.Click += new System.EventHandler(this.smButton_Click);
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginText.Location = new System.Drawing.Point(32, 45);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(46, 16);
            this.loginText.TabIndex = 14;
            this.loginText.Text = "Login";
            // 
            // loginTb
            // 
            this.loginTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTb.Location = new System.Drawing.Point(35, 63);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(245, 22);
            this.loginTb.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(35, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 2);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(32, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Message";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // messageTb
            // 
            this.messageTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTb.Location = new System.Drawing.Point(35, 124);
            this.messageTb.Name = "messageTb";
            this.messageTb.Size = new System.Drawing.Size(245, 22);
            this.messageTb.TabIndex = 16;
            this.messageTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(35, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 2);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // sendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(305, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.smButton);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sendMessage";
            this.Text = "sendMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button smButton;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox messageTb;
        private System.Windows.Forms.Panel panel2;
    }
}