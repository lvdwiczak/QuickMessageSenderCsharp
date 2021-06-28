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
    public partial class QuickMessageSender : Form
    {
        public QuickMessageSender()
        {
            InitializeComponent();
        }

        private void QuickMessageSender_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\source\repos\123\123\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Users WHERE username='" + loginTb.Text.Trim() + "' AND password='" + PasswordTb.Text.Trim() + "'", con);
            DataSet dt = new DataSet(); 
            sda.Fill(dt);
            string hasAdminPermission = "";
            string isValidNow="";
            if (dt.Tables[0].Rows.Count == 1)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE username='" + loginTb.Text.Trim() + "' AND password='" + PasswordTb.Text.Trim() + "'",con);
                    using(SqlDataReader reader = cmd.ExecuteReader() )
                    { 
                        while(reader.Read())
                        {
                        hasAdminPermission = reader["hasAdminPerm"].ToString();
                        isValidNow = reader["isValid"].ToString();
                        if (hasAdminPermission.Equals("True") && isValidNow.Equals("True"))
                        {
                            this.Hide();
                            new AdminPanel().Show();
                        }
                        else if(isValidNow.Equals("True"))
                        {
                            this.Hide();
                            new UserPanel().Show();
                        }
                        else
                        {
                            MessageBox.Show("Your account is deactivated", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        }
                    }
            }
            else
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            con.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showpasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswordCheckbox.Checked)
            {
                PasswordTb.PasswordChar = '\0';
            }
            else
            {
                PasswordTb.PasswordChar = '*';
            }
        }
    }
}
