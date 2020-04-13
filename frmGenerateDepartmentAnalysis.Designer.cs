namespace StockSYS
{
    partial class frmGenerateDepartmentAnalysis
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.cboDepartments = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.picClinics = new System.Windows.Forms.PictureBox();
            this.picLab = new System.Windows.Forms.PictureBox();
            this.picMedRec19 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClinics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedRec19)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(325, 36);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(192, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Please Select A Department to Analyse";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // cboDepartments
            // 
            this.cboDepartments.FormattingEnabled = true;
            this.cboDepartments.Location = new System.Drawing.Point(326, 62);
            this.cboDepartments.Name = "cboDepartments";
            this.cboDepartments.Size = new System.Drawing.Size(191, 21);
            this.cboDepartments.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(569, 60);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // picClinics
            // 
            this.picClinics.BackgroundImage = global::StockSYS.Properties.Resources.Clinics2019;
            this.picClinics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClinics.Location = new System.Drawing.Point(56, 89);
            this.picClinics.Name = "picClinics";
            this.picClinics.Size = new System.Drawing.Size(802, 441);
            this.picClinics.TabIndex = 5;
            this.picClinics.TabStop = false;
            this.picClinics.Visible = false;
            // 
            // picLab
            // 
            this.picLab.BackgroundImage = global::StockSYS.Properties.Resources.Laboratory2019;
            this.picLab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLab.Location = new System.Drawing.Point(56, 89);
            this.picLab.Name = "picLab";
            this.picLab.Size = new System.Drawing.Size(802, 441);
            this.picLab.TabIndex = 4;
            this.picLab.TabStop = false;
            this.picLab.Visible = false;
            // 
            // picMedRec19
            // 
            this.picMedRec19.BackgroundImage = global::StockSYS.Properties.Resources.MedicalRecords_2019;
            this.picMedRec19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMedRec19.Location = new System.Drawing.Point(56, 89);
            this.picMedRec19.Name = "picMedRec19";
            this.picMedRec19.Size = new System.Drawing.Size(802, 437);
            this.picMedRec19.TabIndex = 0;
            this.picMedRec19.TabStop = false;
            this.picMedRec19.Visible = false;
            // 
            // frmGenerateDepartmentAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 542);
            this.Controls.Add(this.picClinics);
            this.Controls.Add(this.picLab);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.picMedRec19);
            this.Controls.Add(this.cboDepartments);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGenerateDepartmentAnalysis";
            this.Text = "frmGenerateDepartmentAnalysis";
            this.Load += new System.EventHandler(this.frmGenerateDepartmentAnalysis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClinics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedRec19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox cboDepartments;
        private System.Windows.Forms.PictureBox picMedRec19;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox picLab;
        private System.Windows.Forms.PictureBox picClinics;
    }
}