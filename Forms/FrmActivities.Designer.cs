namespace TikkTakk2013.Forms
{
    partial class FrmActivities
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActivities));
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.cbDefaultActivity = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActivities
            // 
            this.dgvActivities.AllowUserToDeleteRows = false;
            this.dgvActivities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Location = new System.Drawing.Point(12, 35);
            this.dgvActivities.MultiSelect = false;
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.RowHeadersVisible = false;
            this.dgvActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivities.Size = new System.Drawing.Size(321, 224);
            this.dgvActivities.TabIndex = 0;
            this.dgvActivities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivities_CellContentClick);
            this.dgvActivities.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivities_CellEndEdit);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(12, 12);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(96, 17);
            this.chkActive.TabIndex = 1;
            this.chkActive.Text = "Vis bare aktive";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // cbDefaultActivity
            // 
            this.cbDefaultActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDefaultActivity.FormattingEnabled = true;
            this.cbDefaultActivity.Location = new System.Drawing.Point(111, 265);
            this.cbDefaultActivity.Name = "cbDefaultActivity";
            this.cbDefaultActivity.Size = new System.Drawing.Size(222, 21);
            this.cbDefaultActivity.TabIndex = 14;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 268);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(92, 13);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Oppstartsaktivitet:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(258, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(177, 292);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 327);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbDefaultActivity);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.dgvActivities);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FrmActivities";
            this.Text = "Aktiviteter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmActivities_FormClosing);
            this.Load += new System.EventHandler(this.FrmActivities_Load);
            this.Move += new System.EventHandler(this.FrmActivities_Move);
            this.Resize += new System.EventHandler(this.FrmActivities_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActivities;
        private System.Windows.Forms.CheckBox chkActive;
        internal System.Windows.Forms.ComboBox cbDefaultActivity;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}