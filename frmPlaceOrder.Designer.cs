namespace StockSYS
{
    partial class frmPlaceOrder
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblRequestor = new System.Windows.Forms.Label();
            this.txtRequestor = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.grdStock = new System.Windows.Forms.DataGridView();
            this.grpDept = new System.Windows.Forms.GroupBox();
            this.cboDepts = new System.Windows.Forms.ComboBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).BeginInit();
            this.grpDept.SuspendLayout();
            this.grpStock.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click_1);
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department Id";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(274, 165);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(100, 35);
            this.btnPlaceOrder.TabIndex = 12;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click_1);
            // 
            // lblRequestor
            // 
            this.lblRequestor.AutoSize = true;
            this.lblRequestor.Location = new System.Drawing.Point(23, 131);
            this.lblRequestor.Name = "lblRequestor";
            this.lblRequestor.Size = new System.Drawing.Size(56, 13);
            this.lblRequestor.TabIndex = 13;
            this.lblRequestor.Text = "Requestor";
            // 
            // txtRequestor
            // 
            this.txtRequestor.Enabled = false;
            this.txtRequestor.Location = new System.Drawing.Point(97, 131);
            this.txtRequestor.Name = "txtRequestor";
            this.txtRequestor.Size = new System.Drawing.Size(106, 20);
            this.txtRequestor.TabIndex = 14;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(26, 171);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 15;
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Enabled = false;
            this.txtLocation.Location = new System.Drawing.Point(96, 168);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(107, 20);
            this.txtLocation.TabIndex = 16;
            // 
            // grdStock
            // 
            this.grdStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStock.Location = new System.Drawing.Point(9, 19);
            this.grdStock.Name = "grdStock";
            this.grdStock.Size = new System.Drawing.Size(515, 79);
            this.grdStock.TabIndex = 20;
            this.grdStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStock_CellClick);
            // 
            // grpDept
            // 
            this.grpDept.Controls.Add(this.cboDepts);
            this.grpDept.Controls.Add(this.txtRequestor);
            this.grpDept.Controls.Add(this.label1);
            this.grpDept.Controls.Add(this.label3);
            this.grpDept.Controls.Add(this.txtOrderId);
            this.grpDept.Controls.Add(this.txtLocation);
            this.grpDept.Controls.Add(this.lblRequestor);
            this.grpDept.Controls.Add(this.lblLocation);
            this.grpDept.Location = new System.Drawing.Point(12, 27);
            this.grpDept.Name = "grpDept";
            this.grpDept.Size = new System.Drawing.Size(320, 235);
            this.grpDept.TabIndex = 23;
            this.grpDept.TabStop = false;
            this.grpDept.Text = "Department Details";
            // 
            // cboDepts
            // 
            this.cboDepts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepts.FormattingEnabled = true;
            this.cboDepts.Location = new System.Drawing.Point(96, 89);
            this.cboDepts.Name = "cboDepts";
            this.cboDepts.Size = new System.Drawing.Size(157, 21);
            this.cboDepts.TabIndex = 25;
            this.cboDepts.SelectedIndexChanged += new System.EventHandler(this.cboDepts_SelectedIndexChanged);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Enabled = false;
            this.txtOrderId.Location = new System.Drawing.Point(97, 43);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(54, 20);
            this.txtOrderId.TabIndex = 9;
            // 
            // grpStock
            // 
            this.grpStock.Controls.Add(this.txtQty);
            this.grpStock.Controls.Add(this.lblQuantity);
            this.grpStock.Controls.Add(this.btnAdd);
            this.grpStock.Controls.Add(this.grdStock);
            this.grpStock.Location = new System.Drawing.Point(127, 274);
            this.grpStock.Name = "grpStock";
            this.grpStock.Size = new System.Drawing.Size(542, 164);
            this.grpStock.TabIndex = 24;
            this.grpStock.TabStop = false;
            this.grpStock.Text = "Stock Details";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(84, 132);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(80, 20);
            this.txtQty.TabIndex = 23;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(23, 135);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 22;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(449, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add Stock";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.lstItems);
            this.grpOrder.Controls.Add(this.txtTotal);
            this.grpOrder.Controls.Add(this.lblTotal);
            this.grpOrder.Controls.Add(this.btnPlaceOrder);
            this.grpOrder.Location = new System.Drawing.Point(348, 27);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(440, 235);
            this.grpOrder.TabIndex = 25;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order Details";
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(23, 25);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(351, 134);
            this.lstItems.TabIndex = 15;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(60, 191);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(67, 20);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(23, 194);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // frmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grpStock);
            this.Controls.Add(this.grpDept);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPlaceOrder";
            this.Text = "Place Order";
            this.Load += new System.EventHandler(this.frmPlaceOrder_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).EndInit();
            this.grpDept.ResumeLayout(false);
            this.grpDept.PerformLayout();
            this.grpStock.ResumeLayout(false);
            this.grpStock.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lblRequestor;
        private System.Windows.Forms.TextBox txtRequestor;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.DataGridView grdStock;
        private System.Windows.Forms.GroupBox grpDept;
        private System.Windows.Forms.ComboBox cboDepts;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lstItems;
    }
}