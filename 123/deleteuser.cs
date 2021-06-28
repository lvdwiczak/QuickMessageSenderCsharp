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
    public partial class deleteuser : Form
    {
        public deleteuser()
        {
            InitializeComponent();
        }

        private void Usernametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dButton_Click(object sender, EventArgs e)
        {
            SortedList<int, string> users = new SortedList<int, string>();
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\source\repos\123\123\Database1.mdf;Integrated Security=True");
            sql.Open();
            SqlCommand readerCommand = new SqlCommand("SELECT Id,username,hasAdminPerm,isValid FROM Users", sql);
            SqlCommand idCommand = new SqlCommand("UPDATE Users SET Id=@newIdadder WHERE username=@Usernameid", sql);
            SqlCommand deleteCommand = new SqlCommand("DELETE FROM Users WHERE Id=@cuid", sql);
            int userExistId = 0;
            bool userExist = false;
            using (SqlDataReader reader = readerCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    users.Add(int.Parse(reader["Id"].ToString()), reader["username"].ToString());
                }
            }
            foreach (KeyValuePair<int, string> pair in users)
            {
                if (pair.Value == usernametb.Text.ToString())
                {
                    userExist = true;
                    userExistId = pair.Key;
                }
            }
            if(userExist == true)
            {
                users.Remove(userExistId);
                deleteCommand.Parameters.AddWithValue("cuid", userExistId);
                deleteCommand.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("User deleted.", "User deleted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
