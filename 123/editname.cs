using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _123
{
    public partial class editname : Form
    {
        public editname()
        {
            InitializeComponent();
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            string usernameChange = "";
            bool usernameExist = false;
            bool newusernameexist = false;
            SortedList<string, string> usernames = new SortedList<string, string>();
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\source\repos\123\123\Database1.mdf;Integrated Security=True");
            sql.Open();
            SqlCommand readerCommand = new SqlCommand("SELECT Id,username,name FROM Users", sql);
            SqlCommand updateCommand = new SqlCommand("UPDATE Users SET name=@newname WHERE username=@cuun", sql);
            using (SqlDataReader reader = readerCommand.ExecuteReader())
            {
                while (reader.Read())
                    usernames.Add(reader["username"].ToString(), reader["name"].ToString());
            }
            foreach (KeyValuePair<string, string> pair in usernames)
            {
                if (pair.Value.ToUpper() == Usernametb.Text.ToString().ToUpper())
                {
                    usernameChange = pair.Key;
                    usernameExist = true;
                    break;
                }
            }
            if (usernameExist == false)
            {
                MessageBox.Show("Name does not exist", "Name changed failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (newnameTB.Text.Length == 0)
            {
                MessageBox.Show("New Name textbox is empty.", "Name changed failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newusernameexist = false;
            }
            else { newusernameexist = true; }
            if (usernameExist == true && newusernameexist == true)
            {
                updateCommand.Parameters.AddWithValue("newname", newnameTB.Text.ToString());
                updateCommand.Parameters.AddWithValue("cuun", usernameChange);
                updateCommand.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Name changed.", "Name changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new AdminPanel().Show();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanel().Show();
        }
    }
}

