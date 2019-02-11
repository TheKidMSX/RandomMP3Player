#region

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using AxWMPLib;
using RandomMP3Player.Properties;
using WMPLib;

#endregion

namespace RandomMP3Player
{
    public partial class FrmMain : Form
    {
        private readonly bool _autoFillList = Settings.Default.AutoFillList;
        private readonly bool _expandTree = Settings.Default.Expandtree;
        private readonly bool _keepPlayList = Settings.Default.KeepPlayList;
        private readonly string _setIniFileLocation;
        private readonly bool _shuffle = Settings.Default.Shuffle;
        private string _fileBusy = string.Empty;
        private string _language = Settings.Default.Language;
        private bool _miniMode;
        private int _mp3InfoCounter;
        private List<string> _musicTypes = new List<string>();
        private string _path = string.Empty;
        private bool _running;
        private bool _selectAllChildren = true;
        private readonly List<string> _selectedDirectories = new List<string>();
        private List<string> _selectedMp3List = new List<string>();
        private string _setFileLocation;
        private string _setPlayListLocation;
        private string _substringDirectory;
        private Thread _tr;
        private bool _wantStop;

        public FrmMain()
        {
            InitializeComponent();

            FrmSplashscreen splash = new FrmSplashscreen();
            splash.Show();

            /*
            Thread t1 = new Thread(SplashForm);
            t1.Start();
            Thread.Sleep(3000); // 5 seconds
            //	t1.Abort();
            Thread.Sleep(500);
            */

            lblWarning.Visible = false;
            _setFileLocation = (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _setIniFileLocation = (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _setPlayListLocation = (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            try
            {
                ReadIniFile();
            }
            catch
            {
                Messages.Message("standaarddir");
                txtPlayListtarget.Text = _setPlayListLocation;
                txtSourcePath.Text = _setFileLocation;
                WriteIniLocation();
            }
            txtPlayListtarget.Text = _setPlayListLocation;
            txtSourcePath.Text = _setFileLocation;
            saveFileDialogSelectie.InitialDirectory = _setPlayListLocation;
            openFileDialogSelectie.InitialDirectory = _setPlayListLocation;
            saveFileDialogSelectie.Filter = @"(*.sel)|*.sel";

            chkShuffle.Checked = _shuffle;
            chkKeepPlayList.Checked = _keepPlayList;
            chkAutoVulLijst.Checked = _autoFillList;
            chkExpandtree.Checked = _expandTree;

            if (chkAutoVulLijst.Checked)
            {
                btnMakeList_Click(null, null);
            }
            SetLanguage();
            WindowState = FormWindowState.Normal;
            CloseForm = true;
        }
        
        public static bool CloseForm { get; set; }
        
        /*
        private void SplashForm()
        {
            FrmSplashscreen newSplashForm = new FrmSplashscreen();
            newSplashForm.ShowDialog();
            newSplashForm.Dispose();
        }
        */

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // BOOOOOEEEEEEE!!!!
            CheckForIllegalCrossThreadCalls = false;

            FillDriveList();
        }

        private static void LoadChecked(IEnumerable tNodeList, ICollection<string> checkedItems)
        {
            foreach (TreeNode tNode in tNodeList)
            {
                if (tNode.Checked)
                    checkedItems.Add(tNode.FullPath);
                LoadChecked(tNode.Nodes, checkedItems);
            }
        }

        private void FillDriveList()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            cmdBoxDrives.Items.Clear();
            foreach (DriveInfo drive in drives)
            {
                ComboBoxItem cbi = new ComboBoxItem(string.Format("({0} [{1}]", drive.Name, drive.DriveType), drive);
                cmdBoxDrives.Items.Add(cbi);
            }
            cmdBoxDrives.SelectedIndex = cmdBoxDrives.Items.Count > 4 ? 4 : 0;
        }

        private void checkDo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDo.Checked)
            {
                MakeSelectedMp3List();
                checkDo.Text = _language == "Eng" ? "Stop copying" : "Stop kopieren";
                _wantStop = false;
                btnPlay.Enabled = false;

                _tr = new Thread(CopyMp3);
                _running = true;
                _tr.Start();
                timerMonitor.Start();
            }
            else
            {
                _wantStop = true;
                checkDo.Text = _language == "Eng" ? "Copy selection" : "Kopieer Selectie";
                btnPlay.Enabled = true;
            }
        }

