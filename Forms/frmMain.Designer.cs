namespace TikkTakk2013
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnActivities = new System.Windows.Forms.ToolStripButton();
            this.btnStats = new System.Windows.Forms.ToolStripButton();
            this.btnSetup = new System.Windows.Forms.ToolStripButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.tmrStatus = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.gbActivities = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnActivities,
            this.btnStats,
            this.btnSetup});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnActivities
            // 
            this.btnActivities.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActivities.Image = global::TikkTakk2013.Properties.Resources.Wizard;
            this.btnActivities.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(23, 22);
            this.btnActivities.Text = "Aktiviteter";
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
            // 
            // btnStats
            // 
            this.btnStats.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStats.Image = global::TikkTakk2013.Properties.Resources.Table;
            this.btnStats.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(23, 22);
            this.btnStats.Text = "toolStripButton2";
            this.btnStats.ToolTipText = "Sammendrag";
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSetup.Image = global::TikkTakk2013.Properties.Resources.Tool;
            this.btnSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(23, 22);
            this.btnSetup.Text = "toolStripButton1";
            this.btnSetup.ToolTipText = "Innstillinger";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 39);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "lblDate";
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // tmrStatus
            // 
            this.tmrStatus.Interval = 5000;
            this.tmrStatus.Tick += new System.EventHandler(this.tmrStatus_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(187, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 31);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "lblTime";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbActivities
            // 
            this.gbActivities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbActivities.Location = new System.Drawing.Point(5, 55);
            this.gbActivities.Name = "gbActivities";
            this.gbActivities.Size = new System.Drawing.Size(275, 253);
            this.gbActivities.TabIndex = 3;
            this.gbActivities.TabStop = false;
            this.gbActivities.Text = "Aktiviteter";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotal,
            this.lblStatus2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = false;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(118, 17);
            this.lblTotal.Text = "toolStripStatusLabel1";
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = false;
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(118, 17);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 345);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbActivities);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(230, 190);
            this.Name = "frmMain";
            this.Text = "TikkTakk 2013";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Move += new System.EventHandler(this.frmMain_Move);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSetup;
        private System.Windows.Forms.ToolStripButton btnStats;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Timer tmrStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox gbActivities;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotal;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus2;
        private System.Windows.Forms.ToolStripButton btnActivities;
    }
}

