using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurDDLApp
{
    public partial class frmFields : Form
    {
        public frmFields()
        {
            InitializeComponent();
        }
        public List<string> fields = new List<string>();
        string fieldType = "";
        string fieldName = "";
        string fieldLength = "";
        bool fieldAdded = false;




        private void btnAddField_Click(object sender, EventArgs e)
        {
            fieldName = txtFieldName.Text;
            fieldLength = txtFieldLength.Text;

            if (fieldType != "")
            {
                if (fieldName != "")
                {
                    switch (fieldType)
                    {
                        case "INT":
                            fields.Add(fieldName + " " + "INT");
                            txtFieldName.Text = "";
                            fieldAdded = true;
                            break;
                        case "TINYINT":
                            fields.Add(fieldName + " " + "TINYINT");
                            txtFieldName.Text = "";
                            fieldAdded = true;
                            break;
                        case "SMALLINT":
                            fields.Add(fieldName + " " + "SMALLINT");
                            txtFieldName.Text = "";
                            fieldAdded = true;
                            break;
                        case "MEDIUMINT":
                            fields.Add(fieldName + " " + "MEDIUMINT");
                            txtFieldName.Text = "";
                            fieldAdded = true;
                            break;
                        case "BIGINT":
                            fields.Add(fieldName + " " + "BIGINT");
                            txtFieldName.Text = "";
                            fieldAdded = true;
                            break;
                        case "DECIMAL":
                            fields.Add(fieldName + " " + "DECIMAL");
                            txtFieldName.Text = "";
                            fieldAdded = true;
                            break;
                        case "FLOAT":
                            fields.Add(fieldName + " " + "FLOAT");
                            txtFieldName.Text = "";
                            fieldAdded = true;
                            break;
                        case "DOUBLE":
                            fields.Add(fieldName + " " + "DOUBLE");
                            txtFieldName.Text = "";
                            fieldAdded = true;
                            break;
                        case "BIT":
                            fields.Add(fieldName + " " + "BIT");
                            txtFieldName.Text = "";
                            fieldAdded = true;
                            break;
                        case "VARCHAR":
                            if (fieldLength != "")
                            {
                                fields.Add(fieldName + " " + "VARCHAR(" + fieldLength + ")");
                                txtFieldName.Text = "";
                                txtFieldLength.Text = "";
                                fieldAdded = true;


                            }
                            else
                            {
                                MessageBox.Show("Enter a valid length.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            break;
                        case "CHAR":
                            if (fieldLength != "")
                            {
                                fields.Add(fieldName + " " + "CHAR(" + fieldLength + ")");
                                txtFieldName.Text = "";
                                txtFieldLength.Text = "";
                                fieldAdded = true;


                            }
                            else
                            {
                                MessageBox.Show("Enter a valid length.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            break;

                        case "TINYTEXT":
                            if (fieldLength != "")
                            {
                                fields.Add(fieldName + " " + "TINYTEXT(" + fieldLength + ")");
                                txtFieldName.Text = "";
                                txtFieldLength.Text = "";
                                fieldAdded = true;


                            }
                            else
                            {
                                MessageBox.Show("Enter a valid length.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            break;
                        case "TEXT":
                            if (fieldLength != "")
                            {
                                fields.Add(fieldName + " " + "TEXT(" + fieldLength + ")");
                                txtFieldName.Text = "";
                                txtFieldLength.Text = "";
                                fieldAdded = true;


                            }
                            else
                            {
                                MessageBox.Show("Enter a valid length.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            break;
                        case "MEDIUMTEXT":
                            if (fieldLength != "")
                            {
                                fields.Add(fieldName + " " + "MEDIUMTEXT(" + fieldLength + ")");
                                txtFieldName.Text = "";
                                txtFieldLength.Text = "";
                                fieldAdded = true;


                            }
                            else
                            {
                                MessageBox.Show("Enter a valid length.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            break;
                        case "LONGTEXT":
                            if (fieldLength != "")
                            {
                                fields.Add(fieldName + " " + "LONGTEXT(" + fieldLength + ")");
                                txtFieldName.Text = "";
                                txtFieldLength.Text = "";
                                fieldAdded = true;


                            }
                            else
                            {
                                MessageBox.Show("Enter a valid length.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            break;
                        default:
                            txtFieldLength.Visible = false;
                            lblFielfLength.Visible = false;
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose a data type.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (fieldAdded)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Add a field first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void frmFields_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipoDato_SelectedIndexChanged(object sender, EventArgs e)
        {
            fieldType = cmbFieldType.Text;

            switch (fieldType)
            {
                case "INT":
                    txtFieldLength.Visible = false;
                    lblFielfLength.Visible = false;
                    break;
                case "TINYINT":
                    txtFieldLength.Visible = false;
                    lblFielfLength.Visible = false;
                    break;
                case "SMALLINT":
                    txtFieldLength.Visible = false;
                    lblFielfLength.Visible = false;
                    break;
                case "MEDIUMINT":
                    txtFieldLength.Visible = false;
                    lblFielfLength.Visible = false;
                    break;
                case "BIGINT":
                    txtFieldLength.Visible = false;
                    lblFielfLength.Visible = false;
                    break;
                case "DECIMAL":
                    txtFieldLength.Visible = false;
                    lblFielfLength.Visible = false;
                    break;
                case "FLOAT":
                    txtFieldLength.Visible = false;
                    lblFielfLength.Visible = false;
                    break;
                case "DOUBLE":
                    txtFieldLength.Visible = false;
                    lblFielfLength.Visible = false;
                    break;
                case "BIT":
                    txtFieldLength.Visible = false;
                    lblFielfLength.Visible = false;
                    break;
                case "VARCHAR":
                    txtFieldLength.Visible = true;
                    lblFielfLength.Visible = true;
                    break;
                case "CHAR":
                    txtFieldLength.Visible = true;
                    lblFielfLength.Visible = true;
                    break;

                case "TINYTEXT":
                    txtFieldLength.Visible = true;
                    lblFielfLength.Visible = true;
                    break;
                case "TEXT":
                    txtFieldLength.Visible = true;
                    lblFielfLength.Visible = true;
                    break;
                case "MEDIUMTEXT":
                    txtFieldLength.Visible = true;
                    lblFielfLength.Visible = true;
                    break;
                case "LONGTEXT":
                    txtFieldLength.Visible = true;
                    lblFielfLength.Visible = true;
                    break;
                default:
                    txtFieldLength.Visible = false;
                    lblFielfLength.Visible = false;
                    break;
            }
        }

        private void txtFieldLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFIeldName_Click(object sender, EventArgs e)
        {

        }

        private void txtFieldName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void lblFielfLength_Click(object sender, EventArgs e)
        {

        }

        private void lblFieldType_Click(object sender, EventArgs e)
        {

        }
    }
}
