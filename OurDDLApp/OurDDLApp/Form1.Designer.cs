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
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnGoBackTreeView = new System.Windows.Forms.Button();
            this.lblCurrentElementTreeView = new System.Windows.Forms.Label();
            this.sideBar = new System.Windows.Forms.Panel();
            this.btnDisconnectMySQL = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCurrentSelectedElementTreeView = new System.Windows.Forms.Label();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnTruncate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnConnectDisconnectMySQL = new System.Windows.Forms.Button();
            this.sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(3, 54);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(250, 325);
            this.treeView.TabIndex = 4;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // btnGoBackTreeView
            // 
            this.btnGoBackTreeView.Location = new System.Drawing.Point(37, 391);
            this.btnGoBackTreeView.Name = "btnGoBackTreeView";
            this.btnGoBackTreeView.Size = new System.Drawing.Size(75, 23);
            this.btnGoBackTreeView.TabIndex = 7;
            this.btnGoBackTreeView.Text = "&Go back";
            this.btnGoBackTreeView.UseVisualStyleBackColor = true;
            this.btnGoBackTreeView.Click += new System.EventHandler(this.btnGoBackTreeView_Click);
            // 
            // lblCurrentElementTreeView
            // 
            this.lblCurrentElementTreeView.AutoSize = true;
            this.lblCurrentElementTreeView.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.lblCurrentElementTreeView.Location = new System.Drawing.Point(15, 21);
            this.lblCurrentElementTreeView.Name = "lblCurrentElementTreeView";
            this.lblCurrentElementTreeView.Size = new System.Drawing.Size(139, 25);
            this.lblCurrentElementTreeView.TabIndex = 8;
            this.lblCurrentElementTreeView.Text = "Current element";
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sideBar.Controls.Add(this.btnDisconnectMySQL);
            this.sideBar.Controls.Add(this.lblCurrentElementTreeView);
            this.sideBar.Controls.Add(this.treeView);
            this.sideBar.Controls.Add(this.btnGoBackTreeView);
            this.sideBar.Location = new System.Drawing.Point(3, 4);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(253, 456);
            this.sideBar.TabIndex = 15;
            this.sideBar.Visible = false;
            this.sideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDisconnectMySQL
            // 
            this.btnDisconnectMySQL.Location = new System.Drawing.Point(141, 391);
            this.btnDisconnectMySQL.Name = "btnDisconnectMySQL";
            this.btnDisconnectMySQL.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnectMySQL.TabIndex = 23;
            this.btnDisconnectMySQL.Text = "&Disconnect";
            this.btnDisconnectMySQL.UseVisualStyleBackColor = true;
            this.btnDisconnectMySQL.Click += new System.EventHandler(this.btnDisconnectMySQL_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCurrentSelectedElementTreeView);
            this.panel2.Controls.Add(this.txtLogs);
            this.panel2.Controls.Add(this.btnAlter);
            this.panel2.Controls.Add(this.btnTruncate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Controls.Add(this.sideBar);
            this.panel2.Controls.Add(this.btnConnectDisconnectMySQL);
            this.panel2.Location = new System.Drawing.Point(-6, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 460);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblCurrentSelectedElementTreeView
            // 
            this.lblCurrentSelectedElementTreeView.AutoSize = true;
            this.lblCurrentSelectedElementTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentSelectedElementTreeView.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.lblCurrentSelectedElementTreeView.Location = new System.Drawing.Point(302, 25);
            this.lblCurrentSelectedElementTreeView.Name = "lblCurrentSelectedElementTreeView";
            this.lblCurrentSelectedElementTreeView.Size = new System.Drawing.Size(213, 27);
            this.lblCurrentSelectedElementTreeView.TabIndex = 22;
            this.lblCurrentSelectedElementTreeView.Text = "Current selected element";
            this.lblCurrentSelectedElementTreeView.Visible = false;
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(261, 395);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogs.Size = new System.Drawing.Size(542, 57);
            this.txtLogs.TabIndex = 21;
            this.txtLogs.Text = "Logs";
            this.txtLogs.Visible = false;
            // 
            // btnAlter
            // 
            this.btnAlter.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.btnAlter.Location = new System.Drawing.Point(305, 327);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(458, 56);
            this.btnAlter.TabIndex = 20;
            this.btnAlter.Text = "Alter";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Visible = false;
            // 
            // btnTruncate
            // 
            this.btnTruncate.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.btnTruncate.Location = new System.Drawing.Point(305, 239);
            this.btnTruncate.Name = "btnTruncate";
            this.btnTruncate.Size = new System.Drawing.Size(458, 56);
            this.btnTruncate.TabIndex = 19;
            this.btnTruncate.Text = "Truncate";
            this.btnTruncate.UseVisualStyleBackColor = true;
            this.btnTruncate.Visible = false;
            this.btnTruncate.Click += new System.EventHandler(this.btnTruncate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.btnDelete.Location = new System.Drawing.Point(302, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(461, 53);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.btnCreate.Location = new System.Drawing.Point(305, 58);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(458, 52);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnConnectDisconnectMySQL
            // 
            this.btnConnectDisconnectMySQL.Location = new System.Drawing.Point(278, 207);
            this.btnConnectDisconnectMySQL.Name = "btnConnectDisconnectMySQL";
            this.btnConnectDisconnectMySQL.Size = new System.Drawing.Size(257, 42);
            this.btnConnectDisconnectMySQL.TabIndex = 16;
            this.btnConnectDisconnectMySQL.Text = "Connect";
            this.btnConnectDisconnectMySQL.UseVisualStyleBackColor = true;
            this.btnConnectDisconnectMySQL.Click += new System.EventHandler(this.btnConnectDisconnectMySQL_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurDDLApp";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button btnGoBackTreeView;
        private System.Windows.Forms.Label lblCurrentElementTreeView;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConnectDisconnectMySQL;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnTruncate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.Label lblCurrentSelectedElementTreeView;
        private System.Windows.Forms.Button btnDisconnectMySQL;
    }
}

