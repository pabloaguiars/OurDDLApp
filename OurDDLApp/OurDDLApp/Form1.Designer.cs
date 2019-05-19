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
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnGoBackTreeView = new System.Windows.Forms.Button();
            this.lblTreeView = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConnectDisconnectMySQL = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Location = new System.Drawing.Point(27, 429);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(95, 13);
            this.lblLogs.TabIndex = 0;
            this.lblLogs.Text = "Ready to connect.";
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(3, 42);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(250, 317);
            this.treeView.TabIndex = 4;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // btnGoBackTreeView
            // 
            this.btnGoBackTreeView.Location = new System.Drawing.Point(30, 392);
            this.btnGoBackTreeView.Name = "btnGoBackTreeView";
            this.btnGoBackTreeView.Size = new System.Drawing.Size(75, 23);
            this.btnGoBackTreeView.TabIndex = 7;
            this.btnGoBackTreeView.Text = "Go back";
            this.btnGoBackTreeView.UseVisualStyleBackColor = true;
            this.btnGoBackTreeView.Click += new System.EventHandler(this.btnGoBackTreeView_Click);
            // 
            // lblTreeView
            // 
            this.lblTreeView.AutoSize = true;
            this.lblTreeView.Location = new System.Drawing.Point(27, 10);
            this.lblTreeView.Name = "lblTreeView";
            this.lblTreeView.Size = new System.Drawing.Size(35, 13);
            this.lblTreeView.TabIndex = 8;
            this.lblTreeView.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblTreeView);
            this.panel1.Controls.Add(this.treeView);
            this.panel1.Controls.Add(this.btnGoBackTreeView);
            this.panel1.Controls.Add(this.lblLogs);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 456);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConnectDisconnectMySQL);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-6, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 460);
            this.panel2.TabIndex = 16;
            // 
            // btnConnectDisconnectMySQL
            // 
            this.btnConnectDisconnectMySQL.Location = new System.Drawing.Point(413, 172);
            this.btnConnectDisconnectMySQL.Name = "btnConnectDisconnectMySQL";
            this.btnConnectDisconnectMySQL.Size = new System.Drawing.Size(75, 23);
            this.btnConnectDisconnectMySQL.TabIndex = 16;
            this.btnConnectDisconnectMySQL.Text = "button1";
            this.btnConnectDisconnectMySQL.UseVisualStyleBackColor = true;
            this.btnConnectDisconnectMySQL.Click += new System.EventHandler(this.btnConnectDisconnectMySQL_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurDDLApp";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button btnGoBackTreeView;
        private System.Windows.Forms.Label lblTreeView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConnectDisconnectMySQL;
    }
}

