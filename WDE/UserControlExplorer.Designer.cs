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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tsbRoot = new System.Windows.Forms.ToolStripButton();
            this.tsbUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
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
            this.tsbShow = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowNavigation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelFav = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsddbtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.explorerBrowser = new Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel.SuspendLayout();
            this.ts.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AllowDrop = true;
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel.Controls.Add(this.ts);
            this.flowLayoutPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(720, 25);
            this.flowLayoutPanel.TabIndex = 21;
            this.toolTip.SetToolTip(this.flowLayoutPanel, "Drag your favorites folders here");
            this.flowLayoutPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.flowLayoutPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // ts
            // 
            this.ts.AllowDrop = true;
            this.ts.BackColor = System.Drawing.SystemColors.Control;
            this.ts.Dock = System.Windows.Forms.DockStyle.None;
            this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRoot,
            this.tsbUp,
            this.toolStripSeparator16,
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
            this.ts.Size = new System.Drawing.Size(274, 25);
            this.ts.TabIndex = 19;
            this.ts.Text = "toolStrip4";
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
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
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
            // 
            // toolStripDropDownButton
            // 
            this.toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopyFullnameToClipboard,
            this.tsmiCopyShortnameToClipboard});
            this.toolStripDropDownButton.Image = global::WDE.Properties.Resources.clipboard;
            this.toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton.Name = "toolStripDropDownButton";
            this.toolStripDropDownButton.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton.Text = "clipboard";
            // 
            // tsmiCopyFullnameToClipboard
            // 
            this.tsmiCopyFullnameToClipboard.Name = "tsmiCopyFullnameToClipboard";
            this.tsmiCopyFullnameToClipboard.Size = new System.Drawing.Size(227, 22);
            this.tsmiCopyFullnameToClipboard.Text = "copy fullname to clipboard";
            this.tsmiCopyFullnameToClipboard.ToolTipText = "copy fullname to clipboard";
            this.tsmiCopyFullnameToClipboard.Click += new System.EventHandler(this.tsmiCopyFullnameToClipboard_Click);
            // 
            // tsmiCopyShortnameToClipboard
            // 
            this.tsmiCopyShortnameToClipboard.Name = "tsmiCopyShortnameToClipboard";
            this.tsmiCopyShortnameToClipboard.Size = new System.Drawing.Size(227, 22);
            this.tsmiCopyShortnameToClipboard.Text = "copy shortname to clipboard";
            this.tsmiCopyShortnameToClipboard.Click += new System.EventHandler(this.tsmiCopyShortnameToClipboard_Click);
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
            // 
            // tsmShowPreview
            // 
            this.tsmShowPreview.CheckOnClick = true;
            this.tsmShowPreview.Name = "tsmShowPreview";
            this.tsmShowPreview.Size = new System.Drawing.Size(164, 22);
            this.tsmShowPreview.Text = "Show Preview";
            this.tsmShowPreview.Click += new System.EventHandler(this.tsmShowPreview_Click);
            // 
            // tsmShowNavigation
            // 
            this.tsmShowNavigation.CheckOnClick = true;
            this.tsmShowNavigation.Name = "tsmShowNavigation";
            this.tsmShowNavigation.Size = new System.Drawing.Size(164, 22);
            this.tsmShowNavigation.Text = "Show Navigation";
            this.tsmShowNavigation.Click += new System.EventHandler(this.tsmShowNavigation_Click);
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
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbtn,
            this.tssl});
            this.statusStrip.Location = new System.Drawing.Point(0, 25);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(720, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsddbtn
            // 
            this.tsddbtn.BackColor = System.Drawing.SystemColors.Control;
            this.tsddbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsddbtn.ForeColor = System.Drawing.Color.Black;
            this.tsddbtn.Image = global::WDE.Properties.Resources.Drive;
            this.tsddbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtn.Name = "tsddbtn";
            this.tsddbtn.Size = new System.Drawing.Size(47, 20);
            this.tsddbtn.Text = "C:";
            // 
            // tssl
            // 
            this.tssl.Name = "tssl";
            this.tssl.Size = new System.Drawing.Size(10, 17);
            this.tssl.Text = ".";
            // 
            // explorerBrowser
            // 
            this.explorerBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerBrowser.Location = new System.Drawing.Point(0, 47);
            this.explorerBrowser.Name = "explorerBrowser";
            this.explorerBrowser.PropertyBagName = "Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser";
            this.explorerBrowser.Size = new System.Drawing.Size(720, 385);
            this.explorerBrowser.TabIndex = 23;
            this.explorerBrowser.NavigationComplete += new Microsoft.WindowsAPICodePack.Controls.ExplorerBrowserNavigationCompleteEventHandler(this.explorerBrowser_NavigationComplete);
            this.explorerBrowser.SelectionChanged += new Microsoft.WindowsAPICodePack.Controls.ExplorerBrowserSelectionChangedEventHandler(this.explorerBrowser_SelectionChanged);
            this.explorerBrowser.Enter += new System.EventHandler(this.explorerBrowser_Enter);
            this.explorerBrowser.ItemsChanged += new Microsoft.WindowsAPICodePack.Controls.ExplorerBrowserItemsChangedEventHandler(this.explorerBrowser_ItemsChanged);
            this.explorerBrowser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.explorerBrowser_KeyDown);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolTip
            // 
            this.toolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_Popup);
            // 
            // UserControlExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.explorerBrowser);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "UserControlExplorer";
            this.Size = new System.Drawing.Size(720, 432);
            this.Load += new System.EventHandler(this.UserControlExplorer_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton tsbRoot;
        private System.Windows.Forms.ToolStripButton tsbUp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
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
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtn;
        private System.Windows.Forms.ToolStripStatusLabel tssl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        public Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser explorerBrowser;
    }
}
