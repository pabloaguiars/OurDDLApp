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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnGoBackTreeView = new System.Windows.Forms.Button();
            this.lblCurrentElementTreeView = new System.Windows.Forms.Label();
            this.sideBar = new System.Windows.Forms.Panel();
            this.btnDisconnectMySQL = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.pbAlter = new System.Windows.Forms.PictureBox();
            this.pbpTruncate = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbCreate = new System.Windows.Forms.PictureBox();
            this.lblCurrentSelectedElementTreeView = new System.Windows.Forms.Label();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnTruncate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnConnectDisconnectMySQL = new System.Windows.Forms.Button();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMySQL = new System.Windows.Forms.PictureBox();
            this.pbOurDDLApp = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.sideBar.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpTruncate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreate)).BeginInit();
            this.panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMySQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOurDDLApp)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(3, 66);
            this.treeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(292, 400);
            this.treeView.TabIndex = 4;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // btnGoBackTreeView
            // 
            this.btnGoBackTreeView.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBackTreeView.Location = new System.Drawing.Point(34, 481);
            this.btnGoBackTreeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGoBackTreeView.Name = "btnGoBackTreeView";
            this.btnGoBackTreeView.Size = new System.Drawing.Size(107, 28);
            this.btnGoBackTreeView.TabIndex = 7;
            this.btnGoBackTreeView.Text = "&Go back";
            this.btnGoBackTreeView.UseVisualStyleBackColor = true;
            this.btnGoBackTreeView.Click += new System.EventHandler(this.btnGoBackTreeView_Click);
            // 
            // lblCurrentElementTreeView
            // 
            this.lblCurrentElementTreeView.AutoSize = true;
            this.lblCurrentElementTreeView.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentElementTreeView.Location = new System.Drawing.Point(17, 26);
            this.lblCurrentElementTreeView.Name = "lblCurrentElementTreeView";
            this.lblCurrentElementTreeView.Size = new System.Drawing.Size(180, 24);
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
            this.sideBar.Location = new System.Drawing.Point(3, 5);
            this.sideBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(295, 561);
            this.sideBar.TabIndex = 15;
            this.sideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDisconnectMySQL
            // 
            this.btnDisconnectMySQL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnectMySQL.Location = new System.Drawing.Point(155, 481);
            this.btnDisconnectMySQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisconnectMySQL.Name = "btnDisconnectMySQL";
            this.btnDisconnectMySQL.Size = new System.Drawing.Size(107, 28);
            this.btnDisconnectMySQL.TabIndex = 23;
            this.btnDisconnectMySQL.Text = "&Disconnect";
            this.btnDisconnectMySQL.UseVisualStyleBackColor = true;
            this.btnDisconnectMySQL.Click += new System.EventHandler(this.btnDisconnectMySQL_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.pbAlter);
            this.panelHome.Controls.Add(this.pbpTruncate);
            this.panelHome.Controls.Add(this.pbDelete);
            this.panelHome.Controls.Add(this.pbCreate);
            this.panelHome.Controls.Add(this.lblCurrentSelectedElementTreeView);
            this.panelHome.Controls.Add(this.txtLogs);
            this.panelHome.Controls.Add(this.btnAlter);
            this.panelHome.Controls.Add(this.btnTruncate);
            this.panelHome.Controls.Add(this.btnDelete);
            this.panelHome.Controls.Add(this.btnCreate);
            this.panelHome.Controls.Add(this.sideBar);
            this.panelHome.Location = new System.Drawing.Point(-5, -6);
            this.panelHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(943, 566);
            this.panelHome.TabIndex = 16;
            this.panelHome.Visible = false;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pbAlter
            // 
            this.pbAlter.Image = global::OurDDLApp.Properties.Resources.iconfinder_edit_editor_pen_pencil_write_392507;
            this.pbAlter.Location = new System.Drawing.Point(337, 402);
            this.pbAlter.Name = "pbAlter";
            this.pbAlter.Size = new System.Drawing.Size(65, 65);
            this.pbAlter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlter.TabIndex = 26;
            this.pbAlter.TabStop = false;
            // 
            // pbpTruncate
            // 
            this.pbpTruncate.Image = global::OurDDLApp.Properties.Resources.iconfinder_Delete_discart_exit_less_line_minus_negative_no_premium_remove_392511;
            this.pbpTruncate.Location = new System.Drawing.Point(337, 294);
            this.pbpTruncate.Name = "pbpTruncate";
            this.pbpTruncate.Size = new System.Drawing.Size(65, 65);
            this.pbpTruncate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpTruncate.TabIndex = 25;
            this.pbpTruncate.TabStop = false;
            // 
            // pbDelete
            // 
            this.pbDelete.Image = global::OurDDLApp.Properties.Resources.iconfinder_close_delete_remove_icon_392517;
            this.pbDelete.Location = new System.Drawing.Point(337, 183);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(65, 65);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDelete.TabIndex = 24;
            this.pbDelete.TabStop = false;
            // 
            // pbCreate
            // 
            this.pbCreate.Image = global::OurDDLApp.Properties.Resources.iconfinder_add_cross_new_plus_create_392530;
            this.pbCreate.Location = new System.Drawing.Point(337, 71);
            this.pbCreate.Name = "pbCreate";
            this.pbCreate.Size = new System.Drawing.Size(65, 65);
            this.pbCreate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCreate.TabIndex = 23;
            this.pbCreate.TabStop = false;
            // 
            // lblCurrentSelectedElementTreeView
            // 
            this.lblCurrentSelectedElementTreeView.AutoSize = true;
            this.lblCurrentSelectedElementTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentSelectedElementTreeView.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSelectedElementTreeView.Location = new System.Drawing.Point(352, 31);
            this.lblCurrentSelectedElementTreeView.Name = "lblCurrentSelectedElementTreeView";
            this.lblCurrentSelectedElementTreeView.Size = new System.Drawing.Size(278, 26);
            this.lblCurrentSelectedElementTreeView.TabIndex = 22;
            this.lblCurrentSelectedElementTreeView.Text = "Current selected element";
            // 
            // txtLogs
            // 
            this.txtLogs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogs.Location = new System.Drawing.Point(304, 486);
            this.txtLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogs.Size = new System.Drawing.Size(632, 69);
            this.txtLogs.TabIndex = 21;
            this.txtLogs.Text = "Logs";
            // 
            // btnAlter
            // 
            this.btnAlter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlter.Location = new System.Drawing.Point(407, 402);
            this.btnAlter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(493, 65);
            this.btnAlter.TabIndex = 20;
            this.btnAlter.Text = "Alter";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnTruncate
            // 
            this.btnTruncate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruncate.Location = new System.Drawing.Point(407, 294);
            this.btnTruncate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTruncate.Name = "btnTruncate";
            this.btnTruncate.Size = new System.Drawing.Size(493, 65);
            this.btnTruncate.TabIndex = 19;
            this.btnTruncate.Text = "Truncate";
            this.btnTruncate.UseVisualStyleBackColor = true;
            this.btnTruncate.Click += new System.EventHandler(this.btnTruncate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(407, 182);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(493, 65);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(407, 71);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(493, 65);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnConnectDisconnectMySQL
            // 
            this.btnConnectDisconnectMySQL.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectDisconnectMySQL.Location = new System.Drawing.Point(196, 178);
            this.btnConnectDisconnectMySQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnectDisconnectMySQL.Name = "btnConnectDisconnectMySQL";
            this.btnConnectDisconnectMySQL.Size = new System.Drawing.Size(300, 52);
            this.btnConnectDisconnectMySQL.TabIndex = 16;
            this.btnConnectDisconnectMySQL.Text = "&Connect";
            this.btnConnectDisconnectMySQL.UseVisualStyleBackColor = true;
            this.btnConnectDisconnectMySQL.Click += new System.EventHandler(this.btnConnectDisconnectMySQL_Click);
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.label1);
            this.panelWelcome.Controls.Add(this.pbMySQL);
            this.panelWelcome.Controls.Add(this.pbOurDDLApp);
            this.panelWelcome.Controls.Add(this.lblTitle);
            this.panelWelcome.Controls.Add(this.btnConnectDisconnectMySQL);
            this.panelWelcome.Location = new System.Drawing.Point(967, 119);
            this.panelWelcome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(619, 441);
            this.panelWelcome.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Works with...";
            // 
            // pbMySQL
            // 
            this.pbMySQL.Image = global::OurDDLApp.Properties.Resources.index;
            this.pbMySQL.Location = new System.Drawing.Point(345, 256);
            this.pbMySQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbMySQL.Name = "pbMySQL";
            this.pbMySQL.Size = new System.Drawing.Size(117, 74);
            this.pbMySQL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMySQL.TabIndex = 19;
            this.pbMySQL.TabStop = false;
            // 
            // pbOurDDLApp
            // 
            this.pbOurDDLApp.Image = global::OurDDLApp.Properties.Resources.iconfinder_cascade_display_layout_stack_sw_view_392519;
            this.pbOurDDLApp.InitialImage = global::OurDDLApp.Properties.Resources.iconfinder_cascade_display_layout_stack_sw_view_392519;
            this.pbOurDDLApp.Location = new System.Drawing.Point(16, 23);
            this.pbOurDDLApp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbOurDDLApp.Name = "pbOurDDLApp";
            this.pbOurDDLApp.Size = new System.Drawing.Size(117, 123);
            this.pbOurDDLApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOurDDLApp.TabIndex = 18;
            this.pbOurDDLApp.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(140, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(406, 78);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "OurDDLApp";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnConnectDisconnectMySQL;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 556);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.panelHome);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurDDLApp";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpTruncate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreate)).EndInit();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMySQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOurDDLApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button btnGoBackTreeView;
        private System.Windows.Forms.Label lblCurrentElementTreeView;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnConnectDisconnectMySQL;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnTruncate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.Label lblCurrentSelectedElementTreeView;
        private System.Windows.Forms.Button btnDisconnectMySQL;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.PictureBox pbMySQL;
        private System.Windows.Forms.PictureBox pbOurDDLApp;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAlter;
        private System.Windows.Forms.PictureBox pbpTruncate;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbCreate;
    }
}