        private void CopyMp3()
        {
            if (_selectedDirectories.Count == 0)
            {
                Messages.Message("geenkopieselectie");
                checkDo.Text = _language == "Eng" ? "Copy selection" : "Kopieer Selectie";
                _wantStop = true;
                checkDo.Checked = false;
                return;
            }

            int aantal = Convert.ToInt32(numAmountMP3.Value);

            if (_selectedMp3List.Count < aantal)
            {
                aantal = _selectedMp3List.Count;
            }

            ComboBoxItem cbi = (ComboBoxItem)cmdBoxDrives.SelectedItem;
            DriveInfo drvi = (DriveInfo)cbi.Obj;
            string targetPath = drvi.Name;

            try
            {
                int n = 0;
                int t = 1;
                do
                {
                    string padnaam = Path.GetFileName(_selectedMp3List[n]);
                    if (padnaam != null)
                    {
                        string destfile = Path.Combine(targetPath, padnaam);
                        if (_language == "Ned")
                        {
                            _fileBusy = "No." + t + " van " + aantal + " - " + Path.GetFileName(_selectedMp3List[n]);
                        }
                        else
                        {
                            _fileBusy = "No." + t + " of " + aantal + " - " + Path.GetFileName(_selectedMp3List[n]);
                        }
                        File.Copy(_selectedMp3List[n], destfile, true);
                    }
                    n++;
                    t++;
                } while ((n < aantal) && !_wantStop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _running = false;
                return;
            }
            _running = false;
        }

        private void timerMonitor_Tick(object sender, EventArgs e)
        {
            txtMonitor.Text = _fileBusy;

            if (_running) return;
            timerMonitor.Stop();
            if (_language == "Ned")
            {
                txtMonitor.Text = @"Kopieren is klaar";
                MessageBox.Show("Kopieren is klaar");
                checkDo.Checked = false;
                checkDo.Text = @"Kopieer selectie";
            }
            else
            {
                txtMonitor.Text = @"Copying is ready";
                MessageBox.Show("Copying is ready");
                checkDo.Checked = false;
                checkDo.Text = @"Copy selection";
            }
            btnPlay.Enabled = true;
        }

        private void WindowsMediaPlayer_CurrentItemChange(object sender, _WMPOCXEvents_CurrentItemChangeEvent e)
        {
            txtTitel.BackColor = Color.White;
            txtArtiest.BackColor = Color.White;
            txtAlbumTitel.BackColor = Color.White;
            txtGenre.BackColor = Color.White;
            timerPlaysong.Start();
        }

        private void btnTitel_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.currentItem.setItemInfo("Title", txtTitel.Text);
            WindowsMediaPlayer.Ctlcontrols.currentItem.setItemInfo("Artist", txtArtiest.Text);
            WindowsMediaPlayer.Ctlcontrols.currentItem.setItemInfo("Album", txtAlbumTitel.Text);
            WindowsMediaPlayer.Ctlcontrols.currentItem.setItemInfo("Genre", txtGenre.Text);
        }

