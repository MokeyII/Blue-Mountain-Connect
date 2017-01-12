using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Threading;
using MetroFramework;
using System.Diagnostics;


//Using Github
namespace Blue_Mountain_Connect
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            //For Splash Screen
            //New Thread

            //test
            Thread tThread = new Thread(new ThreadStart(SplashStart));
            //Start Thread
            tThread.Start();
            //Sleep Thread
            Thread.Sleep(5000);

            InitializeComponent();

            //Abort Thread
            tThread.Abort();
            
        }

        public void SplashStart()
        {
            Application.Run(new Splash());
        }

        //Click Time Button
        private void btnTileClickTime_Click(object sender, EventArgs e)
        {
            //Open In App WebBrowser
            Browser fClickTimeModule = new Browser();
            fClickTimeModule.Show();
        }
        //
        //Need to find a better way to launch a nested application or something.
        //
            //Chat Button
        private void btnTileChat_Click(object sender, EventArgs e)
        {
            //Set Success as a false Boolean
            bool success = false;
            try
            {
                //Open Chat 
                System.Diagnostics.Process.Start("C:/Program Files (8x6)/Spark/Spark.exe");
                success = true;                
            }
            catch (Exception ex)
            {
                //Catch Exception Error
                MetroMessageBox.Show(this, ex.Message, "APPLICATION LAUNCH ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //If application Launches
                if(success)
                {
                    MetroMessageBox.Show(this, "Spark Chat Application Has Been Launched\n\n You can access the chat in your task bar.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //If Application cannot launch, after Exception Message, for a more user friendly trouble shoot.
                if (success == false)
                {
                    MetroMessageBox.Show(this, "Please Ensure The Spark Chat Client Is Installed In The Proper Directory:\n\n C:/Program Files (x86)/Spark/Spark.exe","IS SPARK IN THE PROPER DIRECTORY?", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    //Do Nothing
                }
            }
            
        }

            //Tasks Button
        private void btnTileTasks_Click(object sender, EventArgs e)
        {
                //Open Tasks
            BMETasks fTasksModule = new BMETasks();
            fTasksModule.Show();
        }

            // Contacts Button
        private void btnTileContacts_Click(object sender, EventArgs e)
        {
                //Open Contact List
            ContactList fContactList = new ContactList();
            fContactList.Show();
        }
   }
}