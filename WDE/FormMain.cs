using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Windows.Forms.Integration;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Controls;
using System.Diagnostics;
using System.IO;
using jd.Helper.Configuration;

namespace WDE
{
    public partial class FormMain : Form
    {
        const int TOPOFEACHOTHER = 1;
        const int NEXTTOEACHOTHER = 2;
        int TabSheetCounter = 0;
        static public UserControlExplorer current_uce = null;
        static public UserControlExplorer current_uce1 = null;
        static public UserControlExplorer current_uce2 = null;

        ApplicationSettings applicationSettings = new ApplicationSettings(Path.Combine(Application.LocalUserAppDataPath, "wdeConfig.xml"));
        
        public FormMain()
        {
            InitializeComponent();

            applicationSettings.Load();

            for (int i = 0; i < applicationSettings.sections.Count; i++)
            {
                if (applicationSettings.sections[i].ClassName == "OPTIONS")
                {
                    string sectionName = applicationSettings.sections[i].Name;
                    TabControl tc = null;

                    string tabControlName = "";
                    if (applicationSettings.sections[i].settings.GetItemByString("ParentTabControl") != null)
                        tabControlName = applicationSettings.sections[i].settings.GetItemByString("ParentTabControl").Value;

                    if ((tabControlName == "") || (tabControlName == tabControl1.Name))
                        tc = tabControl1;
                    else
                        tc = tabControl2;

                    AddExplorer(tc, sectionName);
                }
            }

            if (tabControl1.TabCount == 0)
                AddExplorer(tabControl1, "");
            if (tabControl2.TabCount == 0)
                AddExplorer(tabControl2, "");

            //
            if (Properties.Settings.Default.CallUpgrade)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.CallUpgrade = false;
                Properties.Settings.Default.Save();
            }

            //caption
            this.Text += System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            Properties.Settings settings = Properties.Settings.Default;
            this.Size = settings.formsize;

            if (Properties.Settings.Default.Layout == TOPOFEACHOTHER) 
            {
                panel1.Height = Properties.Settings.Default.Panel1H;
            }
            else
            {
                toolStripButton2_Click(null, null);
            }

            Left = Properties.Settings.Default.FormL;
            Top = Properties.Settings.Default.FormT;

            if (this.Height < 50)
                this.Height = 700;
            if (this.Width < 50)
                this.Width = 800;


            // initialize known folder combo box
            List<string> knownFolderList = new List<string>();
            foreach (IKnownFolder folder in KnownFolders.All)
            {
                knownFolderList.Add(folder.CanonicalName);
            }
            knownFolderList.Sort();
            //tscbKnownFolder.Items.AddRange(knownFolderList.ToArray());

            foreach (string s in knownFolderList)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(s);


                jumpToToolStripMenuItem.DropDownItems.Add(s, null, jumpTo_Click);
            }



            if (!Properties.Settings.Default.ViewToolbar)
            {
                mainToolbarToolStripMenuItem.Checked = false;
                mainToolbarToolStripMenuItem.CheckState = CheckState.Unchecked;
                tsMain.Visible = false;
            }

            if (!Properties.Settings.Default.ViewExpl1Statusbar)
            {
                tsmiViewStatusbar1.Checked = false;
                tsmiViewStatusbar1.CheckState = CheckState.Unchecked;
                //statusStrip1.Visible = false;
            }
            if (!Properties.Settings.Default.ViewExpl1Toolbar)
            {
                tsmiViewToolbar1.Checked = false;
                tsmiViewToolbar1.CheckState = CheckState.Unchecked;
                //flowLayoutPanel1.Visible = false;
            }
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            applicationSettings.Save();

            Properties.Settings settings = Properties.Settings.Default;
            Properties.Settings.Default.Panel1H = panel1.Height;
            Properties.Settings.Default.Panel1W = panel1.Width;
            Properties.Settings.Default.FormL = Left;
            Properties.Settings.Default.FormT = Top;
            Properties.Settings.Default.FormW = Width;
            Properties.Settings.Default.FormH = Height;
            Properties.Settings.Default.ViewToolbar = tsMain.Visible;
            settings.formsize = this.Size;
            settings.Save();      

