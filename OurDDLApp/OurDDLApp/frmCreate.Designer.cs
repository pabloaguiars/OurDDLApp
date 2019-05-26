namespace OurDDLApp
{
    partial class frmCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreDatabase = new System.Windows.Forms.TextBox();
            this.btnCreateDatabase = new System.Windows.Forms.Button();
            this.btnCancelarDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblNombre.Location = new System.Drawing.Point(12, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(195, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de la base de datos";
            // 
            // txtNombreDatabase
            // 
            this.txtNombreDatabase.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreDatabase.Location = new System.Drawing.Point(213, 54);
            this.txtNombreDatabase.Name = "txtNombreDatabase";
            this.txtNombreDatabase.Size = new System.Drawing.Size(111, 23);
            this.txtNombreDatabase.TabIndex = 1;
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCreateDatabase.Location = new System.Drawing.Point(184, 114);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(98, 30);
            this.btnCreateDatabase.TabIndex = 2;
            this.btnCreateDatabase.Text = "Create";
            this.btnCreateDatabase.UseVisualStyleBackColor = true;
            this.btnCreateDatabase.Click += new System.EventHandler(this.btnCreateDatabase_Click);
            // 
            // btnCancelarDatabase
            // 
            this.btnCancelarDatabase.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarDatabase.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelarDatabase.Location = new System.Drawing.Point(56, 114);
            this.btnCancelarDatabase.Name = "btnCancelarDatabase";
            this.btnCancelarDatabase.Size = new System.Drawing.Size(98, 30);
            this.btnCancelarDatabase.TabIndex = 3;
            this.btnCancelarDatabase.Text = "Cancelar";
            this.btnCancelarDatabase.UseVisualStyleBackColor = true;
            // 
            // frmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 171);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarDatabase);
            this.Controls.Add(this.btnCreateDatabase);
            this.Controls.Add(this.txtNombreDatabase);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCreate";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateDataBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox txtNombreDatabase;
        public System.Windows.Forms.Button btnCreateDatabase;
        public System.Windows.Forms.Button btnCancelarDatabase;
    }
}