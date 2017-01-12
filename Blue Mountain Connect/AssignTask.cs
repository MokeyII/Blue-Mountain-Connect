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
using MetroFramework.Forms;
using MetroFramework;

namespace Blue_Mountain_Connect
{
    public partial class AssignTask : MetroForm
    {
        public AssignTask()
        {
            InitializeComponent();
        }
        // MySql Connection String
        MySqlConnection conn = new MySqlConnection("server=192.168.0.78;Port=3306;database=BMEConnect;uid=BMEadmin;Pwd=Admin1234!$;");

        //On Load
        private void AssignTask_Load(object sender, EventArgs e)
        {
            //Create Tooltip
            ToolTip ttBrowseDiag = new ToolTip();

            // Set up the delays for the ToolTip.
            ttBrowseDiag.AutoPopDelay = 5000;
            ttBrowseDiag.InitialDelay = 1000;
            ttBrowseDiag.ReshowDelay = 500;
            
            // Force the ToolTip text to be displayed whether or not the form is active.
            ttBrowseDiag.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            ttBrowseDiag.SetToolTip(this.metroBtnBrowseDir, "Click this button to select a folder Directory.");

            try
            {
                // Select String
                string selectQuery = "SELECT * FROM BMEConnect.department ORDER by `department` ASC";
                
                //Open Connection
                conn.Open();
                
                //Command with Select String and Connection String
                MySqlCommand command = new MySqlCommand(selectQuery, conn);
                
                //Execute Reader
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {   
                    //Read String in Department ComboBox
                    metroCmbDepartment.Items.Add(reader.GetString("department"));
                }

                //Close Connection
                conn.Close();
            }
            //Catch Exception
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroBtnSubmitTask_Click(object sender, EventArgs e)
        {
            try
            {
                //Selection String
                string Query = "INSERT INTO BMEConnect.tasks (Name, TaskName, StartDate, EndDate, TaskDescription, DirectoryPath, Completed) VALUES (?Name, ?TaskName, ?StartDate, ?EndDate, ?TaskDescription, ?DirectoryPath, ?Completed);";
                
                //Command with Select String and Connection String
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                
                //Open Connection to Database
                conn.Open();

                //Parameters for Query
                cmd.Parameters.AddWithValue("?Name", metroCmbName.Text);
                cmd.Parameters.AddWithValue("?TaskName", metroTxtTaskName.Text);
                cmd.Parameters.AddWithValue("?StartDate", metroTxtDateStart.Value.ToString("yyyy-M-d"));
                cmd.Parameters.AddWithValue("?EndDate", metroTxtEndDate.Value.ToString("yyyy-M-d"));
                cmd.Parameters.AddWithValue("?TaskDescription", metroTxtTaskDescription.Text);
                cmd.Parameters.AddWithValue("?DirectoryPath", metroTxtBrowserDirectory.Text);
                cmd.Parameters.AddWithValue("?Completed", ("0"));
                
                //Execute NonQuery
                cmd.ExecuteNonQuery();
                
                //Close Connection to Database
                conn.Close();

                //Show Task Assigned Submitted
                MetroMessageBox.Show(this,"Task Assignment Submitted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                
                //Clear Previous Entries after "OK" Button from MetroMessageBox
                metroTxtTaskName.Clear();
                metroTxtTaskDescription.Clear();
                metroTxtBrowserDirectory.Clear();
            }
            //Catch Exception
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroCmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear Names from Name Combo Box, w/o this, names will duplicate in combobox
            metroCmbName.Items.Clear();
            try
            {
                // select string
                string selectQuery = "SELECT `name` FROM `employees` WHERE `department` = @department";
                
                //Open connection to database
                conn.Open();
                
                //Command with Select String and Connection String
                MySqlCommand command = new MySqlCommand(selectQuery, conn);
                
                //Add Parameters for Sql Query from combobox
                command.Parameters.AddWithValue("@department", metroCmbDepartment.Text);
                
                // Execute DataReader
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //get Name from ComboBox (String)
                    metroCmbName.Items.Add(reader.GetString("name"));
                }
                //Close Connection
                conn.Close();
            }
            //catch exception
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroBtnBrowseDir_Click(object sender, EventArgs e)
        {
            //Show Folder Browser Dialog Box on Click
            DialogResult btnFolderDir_Click = folderBrowserDialog1.ShowDialog();
            if (btnFolderDir_Click == DialogResult.OK)
            {
                //Clear Dir Text Box if new directory is selected.
                metroTxtBrowserDirectory.Clear();
            
                //Convert selection of FBD to string
                string[] files = System.IO.Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                
                //Put string into textbox
                metroTxtBrowserDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
