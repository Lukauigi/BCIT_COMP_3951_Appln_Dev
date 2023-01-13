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

/// <summary>
/// Lab 8 - Design and implement a local DB with ADO.NET on a .NET windows application.
/// Author: Lukasz Bednarek
/// Date: April 2, 2022
/// </summary>
namespace A01206494Lab8
{
    /// <summary>
    /// Form to display local database data.
    /// </summary>
    public partial class MainForm : Form
    {

        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        /// <summary>
        /// Initializes the MainForm component.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets datagrid properties and calls upon data from local database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridCustomers.AutoGenerateColumns = true;
            dataGridCustomers.DataSource = customerDBDataSetBindingSource;
            GetData("select * from Customers");
        }

        /// <summary>
        /// Fills a table with data and command from the local database.
        /// </summary>
        /// <param name="command"></param>
        private void GetData(string command)
        {
            try
            {
                String connection = " Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CustomerDB.mdf;Integrated Security=True";

                dataAdapter = new SqlDataAdapter(command, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                customerDBDataSetBindingSource.DataSource = table.DefaultView;

                dataGridCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            } 
            catch (SqlException)
            {
                MessageBox.Show("Verify if the connectionString is correct");
            }
        }
    }
}
