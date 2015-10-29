namespace TikkTakk2013.Controls
{
    partial class Activity
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mMoveValue = new System.Windows.Forms.ToolStripMenuItem();
            this.mClearStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Controls.Add(this.btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.time, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 33);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.AutoEllipsis = true;
            this.btn.Location = new System.Drawing.Point(4, 4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(217, 25);
            this.btn.TabIndex = 0;
            this.btn.Text = "btn";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.time.ContextMenuStrip = this.contextMenuStrip1;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(228, 4);
            this.time.Name = "time";
            this.time.ShowUpDown = true;
            this.time.Size = new System.Drawing.Size(79, 24);
            this.time.TabIndex = 2;
            this.time.ValueChanged += new System.EventHandler(this.time_ValueChanged);
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mClear,
            this.mClearStop,
            this.mMoveValue});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 70);
            // 
            // mClear
            // 
            this.mClear.Name = "mClear";
            this.mClear.Size = new System.Drawing.Size(184, 22);
            this.mClear.Text = "Nullstill";
            this.mClear.Click += new System.EventHandler(this.mClear_Click);
            // 
            // mMoveValue
            // 
            this.mMoveValue.Name = "mMoveValue";
            this.mMoveValue.Size = new System.Drawing.Size(184, 22);
            this.mMoveValue.Text = "Flytt verdi til aktivitet";
            // 
            // mClearStop
            // 
            this.mClearStop.Name = "mClearStop";
            this.mClearStop.Size = new System.Drawing.Size(184, 22);
            this.mClearStop.Text = "Nullstill og stopp";
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Activity";
            this.Size = new System.Drawing.Size(311, 33);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mClear;
        private System.Windows.Forms.ToolStripMenuItem mMoveValue;
        private System.Windows.Forms.ToolStripMenuItem mClearStop;
    }
}
