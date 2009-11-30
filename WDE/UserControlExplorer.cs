using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Controls;
using jd.Helper.Configuration;

namespace WDE
{
    public delegate void MyDelegate(object sender, EventArgs e);

    public partial class UserControlExplorer : UserControl
    {
        public event MyDelegate MyEvent;

        private ApplicationSettings applicationSettings = null;
        private string sectionName = "";
        private Section optionSection = null;
        private string LastPath = "";
        private bool ShowDetails = false;
        private bool ShowPreview = false;
        private bool ShowNavigation = true;
        private bool TabControlLocked = false;
        private TabControl currentTabControl;


        public UserControlExplorer(string newSectionName, ApplicationSettings applicationSettingsValue, string name, TabControl destTabControl, TabPage tabPage)
        {
            InitializeComponent();

            explorerBrowser.NavigationLog.NavigationLogChanged += new NavigationLogChangedEventHandler(NavigationLog_NavigationLogChanged);

            currentTabControl = destTabControl;

            if (name == "")
                sectionName = newSectionName; //"UserExplorerControl" + id.ToString();
            else
                sectionName = name;

            applicationSettings = applicationSettingsValue;
            tabPage.Tag = sectionName;

            if (applicationSettings.sections.GetItemIDByString(sectionName, "FAV") == -1)
                applicationSettings.sections.Add(sectionName, "FAV");

            if (applicationSettings.sections.GetItemIDByString(sectionName, "OPTIONS") == -1)
                applicationSettings.sections.Add(sectionName, "OPTIONS");

            optionSection = applicationSettings.sections.GetItemByString(sectionName, "OPTIONS");

            if (optionSection.settings.GetItemByString("LastPath") == null)
                optionSection.settings.Add("LastPath", "");
            else
                LastPath = optionSection.settings.GetItemByString("LastPath").Value;

            tabPage.Text = LastPath;

            //ShowDetails
            if (optionSection.settings.GetItemByString("ShowDetails") == null)
                optionSection.settings.Add("ShowDetails", ShowDetails.ToString());
            else
                ShowDetails = Convert.ToBoolean(optionSection.settings.GetItemByString("ShowDetails").Value);

            tsmShowDetails.Checked = ShowDetails;
            if (ShowDetails)
                explorerBrowser.NavigationOptions.PaneVisibility.Details = PaneVisibilityState.Show;
            else
                explorerBrowser.NavigationOptions.PaneVisibility.Details = PaneVisibilityState.Hide;

            //ShowPreview
            if (optionSection.settings.GetItemByString("ShowPreview") == null)
                optionSection.settings.Add("ShowPreview", ShowPreview.ToString());
            else
                ShowPreview = Convert.ToBoolean(optionSection.settings.GetItemByString("ShowPreview").Value);

            tsmShowPreview.Checked = ShowPreview;
            if (ShowPreview)
                explorerBrowser.NavigationOptions.PaneVisibility.Preview = PaneVisibilityState.Show;
            else
                explorerBrowser.NavigationOptions.PaneVisibility.Preview = PaneVisibilityState.Hide;

            //ShowNavigation
            if (optionSection.settings.GetItemByString("ShowNavigation") == null)
                optionSection.settings.Add("ShowNavigation", ShowNavigation.ToString());
            else
                ShowNavigation = Convert.ToBoolean(optionSection.settings.GetItemByString("ShowNavigation").Value);

            tsmShowNavigation.Checked = ShowNavigation;
            if (ShowNavigation)
                explorerBrowser.NavigationOptions.PaneVisibility.Navigation = PaneVisibilityState.Show;
            else
                explorerBrowser.NavigationOptions.PaneVisibility.Navigation = PaneVisibilityState.Hide;

            //ParentTabControl
            if (optionSection.settings.GetItemByString("ParentTabControl") == null)
                optionSection.settings.Add("ParentTabControl", destTabControl.Name);

            //Locked
            if (optionSection.settings.GetItemByString("Locked") == null)
                optionSection.settings.Add("Locked", "False");
            else
                TabControlLocked = Convert.ToBoolean(optionSection.settings.GetItemByString("Locked").Value);

            if (TabControlLocked)
                tabPage.ImageIndex = 0;


            //
            int sectionID = applicationSettings.sections.GetItemIDByString(sectionName, "FAV");

            for (int i = 0; i < applicationSettings.sections[sectionID].settings.Count; i++)
            {
                string fav = applicationSettings.sections[sectionID].settings[i].Name;
                string favValue = applicationSettings.sections[sectionID].settings[i].Value;
                CreateFavButton(System.IO.Path.GetFileName(fav), favValue, flowLayoutPanel);
            }

            //if (config.Sections.ContainsKey("FAVS"))
            //foreach (Setting s in config.Sections[SectionName].Settings.Values)
            //{
            //    string fav = s.Name;
            //    string favValue = s.Value;
            //    MessageBox.Show(fav+" "+favValue);
            //    CreateFavButton(System.IO.Path.GetFileName(fav), fav, flowLayoutPanel);
            //}

            //for (int i = 0; i < config.Sections[SectionName].Settings.Count; i++)
            //{
            //    config.Sections[SectionName].Settings.Values
                
            //}

            
            //if (Properties.Settings.Default.Favs1 != null)
            //{

            //    foreach (string fav in Properties.Settings.Default.Favs1)
            //    {
            //        CreateFavButton(System.IO.Path.GetFileName(fav), fav, flowLayoutPanel1);
            //    }
            //}

        }

