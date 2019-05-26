namespace OurDDLApp
{
    partial class frmFields
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblFieldType = new System.Windows.Forms.Label();
            this.cmbFieldType = new System.Windows.Forms.ComboBox();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.lblFIeldName = new System.Windows.Forms.Label();
            this.btnAddField = new System.Windows.Forms.Button();
            this.lblFielfLength = new System.Windows.Forms.Label();
            this.txtFieldLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(54, 152);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(233, 152);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "Finalizar";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblFieldType
            // 
            this.lblFieldType.AutoSize = true;
            this.lblFieldType.Location = new System.Drawing.Point(51, 42);
            this.lblFieldType.Name = "lblFieldType";
            this.lblFieldType.Size = new System.Drawing.Size(67, 13);
            this.lblFieldType.TabIndex = 4;
            this.lblFieldType.Text = "Tipo de dato";
            // 
            // cmbFieldType
            // 
            this.cmbFieldType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFieldType.FormattingEnabled = true;
            this.cmbFieldType.Items.AddRange(new object[] {
            "INT",
            "TINYINT",
            "SMALLINT",
            "MEDIUMINT",
            "BIGINT",
            "DECIMAL",
            "FLOAT",
            "DOUBLE",
            "BIT",
            "CHAR",
            "VARCHAR",
            "TINYTEXT",
            "TEXT",
            "MEDIUMTEXT",
            "LONGTEXT"});
            this.cmbFieldType.Location = new System.Drawing.Point(148, 39);
            this.cmbFieldType.Name = "cmbFieldType";
            this.cmbFieldType.Size = new System.Drawing.Size(121, 21);
            this.cmbFieldType.TabIndex = 8;
            this.cmbFieldType.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDato_SelectedIndexChanged);
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(148, 77);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(121, 20);
            this.txtFieldName.TabIndex = 9;
            // 
            // lblFIeldName
            // 
            this.lblFIeldName.AutoSize = true;
            this.lblFIeldName.Location = new System.Drawing.Point(51, 80);
            this.lblFIeldName.Name = "lblFIeldName";
            this.lblFIeldName.Size = new System.Drawing.Size(96, 13);
            this.lblFIeldName.TabIndex = 10;
            this.lblFIeldName.Text = "Nombre del campo";
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(148, 152);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(75, 23);
            this.btnAddField.TabIndex = 11;
            this.btnAddField.Text = "Agregar";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // lblFielfLength
            // 
            this.lblFielfLength.AutoSize = true;
            this.lblFielfLength.Location = new System.Drawing.Point(51, 113);
            this.lblFielfLength.Name = "lblFielfLength";
            this.lblFielfLength.Size = new System.Drawing.Size(86, 13);
            this.lblFielfLength.TabIndex = 13;
            this.lblFielfLength.Text = "Largo del campo";
            this.lblFielfLength.Visible = false;
            // 
            // txtFieldLength
            // 
            this.txtFieldLength.Location = new System.Drawing.Point(148, 110);
            this.txtFieldLength.Name = "txtFieldLength";
            this.txtFieldLength.Size = new System.Drawing.Size(121, 20);
            this.txtFieldLength.TabIndex = 12;
            this.txtFieldLength.Visible = false;
            // 
            // frmFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 197);
            this.Controls.Add(this.lblFielfLength);
            this.Controls.Add(this.txtFieldLength);
            this.Controls.Add(this.btnAddField);
            this.Controls.Add(this.lblFIeldName);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.cmbFieldType);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblFieldType);
            this.Name = "frmFields";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFields";
            this.Load += new System.EventHandler(this.frmFields_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnFinish;
        public System.Windows.Forms.Label lblFieldType;
        private System.Windows.Forms.Label lblFIeldName;
        public System.Windows.Forms.ComboBox cmbFieldType;
        public System.Windows.Forms.TextBox txtFieldName;
        public System.Windows.Forms.Button btnAddField;
        public System.Windows.Forms.Label lblFielfLength;
        public System.Windows.Forms.TextBox txtFieldLength;
    }
}