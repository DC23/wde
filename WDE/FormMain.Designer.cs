namespace WDE
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitter = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cmsTabControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNewTab = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLockTab = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListTabControl = new System.Windows.Forms.ImageList(this.components);
            this.tscbKnownFolder = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationHistoryCombo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorer1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewToolbar1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewStatusbar1 = new System.Windows.Forms.ToolStripMenuItem();
            this.explorer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewToolbar2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewStatusbar2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbSwitch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLayout1 = new System.Windows.Forms.ToolStripButton();
            this.tsbLayout2 = new System.Windows.Forms.ToolStripButton();
            this.tsbShowHide1 = new System.Windows.Forms.ToolStripButton();
            this.tsbShowHide2 = new System.Windows.Forms.ToolStripButton();
            this.tsbExplorer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.switchExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layout1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layout2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideExplorer1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideExplorer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.cmsTabControl.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.SystemColors.Control;
            this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter.Location = new System.Drawing.Point(0, 318);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(784, 4);
            this.splitter.TabIndex = 2;
            this.splitter.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 269);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.cmsTabControl;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageListTabControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 269);
            this.tabControl1.TabIndex = 26;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // cmsTabControl
            // 
            this.cmsTabControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewTab,
            this.closeTabToolStripMenuItem,
            this.tsmiLockTab});
            this.cmsTabControl.Name = "cmsTabControl";
            this.cmsTabControl.Size = new System.Drawing.Size(127, 70);
            this.cmsTabControl.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTabControl_Opening);
            // 
            // tsmiNewTab
            // 
            this.tsmiNewTab.Name = "tsmiNewTab";
            this.tsmiNewTab.Size = new System.Drawing.Size(126, 22);
            this.tsmiNewTab.Text = "New Tab";
            this.tsmiNewTab.Click += new System.EventHandler(this.tsmiNewTab_Click);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.closeTabToolStripMenuItem.Text = "Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // tsmiLockTab
            // 
            this.tsmiLockTab.CheckOnClick = true;
            this.tsmiLockTab.Name = "tsmiLockTab";
            this.tsmiLockTab.Size = new System.Drawing.Size(126, 22);
            this.tsmiLockTab.Text = "Lock Tab";
            this.tsmiLockTab.Click += new System.EventHandler(this.tsmiLockTab_Click);
            // 
            // imageListTabControl
            // 
            this.imageListTabControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabControl.ImageStream")));
            this.imageListTabControl.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTabControl.Images.SetKeyName(0, "StartSmal.png");
            this.imageListTabControl.Images.SetKeyName(1, "StarBig.png");
            // 
            // tscbKnownFolder
            // 
            this.tscbKnownFolder.AutoSize = false;
            this.tscbKnownFolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tscbKnownFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbKnownFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tscbKnownFolder.Name = "tscbKnownFolder";
            this.tscbKnownFolder.Size = new System.Drawing.Size(250, 23);
            this.tscbKnownFolder.SelectedIndexChanged += new System.EventHandler(this.knownFolderCombo_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "Jump to";
            this.toolStripLabel1.ToolTipText = "Jump to known folder";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // navigationHistoryCombo
            // 
            this.navigationHistoryCombo.FormattingEnabled = true;
            this.navigationHistoryCombo.Location = new System.Drawing.Point(638, 0);
            this.navigationHistoryCombo.Name = "navigationHistoryCombo";
            this.navigationHistoryCombo.Size = new System.Drawing.Size(134, 21);
            this.navigationHistoryCombo.TabIndex = 23;
            this.navigationHistoryCombo.Visible = false;
            this.navigationHistoryCombo.SelectedIndexChanged += new System.EventHandler(this.navigationHistoryCombo_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 369);
            this.panel2.TabIndex = 18;
            // 
            // tabControl2
            // 
            this.tabControl2.ContextMenuStrip = this.cmsTabControl;
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ImageList = this.imageListTabControl;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(784, 369);
            this.tabControl2.TabIndex = 25;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tsmiViewToolbar,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tsmiViewToolbar
            // 
            this.tsmiViewToolbar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolbarToolStripMenuItem,
            this.explorer1ToolStripMenuItem,
            this.explorer2ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.refreshToolStripMenuItem,
            this.switchExplorerToolStripMenuItem,
            this.layoutToolStripMenuItem,
            this.showHideExplorer1ToolStripMenuItem,
            this.showHideExplorer2ToolStripMenuItem,
            this.openExplorerToolStripMenuItem,
            this.jumpToToolStripMenuItem});
            this.tsmiViewToolbar.Name = "tsmiViewToolbar";
            this.tsmiViewToolbar.Size = new System.Drawing.Size(44, 20);
            this.tsmiViewToolbar.Text = "View";
            // 
            // mainToolbarToolStripMenuItem
            // 
            this.mainToolbarToolStripMenuItem.Checked = true;
            this.mainToolbarToolStripMenuItem.CheckOnClick = true;
            this.mainToolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mainToolbarToolStripMenuItem.Name = "mainToolbarToolStripMenuItem";
            this.mainToolbarToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.mainToolbarToolStripMenuItem.Text = "Main Toolbar";
            this.mainToolbarToolStripMenuItem.Click += new System.EventHandler(this.mainToolbarToolStripMenuItem_Click);
            // 
            // explorer1ToolStripMenuItem
            // 
            this.explorer1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewToolbar1,
            this.tsmiViewStatusbar1});
            this.explorer1ToolStripMenuItem.Name = "explorer1ToolStripMenuItem";
            this.explorer1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.explorer1ToolStripMenuItem.Text = "Explorer 1";
            this.explorer1ToolStripMenuItem.Visible = false;
            // 
            // tsmiViewToolbar1
            // 
            this.tsmiViewToolbar1.Checked = true;
            this.tsmiViewToolbar1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiViewToolbar1.Name = "tsmiViewToolbar1";
            this.tsmiViewToolbar1.Size = new System.Drawing.Size(123, 22);
            this.tsmiViewToolbar1.Text = "Toolbar";
            this.tsmiViewToolbar1.Click += new System.EventHandler(this.tsmiViewToolbar1_Click);
            // 
            // tsmiViewStatusbar1
            // 
            this.tsmiViewStatusbar1.Checked = true;
            this.tsmiViewStatusbar1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiViewStatusbar1.Name = "tsmiViewStatusbar1";
            this.tsmiViewStatusbar1.Size = new System.Drawing.Size(123, 22);
            this.tsmiViewStatusbar1.Text = "Statusbar";
            this.tsmiViewStatusbar1.Click += new System.EventHandler(this.tsmiViewStatusbar1_Click);
            // 
            // explorer2ToolStripMenuItem
            // 
            this.explorer2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewToolbar2,
            this.tsmiViewStatusbar2});
            this.explorer2ToolStripMenuItem.Name = "explorer2ToolStripMenuItem";
            this.explorer2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.explorer2ToolStripMenuItem.Text = "Explorer 2";
            this.explorer2ToolStripMenuItem.Visible = false;
            // 
            // tsmiViewToolbar2
            // 
            this.tsmiViewToolbar2.Checked = true;
            this.tsmiViewToolbar2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiViewToolbar2.Name = "tsmiViewToolbar2";
            this.tsmiViewToolbar2.Size = new System.Drawing.Size(123, 22);
            this.tsmiViewToolbar2.Text = "Toolbar";
            this.tsmiViewToolbar2.Click += new System.EventHandler(this.tsmiViewToolbar2_Click);
            // 
            // tsmiViewStatusbar2
            // 
            this.tsmiViewStatusbar2.Checked = true;
            this.tsmiViewStatusbar2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiViewStatusbar2.Name = "tsmiViewStatusbar2";
            this.tsmiViewStatusbar2.Size = new System.Drawing.Size(123, 22);
            this.tsmiViewStatusbar2.Text = "Statusbar";
            this.tsmiViewStatusbar2.Click += new System.EventHandler(this.tsmiViewStatusbar2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.infoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.Image")));
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.infoToolStripMenuItem.Text = "Infos";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // tsMain
            // 
            this.tsMain.BackColor = System.Drawing.SystemColors.Control;
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSwitch,
            this.toolStripSeparator15,
            this.tsbLayout1,
            this.tsbLayout2,
            this.tsbShowHide1,
            this.tsbShowHide2,
            this.toolStripSeparator3,
            this.tsbExplorer,
            this.toolStripSeparator12,
            this.toolStripLabel1,
            this.tscbKnownFolder});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(784, 25);
            this.tsMain.TabIndex = 20;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbSwitch
            // 
            this.tsbSwitch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSwitch.Image = global::WDE.Properties.Resources._switch;
            this.tsbSwitch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSwitch.Name = "tsbSwitch";
            this.tsbSwitch.Size = new System.Drawing.Size(23, 22);
            this.tsbSwitch.Text = "Switch Explorer ";
            this.tsbSwitch.Click += new System.EventHandler(this.tsbSwitch_Click_1);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLayout1
            // 
            this.tsbLayout1.Checked = true;
            this.tsbLayout1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbLayout1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLayout1.Image = global::WDE.Properties.Resources.layout1;
            this.tsbLayout1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLayout1.Name = "tsbLayout1";
            this.tsbLayout1.Size = new System.Drawing.Size(23, 22);
            this.tsbLayout1.Text = "Layout 1";
            this.tsbLayout1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbLayout2
            // 
            this.tsbLayout2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLayout2.Image = global::WDE.Properties.Resources.layout2;
            this.tsbLayout2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLayout2.Name = "tsbLayout2";
            this.tsbLayout2.Size = new System.Drawing.Size(23, 22);
            this.tsbLayout2.Text = "Layout 2";
            this.tsbLayout2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbShowHide1
            // 
            this.tsbShowHide1.Checked = true;
            this.tsbShowHide1.CheckOnClick = true;
            this.tsbShowHide1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbShowHide1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShowHide1.Image = global::WDE.Properties.Resources._1;
            this.tsbShowHide1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowHide1.Name = "tsbShowHide1";
            this.tsbShowHide1.Size = new System.Drawing.Size(23, 22);
            this.tsbShowHide1.Text = "Show/Hide Explorer 1";
            this.tsbShowHide1.Click += new System.EventHandler(this.tsbShowHide1_Click);
            // 
            // tsbShowHide2
            // 
            this.tsbShowHide2.Checked = true;
            this.tsbShowHide2.CheckOnClick = true;
            this.tsbShowHide2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbShowHide2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShowHide2.Image = global::WDE.Properties.Resources._2;
            this.tsbShowHide2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowHide2.Name = "tsbShowHide2";
            this.tsbShowHide2.Size = new System.Drawing.Size(23, 22);
            this.tsbShowHide2.Text = "Show/Hide Explorer 2";
            this.tsbShowHide2.Click += new System.EventHandler(this.tsbShowHide2_Click);
            // 
            // tsbExplorer
            // 
            this.tsbExplorer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExplorer.Image = global::WDE.Properties.Resources.explorer;
            this.tsbExplorer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExplorer.Name = "tsbExplorer";
            this.tsbExplorer.Size = new System.Drawing.Size(23, 22);
            this.tsbExplorer.Text = "Open Explorer";
            this.tsbExplorer.Click += new System.EventHandler(this.tsbExplorer_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // switchExplorerToolStripMenuItem
            // 
            this.switchExplorerToolStripMenuItem.Image = global::WDE.Properties.Resources._switch;
            this.switchExplorerToolStripMenuItem.Name = "switchExplorerToolStripMenuItem";
            this.switchExplorerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.switchExplorerToolStripMenuItem.Text = "Switch Explorer";
            this.switchExplorerToolStripMenuItem.Click += new System.EventHandler(this.tsbSwitch_Click_1);
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layout1ToolStripMenuItem,
            this.layout2ToolStripMenuItem});
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.layoutToolStripMenuItem.Text = "Layout";
            // 
            // layout1ToolStripMenuItem
            // 
            this.layout1ToolStripMenuItem.Image = global::WDE.Properties.Resources.layout1;
            this.layout1ToolStripMenuItem.Name = "layout1ToolStripMenuItem";
            this.layout1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.layout1ToolStripMenuItem.Text = "Layout 1";
            this.layout1ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // layout2ToolStripMenuItem
            // 
            this.layout2ToolStripMenuItem.Image = global::WDE.Properties.Resources.layout2;
            this.layout2ToolStripMenuItem.Name = "layout2ToolStripMenuItem";
            this.layout2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.layout2ToolStripMenuItem.Text = "Layout 2";
            this.layout2ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // showHideExplorer1ToolStripMenuItem
            // 
            this.showHideExplorer1ToolStripMenuItem.Image = global::WDE.Properties.Resources._1;
            this.showHideExplorer1ToolStripMenuItem.Name = "showHideExplorer1ToolStripMenuItem";
            this.showHideExplorer1ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.showHideExplorer1ToolStripMenuItem.Text = "Show/Hide Explorer 1";
            this.showHideExplorer1ToolStripMenuItem.Click += new System.EventHandler(this.tsbShowHide1_Click);
            // 
            // showHideExplorer2ToolStripMenuItem
            // 
            this.showHideExplorer2ToolStripMenuItem.Image = global::WDE.Properties.Resources._2;
            this.showHideExplorer2ToolStripMenuItem.Name = "showHideExplorer2ToolStripMenuItem";
            this.showHideExplorer2ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.showHideExplorer2ToolStripMenuItem.Text = "Show/Hide Explorer 2";
            this.showHideExplorer2ToolStripMenuItem.Click += new System.EventHandler(this.tsbShowHide2_Click);
            // 
            // openExplorerToolStripMenuItem
            // 
            this.openExplorerToolStripMenuItem.Image = global::WDE.Properties.Resources.explorer;
            this.openExplorerToolStripMenuItem.Name = "openExplorerToolStripMenuItem";
            this.openExplorerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.openExplorerToolStripMenuItem.Text = "Open Explorer";
            this.openExplorerToolStripMenuItem.Click += new System.EventHandler(this.tsbExplorer_Click);
            // 
            // jumpToToolStripMenuItem
            // 
            this.jumpToToolStripMenuItem.Name = "jumpToToolStripMenuItem";
            this.jumpToToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.jumpToToolStripMenuItem.Text = "Jump to";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.navigationHistoryCombo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Windows Double Explorer - www.jdSoftwareSolutions.de - v";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.panel1.ResumeLayout(false);
            this.cmsTabControl.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ComboBox navigationHistoryCombo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbLayout1;
        private System.Windows.Forms.ToolStripButton tsbLayout2;
        private System.Windows.Forms.ToolStripButton tsbExplorer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tscbKnownFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton tsbShowHide1;
        private System.Windows.Forms.ToolStripButton tsbShowHide2;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewToolbar;
        private System.Windows.Forms.ToolStripMenuItem mainToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorer1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewToolbar1;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewStatusbar1;
        private System.Windows.Forms.ToolStripMenuItem explorer2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewToolbar2;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewStatusbar2;
        private System.Windows.Forms.ToolStripButton tsbSwitch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ImageList imageListTabControl;
        private System.Windows.Forms.ContextMenuStrip cmsTabControl;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewTab;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLockTab;
        private System.Windows.Forms.ToolStripMenuItem switchExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layout1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layout2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideExplorer1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideExplorer2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpToToolStripMenuItem;

    }
}