        void NavigationLog_NavigationLogChanged(object sender, NavigationLogEventArgs args)
        {
            // This event is BeginInvoked to decouple the ExplorerBrowser UI from this UI
            //BeginInvoke(new MethodInvoker(delegate()
            //{
            //    // calculate button states
            //    if (args.CanNavigateBackwardChanged)
            //    {
            //        this.tsbBack1.Enabled = explorerBrowser1.NavigationLog.CanNavigateBackward;
            //    }
            //    if (args.CanNavigateForwardChanged)
            //    {
            //        this.tsbForward1.Enabled = explorerBrowser1.NavigationLog.CanNavigateForward;
            //    }

            //    // update history combo box
            //    if (args.LocationsChanged)
            //    {
            //        this.navigationHistoryCombo.Items.Clear();
            //        foreach (ShellObject shobj in this.explorerBrowser1.NavigationLog.Locations)
            //        {
            //            this.navigationHistoryCombo.Items.Add(shobj.Name);
            //        }
            //    }
            //    if (this.explorerBrowser1.NavigationLog.CurrentLocationIndex == -1)
            //        this.navigationHistoryCombo.Text = "";
            //    else
            //        this.navigationHistoryCombo.SelectedIndex = this.explorerBrowser1.NavigationLog.CurrentLocationIndex;
            //}));
        }


        public delegate void PathChanged(string pathname, UserControlExplorer uce);
        public event PathChanged pathChanged;

        private void UserControlExplorer_Load(object sender, EventArgs e)
        {
            try
            {
                if (LastPath == "")
                    explorerBrowser.Navigate((ShellObject)KnownFolders.Desktop);
                else
                    explorerBrowser.Navigate(ShellFileSystemFolder.FromFolderPath(LastPath));

                RefreshApp();
            }
            catch (Exception)
            {
            }
        }

        private string GetRootDriveFromPath(string path)
        {
            string driveletter = path.Substring(0, 2);

            try
            {
                DriveInfo driveInfo = new DriveInfo(driveletter);

                return driveInfo.RootDirectory.FullName;
            }
            catch (Exception)
            {
                return "";

            }
        }


        private void tsbRoot1_Click(object sender, EventArgs e)
        {
            string driveletter = GetRootDriveFromPath(tsddbtn.Text);
            if (driveletter != "")
            {
                try
                {
                    explorerBrowser.Navigate(ShellFileSystemFolder.FromParsingName(driveletter));
                }
                catch (Exception)
                {
                }
            }
        }

