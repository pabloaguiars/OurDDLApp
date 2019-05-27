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
            this.lblNombre.Location = new System.Drawing.Point(16, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(118, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Database name:";
            // 
            // txtNombreDatabase
            // 
            this.txtNombreDatabase.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreDatabase.Location = new System.Drawing.Point(150, 68);
            this.txtNombreDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreDatabase.Name = "txtNombreDatabase";
            this.txtNombreDatabase.Size = new System.Drawing.Size(286, 23);
            this.txtNombreDatabase.TabIndex = 1;
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCreateDatabase.Location = new System.Drawing.Point(306, 149);
            this.btnCreateDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(130, 39);
            this.btnCreateDatabase.TabIndex = 2;
            this.btnCreateDatabase.Text = "&Create";
            this.btnCreateDatabase.UseVisualStyleBackColor = true;
            this.btnCreateDatabase.Click += new System.EventHandler(this.btnCreateDatabase_Click);
            // 
            // btnCancelarDatabase
            // 
            this.btnCancelarDatabase.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarDatabase.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelarDatabase.Location = new System.Drawing.Point(150, 149);
            this.btnCancelarDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarDatabase.Name = "btnCancelarDatabase";
            this.btnCancelarDatabase.Size = new System.Drawing.Size(130, 39);
            this.btnCancelarDatabase.TabIndex = 3;
            this.btnCancelarDatabase.Text = "&Cancel";
            this.btnCancelarDatabase.UseVisualStyleBackColor = true;
            // 
            // frmCreate
            // 
            this.AcceptButton = this.btnCreateDatabase;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelarDatabase;
            this.ClientSize = new System.Drawing.Size(459, 223);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarDatabase);
            this.Controls.Add(this.btnCreateDatabase);
            this.Controls.Add(this.txtNombreDatabase);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCreate";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create database";
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