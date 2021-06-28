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
    public partial class EditPassord : Form
    {
        public EditPassord()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanel().Show();
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            SortedList<int, string> usernames = new SortedList<int, string>();
            SortedList<string, string> passwords = new SortedList<string, string>();
            string changePasswordUsername = "";
            bool usernameExist = false;
            bool passwordExist = false;
            bool newpasswordExist = false;
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\source\repos\123\123\Database1.mdf;Integrated Security=True");
            sql.Open();
            SqlCommand readerCommand = new SqlCommand("SELECT Id,username,password FROM Users", sql);
            SqlCommand UpdateCommand = new SqlCommand("UPDATE Users SET password=@newPassword WHERE username=@cpid", sql);
            using (SqlDataReader reader = readerCommand.ExecuteReader())
            {
                while(reader.Read())
                {
                    usernames.Add( int.Parse( reader["Id"].ToString() ), reader["username"].ToString() );
                    passwords.Add(reader["username"].ToString(), reader["password"].ToString());
                }
            }
            foreach(KeyValuePair<int,string> pair in usernames)
            {
                if(pair.Value.ToUpper() == login.Text.ToString().ToUpper())
                {
                    usernameExist = true;
                }
            }
            if(usernameExist == false)
            {
                MessageBox.Show("Username does not exist", "Password changed failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
            foreach (KeyValuePair<string, string> pair in passwords)
            {
                if (pair.Value.ToUpper() == oldPassword.Text.ToString().ToUpper())
                {
                    passwordExist = true;
                    changePasswordUsername = pair.Key;
                }
            }
            if (passwordExist == false)
            {
                MessageBox.Show("Old password is wrong", "Password changed failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(newPassword.Text.Length < 0)
            {
                newpasswordExist = false;
                MessageBox.Show("New password need 6 char length", "Password changed failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { newpasswordExist = true; }
                if (usernameExist == true && passwordExist == true && newpasswordExist == true)
                {
                    UpdateCommand.Parameters.AddWithValue("newPassword", newPassword.Text.ToString());
                    UpdateCommand.Parameters.AddWithValue("cpid", changePasswordUsername);
                    UpdateCommand.ExecuteNonQuery();
                    sql.Close();
                    MessageBox.Show("Password changed", "Password changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new AdminPanel().Show();
                }
            }
        }
    }
}
