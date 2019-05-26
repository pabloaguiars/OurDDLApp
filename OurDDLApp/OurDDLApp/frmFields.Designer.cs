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
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(52, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnFinish.Location = new System.Drawing.Point(214, 146);
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
            this.lblFieldType.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblFieldType.Location = new System.Drawing.Point(36, 35);
            this.lblFieldType.Name = "lblFieldType";
            this.lblFieldType.Size = new System.Drawing.Size(91, 17);
            this.lblFieldType.TabIndex = 4;
            this.lblFieldType.Text = "Tipo de dato";
            this.lblFieldType.Click += new System.EventHandler(this.lblFieldType_Click);
            // 
            // cmbFieldType
            // 
            this.cmbFieldType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFieldType.Font = new System.Drawing.Font("Century Gothic", 9.75F);
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
            this.cmbFieldType.Location = new System.Drawing.Point(179, 32);
            this.cmbFieldType.Name = "cmbFieldType";
            this.cmbFieldType.Size = new System.Drawing.Size(121, 25);
            this.cmbFieldType.TabIndex = 8;
            this.cmbFieldType.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDato_SelectedIndexChanged);
            // 
            // txtFieldName
            // 
            this.txtFieldName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFieldName.Location = new System.Drawing.Point(179, 70);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(121, 23);
            this.txtFieldName.TabIndex = 9;
            this.txtFieldName.TextChanged += new System.EventHandler(this.txtFieldName_TextChanged);
            // 
            // lblFIeldName
            // 
            this.lblFIeldName.AutoSize = true;
            this.lblFIeldName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblFIeldName.Location = new System.Drawing.Point(36, 73);
            this.lblFIeldName.Name = "lblFIeldName";
            this.lblFIeldName.Size = new System.Drawing.Size(137, 17);
            this.lblFIeldName.TabIndex = 10;
            this.lblFIeldName.Text = "Nombre del campo";
            this.lblFIeldName.Click += new System.EventHandler(this.lblFIeldName_Click);
            // 
            // btnAddField
            // 
            this.btnAddField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAddField.Location = new System.Drawing.Point(133, 146);
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
            this.lblFielfLength.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblFielfLength.Location = new System.Drawing.Point(36, 106);
            this.lblFielfLength.Name = "lblFielfLength";
            this.lblFielfLength.Size = new System.Drawing.Size(121, 17);
            this.lblFielfLength.TabIndex = 13;
            this.lblFielfLength.Text = "Largo del campo";
            this.lblFielfLength.Visible = false;
            this.lblFielfLength.Click += new System.EventHandler(this.lblFielfLength_Click);
            // 
            // txtFieldLength
            // 
            this.txtFieldLength.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFieldLength.Location = new System.Drawing.Point(179, 103);
            this.txtFieldLength.Name = "txtFieldLength";
            this.txtFieldLength.Size = new System.Drawing.Size(121, 23);
            this.txtFieldLength.TabIndex = 12;
            this.txtFieldLength.Visible = false;
            this.txtFieldLength.TextChanged += new System.EventHandler(this.txtFieldLength_TextChanged);
            // 
            // frmFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 191);
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