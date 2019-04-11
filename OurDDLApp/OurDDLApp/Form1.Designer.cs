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
            this.lblLogs = new System.Windows.Forms.Label();
            this.btnConnectMySQL = new System.Windows.Forms.Button();
            this.btnDisconnectMySQL = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mySQLConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Location = new System.Drawing.Point(12, 428);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(40, 13);
            this.lblLogs.TabIndex = 0;
            this.lblLogs.Text = "lblLogs";
            // 
            // btnConnectMySQL
            // 
            this.btnConnectMySQL.Location = new System.Drawing.Point(389, 195);
            this.btnConnectMySQL.Name = "btnConnectMySQL";
            this.btnConnectMySQL.Size = new System.Drawing.Size(75, 23);
            this.btnConnectMySQL.TabIndex = 1;
            this.btnConnectMySQL.Text = "Connect";
            this.btnConnectMySQL.UseVisualStyleBackColor = true;
            this.btnConnectMySQL.Click += new System.EventHandler(this.btnConnectMySQL_Click);
            // 
            // btnDisconnectMySQL
            // 
            this.btnDisconnectMySQL.Enabled = false;
            this.btnDisconnectMySQL.Location = new System.Drawing.Point(308, 195);
            this.btnDisconnectMySQL.Name = "btnDisconnectMySQL";
            this.btnDisconnectMySQL.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnectMySQL.TabIndex = 2;
            this.btnDisconnectMySQL.Text = "Disconnect";
            this.btnDisconnectMySQL.UseVisualStyleBackColor = true;
            this.btnDisconnectMySQL.Click += new System.EventHandler(this.btnDisconnectMySQL_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mySQLConnectionToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 3;
            this.menu.Text = "Menu";
            // 
            // mySQLConnectionToolStripMenuItem
            // 
            this.mySQLConnectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.mySQLConnectionToolStripMenuItem.Name = "mySQLConnectionToolStripMenuItem";
            this.mySQLConnectionToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.mySQLConnectionToolStripMenuItem.Text = "MySQL Connection";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisconnectMySQL);
            this.Controls.Add(this.btnConnectMySQL);
            this.Controls.Add(this.lblLogs);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Our DDL";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.Button btnConnectMySQL;
        private System.Windows.Forms.Button btnDisconnectMySQL;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mySQLConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
    }
}

