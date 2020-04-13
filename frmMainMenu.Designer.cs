namespace StockSYS
{
    partial class frmMainMenu
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegStock = new System.Windows.Forms.ToolStripMenuItem();
            this.frmChgStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemStock = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddDept = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateDept = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseDept = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenDep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYrlyExp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStock,
            this.departmentsToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.mnuExit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuStock
            // 
            this.mnuStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegStock,
            this.frmChgStock,
            this.mnuRemStock});
            this.mnuStock.Name = "mnuStock";
            this.mnuStock.Size = new System.Drawing.Size(48, 20);
            this.mnuStock.Text = "Stock";
            // 
            // mnuRegStock
            // 
            this.mnuRegStock.Name = "mnuRegStock";
            this.mnuRegStock.Size = new System.Drawing.Size(149, 22);
            this.mnuRegStock.Text = "Register Stock";
            this.mnuRegStock.Click += new System.EventHandler(this.mnuRegStock_Click);
            // 
            // frmChgStock
            // 
            this.frmChgStock.Name = "frmChgStock";
            this.frmChgStock.Size = new System.Drawing.Size(149, 22);
            this.frmChgStock.Text = "Change Stock";
            this.frmChgStock.Click += new System.EventHandler(this.frmChgStock_Click);
            // 
            // mnuRemStock
            // 
            this.mnuRemStock.Name = "mnuRemStock";
            this.mnuRemStock.Size = new System.Drawing.Size(149, 22);
            this.mnuRemStock.Text = "Remove Stock";
            this.mnuRemStock.Click += new System.EventHandler(this.mnuRemStock_Click);
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddDept,
            this.mnuUpdateDept,
            this.mnuCloseDept});
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.departmentsToolStripMenuItem.Text = "Departments";
            // 
            // mnuAddDept
            // 
            this.mnuAddDept.Name = "mnuAddDept";
            this.mnuAddDept.Size = new System.Drawing.Size(178, 22);
            this.mnuAddDept.Text = "Add Department";
            this.mnuAddDept.Click += new System.EventHandler(this.mnuAddDept_Click);
            // 
            // mnuUpdateDept
            // 
            this.mnuUpdateDept.Name = "mnuUpdateDept";
            this.mnuUpdateDept.Size = new System.Drawing.Size(178, 22);
            this.mnuUpdateDept.Text = "Update Department";
            this.mnuUpdateDept.Click += new System.EventHandler(this.mnuUpdateDept_Click);
            // 
            // mnuCloseDept
            // 
            this.mnuCloseDept.Name = "mnuCloseDept";
            this.mnuCloseDept.Size = new System.Drawing.Size(178, 22);
            this.mnuCloseDept.Text = "Close Department";
            this.mnuCloseDept.Click += new System.EventHandler(this.mnuCloseDept_Click_1);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateOrder,
            this.mnuCancelOrder});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // mnuUpdateOrder
            // 
            this.mnuUpdateOrder.Name = "mnuUpdateOrder";
            this.mnuUpdateOrder.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdateOrder.Text = "Update Order";
            this.mnuUpdateOrder.Click += new System.EventHandler(this.mnuUpdateOrder_Click);
            // 
            // mnuCancelOrder
            // 
            this.mnuCancelOrder.Name = "mnuCancelOrder";
            this.mnuCancelOrder.Size = new System.Drawing.Size(180, 22);
            this.mnuCancelOrder.Text = "Cancel Order";
            this.mnuCancelOrder.Click += new System.EventHandler(this.mnuCancelOrder_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenDep,
            this.mnuYrlyExp});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // mnuGenDep
            // 
            this.mnuGenDep.Name = "mnuGenDep";
            this.mnuGenDep.Size = new System.Drawing.Size(233, 22);
            this.mnuGenDep.Text = "Generate Department Analysis";
            this.mnuGenDep.Click += new System.EventHandler(this.mnuGenDep_Click);
            // 
            // mnuYrlyExp
            // 
            this.mnuYrlyExp.Name = "mnuYrlyExp";
            this.mnuYrlyExp.Size = new System.Drawing.Size(233, 22);
            this.mnuYrlyExp.Text = "Yearly Expenditure Report";
            this.mnuYrlyExp.Click += new System.EventHandler(this.mnuYrlyExp_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // picImage
            // 
            this.picImage.BackgroundImage = global::StockSYS.Properties.Resources.Bon_Secours_Tralee_1080x720;
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImage.Location = new System.Drawing.Point(12, 27);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(776, 411);
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuRegStock;
        private System.Windows.Forms.ToolStripMenuItem frmChgStock;
        private System.Windows.Forms.ToolStripMenuItem mnuRemStock;
        private System.Windows.Forms.ToolStripMenuItem mnuAddDept;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateDept;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseDept;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateOrder;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.ToolStripMenuItem mnuGenDep;
        private System.Windows.Forms.ToolStripMenuItem mnuYrlyExp;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelOrder;
    }
}