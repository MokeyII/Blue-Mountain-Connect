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
using System.Web;
using MetroFramework.Forms;
using MetroFramework;

namespace Blue_Mountain_Connect
{
    public partial class BMETasks : MetroForm
    {
        public BMETasks()
        {
            InitializeComponent();
        }

        //(Scopes) PEW PEW
        MySqlDataAdapter myDA;
        DataTable myDT;
        //Connection String
        MySqlConnection conn = new MySqlConnection("server=192.168.0.78;Port=3306;database=BMEConnect;uid=BMEadmin;Pwd=Admin1234!$;");

        //Method to populate Datagrid with Information
        void zPopulateGrid()
        {
            try
            {
                //Selection String
                string selectCompleted = "SELECT * FROM `tasks` WHERE `Name` = @Name AND `Completed` = 0";

                //DataAdapter
                myDA = new MySqlDataAdapter(selectCompleted, conn);

                //MySqlCommand
                MySqlCommand myCMD = new MySqlCommand(selectCompleted, conn);

                //Selection Parameters
                myCMD.Parameters.AddWithValue("@Name", cmbName.Text);

                //DataAdapter to Command
                myDA.SelectCommand = myCMD;

                //Define Datatable
                myDT = new DataTable();

                //Command Builder (IS GOD!)
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDA);

                //Teach Command builder to be a boss!
                myDA.UpdateCommand = cb.GetUpdateCommand();
                myDA.InsertCommand = cb.GetInsertCommand();
                myDA.DeleteCommand = cb.GetDeleteCommand();

                //Fill the DataTable with DataAdapter information
                myDA.Fill(myDT);

                //Fill DataTable with Database Schema
                myDA.FillSchema(myDT, SchemaType.Source);

                //Bind The Data Table to the DataGrid
                metroGrid1.DataSource = myDT;

                //AutoSize Datagrid Rows and Colums to fit the Datagrid
                metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                metroGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            //Catch Exception
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //On Form Load
        private void BMETasks_Load(object sender, EventArgs e)
        {
            try
            {
                //Selection string
                string selectQuery = "SELECT * FROM BMEConnect.department ORDER by `department` ASC";
               
                //Open Connection
                conn.Open();
                
                //Command
                MySqlCommand command = new MySqlCommand(selectQuery, conn);
                
                //Datareader Execute with connection and slection
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Read from Department Dropdown box
                    cmbDepartment.Items.Add(reader.GetString("department"));
                }
                
                //Close COnnection
                conn.Close();
            }
            //Catch Exception
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Update Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update Datagrid on update button
            int rows = myDA.Update(myDT);
            
            //Repopulate Datagrid
            zPopulateGrid();
        }

        //ComboBox "Depatment" Selection change
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear names in combobox to stop duplication of names when selecting departments
            cmbName.Items.Clear();
            try
            {
                //Selection String
                string selectQuery = "SELECT `name` FROM `employees` WHERE `department` = @department";
            
                //Open Connection
                conn.Open();
                
                //Command with select and conn string
                MySqlCommand command = new MySqlCommand(selectQuery, conn);
                
                //Parameter for Department
                command.Parameters.AddWithValue("@department", cmbDepartment.Text);
                
                // Data Reader
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Get name from combobox
                    cmbName.Items.Add(reader.GetString("name"));
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

        // Combo Box "Name" Selection Change
        private void cmbName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Populate DataGrid
            zPopulateGrid();
        }

        //Assign Task Button
        private void metroLink1_Click(object sender, EventArgs e)
        {
            //Show Login...
            Login fLogin = new Login();
            fLogin.Show();
        }
    }
}