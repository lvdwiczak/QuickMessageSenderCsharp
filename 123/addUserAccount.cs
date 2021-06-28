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
    public partial class addUserAccount : Form
    {
        public addUserAccount()
        {
            InitializeComponent();
        }

        private void loginText_Click(object sender, EventArgs e)
        {

        }

        private void auButton_Click(object sender, EventArgs e)
        {
            List<string> IDs = new List<string>();
            List<string> Nicknames = new List<string>();
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\source\repos\123\123\Database1.mdf;Integrated Security=True");
            sql.Open();
            SqlCommand readerCommand = new SqlCommand("SELECT Id, username FROM Users", sql);
            using (SqlDataReader reader = readerCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDs.Add(reader["Id"].ToString());
                    Nicknames.Add(reader["username"].ToString());
                }
            }
            string cmdString = "INSERT INTO Users (Id,username,password,name,hasAdminPerm,isValid) VALUES (@id,@var1, @var2, @var3, @var4, @var5)";
            using (SqlCommand comm = new SqlCommand(cmdString))
            {
                bool usernameExist = false;
                bool passwordLength = false;
                bool doesNameExist = false;
                bool loginLenght = false;
                for (int i = 0; i < Nicknames.Count - 1; i++)
                {
                    if (loginTb.Text.Equals(Nicknames[i]))
                    {
                        MessageBox.Show("Username exist, Please change username", "User not added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usernameExist = true;
                    }
                }
                if (loginTb.Text.Length < 3 || loginTb.Text.Length >12)
                {
                    MessageBox.Show("Username need 3 char length and max 12 length", "User not added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginLenght = false;
                }
                else { loginLenght = true; }
                if (passwdTB.Text.Length < 6 || passwdTB.Text.Length >12 && usernameExist == false)
                {
                    MessageBox.Show("Password need 6 char length", "User not added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordLength = true;
                }
                if (nameTB.Text.Length == 0 && usernameExist == false && passwordLength == false)
                {
                    MessageBox.Show("Add name of your user", "User not added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    doesNameExist = false;
                }
                else { doesNameExist = true; }
                if (usernameExist == false && passwordLength == false && doesNameExist == true && loginLenght == true)
                {
                    comm.Connection = sql;
                    comm.Parameters.AddWithValue("@Id", IDs.Count);
                    comm.Parameters.AddWithValue("@var1", loginTb.Text);
                    comm.Parameters.AddWithValue("@var2", passwdTB.Text);
                    comm.Parameters.AddWithValue("@var3", nameTB.Text);
                    if (AdminACB.Checked)
                    {
                        comm.Parameters.AddWithValue("@var4", true);
                    }
                    else { comm.Parameters.AddWithValue("@var4", false); }
                    if (ValidCB.Checked)
                    {
                        comm.Parameters.AddWithValue("@var5", true);
                    }
                    else { comm.Parameters.AddWithValue("@var5", false); }
                    comm.ExecuteNonQuery();
                    sql.Close();
                    MessageBox.Show("User Added", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new AdminPanel().Show();
                }
            }
        }
    }
}
