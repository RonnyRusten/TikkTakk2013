namespace TikkTakk2013.Forms
{
    partial class FrmSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSummary));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpActivities = new System.Windows.Forms.TabPage();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbLastWeek = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbWeek = new System.Windows.Forms.RadioButton();
            this.rbToday = new System.Windows.Forms.RadioButton();
            this.tpStatistics = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tpActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpActivities);
            this.tabControl1.Controls.Add(this.tpStatistics);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tpActivities
            // 
            this.tpActivities.Controls.Add(this.dgvSummary);
            this.tpActivities.Controls.Add(this.GroupBox1);
            this.tpActivities.Location = new System.Drawing.Point(4, 22);
            this.tpActivities.Name = "tpActivities";
            this.tpActivities.Padding = new System.Windows.Forms.Padding(3);
            this.tpActivities.Size = new System.Drawing.Size(596, 435);
            this.tpActivities.TabIndex = 0;
            this.tpActivities.Text = "Aktiviteter";
            this.tpActivities.UseVisualStyleBackColor = true;
            // 
            // dgvSummary
            // 
            this.dgvSummary.AllowUserToAddRows = false;
            this.dgvSummary.AllowUserToDeleteRows = false;
            this.dgvSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Location = new System.Drawing.Point(8, 60);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.RowHeadersVisible = false;
            this.dgvSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSummary.Size = new System.Drawing.Size(580, 367);
            this.dgvSummary.TabIndex = 3;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.lblTo);
            this.GroupBox1.Controls.Add(this.lblFrom);
            this.GroupBox1.Controls.Add(this.dtpEnd);
            this.GroupBox1.Controls.Add(this.dtpStart);
            this.GroupBox1.Controls.Add(this.rbCustom);
            this.GroupBox1.Controls.Add(this.rbLastWeek);
            this.GroupBox1.Controls.Add(this.rbAll);
            this.GroupBox1.Controls.Add(this.rbWeek);
            this.GroupBox1.Controls.Add(this.rbToday);
            this.GroupBox1.Location = new System.Drawing.Point(8, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(582, 48);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Vis aktiviteter";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Enabled = false;
            this.lblTo.Location = new System.Drawing.Point(457, 21);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(18, 13);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "Til";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Enabled = false;
            this.lblFrom.Location = new System.Drawing.Point(335, 21);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(22, 13);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.Text = "Fra";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(481, 19);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(92, 20);
            this.dtpEnd.TabIndex = 6;
            this.dtpEnd.CloseUp += new System.EventHandler(this.dtpEnd_CloseUp);
            // 
            // dtpStart
            // 
            this.dtpStart.Enabled = false;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(359, 19);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(92, 20);
            this.dtpStart.TabIndex = 5;
            this.dtpStart.CloseUp += new System.EventHandler(this.dtpStart_CloseUp);
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(283, 19);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(46, 17);
            this.rbCustom.TabIndex = 4;
            this.rbCustom.TabStop = true;
            this.rbCustom.Text = "Velg";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // rbLastWeek
            // 
            this.rbLastWeek.AutoSize = true;
            this.rbLastWeek.Location = new System.Drawing.Point(153, 19);
            this.rbLastWeek.Name = "rbLastWeek";
            this.rbLastWeek.Size = new System.Drawing.Size(78, 17);
            this.rbLastWeek.TabIndex = 3;
            this.rbLastWeek.TabStop = true;
            this.rbLastWeek.Text = "Forrige uke";
            this.rbLastWeek.UseVisualStyleBackColor = true;
            this.rbLastWeek.CheckedChanged += new System.EventHandler(this.rbLastWeek_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(235, 19);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(42, 17);
            this.rbAll.TabIndex = 2;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Alle";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbWeek
            // 
            this.rbWeek.AutoSize = true;
            this.rbWeek.Location = new System.Drawing.Point(63, 19);
            this.rbWeek.Name = "rbWeek";
            this.rbWeek.Size = new System.Drawing.Size(84, 17);
            this.rbWeek.TabIndex = 1;
            this.rbWeek.TabStop = true;
            this.rbWeek.Text = "Denne uken";
            this.rbWeek.UseVisualStyleBackColor = true;
            this.rbWeek.CheckedChanged += new System.EventHandler(this.rbWeek_CheckedChanged);
            // 
            // rbToday
            // 
            this.rbToday.AutoSize = true;
            this.rbToday.Location = new System.Drawing.Point(8, 19);
            this.rbToday.Name = "rbToday";
            this.rbToday.Size = new System.Drawing.Size(49, 17);
            this.rbToday.TabIndex = 0;
            this.rbToday.TabStop = true;
            this.rbToday.Text = "I dag";
            this.rbToday.UseVisualStyleBackColor = true;
            this.rbToday.CheckedChanged += new System.EventHandler(this.rbToday_CheckedChanged);
            // 
            // tpStatistics
            // 
            this.tpStatistics.Location = new System.Drawing.Point(4, 22);
            this.tpStatistics.Name = "tpStatistics";
            this.tpStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tpStatistics.Size = new System.Drawing.Size(596, 435);
            this.tpStatistics.TabIndex = 1;
            this.tpStatistics.Text = "Statistikk";
            this.tpStatistics.UseVisualStyleBackColor = true;
            // 
            // FrmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(620, 500);
            this.Name = "FrmSummary";
            this.Text = "Oppsumering";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSummary_FormClosing);
            this.Load += new System.EventHandler(this.FrmSummary_Load);
            this.Move += new System.EventHandler(this.FrmSummary_Move);
            this.tabControl1.ResumeLayout(false);
            this.tpActivities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpActivities;
        internal System.Windows.Forms.DataGridView dgvSummary;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblTo;
        internal System.Windows.Forms.Label lblFrom;
        internal System.Windows.Forms.DateTimePicker dtpEnd;
        internal System.Windows.Forms.DateTimePicker dtpStart;
        internal System.Windows.Forms.RadioButton rbCustom;
        internal System.Windows.Forms.RadioButton rbLastWeek;
        internal System.Windows.Forms.RadioButton rbAll;
        internal System.Windows.Forms.RadioButton rbWeek;
        internal System.Windows.Forms.RadioButton rbToday;
        private System.Windows.Forms.TabPage tpStatistics;
    }
}