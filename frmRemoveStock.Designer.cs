namespace StockSYS
{
    partial class frmRemoveStock
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtStockId = new System.Windows.Forms.TextBox();
            this.btnRemStock = new System.Windows.Forms.Button();
            this.lblStockId = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStock.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(311, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(148, 126);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(100, 21);
            this.cboStatus.TabIndex = 1;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(148, 94);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(81, 20);
            this.txtCost.TabIndex = 2;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(148, 61);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(71, 20);
            this.txtQty.TabIndex = 3;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(148, 31);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 4;
            // 
            // txtStockId
            // 
            this.txtStockId.Location = new System.Drawing.Point(161, 45);
            this.txtStockId.Name = "txtStockId";
            this.txtStockId.Size = new System.Drawing.Size(100, 20);
            this.txtStockId.TabIndex = 5;
            // 
            // btnRemStock
            // 
            this.btnRemStock.Location = new System.Drawing.Point(148, 184);
            this.btnRemStock.Name = "btnRemStock";
            this.btnRemStock.Size = new System.Drawing.Size(100, 23);
            this.btnRemStock.TabIndex = 6;
            this.btnRemStock.Text = "Remove Stock";
            this.btnRemStock.UseVisualStyleBackColor = true;
            this.btnRemStock.Click += new System.EventHandler(this.btnRemStock_Click);
            // 
            // lblStockId
            // 
            this.lblStockId.AutoSize = true;
            this.lblStockId.Location = new System.Drawing.Point(109, 48);
            this.lblStockId.Name = "lblStockId";
            this.lblStockId.Size = new System.Drawing.Size(47, 13);
            this.lblStockId.TabIndex = 7;
            this.lblStockId.Text = "Stock Id";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(45, 34);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Description";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(17, 64);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(88, 13);
            this.lblQty.TabIndex = 9;
            this.lblQty.Text = "Quantity in Stock";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(24, 97);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(81, 13);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Cost per Supply";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(68, 129);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // grpStock
            // 
            this.grpStock.Controls.Add(this.lblStatus);
            this.grpStock.Controls.Add(this.lblCost);
            this.grpStock.Controls.Add(this.lblQty);
            this.grpStock.Controls.Add(this.lblDesc);
            this.grpStock.Controls.Add(this.btnRemStock);
            this.grpStock.Controls.Add(this.txtDesc);
            this.grpStock.Controls.Add(this.txtQty);
            this.grpStock.Controls.Add(this.txtCost);
            this.grpStock.Controls.Add(this.cboStatus);
            this.grpStock.Location = new System.Drawing.Point(117, 109);
            this.grpStock.Name = "grpStock";
            this.grpStock.Size = new System.Drawing.Size(357, 257);
            this.grpStock.TabIndex = 12;
            this.grpStock.TabStop = false;
            this.grpStock.Text = "Change Details";
            this.grpStock.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmRemoveStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpStock);
            this.Controls.Add(this.lblStockId);
            this.Controls.Add(this.txtStockId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRemoveStock";
            this.Text = "frmRemoveStock";
            this.Load += new System.EventHandler(this.frmRemoveStock_Load);
            this.grpStock.ResumeLayout(false);
            this.grpStock.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtStockId;
        private System.Windows.Forms.Button btnRemStock;
        private System.Windows.Forms.Label lblStockId;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}