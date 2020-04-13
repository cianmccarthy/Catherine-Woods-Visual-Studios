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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChgStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveStock = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddDept = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateDept = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateDepartmentAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyExpenditureReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCloseDept = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StockSYS.Properties.Resources.Bon_Secours_Tralee_1080x720;
            this.pictureBox1.InitialImage = global::StockSYS.Properties.Resources.Bon_Secours_Tralee_1080x720;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 382);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mnuStock
            // 
            this.mnuStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterStock,
            this.mnuChgStock,
            this.mnuRemoveStock});
            this.mnuStock.Name = "mnuStock";
            this.mnuStock.Size = new System.Drawing.Size(48, 20);
            this.mnuStock.Text = "Stock";
            // 
            // mnuRegisterStock
            // 
            this.mnuRegisterStock.Name = "mnuRegisterStock";
            this.mnuRegisterStock.Size = new System.Drawing.Size(149, 22);
            this.mnuRegisterStock.Text = "Register Stock";
            this.mnuRegisterStock.Click += new System.EventHandler(this.mnuRegisterStock_Click);
            // 
            // mnuChgStock
            // 
            this.mnuChgStock.Name = "mnuChgStock";
            this.mnuChgStock.Size = new System.Drawing.Size(149, 22);
            this.mnuChgStock.Text = "Change Stock";
            this.mnuChgStock.Click += new System.EventHandler(this.mnuChgStock_Click);
            // 
            // mnuRemoveStock
            // 
            this.mnuRemoveStock.Name = "mnuRemoveStock";
            this.mnuRemoveStock.Size = new System.Drawing.Size(149, 22);
            this.mnuRemoveStock.Text = "Remove Stock";
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
            this.mnuAddDept.Size = new System.Drawing.Size(180, 22);
            this.mnuAddDept.Text = "Add Department";
            this.mnuAddDept.Click += new System.EventHandler(this.mnuAddDept_Click_1);
            // 
            // mnuUpdateDept
            // 
            this.mnuUpdateDept.Name = "mnuUpdateDept";
            this.mnuUpdateDept.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdateDept.Text = "Update Department";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeOrderToolStripMenuItem,
            this.updateOrderToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            // 
            // updateOrderToolStripMenuItem
            // 
            this.updateOrderToolStripMenuItem.Name = "updateOrderToolStripMenuItem";
            this.updateOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateOrderToolStripMenuItem.Text = "Update Order";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateDepartmentAnalysisToolStripMenuItem,
            this.yearlyExpenditureReportToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // generateDepartmentAnalysisToolStripMenuItem
            // 
            this.generateDepartmentAnalysisToolStripMenuItem.Name = "generateDepartmentAnalysisToolStripMenuItem";
            this.generateDepartmentAnalysisToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.generateDepartmentAnalysisToolStripMenuItem.Text = "Generate Department Analysis";
            // 
            // yearlyExpenditureReportToolStripMenuItem
            // 
            this.yearlyExpenditureReportToolStripMenuItem.Name = "yearlyExpenditureReportToolStripMenuItem";
            this.yearlyExpenditureReportToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.yearlyExpenditureReportToolStripMenuItem.Text = "Yearly Expenditure Report";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStock,
            this.departmentsToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.administrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCloseDept
            // 
            this.mnuCloseDept.Name = "mnuCloseDept";
            this.mnuCloseDept.Size = new System.Drawing.Size(180, 22);
            this.mnuCloseDept.Text = "Close Department";
            this.mnuCloseDept.Click += new System.EventHandler(this.mnuCloseDept_Click_1);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 449);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMainMenu";
            this.Text = "BSH - Stock Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterStock;
        private System.Windows.Forms.ToolStripMenuItem mnuChgStock;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddDept;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateDept;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateDepartmentAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyExpenditureReportToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveStock;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseDept;
    }
}

