namespace StockSYS
{
    partial class frmYearlyExpenditureReport
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
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pic2017 = new System.Windows.Forms.PictureBox();
            this.pic2018 = new System.Windows.Forms.PictureBox();
            this.pic2019 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2017)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2018)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2019)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(47, 20);
            this.mnuBack.Text = "Back ";
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
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(293, 35);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(159, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Please Select A Year to Analyse";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(308, 65);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 21);
            this.cboYear.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(472, 63);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pic2017
            // 
            this.pic2017.BackgroundImage = global::StockSYS.Properties.Resources._2017;
            this.pic2017.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic2017.Location = new System.Drawing.Point(62, 92);
            this.pic2017.Name = "pic2017";
            this.pic2017.Size = new System.Drawing.Size(696, 336);
            this.pic2017.TabIndex = 7;
            this.pic2017.TabStop = false;
            this.pic2017.Visible = false;
            // 
            // pic2018
            // 
            this.pic2018.BackgroundImage = global::StockSYS.Properties.Resources._2018;
            this.pic2018.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic2018.Location = new System.Drawing.Point(62, 92);
            this.pic2018.Name = "pic2018";
            this.pic2018.Size = new System.Drawing.Size(696, 336);
            this.pic2018.TabIndex = 6;
            this.pic2018.TabStop = false;
            this.pic2018.Visible = false;
            // 
            // pic2019
            // 
            this.pic2019.BackgroundImage = global::StockSYS.Properties.Resources._2019;
            this.pic2019.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic2019.Location = new System.Drawing.Point(62, 92);
            this.pic2019.Name = "pic2019";
            this.pic2019.Size = new System.Drawing.Size(696, 336);
            this.pic2019.TabIndex = 5;
            this.pic2019.TabStop = false;
            this.pic2019.Visible = false;
            // 
            // frmYearlyExpenditureReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pic2019);
            this.Controls.Add(this.pic2017);
            this.Controls.Add(this.pic2018);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmYearlyExpenditureReport";
            this.Text = "frmYearlyExpenditureReportcs";
            this.Load += new System.EventHandler(this.frmYearlyExpenditureReport_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2017)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2018)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2019)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pic2019;
        private System.Windows.Forms.PictureBox pic2018;
        private System.Windows.Forms.PictureBox pic2017;
    }
}