        private void timerPlaysong_Tick(object sender, EventArgs e)
        {
            _mp3InfoCounter++;
            if (_mp3InfoCounter != 10) return;
            timerPlaysong.Stop();
            _mp3InfoCounter = 0;
            FillMp3Items();

            string cutTitel = string.Empty;
            for (int i = 0; i < txtCurrentSong.Text.Length; i++)
            {
                cutTitel = txtCurrentSong.Text.Substring(i, txtCurrentSong.Text.Length - i);
                if (!cutTitel.Contains(@"\")) break;
            }

            cutTitel = cutTitel.Substring(0, cutTitel.Length - 4);
            if (txtTitel.Text == cutTitel) txtTitel.BackColor = Color.Red;
            if (txtArtiest.Text == "") txtArtiest.BackColor = Color.Red;
            if (txtAlbumTitel.Text == "") txtAlbumTitel.BackColor = Color.Red;
            if (txtGenre.Text == @"Other") txtGenre.BackColor = Color.Red;
        }

        private void FillMp3Items()
        {
            txtCurrentSong.Text = WindowsMediaPlayer.Ctlcontrols.currentItem.sourceURL;
            txtTitel.Text = WindowsMediaPlayer.Ctlcontrols.currentItem.getItemInfo("Title");
            txtArtiest.Text = WindowsMediaPlayer.Ctlcontrols.currentItem.getItemInfo("Artist");
            txtAlbumTitel.Text = WindowsMediaPlayer.Ctlcontrols.currentItem.getItemInfo("Album");
            txtGenre.Text = WindowsMediaPlayer.Ctlcontrols.currentItem.getItemInfo("Genre");
        }

        private void cmdBoxDrives_Click(object sender, EventArgs e)
        {
            FillDriveList();
        }

        private void linkLblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:info@thekidmsx.nl?body=Please type your message in English or Dutch");
        }

        private void picNed_Click(object sender, EventArgs e)
        {
            _language = "Ned";
            Settings.Default.Language = "Ned";
            Settings.Default.Save();
            SetLanguage();
        }

        private void picEng_Click(object sender, EventArgs e)
        {
            _language = "Eng";
            Settings.Default.Language = "Eng";
            Settings.Default.Save();
            SetLanguage();
        }

        private void SetLanguage()
        {
            List<string> abouts = About.Aboutjes();
            lblVersion.Text = abouts[0];
            lblQuestion.Text = abouts[1];
            lblProgrammer.Text = abouts[2];
            txtLicense.Text = abouts[4];

            if (_language == "Eng")
            {
                tabControl.TabPages[1].Text = @"MP3 player";
                tabControl.TabPages[2].Text = @"About";
                GroupFillMP3List.Text = @"Fill MP3 list";
                lblMP3Lokatie.Text = @"MP3 location:";
                lblPlayList.Text = @"Playlist location:";
                btnMakeList.Text = @"&Fill list";
                btnBrowseLoadSelectieLokatie.Text = @"Load selection";
                btnBrowseSaveSelectieLokatie.Text = @"Save selection";
                chkAutoVulLijst.Text = @"Autofill list at startup";
                chkExpandtree.Text = @"Expand tree and select all";
                GroupCopy.Text = @"Copy selection";
                lblCopyLokatie.Text = @"Copy to drive:";
                checkDo.Text = @"Copy selection";
                btnCalc.Text = @"Calculate selection";
                chkKeepPlayList.Text = @"Save playlist";
                btnLoadPlayList.Text = @"Load playlist";
                GroupMP3.Text = @"MP3 player";
                btnPlay.Text = @"Play";
                btnUpdateMP3Info.Text = @"Update data";
                lblCurrentSong.Text = @"Location";
                lblTitel.Text = @"Title";
                lblArtiest.Text = @"Artist";
                lblAantal.Text = @"Number of MP3's:";
                lblAmountSource.Text = @"Number of selected MP3's";
                lblWarning.Text = @"One moment please";
                btnClear.Text = @"&Clear";
                chkSelDeSel.Text = chkSelDeSel.Checked ? "Deselect all" : "Select all";
                chkExpandAll.Text = chkExpandAll.Checked ? "Collapse" : "Expand";
            }

            if (_language == "Ned")
            {
                tabControl.TabPages[1].Text = @"MP3 speler";
                tabControl.TabPages[2].Text = @"Over";
                GroupFillMP3List.Text = @"Vul MP3 lijst";
                lblMP3Lokatie.Text = @"MP3 lokatie:";
                lblPlayList.Text = @"Speellijst lokatie:";
                btnMakeList.Text = @"&Vul lijst";
                btnBrowseLoadSelectieLokatie.Text = @"Laad selectie";
                btnBrowseSaveSelectieLokatie.Text = @"Bewaar selectie";
                chkAutoVulLijst.Text = @"Lijst automatisch vullen bij opstarten";
                chkExpandtree.Text = @"Uitvouwen en alles selecteren";
                GroupCopy.Text = @"Kopieer selectie";
                lblCopyLokatie.Text = @"Kopieer naar schijf:";
                checkDo.Text = @"Kopieer selectie";
                btnCalc.Text = @"Bereken selectie";
                chkKeepPlayList.Text = @"Bewaar speellijst";
                btnLoadPlayList.Text = @"Laad speellijst";
                GroupMP3.Text = @"MP3 speler";
                btnPlay.Text = @"Afspelen";
                btnUpdateMP3Info.Text = @"Gegevens bijwerken";
                lblCurrentSong.Text = @"Lokatie";
                lblTitel.Text = @"Titel";
                lblArtiest.Text = @"Artiest";
                lblAantal.Text = @"Aantal MP3's:";
                lblAmountSource.Text = @"Aantal geselecteerde MP3's";
                lblWarning.Text = @"Een moment geduld aub";
                btnClear.Text = @"&Wis";
                chkSelDeSel.Text = chkSelDeSel.Checked ? "Deselecteer alles" : "Selecteer alles";
                chkExpandAll.Text = chkExpandAll.Checked ? "Inklappen" : "Uitklappen";
            }
            PositonButtons();
            txtVersion.Text = About.VersionText();
            MakeSelectedMp3List();
        }

        private void WindowsMediaPlayer_DoubleClickEvent(object sender, _WMPOCXEvents_DoubleClickEvent e)
        {
            int kliklocY = WindowsMediaPlayer.Location.Y + e.fY;
            if (kliklocY > 40) return;

            if (_miniMode == false)
            {
                _miniMode = true;
                MinimumSize = new Size(270, 165);
                Screen s = Screen.FromPoint(Location);
                Location = new Point(s.WorkingArea.Right - 280, s.WorkingArea.Bottom - 165 - 10);
                GroupCopy.Visible = false;
                GroupMP3.Visible = false;
                chkShuffle.Visible = false;
                chkKeepPlayList.Visible = false;
                btnLoadPlayList.Visible = false;
                FormBorderStyle = FormBorderStyle.FixedToolWindow;
                Height = 165;
                Width = 270;
                WindowsMediaPlayer.Top = 6;
                WindowsMediaPlayer.Height = 85;
            }
            else
            {
                _miniMode = false;
                MinimumSize = new Size(460, 520);
                Screen s = Screen.FromPoint(Location);
                Location = new Point(s.WorkingArea.Right - 470, s.WorkingArea.Bottom - 520 - 10);
                GroupCopy.Visible = true;
                GroupMP3.Visible = true;
                chkShuffle.Visible = true;
                chkKeepPlayList.Visible = true;
                btnLoadPlayList.Visible = true;
                FormBorderStyle = FormBorderStyle.Sizable;
                Height = 520;
                Width = 460;
                WindowsMediaPlayer.Top = 344;
                WindowsMediaPlayer.Height = 85;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in treeViewDirs.Nodes)
            {
                node.Checked = false;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_miniMode)
            {
                tabControl.SelectedIndex = 1;
            }
        }

        private void PositonButtons()
        {
            btnClear.Location = new Point(chkSelDeSel.Location.X + chkSelDeSel.Width + 3, btnClear.Location.Y);
            chkExpandAll.Location = new Point(btnClear.Location.X + btnClear.Width + 3, chkExpandAll.Location.Y);
        }

        private class ComboBoxItem
        {
            private readonly string _text;

            public ComboBoxItem(string _text, object obj)
            {
                if (_text == null) throw new ArgumentNullException("_text");
                this._text = _text;
                Obj = obj;
            }

            public object Obj { get; private set; }

            public override string ToString()
            {
                return _text;
            }
        }

        #region checkboxes

        private void chkAutoVulLijst_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.AutoFillList = chkAutoVulLijst.Checked;
            Settings.Default.Save();
        }

