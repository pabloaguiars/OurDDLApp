using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace OurDDLApp
{
    public partial class frmMain : Form
    {
        //global class object for mysql connection
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand;
        private MySql.Data.MySqlClient.MySqlDataReader mySqlDataReader;
        private string Database;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Print log in label log
        /// </summary>
        /// <param name="log">log to print</param>
        public void ShowLog(string log)
        {
            lblLogs.Text = "";
            lblLogs.Text = log;
        }

        /// <summary>
        /// Check mysql connection status.
        /// </summary>
        /// <returns>Return true if connected, false if disconnected.</returns>
        public bool CheckConnectMySQL()
        {
            bool response = false;

            //if mysqlconnection states is open, return true
            if (mySqlConnection.State == ConnectionState.Open)
            {
                response = true;
                ShowLog("Connection status: Open.");
            } //else if mysqlconnection state is close, return false
            else if (mySqlConnection.State == ConnectionState.Closed)
            {
                response =  false;
                ShowLog("Connection status: Close.");
            }
            return response;
        }
        
        /// <summary>
        /// Connect and open connection to MySQL
        /// </summary> 
        public void ConnectMySQL()
        {
            //frmConnectDBMS instance
            frmConnectDBMS frmConnect = new frmConnectDBMS();

            //boolean to continue or not with connection attempts
            Boolean b = true;
            while (b)
            {
                //show form
                frmConnect.ShowDialog();
                //if dialogresult is ok, try connection
                if (frmConnect.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        //try connection
                        string connection = "";
                        connection = String.Format("server={0};port={1};user={2};password={3}", frmConnect.txtServer.Text, frmConnect.txtPort.Text, frmConnect.txtUsername.Text, frmConnect.txtPassword.Text);
                        connectToolStripMenuItem.Enabled = false;
                        disconnectToolStripMenuItem.Enabled = false;
                        mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connection);
                        //open connection
                        mySqlConnection.Open();
                        //if connection state is open
                        if (CheckConnectMySQL())
                        {
                            b = false;
                            connectToolStripMenuItem.Enabled = false;
                            disconnectToolStripMenuItem.Enabled = true;
                            GetAllMySQLData();
                        }
                    }
                    catch (Exception ex)
                    {
                        //exception thrown, show message
                        DialogResult dialog = MessageBox.Show("ERROR to connect: " + ex.ToString(), "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        //if dialogresult is cancel, stop attempts
                        if (dialog == DialogResult.Cancel)
                        {
                            //stop attempts
                            b = false;
                            connectToolStripMenuItem.Enabled = true;
                        } //else if dialogresult is retry, new attempt
                        else if (dialog == DialogResult.Retry)
                        {
                            //new attempt
                            b = true;
                        }
                    }
                }
                else if (frmConnect.DialogResult == DialogResult.Cancel)
                {
                    //stop attempts
                    b = false;
                    connectToolStripMenuItem.Enabled = true;
                    disconnectToolStripMenuItem.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Close connection to MySQL
        /// </summary>
        public void DisconnectMysql()
        {
            //close connection
            mySqlConnection.Close();
            //if connection state is close
            if (!CheckConnectMySQL())
            {
                connectToolStripMenuItem.Enabled = true;
                disconnectToolStripMenuItem.Enabled = false;
                tree.Nodes.Clear();
            }
        }

        public void GetAllMySQLData()
        {
            List<string> dataBases = new List<string>();
            try
            {
                if (CheckConnectMySQL())
                {
                    //Get all databases
                    mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand("SHOW DATABASES;", mySqlConnection);
                    mySqlDataReader = mySqlCommand.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
                        for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                        {
                            dataBases.Add(mySqlDataReader.GetValue(i).ToString());
                            tree.Nodes.Add(mySqlDataReader.GetValue(i).ToString());
                        }
                    }
                    mySqlDataReader.Close();

                    int c = 0;
                    //for each data base, get tables and add to tree
                    foreach (string db in dataBases)
                    {
                        //Use database
                        mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand("USE " + db + ";", mySqlConnection);
                        mySqlDataReader = mySqlCommand.ExecuteReader();
                        mySqlDataReader.Close();
                        //Get all tables
                        mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand("SHOW TABLES;", mySqlConnection);
                        mySqlDataReader = mySqlCommand.ExecuteReader();
                        while (mySqlDataReader.Read())
                        {
                            for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                            {
                                tree.Nodes[c].Nodes.Add(mySqlDataReader.GetValue(i).ToString());
                            }
                        }
                        mySqlDataReader.Close();
                        c++;
                    }
                }
            }
            catch (Exception ex)
            {
                //disconnect mysql
                //DisconnectMysql();
                //exception thrown, show message
                DialogResult dialog = MessageBox.Show("ERROR to extract data: " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectMySQL();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisconnectMysql();
        }

        private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode node = tree.SelectedNode;
            MessageBox.Show(string.Format("You selected: {0}", node.Text));
            useDatabase(node.Text);
        }

        public void useDatabase(string dataBase)
        {

            string useTable = "USE " + dataBase;
            try
            {
                mySqlCommand = new MySqlCommand(useTable, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                DialogResult dialog = MessageBox.Show("ERROR to extract data: " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void dropElement(string element,string elementName)
        {

            string useTable = "DROP " + element+" " + elementName;
            try
            {
                mySqlCommand = new MySqlCommand(useTable, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DialogResult dialog = MessageBox.Show("ERROR to extract data: " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void crateElement(string element, string elementName)
        {

            string useTable = "CREATE " + element + " " + elementName;
            try
            {
                mySqlCommand = new MySqlCommand(useTable, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DialogResult dialog = MessageBox.Show("ERROR to extract data: " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void createDatabase( string databaseName)
        {

            string useTable = "CREATE DATABASE "  + databaseName;
            try
            {
                mySqlCommand = new MySqlCommand(useTable, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DialogResult dialog = MessageBox.Show("ERROR to extract data: " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void tree_Click(object sender, EventArgs e)
        {
       
        }

        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tree_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = tree.SelectedNode;
            if (node.Parent != null)
            {
                node = node.Parent;
            }
            MessageBox.Show(string.Format("You selected: {0}", node.Text));
            useDatabase(node.Text);
            Database = node.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createDatabase("Pes");
        }
    }
}
