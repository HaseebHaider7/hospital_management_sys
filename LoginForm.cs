using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class LoginForm : Form
    {
        private MySqlConnection con;
        private string server;
        private string database;
        private string uid;
        private string pass;

        private string username;
        private string password;

        

        public LoginForm()
        {
            InitializeComponent();
            server = "localhost";
            database = "smc_database";
            uid = "root";
            pass = "3329992075i";

            string connString;

            connString = $"SERVER = {server}; DATABASE = {database}; UID = {uid} ;PASSWORD = {pass};";

            con = new MySqlConnection(connString);
            textBoxuser.AutoSize = false;
            textBoxPassword.AutoSize = false;
            textBoxuser.Size = new Size(221, 35);
            textBoxPassword.Size = new Size(221, 35);

        }

      

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
            

        }

        private void LoginFormEnterButton_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            username = textBoxuser.Text;
            password = textBoxPassword.Text;

            if (isLogin(username, password))
            {
                
                textBoxuser.Text = "";
                textBoxPassword.Text = "";
                this.Close();
                
            }
            else
            {
                textBoxuser.Text = "";
                textBoxPassword.Text = "";

                MessageBox.Show(username + " does not exist or password is inccorect!!");
            }
        }
        private bool isLogin(string user, string pass)
        {
            string selectQuery = "SELECT * FROM smc_database.accounts WHERE username = '" + user + "' AND password = '" + pass + "'";

            try
            {
                if (openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if(reader.Read())
                    {
                        reader.Close();
                        con.Close();
                        return true;

                    }
                    else
                    {
                        reader.Close();
                        con.Close();
                        return false;
                    }
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            catch(Exception)
            {
                con.Close();
                return false;
            }
        }

       

        private bool openConnection()
        {
            try
            {
                con.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server failed");
                        break;

                    case 1045:
                        MessageBox.Show("Server username or password incorrect");
                        break;
                }
                return false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
