using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using MetroFramework;

namespace Blue_Mountain_Connect
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        //Login Button
        private void metroBtnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                //Connection String
                MySqlConnection conn = new MySqlConnection("server=192.168.0.78;Port=3306;database=BMEConnect;uid=BMEadmin;Pwd=Admin1234!$;");

                //Select String
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM BMEConnect.credentials WHERE Username=@Username AND Password=@Password", conn);

                Credentials logIn = new Credentials();

                String hashedPassword = logIn.GenHash(metroTxtPassword.Text, logIn.salt);

                //Parameters
                cmd.Parameters.AddWithValue("@Username", metroTxtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);

                // Define DataReader
                MySqlDataReader myReader;

                //Open Connection
                conn.Open();

                //Execute DataReader
                myReader = cmd.ExecuteReader();

                //Login 
                //Count = 0
                int count = 0;
                while (myReader.Read())
                {
                    //If Reader reads Line +1 to count
                    count = count + 1;
                }
                if (count == 1)
                {
                    //If the count == 1 then 
                    //Show Assign Task 
                    AssignTask fAssignTask = new AssignTask();
                    fAssignTask.Show();
                    this.Hide();
                }
                else
                {
                    //If Count doesn't == 1 then show

                    //Incorrect login Credentials
                    MetroMessageBox.Show(this, "Incorrect Username or Password! Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Refocus Username TxtBox, makes user interface easier
                    metroTxtUsername.Focus();
                }
            }
            //Catch Exception
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Username Click
        private void metroTxtUsername_Click(object sender, EventArgs e)
        {
            //Clear Username and Password Text Box
            metroTxtUsername.Clear();
            metroTxtPassword.Clear();
        }

        //Password Click
        private void metroTxtPassword_Click(object sender, EventArgs e)
        {
            //Clear Password Box
            metroTxtPassword.Clear();
        }

        //Password Keypress event
        private void metroTxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If Keypress on Password (Enter)
            if (e.KeyChar == (char)13)
            {
                //Click Submit button
                metroBtnLogin.PerformClick();
            }
        }

        //Username keypress event
        private void metroTxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If Keypress on Password (Enter)
            if (e.KeyChar == (char)13)
            {
                //Click submit button
                metroBtnLogin.PerformClick();
            }
        }

    }
}