            Properties.Settings.Default.Save();
        }

        private void knownFolderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Navigate to a known folder
                IKnownFolder kf = KnownFolderHelper.FromCanonicalName( this.tscbKnownFolder.Items[tscbKnownFolder.SelectedIndex].ToString());

                current_uce.explorerBrowser.Navigate((ShellObject)kf);
            }
            catch (COMException)
            {
                MessageBox.Show("Navigation not possible.");
            }

        }

        private void navigationHistoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // navigating to specific index in navigation log
            //explorerBrowser1.NavigateLogLocation(this.navigationHistoryCombo.SelectedIndex);

        }

        private void tsbExplorer_Click(object sender, EventArgs e)
        {
           string Programmname = "explorer.exe";
           System.Diagnostics.Process.Start(Programmname, current_uce.explorerBrowser.NavigationLog.CurrentLocation.ParsingName); 
        }


        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }



        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mycaption = (contextMenuStrip1.SourceControl as Button).Text;
            string mypath = toolTip1.GetToolTip(contextMenuStrip1.SourceControl as Button);

            (contextMenuStrip1.SourceControl as Button).Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyData.ToString());
        }


        private void ClearLayout()
        {
            panel1.Dock = DockStyle.None;
            splitter.Dock = DockStyle.Bottom;
            panel2.Dock = DockStyle.None;
        }

        private void OrderLayout()
        {
            panel1.BringToFront();
            splitter.BringToFront();
            panel2.BringToFront();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tsbLayout1.Checked)
                return;
            
            //Übereinander
            Properties.Settings.Default.Layout = TOPOFEACHOTHER;
            tsbLayout1.Checked = true;
            tsbLayout2.Checked = false;

            ClearLayout();

            panel1.Dock = DockStyle.Top;
            panel1.Height = (this.Height - menuStrip1.Height - tsMain.Height) / 2;
            splitter.Dock = DockStyle.Top;
            panel2.Dock = DockStyle.Fill;

            OrderLayout();

            layout1ToolStripMenuItem.Checked = tsbLayout1.Checked;
            layout2ToolStripMenuItem.Checked = tsbLayout2.Checked;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (tsbLayout2.Checked)
                return;

            //Hintereinanden
            Properties.Settings.Default.Layout = NEXTTOEACHOTHER;
            tsbLayout2.Checked = true;
            tsbLayout1.Checked = false;

            ClearLayout();

            panel1.Dock = DockStyle.Left;
            panel1.Width = panel1.Width = Properties.Settings.Default.Panel1W;
            if (panel1.Width > (this.Width - 20))
                panel1.Width = this.Width / 2;
            splitter.Dock = DockStyle.Left;
            panel2.Dock = DockStyle.Fill;

            OrderLayout();

            layout1ToolStripMenuItem.Checked = tsbLayout1.Checked;
            layout2ToolStripMenuItem.Checked = tsbLayout2.Checked;
        }

        private void tsbShowHide1_Click(object sender, EventArgs e)
        {
            panel1.Visible = tsbShowHide1.Checked;

            if (!panel1.Visible)
                panel2.Visible = true;

            AjustPanel();
        }

        private void tsbShowHide2_Click(object sender, EventArgs e)
        {
            panel2.Visible = tsbShowHide2.Checked;

            if (!panel2.Visible)
                panel1.Visible = true;

            AjustPanel();
        }

        private void AjustPanel()
        {
            if ((panel1.Visible) && (!panel2.Visible))
                panel1.Dock = DockStyle.Fill;
            else
            {
                if (tsbLayout1.Checked)
                    panel1.Dock = DockStyle.Top;
                else
                    panel1.Dock = DockStyle.Left;
            }

        }

        private void ToogleToolStripMenuItem(ToolStripMenuItem tsmi, System.Windows.Forms.Control obj)
        {
            if (tsmi.CheckState == CheckState.Checked)
                tsmi.CheckState = CheckState.Unchecked;
            else
                tsmi.CheckState = CheckState.Checked;

            obj.Visible = tsmi.CheckState == CheckState.Checked;

        }

        private void mainToolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tsmiViewToolbar.CheckState == CheckState.Checked)
                tsmiViewToolbar.CheckState = CheckState.Unchecked;
            else
                tsmiViewToolbar.CheckState = CheckState.Checked;

            tsMain.Visible = tsmiViewToolbar.CheckState == CheckState.Unchecked;
        }

        private void tsmiViewToolbar1_Click(object sender, EventArgs e)
        {
            //ToogleToolStripMenuItem(tsmiViewToolbar1, flowLayoutPanel1);
        }

        private void tsmiViewStatusbar1_Click(object sender, EventArgs e)
        {
            //ToogleToolStripMenuItem(tsmiViewStatusbar1, statusStrip1);
        }

        private void tsmiViewToolbar2_Click(object sender, EventArgs e)
        {
            //ToogleToolStripMenuItem(tsmiViewToolbar2, flowLayoutPanel2);
        }

        private void tsmiViewStatusbar2_Click(object sender, EventArgs e)
        {
            //ToogleToolStripMenuItem(tsmiViewStatusbar2, statusStrip2);
        }

        private void tsbSwitch_Click_1(object sender, EventArgs e)
        {
            ShellObject so=current_uce1.explorerBrowser.NavigationLog.CurrentLocation;
            current_uce1.explorerBrowser.Navigate(current_uce2.explorerBrowser.NavigationLog.CurrentLocation);
            current_uce2.explorerBrowser.Navigate(so);
        }


        private void path_Changed(string pathname, UserControlExplorer uce)
        {
            uce.Parent.Text = pathname;
        }

        private void AddExplorer(TabControl DestinationTabControl, string name)
        {
            TabSheetCounter++;

            TabPage newTabPage = new TabPage();
            DestinationTabControl.TabPages.Add(newTabPage);

            UserControlExplorer uce = new UserControlExplorer(TabSheetCounter, applicationSettings, name, DestinationTabControl, newTabPage);
            uce.Parent = newTabPage;
            uce.Dock = DockStyle.Fill;
            uce.pathChanged += new UserControlExplorer.PathChanged(this.path_Changed);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Section section = applicationSettings.sections.Add("A1", "");
            section.settings.Add("AA1", "1");
            section.settings.Add("AA2", "2");
            section = applicationSettings.sections.Add("B1", "");
            section.settings.Add("BB1", "3");
        }

        private void tsmiNewTab_Click(object sender, EventArgs e)
        {
            TabControl tc = (cmsTabControl.SourceControl as TabControl);

            AddExplorer(tc, "");
            tc.SelectedIndex = tc.TabCount - 1;
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (cmsTabControl.SourceControl as TabControl);
            TabPage tp = tc.SelectedTab;
            if (tp != null)
            {
                string removeSectionName = tp.Tag.ToString();
                applicationSettings.sections.Remove(applicationSettings.sections.GetItemByString(removeSectionName, "FAV"));
                applicationSettings.sections.Remove(applicationSettings.sections.GetItemByString(removeSectionName, "OPTIONS"));
                tc.TabPages.Remove(tp);
            }
        }

        private void cmsTabControl_Opening(object sender, CancelEventArgs e)
        {
            TabControl tc = (cmsTabControl.SourceControl as TabControl);
            tsmiLockTab.Checked = (tc.SelectedTab.ImageIndex == 0);


            closeTabToolStripMenuItem.Enabled = ((tc.TabCount > 1) && (!tsmiLockTab.Checked));
        }

        private void tsmiLockTab_Click(object sender, EventArgs e)
        {
            TabControl tc = (cmsTabControl.SourceControl as TabControl);
            TabPage tp = tc.SelectedTab;
            if (tsmiLockTab.Checked)
                tp.ImageIndex = 0;
            else
                tp.ImageIndex = -1;

            string sectionName = tp.Tag.ToString();
            applicationSettings.sections.GetItemByString(sectionName, "OPTIONS").settings.GetItemByString("Locked").Value = 
                tsmiLockTab.Checked.ToString();
        }


        static public void setUserControlExplorer(UserControlExplorer uce, TabControl tabControl)
        {
            current_uce = uce;

            if (tabControl.Name == "tabControl1")
                current_uce1 = uce;
            else
                current_uce2 = uce;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sectionName = tabControl1.SelectedTab.Tag.ToString();
                //MessageBox.Show((tabControl1.SelectedTab.Controls["UserControlExplorer"] as UserControlExplorer).Name);
                current_uce1 = (tabControl1.SelectedTab.Controls["UserControlExplorer"] as UserControlExplorer);
                current_uce = current_uce1;
            }
            catch (Exception)
            {
            }
        }

        private void jumpTo_Click(object sender, EventArgs e)
        {
            string jumptoFolder = (sender as ToolStripMenuItem).Text;
            //MessageBox.Show(jumptoFolder);

            try
            {
                // Navigate to a known folder
                IKnownFolder kf = KnownFolderHelper.FromCanonicalName(jumptoFolder);

                current_uce.explorerBrowser.Navigate((ShellObject)kf);
            }
            catch (COMException)
            {
                MessageBox.Show("Navigation not possible.");
            }
        }


    }
}
