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

namespace OurDDLApp
{
    public partial class frmMain : Form
    {
        //global class object for mysql connection
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDisconnectMySQL_Click(object sender, EventArgs e)
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
                        mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connection);
                        //open connection
                        mySqlConnection.Open();
                        //if connection state is open
                        if (CheckConnectMySQL())
                        {
                            b = false;
                            lblConnectionStatus.Text = "Connection status: Open";
                            btnConnectMySQL.Enabled = true;
                            btnDisconnectMySQL.Enabled = false;
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
                }
            } 
        }

        private void btnConnectMySQL_Click(object sender, EventArgs e)
        {
            //close connection
            mySqlConnection.Close();
            //if connection state is close
            if (!CheckConnectMySQL())
            {
                lblConnectionStatus.Text = "Connection status: Close";
                btnConnectMySQL.Enabled = false;
                btnDisconnectMySQL.Enabled = true;
            }
        }

        public bool CheckConnectMySQL()
        {
            bool response = false;

            //if mysqlconnection states is open, return true
            if (mySqlConnection.State == ConnectionState.Open)
            {
                response = true;
            } //else if mysqlconnection state is close, return false
            else if (mySqlConnection.State == ConnectionState.Closed)
            {
                response =  false;
            }
            return response;
        }
    }
}
