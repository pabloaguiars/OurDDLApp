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
    public partial class frmCreate : Form
    {
        public frmCreate()
        {
            InitializeComponent();
        }

        
        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
            if (txtNombreDatabase.Text != "")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
