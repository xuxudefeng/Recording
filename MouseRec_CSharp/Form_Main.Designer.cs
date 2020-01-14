﻿namespace MouseRec_CSharp
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.MetrotipAll = new MetroFramework.Components.MetroToolTip();
            this.MetrolblState = new MetroFramework.Controls.MetroLabel();
            this.ToolStripMenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.MetrocmsRec = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mousebutton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetropnlState = new MetroFramework.Controls.MetroPanel();
            this.dgvRec = new System.Windows.Forms.DataGridView();
            this.lblHotkey = new MetroFramework.Controls.MetroLabel();
            this.llbExplain = new System.Windows.Forms.LinkLabel();
            this.bgwRun = new System.ComponentModel.BackgroundWorker();
            this.btnPlayback = new MetroFramework.Controls.MetroButton();
            this.lblLog = new MetroFramework.Controls.MetroLabel();
            this.btnRecording = new MetroFramework.Controls.MetroButton();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.chkLoop = new MetroFramework.Controls.MetroCheckBox();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.lblInterval = new MetroFramework.Controls.MetroLabel();
            this.lblCursorPosition = new MetroFramework.Controls.MetroLabel();
            this.grpExplain = new System.Windows.Forms.GroupBox();
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.MetrocmsRec.SuspendLayout();
            this.MetropnlState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            this.grpExplain.SuspendLayout();
            this.grpPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetrotipAll
            // 
            this.MetrotipAll.Style = MetroFramework.MetroColorStyle.Default;
            this.MetrotipAll.StyleManager = null;
            this.MetrotipAll.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // MetrolblState
            // 
            this.MetrolblState.AutoSize = true;
            this.MetrolblState.Location = new System.Drawing.Point(3, 6);
            this.MetrolblState.Name = "MetrolblState";
            this.MetrolblState.Size = new System.Drawing.Size(84, 20);
            this.MetrolblState.TabIndex = 10;
            this.MetrolblState.Text = "MetroLabel1";
            // 
            // ToolStripMenuItemExport
            // 
            this.ToolStripMenuItemExport.Name = "ToolStripMenuItemExport";
            this.ToolStripMenuItemExport.Size = new System.Drawing.Size(113, 24);
            this.ToolStripMenuItemExport.Text = "保存记录";
            this.ToolStripMenuItemExport.Click += new System.EventHandler(this.ToolStripMenuItemExport_Click);
            // 
            // ToolStripMenuItemImport
            // 
            this.ToolStripMenuItemImport.Name = "ToolStripMenuItemImport";
            this.ToolStripMenuItemImport.Size = new System.Drawing.Size(113, 24);
            this.ToolStripMenuItemImport.Text = "载入记录";
            this.ToolStripMenuItemImport.Click += new System.EventHandler(this.ToolStripMenuItemImport_Click);
            // 
            // MetrocmsRec
            // 
            this.MetrocmsRec.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MetrocmsRec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemImport,
            this.ToolStripMenuItemExport});
            this.MetrocmsRec.Name = "MetroContextMenu1";
            this.MetrocmsRec.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MetrocmsRec.ShowImageMargin = false;
            this.MetrocmsRec.Size = new System.Drawing.Size(114, 52);
            this.MetrocmsRec.Opening += new System.ComponentModel.CancelEventHandler(this.MetrocmsRec_Opening);
            // 
            // interval
            // 
            this.interval.HeaderText = "间隔（秒）";
            this.interval.MinimumWidth = 6;
            this.interval.Name = "interval";
            this.interval.ReadOnly = true;
            // 
            // mousebutton
            // 
            this.mousebutton.HeaderText = "按键";
            this.mousebutton.MinimumWidth = 6;
            this.mousebutton.Name = "mousebutton";
            this.mousebutton.ReadOnly = true;
            this.mousebutton.Width = 61;
            // 
            // position
            // 
            this.position.HeaderText = "坐标";
            this.position.MinimumWidth = 6;
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.Width = 61;
            // 
            // id
            // 
            this.id.HeaderText = "序号";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 61;
            // 
            // MetropnlState
            // 
            this.MetropnlState.Controls.Add(this.MetrolblState);
            this.MetropnlState.HorizontalScrollbarBarColor = true;
            this.MetropnlState.HorizontalScrollbarHighlightOnWheel = false;
            this.MetropnlState.HorizontalScrollbarSize = 10;
            this.MetropnlState.Location = new System.Drawing.Point(1, 463);
            this.MetropnlState.Name = "MetropnlState";
            this.MetropnlState.Size = new System.Drawing.Size(426, 32);
            this.MetropnlState.TabIndex = 19;
            this.MetropnlState.VerticalScrollbarBarColor = true;
            this.MetropnlState.VerticalScrollbarHighlightOnWheel = false;
            this.MetropnlState.VerticalScrollbarSize = 10;
            // 
            // dgvRec
            // 
            this.dgvRec.AllowUserToAddRows = false;
            this.dgvRec.AllowUserToResizeRows = false;
            this.dgvRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.position,
            this.mousebutton,
            this.interval});
            this.dgvRec.ContextMenuStrip = this.MetrocmsRec;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRec.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRec.EnableHeadersVisualStyles = false;
            this.dgvRec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRec.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRec.Location = new System.Drawing.Point(12, 310);
            this.dgvRec.MultiSelect = false;
            this.dgvRec.Name = "dgvRec";
            this.dgvRec.ReadOnly = true;
            this.dgvRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRec.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRec.RowHeadersWidth = 51;
            this.dgvRec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRec.RowTemplate.Height = 27;
            this.dgvRec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRec.Size = new System.Drawing.Size(401, 147);
            this.dgvRec.TabIndex = 18;
            this.dgvRec.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvRec_UserDeletedRow);
            // 
            // lblHotkey
            // 
            this.lblHotkey.AutoSize = true;
            this.lblHotkey.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblHotkey.Location = new System.Drawing.Point(232, 126);
            this.lblHotkey.Name = "lblHotkey";
            this.lblHotkey.Size = new System.Drawing.Size(24, 20);
            this.lblHotkey.TabIndex = 17;
            this.lblHotkey.Text = "F8";
            this.lblHotkey.Visible = false;
            // 
            // llbExplain
            // 
            this.llbExplain.LinkArea = new System.Windows.Forms.LinkArea(19, 30);
            this.llbExplain.Location = new System.Drawing.Point(6, 21);
            this.llbExplain.Name = "llbExplain";
            this.llbExplain.Size = new System.Drawing.Size(134, 53);
            this.llbExplain.TabIndex = 9;
            this.llbExplain.TabStop = true;
            this.llbExplain.Text = "录制鼠标动作进行回放   - by  fesugar.com";
            this.llbExplain.UseCompatibleTextRendering = true;
            // 
            // bgwRun
            // 
            this.bgwRun.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwRun_DoWork);
            this.bgwRun.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwRun_ProgressChanged);
            this.bgwRun.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwRun_RunWorkerCompleted);
            // 
            // btnPlayback
            // 
            this.btnPlayback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayback.Location = new System.Drawing.Point(12, 126);
            this.btnPlayback.Name = "btnPlayback";
            this.btnPlayback.Size = new System.Drawing.Size(214, 31);
            this.btnPlayback.TabIndex = 15;
            this.btnPlayback.Text = "动作回放";
            this.btnPlayback.UseSelectable = true;
            this.btnPlayback.Click += new System.EventHandler(this.BtnPlayback_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 287);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(69, 20);
            this.lblLog.TabIndex = 14;
            this.lblLog.Text = "操作日志";
            // 
            // btnRecording
            // 
            this.btnRecording.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecording.Location = new System.Drawing.Point(12, 83);
            this.btnRecording.Name = "btnRecording";
            this.btnRecording.Size = new System.Drawing.Size(214, 30);
            this.btnRecording.TabIndex = 13;
            this.btnRecording.Text = "录制动作";
            this.btnRecording.UseSelectable = true;
            this.btnRecording.Click += new System.EventHandler(this.BtnRecording_Click);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdown.Font = new System.Drawing.Font("宋体", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCountdown.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCountdown.Location = new System.Drawing.Point(125, 0);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(109, 117);
            this.lblCountdown.TabIndex = 12;
            this.lblCountdown.Text = "3";
            this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(310, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 29);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "重置";
            this.btnReset.UseSelectable = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // chkLoop
            // 
            this.chkLoop.AutoSize = true;
            this.chkLoop.Location = new System.Drawing.Point(220, 82);
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(136, 17);
            this.chkLoop.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkLoop.TabIndex = 7;
            this.chkLoop.Text = "已停用循环回放";
            this.chkLoop.UseSelectable = true;
            this.chkLoop.CheckStateChanged += new System.EventHandler(this.ChkLoop_CheckStateChanged);
            // 
            // nudSecond
            // 
            this.nudSecond.Location = new System.Drawing.Point(16, 82);
            this.nudSecond.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(109, 25);
            this.nudSecond.TabIndex = 3;
            this.nudSecond.TabStop = false;
            this.nudSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSecond.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(11, 54);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(114, 20);
            this.lblInterval.TabIndex = 1;
            this.lblInterval.Text = "间隔时间（秒）";
            // 
            // lblCursorPosition
            // 
            this.lblCursorPosition.AutoSize = true;
            this.lblCursorPosition.Location = new System.Drawing.Point(11, 25);
            this.lblCursorPosition.Name = "lblCursorPosition";
            this.lblCursorPosition.Size = new System.Drawing.Size(84, 20);
            this.lblCursorPosition.TabIndex = 0;
            this.lblCursorPosition.Text = "光标位置：";
            // 
            // grpExplain
            // 
            this.grpExplain.Controls.Add(this.llbExplain);
            this.grpExplain.Location = new System.Drawing.Point(267, 83);
            this.grpExplain.Name = "grpExplain";
            this.grpExplain.Size = new System.Drawing.Size(146, 79);
            this.grpExplain.TabIndex = 16;
            this.grpExplain.TabStop = false;
            this.grpExplain.Text = "说明";
            // 
            // grpPreview
            // 
            this.grpPreview.Controls.Add(this.lblCountdown);
            this.grpPreview.Controls.Add(this.btnReset);
            this.grpPreview.Controls.Add(this.chkLoop);
            this.grpPreview.Controls.Add(this.nudSecond);
            this.grpPreview.Controls.Add(this.lblInterval);
            this.grpPreview.Controls.Add(this.lblCursorPosition);
            this.grpPreview.Location = new System.Drawing.Point(12, 168);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Size = new System.Drawing.Size(401, 115);
            this.grpPreview.TabIndex = 12;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "预览";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 497);
            this.Controls.Add(this.MetropnlState);
            this.Controls.Add(this.dgvRec);
            this.Controls.Add(this.lblHotkey);
            this.Controls.Add(this.btnPlayback);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnRecording);
            this.Controls.Add(this.grpExplain);
            this.Controls.Add(this.grpPreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Opacity = 0.97D;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "鼠标动作录制工具";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.MetrocmsRec.ResumeLayout(false);
            this.MetropnlState.ResumeLayout(false);
            this.MetropnlState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            this.grpExplain.ResumeLayout(false);
            this.grpPreview.ResumeLayout(false);
            this.grpPreview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Components.MetroToolTip MetrotipAll;
        internal MetroFramework.Controls.MetroLabel MetrolblState;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExport;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemImport;
        internal MetroFramework.Controls.MetroContextMenu MetrocmsRec;
        internal System.Windows.Forms.DataGridViewTextBoxColumn interval;
        internal System.Windows.Forms.DataGridViewTextBoxColumn mousebutton;
        internal System.Windows.Forms.DataGridViewTextBoxColumn position;
        internal System.Windows.Forms.DataGridViewTextBoxColumn id;
        internal MetroFramework.Controls.MetroPanel MetropnlState;
        internal System.Windows.Forms.DataGridView dgvRec;
        internal MetroFramework.Controls.MetroLabel lblHotkey;
        internal System.Windows.Forms.LinkLabel llbExplain;
        internal System.ComponentModel.BackgroundWorker bgwRun;
        internal MetroFramework.Controls.MetroButton btnPlayback;
        internal MetroFramework.Controls.MetroLabel lblLog;
        internal MetroFramework.Controls.MetroButton btnRecording;
        internal System.Windows.Forms.Label lblCountdown;
        internal MetroFramework.Controls.MetroButton btnReset;
        internal MetroFramework.Controls.MetroCheckBox chkLoop;
        internal System.Windows.Forms.NumericUpDown nudSecond;
        internal MetroFramework.Controls.MetroLabel lblInterval;
        internal MetroFramework.Controls.MetroLabel lblCursorPosition;
        internal System.Windows.Forms.GroupBox grpExplain;
        internal System.Windows.Forms.GroupBox grpPreview;
    }
}
