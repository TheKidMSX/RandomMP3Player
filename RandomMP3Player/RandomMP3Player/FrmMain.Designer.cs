namespace RandomMP3Player
{
	partial class FrmMain
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
			if(disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.folderBrowserMP3 = new System.Windows.Forms.FolderBrowserDialog();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageDirectories = new System.Windows.Forms.TabPage();
			this.btnClear = new System.Windows.Forms.Button();
			this.lblWarning = new System.Windows.Forms.Label();
			this.chkExpandAll = new System.Windows.Forms.CheckBox();
			this.chkSelDeSel = new System.Windows.Forms.CheckBox();
			this.chkExpandtree = new System.Windows.Forms.CheckBox();
			this.GroupFillMP3List = new System.Windows.Forms.GroupBox();
			this.chkAutoVulLijst = new System.Windows.Forms.CheckBox();
			this.btnBrowseLoadSelectieLokatie = new System.Windows.Forms.Button();
			this.btnBrowseSaveSelectieLokatie = new System.Windows.Forms.Button();
			this.lblPlayList = new System.Windows.Forms.Label();
			this.lblMP3Lokatie = new System.Windows.Forms.Label();
			this.btnBrowsePlayList = new System.Windows.Forms.Button();
			this.txtPlayListtarget = new System.Windows.Forms.TextBox();
			this.btnMakeList = new System.Windows.Forms.Button();
			this.btnBrowseSource = new System.Windows.Forms.Button();
			this.txtSourcePath = new System.Windows.Forms.TextBox();
			this.treeViewDirs = new System.Windows.Forms.TreeView();
			this.tabPagePlayer = new System.Windows.Forms.TabPage();
			this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.btnLoadPlayList = new System.Windows.Forms.Button();
			this.chkKeepPlayList = new System.Windows.Forms.CheckBox();
			this.chkShuffle = new System.Windows.Forms.CheckBox();
			this.GroupMP3 = new System.Windows.Forms.GroupBox();
			this.lblGenre = new System.Windows.Forms.Label();
			this.txtGenre = new System.Windows.Forms.TextBox();
			this.btnUpdateMP3Info = new System.Windows.Forms.Button();
			this.lblAlbumTitel = new System.Windows.Forms.Label();
			this.lblArtiest = new System.Windows.Forms.Label();
			this.lblTitel = new System.Windows.Forms.Label();
			this.lblCurrentSong = new System.Windows.Forms.Label();
			this.txtAlbumTitel = new System.Windows.Forms.TextBox();
			this.txtArtiest = new System.Windows.Forms.TextBox();
			this.txtTitel = new System.Windows.Forms.TextBox();
			this.txtCurrentSong = new System.Windows.Forms.TextBox();
			this.btnPlay = new System.Windows.Forms.Button();
			this.GroupCopy = new System.Windows.Forms.GroupBox();
			this.numAmountMP3 = new System.Windows.Forms.NumericUpDown();
			this.btnCalc = new System.Windows.Forms.Button();
			this.lblCopyLokatie = new System.Windows.Forms.Label();
			this.checkDo = new System.Windows.Forms.CheckBox();
			this.txtMonitor = new System.Windows.Forms.TextBox();
			this.lblAmountSource = new System.Windows.Forms.Label();
			this.lblAantal = new System.Windows.Forms.Label();
			this.cmdBoxDrives = new System.Windows.Forms.ComboBox();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.txtVersion = new System.Windows.Forms.TextBox();
			this.txtLicense = new System.Windows.Forms.TextBox();
			this.linkLblEmail = new System.Windows.Forms.LinkLabel();
			this.lblProgrammer = new System.Windows.Forms.Label();
			this.lblQuestion = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.timerMonitor = new System.Windows.Forms.Timer(this.components);
			this.saveFileDialogSelectie = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialogSelectie = new System.Windows.Forms.OpenFileDialog();
			this.timerPlaysong = new System.Windows.Forms.Timer(this.components);
			this.picEng = new System.Windows.Forms.PictureBox();
			this.picNed = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabControl.SuspendLayout();
			this.tabPageDirectories.SuspendLayout();
			this.GroupFillMP3List.SuspendLayout();
			this.tabPagePlayer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
			this.GroupMP3.SuspendLayout();
			this.GroupCopy.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAmountMP3)).BeginInit();
			this.tabPage1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picEng)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picNed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// folderBrowserMP3
			// 
			this.folderBrowserMP3.SelectedPath = "E:\\MP3";
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabPageDirectories);
			this.tabControl.Controls.Add(this.tabPagePlayer);
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(420, 458);
			this.tabControl.TabIndex = 8;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// tabPageDirectories
			// 
			this.tabPageDirectories.Controls.Add(this.btnClear);
			this.tabPageDirectories.Controls.Add(this.lblWarning);
			this.tabPageDirectories.Controls.Add(this.chkExpandAll);
			this.tabPageDirectories.Controls.Add(this.chkSelDeSel);
			this.tabPageDirectories.Controls.Add(this.chkExpandtree);
			this.tabPageDirectories.Controls.Add(this.GroupFillMP3List);
			this.tabPageDirectories.Controls.Add(this.treeViewDirs);
			this.tabPageDirectories.Location = new System.Drawing.Point(4, 22);
			this.tabPageDirectories.Name = "tabPageDirectories";
			this.tabPageDirectories.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDirectories.Size = new System.Drawing.Size(412, 432);
			this.tabPageDirectories.TabIndex = 0;
			this.tabPageDirectories.Text = "Directories";
			this.tabPageDirectories.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnClear.Location = new System.Drawing.Point(92, 400);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(49, 23);
			this.btnClear.TabIndex = 18;
			this.btnClear.Text = "&Wis";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// lblWarning
			// 
			this.lblWarning.AutoSize = true;
			this.lblWarning.BackColor = System.Drawing.Color.Yellow;
			this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWarning.ForeColor = System.Drawing.Color.Red;
			this.lblWarning.Location = new System.Drawing.Point(121, 232);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(183, 17);
			this.lblWarning.TabIndex = 6;
			this.lblWarning.Text = "Een moment geduld aub";
			// 
			// chkExpandAll
			// 
			this.chkExpandAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chkExpandAll.Appearance = System.Windows.Forms.Appearance.Button;
			this.chkExpandAll.AutoSize = true;
			this.chkExpandAll.Location = new System.Drawing.Point(147, 400);
			this.chkExpandAll.Name = "chkExpandAll";
			this.chkExpandAll.Size = new System.Drawing.Size(68, 23);
			this.chkExpandAll.TabIndex = 2;
			this.chkExpandAll.Text = "Uitklappen";
			this.chkExpandAll.UseVisualStyleBackColor = true;
			this.chkExpandAll.CheckedChanged += new System.EventHandler(this.chkExpandAll_CheckedChanged);
			// 
			// chkSelDeSel
			// 
			this.chkSelDeSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chkSelDeSel.Appearance = System.Windows.Forms.Appearance.Button;
			this.chkSelDeSel.AutoSize = true;
			this.chkSelDeSel.Location = new System.Drawing.Point(3, 400);
			this.chkSelDeSel.Name = "chkSelDeSel";
			this.chkSelDeSel.Size = new System.Drawing.Size(86, 23);
			this.chkSelDeSel.TabIndex = 1;
			this.chkSelDeSel.Text = "Selecteer alles";
			this.chkSelDeSel.UseVisualStyleBackColor = true;
			this.chkSelDeSel.CheckedChanged += new System.EventHandler(this.chkSelDeSel_CheckedChanged);
			// 
			// chkExpandtree
			// 
			this.chkExpandtree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chkExpandtree.AutoSize = true;
			this.chkExpandtree.Location = new System.Drawing.Point(238, 406);
			this.chkExpandtree.Name = "chkExpandtree";
			this.chkExpandtree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chkExpandtree.Size = new System.Drawing.Size(168, 17);
			this.chkExpandtree.TabIndex = 3;
			this.chkExpandtree.Text = "Uitvouwen en alles selecteren";
			this.chkExpandtree.UseVisualStyleBackColor = true;
			this.chkExpandtree.CheckedChanged += new System.EventHandler(this.chkExpandtree_CheckedChanged);
			// 
			// GroupFillMP3List
			// 
			this.GroupFillMP3List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupFillMP3List.Controls.Add(this.chkAutoVulLijst);
			this.GroupFillMP3List.Controls.Add(this.btnBrowseLoadSelectieLokatie);
			this.GroupFillMP3List.Controls.Add(this.btnBrowseSaveSelectieLokatie);
			this.GroupFillMP3List.Controls.Add(this.lblPlayList);
			this.GroupFillMP3List.Controls.Add(this.lblMP3Lokatie);
			this.GroupFillMP3List.Controls.Add(this.btnBrowsePlayList);
			this.GroupFillMP3List.Controls.Add(this.txtPlayListtarget);
			this.GroupFillMP3List.Controls.Add(this.btnMakeList);
			this.GroupFillMP3List.Controls.Add(this.btnBrowseSource);
			this.GroupFillMP3List.Controls.Add(this.txtSourcePath);
			this.GroupFillMP3List.Location = new System.Drawing.Point(3, 6);
			this.GroupFillMP3List.Name = "GroupFillMP3List";
			this.GroupFillMP3List.Size = new System.Drawing.Size(406, 114);
			this.GroupFillMP3List.TabIndex = 0;
			this.GroupFillMP3List.TabStop = false;
			this.GroupFillMP3List.Text = "Vul MP3 lijst";
			// 
			// chkAutoVulLijst
			// 
			this.chkAutoVulLijst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkAutoVulLijst.AutoSize = true;
			this.chkAutoVulLijst.Location = new System.Drawing.Point(205, 87);
			this.chkAutoVulLijst.Name = "chkAutoVulLijst";
			this.chkAutoVulLijst.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chkAutoVulLijst.Size = new System.Drawing.Size(195, 17);
			this.chkAutoVulLijst.TabIndex = 7;
			this.chkAutoVulLijst.Text = "Lijst automatisch vullen bij opstarten";
			this.chkAutoVulLijst.UseVisualStyleBackColor = true;
			this.chkAutoVulLijst.CheckedChanged += new System.EventHandler(this.chkAutoVulLijst_CheckedChanged);
			// 
			// btnBrowseLoadSelectieLokatie
			// 
			this.btnBrowseLoadSelectieLokatie.Location = new System.Drawing.Point(6, 83);
			this.btnBrowseLoadSelectieLokatie.Name = "btnBrowseLoadSelectieLokatie";
			this.btnBrowseLoadSelectieLokatie.Size = new System.Drawing.Size(87, 23);
			this.btnBrowseLoadSelectieLokatie.TabIndex = 5;
			this.btnBrowseLoadSelectieLokatie.Text = "Laad selectie";
			this.btnBrowseLoadSelectieLokatie.UseVisualStyleBackColor = true;
			this.btnBrowseLoadSelectieLokatie.Click += new System.EventHandler(this.btnBrowseLoadSelectieLokatie_Click);
			// 
			// btnBrowseSaveSelectieLokatie
			// 
			this.btnBrowseSaveSelectieLokatie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnBrowseSaveSelectieLokatie.Location = new System.Drawing.Point(99, 83);
			this.btnBrowseSaveSelectieLokatie.Name = "btnBrowseSaveSelectieLokatie";
			this.btnBrowseSaveSelectieLokatie.Size = new System.Drawing.Size(94, 23);
			this.btnBrowseSaveSelectieLokatie.TabIndex = 6;
			this.btnBrowseSaveSelectieLokatie.Text = "Bewaar selectie";
			this.btnBrowseSaveSelectieLokatie.UseVisualStyleBackColor = true;
			this.btnBrowseSaveSelectieLokatie.Click += new System.EventHandler(this.btnBrowseSelectieLokatie_Click);
			// 
			// lblPlayList
			// 
			this.lblPlayList.AutoSize = true;
			this.lblPlayList.Location = new System.Drawing.Point(6, 57);
			this.lblPlayList.Name = "lblPlayList";
			this.lblPlayList.Size = new System.Drawing.Size(76, 13);
			this.lblPlayList.TabIndex = 17;
			this.lblPlayList.Text = "Playlist lokatie:";
			// 
			// lblMP3Lokatie
			// 
			this.lblMP3Lokatie.AutoSize = true;
			this.lblMP3Lokatie.Location = new System.Drawing.Point(6, 31);
			this.lblMP3Lokatie.Name = "lblMP3Lokatie";
			this.lblMP3Lokatie.Size = new System.Drawing.Size(66, 13);
			this.lblMP3Lokatie.TabIndex = 16;
			this.lblMP3Lokatie.Text = "MP3 lokatie:";
			// 
			// btnBrowsePlayList
			// 
			this.btnBrowsePlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowsePlayList.Location = new System.Drawing.Point(310, 52);
			this.btnBrowsePlayList.Name = "btnBrowsePlayList";
			this.btnBrowsePlayList.Size = new System.Drawing.Size(30, 23);
			this.btnBrowsePlayList.TabIndex = 4;
			this.btnBrowsePlayList.Text = "...";
			this.btnBrowsePlayList.UseVisualStyleBackColor = true;
			this.btnBrowsePlayList.Click += new System.EventHandler(this.btnBrowsePlayList_Click);
			// 
			// txtPlayListtarget
			// 
			this.txtPlayListtarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPlayListtarget.Location = new System.Drawing.Point(107, 54);
			this.txtPlayListtarget.Name = "txtPlayListtarget";
			this.txtPlayListtarget.Size = new System.Drawing.Size(197, 20);
			this.txtPlayListtarget.TabIndex = 3;
			this.txtPlayListtarget.Text = "C:\\";
			// 
			// btnMakeList
			// 
			this.btnMakeList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMakeList.Location = new System.Drawing.Point(346, 26);
			this.btnMakeList.Name = "btnMakeList";
			this.btnMakeList.Size = new System.Drawing.Size(54, 23);
			this.btnMakeList.TabIndex = 2;
			this.btnMakeList.Text = "Vul lijst";
			this.btnMakeList.UseVisualStyleBackColor = true;
			this.btnMakeList.Click += new System.EventHandler(this.btnMakeList_Click);
			// 
			// btnBrowseSource
			// 
			this.btnBrowseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseSource.Location = new System.Drawing.Point(310, 26);
			this.btnBrowseSource.Name = "btnBrowseSource";
			this.btnBrowseSource.Size = new System.Drawing.Size(30, 23);
			this.btnBrowseSource.TabIndex = 1;
			this.btnBrowseSource.Text = "...";
			this.btnBrowseSource.UseVisualStyleBackColor = true;
			this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtSourcePath
			// 
			this.txtSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSourcePath.Location = new System.Drawing.Point(107, 28);
			this.txtSourcePath.Name = "txtSourcePath";
			this.txtSourcePath.Size = new System.Drawing.Size(197, 20);
			this.txtSourcePath.TabIndex = 0;
			this.txtSourcePath.Text = "E:\\";
			// 
			// treeViewDirs
			// 
			this.treeViewDirs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeViewDirs.CheckBoxes = true;
			this.treeViewDirs.Location = new System.Drawing.Point(3, 126);
			this.treeViewDirs.Name = "treeViewDirs";
			this.treeViewDirs.Size = new System.Drawing.Size(406, 268);
			this.treeViewDirs.TabIndex = 0;
			this.treeViewDirs.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDirs_AfterCheck);
			// 
			// tabPagePlayer
			// 
			this.tabPagePlayer.Controls.Add(this.WindowsMediaPlayer);
			this.tabPagePlayer.Controls.Add(this.btnLoadPlayList);
			this.tabPagePlayer.Controls.Add(this.chkKeepPlayList);
			this.tabPagePlayer.Controls.Add(this.chkShuffle);
			this.tabPagePlayer.Controls.Add(this.GroupMP3);
			this.tabPagePlayer.Controls.Add(this.GroupCopy);
			this.tabPagePlayer.Location = new System.Drawing.Point(4, 22);
			this.tabPagePlayer.Name = "tabPagePlayer";
			this.tabPagePlayer.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePlayer.Size = new System.Drawing.Size(412, 432);
			this.tabPagePlayer.TabIndex = 1;
			this.tabPagePlayer.Text = "MP3 Speler";
			this.tabPagePlayer.UseVisualStyleBackColor = true;
			// 
			// WindowsMediaPlayer
			// 
			this.WindowsMediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WindowsMediaPlayer.Enabled = true;
			this.WindowsMediaPlayer.Location = new System.Drawing.Point(3, 344);
			this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
			this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
			this.WindowsMediaPlayer.Size = new System.Drawing.Size(406, 85);
			this.WindowsMediaPlayer.TabIndex = 9;
			this.WindowsMediaPlayer.DoubleClickEvent += new AxWMPLib._WMPOCXEvents_DoubleClickEventHandler(this.WindowsMediaPlayer_DoubleClickEvent);
			this.WindowsMediaPlayer.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.WindowsMediaPlayer_CurrentItemChange);
			// 
			// btnLoadPlayList
			// 
			this.btnLoadPlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLoadPlayList.Location = new System.Drawing.Point(322, 134);
			this.btnLoadPlayList.Name = "btnLoadPlayList";
			this.btnLoadPlayList.Size = new System.Drawing.Size(81, 23);
			this.btnLoadPlayList.TabIndex = 3;
			this.btnLoadPlayList.Text = "Laad speellijst";
			this.btnLoadPlayList.UseVisualStyleBackColor = true;
			this.btnLoadPlayList.Click += new System.EventHandler(this.btnLoadPlayList_Click);
			// 
			// chkKeepPlayList
			// 
			this.chkKeepPlayList.AutoSize = true;
			this.chkKeepPlayList.Location = new System.Drawing.Point(106, 134);
			this.chkKeepPlayList.Name = "chkKeepPlayList";
			this.chkKeepPlayList.Size = new System.Drawing.Size(97, 17);
			this.chkKeepPlayList.TabIndex = 2;
			this.chkKeepPlayList.Text = "Bewaar Playlist";
			this.chkKeepPlayList.UseVisualStyleBackColor = true;
			this.chkKeepPlayList.CheckedChanged += new System.EventHandler(this.chkKeepPlayList_CheckedChanged);
			// 
			// chkShuffle
			// 
			this.chkShuffle.AutoSize = true;
			this.chkShuffle.Location = new System.Drawing.Point(9, 134);
			this.chkShuffle.Name = "chkShuffle";
			this.chkShuffle.Size = new System.Drawing.Size(91, 17);
			this.chkShuffle.TabIndex = 1;
			this.chkShuffle.Text = "Shuffle MP3\'s";
			this.chkShuffle.UseVisualStyleBackColor = true;
			this.chkShuffle.CheckedChanged += new System.EventHandler(this.chkShuffle_CheckedChanged);
			// 
			// GroupMP3
			// 
			this.GroupMP3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupMP3.Controls.Add(this.lblGenre);
			this.GroupMP3.Controls.Add(this.txtGenre);
			this.GroupMP3.Controls.Add(this.btnUpdateMP3Info);
			this.GroupMP3.Controls.Add(this.lblAlbumTitel);
			this.GroupMP3.Controls.Add(this.lblArtiest);
			this.GroupMP3.Controls.Add(this.lblTitel);
			this.GroupMP3.Controls.Add(this.lblCurrentSong);
			this.GroupMP3.Controls.Add(this.txtAlbumTitel);
			this.GroupMP3.Controls.Add(this.txtArtiest);
			this.GroupMP3.Controls.Add(this.txtTitel);
			this.GroupMP3.Controls.Add(this.txtCurrentSong);
			this.GroupMP3.Controls.Add(this.btnPlay);
			this.GroupMP3.Location = new System.Drawing.Point(3, 157);
			this.GroupMP3.Name = "GroupMP3";
			this.GroupMP3.Size = new System.Drawing.Size(406, 181);
			this.GroupMP3.TabIndex = 4;
			this.GroupMP3.TabStop = false;
			this.GroupMP3.Text = "MP3 Speler";
			// 
			// lblGenre
			// 
			this.lblGenre.AutoSize = true;
			this.lblGenre.Location = new System.Drawing.Point(13, 155);
			this.lblGenre.Name = "lblGenre";
			this.lblGenre.Size = new System.Drawing.Size(39, 13);
			this.lblGenre.TabIndex = 11;
			this.lblGenre.Text = "Genre:";
			// 
			// txtGenre
			// 
			this.txtGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGenre.BackColor = System.Drawing.Color.White;
			this.txtGenre.Location = new System.Drawing.Point(64, 152);
			this.txtGenre.Name = "txtGenre";
			this.txtGenre.Size = new System.Drawing.Size(336, 20);
			this.txtGenre.TabIndex = 8;
			// 
			// btnUpdateMP3Info
			// 
			this.btnUpdateMP3Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdateMP3Info.Location = new System.Drawing.Point(287, 19);
			this.btnUpdateMP3Info.Name = "btnUpdateMP3Info";
			this.btnUpdateMP3Info.Size = new System.Drawing.Size(113, 23);
			this.btnUpdateMP3Info.TabIndex = 3;
			this.btnUpdateMP3Info.Text = "Gegevens bijwerken";
			this.btnUpdateMP3Info.UseVisualStyleBackColor = true;
			this.btnUpdateMP3Info.Click += new System.EventHandler(this.btnTitel_Click);
			// 
			// lblAlbumTitel
			// 
			this.lblAlbumTitel.AutoSize = true;
			this.lblAlbumTitel.Location = new System.Drawing.Point(13, 129);
			this.lblAlbumTitel.Name = "lblAlbumTitel";
			this.lblAlbumTitel.Size = new System.Drawing.Size(39, 13);
			this.lblAlbumTitel.TabIndex = 8;
			this.lblAlbumTitel.Text = "Album:";
			// 
			// lblArtiest
			// 
			this.lblArtiest.AutoSize = true;
			this.lblArtiest.Location = new System.Drawing.Point(13, 100);
			this.lblArtiest.Name = "lblArtiest";
			this.lblArtiest.Size = new System.Drawing.Size(39, 13);
			this.lblArtiest.TabIndex = 7;
			this.lblArtiest.Text = "Artiest:";
			// 
			// lblTitel
			// 
			this.lblTitel.AutoSize = true;
			this.lblTitel.Location = new System.Drawing.Point(13, 77);
			this.lblTitel.Name = "lblTitel";
			this.lblTitel.Size = new System.Drawing.Size(30, 13);
			this.lblTitel.TabIndex = 6;
			this.lblTitel.Text = "Titel:";
			// 
			// lblCurrentSong
			// 
			this.lblCurrentSong.AutoSize = true;
			this.lblCurrentSong.Location = new System.Drawing.Point(13, 53);
			this.lblCurrentSong.Name = "lblCurrentSong";
			this.lblCurrentSong.Size = new System.Drawing.Size(45, 13);
			this.lblCurrentSong.TabIndex = 5;
			this.lblCurrentSong.Text = "Lokatie:";
			// 
			// txtAlbumTitel
			// 
			this.txtAlbumTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAlbumTitel.BackColor = System.Drawing.Color.White;
			this.txtAlbumTitel.Location = new System.Drawing.Point(64, 126);
			this.txtAlbumTitel.Name = "txtAlbumTitel";
			this.txtAlbumTitel.Size = new System.Drawing.Size(336, 20);
			this.txtAlbumTitel.TabIndex = 7;
			// 
			// txtArtiest
			// 
			this.txtArtiest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtArtiest.BackColor = System.Drawing.Color.White;
			this.txtArtiest.Location = new System.Drawing.Point(64, 100);
			this.txtArtiest.Name = "txtArtiest";
			this.txtArtiest.Size = new System.Drawing.Size(336, 20);
			this.txtArtiest.TabIndex = 6;
			// 
			// txtTitel
			// 
			this.txtTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTitel.BackColor = System.Drawing.Color.White;
			this.txtTitel.Location = new System.Drawing.Point(64, 74);
			this.txtTitel.Name = "txtTitel";
			this.txtTitel.Size = new System.Drawing.Size(336, 20);
			this.txtTitel.TabIndex = 5;
			// 
			// txtCurrentSong
			// 
			this.txtCurrentSong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCurrentSong.BackColor = System.Drawing.Color.White;
			this.txtCurrentSong.Location = new System.Drawing.Point(64, 48);
			this.txtCurrentSong.Name = "txtCurrentSong";
			this.txtCurrentSong.Size = new System.Drawing.Size(336, 20);
			this.txtCurrentSong.TabIndex = 4;
			// 
			// btnPlay
			// 
			this.btnPlay.Location = new System.Drawing.Point(6, 19);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(75, 23);
			this.btnPlay.TabIndex = 2;
			this.btnPlay.Text = "Afspelen";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// GroupCopy
			// 
			this.GroupCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupCopy.Controls.Add(this.numAmountMP3);
			this.GroupCopy.Controls.Add(this.btnCalc);
			this.GroupCopy.Controls.Add(this.lblCopyLokatie);
			this.GroupCopy.Controls.Add(this.checkDo);
			this.GroupCopy.Controls.Add(this.txtMonitor);
			this.GroupCopy.Controls.Add(this.lblAmountSource);
			this.GroupCopy.Controls.Add(this.lblAantal);
			this.GroupCopy.Controls.Add(this.cmdBoxDrives);
			this.GroupCopy.Location = new System.Drawing.Point(3, 6);
			this.GroupCopy.Name = "GroupCopy";
			this.GroupCopy.Size = new System.Drawing.Size(406, 122);
			this.GroupCopy.TabIndex = 0;
			this.GroupCopy.TabStop = false;
			this.GroupCopy.Text = "Kopieer selectie";
			// 
			// numAmountMP3
			// 
			this.numAmountMP3.Location = new System.Drawing.Point(109, 56);
			this.numAmountMP3.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numAmountMP3.Name = "numAmountMP3";
			this.numAmountMP3.Size = new System.Drawing.Size(78, 20);
			this.numAmountMP3.TabIndex = 2;
			this.numAmountMP3.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// btnCalc
			// 
			this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCalc.Location = new System.Drawing.Point(287, 70);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(113, 23);
			this.btnCalc.TabIndex = 3;
			this.btnCalc.Text = "Bereken Selectie";
			this.btnCalc.UseVisualStyleBackColor = true;
			this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
			// 
			// lblCopyLokatie
			// 
			this.lblCopyLokatie.AutoSize = true;
			this.lblCopyLokatie.Location = new System.Drawing.Point(6, 31);
			this.lblCopyLokatie.Name = "lblCopyLokatie";
			this.lblCopyLokatie.Size = new System.Drawing.Size(97, 13);
			this.lblCopyLokatie.TabIndex = 21;
			this.lblCopyLokatie.Text = "Kopieer naar schijf:";
			// 
			// checkDo
			// 
			this.checkDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkDo.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkDo.AutoSize = true;
			this.checkDo.Location = new System.Drawing.Point(306, 26);
			this.checkDo.Name = "checkDo";
			this.checkDo.Size = new System.Drawing.Size(94, 23);
			this.checkDo.TabIndex = 1;
			this.checkDo.Text = "Kopieer Selectie";
			this.checkDo.UseVisualStyleBackColor = true;
			this.checkDo.CheckedChanged += new System.EventHandler(this.checkDo_CheckedChanged);
			// 
			// txtMonitor
			// 
			this.txtMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMonitor.Location = new System.Drawing.Point(6, 96);
			this.txtMonitor.Name = "txtMonitor";
			this.txtMonitor.ReadOnly = true;
			this.txtMonitor.Size = new System.Drawing.Size(394, 20);
			this.txtMonitor.TabIndex = 19;
			this.txtMonitor.TabStop = false;
			// 
			// lblAmountSource
			// 
			this.lblAmountSource.AutoSize = true;
			this.lblAmountSource.Location = new System.Drawing.Point(6, 80);
			this.lblAmountSource.Name = "lblAmountSource";
			this.lblAmountSource.Size = new System.Drawing.Size(142, 13);
			this.lblAmountSource.TabIndex = 18;
			this.lblAmountSource.Text = "Aantal geselecteerde MP3\'s:";
			// 
			// lblAantal
			// 
			this.lblAantal.AutoSize = true;
			this.lblAantal.Location = new System.Drawing.Point(6, 58);
			this.lblAantal.Name = "lblAantal";
			this.lblAantal.Size = new System.Drawing.Size(72, 13);
			this.lblAantal.TabIndex = 17;
			this.lblAantal.Text = "Aantal MP3\'s:";
			// 
			// cmdBoxDrives
			// 
			this.cmdBoxDrives.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdBoxDrives.FormattingEnabled = true;
			this.cmdBoxDrives.Location = new System.Drawing.Point(109, 28);
			this.cmdBoxDrives.Name = "cmdBoxDrives";
			this.cmdBoxDrives.Size = new System.Drawing.Size(191, 21);
			this.cmdBoxDrives.TabIndex = 0;
			this.cmdBoxDrives.Click += new System.EventHandler(this.cmdBoxDrives_Click);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer1);
			this.tabPage1.Controls.Add(this.linkLblEmail);
			this.tabPage1.Controls.Add(this.lblProgrammer);
			this.tabPage1.Controls.Add(this.lblQuestion);
			this.tabPage1.Controls.Add(this.lblVersion);
			this.tabPage1.Controls.Add(this.picEng);
			this.tabPage1.Controls.Add(this.picNed);
			this.tabPage1.Controls.Add(this.pictureBox3);
			this.tabPage1.Controls.Add(this.pictureBox2);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(412, 432);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Over";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(6, 44);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.txtVersion);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.txtLicense);
			this.splitContainer1.Size = new System.Drawing.Size(400, 314);
			this.splitContainer1.SplitterDistance = 156;
			this.splitContainer1.TabIndex = 25;
			// 
			// txtVersion
			// 
			this.txtVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtVersion.HideSelection = false;
			this.txtVersion.Location = new System.Drawing.Point(3, 3);
			this.txtVersion.Margin = new System.Windows.Forms.Padding(10, 1, 10, 1);
			this.txtVersion.Multiline = true;
			this.txtVersion.Name = "txtVersion";
			this.txtVersion.ReadOnly = true;
			this.txtVersion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtVersion.Size = new System.Drawing.Size(394, 150);
			this.txtVersion.TabIndex = 24;
			// 
			// txtLicense
			// 
			this.txtLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLicense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLicense.Location = new System.Drawing.Point(3, 1);
			this.txtLicense.Margin = new System.Windows.Forms.Padding(10, 1, 10, 1);
			this.txtLicense.Multiline = true;
			this.txtLicense.Name = "txtLicense";
			this.txtLicense.ReadOnly = true;
			this.txtLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtLicense.Size = new System.Drawing.Size(394, 150);
			this.txtLicense.TabIndex = 13;
			// 
			// linkLblEmail
			// 
			this.linkLblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLblEmail.AutoSize = true;
			this.linkLblEmail.BackColor = System.Drawing.Color.Transparent;
			this.linkLblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLblEmail.LinkColor = System.Drawing.Color.DarkCyan;
			this.linkLblEmail.Location = new System.Drawing.Point(68, 387);
			this.linkLblEmail.Name = "linkLblEmail";
			this.linkLblEmail.Size = new System.Drawing.Size(120, 13);
			this.linkLblEmail.TabIndex = 19;
			this.linkLblEmail.TabStop = true;
			this.linkLblEmail.Text = "info@TheKidMSX.nl";
			this.linkLblEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblEmail_LinkClicked);
			// 
			// lblProgrammer
			// 
			this.lblProgrammer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblProgrammer.AutoSize = true;
			this.lblProgrammer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProgrammer.Location = new System.Drawing.Point(68, 409);
			this.lblProgrammer.Name = "lblProgrammer";
			this.lblProgrammer.Size = new System.Drawing.Size(73, 13);
			this.lblProgrammer.TabIndex = 17;
			this.lblProgrammer.Text = "Programmer";
			// 
			// lblQuestion
			// 
			this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblQuestion.AutoSize = true;
			this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuestion.Location = new System.Drawing.Point(68, 364);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(245, 13);
			this.lblQuestion.TabIndex = 16;
			this.lblQuestion.Text = "Voor opmerkingen of vragen e-mail mij op:";
			// 
			// lblVersion
			// 
			this.lblVersion.AutoSize = true;
			this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersion.Location = new System.Drawing.Point(44, 14);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(203, 17);
			this.lblVersion.TabIndex = 15;
			this.lblVersion.Text = "Random MP3 Player versie";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(14, 25);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(30, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(50, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(146, 20);
			this.textBox1.TabIndex = 15;
			this.textBox1.Text = "F:";
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(202, 26);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 23);
			this.button2.TabIndex = 14;
			this.button2.Text = "Kopieer Selectie";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// timerMonitor
			// 
			this.timerMonitor.Interval = 60;
			this.timerMonitor.Tick += new System.EventHandler(this.timerMonitor_Tick);
			// 
			// saveFileDialogSelectie
			// 
			this.saveFileDialogSelectie.DefaultExt = "sel";
			// 
			// openFileDialogSelectie
			// 
			this.openFileDialogSelectie.DefaultExt = "sel";
			// 
			// timerPlaysong
			// 
			this.timerPlaysong.Interval = 60;
			this.timerPlaysong.Tick += new System.EventHandler(this.timerPlaysong_Tick);
			// 
			// picEng
			// 
			this.picEng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picEng.Image = global::RandomMP3Player.Properties.Resources.EnglishFlag;
			this.picEng.Location = new System.Drawing.Point(285, 383);
			this.picEng.Name = "picEng";
			this.picEng.Size = new System.Drawing.Size(25, 17);
			this.picEng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picEng.TabIndex = 23;
			this.picEng.TabStop = false;
			this.picEng.Click += new System.EventHandler(this.picEng_Click);
			// 
			// picNed
			// 
			this.picNed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picNed.Image = global::RandomMP3Player.Properties.Resources.dutchFlag;
			this.picNed.Location = new System.Drawing.Point(285, 405);
			this.picNed.Name = "picNed";
			this.picNed.Size = new System.Drawing.Size(25, 17);
			this.picNed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picNed.TabIndex = 22;
			this.picNed.TabStop = false;
			this.picNed.Click += new System.EventHandler(this.picNed_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.Image = global::RandomMP3Player.Properties.Resources.DSlogo;
			this.pictureBox3.Location = new System.Drawing.Point(316, 369);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(90, 53);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 21;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox2.Image = global::RandomMP3Player.Properties.Resources.thekidmsx;
			this.pictureBox2.Location = new System.Drawing.Point(6, 364);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(56, 62);
			this.pictureBox2.TabIndex = 18;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::RandomMP3Player.Properties.Resources.RandomMp3;
			this.pictureBox1.Location = new System.Drawing.Point(6, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 482);
			this.Controls.Add(this.tabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(460, 520);
			this.Name = "FrmMain";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Random MP3 Player and Copier";
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.tabControl.ResumeLayout(false);
			this.tabPageDirectories.ResumeLayout(false);
			this.tabPageDirectories.PerformLayout();
			this.GroupFillMP3List.ResumeLayout(false);
			this.GroupFillMP3List.PerformLayout();
			this.tabPagePlayer.ResumeLayout(false);
			this.tabPagePlayer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
			this.GroupMP3.ResumeLayout(false);
			this.GroupMP3.PerformLayout();
			this.GroupCopy.ResumeLayout(false);
			this.GroupCopy.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAmountMP3)).EndInit();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picEng)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picNed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folderBrowserMP3;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageDirectories;
		private System.Windows.Forms.Button btnBrowseSource;
		private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.TreeView treeViewDirs;
		private System.Windows.Forms.Button btnMakeList;
		private System.Windows.Forms.TabPage tabPagePlayer;
		private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.GroupBox GroupMP3;
		private System.Windows.Forms.GroupBox GroupCopy;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox GroupFillMP3List;
		private System.Windows.Forms.ComboBox cmdBoxDrives;
        private System.Windows.Forms.Label lblAantal;
		private System.Windows.Forms.Label lblAmountSource;
		private System.Windows.Forms.TextBox txtMonitor;
		private System.Windows.Forms.Timer timerMonitor;
		private System.Windows.Forms.CheckBox checkDo;
		private System.Windows.Forms.Button btnBrowsePlayList;
		private System.Windows.Forms.TextBox txtPlayListtarget;
		private System.Windows.Forms.Label lblPlayList;
		private System.Windows.Forms.Label lblMP3Lokatie;
		private System.Windows.Forms.Label lblCopyLokatie;
		private System.Windows.Forms.Button btnBrowseSaveSelectieLokatie;
		private System.Windows.Forms.SaveFileDialog saveFileDialogSelectie;
		private System.Windows.Forms.Button btnBrowseLoadSelectieLokatie;
		private System.Windows.Forms.OpenFileDialog openFileDialogSelectie;
		private System.Windows.Forms.CheckBox chkShuffle;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.CheckBox chkKeepPlayList;
		private System.Windows.Forms.Button btnLoadPlayList;
		private System.Windows.Forms.TextBox txtCurrentSong;
		private System.Windows.Forms.TextBox txtAlbumTitel;
		private System.Windows.Forms.TextBox txtArtiest;
		private System.Windows.Forms.TextBox txtTitel;
		private System.Windows.Forms.Label lblTitel;
		private System.Windows.Forms.Label lblCurrentSong;
		private System.Windows.Forms.Label lblAlbumTitel;
		private System.Windows.Forms.Label lblArtiest;
		private System.Windows.Forms.Button btnUpdateMP3Info;
		private System.Windows.Forms.Label lblGenre;
		private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Timer timerPlaysong;
		private System.Windows.Forms.CheckBox chkExpandtree;
        private System.Windows.Forms.CheckBox chkAutoVulLijst;
		  private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.LinkLabel linkLblEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblProgrammer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picNed;
        private System.Windows.Forms.PictureBox picEng;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown numAmountMP3;
        private System.Windows.Forms.CheckBox chkSelDeSel;
        private System.Windows.Forms.CheckBox chkExpandAll;
        private System.Windows.Forms.Label lblWarning;
		  private System.Windows.Forms.Button btnClear;
	}
}

