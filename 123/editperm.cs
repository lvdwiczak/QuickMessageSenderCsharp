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
    public partial class editperm : Form
    {
        public editperm()
        {
            InitializeComponent();
        }

        private void editperm_Load(object sender, EventArgs e)
        {

        }

        private void cButton_Click(object sender, EventArgs e)
        {
            SortedList<int, string> users = new SortedList<int, string>();
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\source\repos\123\123\Database1.mdf;Integrated Security=True");
            sql.Open();
            SqlCommand readerCommand = new SqlCommand("SELECT Id,username,hasAdminPerm,isValid FROM Users", sql);
            SqlCommand updateCommand = new SqlCommand("UPDATE Users SET hasAdminPerm=@adminperm, isValid=@isvalid WHERE Id=@cuun", sql);
            bool adminperm = false;
            bool isvalid = false;
            bool userExist = false;
            int userExistId = 0;
            if(AdminACB.Checked)
            {
                adminperm = true;
            }
            if(ValidCB.Checked)
            {
                isvalid = true;
            }
            using(SqlDataReader reader = readerCommand.ExecuteReader())
            {
                while(reader.Read())
                {
                    users.Add(int.Parse(reader["Id"].ToString()), reader["username"].ToString());
                }
            }
            foreach(KeyValuePair<int,string> pair in users)
            {
                if(pair.Value == usernameTb.Text.ToString())
                {
                    userExist = true;
                    userExistId = pair.Key;
                }
            }
            if(userExist == false)
            {
                MessageBox.Show("Username does not exist", "Permission changed failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("adminperm", adminperm);
                updateCommand.Parameters.AddWithValue("isvalid", isvalid);
                updateCommand.Parameters.AddWithValue("cuun", userExistId);
                updateCommand.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Permission changed.", "Perm changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new AdminPanel().Show();
            }


        }

        private void usernameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanel().Show();
        }
    }
}
