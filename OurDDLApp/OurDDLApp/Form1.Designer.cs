namespace OurDDLApp
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnConnectMySQL = new System.Windows.Forms.Button();
            this.btnDisconnectMySQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(299, 249);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(98, 13);
            this.lblConnectionStatus.TabIndex = 0;
            this.lblConnectionStatus.Text = "Connection status: ";
            // 
            // btnConnectMySQL
            // 
            this.btnConnectMySQL.Location = new System.Drawing.Point(265, 276);
            this.btnConnectMySQL.Name = "btnConnectMySQL";
            this.btnConnectMySQL.Size = new System.Drawing.Size(75, 23);
            this.btnConnectMySQL.TabIndex = 1;
            this.btnConnectMySQL.Text = "Disconnect";
            this.btnConnectMySQL.UseVisualStyleBackColor = true;
            this.btnConnectMySQL.Click += new System.EventHandler(this.btnConnectMySQL_Click);
            // 
            // btnDisconnectMySQL
            // 
            this.btnDisconnectMySQL.Location = new System.Drawing.Point(346, 276);
            this.btnDisconnectMySQL.Name = "btnDisconnectMySQL";
            this.btnDisconnectMySQL.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnectMySQL.TabIndex = 2;
            this.btnDisconnectMySQL.Text = "Connect";
            this.btnDisconnectMySQL.UseVisualStyleBackColor = true;
            this.btnDisconnectMySQL.Click += new System.EventHandler(this.btnDisconnectMySQL_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisconnectMySQL);
            this.Controls.Add(this.btnConnectMySQL);
            this.Controls.Add(this.lblConnectionStatus);
            this.Name = "frmMain";
            this.Text = "Our DDL";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnConnectMySQL;
        private System.Windows.Forms.Button btnDisconnectMySQL;
    }
}

