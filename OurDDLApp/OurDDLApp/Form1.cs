﻿using System;
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
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new MySqlConnection();
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand;
        private MySql.Data.MySqlClient.MySqlDataReader mySqlDataReader;
        private string Database;

        private string currentElementType = ""; //save the current type on tree view e.g. server, database, table, field
        private string currentElementName = ""; //save the name of the current object on tree view e.g. database name or table name
        private string currentSelectedElementType = ""; //save the current selected type selected on tree view e.g. server, database, table, field
        private string currentSelectedElementName = ""; //save the name of the current object seleted on tree view e.g. database name or table name
        private Dictionary<string, string> wayToElement = new Dictionary<string, string>(); //save the way to the current object server, database, table, field

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelWelcome.Location = new Point(171, 56);
            wayToElement.Add("server", "");
            wayToElement.Add("database", "");
            wayToElement.Add("table", "");
            wayToElement.Add("field", "");
            lblCurrentElementTreeView.Text = "";
            lblCurrentSelectedElementTreeView.Text = "";
            txtLogs.Text = DateTime.Now.ToString() + " " + "Ready to Connect";
            btnGoBackTreeView.Enabled = false;
            btnGoBackTreeView.Visible = false;
            btnConnectDisconnectMySQL.Focus();
        }

        /// <summary>
        /// Print log in label log
        /// </summary>
        /// <param name="log">log to print</param>
        public void ShowLog(string log)
        {

            txtLogs.Text += System.Environment.NewLine + DateTime.Now.ToString() + " " + log;
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
                        //change view
                        btnConnectDisconnectMySQL.Enabled = false;
                        //create connection
                        mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connection);
                        //open connection
                        mySqlConnection.Open();
                        //if connection state is open
                        if (CheckConnectMySQL())
                        {
                            b = false;
                            btnConnectDisconnectMySQL.Text = "Disconnect";
                            btnConnectDisconnectMySQL.Enabled = true;
                            //save name and typer current element
                            wayToElement["server"] = frmConnect.txtServer.Text;
                            currentElementName = frmConnect.txtServer.Text;
                            currentElementType = "server";
                            //get and put data in treeView
                            PutDataInTreeView();
                            //enable btn go back
                            btnGoBackTreeView.Enabled = true;
                            btnGoBackTreeView.Visible = true;
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
                            btnConnectDisconnectMySQL.Text = "Connect";
                            btnConnectDisconnectMySQL.Enabled = true;
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
                    panelWelcome.Visible = true;
                    panelHome.Visible = false;
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
                btnConnectDisconnectMySQL.Text = "Connect";
                btnGoBackTreeView.Enabled = false;
                btnGoBackTreeView.Visible = false;
                lblCurrentElementTreeView.Text = "";
                wayToElement["server"] = "";
                wayToElement["database"] = "";
                wayToElement["table"] = "";
                wayToElement["field"] = "";
                currentElementName = "";
                currentElementType = "";
                currentSelectedElementName = "";
                currentSelectedElementType = "";
                treeView.Nodes.Clear();
            }
        }

        /// <summary>
        /// Print node's child.
        /// </summary>
        private void PutDataInTreeView()
        {
            try
            {
                if (CheckConnectMySQL())
                {
                    if (currentElementType == "server")
                    {
                        treeView.Nodes.Clear();
                        //Get all databases
                        List<string> databases = new List<string>();
                        mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand("SHOW DATABASES;", mySqlConnection);
                        mySqlDataReader = mySqlCommand.ExecuteReader();
                        ShowLog("Query: SHOW DATABASES;");
                        while (mySqlDataReader.Read())
                        {
                            for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                            {
                                treeView.Nodes.Add(mySqlDataReader.GetValue(i).ToString());
                            }
                        }
                        mySqlDataReader.Close();
                        PutCurrentElementTreeView();
                        PutCurrentElementSelectedTreeView();
                    }
                    else if (currentElementType == "database")
                    {
                        treeView.Nodes.Clear();
                        //Use database
                        mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand("USE " + wayToElement["database"] + ";", mySqlConnection);
                        mySqlDataReader = mySqlCommand.ExecuteReader();
                        ShowLog("Query: USE " + wayToElement["database"] + ";");
                        mySqlDataReader.Close();
                        //Get all tables
                        mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand("SHOW TABLES;", mySqlConnection);
                        mySqlDataReader = mySqlCommand.ExecuteReader();
                        ShowLog("Query: SHOW TABLES;");
                        while (mySqlDataReader.Read())
                        {
                            for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                            {
                                treeView.Nodes.Add(mySqlDataReader.GetValue(i).ToString());
                            }
                        }
                        mySqlDataReader.Close();
                        PutCurrentElementTreeView();
                        PutCurrentElementSelectedTreeView();
                    }
                    else if (currentElementType == "table")
                    {
                        treeView.Nodes.Clear();
                        //Get all fields
                        mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand("SELECT column_name FROM information_schema.columns WHERE table_schema = database() AND table_name = '" + wayToElement["table"] + "';", mySqlConnection);
                        mySqlDataReader = mySqlCommand.ExecuteReader();
                        ShowLog("Query: SELECT column_name FROM information_schema.columns WHERE table_schema = database() AND table_name = '" + wayToElement["table"] + "';");
                        while (mySqlDataReader.Read())
                        {
                            for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                            {
                                treeView.Nodes.Add(mySqlDataReader.GetValue(i).ToString());
                            }
                        }
                        mySqlDataReader.Close();
                        PutCurrentElementTreeView();
                        PutCurrentElementSelectedTreeView();
                    }
                    else if (currentElementType == "field")
                    {
                        MessageBox.Show("You can´t go more deep.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void PutCurrentElementSelectedTreeView()
        {
            //show current selected element type and name
            lblCurrentSelectedElementTreeView.Text = string.Format("selected {0}: {1}", currentSelectedElementType, currentSelectedElementName);
        }

        private void PutCurrentElementTreeView()
        {
            //show current element type and name
            lblCurrentElementTreeView.Text = string.Format("{0}: {1}", currentElementType, currentElementName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            MessageBox.Show(string.Format("You selected: {0}", node.Text));
            useDatabase(node.Text);

        }

        public void useDatabase(string dataBase)
        {

            string useTable = "USE " + dataBase + ";";
            try
            {
                mySqlCommand = new MySqlCommand(useTable, mySqlConnection);
                ShowLog("Query: " + useTable);
                mySqlCommand.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                DialogResult dialog = MessageBox.Show("ERROR to extract data: " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void dropTable (string elementName)
        {

            string useTable = "DROP TABLE"+" " + elementName;
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

        public void dropDatabase( string elementName)
        {

            string useTable = "DROP DATABASE"  + " " + elementName;
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


        public void createDatabase( )
        {
            frmCreateDataBase frmCreateDataBase = new frmCreateDataBase();
            frmCreateDataBase.ShowDialog();

            if (frmCreateDataBase.DialogResult == DialogResult.OK)
            {
                string databaseName = frmCreateDataBase.txtNombreDatabase.Text;
                string query = "CREATE DATABASE " + databaseName;
                ShowLog("Query: " + query);
                try
                {
                    mySqlCommand = new MySqlCommand(query, mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                    PutDataInTreeView();
                }
                catch (Exception e)
                {
                    DialogResult dialog = MessageBox.Show("ERROR to extract data: " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

              

        }

        public void createTable(string tableName)
        {

            string useTable = "CREATE TABLE "+ tableName + "( id INT NOT NULL PRIMARY KEY AUTO_INCREMENT );";
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
        public void createField(string tableName, string fieldName,string fieldType)
        {

            string useTable = "AlTER TABLE " + tableName + " ADD " + fieldName +" "+ fieldType;
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

        public void deleteField(string tableName, string fieldName)
        {

            string useTable = "AlTER TABLE " + tableName + " DROP  " + fieldName ;
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

        public void alterField(string tableName, string fieldName)
        {
            MessageBox.Show("I'm here!");
            mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand("SHOW FIELDS FROM " + tableName +  " WHERE  Field = '" + fieldName + "';", mySqlConnection);
            mySqlDataReader = mySqlCommand.ExecuteReader();
            ShowLog("SHOW FIELDS FROM " + tableName + " WHERE  Field = '" + fieldName + "';");
            while (mySqlDataReader.Read())
            {
                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                {
                    MessageBox.Show(mySqlDataReader.GetValue(i).ToString());
                }
            }
            mySqlDataReader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            createTable("hola");
            PutDataInTreeView();

        }

        private void btnGoBackTreeView_Click(object sender, EventArgs e)
        {
            if (currentElementType != "server")
            {
                currentSelectedElementName = "";
                currentSelectedElementType = "";
                PutCurrentElementSelectedTreeView();
            }

            if (currentElementType == "server")
            {
                MessageBox.Show("You can´t go more up.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (currentElementType == "database")
            {
                //go back to server
                currentElementType = "server";
                currentElementName = wayToElement["server"];
                wayToElement["database"] = "";

                PutDataInTreeView();
            }
            else if (currentElementType == "table")
            {
                //go back to database
                currentElementType = "database";
                currentElementName = wayToElement["database"];
                wayToElement["table"] = "";

                PutDataInTreeView();
            }
            else if (currentElementType == "field")
            {
                //go back to table
                currentElementType = "table";
                currentElementName = wayToElement["table"];
                wayToElement["field"] = "";

                PutDataInTreeView();
            }
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (currentElementType == "server")
            {
                //click on database
                currentSelectedElementType = "database";
                currentSelectedElementName = e.Node.Text;
                wayToElement["database"] = e.Node.Text;
                PutCurrentElementSelectedTreeView();
            }
            else if (currentElementType == "database")
            {
                //click on table
                currentSelectedElementType = "table";
                currentSelectedElementName = e.Node.Text;
                wayToElement["table"] = e.Node.Text;
                PutCurrentElementSelectedTreeView();
            }
            else if (currentElementType == "table")
            {
                //click on field
                currentSelectedElementType = "field";
                currentSelectedElementName = e.Node.Text;
                wayToElement["field"] = e.Node.Text;
                PutCurrentElementSelectedTreeView();
            }
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (currentElementType == "server")
            {
                //go deep into database
                currentElementType = "database";
                currentElementName = e.Node.Text;
                wayToElement["database"] = e.Node.Text;

                PutDataInTreeView();
            }
            else if (currentElementType == "database")
            {
                //go deep into table
                currentElementType = "table";
                currentElementName = e.Node.Text;
                wayToElement["table"] = e.Node.Text;

                PutDataInTreeView();
            }
            else if (currentElementType == "table")
            {
                MessageBox.Show("You can´t go more deep.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (currentElementType == "server")
            {
                //select on database
                currentSelectedElementType = "database";
                currentSelectedElementName = e.Node.Text;
                wayToElement["database"] = e.Node.Text;
                PutCurrentElementSelectedTreeView();
            }
            else if (currentElementType == "database")
            {
                //select on table
                currentSelectedElementType = "table";
                currentSelectedElementName = e.Node.Text;
                wayToElement["table"] = e.Node.Text;
                PutCurrentElementSelectedTreeView();
            }
            else if (currentElementType == "table")
            {
                //select on field
                currentSelectedElementType = "field";
                currentSelectedElementName = e.Node.Text;
                wayToElement["field"] = e.Node.Text;
                PutCurrentElementSelectedTreeView();
            }
        }

        private bool ConfirmQuery(string query)
        {
            bool answer = false;

            //create dialog for response
            DialogResult result = MessageBox.Show(string.Format("Execute the following query: '{0}'?", query), "Confirm query", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                //positive confirm
                answer = true;
            }
            else if (result == DialogResult.No)
            {
                //negative confirm
                answer = false;
            }

            return answer;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dropTable(currentSelectedElementName);
            PutDataInTreeView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dropDatabase(currentSelectedElementName);
            PutDataInTreeView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            createField(wayToElement["table"], "hola", "int");
            PutDataInTreeView();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            PutDataInTreeView();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            deleteField(wayToElement["table"], currentSelectedElementName);
            PutDataInTreeView();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConnectDisconnectMySQL_Click(object sender, EventArgs e)
        {
            if (btnConnectDisconnectMySQL.Text == "Connect")
            {
                //connect
                ConnectMySQL();
                if (CheckConnectMySQL())
                {
                    panelWelcome.Visible = false;
                    panelHome.Visible = true;
                }
              
            }
            else
            {
                //disconnect
                DisconnectMysql();
                if (!CheckConnectMySQL())
                {
                    panelWelcome.Visible = true;
                    panelHome.Visible = false;
                }
            }
        }

        private void btnDisconnectMySQL_Click(object sender, EventArgs e)
        {
            //disconnect
            DisconnectMysql();
            if (!CheckConnectMySQL())
            {
                panelWelcome.Visible = true;
                panelHome.Visible = false;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (currentElementType=="server")
            {
                createDatabase();
            }
            else if (currentElementType == "database")
            {
                MessageBox.Show("database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (currentElementType == "table")
            {
                MessageBox.Show("table", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (currentElementType == "field")
            {
                MessageBox.Show("field", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if(currentSelectedElementType == "field")
            {
                alterField(currentElementName, currentSelectedElementName);
            }
            else
            {
                MessageBox.Show("You can't alter a " + currentSelectedElementType, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