        private void tsbUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (explorerBrowser.NavigationLog.CurrentLocation.Parent != null)
                    explorerBrowser.Navigate(explorerBrowser.NavigationLog.CurrentLocation.Parent);
            }
            catch (Exception)
            {
            }
        }

        private void tsbBack_Click(object sender, EventArgs e)
        {
            // Move backwards through navigation log
            explorerBrowser.NavigateLogLocation(NavigationLogDirection.Backward);

        }

        private void tsbForward_Click(object sender, EventArgs e)
        {
            // Move forwards through navigation log
            explorerBrowser.NavigateLogLocation(NavigationLogDirection.Forward);

        }

        private void flowLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            String[] Params = (String[])e.Data.GetData(DataFormats.FileDrop);
            string myParam = Params[0];
            string myDir;
            string myDirCaption;

            if (System.IO.File.Exists(myParam))
                myDir = System.IO.Path.GetDirectoryName(myParam);
            else
                myDir = System.IO.Path.GetFullPath(myParam);

            myDirCaption = System.IO.Path.GetFileName(myDir);

            if (myDirCaption == "")
                myDirCaption = myDir;


            int i = applicationSettings.sections.GetItemIDByString(sectionName, "FAV");
            if (i >= 0)
                applicationSettings.sections[i].settings.Add(myDirCaption, myDir);
            

            //            if (sender.GetType().Name == "ToolStrip")
            {
                CreateFavButton(myDirCaption, myDir, flowLayoutPanel);
            }


        }

        private void flowLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            //Console.WriteLine(s[0]);

            e.Effect = DragDropEffects.Link;
        }

        private void explorerBrowser_Enter(object sender, EventArgs e)
        {
            this.OnMyEvent();
         
            //FormMain.setUserControlExplorer(this, currentTabControl);
        }

        private void explorerBrowser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                //tsbViewer_Click(sender, null);
                MessageBox.Show("F3");
            }

        }

        private void explorerBrowser_NavigationComplete(object sender, NavigationCompleteEventArgs e)
        {
            // This event is BeginInvoked to decouple the ExplorerBrowser UI from this UI
            BeginInvoke(new MethodInvoker(delegate()
            {
                // update event history text box
                string location = (e.NewLocation == null) ? "(unknown)" : e.NewLocation.ParsingName;

                //this.eventHistoryTextBox.Text = this.eventHistoryTextBox.Text + "Navigation completed. New Location = " + location + "\n";

                if (!location.Contains("::"))
                    optionSection.settings.GetItemByString("LastPath").Value = location;

                //Properties.Settings.Default.LastPath1 = location;

                tsddbtn.Text = GetRootDriveFromPath(location);
                
                tssl.Text = GetFreeDiskSpace(location);

                
                if (pathChanged != null)
                    this.pathChanged(location, this);
            }));

            this.OnMyEvent();
            //FormMain.setUserControlExplorer(this, currentTabControl);
        }

        private void explorerBrowser_SelectionChanged(object sender, EventArgs e)
        {
            // This event is BeginInvoked to decouple the ExplorerBrowser UI from this UI
            //BeginInvoke(new MethodInvoker(delegate()
            //{
            //    StringBuilder itemsText = new StringBuilder();

            //    foreach (ShellObject item in explorerBrowser1.SelectedItems)
            //    {
            //        if (item != null)
            //            itemsText.AppendLine("\tItem = " + item.GetDisplayName(DisplayNameType.Default));
            //    }

            //    //this.selectedItemsTextBox.Text = itemsText.ToString();
            //    //this.itemsTabControl.TabPages[1].Text = "Selected Items (Count=" + explorerBrowser1.SelectedItems.Count.ToString() + ")";
            //}));

            this.OnMyEvent();
            //FormMain.setUserControlExplorer(this, currentTabControl);

            tsbViewer.Enabled = explorerBrowser.SelectedItems[0] != null;
            tsbDel.Enabled = tsbViewer.Enabled;

        }

        private void tsbSwitch_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormMain.current_uce1.explorerBrowser.NavigationLog.CurrentLocation == explorerBrowser.NavigationLog.CurrentLocation)
                    explorerBrowser.Navigate(FormMain.current_uce2.explorerBrowser.NavigationLog.CurrentLocation);
                else
                    explorerBrowser.Navigate(FormMain.current_uce1.explorerBrowser.NavigationLog.CurrentLocation);
            }
            catch (Exception)
            {
            }
        }

        private void tsbDel_Click(object sender, EventArgs e)
        {
            // This event is BeginInvoked to decouple the ExplorerBrowser UI from this UI
            if (MessageBox.Show("Delete all selected files?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BeginInvoke(new MethodInvoker(delegate()
                {
                    StringBuilder itemsText = new StringBuilder();

                    foreach (ShellObject item in explorerBrowser.SelectedItems)
                    {
                        if (item != null)
                        {
                            //Console.WriteLine(item.GetDisplayName(DisplayNameType.Default));
                            //Console.WriteLine(item.ParsingName);
                            System.IO.File.Delete(item.ParsingName);
                        }
                    }

                    //this.selectedItemsTextBox.Text = itemsText.ToString();
                    //this.itemsTabControl.TabPages[1].Text = "Selected Items (Count=" + explorerBrowser1.SelectedItems.Count.ToString() + ")";
                }));
            }

        }

        private void tsbViewer_Click(object sender, EventArgs e)
        {
            FormViewer formViewer = new FormViewer();

            ShellObject so = explorerBrowser.SelectedItems[0];
            if (so != null)
            {
                formViewer.Show();
                formViewer.SetText(so.ParsingName);
            }

            //foreach (ShellObject item in explorerBrowser.SelectedItems)
            //{
            //    if (item != null)
            //        itemsText.AppendLine("\tItem = " + item.GetDisplayName(DisplayNameType.Default));
            //}

        }

        private void tsmiCopyFullnameToClipboard_Click(object sender, EventArgs e)
        {
            ShellObject so = explorerBrowser.SelectedItems[0];
            if (so != null)
            {
                Clipboard.SetText(so.ParsingName);
            }

        }

        private void tsmiCopyShortnameToClipboard_Click(object sender, EventArgs e)
        {
            ShellObject so = explorerBrowser.SelectedItems[0];
            if (so != null)
            {
                Clipboard.SetText(so.Name);
            }

        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            ShowDetails = tsmShowDetails.Checked;

            if (tsmShowDetails.Checked)
                explorerBrowser.NavigationOptions.PaneVisibility.Details = PaneVisibilityState.Show;
            else
                explorerBrowser.NavigationOptions.PaneVisibility.Details = PaneVisibilityState.Hide;
            explorerBrowser.Update();

            optionSection.settings.GetItemByString("ShowDetails").Value = ShowDetails.ToString();
        }

        private void tsmShowPreview_Click(object sender, EventArgs e)
        {
            ShowPreview = tsmShowPreview.Checked;

            if (ShowPreview)
                explorerBrowser.NavigationOptions.PaneVisibility.Preview = PaneVisibilityState.Show;
            else
                explorerBrowser.NavigationOptions.PaneVisibility.Preview = PaneVisibilityState.Hide;

            optionSection.settings.GetItemByString("ShowPreview").Value = ShowPreview.ToString();
        }

        private void tsmShowNavigation_Click(object sender, EventArgs e)
        {
            ShowNavigation = tsmShowNavigation.Checked;

            if (ShowNavigation)
                explorerBrowser.NavigationOptions.PaneVisibility.Navigation = PaneVisibilityState.Show;
            else
                explorerBrowser.NavigationOptions.PaneVisibility.Navigation = PaneVisibilityState.Hide;

            optionSection.settings.GetItemByString("ShowNavigation").Value = ShowNavigation.ToString();
        }

        private void CreateFavButton(string FavText, string FavPath, FlowLayoutPanel flp)
        {
            //System.Windows.Forms.ToolStripButton mytsm = new System.Windows.Forms.ToolStripButton();
            System.Windows.Forms.Button mybtn = new System.Windows.Forms.Button();
            //ts.Items.Add(mytsm);


            //this.ts2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            //this.tsbBack2,
            //this.tsbForward2,
            //this.toolStripSeparator4,
            //this.tsbSwitch2,
            //this.toolStripSeparator6,
            //this.tsbDel2,
            //this.toolStripDropDownButton2,
            //this.toolStripSeparator10});
            //this.ts2.Location = new System.Drawing.Point(0, 35);
            //this.ts2.Name = "ts2";
            //this.ts2.Size = new System.Drawing.Size(784, 25);
            //this.ts2.TabIndex = 20;
            //this.ts2.Text = "toolStrip5";

            mybtn.Parent = flp;
            if (FavText == "")
                FavText = FavPath;
            mybtn.Text = FavText;
            mybtn.Tag = 1;
            mybtn.Height = 22;
            toolTip.SetToolTip(mybtn, FavPath);
            mybtn.FlatStyle = FlatStyle.Flat;
            //mybtn.ToolTipText = FavPath;
            mybtn.Click += new System.EventHandler(mybtn_Click);
            mybtn.ContextMenuStrip = contextMenuStrip;
            mybtn.AutoSize = true;
            mybtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;


            //mytsm.Text = FavText;
            //mytsm.Tag = 1;
            //mytsm.ToolTipText = FavPath;
            //mytsm.Click += new System.EventHandler(mytsm_Click);
        }

        private void mybtn_Click(object sender, EventArgs e)
        {
            //Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser explorerBrowser0;

            //if ((sender as Button).Parent == flowLayoutPanel)
            //    explorerBrowser0 = explorerBrowser1;
            //else
            //    explorerBrowser0 = explorerBrowser2;

            //MessageBox.Show((sender as ToolStripButton).ToolTipText);

            string pfad = toolTip.GetToolTip(sender as Button);
            if (pfad != "")
            {
                try
                {
                    //explorerBrowser1.Navigate(ShellFileSystemFolder.FromFolderPath(Properties.Settings.Default.LastPath1));
                    explorerBrowser.Navigate(ShellFileSystemFolder.FromParsingName(pfad));
                }
                catch (Exception) { }
            }
        }

        // Größe und freien Speicherplatz ausgeben
        private string GetFreeDiskSpace(string path)
        {
            string driveletter = path.Substring(0, 2);

            try
            {
                DriveInfo driveInfo = new DriveInfo(driveletter);
                string freeSpace = GetBestDiskSpaceSize(driveInfo.TotalFreeSpace);
                string totalSpace = GetBestDiskSpaceSize(driveInfo.TotalSize);

                return "   [" + driveInfo.VolumeLabel + " " + freeSpace + " / " + totalSpace + "]";
            }
            catch (Exception)
            {
                return "";

            }

            //Console.WriteLine("Speicherplatz von C:");
            //Console.WriteLine("Größe: {0} Byte", driveInfo.TotalSize);
            //Console.WriteLine("Gesamter freier Platz: {0} Byte", driveInfo.TotalFreeSpace);
            //Console.WriteLine("Für den aktuellen Benutzer verfügbarer " + "freier Platz: {0} Byte", driveInfo.AvailableFreeSpace);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(sender.GetType().Name);
            //MessageBox.Show(toolTip1.GetToolTip(sender as Button));
            // Console.WriteLine(((sender as Button).GetCurrentParent() as ContextMenuStrip).Name.ToString());
            //Console.WriteLine(((sender as ToolStripMenuItem).GetCurrentParent() as ContextMenuStrip).Name.ToString());


            //(contextMenuStrip1.SourceControl as Button).Text = "Fav" + (contextMenuStrip1.SourceControl as Button).Tag.ToString();
            //toolTip1.SetToolTip((contextMenuStrip1.SourceControl as Button), "");

            string mycaption = (contextMenuStrip.SourceControl as Button).Text;
            string mypath = toolTip.GetToolTip(contextMenuStrip.SourceControl as Button);


            int i = applicationSettings.sections.GetItemIDByString(sectionName, "FAV");
            if (i > -1)
            {
                //Section section = applicationSettings.sections.GetItemByString(mypath);
                int settingID = applicationSettings.sections[i].settings.GetItemIDByString(mycaption);
                Setting setting = applicationSettings.sections[i].settings.GetItemByString(mycaption);
                applicationSettings.sections[i].settings.Remove(setting);
                //applicationSettings.sections.Remove(section);
            }


            (contextMenuStrip.SourceControl as Button).Dispose();
            //MessageBox.Show((contextMenuStrip1.SourceControl as Button).Text);
        }
        private string GetBestDiskSpaceSize(long disksize)
        {
            string ResultString;
            Int64 diskSpaceKB = disksize / 1024;
            Int64 diskSpaceMB = diskSpaceKB / 1024;
            Int64 diskSpaceGB = diskSpaceMB / 1024;

            ResultString = diskSpaceGB.ToString() + "GB";

            if (diskSpaceGB < 1)
                ResultString = diskSpaceMB.ToString() + "MB";

            if (diskSpaceMB < 1)
                ResultString = disksize.ToString() + "Byte";

            return ResultString;
        }

        private void ReadAllDrives(ToolStripDropDownButton btn)
        {
            btn.DropDownItems.Clear();

            foreach (var driveInfo in DriveInfo.GetDrives())
            {
                ToolStripMenuItem newBtn = new ToolStripMenuItem();
                if (driveInfo.IsReady)
                {
                    newBtn.Text = driveInfo.Name + " [" + driveInfo.VolumeLabel + "]";
                    newBtn.ToolTipText = driveInfo.Name;
                    newBtn.Image = WDE.Properties.Resources.Drive;
                    if (btn.Name == "tsddbtn1")
                        newBtn.Tag = 1;
                    else
                        newBtn.Tag = 2;

                    newBtn.Click += new System.EventHandler(this.newBtn_Click);

                    btn.DropDownItems.Add(newBtn);
                    //    Console.WriteLine("Label: {0}", driveInfo.VolumeLabel);
                    //    Console.WriteLine("Dateisystem: {0}", driveInfo.DriveFormat);
                    //    Console.WriteLine("Gesamtgröße: {0} Byte", driveInfo.TotalSize);
                    //    Console.WriteLine("Freier Speicher: {0} Byte", driveInfo.TotalFreeSpace);
                    //    Console.WriteLine("Für den akt. Benutzer verfügbarer freier " +
                    //       "Speicher: {0} Byte", driveInfo.AvailableFreeSpace);
                }
                else
                {
                    //    Console.WriteLine("Nicht verfügbar");
                }
                //Console.WriteLine("Wurzelverzeichnis: {0}", driveInfo.RootDirectory.FullName);
            }

        }
        private void newBtn_Click(object sender, EventArgs e)
        {
            // Move backwards through navigation log
            //explorerBrowser1.NavigateLogLocation(NavigationLogDirection.Backward);
            string dir = (sender as ToolStripMenuItem).ToolTipText;

            //if ((int)(sender as ToolStripMenuItem).Tag == 1)
            try
            {
                explorerBrowser.Navigate(ShellFileSystemFolder.FromParsingName(dir));
            }
            catch (Exception)
            {
            }

        }

        public void RefreshApp()
        {
            ReadAllDrives(tsddbtn);
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void explorerBrowser_ItemsChanged(object sender, EventArgs e)
        {
            //System.Media.SystemSounds.Beep.Play();
            // This event is BeginInvoked to decouple the ExplorerBrowser UI from this UI
            BeginInvoke(new MethodInvoker(delegate()
            {
                // update items text box
                StringBuilder itemsText = new StringBuilder();

                //foreach (ShellObject item in explorerBrowser1.Items)
                //{
                //    if (item != null)
                //        itemsText.AppendLine("\tItem = " + item.GetDisplayName(DisplayNameType.Default));
                //}

                //this.itemsTextBox.Text = itemsText.ToString();
                //this.itemsTabControl.TabPages[0].Text = "Items (Count=" + explorerBrowser1.Items.Count.ToString() + ")";

            }));
            //explorerBrowser1.Focus();
            this.OnMyEvent();
            //FormMain.setUserControlExplorer(this, currentTabControl);
        }

        private void OnMyEvent()
        {
            if (this.MyEvent != null)
                this.MyEvent(this, null);
        }
    }

 
}
