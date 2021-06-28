using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123
{
    public partial class editUser : Form
    {
        public editUser()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void euButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new editusername().Show();
        }

        private void edButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new editperm().Show();
        }

        private void enButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new editname().Show();
        }

        private void epButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditPassord().Show();
        }

        private void duButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new deleteuser().Show();
        }
    }
}
