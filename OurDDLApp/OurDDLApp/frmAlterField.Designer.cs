namespace OurDDLApp
{
    partial class frmAlterField
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
            this.lblFieldName = new System.Windows.Forms.Label();
            this.lblFieldType = new System.Windows.Forms.Label();
            this.lblFieldCollation = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.txtFieldType = new System.Windows.Forms.TextBox();
            this.txtFieldCollation = new System.Windows.Forms.TextBox();
            this.gbNullable = new System.Windows.Forms.GroupBox();
            this.rbNullableNo = new System.Windows.Forms.RadioButton();
            this.rbNullableYes = new System.Windows.Forms.RadioButton();
            this.gbKeys = new System.Windows.Forms.GroupBox();
            this.rbKeyNull = new System.Windows.Forms.RadioButton();
            this.rbKeyMultiple = new System.Windows.Forms.RadioButton();
            this.rbKeyUnique = new System.Windows.Forms.RadioButton();
            this.rbKeyPrimary = new System.Windows.Forms.RadioButton();
            this.txtFieldDefault = new System.Windows.Forms.TextBox();
            this.lblDefault = new System.Windows.Forms.Label();
            this.txtFieldExtra = new System.Windows.Forms.TextBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.txtFieldPrivileges = new System.Windows.Forms.TextBox();
            this.lblPrivileges = new System.Windows.Forms.Label();
            this.txtFieldComment = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbNullable.SuspendLayout();
            this.gbKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Location = new System.Drawing.Point(16, 21);
            this.lblFieldName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(52, 17);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Name:";
            // 
            // lblFieldType
            // 
            this.lblFieldType.AutoSize = true;
            this.lblFieldType.Location = new System.Drawing.Point(16, 55);
            this.lblFieldType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFieldType.Name = "lblFieldType";
            this.lblFieldType.Size = new System.Drawing.Size(73, 17);
            this.lblFieldType.TabIndex = 1;
            this.lblFieldType.Text = "Field type:";
            this.lblFieldType.Click += new System.EventHandler(this.lblFieldType_Click);
            // 
            // lblFieldCollation
            // 
            this.lblFieldCollation.AutoSize = true;
            this.lblFieldCollation.Location = new System.Drawing.Point(16, 89);
            this.lblFieldCollation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFieldCollation.Name = "lblFieldCollation";
            this.lblFieldCollation.Size = new System.Drawing.Size(72, 17);
            this.lblFieldCollation.TabIndex = 2;
            this.lblFieldCollation.Text = "Collation:";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(103, 18);
            this.txtFieldName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(320, 23);
            this.txtFieldName.TabIndex = 3;
            // 
            // txtFieldType
            // 
            this.txtFieldType.Location = new System.Drawing.Point(103, 52);
            this.txtFieldType.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldType.Name = "txtFieldType";
            this.txtFieldType.Size = new System.Drawing.Size(320, 23);
            this.txtFieldType.TabIndex = 4;
            // 
            // txtFieldCollation
            // 
            this.txtFieldCollation.Location = new System.Drawing.Point(103, 86);
            this.txtFieldCollation.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldCollation.Name = "txtFieldCollation";
            this.txtFieldCollation.ReadOnly = true;
            this.txtFieldCollation.Size = new System.Drawing.Size(320, 23);
            this.txtFieldCollation.TabIndex = 5;
            // 
            // gbNullable
            // 
            this.gbNullable.Controls.Add(this.rbNullableNo);
            this.gbNullable.Controls.Add(this.rbNullableYes);
            this.gbNullable.Enabled = false;
            this.gbNullable.Location = new System.Drawing.Point(456, 17);
            this.gbNullable.Margin = new System.Windows.Forms.Padding(4);
            this.gbNullable.Name = "gbNullable";
            this.gbNullable.Padding = new System.Windows.Forms.Padding(4);
            this.gbNullable.Size = new System.Drawing.Size(149, 95);
            this.gbNullable.TabIndex = 6;
            this.gbNullable.TabStop = false;
            this.gbNullable.Text = "Nullable";
            // 
            // rbNullableNo
            // 
            this.rbNullableNo.AutoSize = true;
            this.rbNullableNo.Location = new System.Drawing.Point(29, 58);
            this.rbNullableNo.Margin = new System.Windows.Forms.Padding(4);
            this.rbNullableNo.Name = "rbNullableNo";
            this.rbNullableNo.Size = new System.Drawing.Size(45, 21);
            this.rbNullableNo.TabIndex = 1;
            this.rbNullableNo.TabStop = true;
            this.rbNullableNo.Text = "No";
            this.rbNullableNo.UseVisualStyleBackColor = true;
            // 
            // rbNullableYes
            // 
            this.rbNullableYes.AutoSize = true;
            this.rbNullableYes.Location = new System.Drawing.Point(29, 27);
            this.rbNullableYes.Margin = new System.Windows.Forms.Padding(4);
            this.rbNullableYes.Name = "rbNullableYes";
            this.rbNullableYes.Size = new System.Drawing.Size(46, 21);
            this.rbNullableYes.TabIndex = 0;
            this.rbNullableYes.TabStop = true;
            this.rbNullableYes.Text = "Yes";
            this.rbNullableYes.UseVisualStyleBackColor = true;
            // 
            // gbKeys
            // 
            this.gbKeys.Controls.Add(this.rbKeyNull);
            this.gbKeys.Controls.Add(this.rbKeyMultiple);
            this.gbKeys.Controls.Add(this.rbKeyUnique);
            this.gbKeys.Controls.Add(this.rbKeyPrimary);
            this.gbKeys.Enabled = false;
            this.gbKeys.Location = new System.Drawing.Point(456, 120);
            this.gbKeys.Margin = new System.Windows.Forms.Padding(4);
            this.gbKeys.Name = "gbKeys";
            this.gbKeys.Padding = new System.Windows.Forms.Padding(4);
            this.gbKeys.Size = new System.Drawing.Size(149, 157);
            this.gbKeys.TabIndex = 7;
            this.gbKeys.TabStop = false;
            this.gbKeys.Text = "Keys";
            // 
            // rbKeyNull
            // 
            this.rbKeyNull.AutoSize = true;
            this.rbKeyNull.Location = new System.Drawing.Point(23, 119);
            this.rbKeyNull.Margin = new System.Windows.Forms.Padding(4);
            this.rbKeyNull.Name = "rbKeyNull";
            this.rbKeyNull.Size = new System.Drawing.Size(50, 21);
            this.rbKeyNull.TabIndex = 3;
            this.rbKeyNull.TabStop = true;
            this.rbKeyNull.Text = "Null";
            this.rbKeyNull.UseVisualStyleBackColor = true;
            // 
            // rbKeyMultiple
            // 
            this.rbKeyMultiple.AutoSize = true;
            this.rbKeyMultiple.Location = new System.Drawing.Point(23, 89);
            this.rbKeyMultiple.Margin = new System.Windows.Forms.Padding(4);
            this.rbKeyMultiple.Name = "rbKeyMultiple";
            this.rbKeyMultiple.Size = new System.Drawing.Size(48, 21);
            this.rbKeyMultiple.TabIndex = 2;
            this.rbKeyMultiple.TabStop = true;
            this.rbKeyMultiple.Text = "Mul";
            this.rbKeyMultiple.UseVisualStyleBackColor = true;
            // 
            // rbKeyUnique
            // 
            this.rbKeyUnique.AutoSize = true;
            this.rbKeyUnique.Location = new System.Drawing.Point(23, 58);
            this.rbKeyUnique.Margin = new System.Windows.Forms.Padding(4);
            this.rbKeyUnique.Name = "rbKeyUnique";
            this.rbKeyUnique.Size = new System.Drawing.Size(70, 21);
            this.rbKeyUnique.TabIndex = 1;
            this.rbKeyUnique.TabStop = true;
            this.rbKeyUnique.Text = "Unique";
            this.rbKeyUnique.UseVisualStyleBackColor = true;
            // 
            // rbKeyPrimary
            // 
            this.rbKeyPrimary.AutoSize = true;
            this.rbKeyPrimary.Location = new System.Drawing.Point(23, 27);
            this.rbKeyPrimary.Margin = new System.Windows.Forms.Padding(4);
            this.rbKeyPrimary.Name = "rbKeyPrimary";
            this.rbKeyPrimary.Size = new System.Drawing.Size(73, 21);
            this.rbKeyPrimary.TabIndex = 0;
            this.rbKeyPrimary.TabStop = true;
            this.rbKeyPrimary.Text = "Primary";
            this.rbKeyPrimary.UseVisualStyleBackColor = true;
            // 
            // txtFieldDefault
            // 
            this.txtFieldDefault.Location = new System.Drawing.Point(103, 121);
            this.txtFieldDefault.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldDefault.Name = "txtFieldDefault";
            this.txtFieldDefault.ReadOnly = true;
            this.txtFieldDefault.Size = new System.Drawing.Size(320, 23);
            this.txtFieldDefault.TabIndex = 9;
            // 
            // lblDefault
            // 
            this.lblDefault.AutoSize = true;
            this.lblDefault.Location = new System.Drawing.Point(16, 124);
            this.lblDefault.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDefault.Name = "lblDefault";
            this.lblDefault.Size = new System.Drawing.Size(59, 17);
            this.lblDefault.TabIndex = 8;
            this.lblDefault.Text = "Default:";
            // 
            // txtFieldExtra
            // 
            this.txtFieldExtra.Location = new System.Drawing.Point(103, 155);
            this.txtFieldExtra.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldExtra.Multiline = true;
            this.txtFieldExtra.Name = "txtFieldExtra";
            this.txtFieldExtra.ReadOnly = true;
            this.txtFieldExtra.Size = new System.Drawing.Size(320, 77);
            this.txtFieldExtra.TabIndex = 11;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(16, 158);
            this.lblExtra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(43, 17);
            this.lblExtra.TabIndex = 10;
            this.lblExtra.Text = "Extra:";
            // 
            // txtFieldPrivileges
            // 
            this.txtFieldPrivileges.Location = new System.Drawing.Point(103, 242);
            this.txtFieldPrivileges.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldPrivileges.Name = "txtFieldPrivileges";
            this.txtFieldPrivileges.ReadOnly = true;
            this.txtFieldPrivileges.Size = new System.Drawing.Size(320, 23);
            this.txtFieldPrivileges.TabIndex = 13;
            // 
            // lblPrivileges
            // 
            this.lblPrivileges.AutoSize = true;
            this.lblPrivileges.Location = new System.Drawing.Point(16, 245);
            this.lblPrivileges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrivileges.Name = "lblPrivileges";
            this.lblPrivileges.Size = new System.Drawing.Size(71, 17);
            this.lblPrivileges.TabIndex = 12;
            this.lblPrivileges.Text = "Privileges:";
            // 
            // txtFieldComment
            // 
            this.txtFieldComment.Location = new System.Drawing.Point(103, 276);
            this.txtFieldComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldComment.Multiline = true;
            this.txtFieldComment.Name = "txtFieldComment";
            this.txtFieldComment.ReadOnly = true;
            this.txtFieldComment.Size = new System.Drawing.Size(320, 77);
            this.txtFieldComment.TabIndex = 15;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(16, 279);
            this.lblComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(79, 17);
            this.lblComments.TabIndex = 14;
            this.lblComments.Text = "Comment:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(505, 378);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(323, 378);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAlterField
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(638, 429);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFieldComment);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtFieldPrivileges);
            this.Controls.Add(this.lblPrivileges);
            this.Controls.Add(this.txtFieldExtra);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.txtFieldDefault);
            this.Controls.Add(this.lblDefault);
            this.Controls.Add(this.gbKeys);
            this.Controls.Add(this.gbNullable);
            this.Controls.Add(this.txtFieldCollation);
            this.Controls.Add(this.txtFieldType);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.lblFieldCollation);
            this.Controls.Add(this.lblFieldType);
            this.Controls.Add(this.lblFieldName);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAlterField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit field";
            this.gbNullable.ResumeLayout(false);
            this.gbNullable.PerformLayout();
            this.gbKeys.ResumeLayout(false);
            this.gbKeys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Label lblFieldType;
        private System.Windows.Forms.Label lblFieldCollation;
        public System.Windows.Forms.TextBox txtFieldName;
        public System.Windows.Forms.TextBox txtFieldType;
        public System.Windows.Forms.TextBox txtFieldCollation;
        private System.Windows.Forms.GroupBox gbNullable;
        public System.Windows.Forms.RadioButton rbNullableNo;
        public System.Windows.Forms.RadioButton rbNullableYes;
        private System.Windows.Forms.GroupBox gbKeys;
        public System.Windows.Forms.RadioButton rbKeyNull;
        public System.Windows.Forms.RadioButton rbKeyMultiple;
        public System.Windows.Forms.RadioButton rbKeyUnique;
        public System.Windows.Forms.RadioButton rbKeyPrimary;
        public System.Windows.Forms.TextBox txtFieldDefault;
        private System.Windows.Forms.Label lblDefault;
        public System.Windows.Forms.TextBox txtFieldExtra;
        private System.Windows.Forms.Label lblExtra;
        public System.Windows.Forms.TextBox txtFieldPrivileges;
        private System.Windows.Forms.Label lblPrivileges;
        public System.Windows.Forms.TextBox txtFieldComment;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}