        private void chkExpandtree_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Expandtree = chkExpandtree.Checked;
            Settings.Default.Save();
        }

        private void chkShuffle_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Shuffle = chkShuffle.Checked;
            Settings.Default.Save();
        }

        private void chkKeepPlayList_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.KeepPlayList = chkKeepPlayList.Checked;
            Settings.Default.Save();
        }

        # endregion

        #region Set locations

        private void ReadIniFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_setIniFileLocation + "\\RandomMP3Player.ini"))
                {
                    _setFileLocation = sr.ReadLine();
                    _setPlayListLocation = sr.ReadLine();
                    string readLine = sr.ReadLine();
                    if (readLine != null) _musicTypes = readLine.Split(',').ToList();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WriteIniLocation()
        {
            _setFileLocation = txtSourcePath.Text;
            _setPlayListLocation = txtPlayListtarget.Text;
            if (_musicTypes.Count == 0) _musicTypes.Add("mp3,");
            try
            {
                using (StreamWriter sw = new StreamWriter(_setIniFileLocation + "\\RandomMP3Player.ini"))
                {
                    sw.WriteLine(_setFileLocation);
                    sw.WriteLine(_setPlayListLocation);
                    foreach (string mt in _musicTypes)
                    {
                        if (!string.IsNullOrEmpty(mt))
                        {
                            sw.Write(mt + ",");
                        }
                    }
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowsePlayList_Click(object sender, EventArgs e)
        {
            folderBrowserMP3.SelectedPath = _setPlayListLocation;
            if (folderBrowserMP3.ShowDialog(this) != DialogResult.OK)
                return;
            txtPlayListtarget.Text = folderBrowserMP3.SelectedPath;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserMP3.ShowDialog(this) != DialogResult.OK)
                return;
            txtSourcePath.Text = folderBrowserMP3.SelectedPath;
        }

        private void btnBrowseSelectieLokatie_Click(object sender, EventArgs e)
        {
            //lijst nog legen anders worden er te veel vinkjes gezet
            _selectedDirectories.Clear();
            LoadChecked(treeViewDirs.Nodes, _selectedDirectories);
            if (_selectedDirectories.Count == 0)
            {
                Messages.Message("geenselectie");
                return;
            }
            saveFileDialogSelectie.InitialDirectory = _setPlayListLocation;
            if (saveFileDialogSelectie.ShowDialog(this) != DialogResult.OK)
                return;
            StreamWriter sw = new StreamWriter(saveFileDialogSelectie.FileName);
            foreach (string t in _selectedDirectories)
            {
                if (t.Equals(txtSourcePath.Text)) continue;
                string tempname = t.Substring(txtSourcePath.TextLength + 1, t.Length - txtSourcePath.TextLength - 1);
                sw.WriteLine(tempname);
            }
            sw.Close();
        }

        private void btnBrowseLoadSelectieLokatie_Click(object sender, EventArgs e)
        {
            if (treeViewDirs.Nodes.Count == 0)
            {
                Messages.Message("vullijsteerst");
                return;
            }
            openFileDialogSelectie.Filter = @"(*.sel)|*.sel";
            openFileDialogSelectie.InitialDirectory = _setPlayListLocation;
            lblWarning.Visible = true;
            if (openFileDialogSelectie.ShowDialog(this) != DialogResult.OK)
            {
                lblWarning.Visible = false;
                return;
            }
            foreach (TreeNode node in treeViewDirs.Nodes)
            {
                node.Checked = false;
            }
            chkSelDeSel.Checked = false;
            bool chkit = Settings.Default.Expandtree;
            chkExpandtree.Checked = false;
            _selectedDirectories.Clear();
            _selectAllChildren = false;
            StreamReader sr = new StreamReader(openFileDialogSelectie.FileName);
            do
            {
                string lin = sr.ReadLine();
                if (string.IsNullOrEmpty(lin)) continue;
                string tempname = Path.Combine(txtSourcePath.Text, lin);
                _selectedDirectories.Add(tempname);
            } while (!sr.EndOfStream);
            sr.Close();
            foreach (string t in _selectedDirectories)
            {
                SetLoadedNodes(treeViewDirs, t);
            }
            _selectAllChildren = true;
            chkExpandtree.Checked = chkit;
            lblWarning.Visible = false;
        }

        #endregion

        #region TabDirectories

        private void SetLoadedNodes(TreeView treeView, string t)
        {
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                CheckLoadedNodes(n, t);
            }
        }

        private void SetLoadedNodes(TreeView treeView)
        {
            TreeNodeCollection nodes = treeView.Nodes;
            bool chkit = Settings.Default.Expandtree;
            chkExpandtree.Checked = false;
            foreach (TreeNode n in nodes)
            {
                CheckAllLoadedNodes(n);
            }
            chkExpandtree.Checked = chkit;
        }

        private void CheckLoadedNodes(TreeNode treeNode, string t)
        {
            if (treeNode.FullPath.Equals(t))
            {
                treeNode.Checked = true;
                if (chkExpandtree.Checked && treeNode.Parent != null)
                {
                    treeNode.Parent.Expand();
                }
            }
            foreach (TreeNode tn in treeNode.Nodes)
            {
                CheckLoadedNodes(tn, t);
            }
            if (chkExpandtree.Checked)
            {
                treeViewDirs.Nodes[0].Expand();
            }
        }

        private void CheckAllLoadedNodes(TreeNode treeNode)
        {
            if (chkExpandtree.Checked && treeNode.Parent != null)
            {
                treeNode.Parent.Expand();
            }
            foreach (TreeNode tn in treeNode.Nodes)
            {
                tn.Expand();
            }
        }

        private void PopulateTreeView(string directoryValue, TreeNode parentNode)
        {
            if (!Directory.Exists(directoryValue))
            {
                Messages.Message("directorybestaatniet");
                return;
            }

            string[] directoryArray = Directory.GetDirectories(directoryValue);
            Array.Sort(directoryArray);

            try
            {
                if (directoryArray.Length != 0)
                {
                    foreach (string directory in directoryArray)
                    {
                        _substringDirectory = directory.Substring(directory.LastIndexOf('\\') + 1,
                            directory.Length - directory.LastIndexOf('\\') - 1);

                        TreeNode myNode = new TreeNode(_substringDirectory);

                        if (directory != parentNode.FullPath + "System Volume Information" &&
                            directory != parentNode.FullPath + "$RECYCLE.BIN"
                            && directory != parentNode.FullPath + "RECYCLER")
                        {
                            parentNode.Nodes.Add(myNode);
                            PopulateTreeView(directory, myNode);
                        }
                    }
                }
                treeViewDirs.Nodes[0].Expand();
            }
            catch (UnauthorizedAccessException)
            {
                // parentNode.Nodes.Add("Access denied");
            }
        }

        private void btnMakeList_Click(object sender, EventArgs e)
        {
            lblWarning.Visible = true;
            WriteIniLocation();
            _path = txtSourcePath.Text;
            treeViewDirs.Nodes.Clear();
            treeViewDirs.Nodes.Add(_path);
            PopulateTreeView(_path, treeViewDirs.Nodes[0]);
            lblWarning.Visible = false;
        }

        private void chkSelDeSel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelDeSel.Checked)
            {
                foreach (TreeNode node in treeViewDirs.Nodes)
                {
                    node.Checked = true;
                }
                chkSelDeSel.Text = _language == "Ned" ? @"Deselecteer alles" : @"Deselect all";
                treeViewDirs.Nodes[0].Expand();
                chkExpandAll.Checked = false;
            }
            else
            {
                foreach (TreeNode node in treeViewDirs.Nodes)
                {
                    node.Checked = false;
                }
                chkSelDeSel.Text = _language == "Ned" ? @"Selecteer alles" : @"Select all";
                treeViewDirs.Nodes[0].Expand();
                chkExpandAll.Checked = true;
            }
            PositonButtons();
        }

        private void chkExpandAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExpandAll.Checked)
            {
                chkExpandAll.Text = _language == "Ned" ? @"Inklappen" : @"Collapse";
                SetLoadedNodes(treeViewDirs);
            }
            else
            {
                chkExpandAll.Text = _language == "Ned" ? @"Uitklappen" : @"Expand";
                foreach (TreeNode tn in treeViewDirs.Nodes)
                {
                    foreach (TreeNode tnn in tn.Nodes)
                    {
                        tnn.Collapse();
                    }
                }
            }
        }

        private void treeViewDirs_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (_selectAllChildren)
            {
                if (e.Node.Nodes.Count != 0)
                    SetSelection(e.Node, e.Node.Checked);
            }
        }

        private void SetSelection(TreeNode node, bool bCheck)
        {
            foreach (TreeNode n in node.Nodes)
            {
                n.Checked = bCheck;
                SetSelection(n, bCheck);
            }
            if (chkExpandtree.Checked)
            {
                if (bCheck)
                {
                    node.Expand();
                }
                else
                {
                    node.Collapse();
                }
            }
        }

        #endregion

        #region TabMP3Player

        private void btnCalc_Click(object sender, EventArgs e)
        {
            MakeSelectedMp3List();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                WindowsMediaPlayer.Ctlcontrols.stop();
            }

            if (MakeSelectedMp3List())
            {
                Messages.Message("geensongs");
                return;
            }

            if (_selectedDirectories.Count == 0)
            {
                Messages.Message("nietsgeselecteerd");
                return;
            }

            //namecutter		
            string playlistName = _selectedDirectories[0];
            string cutstring = string.Empty;
            for (int i = 0; i < playlistName.Length; i++)
            {
                cutstring = playlistName.Substring(i);
                if (!cutstring.Contains(@"\")) break;
            }

            playlistName = cutstring == "\\" ? "Random_Playlist" : cutstring;

            using (StreamWriter writer = new StreamWriter(_setPlayListLocation + "\\" + playlistName + ".m3u"))
                foreach (string f in _selectedMp3List)
                {
                    writer.WriteLine(f);
                }

            WindowsMediaPlayer.Ctlcontrols.stop();
            WindowsMediaPlayer.settings.autoStart = true;

            //			WindowsMediaPlayer.settings.setMode("shuffle",true);
            WindowsMediaPlayer.URL = _setPlayListLocation + "\\" + playlistName + ".m3u";
            if (!chkKeepPlayList.Checked)
            {
                File.Delete(_setPlayListLocation + "\\" + playlistName + ".m3u");
            }
            FillMp3Items();
            timerPlaysong.Start();
        }

        private void btnLoadPlayList_Click(object sender, EventArgs e)
        {
            openFileDialogSelectie.Filter = @"(*.m3u)|*.m3u";
            openFileDialogSelectie.InitialDirectory = _setPlayListLocation;
            if (openFileDialogSelectie.ShowDialog(this) != DialogResult.OK)
                return;
            WindowsMediaPlayer.Ctlcontrols.stop();
            WindowsMediaPlayer.settings.autoStart = true;
            WindowsMediaPlayer.URL = openFileDialogSelectie.FileName;
        }

        private bool MakeSelectedMp3List()
        {
            if (_running)
            {
                tabControl.SelectedIndex = 1;
                return true;
            }

            if (tabControl.SelectedIndex == 1)
            {
                _selectedDirectories.Clear();
                LoadChecked(treeViewDirs.Nodes, _selectedDirectories);

                List<string> tempPlayListFiles = new List<string>();
                _selectedMp3List.Clear();

                foreach (string f in _selectedDirectories)
                {
                    tempPlayListFiles.Clear();
                    foreach (string tempext in _musicTypes.Select(ext => "*." + ext))
                    {
                        try
                        {
                            tempPlayListFiles.AddRange(Directory.GetFiles(f, tempext));
                            _selectedMp3List.AddRange(tempPlayListFiles);
                            tempPlayListFiles.Clear();
                        }
                        catch
                        {
                            Messages.Message("extensieonbruikbaar");
                        }
                    }
                }

                if (chkShuffle.Checked)
                {
                    _selectedMp3List = _selectedMp3List.OrderBy(emp => Guid.NewGuid()).ToList();
                }
            }
            if (_language == "Ned")
            {
                lblAmountSource.Text = @"Aantal geselecteerde MP3's = " + _selectedMp3List.Count;
            }
            else
            {
                lblAmountSource.Text = @"Number of selected MP3's = " + _selectedMp3List.Count;
            }
            return _selectedMp3List.Count == 0;
        }

        #endregion TabMP3Player
    }
}