namespace WDE
{
    partial class UserControlExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlExplorer));
            this.ts = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbBack = new System.Windows.Forms.ToolStripButton();
            this.tsbForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSwitch = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbViewer = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiCopyFullnameToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyShortnameToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendFullnameViaEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendShortnameViaEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbShow = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowNavigation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelFav = new System.Windows.Forms.ToolStripLabel();
            this.explorerBrowser = new Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRoot = new System.Windows.Forms.ToolStripButton();
            this.tsbUp = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.navigationHistoryCombo = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsddbtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.tssl = new System.Windows.Forms.ToolStripLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ts.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts
            // 
            this.ts.AllowDrop = true;
            this.ts.BackColor = System.Drawing.SystemColors.Control;
            this.ts.ContextMenuStrip = this.contextMenuStrip;
            this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBack,
            this.tsbForward,
            this.toolStripSeparator1,
            this.tsbSwitch,
            this.tsbDel,
            this.toolStripSeparator13,
            this.tsbViewer,
            this.toolStripDropDownButton,
            this.tsbShow,
            this.toolStripSeparator11,
            this.toolStripLabelFav});
            this.ts.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(720, 25);
            this.ts.TabIndex = 19;
            this.ts.Text = "toolStrip4";
            this.ts.DragDrop += new System.Windows.Forms.DragEventHandler(this.ts_DragDrop);
            this.ts.DragEnter += new System.Windows.Forms.DragEventHandler(this.ts_DragEnter);
            this.ts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ts_MouseDown);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(118, 26);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::WDE.Properties.Resources.remove;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clearToolStripMenuItem.Text = "Remove";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // tsbBack
            // 
            this.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBack.Image = global::WDE.Properties.Resources.back;
            this.tsbBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBack.Name = "tsbBack";
            this.tsbBack.Size = new System.Drawing.Size(23, 22);
            this.tsbBack.Text = "back";
            this.tsbBack.ToolTipText = "back";
            this.tsbBack.Click += new System.EventHandler(this.tsbBack_Click);
            this.tsbBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsb_MouseDown);
            // 
            // tsbForward
            // 
            this.tsbForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbForward.Image = global::WDE.Properties.Resources.forward;
            this.tsbForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbForward.Name = "tsbForward";
            this.tsbForward.Size = new System.Drawing.Size(23, 22);
            this.tsbForward.Text = "forward";
            this.tsbForward.Click += new System.EventHandler(this.tsbForward_Click);
            this.tsbForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsb_MouseDown);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSwitch
            // 
            this.tsbSwitch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSwitch.Image = global::WDE.Properties.Resources.sync;
            this.tsbSwitch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSwitch.Name = "tsbSwitch";
            this.tsbSwitch.Size = new System.Drawing.Size(23, 22);
            this.tsbSwitch.Text = "sync to same folder as explorer 2";
            this.tsbSwitch.Click += new System.EventHandler(this.tsbSwitch_Click);
            this.tsbSwitch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsb_MouseDown);
            // 
            // tsbDel
            // 
            this.tsbDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbDel.Image")));
            this.tsbDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(23, 22);
            this.tsbDel.Text = "delete";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            this.tsbDel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsb_MouseDown);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbViewer
            // 
            this.tsbViewer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewer.Image = global::WDE.Properties.Resources.viewer;
            this.tsbViewer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewer.Name = "tsbViewer";
            this.tsbViewer.Size = new System.Drawing.Size(23, 22);
            this.tsbViewer.Text = "Viewer";
            this.tsbViewer.Click += new System.EventHandler(this.tsbViewer_Click);
            this.tsbViewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsb_MouseDown);
            // 
            // toolStripDropDownButton
            // 
            this.toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopyFullnameToClipboard,
            this.tsmiCopyShortnameToClipboard,
            this.toolStripMenuItem1,
            this.sendFullnameViaEmailToolStripMenuItem,
            this.sendShortnameViaEmailToolStripMenuItem});
            this.toolStripDropDownButton.Image = global::WDE.Properties.Resources.clipboard;
            this.toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton.Name = "toolStripDropDownButton";
            this.toolStripDropDownButton.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton.Text = "clipboard";
            this.toolStripDropDownButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsb_MouseDown);
            // 
            // tsmiCopyFullnameToClipboard
            // 
            this.tsmiCopyFullnameToClipboard.Image = global::WDE.Properties.Resources.clipboard;
            this.tsmiCopyFullnameToClipboard.Name = "tsmiCopyFullnameToClipboard";
            this.tsmiCopyFullnameToClipboard.Size = new System.Drawing.Size(240, 22);
            this.tsmiCopyFullnameToClipboard.Text = "copy fullname(s) to clipboard";
            this.tsmiCopyFullnameToClipboard.ToolTipText = "copy fullname to clipboard";
            this.tsmiCopyFullnameToClipboard.Click += new System.EventHandler(this.tsmiCopyFullnameToClipboard_Click);
            this.tsmiCopyFullnameToClipboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsb_MouseDown);
            // 
            // tsmiCopyShortnameToClipboard
            // 
            this.tsmiCopyShortnameToClipboard.Image = global::WDE.Properties.Resources.clipboard;
            this.tsmiCopyShortnameToClipboard.Name = "tsmiCopyShortnameToClipboard";
            this.tsmiCopyShortnameToClipboard.Size = new System.Drawing.Size(240, 22);
            this.tsmiCopyShortnameToClipboard.Text = "copy shortname(s) to clipboard";
            this.tsmiCopyShortnameToClipboard.Click += new System.EventHandler(this.tsmiCopyShortnameToClipboard_Click);
            this.tsmiCopyShortnameToClipboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsb_MouseDown);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 6);
            // 
            // sendFullnameViaEmailToolStripMenuItem
            // 
            this.sendFullnameViaEmailToolStripMenuItem.Name = "sendFullnameViaEmailToolStripMenuItem";
            this.sendFullnameViaEmailToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.sendFullnameViaEmailToolStripMenuItem.Text = "send fullname(s) via email";
            this.sendFullnameViaEmailToolStripMenuItem.Click += new System.EventHandler(this.sendFullnameViaEmailToolStripMenuItem_Click);
            // 
            // sendShortnameViaEmailToolStripMenuItem
            // 
            this.sendShortnameViaEmailToolStripMenuItem.Name = "sendShortnameViaEmailToolStripMenuItem";
            this.sendShortnameViaEmailToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.sendShortnameViaEmailToolStripMenuItem.Text = "send shortname(s) via email";
            this.sendShortnameViaEmailToolStripMenuItem.Click += new System.EventHandler(this.sendShortnameViaEmailToolStripMenuItem_Click);
            // 
            // tsbShow
            // 
            this.tsbShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.tsmShowPreview,
            this.tsmShowNavigation});
            this.tsbShow.Image = global::WDE.Properties.Resources.show;
            this.tsbShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShow.Name = "tsbShow";
            this.tsbShow.Size = new System.Drawing.Size(29, 22);
            this.tsbShow.Text = "show";
            this.tsbShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsb_MouseDown);
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.Checked = true;
            this.tsmShowDetails.CheckOnClick = true;
            this.tsmShowDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Size = new System.Drawing.Size(164, 22);
            this.tsmShowDetails.Text = "Show Details";
            this.tsmShowDetails.Click += new System.EventHandler(this.tsmShowDetails_Click);
            this.tsmShowDetails.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsb_MouseDown);
            // 
            // tsmShowPreview
            // 
            this.tsmShowPreview.CheckOnClick = true;
            this.tsmShowPreview.Name = "tsmShowPreview";
            this.tsmShowPreview.Size = new System.Drawing.Size(164, 22);
            this.tsmShowPreview.Text = "Show Preview";
            this.tsmShowPreview.Click += new System.EventHandler(this.tsmShowPreview_Click);
            this.tsmShowPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsb_MouseDown);
            // 
            // tsmShowNavigation
            // 
            this.tsmShowNavigation.CheckOnClick = true;
            this.tsmShowNavigation.Name = "tsmShowNavigation";
            this.tsmShowNavigation.Size = new System.Drawing.Size(164, 22);
            this.tsmShowNavigation.Text = "Show Navigation";
            this.tsmShowNavigation.Click += new System.EventHandler(this.tsmShowNavigation_Click);
            this.tsmShowNavigation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsb_MouseDown);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelFav
            // 
            this.toolStripLabelFav.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripLabelFav.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabelFav.Name = "toolStripLabelFav";
            this.toolStripLabelFav.Size = new System.Drawing.Size(28, 22);
            this.toolStripLabelFav.Tag = "0";
            this.toolStripLabelFav.Text = "Fav:";
            this.toolStripLabelFav.ToolTipText = "Drag your favorites folders here";
            this.toolStripLabelFav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsb_MouseDown);
            // 
            // explorerBrowser
            // 
            this.explorerBrowser.AllowDrop = true;
            this.explorerBrowser.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.explorerBrowser.BackColor = System.Drawing.SystemColors.Control;
            this.explorerBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerBrowser.Location = new System.Drawing.Point(0, 50);
            this.explorerBrowser.Name = "explorerBrowser";
            this.explorerBrowser.PropertyBagName = "Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser";
            this.explorerBrowser.Size = new System.Drawing.Size(720, 382);
            this.explorerBrowser.TabIndex = 23;
            this.explorerBrowser.SelectionChanged += new Microsoft.WindowsAPICodePack.Controls.ExplorerBrowserSelectionChangedEventHandler(this.explorerBrowser_SelectionChanged);
            this.explorerBrowser.ItemsChanged += new Microsoft.WindowsAPICodePack.Controls.ExplorerBrowserItemsChangedEventHandler(this.explorerBrowser_ItemsChanged);
            this.explorerBrowser.NavigationComplete += new Microsoft.WindowsAPICodePack.Controls.ExplorerBrowserNavigationCompleteEventHandler(this.explorerBrowser_NavigationComplete);
            this.explorerBrowser.Enter += new System.EventHandler(this.explorerBrowser_Enter);
            this.explorerBrowser.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.explorerBrowser_PreviewKeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRoot,
            this.tsbUp});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(671, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(49, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbRoot
            // 
            this.tsbRoot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRoot.Image = global::WDE.Properties.Resources.root;
            this.tsbRoot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRoot.Name = "tsbRoot";
            this.tsbRoot.Size = new System.Drawing.Size(23, 22);
            this.tsbRoot.Text = "Root";
            this.tsbRoot.Click += new System.EventHandler(this.tsbRoot1_Click);
            // 
            // tsbUp
            // 
            this.tsbUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUp.Image = global::WDE.Properties.Resources.up;
            this.tsbUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUp.Name = "tsbUp";
            this.tsbUp.Size = new System.Drawing.Size(23, 22);
            this.tsbUp.Text = "up";
            this.tsbUp.Click += new System.EventHandler(this.tsbUp_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.navigationHistoryCombo);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 25);
            this.panel2.TabIndex = 25;
            // 
            // navigationHistoryCombo
            // 
            this.navigationHistoryCombo.BackColor = System.Drawing.SystemColors.Control;
            this.navigationHistoryCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationHistoryCombo.FormattingEnabled = true;
            this.navigationHistoryCombo.Location = new System.Drawing.Point(65, 0);
            this.navigationHistoryCombo.Name = "navigationHistoryCombo";
            this.navigationHistoryCombo.Size = new System.Drawing.Size(606, 21);
            this.navigationHistoryCombo.TabIndex = 28;
            this.navigationHistoryCombo.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxPath_SelectedIndexChanged);
            this.navigationHistoryCombo.Enter += new System.EventHandler(this.navigationHistoryCombo_Enter);
            this.navigationHistoryCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripComboBoxPath_KeyDown);
            this.navigationHistoryCombo.Leave += new System.EventHandler(this.navigationHistoryCombo_Leave);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbtn,
            this.tssl});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(65, 25);
            this.toolStrip2.TabIndex = 27;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.SizeChanged += new System.EventHandler(this.toolStrip2_SizeChanged);
            // 
            // tsddbtn
            // 
            this.tsddbtn.BackColor = System.Drawing.SystemColors.Control;
            this.tsddbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsddbtn.ForeColor = System.Drawing.Color.Black;
            this.tsddbtn.Image = global::WDE.Properties.Resources.Drive;
            this.tsddbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtn.Name = "tsddbtn";
            this.tsddbtn.Size = new System.Drawing.Size(47, 22);
            this.tsddbtn.Text = "C:";
            this.tsddbtn.DropDownOpening += new System.EventHandler(this.tsddbtn_DropDownOpening);
            // 
            // tssl
            // 
            this.tssl.Name = "tssl";
            this.tssl.Size = new System.Drawing.Size(15, 22);
            this.tssl.Text = "[]";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 385);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(720, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 27;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.Visible = false;
            // 
            // UserControlExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.explorerBrowser);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ts);
            this.Name = "UserControlExplorer";
            this.Size = new System.Drawing.Size(720, 432);
            this.Load += new System.EventHandler(this.UserControlExplorer_Load);
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton tsbRoot;
        private System.Windows.Forms.ToolStripButton tsbUp;
        private System.Windows.Forms.ToolStripButton tsbBack;
        private System.Windows.Forms.ToolStripButton tsbForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSwitch;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton tsbViewer;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyFullnameToClipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyShortnameToClipboard;
        private System.Windows.Forms.ToolStripDropDownButton tsbShow;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPreview;
        private System.Windows.Forms.ToolStripMenuItem tsmShowNavigation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFav;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtn;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        public Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser explorerBrowser;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tssl;
        private System.Windows.Forms.ComboBox navigationHistoryCombo;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sendFullnameViaEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendShortnameViaEmailToolStripMenuItem;
    }
}
