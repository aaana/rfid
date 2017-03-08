﻿namespace RFIDIntegratedApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dockPanelMain = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tssbtnSave = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnStart = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStop = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbtnAddWindow = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiReaderSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTagTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRSSIGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPhaseGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHolographics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDemoSortingBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDemoTrackingObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslRunTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanelMain
            // 
            this.dockPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelMain.Location = new System.Drawing.Point(0, 27);
            this.dockPanelMain.Margin = new System.Windows.Forms.Padding(4);
            this.dockPanelMain.Name = "dockPanelMain";
            this.dockPanelMain.Size = new System.Drawing.Size(1346, 929);
            this.dockPanelMain.TabIndex = 1;
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbtnSave,
            this.toolStripSeparator5,
            this.tsbtnConnect,
            this.toolStripSeparator4,
            this.tsbtnStart,
            this.tsbtnStop,
            this.tsbtnClear,
            this.toolStripSeparator2,
            this.tssbtnAddWindow});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1346, 27);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "Tool Strip";
            // 
            // tssbtnSave
            // 
            this.tssbtnSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiSaveAs});
            this.tssbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tssbtnSave.Image")));
            this.tssbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbtnSave.Name = "tssbtnSave";
            this.tssbtnSave.Size = new System.Drawing.Size(82, 24);
            this.tssbtnSave.Text = "Save";
            this.tssbtnSave.ButtonClick += new System.EventHandler(this.tssbtnSave_ButtonClick);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSave.Image")));
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(137, 26);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSaveAs.Image")));
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(137, 26);
            this.tsmiSaveAs.Text = "Save as";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnConnect
            // 
            this.tsbtnConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConnect.Image")));
            this.tsbtnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConnect.Name = "tsbtnConnect";
            this.tsbtnConnect.Size = new System.Drawing.Size(94, 24);
            this.tsbtnConnect.Text = "Connect";
            this.tsbtnConnect.Click += new System.EventHandler(this.tsbtnConnect_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnStart
            // 
            this.tsbtnStart.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStart.Image")));
            this.tsbtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStart.Name = "tsbtnStart";
            this.tsbtnStart.Size = new System.Drawing.Size(68, 24);
            this.tsbtnStart.Text = "Start";
            this.tsbtnStart.Click += new System.EventHandler(this.tsbtnStart_Click);
            // 
            // tsbtnStop
            // 
            this.tsbtnStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStop.Image")));
            this.tsbtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStop.Name = "tsbtnStop";
            this.tsbtnStop.Size = new System.Drawing.Size(68, 24);
            this.tsbtnStop.Text = "Stop";
            this.tsbtnStop.Click += new System.EventHandler(this.tsbtnStop_Click);
            // 
            // tsbtnClear
            // 
            this.tsbtnClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClear.Image")));
            this.tsbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClear.Name = "tsbtnClear";
            this.tsbtnClear.Size = new System.Drawing.Size(70, 24);
            this.tsbtnClear.Text = "Clear";
            this.tsbtnClear.Click += new System.EventHandler(this.tsbtnClear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tssbtnAddWindow
            // 
            this.tssbtnAddWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReaderSettings,
            this.tsmiTagTable,
            this.tsmiRSSIGraph,
            this.tsmiPhaseGraph,
            this.tsmiHolographics});
            this.tssbtnAddWindow.Image = ((System.Drawing.Image)(resources.GetObject("tssbtnAddWindow.Image")));
            this.tssbtnAddWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbtnAddWindow.Name = "tssbtnAddWindow";
            this.tssbtnAddWindow.Size = new System.Drawing.Size(108, 24);
            this.tssbtnAddWindow.Text = "Window";
            this.tssbtnAddWindow.ButtonClick += new System.EventHandler(this.tssbtnAddWindow_ButtonClick);
            // 
            // tsmiReaderSettings
            // 
            this.tsmiReaderSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReaderSettings.Image")));
            this.tsmiReaderSettings.Name = "tsmiReaderSettings";
            this.tsmiReaderSettings.Size = new System.Drawing.Size(200, 26);
            this.tsmiReaderSettings.Text = "Reader Settings";
            this.tsmiReaderSettings.Click += new System.EventHandler(this.tsmiReaderSettings_Click);
            // 
            // tsmiTagTable
            // 
            this.tsmiTagTable.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTagTable.Image")));
            this.tsmiTagTable.Name = "tsmiTagTable";
            this.tsmiTagTable.Size = new System.Drawing.Size(200, 26);
            this.tsmiTagTable.Text = "Tag Table";
            this.tsmiTagTable.Click += new System.EventHandler(this.tsmiTagTable_Click);
            // 
            // tsmiRSSIGraph
            // 
            this.tsmiRSSIGraph.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRSSIGraph.Image")));
            this.tsmiRSSIGraph.Name = "tsmiRSSIGraph";
            this.tsmiRSSIGraph.Size = new System.Drawing.Size(200, 26);
            this.tsmiRSSIGraph.Text = "RSSI Graph";
            this.tsmiRSSIGraph.Click += new System.EventHandler(this.tsmiRSSIGraph_Click);
            // 
            // tsmiPhaseGraph
            // 
            this.tsmiPhaseGraph.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPhaseGraph.Image")));
            this.tsmiPhaseGraph.Name = "tsmiPhaseGraph";
            this.tsmiPhaseGraph.Size = new System.Drawing.Size(200, 26);
            this.tsmiPhaseGraph.Text = "Phase Graph";
            this.tsmiPhaseGraph.Click += new System.EventHandler(this.tsmiPhaseGraph_Click);
            // 
            // tsmiHolographics
            // 
            this.tsmiHolographics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDemoSortingBooks,
            this.tsmiDemoTrackingObjects});
            this.tsmiHolographics.Image = ((System.Drawing.Image)(resources.GetObject("tsmiHolographics.Image")));
            this.tsmiHolographics.Name = "tsmiHolographics";
            this.tsmiHolographics.Size = new System.Drawing.Size(200, 26);
            this.tsmiHolographics.Text = "Holographics";
            // 
            // tsmiDemoSortingBooks
            // 
            this.tsmiDemoSortingBooks.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDemoSortingBooks.Image")));
            this.tsmiDemoSortingBooks.Name = "tsmiDemoSortingBooks";
            this.tsmiDemoSortingBooks.Size = new System.Drawing.Size(262, 26);
            this.tsmiDemoSortingBooks.Text = "Demo - Sorting books";
            this.tsmiDemoSortingBooks.Click += new System.EventHandler(this.tsmiDemoSortingBooks_Click);
            // 
            // tsmiDemoTrackingObjects
            // 
            this.tsmiDemoTrackingObjects.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDemoTrackingObjects.Image")));
            this.tsmiDemoTrackingObjects.Name = "tsmiDemoTrackingObjects";
            this.tsmiDemoTrackingObjects.Size = new System.Drawing.Size(262, 26);
            this.tsmiDemoTrackingObjects.Text = "Demo - Tracking objects";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslRunTime,
            this.tsslblCounter,
            this.tsslblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 927);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1346, 29);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "status";
            // 
            // tsslRunTime
            // 
            this.tsslRunTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslRunTime.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tsslRunTime.Image = ((System.Drawing.Image)(resources.GetObject("tsslRunTime.Image")));
            this.tsslRunTime.Name = "tsslRunTime";
            this.tsslRunTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsslRunTime.Size = new System.Drawing.Size(101, 24);
            this.tsslRunTime.Text = "Run Time";
            this.tsslRunTime.Click += new System.EventHandler(this.tsslRunTime_Click);
            // 
            // tsslblCounter
            // 
            this.tsslblCounter.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslblCounter.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tsslblCounter.Image = ((System.Drawing.Image)(resources.GetObject("tsslblCounter.Image")));
            this.tsslblCounter.Name = "tsslblCounter";
            this.tsslblCounter.Size = new System.Drawing.Size(92, 24);
            this.tsslblCounter.Text = "Counter";
            this.tsslblCounter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.Image = ((System.Drawing.Image)(resources.GetObject("tsslblStatus.Image")));
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(74, 24);
            this.tsslblStatus.Text = "Ready";
            this.tsslblStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 956);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dockPanelMain);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "RFID Integrated Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanelMain;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSplitButton tssbtnSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnStart;
        private System.Windows.Forms.ToolStripButton tsbtnStop;
        private System.Windows.Forms.ToolStripButton tsbtnClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslRunTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslblCounter;
        private System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
        private System.Windows.Forms.ToolStripSplitButton tssbtnAddWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiReaderSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiTagTable;
        private System.Windows.Forms.ToolStripMenuItem tsmiRSSIGraph;
        private System.Windows.Forms.ToolStripMenuItem tsmiPhaseGraph;
        private System.Windows.Forms.ToolStripMenuItem tsmiHolographics;
        private System.Windows.Forms.ToolStripMenuItem tsmiDemoSortingBooks;
        private System.Windows.Forms.ToolStripMenuItem tsmiDemoTrackingObjects;
    }
}