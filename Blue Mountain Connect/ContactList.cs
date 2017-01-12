using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace Blue_Mountain_Connect
{
    public partial class ContactList : MetroForm
    {
        public ContactList()
        {
            InitializeComponent();
        }

        MySqlDataAdapter myDA;
        DataTable myDT;


        //On Load
        private void ContactList_Load(object sender, EventArgs e)
        {
            try
            {
                //Connection String && Selection String
                string conn = "server=192.168.0.78;Port=3306;database=BMEContacts;uid=BMEadmin;Pwd=Admin1234!$;";
                string selectCompleted = "SELECT * FROM `Employees` Order by `Name` ASC";

                // Define Datatable
                myDT = new DataTable();
                
                //Data Adapterwith conn and select string
                myDA = new MySqlDataAdapter(selectCompleted, conn);
                
                //fill datatable
                myDA.Fill(myDT);
                
                //fill datatable with database schema
                myDA.FillSchema(myDT, SchemaType.Source);
                
                //bind datatable to datagrid
                metroGrid1.DataSource = myDT;
                
                //AutoSize all columns and rows for datagrid
                metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                metroGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            // catch exception
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
