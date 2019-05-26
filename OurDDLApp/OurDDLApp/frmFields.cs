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
        public List<string>  fields;
        string fieldType="";
        string fieldName = "";
        string fieldLength = "";



        private void btnAddField_Click(object sender, EventArgs e)
        {
            fieldName = txtNombreDato.Text;
            fieldLength = txtNombreDato.Text;

            if (fieldType != "")
            {
                if(fieldName != "")
                {
                    switch (fieldType)
                    {
                        case "int":
                            fields.Add(fieldName + " " + "INT");
                            break;
                        case "varchar":
                            if (fieldLength != "")
                            {
                               fields.Add(fieldName + " " + "varchar(" + fieldLength);

                            }
                            else
                            {

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

            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            btnFinish.DialogResult = DialogResult.OK;
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
