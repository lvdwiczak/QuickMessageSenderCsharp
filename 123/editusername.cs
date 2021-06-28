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
    public partial class editusername : Form
    {
        public editusername()
        {
            InitializeComponent();
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            int usernameChangeId=0;
            bool usernameExist = false;
            bool newusernameexist = false;
            SortedList<int, string> usernames = new SortedList<int, string>();
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\source\repos\123\123\Database1.mdf;Integrated Security=True");
            sql.Open();
            SqlCommand readerCommand = new SqlCommand("SELECT Id,username FROM Users",sql);
            SqlCommand updateCommand = new SqlCommand("UPDATE Users SET username=@newusername WHERE Id=@cuid",sql);
            using(SqlDataReader reader = readerCommand.ExecuteReader())
            {
                while(reader.Read())
                usernames.Add(int.Parse(reader["Id"].ToString()),reader["username"].ToString());
            }
            foreach (KeyValuePair<int, string> pair in usernames)
            {
                if (pair.Value.ToUpper() == oldUsername.Text.ToString().ToUpper())
                {
                    usernameChangeId = pair.Key;
                    usernameExist = true;
                    break;
                }
            }
            if (usernameExist == false)
            {
                MessageBox.Show("Username does not exist", "Username changed failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(newUsername.Text.Length == 0 )
            {
                MessageBox.Show("New username textbox is empty.", "Username changed failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newusernameexist = false;
            }
            else { newusernameexist = true; }
            if(usernameExist == true && newusernameexist == true)
            {
                updateCommand.Parameters.AddWithValue("newusername", newUsername.Text.ToString());
                updateCommand.Parameters.AddWithValue("cuid", usernameChangeId);
                updateCommand.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Username changed.", "Username changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
