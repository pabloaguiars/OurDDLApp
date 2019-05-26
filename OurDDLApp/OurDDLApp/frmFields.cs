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
        public List<string>  fields = new List<string>();
        string fieldType="";
        string fieldName = "";
        string fieldLength = "";
        bool fieldAdded = false;
        



        private void btnAddField_Click(object sender, EventArgs e)
        {
            fieldName = txtNombreDato.Text;
            fieldLength = txtFieldLength.Text;

            if (fieldType != "")
            {
                if(fieldName != "")
                {
                    switch (fieldType)
                    {
                        case "int":
                            fields.Add(fieldName + " " + "INT");
                            txtNombreDato.Text = "";
                            fieldAdded = true;
                            break;
                        case "varchar":
                            if (fieldLength != "")
                            {
                               fields.Add(fieldName + " " + "varchar(" + fieldLength + ")");
                               txtNombreDato.Text = "";
                               txtFieldLength.Text = "";
                               fieldAdded = true;


                            }
                            else
                            {
                                MessageBox.Show("Ingrese una longitud valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show("Eliga un tipo de dato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show("Agrega un campo primero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void frmFields_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipoDato_SelectedIndexChanged(object sender, EventArgs e)
        {
            fieldType = cmbTipoDato.Text;

            switch (fieldType)
            {
                case "int":
                    txtFieldLength.Visible = false;
                    lblFielfLength.Visible = false;
                    break;
                case "varchar":
                    txtFieldLength.Visible = true;
                    lblFielfLength.Visible = true; 
                    break;
                default:
                    txtFieldLength.Visible = false;
                    lblFielfLength.Visible = false;
                    break;
            }


        }
    }
}
