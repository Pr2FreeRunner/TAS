namespace PR2_Speedrun_Tools
{
    // Token: 0x0200000B RID: 11
    public partial class Form1 : global::System.Windows.Forms.Form
    {
        // Token: 0x060000F5 RID: 245 RVA: 0x0000CE2F File Offset: 0x0000B02F
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060000F6 RID: 246 RVA: 0x0000CE50 File Offset: 0x0000B050
        private void InitializeComponent()
        {
            this.components = new global::System.ComponentModel.Container();
            global::System.Windows.Forms.ListViewItem listViewItem = new global::System.Windows.Forms.ListViewItem("", 0);
            global::System.Windows.Forms.ListViewItem listViewItem2 = new global::System.Windows.Forms.ListViewItem("", 1);
            global::System.Windows.Forms.ListViewItem listViewItem3 = new global::System.Windows.Forms.ListViewItem("", 2);
            global::System.Windows.Forms.ListViewItem listViewItem4 = new global::System.Windows.Forms.ListViewItem("", 3);
            global::System.Windows.Forms.ListViewItem listViewItem5 = new global::System.Windows.Forms.ListViewItem("", 4);
            global::System.Windows.Forms.ListViewItem listViewItem6 = new global::System.Windows.Forms.ListViewItem("", 5);
            global::System.Windows.Forms.ListViewItem listViewItem7 = new global::System.Windows.Forms.ListViewItem("", 6);
            global::System.Windows.Forms.ListViewItem listViewItem8 = new global::System.Windows.Forms.ListViewItem("", 7);
            global::System.Windows.Forms.ListViewItem listViewItem9 = new global::System.Windows.Forms.ListViewItem("", 8);
            global::System.Windows.Forms.ListViewItem listViewItem10 = new global::System.Windows.Forms.ListViewItem("", 9);
            global::System.Windows.Forms.ListViewItem listViewItem11 = new global::System.Windows.Forms.ListViewItem("", 10);
            global::System.Windows.Forms.ListViewItem listViewItem12 = new global::System.Windows.Forms.ListViewItem("", 11);
            global::System.Windows.Forms.ListViewItem listViewItem13 = new global::System.Windows.Forms.ListViewItem("", 12);
            global::System.Windows.Forms.ListViewItem listViewItem14 = new global::System.Windows.Forms.ListViewItem("", 13);
            global::System.Windows.Forms.ListViewItem listViewItem15 = new global::System.Windows.Forms.ListViewItem("", 14);
            global::System.Windows.Forms.ListViewItem listViewItem16 = new global::System.Windows.Forms.ListViewItem("", 15);
            global::System.Windows.Forms.ListViewItem listViewItem17 = new global::System.Windows.Forms.ListViewItem("", 16);
            global::System.Windows.Forms.ListViewItem listViewItem18 = new global::System.Windows.Forms.ListViewItem("", 17);
            global::System.Windows.Forms.ListViewItem listViewItem19 = new global::System.Windows.Forms.ListViewItem("", 18);
            global::System.Windows.Forms.ListViewItem listViewItem20 = new global::System.Windows.Forms.ListViewItem("", 19);
            global::System.Windows.Forms.ListViewItem listViewItem21 = new global::System.Windows.Forms.ListViewItem("", 20);
            global::System.Windows.Forms.ListViewItem listViewItem22 = new global::System.Windows.Forms.ListViewItem("", 21);
            global::System.Windows.Forms.ListViewItem listViewItem23 = new global::System.Windows.Forms.ListViewItem("", 22);
            global::System.Windows.Forms.ListViewItem listViewItem24 = new global::System.Windows.Forms.ListViewItem("", 23);
            global::System.Windows.Forms.ListViewItem listViewItem25 = new global::System.Windows.Forms.ListViewItem("", 24);
            global::System.Windows.Forms.ListViewItem listViewItem26 = new global::System.Windows.Forms.ListViewItem("", 25);
            global::System.Windows.Forms.ListViewItem listViewItem27 = new global::System.Windows.Forms.ListViewItem("", 26);
            global::System.Windows.Forms.ListViewItem listViewItem28 = new global::System.Windows.Forms.ListViewItem("", 27);
            global::System.Windows.Forms.ListViewItem listViewItem29 = new global::System.Windows.Forms.ListViewItem("", 28);
            global::System.Windows.Forms.ListViewItem listViewItem30 = new global::System.Windows.Forms.ListViewItem("", 29);
            global::System.Windows.Forms.ListViewItem listViewItem31 = new global::System.Windows.Forms.ListViewItem("", 30);
            global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::PR2_Speedrun_Tools.Form1));
            this.pnlGame = new global::System.Windows.Forms.Panel();
            this.tabControl1 = new global::System.Windows.Forms.TabControl();
            this.tabLevels = new global::System.Windows.Forms.TabPage();
            this.tokenBtn = new global::System.Windows.Forms.Button();
            this.loadLevelBtn = new global::System.Windows.Forms.Button();
            this.noteBox = new global::System.Windows.Forms.RichTextBox();
            this.label13 = new global::System.Windows.Forms.Label();
            this.hasPassLbl = new global::System.Windows.Forms.Label();
            this.levelIDLbl = new global::System.Windows.Forms.Label();
            this.minRankLbl = new global::System.Windows.Forms.Label();
            this.ratingLbl = new global::System.Windows.Forms.Label();
            this.typeLbl = new global::System.Windows.Forms.Label();
            this.playsLbl = new global::System.Windows.Forms.Label();
            this.versionLbl = new global::System.Windows.Forms.Label();
            this.userLbl = new global::System.Windows.Forms.Label();
            this.ascBox = new global::System.Windows.Forms.CheckBox();
            this.orderBox = new global::System.Windows.Forms.ComboBox();
            this.modeBox = new global::System.Windows.Forms.ComboBox();
            this.pageNum = new global::System.Windows.Forms.NumericUpDown();
            this.label12 = new global::System.Windows.Forms.Label();
            this.label11 = new global::System.Windows.Forms.Label();
            this.searchBox = new global::System.Windows.Forms.TextBox();
            this.myLevelsButton = new global::System.Windows.Forms.Button();
            this.searchBtn = new global::System.Windows.Forms.Button();
            this.levelsList = new global::System.Windows.Forms.ListBox();
            this.btnLoadLevel = new global::System.Windows.Forms.Button();
            this.tabLevelData = new global::System.Windows.Forms.TabPage();
            this.chkLive = new global::System.Windows.Forms.CheckBox();
            this.uploadBtn = new global::System.Windows.Forms.Button();
            this.cmbGameMode = new global::System.Windows.Forms.ComboBox();
            this.label7 = new global::System.Windows.Forms.Label();
            this.cmbMusic = new global::System.Windows.Forms.ComboBox();
            this.label5 = new global::System.Windows.Forms.Label();
            this.groupBox1 = new global::System.Windows.Forms.GroupBox();
            this.linkLabelToggleItems = new global::System.Windows.Forms.LinkLabel();
            this.chkMine = new global::System.Windows.Forms.CheckBox();
            this.chkTeleport = new global::System.Windows.Forms.CheckBox();
            this.chkJetPack = new global::System.Windows.Forms.CheckBox();
            this.chkSword = new global::System.Windows.Forms.CheckBox();
            this.chkFreezeRay = new global::System.Windows.Forms.CheckBox();
            this.chkSpeedy = new global::System.Windows.Forms.CheckBox();
            this.chkSuperJump = new global::System.Windows.Forms.CheckBox();
            this.chkLightning = new global::System.Windows.Forms.CheckBox();
            this.chkLaserGun = new global::System.Windows.Forms.CheckBox();
            this.numCowboyChance = new global::System.Windows.Forms.NumericUpDown();
            this.label8 = new global::System.Windows.Forms.Label();
            this.numMinLevel = new global::System.Windows.Forms.NumericUpDown();
            this.label6 = new global::System.Windows.Forms.Label();
            this.numGravity = new global::System.Windows.Forms.NumericUpDown();
            this.label4 = new global::System.Windows.Forms.Label();
            this.txtCredits = new global::System.Windows.Forms.RichTextBox();
            this.label3 = new global::System.Windows.Forms.Label();
            this.txtNote = new global::System.Windows.Forms.RichTextBox();
            this.txtTitle = new global::System.Windows.Forms.TextBox();
            this.label2 = new global::System.Windows.Forms.Label();
            this.label1 = new global::System.Windows.Forms.Label();
            this.tabGameControls = new global::System.Windows.Forms.TabPage();
            this.buttonLoadRace = new global::System.Windows.Forms.Button();
            this.tournamentBth = new global::System.Windows.Forms.Label();
            this.lblRecStatus = new global::System.Windows.Forms.Label();
            this.lblPlayers = new global::System.Windows.Forms.Label();
            this.btnAddPlayer = new global::System.Windows.Forms.Button();
            this.label10 = new global::System.Windows.Forms.Label();
            this.numSelectedPlayer = new global::System.Windows.Forms.NumericUpDown();
            this.btnPartial = new global::System.Windows.Forms.Button();
            this.lblTotalStats = new global::System.Windows.Forms.Label();
            this.chkCopy = new global::System.Windows.Forms.CheckBox();
            this.chkx10 = new global::System.Windows.Forms.CheckBox();
            this.btnInsertFrame = new global::System.Windows.Forms.Button();
            this.btnDeleteFrame = new global::System.Windows.Forms.Button();
            this.btnCurrentFrame = new global::System.Windows.Forms.Button();
            this.btnSetRecSS = new global::System.Windows.Forms.Button();
            this.numJump = new global::System.Windows.Forms.NumericUpDown();
            this.numAccel = new global::System.Windows.Forms.NumericUpDown();
            this.numSpeed = new global::System.Windows.Forms.NumericUpDown();
            this.btnSetStats = new global::System.Windows.Forms.Button();
            this.btnPlayRec = new global::System.Windows.Forms.Button();
            this.btnSaveRec = new global::System.Windows.Forms.Button();
            this.btnLoadRec = new global::System.Windows.Forms.Button();
            this.chkLoadSS = new global::System.Windows.Forms.CheckBox();
            this.lblFrames = new global::System.Windows.Forms.Label();
            this.numNextLast = new global::System.Windows.Forms.NumericUpDown();
            this.rdoNext = new global::System.Windows.Forms.RadioButton();
            this.rdoLast = new global::System.Windows.Forms.RadioButton();
            this.btnSetNextTo = new global::System.Windows.Forms.Button();
            this.lblSS = new global::System.Windows.Forms.Label();
            this.numFrame = new global::System.Windows.Forms.NumericUpDown();
            this.label9 = new global::System.Windows.Forms.Label();
            this.chkSpace = new global::System.Windows.Forms.CheckBox();
            this.chkRight = new global::System.Windows.Forms.CheckBox();
            this.chkLeft = new global::System.Windows.Forms.CheckBox();
            this.chkDown = new global::System.Windows.Forms.CheckBox();
            this.chkUp = new global::System.Windows.Forms.CheckBox();
            this.btnPlay = new global::System.Windows.Forms.Button();
            this.tabLE = new global::System.Windows.Forms.TabPage();
            this.buttonSaveToFile = new global::System.Windows.Forms.Button();
            this.listViewBlocks = new global::System.Windows.Forms.ListView();
            this.colHdrBlock = new global::System.Windows.Forms.ColumnHeader();
            this.imageListBlocks = new global::System.Windows.Forms.ImageList(this.components);
            this.tabSimple = new global::System.Windows.Forms.TabPage();
            this.button2 = new global::System.Windows.Forms.Button();
            this.label24 = new global::System.Windows.Forms.Label();
            this.label23 = new global::System.Windows.Forms.Label();
            this.label22 = new global::System.Windows.Forms.Label();
            this.label20 = new global::System.Windows.Forms.Label();
            this.label19 = new global::System.Windows.Forms.Label();
            this.label18 = new global::System.Windows.Forms.Label();
            this.label17 = new global::System.Windows.Forms.Label();
            this.label16 = new global::System.Windows.Forms.Label();
            this.label15 = new global::System.Windows.Forms.Label();
            this.numJump2 = new global::System.Windows.Forms.NumericUpDown();
            this.numAccel2 = new global::System.Windows.Forms.NumericUpDown();
            this.numSpeed2 = new global::System.Windows.Forms.NumericUpDown();
            this.btnSetStats2 = new global::System.Windows.Forms.Button();
            this.lblSS2 = new global::System.Windows.Forms.Label();
            this.btnRetart = new global::System.Windows.Forms.Button();
            this.txtNoSelect = new global::System.Windows.Forms.TextBox();
            this.lblPause = new global::System.Windows.Forms.Label();
            this.lblVelX = new global::System.Windows.Forms.Label();
            this.lblVelY = new global::System.Windows.Forms.Label();
            this.lblPosX = new global::System.Windows.Forms.Label();
            this.lblPosY = new global::System.Windows.Forms.Label();
            this.lblTVel = new global::System.Windows.Forms.Label();
            this.lblSJump = new global::System.Windows.Forms.Label();
            this.lblHurt = new global::System.Windows.Forms.Label();
            this.lblMode = new global::System.Windows.Forms.Label();
            this.button1 = new global::System.Windows.Forms.Button();
            this.chkProp = new global::System.Windows.Forms.CheckBox();
            this.chkCrown = new global::System.Windows.Forms.CheckBox();
            this.chkCowboy = new global::System.Windows.Forms.CheckBox();
            this.chkSanta = new global::System.Windows.Forms.CheckBox();
            this.chkTop = new global::System.Windows.Forms.CheckBox();
            this.chkJump = new global::System.Windows.Forms.CheckBox();
            this.label14 = new global::System.Windows.Forms.Label();
            this.fpsNum = new global::System.Windows.Forms.NumericUpDown();
            this.ghostBtn = new global::System.Windows.Forms.Button();
            this.removeGhostsBtn = new global::System.Windows.Forms.Button();
            this.currentFPSLbl = new global::System.Windows.Forms.Label();
            this.chkJigg = new global::System.Windows.Forms.CheckBox();
            this.chkArti = new global::System.Windows.Forms.CheckBox();
            this.lblState = new global::System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabLevels.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)this.pageNum).BeginInit();
            this.tabLevelData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)this.numCowboyChance).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numMinLevel).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numGravity).BeginInit();
            this.tabGameControls.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)this.numSelectedPlayer).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numJump).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numAccel).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numSpeed).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numNextLast).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numFrame).BeginInit();
            this.tabLE.SuspendLayout();
            this.tabSimple.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)this.numJump2).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numAccel2).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numSpeed2).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.fpsNum).BeginInit();
            base.SuspendLayout();
            this.pnlGame.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
            this.pnlGame.BackColor = global::System.Drawing.Color.Black;
            this.pnlGame.Location = new global::System.Drawing.Point(0, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new global::System.Drawing.Size(705, 465);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.pnlGame_MouseDown);
            this.pnlGame.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.pnlGame_MouseMove);
            this.pnlGame.Resize += new global::System.EventHandler(this.pnlGame_Resize);
            this.tabControl1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
            this.tabControl1.Controls.Add(this.tabLevels);
            this.tabControl1.Controls.Add(this.tabLevelData);
            this.tabControl1.Controls.Add(this.tabGameControls);
            this.tabControl1.Controls.Add(this.tabLE);
            this.tabControl1.Controls.Add(this.tabSimple);
            this.tabControl1.Location = new global::System.Drawing.Point(705, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new global::System.Drawing.Size(200, 502);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TabIndexChanged += new global::System.EventHandler(this.Random_Events);
            this.tabLevels.Controls.Add(this.tokenBtn);
            this.tabLevels.Controls.Add(this.loadLevelBtn);
            this.tabLevels.Controls.Add(this.noteBox);
            this.tabLevels.Controls.Add(this.label13);
            this.tabLevels.Controls.Add(this.hasPassLbl);
            this.tabLevels.Controls.Add(this.levelIDLbl);
            this.tabLevels.Controls.Add(this.minRankLbl);
            this.tabLevels.Controls.Add(this.ratingLbl);
            this.tabLevels.Controls.Add(this.typeLbl);
            this.tabLevels.Controls.Add(this.playsLbl);
            this.tabLevels.Controls.Add(this.versionLbl);
            this.tabLevels.Controls.Add(this.userLbl);
            this.tabLevels.Controls.Add(this.ascBox);
            this.tabLevels.Controls.Add(this.orderBox);
            this.tabLevels.Controls.Add(this.modeBox);
            this.tabLevels.Controls.Add(this.pageNum);
            this.tabLevels.Controls.Add(this.label12);
            this.tabLevels.Controls.Add(this.label11);
            this.tabLevels.Controls.Add(this.searchBox);
            this.tabLevels.Controls.Add(this.myLevelsButton);
            this.tabLevels.Controls.Add(this.searchBtn);
            this.tabLevels.Controls.Add(this.levelsList);
            this.tabLevels.Controls.Add(this.btnLoadLevel);
            this.tabLevels.Location = new global::System.Drawing.Point(4, 22);
            this.tabLevels.Name = "tabLevels";
            this.tabLevels.Padding = new global::System.Windows.Forms.Padding(3);
            this.tabLevels.Size = new global::System.Drawing.Size(192, 476);
            this.tabLevels.TabIndex = 0;
            this.tabLevels.Text = "Levels";
            this.tabLevels.UseVisualStyleBackColor = true;
            this.tokenBtn.Location = new global::System.Drawing.Point(87, 447);
            this.tokenBtn.Name = "tokenBtn";
            this.tokenBtn.Size = new global::System.Drawing.Size(96, 23);
            this.tokenBtn.TabIndex = 12;
            this.tokenBtn.Text = "Set Login Token";
            this.tokenBtn.UseVisualStyleBackColor = true;
            this.tokenBtn.Click += new global::System.EventHandler(this.tokenBtn_Click);
            this.loadLevelBtn.Location = new global::System.Drawing.Point(6, 447);
            this.loadLevelBtn.Name = "loadLevelBtn";
            this.loadLevelBtn.Size = new global::System.Drawing.Size(75, 23);
            this.loadLevelBtn.TabIndex = 12;
            this.loadLevelBtn.Text = "Load Level";
            this.loadLevelBtn.UseVisualStyleBackColor = true;
            this.loadLevelBtn.Click += new global::System.EventHandler(this.loadLevelBtn_Click);
            this.noteBox.Location = new global::System.Drawing.Point(40, 277);
            this.noteBox.Name = "noteBox";
            this.noteBox.ReadOnly = true;
            this.noteBox.Size = new global::System.Drawing.Size(143, 63);
            this.noteBox.TabIndex = 11;
            this.noteBox.Text = "";
            this.label13.AutoSize = true;
            this.label13.Location = new global::System.Drawing.Point(7, 278);
            this.label13.Name = "label13";
            this.label13.Size = new global::System.Drawing.Size(33, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Note:";
            this.hasPassLbl.AutoSize = true;
            this.hasPassLbl.Location = new global::System.Drawing.Point(28, 427);
            this.hasPassLbl.Name = "hasPassLbl";
            this.hasPassLbl.Size = new global::System.Drawing.Size(132, 13);
            this.hasPassLbl.TabIndex = 9;
            this.hasPassLbl.Text = "This level has a password.";
            this.hasPassLbl.Visible = false;
            this.levelIDLbl.AutoSize = true;
            this.levelIDLbl.Location = new global::System.Drawing.Point(7, 413);
            this.levelIDLbl.Name = "levelIDLbl";
            this.levelIDLbl.Size = new global::System.Drawing.Size(50, 13);
            this.levelIDLbl.TabIndex = 9;
            this.levelIDLbl.Text = "Level ID:";
            this.minRankLbl.AutoSize = true;
            this.minRankLbl.Location = new global::System.Drawing.Point(7, 399);
            this.minRankLbl.Name = "minRankLbl";
            this.minRankLbl.Size = new global::System.Drawing.Size(56, 13);
            this.minRankLbl.TabIndex = 9;
            this.minRankLbl.Text = "Min Rank:";
            this.ratingLbl.AutoSize = true;
            this.ratingLbl.Location = new global::System.Drawing.Point(7, 371);
            this.ratingLbl.Name = "ratingLbl";
            this.ratingLbl.Size = new global::System.Drawing.Size(41, 13);
            this.ratingLbl.TabIndex = 9;
            this.ratingLbl.Text = "Rating:";
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new global::System.Drawing.Point(7, 343);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new global::System.Drawing.Size(37, 13);
            this.typeLbl.TabIndex = 9;
            this.typeLbl.Text = "Type: ";
            this.playsLbl.AutoSize = true;
            this.playsLbl.Location = new global::System.Drawing.Point(7, 385);
            this.playsLbl.Name = "playsLbl";
            this.playsLbl.Size = new global::System.Drawing.Size(38, 13);
            this.playsLbl.TabIndex = 9;
            this.playsLbl.Text = "Plays: ";
            this.versionLbl.AutoSize = true;
            this.versionLbl.Location = new global::System.Drawing.Point(7, 357);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new global::System.Drawing.Size(45, 13);
            this.versionLbl.TabIndex = 9;
            this.versionLbl.Text = "Version:";
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new global::System.Drawing.Point(6, 262);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new global::System.Drawing.Size(61, 13);
            this.userLbl.TabIndex = 9;
            this.userLbl.Text = "Username: ";
            this.ascBox.AutoSize = true;
            this.ascBox.Location = new global::System.Drawing.Point(109, 101);
            this.ascBox.Name = "ascBox";
            this.ascBox.Size = new global::System.Drawing.Size(76, 17);
            this.ascBox.TabIndex = 8;
            this.ascBox.Text = "Ascending";
            this.ascBox.UseVisualStyleBackColor = true;
            this.orderBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Items.AddRange(new object[]
            {
                "Date",
                "Popularity",
                "Rating",
                "Alphabetical"
            });
            this.orderBox.Location = new global::System.Drawing.Point(101, 74);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new global::System.Drawing.Size(82, 21);
            this.orderBox.TabIndex = 7;
            this.modeBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeBox.FormattingEnabled = true;
            this.modeBox.Items.AddRange(new object[]
            {
                "Username",
                "Level Title"
            });
            this.modeBox.Location = new global::System.Drawing.Point(10, 74);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new global::System.Drawing.Size(82, 21);
            this.modeBox.TabIndex = 7;
            this.pageNum.Location = new global::System.Drawing.Point(45, 100);
            global::System.Windows.Forms.NumericUpDown numericUpDown = this.pageNum;
            int[] array = new int[4];
            array[0] = 10000;
            numericUpDown.Maximum = new decimal(array);
            global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.pageNum;
            int[] array2 = new int[4];
            array2[0] = 1;
            numericUpDown2.Minimum = new decimal(array2);
            this.pageNum.Name = "pageNum";
            this.pageNum.Size = new global::System.Drawing.Size(56, 20);
            this.pageNum.TabIndex = 6;
            global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.pageNum;
            int[] array3 = new int[4];
            array3[0] = 1;
            numericUpDown3.Value = new decimal(array3);
            this.label12.AutoSize = true;
            this.label12.Location = new global::System.Drawing.Point(7, 102);
            this.label12.Name = "label12";
            this.label12.Size = new global::System.Drawing.Size(35, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Page:";
            this.label11.AutoSize = true;
            this.label11.Location = new global::System.Drawing.Point(7, 53);
            this.label11.Name = "label11";
            this.label11.Size = new global::System.Drawing.Size(44, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Search:";
            this.searchBox.Location = new global::System.Drawing.Point(57, 50);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new global::System.Drawing.Size(126, 20);
            this.searchBox.TabIndex = 3;
            this.myLevelsButton.Location = new global::System.Drawing.Point(6, 128);
            this.myLevelsButton.Name = "myLevelsButton";
            this.myLevelsButton.Size = new global::System.Drawing.Size(95, 23);
            this.myLevelsButton.TabIndex = 2;
            this.myLevelsButton.Text = "Load My Levels";
            this.myLevelsButton.UseVisualStyleBackColor = true;
            this.myLevelsButton.Click += new global::System.EventHandler(this.myLevelsButton_Click);
            this.searchBtn.Location = new global::System.Drawing.Point(120, 128);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new global::System.Drawing.Size(63, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new global::System.EventHandler(this.searchBtn_Click);
            this.levelsList.FormattingEnabled = true;
            this.levelsList.Location = new global::System.Drawing.Point(6, 157);
            this.levelsList.Name = "levelsList";
            this.levelsList.Size = new global::System.Drawing.Size(180, 95);
            this.levelsList.TabIndex = 1;
            this.levelsList.SelectedIndexChanged += new global::System.EventHandler(this.levelsList_SelectedIndexChanged);
            this.levelsList.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.levelsList_MouseDoubleClick);
            this.btnLoadLevel.Location = new global::System.Drawing.Point(19, 6);
            this.btnLoadLevel.Name = "btnLoadLevel";
            this.btnLoadLevel.Size = new global::System.Drawing.Size(150, 23);
            this.btnLoadLevel.TabIndex = 0;
            this.btnLoadLevel.Text = "Load Downloaded Level";
            this.btnLoadLevel.UseVisualStyleBackColor = true;
            this.btnLoadLevel.Click += new global::System.EventHandler(this.btnLoadLevel_Click);
            this.tabLevelData.BackColor = global::System.Drawing.Color.Gainsboro;
            this.tabLevelData.Controls.Add(this.chkLive);
            this.tabLevelData.Controls.Add(this.uploadBtn);
            this.tabLevelData.Controls.Add(this.cmbGameMode);
            this.tabLevelData.Controls.Add(this.label7);
            this.tabLevelData.Controls.Add(this.cmbMusic);
            this.tabLevelData.Controls.Add(this.label5);
            this.tabLevelData.Controls.Add(this.groupBox1);
            this.tabLevelData.Controls.Add(this.numCowboyChance);
            this.tabLevelData.Controls.Add(this.label8);
            this.tabLevelData.Controls.Add(this.numMinLevel);
            this.tabLevelData.Controls.Add(this.label6);
            this.tabLevelData.Controls.Add(this.numGravity);
            this.tabLevelData.Controls.Add(this.label4);
            this.tabLevelData.Controls.Add(this.txtCredits);
            this.tabLevelData.Controls.Add(this.label3);
            this.tabLevelData.Controls.Add(this.txtNote);
            this.tabLevelData.Controls.Add(this.txtTitle);
            this.tabLevelData.Controls.Add(this.label2);
            this.tabLevelData.Controls.Add(this.label1);
            this.tabLevelData.Location = new global::System.Drawing.Point(4, 22);
            this.tabLevelData.Name = "tabLevelData";
            this.tabLevelData.Padding = new global::System.Windows.Forms.Padding(3);
            this.tabLevelData.Size = new global::System.Drawing.Size(192, 476);
            this.tabLevelData.TabIndex = 1;
            this.tabLevelData.Text = "Info";
            this.chkLive.AutoSize = true;
            this.chkLive.Location = new global::System.Drawing.Point(102, 447);
            this.chkLive.Name = "chkLive";
            this.chkLive.Size = new global::System.Drawing.Size(74, 17);
            this.chkLive.TabIndex = 11;
            this.chkLive.Text = "Live/Pass";
            this.chkLive.ThreeState = true;
            this.chkLive.UseVisualStyleBackColor = true;
            this.chkLive.CheckStateChanged += new global::System.EventHandler(this.chkLive_CheckStateChanged);
            this.uploadBtn.Location = new global::System.Drawing.Point(17, 444);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new global::System.Drawing.Size(75, 23);
            this.uploadBtn.TabIndex = 10;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new global::System.EventHandler(this.uploadBtn_Click);
            this.cmbGameMode.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGameMode.FormattingEnabled = true;
            this.cmbGameMode.Items.AddRange(new object[]
            {
                "Race",
                "Deathmatch",
                "Objective",
                "Egg"
            });
            this.cmbGameMode.Location = new global::System.Drawing.Point(82, 394);
            this.cmbGameMode.Name = "cmbGameMode";
            this.cmbGameMode.Size = new global::System.Drawing.Size(100, 21);
            this.cmbGameMode.TabIndex = 9;
            this.cmbGameMode.SelectedIndexChanged += new global::System.EventHandler(this.cmbGameMode_SelectedIndexChanged);
            this.label7.AutoSize = true;
            this.label7.Location = new global::System.Drawing.Point(10, 397);
            this.label7.Name = "label7";
            this.label7.Size = new global::System.Drawing.Size(68, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Game Mode:";
            this.cmbMusic.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusic.FormattingEnabled = true;
            this.cmbMusic.Items.AddRange(new object[]
            {
                "random",
                "None",
                "Miniature Fantasy",
                "Under Fire",
                "Paradise on E",
                "Crying Soul",
                "My Vision",
                "Switchblade",
                "The Wires",
                "Before Mydnite",
                "Broked It",
                "Hello?",
                "Pyrokinesis",
                "Flowerz 'n' Herbz",
                "Instrumental #4",
                "Prismatic"
            });
            this.cmbMusic.Location = new global::System.Drawing.Point(53, 344);
            this.cmbMusic.Name = "cmbMusic";
            this.cmbMusic.Size = new global::System.Drawing.Size(130, 21);
            this.cmbMusic.TabIndex = 9;
            this.cmbMusic.SelectedIndexChanged += new global::System.EventHandler(this.cmbMusic_SelectedIndexChanged);
            this.label5.AutoSize = true;
            this.label5.Location = new global::System.Drawing.Point(9, 347);
            this.label5.Name = "label5";
            this.label5.Size = new global::System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Music:";
            this.groupBox1.Controls.Add(this.linkLabelToggleItems);
            this.groupBox1.Controls.Add(this.chkMine);
            this.groupBox1.Controls.Add(this.chkTeleport);
            this.groupBox1.Controls.Add(this.chkJetPack);
            this.groupBox1.Controls.Add(this.chkSword);
            this.groupBox1.Controls.Add(this.chkFreezeRay);
            this.groupBox1.Controls.Add(this.chkSpeedy);
            this.groupBox1.Controls.Add(this.chkSuperJump);
            this.groupBox1.Controls.Add(this.chkLightning);
            this.groupBox1.Controls.Add(this.chkLaserGun);
            this.groupBox1.Location = new global::System.Drawing.Point(6, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new global::System.Drawing.Size(180, 104);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            this.groupBox1.UseCompatibleTextRendering = true;
            this.linkLabelToggleItems.AutoSize = true;
            this.linkLabelToggleItems.Location = new global::System.Drawing.Point(87, 84);
            this.linkLabelToggleItems.Name = "linkLabelToggleItems";
            this.linkLabelToggleItems.Size = new global::System.Drawing.Size(49, 13);
            this.linkLabelToggleItems.TabIndex = 1;
            this.linkLabelToggleItems.TabStop = true;
            this.linkLabelToggleItems.Text = "toggle all";
            this.linkLabelToggleItems.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelToggleItems_LinkClicked);
            this.chkMine.AutoSize = true;
            this.chkMine.Location = new global::System.Drawing.Point(87, 14);
            this.chkMine.Name = "chkMine";
            this.chkMine.Size = new global::System.Drawing.Size(49, 17);
            this.chkMine.TabIndex = 0;
            this.chkMine.Text = "Mine";
            this.chkMine.UseVisualStyleBackColor = true;
            this.chkMine.CheckedChanged += new global::System.EventHandler(this.chkItem_CheckedChanged);
            this.chkTeleport.AutoSize = true;
            this.chkTeleport.Location = new global::System.Drawing.Point(87, 32);
            this.chkTeleport.Name = "chkTeleport";
            this.chkTeleport.Size = new global::System.Drawing.Size(65, 17);
            this.chkTeleport.TabIndex = 0;
            this.chkTeleport.Text = "Teleport";
            this.chkTeleport.UseVisualStyleBackColor = true;
            this.chkTeleport.CheckedChanged += new global::System.EventHandler(this.chkItem_CheckedChanged);
            this.chkJetPack.AutoSize = true;
            this.chkJetPack.Location = new global::System.Drawing.Point(87, 49);
            this.chkJetPack.Name = "chkJetPack";
            this.chkJetPack.Size = new global::System.Drawing.Size(68, 17);
            this.chkJetPack.TabIndex = 0;
            this.chkJetPack.Text = "Jet Pack";
            this.chkJetPack.UseVisualStyleBackColor = true;
            this.chkJetPack.CheckedChanged += new global::System.EventHandler(this.chkItem_CheckedChanged);
            this.chkSword.AutoSize = true;
            this.chkSword.Location = new global::System.Drawing.Point(87, 66);
            this.chkSword.Name = "chkSword";
            this.chkSword.Size = new global::System.Drawing.Size(56, 17);
            this.chkSword.TabIndex = 0;
            this.chkSword.Text = "Sword";
            this.chkSword.UseVisualStyleBackColor = true;
            this.chkSword.CheckedChanged += new global::System.EventHandler(this.chkItem_CheckedChanged);
            this.chkFreezeRay.AutoSize = true;
            this.chkFreezeRay.Location = new global::System.Drawing.Point(6, 84);
            this.chkFreezeRay.Name = "chkFreezeRay";
            this.chkFreezeRay.Size = new global::System.Drawing.Size(80, 17);
            this.chkFreezeRay.TabIndex = 0;
            this.chkFreezeRay.Text = "Freeze Ray";
            this.chkFreezeRay.UseVisualStyleBackColor = true;
            this.chkFreezeRay.CheckedChanged += new global::System.EventHandler(this.chkItem_CheckedChanged);
            this.chkSpeedy.AutoSize = true;
            this.chkSpeedy.Location = new global::System.Drawing.Point(6, 66);
            this.chkSpeedy.Name = "chkSpeedy";
            this.chkSpeedy.Size = new global::System.Drawing.Size(62, 17);
            this.chkSpeedy.TabIndex = 0;
            this.chkSpeedy.Text = "Speedy";
            this.chkSpeedy.UseVisualStyleBackColor = true;
            this.chkSpeedy.CheckedChanged += new global::System.EventHandler(this.chkItem_CheckedChanged);
            this.chkSuperJump.AutoSize = true;
            this.chkSuperJump.Location = new global::System.Drawing.Point(6, 49);
            this.chkSuperJump.Name = "chkSuperJump";
            this.chkSuperJump.Size = new global::System.Drawing.Size(79, 17);
            this.chkSuperJump.TabIndex = 0;
            this.chkSuperJump.Text = "SuperJump";
            this.chkSuperJump.UseVisualStyleBackColor = true;
            this.chkSuperJump.CheckedChanged += new global::System.EventHandler(this.chkItem_CheckedChanged);
            this.chkLightning.AutoSize = true;
            this.chkLightning.Location = new global::System.Drawing.Point(6, 32);
            this.chkLightning.Name = "chkLightning";
            this.chkLightning.Size = new global::System.Drawing.Size(69, 17);
            this.chkLightning.TabIndex = 0;
            this.chkLightning.Text = "Lightning";
            this.chkLightning.UseVisualStyleBackColor = true;
            this.chkLightning.CheckedChanged += new global::System.EventHandler(this.chkItem_CheckedChanged);
            this.chkLaserGun.AutoSize = true;
            this.chkLaserGun.Location = new global::System.Drawing.Point(6, 14);
            this.chkLaserGun.Name = "chkLaserGun";
            this.chkLaserGun.Size = new global::System.Drawing.Size(75, 17);
            this.chkLaserGun.TabIndex = 0;
            this.chkLaserGun.Text = "Laser Gun";
            this.chkLaserGun.UseVisualStyleBackColor = true;
            this.chkLaserGun.CheckedChanged += new global::System.EventHandler(this.chkItem_CheckedChanged);
            this.numCowboyChance.Location = new global::System.Drawing.Point(106, 419);
            global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numCowboyChance;
            int[] array4 = new int[4];
            array4[0] = 500;
            numericUpDown4.Maximum = new decimal(array4);
            this.numCowboyChance.Minimum = new decimal(new int[]
            {
                100,
                0,
                0,
                int.MinValue
            });
            this.numCowboyChance.Name = "numCowboyChance";
            this.numCowboyChance.Size = new global::System.Drawing.Size(70, 20);
            this.numCowboyChance.TabIndex = 6;
            this.numCowboyChance.ValueChanged += new global::System.EventHandler(this.numCowboyChance_ValueChanged);
            this.label8.AutoSize = true;
            this.label8.Location = new global::System.Drawing.Point(12, 421);
            this.label8.Name = "label8";
            this.label8.Size = new global::System.Drawing.Size(88, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cowboy Chance:";
            this.numMinLevel.Location = new global::System.Drawing.Point(85, 368);
            global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numMinLevel;
            int[] array5 = new int[4];
            array5[0] = 127;
            numericUpDown5.Maximum = new decimal(array5);
            this.numMinLevel.Minimum = new decimal(new int[]
            {
                128,
                0,
                0,
                int.MinValue
            });
            this.numMinLevel.Name = "numMinLevel";
            this.numMinLevel.Size = new global::System.Drawing.Size(70, 20);
            this.numMinLevel.TabIndex = 6;
            this.numMinLevel.ValueChanged += new global::System.EventHandler(this.numMinLevel_ValueChanged);
            this.label6.AutoSize = true;
            this.label6.Location = new global::System.Drawing.Point(23, 370);
            this.label6.Name = "label6";
            this.label6.Size = new global::System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Min Rank:";
            this.numGravity.DecimalPlaces = 5;
            this.numGravity.Location = new global::System.Drawing.Point(72, 210);
            global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numGravity;
            int[] array6 = new int[4];
            array6[0] = 1000;
            numericUpDown6.Maximum = new decimal(array6);
            this.numGravity.Minimum = new decimal(new int[]
            {
                1000,
                0,
                0,
                int.MinValue
            });
            this.numGravity.Name = "numGravity";
            this.numGravity.Size = new global::System.Drawing.Size(83, 20);
            this.numGravity.TabIndex = 6;
            global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.numGravity;
            int[] array7 = new int[4];
            array7[0] = 1;
            numericUpDown7.Value = new decimal(array7);
            this.numGravity.ValueChanged += new global::System.EventHandler(this.numGravity_ValueChanged);
            this.label4.AutoSize = true;
            this.label4.Location = new global::System.Drawing.Point(23, 212);
            this.label4.Name = "label4";
            this.label4.Size = new global::System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gravity:";
            this.txtCredits.Location = new global::System.Drawing.Point(6, 152);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new global::System.Drawing.Size(180, 51);
            this.txtCredits.TabIndex = 4;
            this.txtCredits.Text = "";
            this.txtCredits.TextChanged += new global::System.EventHandler(this.txtCredits_TextChanged);
            this.label3.AutoSize = true;
            this.label3.Location = new global::System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Credits:";
            this.txtNote.Location = new global::System.Drawing.Point(6, 54);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new global::System.Drawing.Size(177, 81);
            this.txtNote.TabIndex = 2;
            this.txtNote.Text = "";
            this.txtNote.TextChanged += new global::System.EventHandler(this.txtNote_TextChanged);
            this.txtTitle.Location = new global::System.Drawing.Point(6, 17);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new global::System.Drawing.Size(180, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new global::System.EventHandler(this.txtTitle_TextChanged);
            this.label2.AutoSize = true;
            this.label2.Location = new global::System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Level Note:";
            this.label1.AutoSize = true;
            this.label1.Location = new global::System.Drawing.Point(6, 2);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level Title:";
            this.tabGameControls.Controls.Add(this.buttonLoadRace);
            this.tabGameControls.Controls.Add(this.tournamentBth);
            this.tabGameControls.Controls.Add(this.lblRecStatus);
            this.tabGameControls.Controls.Add(this.lblPlayers);
            this.tabGameControls.Controls.Add(this.btnAddPlayer);
            this.tabGameControls.Controls.Add(this.label10);
            this.tabGameControls.Controls.Add(this.numSelectedPlayer);
            this.tabGameControls.Controls.Add(this.btnPartial);
            this.tabGameControls.Controls.Add(this.lblTotalStats);
            this.tabGameControls.Controls.Add(this.chkCopy);
            this.tabGameControls.Controls.Add(this.chkx10);
            this.tabGameControls.Controls.Add(this.btnInsertFrame);
            this.tabGameControls.Controls.Add(this.btnDeleteFrame);
            this.tabGameControls.Controls.Add(this.btnCurrentFrame);
            this.tabGameControls.Controls.Add(this.btnSetRecSS);
            this.tabGameControls.Controls.Add(this.numJump);
            this.tabGameControls.Controls.Add(this.numAccel);
            this.tabGameControls.Controls.Add(this.numSpeed);
            this.tabGameControls.Controls.Add(this.btnSetStats);
            this.tabGameControls.Controls.Add(this.btnPlayRec);
            this.tabGameControls.Controls.Add(this.btnSaveRec);
            this.tabGameControls.Controls.Add(this.btnLoadRec);
            this.tabGameControls.Controls.Add(this.chkLoadSS);
            this.tabGameControls.Controls.Add(this.lblFrames);
            this.tabGameControls.Controls.Add(this.numNextLast);
            this.tabGameControls.Controls.Add(this.rdoNext);
            this.tabGameControls.Controls.Add(this.rdoLast);
            this.tabGameControls.Controls.Add(this.btnSetNextTo);
            this.tabGameControls.Controls.Add(this.lblSS);
            this.tabGameControls.Controls.Add(this.numFrame);
            this.tabGameControls.Controls.Add(this.label9);
            this.tabGameControls.Controls.Add(this.chkSpace);
            this.tabGameControls.Controls.Add(this.chkRight);
            this.tabGameControls.Controls.Add(this.chkLeft);
            this.tabGameControls.Controls.Add(this.chkDown);
            this.tabGameControls.Controls.Add(this.chkUp);
            this.tabGameControls.Controls.Add(this.btnPlay);
            this.tabGameControls.Location = new global::System.Drawing.Point(4, 22);
            this.tabGameControls.Name = "tabGameControls";
            this.tabGameControls.Padding = new global::System.Windows.Forms.Padding(3);
            this.tabGameControls.Size = new global::System.Drawing.Size(192, 476);
            this.tabGameControls.TabIndex = 2;
            this.tabGameControls.Text = "Play";
            this.tabGameControls.UseVisualStyleBackColor = true;
            this.buttonLoadRace.Location = new global::System.Drawing.Point(114, 6);
            this.buttonLoadRace.Name = "buttonLoadRace";
            this.buttonLoadRace.Size = new global::System.Drawing.Size(75, 23);
            this.buttonLoadRace.TabIndex = 28;
            this.buttonLoadRace.Text = "Load Race";
            this.buttonLoadRace.UseVisualStyleBackColor = true;
            this.buttonLoadRace.Click += new global::System.EventHandler(this.buttonLoadRace_Click);
            this.tournamentBth.AutoSize = true;
            this.tournamentBth.BackColor = global::System.Drawing.Color.LightGray;
            this.tournamentBth.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
            this.tournamentBth.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            this.tournamentBth.Location = new global::System.Drawing.Point(129, 406);
            this.tournamentBth.Name = "tournamentBth";
            this.tournamentBth.Size = new global::System.Drawing.Size(56, 14);
            this.tournamentBth.TabIndex = 27;
            this.tournamentBth.Text = "Tournament";
            this.tournamentBth.Click += new global::System.EventHandler(this.tournamentBth_Click);
            this.lblRecStatus.AutoSize = true;
            this.lblRecStatus.Location = new global::System.Drawing.Point(32, 315);
            this.lblRecStatus.Name = "lblRecStatus";
            this.lblRecStatus.Size = new global::System.Drawing.Size(99, 13);
            this.lblRecStatus.TabIndex = 26;
            this.lblRecStatus.Text = "Recording [Default]";
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Location = new global::System.Drawing.Point(97, 358);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new global::System.Drawing.Size(21, 13);
            this.lblPlayers.TabIndex = 25;
            this.lblPlayers.Text = "/ 1";
            this.btnAddPlayer.Location = new global::System.Drawing.Point(133, 355);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new global::System.Drawing.Size(53, 20);
            this.btnAddPlayer.TabIndex = 24;
            this.btnAddPlayer.Text = "add";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new global::System.EventHandler(this.btnAddPlayer_Click);
            this.label10.AutoSize = true;
            this.label10.Location = new global::System.Drawing.Point(12, 357);
            this.label10.Name = "label10";
            this.label10.Size = new global::System.Drawing.Size(39, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Player:";
            this.numSelectedPlayer.InterceptArrowKeys = false;
            this.numSelectedPlayer.Location = new global::System.Drawing.Point(57, 355);
            global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.numSelectedPlayer;
            int[] array8 = new int[4];
            array8[0] = 1;
            numericUpDown8.Maximum = new decimal(array8);
            global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.numSelectedPlayer;
            int[] array9 = new int[4];
            array9[0] = 1;
            numericUpDown9.Minimum = new decimal(array9);
            this.numSelectedPlayer.Name = "numSelectedPlayer";
            this.numSelectedPlayer.Size = new global::System.Drawing.Size(38, 20);
            this.numSelectedPlayer.TabIndex = 22;
            global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.numSelectedPlayer;
            int[] array10 = new int[4];
            array10[0] = 1;
            numericUpDown10.Value = new decimal(array10);
            this.numSelectedPlayer.ValueChanged += new global::System.EventHandler(this.numSelectedPlayer_ValueChanged);
            this.btnPartial.Location = new global::System.Drawing.Point(19, 221);
            this.btnPartial.Name = "btnPartial";
            this.btnPartial.Size = new global::System.Drawing.Size(75, 23);
            this.btnPartial.TabIndex = 21;
            this.btnPartial.Text = "Partials";
            this.btnPartial.UseVisualStyleBackColor = true;
            this.btnPartial.Click += new global::System.EventHandler(this.btnPartial_Click);
            this.lblTotalStats.AutoSize = true;
            this.lblTotalStats.Location = new global::System.Drawing.Point(157, 425);
            this.lblTotalStats.Name = "lblTotalStats";
            this.lblTotalStats.Size = new global::System.Drawing.Size(31, 13);
            this.lblTotalStats.TabIndex = 20;
            this.lblTotalStats.Text = "(300)";
            this.chkCopy.AutoSize = true;
            this.chkCopy.Checked = true;
            this.chkCopy.CheckState = global::System.Windows.Forms.CheckState.Checked;
            this.chkCopy.Location = new global::System.Drawing.Point(112, 198);
            this.chkCopy.Name = "chkCopy";
            this.chkCopy.Size = new global::System.Drawing.Size(50, 17);
            this.chkCopy.TabIndex = 19;
            this.chkCopy.Text = "Copy";
            this.chkCopy.UseVisualStyleBackColor = true;
            this.chkx10.AutoSize = true;
            this.chkx10.Location = new global::System.Drawing.Point(51, 198);
            this.chkx10.Name = "chkx10";
            this.chkx10.Size = new global::System.Drawing.Size(49, 17);
            this.chkx10.TabIndex = 18;
            this.chkx10.Text = "x10?";
            this.chkx10.UseVisualStyleBackColor = true;
            this.chkx10.CheckedChanged += new global::System.EventHandler(this.chkx10_CheckedChanged);
            this.btnInsertFrame.Location = new global::System.Drawing.Point(101, 173);
            this.btnInsertFrame.Name = "btnInsertFrame";
            this.btnInsertFrame.Size = new global::System.Drawing.Size(75, 23);
            this.btnInsertFrame.TabIndex = 17;
            this.btnInsertFrame.Text = "Insert";
            this.btnInsertFrame.UseVisualStyleBackColor = true;
            this.btnInsertFrame.Click += new global::System.EventHandler(this.btnInsertFrame_Click);
            this.btnDeleteFrame.Location = new global::System.Drawing.Point(9, 173);
            this.btnDeleteFrame.Name = "btnDeleteFrame";
            this.btnDeleteFrame.Size = new global::System.Drawing.Size(75, 23);
            this.btnDeleteFrame.TabIndex = 17;
            this.btnDeleteFrame.Text = "Delete";
            this.btnDeleteFrame.UseVisualStyleBackColor = true;
            this.btnDeleteFrame.Click += new global::System.EventHandler(this.btnDeleteFrame_Click);
            this.btnCurrentFrame.Location = new global::System.Drawing.Point(137, 37);
            this.btnCurrentFrame.Name = "btnCurrentFrame";
            this.btnCurrentFrame.Size = new global::System.Drawing.Size(49, 23);
            this.btnCurrentFrame.TabIndex = 16;
            this.btnCurrentFrame.Text = "Current";
            this.btnCurrentFrame.UseVisualStyleBackColor = true;
            this.btnCurrentFrame.Click += new global::System.EventHandler(this.btnCurrentFrame_Click);
            this.btnSetRecSS.Location = new global::System.Drawing.Point(110, 236);
            this.btnSetRecSS.Name = "btnSetRecSS";
            this.btnSetRecSS.Size = new global::System.Drawing.Size(75, 23);
            this.btnSetRecSS.TabIndex = 15;
            this.btnSetRecSS.Text = "Set Rec SS";
            this.btnSetRecSS.UseVisualStyleBackColor = true;
            this.btnSetRecSS.Click += new global::System.EventHandler(this.btnSetRecSS_Click);
            this.numJump.Location = new global::System.Drawing.Point(107, 423);
            this.numJump.Name = "numJump";
            this.numJump.Size = new global::System.Drawing.Size(44, 20);
            this.numJump.TabIndex = 14;
            global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.numJump;
            int[] array11 = new int[4];
            array11[0] = 100;
            numericUpDown11.Value = new decimal(array11);
            this.numJump.ValueChanged += new global::System.EventHandler(this.numStat_ValueChanged);
            this.numAccel.Location = new global::System.Drawing.Point(57, 423);
            this.numAccel.Name = "numAccel";
            this.numAccel.Size = new global::System.Drawing.Size(44, 20);
            this.numAccel.TabIndex = 14;
            global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.numAccel;
            int[] array12 = new int[4];
            array12[0] = 100;
            numericUpDown12.Value = new decimal(array12);
            this.numAccel.ValueChanged += new global::System.EventHandler(this.numStat_ValueChanged);
            this.numSpeed.Location = new global::System.Drawing.Point(7, 423);
            global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.numSpeed;
            int[] array13 = new int[4];
            array13[0] = 1100;
            numericUpDown13.Maximum = new decimal(array13);
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new global::System.Drawing.Size(44, 20);
            this.numSpeed.TabIndex = 14;
            global::System.Windows.Forms.NumericUpDown numericUpDown14 = this.numSpeed;
            int[] array14 = new int[4];
            array14[0] = 100;
            numericUpDown14.Value = new decimal(array14);
            this.numSpeed.ValueChanged += new global::System.EventHandler(this.numStat_ValueChanged);
            this.btnSetStats.Location = new global::System.Drawing.Point(6, 395);
            this.btnSetStats.Name = "btnSetStats";
            this.btnSetStats.Size = new global::System.Drawing.Size(63, 23);
            this.btnSetStats.TabIndex = 13;
            this.btnSetStats.Text = "Set Stats";
            this.btnSetStats.UseVisualStyleBackColor = true;
            this.btnSetStats.Click += new global::System.EventHandler(this.btnSetStats_Click);
            this.btnPlayRec.Location = new global::System.Drawing.Point(3, 289);
            this.btnPlayRec.Name = "btnPlayRec";
            this.btnPlayRec.Size = new global::System.Drawing.Size(66, 23);
            this.btnPlayRec.TabIndex = 12;
            this.btnPlayRec.Text = "Play Rec";
            this.btnPlayRec.UseVisualStyleBackColor = true;
            this.btnPlayRec.Click += new global::System.EventHandler(this.btnPlayRec_Click);
            this.btnSaveRec.Location = new global::System.Drawing.Point(2, 260);
            this.btnSaveRec.Name = "btnSaveRec";
            this.btnSaveRec.Size = new global::System.Drawing.Size(92, 23);
            this.btnSaveRec.TabIndex = 11;
            this.btnSaveRec.Text = "Save Recording";
            this.btnSaveRec.UseVisualStyleBackColor = true;
            this.btnSaveRec.Click += new global::System.EventHandler(this.btnSaveRec_Click);
            this.btnLoadRec.Location = new global::System.Drawing.Point(98, 260);
            this.btnLoadRec.Name = "btnLoadRec";
            this.btnLoadRec.Size = new global::System.Drawing.Size(91, 23);
            this.btnLoadRec.TabIndex = 11;
            this.btnLoadRec.Text = "Load Recording";
            this.btnLoadRec.UseVisualStyleBackColor = true;
            this.btnLoadRec.Click += new global::System.EventHandler(this.btnLoadRec_Click);
            this.chkLoadSS.AutoSize = true;
            this.chkLoadSS.Location = new global::System.Drawing.Point(75, 293);
            this.chkLoadSS.Name = "chkLoadSS";
            this.chkLoadSS.Size = new global::System.Drawing.Size(67, 17);
            this.chkLoadSS.TabIndex = 10;
            this.chkLoadSS.Text = "Load SS";
            this.chkLoadSS.UseVisualStyleBackColor = true;
            this.chkLoadSS.CheckedChanged += new global::System.EventHandler(this.chkPlayRec_CheckedChanged);
            this.lblFrames.AutoSize = true;
            this.lblFrames.Location = new global::System.Drawing.Point(130, 67);
            this.lblFrames.Name = "lblFrames";
            this.lblFrames.Size = new global::System.Drawing.Size(19, 13);
            this.lblFrames.TabIndex = 9;
            this.lblFrames.Text = "(0)";
            this.numNextLast.Location = new global::System.Drawing.Point(101, 147);
            global::System.Windows.Forms.NumericUpDown numericUpDown15 = this.numNextLast;
            int[] array15 = new int[4];
            array15[0] = 1000000;
            numericUpDown15.Maximum = new decimal(array15);
            global::System.Windows.Forms.NumericUpDown numericUpDown16 = this.numNextLast;
            int[] array16 = new int[4];
            array16[0] = 1;
            numericUpDown16.Minimum = new decimal(array16);
            this.numNextLast.Name = "numNextLast";
            this.numNextLast.Size = new global::System.Drawing.Size(70, 20);
            this.numNextLast.TabIndex = 8;
            global::System.Windows.Forms.NumericUpDown numericUpDown17 = this.numNextLast;
            int[] array17 = new int[4];
            array17[0] = 1;
            numericUpDown17.Value = new decimal(array17);
            this.rdoNext.AutoSize = true;
            this.rdoNext.Checked = true;
            this.rdoNext.Location = new global::System.Drawing.Point(136, 124);
            this.rdoNext.Name = "rdoNext";
            this.rdoNext.Size = new global::System.Drawing.Size(47, 17);
            this.rdoNext.TabIndex = 6;
            this.rdoNext.TabStop = true;
            this.rdoNext.Text = "Next";
            this.rdoNext.UseVisualStyleBackColor = true;
            this.rdoLast.AutoSize = true;
            this.rdoLast.Location = new global::System.Drawing.Point(92, 124);
            this.rdoLast.Name = "rdoLast";
            this.rdoLast.Size = new global::System.Drawing.Size(45, 17);
            this.rdoLast.TabIndex = 7;
            this.rdoLast.Text = "Last";
            this.rdoLast.UseVisualStyleBackColor = true;
            this.btnSetNextTo.Location = new global::System.Drawing.Point(10, 121);
            this.btnSetNextTo.Name = "btnSetNextTo";
            this.btnSetNextTo.Size = new global::System.Drawing.Size(75, 23);
            this.btnSetNextTo.TabIndex = 5;
            this.btnSetNextTo.Text = "Set:";
            this.btnSetNextTo.UseVisualStyleBackColor = true;
            this.btnSetNextTo.Click += new global::System.EventHandler(this.btnSetNextTo_Click);
            this.lblSS.AutoSize = true;
            this.lblSS.Location = new global::System.Drawing.Point(4, 460);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new global::System.Drawing.Size(81, 13);
            this.lblSS.TabIndex = 4;
            this.lblSS.Text = "No SS selected";
            this.numFrame.Location = new global::System.Drawing.Point(51, 45);
            this.numFrame.Name = "numFrame";
            this.numFrame.Size = new global::System.Drawing.Size(81, 20);
            this.numFrame.TabIndex = 3;
            this.numFrame.ValueChanged += new global::System.EventHandler(this.numFrame_ValueChanged);
            this.label9.AutoSize = true;
            this.label9.Location = new global::System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new global::System.Drawing.Size(39, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Frame:";
            this.chkSpace.AutoSize = true;
            this.chkSpace.ForeColor = global::System.Drawing.Color.Black;
            this.chkSpace.Location = new global::System.Drawing.Point(26, 67);
            this.chkSpace.Name = "chkSpace";
            this.chkSpace.Size = new global::System.Drawing.Size(31, 17);
            this.chkSpace.TabIndex = 1;
            this.chkSpace.Text = "s";
            this.chkSpace.UseVisualStyleBackColor = true;
            this.chkSpace.CheckedChanged += new global::System.EventHandler(this.chkInput_CheckedChanged);
            this.chkSpace.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.chkInput_MouseDown);
            this.chkRight.AutoSize = true;
            this.chkRight.ForeColor = global::System.Drawing.Color.Black;
            this.chkRight.Location = new global::System.Drawing.Point(100, 91);
            this.chkRight.Name = "chkRight";
            this.chkRight.Size = new global::System.Drawing.Size(32, 17);
            this.chkRight.TabIndex = 1;
            this.chkRight.Text = ">";
            this.chkRight.UseVisualStyleBackColor = true;
            this.chkRight.CheckedChanged += new global::System.EventHandler(this.chkInput_CheckedChanged);
            this.chkRight.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.chkInput_MouseDown);
            this.chkLeft.AutoSize = true;
            this.chkLeft.ForeColor = global::System.Drawing.Color.Black;
            this.chkLeft.Location = new global::System.Drawing.Point(26, 91);
            this.chkLeft.Name = "chkLeft";
            this.chkLeft.Size = new global::System.Drawing.Size(32, 17);
            this.chkLeft.TabIndex = 1;
            this.chkLeft.Text = "<";
            this.chkLeft.UseVisualStyleBackColor = true;
            this.chkLeft.CheckedChanged += new global::System.EventHandler(this.chkInput_CheckedChanged);
            this.chkLeft.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.chkInput_MouseDown);
            this.chkDown.AutoSize = true;
            this.chkDown.ForeColor = global::System.Drawing.Color.Black;
            this.chkDown.Location = new global::System.Drawing.Point(63, 91);
            this.chkDown.Name = "chkDown";
            this.chkDown.Size = new global::System.Drawing.Size(32, 17);
            this.chkDown.TabIndex = 1;
            this.chkDown.Text = "v";
            this.chkDown.UseVisualStyleBackColor = true;
            this.chkDown.CheckedChanged += new global::System.EventHandler(this.chkInput_CheckedChanged);
            this.chkDown.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.chkInput_MouseDown);
            this.chkUp.AutoSize = true;
            this.chkUp.ForeColor = global::System.Drawing.Color.Black;
            this.chkUp.Location = new global::System.Drawing.Point(63, 69);
            this.chkUp.Name = "chkUp";
            this.chkUp.Size = new global::System.Drawing.Size(32, 17);
            this.chkUp.TabIndex = 1;
            this.chkUp.Text = "^";
            this.chkUp.UseVisualStyleBackColor = true;
            this.chkUp.CheckedChanged += new global::System.EventHandler(this.chkInput_CheckedChanged);
            this.chkUp.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.chkInput_MouseDown);
            this.btnPlay.Location = new global::System.Drawing.Point(6, 6);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new global::System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play Level";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new global::System.EventHandler(this.btnPlay_Click);
            this.tabLE.Controls.Add(this.buttonSaveToFile);
            this.tabLE.Controls.Add(this.listViewBlocks);
            this.tabLE.Location = new global::System.Drawing.Point(4, 22);
            this.tabLE.Name = "tabLE";
            this.tabLE.Padding = new global::System.Windows.Forms.Padding(3);
            this.tabLE.Size = new global::System.Drawing.Size(192, 476);
            this.tabLE.TabIndex = 3;
            this.tabLE.Text = "LE";
            this.tabLE.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Location = new global::System.Drawing.Point(6, 446);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new global::System.Drawing.Size(87, 23);
            this.buttonSaveToFile.TabIndex = 3;
            this.buttonSaveToFile.Text = "Save to File...";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new global::System.EventHandler(this.buttonSaveToFile_Click);
            this.listViewBlocks.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
            {
                this.colHdrBlock
            });
            this.listViewBlocks.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewBlocks.HideSelection = false;
            this.listViewBlocks.Items.AddRange(new global::System.Windows.Forms.ListViewItem[]
            {
                listViewItem,
                listViewItem2,
                listViewItem3,
                listViewItem4,
                listViewItem5,
                listViewItem6,
                listViewItem7,
                listViewItem8,
                listViewItem9,
                listViewItem10,
                listViewItem11,
                listViewItem12,
                listViewItem13,
                listViewItem14,
                listViewItem15,
                listViewItem16,
                listViewItem17,
                listViewItem18,
                listViewItem19,
                listViewItem20,
                listViewItem21,
                listViewItem22,
                listViewItem23,
                listViewItem24,
                listViewItem25,
                listViewItem26,
                listViewItem27,
                listViewItem28,
                listViewItem29,
                listViewItem30,
                listViewItem31
            });
            this.listViewBlocks.Location = new global::System.Drawing.Point(137, 3);
            this.listViewBlocks.MultiSelect = false;
            this.listViewBlocks.Name = "listViewBlocks";
            this.listViewBlocks.Size = new global::System.Drawing.Size(52, 473);
            this.listViewBlocks.SmallImageList = this.imageListBlocks;
            this.listViewBlocks.TabIndex = 2;
            this.listViewBlocks.TileSize = new global::System.Drawing.Size(30, 30);
            this.listViewBlocks.UseCompatibleStateImageBehavior = false;
            this.listViewBlocks.View = global::System.Windows.Forms.View.SmallIcon;
            this.colHdrBlock.Text = "Block";
            this.imageListBlocks.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageListBlocks.ImageStream");
            this.imageListBlocks.TransparentColor = global::System.Drawing.Color.Transparent;
            this.imageListBlocks.Images.SetKeyName(0, "BB1.bmp");
            this.imageListBlocks.Images.SetKeyName(1, "BB2.bmp");
            this.imageListBlocks.Images.SetKeyName(2, "BB3.bmp");
            this.imageListBlocks.Images.SetKeyName(3, "BB4.bmp");
            this.imageListBlocks.Images.SetKeyName(4, "Brick.bmp");
            this.imageListBlocks.Images.SetKeyName(5, "Down Arrow.bmp");
            this.imageListBlocks.Images.SetKeyName(6, "Up Arrow.bmp");
            this.imageListBlocks.Images.SetKeyName(7, "Left Arrow.bmp");
            this.imageListBlocks.Images.SetKeyName(8, "Right Arrow.bmp");
            this.imageListBlocks.Images.SetKeyName(9, "Mine.bmp");
            this.imageListBlocks.Images.SetKeyName(10, "Item.bmp");
            this.imageListBlocks.Images.SetKeyName(11, "P1 Start.bmp");
            this.imageListBlocks.Images.SetKeyName(12, "P2 Start.bmp");
            this.imageListBlocks.Images.SetKeyName(13, "P3 Start.bmp");
            this.imageListBlocks.Images.SetKeyName(14, "P4 Start.bmp");
            this.imageListBlocks.Images.SetKeyName(15, "Ice.bmp");
            this.imageListBlocks.Images.SetKeyName(16, "Finish.bmp");
            this.imageListBlocks.Images.SetKeyName(17, "Crumble.bmp");
            this.imageListBlocks.Images.SetKeyName(18, "Vanish.bmp");
            this.imageListBlocks.Images.SetKeyName(19, "Move.bmp");
            this.imageListBlocks.Images.SetKeyName(20, "Water.bmp");
            this.imageListBlocks.Images.SetKeyName(21, "RotateR.bmp");
            this.imageListBlocks.Images.SetKeyName(22, "RotateL.bmp");
            this.imageListBlocks.Images.SetKeyName(23, "Push.bmp");
            this.imageListBlocks.Images.SetKeyName(24, "Safety.bmp");
            this.imageListBlocks.Images.SetKeyName(25, "Inf Item.bmp");
            this.imageListBlocks.Images.SetKeyName(26, "Happy.bmp");
            this.imageListBlocks.Images.SetKeyName(27, "Sad.bmp");
            this.imageListBlocks.Images.SetKeyName(28, "Heart.bmp");
            this.imageListBlocks.Images.SetKeyName(29, "image 11 (TimeBitmap).bmp");
            this.imageListBlocks.Images.SetKeyName(30, "Egg.PNG");
            this.tabSimple.Controls.Add(this.button2);
            this.tabSimple.Controls.Add(this.label24);
            this.tabSimple.Controls.Add(this.label23);
            this.tabSimple.Controls.Add(this.label22);
            this.tabSimple.Controls.Add(this.label20);
            this.tabSimple.Controls.Add(this.label19);
            this.tabSimple.Controls.Add(this.label18);
            this.tabSimple.Controls.Add(this.label17);
            this.tabSimple.Controls.Add(this.label16);
            this.tabSimple.Controls.Add(this.label15);
            this.tabSimple.Controls.Add(this.numJump2);
            this.tabSimple.Controls.Add(this.numAccel2);
            this.tabSimple.Controls.Add(this.numSpeed2);
            this.tabSimple.Controls.Add(this.btnSetStats2);
            this.tabSimple.Controls.Add(this.lblSS2);
            this.tabSimple.Controls.Add(this.btnRetart);
            this.tabSimple.Location = new global::System.Drawing.Point(4, 22);
            this.tabSimple.Name = "tabSimple";
            this.tabSimple.Padding = new global::System.Windows.Forms.Padding(3);
            this.tabSimple.Size = new global::System.Drawing.Size(192, 476);
            this.tabSimple.TabIndex = 4;
            this.tabSimple.Text = "Play";
            this.tabSimple.UseVisualStyleBackColor = true;
            this.button2.Location = new global::System.Drawing.Point(21, 266);
            this.button2.Name = "button2";
            this.button2.Size = new global::System.Drawing.Size(146, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Activate Advanced View";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new global::System.EventHandler(this.button2_Click);


            this.label24.AutoSize = true;
            this.label24.Location = new global::System.Drawing.Point(21, 170);
            this.label24.Name = "label24";
            this.label24.Size = new global::System.Drawing.Size(99, 13);
            this.label24.Text = "R: Restart";

            this.label23.AutoSize = true;
            this.label23.Location = new global::System.Drawing.Point(21, 156);
            this.label23.Name = "label23";
            this.label23.Size = new global::System.Drawing.Size(99, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "P: Load save state ";

            this.label22.AutoSize = true;
            this.label22.Location = new global::System.Drawing.Point(21, 143);
            this.label22.Name = "label22";
            this.label22.Size = new global::System.Drawing.Size(146, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "U: Save state to selected slot";
            this.label20.AutoSize = true;
            this.label20.Location = new global::System.Drawing.Point(21, 130);
            this.label20.Name = "label20";
            this.label20.Size = new global::System.Drawing.Size(113, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "0: Deselect save state";
            this.label19.AutoSize = true;
            this.label19.Location = new global::System.Drawing.Point(21, 117);
            this.label19.Name = "label19";
            this.label19.Size = new global::System.Drawing.Size(113, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "1-9:  Select save state";
            this.label18.AutoSize = true;
            this.label18.Location = new global::System.Drawing.Point(21, 104);
            this.label18.Name = "label18";
            this.label18.Size = new global::System.Drawing.Size(134, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Z:  Move Camera to avatar";
            this.label17.AutoSize = true;
            this.label17.Location = new global::System.Drawing.Point(21, 91);
            this.label17.Name = "label17";
            this.label17.Size = new global::System.Drawing.Size(77, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "S:  Next Frame";
            this.label16.AutoSize = true;
            this.label16.Location = new global::System.Drawing.Point(21, 78);
            this.label16.Name = "label16";
            this.label16.Size = new global::System.Drawing.Size(84, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "A:  Play / Pause";
            this.label15.AutoSize = true;
            this.label15.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
            this.label15.Location = new global::System.Drawing.Point(18, 61);
            this.label15.Name = "label15";
            this.label15.Size = new global::System.Drawing.Size(62, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Hot Keys:";
            this.numJump2.Location = new global::System.Drawing.Point(107, 423);
            this.numJump2.Name = "numJump2";
            this.numJump2.Size = new global::System.Drawing.Size(44, 20);
            this.numJump2.TabIndex = 14;
            global::System.Windows.Forms.NumericUpDown numericUpDown18 = this.numJump2;
            int[] array18 = new int[4];
            array18[0] = 100;
            numericUpDown18.Value = new decimal(array18);
            this.numJump2.ValueChanged += new global::System.EventHandler(this.numStat_ValueChanged);
            this.numAccel2.Location = new global::System.Drawing.Point(57, 423);
            this.numAccel2.Name = "numAccel2";
            this.numAccel2.Size = new global::System.Drawing.Size(44, 20);
            this.numAccel2.TabIndex = 14;
            global::System.Windows.Forms.NumericUpDown numericUpDown19 = this.numAccel2;
            int[] array19 = new int[4];
            array19[0] = 100;
            numericUpDown19.Value = new decimal(array19);
            this.numAccel2.ValueChanged += new global::System.EventHandler(this.numStat_ValueChanged);
            this.numSpeed2.Location = new global::System.Drawing.Point(7, 423);
            global::System.Windows.Forms.NumericUpDown numericUpDown20 = this.numSpeed2;
            int[] array20 = new int[4];
            array20[0] = 1100;
            numericUpDown20.Maximum = new decimal(array20);
            this.numSpeed2.Name = "numSpeed2";
            this.numSpeed2.Size = new global::System.Drawing.Size(44, 20);
            this.numSpeed2.TabIndex = 14;
            global::System.Windows.Forms.NumericUpDown numericUpDown21 = this.numSpeed2;
            int[] array21 = new int[4];
            array21[0] = 100;
            numericUpDown21.Value = new decimal(array21);
            this.numSpeed2.ValueChanged += new global::System.EventHandler(this.numStat_ValueChanged);
            this.btnSetStats2.Location = new global::System.Drawing.Point(6, 395);
            this.btnSetStats2.Name = "btnSetStats2";
            this.btnSetStats2.Size = new global::System.Drawing.Size(63, 23);
            this.btnSetStats2.TabIndex = 13;
            this.btnSetStats2.Text = "Set Stats";
            this.btnSetStats2.UseVisualStyleBackColor = true;
            this.btnSetStats2.Click += new global::System.EventHandler(this.btnSetStats_Click);
            this.lblSS2.AutoSize = true;
            this.lblSS2.Location = new global::System.Drawing.Point(4, 460);
            this.lblSS2.Name = "lblSS2";
            this.lblSS2.Size = new global::System.Drawing.Size(81, 13);
            this.lblSS2.TabIndex = 4;
            this.lblSS2.Text = "No SS selected";
            this.btnRetart.Location = new global::System.Drawing.Point(21, 20);
            this.btnRetart.Name = "btnRetart";
            this.btnRetart.Size = new global::System.Drawing.Size(146, 23);
            this.btnRetart.TabIndex = 0;
            this.btnRetart.Text = "Restart";
            this.btnRetart.UseVisualStyleBackColor = true;
            this.btnRetart.Click += new global::System.EventHandler(this.btnRetart_Click);
            this.txtNoSelect.Location = new global::System.Drawing.Point(0, -50);
            this.txtNoSelect.MaxLength = 0;
            this.txtNoSelect.Name = "txtNoSelect";
            this.txtNoSelect.Size = new global::System.Drawing.Size(100, 20);
            this.txtNoSelect.TabIndex = 3;
            this.txtNoSelect.PreviewKeyDown += new global::System.Windows.Forms.PreviewKeyDownEventHandler(this.txtNoSelect_PreviewKeyDown);
            this.lblPause.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.lblPause.AutoSize = true;
            this.lblPause.Location = new global::System.Drawing.Point(3, 473);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new global::System.Drawing.Size(91, 13);
            this.lblPause.TabIndex = 4;
            this.lblPause.Text = "Game not running";
            this.lblVelX.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.lblVelX.AutoSize = true;
            this.lblVelX.Location = new global::System.Drawing.Point(228, 498);
            this.lblVelX.Name = "lblVelX";
            this.lblVelX.Size = new global::System.Drawing.Size(41, 13);
            this.lblVelX.TabIndex = 5;
            this.lblVelX.Text = "VelX: 0";
            this.lblVelY.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.lblVelY.AutoSize = true;
            this.lblVelY.Location = new global::System.Drawing.Point(228, 511);
            this.lblVelY.Name = "lblVelY";
            this.lblVelY.Size = new global::System.Drawing.Size(41, 13);
            this.lblVelY.TabIndex = 5;
            this.lblVelY.Text = "VelY: 0";
            this.lblPosX.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.lblPosX.AutoSize = true;
            this.lblPosX.Location = new global::System.Drawing.Point(228, 524);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new global::System.Drawing.Size(44, 13);
            this.lblPosX.TabIndex = 5;
            this.lblPosX.Text = "PosX: 0";
            this.lblPosY.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.lblPosY.AutoSize = true;
            this.lblPosY.Location = new global::System.Drawing.Point(228, 537);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new global::System.Drawing.Size(44, 13);
            this.lblPosY.TabIndex = 5;
            this.lblPosY.Text = "PosY: 0";
            this.lblTVel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.lblTVel.AutoSize = true;
            this.lblTVel.Location = new global::System.Drawing.Point(321, 498);
            this.lblTVel.Name = "lblTVel";
            this.lblTVel.Size = new global::System.Drawing.Size(41, 13);
            this.lblTVel.TabIndex = 5;
            this.lblTVel.Text = "TVel: 0";
            this.lblSJump.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.lblSJump.AutoSize = true;
            this.lblSJump.Location = new global::System.Drawing.Point(321, 511);
            this.lblSJump.Name = "lblSJump";
            this.lblSJump.Size = new global::System.Drawing.Size(51, 13);
            this.lblSJump.TabIndex = 5;
            this.lblSJump.Text = "SJump: 0";
            this.lblHurt.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.lblHurt.AutoSize = true;
            this.lblHurt.Location = new global::System.Drawing.Point(321, 524);
            this.lblHurt.Name = "lblHurt";
            this.lblHurt.Size = new global::System.Drawing.Size(39, 13);
            this.lblHurt.TabIndex = 5;
            this.lblHurt.Text = "Hurt: 0";
            this.lblMode.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new global::System.Drawing.Point(321, 537);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new global::System.Drawing.Size(60, 13);
            this.lblMode.TabIndex = 5;
            this.lblMode.Text = "Mode: land";
            this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.button1.Location = new global::System.Drawing.Point(438, 471);
            this.button1.Name = "button1";
            this.button1.Size = new global::System.Drawing.Size(96, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Record \"video\"";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new global::System.EventHandler(this.button1_Click);
            this.chkProp.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.chkProp.AutoSize = true;
            this.chkProp.Location = new global::System.Drawing.Point(6, 514);
            this.chkProp.Name = "chkProp";
            this.chkProp.Size = new global::System.Drawing.Size(48, 17);
            this.chkProp.TabIndex = 7;
            this.chkProp.Text = "Prop";
            this.chkProp.UseVisualStyleBackColor = true;
            this.chkProp.CheckedChanged += new global::System.EventHandler(this.chkHats_CheckedChanged);
            this.chkCrown.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.chkCrown.AutoSize = true;
            this.chkCrown.Location = new global::System.Drawing.Point(6, 533);
            this.chkCrown.Name = "chkCrown";
            this.chkCrown.Size = new global::System.Drawing.Size(56, 17);
            this.chkCrown.TabIndex = 7;
            this.chkCrown.Text = "Crown";
            this.chkCrown.UseVisualStyleBackColor = true;
            this.chkCrown.CheckedChanged += new global::System.EventHandler(this.chkHats_CheckedChanged);
            this.chkCowboy.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.chkCowboy.AutoSize = true;
            this.chkCowboy.Location = new global::System.Drawing.Point(60, 514);
            this.chkCowboy.Name = "chkCowboy";
            this.chkCowboy.Size = new global::System.Drawing.Size(64, 17);
            this.chkCowboy.TabIndex = 7;
            this.chkCowboy.Text = "Cowboy";
            this.chkCowboy.UseVisualStyleBackColor = true;
            this.chkCowboy.CheckedChanged += new global::System.EventHandler(this.chkHats_CheckedChanged);
            this.chkSanta.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.chkSanta.AutoSize = true;
            this.chkSanta.Location = new global::System.Drawing.Point(60, 533);
            this.chkSanta.Name = "chkSanta";
            this.chkSanta.Size = new global::System.Drawing.Size(54, 17);
            this.chkSanta.TabIndex = 7;
            this.chkSanta.Text = "Santa";
            this.chkSanta.UseVisualStyleBackColor = true;
            this.chkSanta.CheckedChanged += new global::System.EventHandler(this.chkHats_CheckedChanged);
            this.chkTop.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.chkTop.AutoSize = true;
            this.chkTop.Location = new global::System.Drawing.Point(121, 514);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new global::System.Drawing.Size(45, 17);
            this.chkTop.TabIndex = 7;
            this.chkTop.Text = "Top";
            this.chkTop.UseVisualStyleBackColor = true;
            this.chkTop.CheckedChanged += new global::System.EventHandler(this.chkHats_CheckedChanged);
            this.chkJump.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.chkJump.AutoSize = true;
            this.chkJump.Location = new global::System.Drawing.Point(121, 533);
            this.chkJump.Name = "chkJump";
            this.chkJump.Size = new global::System.Drawing.Size(51, 17);
            this.chkJump.TabIndex = 7;
            this.chkJump.Text = "Jump";
            this.chkJump.UseVisualStyleBackColor = true;
            this.chkJump.CheckedChanged += new global::System.EventHandler(this.chkHats_CheckedChanged);
            this.label14.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.label14.AutoSize = true;
            this.label14.Location = new global::System.Drawing.Point(3, 494);
            this.label14.Name = "label14";
            this.label14.Size = new global::System.Drawing.Size(64, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Target FPS:";
            this.fpsNum.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.fpsNum.Location = new global::System.Drawing.Point(73, 490);
            global::System.Windows.Forms.NumericUpDown numericUpDown22 = this.fpsNum;
            int[] array22 = new int[4];
            array22[0] = 1000;
            numericUpDown22.Maximum = new decimal(array22);
            global::System.Windows.Forms.NumericUpDown numericUpDown23 = this.fpsNum;
            int[] array23 = new int[4];
            array23[0] = 1;
            numericUpDown23.Minimum = new decimal(array23);
            this.fpsNum.Name = "fpsNum";
            this.fpsNum.Size = new global::System.Drawing.Size(53, 20);
            this.fpsNum.TabIndex = 9;
            global::System.Windows.Forms.NumericUpDown numericUpDown24 = this.fpsNum;
            int[] array24 = new int[4];
            array24[0] = 27;
            numericUpDown24.Value = new decimal(array24);
            this.fpsNum.ValueChanged += new global::System.EventHandler(this.fpsNum_ValueChanged);
            this.ghostBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.ghostBtn.Location = new global::System.Drawing.Point(461, 503);
            this.ghostBtn.Name = "ghostBtn";
            this.ghostBtn.Size = new global::System.Drawing.Size(73, 23);
            this.ghostBtn.TabIndex = 27;
            this.ghostBtn.Text = "Add Ghost";
            this.ghostBtn.UseVisualStyleBackColor = true;
            this.ghostBtn.Click += new global::System.EventHandler(this.ghostBtn_Click);
            this.removeGhostsBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.removeGhostsBtn.Location = new global::System.Drawing.Point(438, 529);
            this.removeGhostsBtn.Name = "removeGhostsBtn";
            this.removeGhostsBtn.Size = new global::System.Drawing.Size(96, 23);
            this.removeGhostsBtn.TabIndex = 27;
            this.removeGhostsBtn.Text = "Remove Ghosts";
            this.removeGhostsBtn.UseVisualStyleBackColor = true;
            this.removeGhostsBtn.Click += new global::System.EventHandler(this.removeGhostsBtn_Click);
            this.currentFPSLbl.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.currentFPSLbl.AutoSize = true;
            this.currentFPSLbl.Location = new global::System.Drawing.Point(132, 494);
            this.currentFPSLbl.Name = "currentFPSLbl";
            this.currentFPSLbl.Size = new global::System.Drawing.Size(39, 13);
            this.currentFPSLbl.TabIndex = 28;
            this.currentFPSLbl.Text = "FPS: 0";
            this.chkJigg.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.chkJigg.AutoSize = true;
            this.chkJigg.Enabled = false;
            this.chkJigg.Location = new global::System.Drawing.Point(172, 514);
            this.chkJigg.Name = "chkJigg";
            this.chkJigg.Size = new global::System.Drawing.Size(45, 17);
            this.chkJigg.TabIndex = 29;
            this.chkJigg.Text = "Jigg";
            this.chkJigg.UseVisualStyleBackColor = true;
            this.chkJigg.CheckedChanged += new global::System.EventHandler(this.chkHats_CheckedChanged);
            this.chkArti.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.chkArti.AutoSize = true;
            this.chkArti.Enabled = false;
            this.chkArti.Location = new global::System.Drawing.Point(172, 532);
            this.chkArti.Name = "chkArti";
            this.chkArti.Size = new global::System.Drawing.Size(41, 17);
            this.chkArti.TabIndex = 30;
            this.chkArti.Text = "Arti";
            this.chkArti.UseVisualStyleBackColor = true;
            this.chkArti.CheckedChanged += new global::System.EventHandler(this.chkHats_CheckedChanged);
            this.lblState.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
            this.lblState.AutoSize = true;
            this.lblState.Location = new global::System.Drawing.Point(321, 483);
            this.lblState.Name = "lblState";
            this.lblState.Size = new global::System.Drawing.Size(64, 13);
            this.lblState.TabIndex = 31;
            this.lblState.Text = "State: stand";
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new global::System.Drawing.Size(904, 561);
            base.Controls.Add(this.lblState);
            base.Controls.Add(this.chkArti);
            base.Controls.Add(this.chkJigg);
            base.Controls.Add(this.currentFPSLbl);
            base.Controls.Add(this.removeGhostsBtn);
            base.Controls.Add(this.ghostBtn);
            base.Controls.Add(this.fpsNum);
            base.Controls.Add(this.label14);
            base.Controls.Add(this.chkJump);
            base.Controls.Add(this.chkSanta);
            base.Controls.Add(this.chkCrown);
            base.Controls.Add(this.chkTop);
            base.Controls.Add(this.chkCowboy);
            base.Controls.Add(this.chkProp);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.lblPosY);
            base.Controls.Add(this.lblPosX);
            base.Controls.Add(this.lblVelY);
            base.Controls.Add(this.lblMode);
            base.Controls.Add(this.lblHurt);
            base.Controls.Add(this.lblSJump);
            base.Controls.Add(this.lblTVel);
            base.Controls.Add(this.lblVelX);
            base.Controls.Add(this.lblPause);
            base.Controls.Add(this.txtNoSelect);
            base.Controls.Add(this.tabControl1);
            base.Controls.Add(this.pnlGame);
            base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
            base.KeyPreview = true;
            this.MinimumSize = new global::System.Drawing.Size(755, 534);
            base.Name = "Form1";
            base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAS";
            base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            base.Load += new global::System.EventHandler(this.Form1_Load);
            base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            base.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            base.PreviewKeyDown += new global::System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabLevels.ResumeLayout(false);
            this.tabLevels.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)this.pageNum).EndInit();
            this.tabLevelData.ResumeLayout(false);
            this.tabLevelData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)this.numCowboyChance).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numMinLevel).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numGravity).EndInit();
            this.tabGameControls.ResumeLayout(false);
            this.tabGameControls.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)this.numSelectedPlayer).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numJump).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numAccel).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numSpeed).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numNextLast).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numFrame).EndInit();
            this.tabLE.ResumeLayout(false);
            this.tabSimple.ResumeLayout(false);
            this.tabSimple.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)this.numJump2).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numAccel2).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numSpeed2).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.fpsNum).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        // Token: 0x040000F0 RID: 240
        private global::System.ComponentModel.IContainer components;

        // Token: 0x040000F1 RID: 241
        private global::System.Windows.Forms.Panel pnlGame;

        // Token: 0x040000F2 RID: 242
        private global::System.Windows.Forms.TabControl tabControl1;

        // Token: 0x040000F3 RID: 243
        private global::System.Windows.Forms.TabPage tabLevels;

        // Token: 0x040000F4 RID: 244
        private global::System.Windows.Forms.Button btnLoadLevel;

        // Token: 0x040000F5 RID: 245
        private global::System.Windows.Forms.TabPage tabLevelData;

        // Token: 0x040000F6 RID: 246
        private global::System.Windows.Forms.RichTextBox txtNote;

        // Token: 0x040000F7 RID: 247
        private global::System.Windows.Forms.TextBox txtTitle;

        // Token: 0x040000F8 RID: 248
        private global::System.Windows.Forms.Label label2;

        // Token: 0x040000F9 RID: 249
        private global::System.Windows.Forms.Label label1;

        // Token: 0x040000FA RID: 250
        private global::System.Windows.Forms.TabPage tabGameControls;

        // Token: 0x040000FB RID: 251
        private global::System.Windows.Forms.Button btnPlay;

        // Token: 0x040000FC RID: 252
        private global::System.Windows.Forms.TextBox txtNoSelect;

        // Token: 0x040000FD RID: 253
        private global::System.Windows.Forms.NumericUpDown numGravity;

        // Token: 0x040000FE RID: 254
        private global::System.Windows.Forms.Label label4;

        // Token: 0x040000FF RID: 255
        private global::System.Windows.Forms.RichTextBox txtCredits;

        // Token: 0x04000100 RID: 256
        private global::System.Windows.Forms.Label label3;

        // Token: 0x04000101 RID: 257
        private global::System.Windows.Forms.GroupBox groupBox1;

        // Token: 0x04000102 RID: 258
        private global::System.Windows.Forms.CheckBox chkLaserGun;

        // Token: 0x04000103 RID: 259
        private global::System.Windows.Forms.CheckBox chkMine;

        // Token: 0x04000104 RID: 260
        private global::System.Windows.Forms.CheckBox chkLightning;

        // Token: 0x04000105 RID: 261
        private global::System.Windows.Forms.CheckBox chkTeleport;

        // Token: 0x04000106 RID: 262
        private global::System.Windows.Forms.CheckBox chkSuperJump;

        // Token: 0x04000107 RID: 263
        private global::System.Windows.Forms.CheckBox chkJetPack;

        // Token: 0x04000108 RID: 264
        private global::System.Windows.Forms.CheckBox chkSword;

        // Token: 0x04000109 RID: 265
        private global::System.Windows.Forms.CheckBox chkFreezeRay;

        // Token: 0x0400010A RID: 266
        private global::System.Windows.Forms.CheckBox chkSpeedy;

        // Token: 0x0400010B RID: 267
        private global::System.Windows.Forms.ComboBox cmbMusic;

        // Token: 0x0400010C RID: 268
        private global::System.Windows.Forms.Label label5;

        // Token: 0x0400010D RID: 269
        private global::System.Windows.Forms.NumericUpDown numMinLevel;

        // Token: 0x0400010E RID: 270
        private global::System.Windows.Forms.Label label6;

        // Token: 0x0400010F RID: 271
        private global::System.Windows.Forms.ComboBox cmbGameMode;

        // Token: 0x04000110 RID: 272
        private global::System.Windows.Forms.Label label7;

        // Token: 0x04000111 RID: 273
        private global::System.Windows.Forms.NumericUpDown numCowboyChance;

        // Token: 0x04000112 RID: 274
        private global::System.Windows.Forms.Label label8;

        // Token: 0x04000113 RID: 275
        private global::System.Windows.Forms.CheckBox chkSpace;

        // Token: 0x04000114 RID: 276
        private global::System.Windows.Forms.CheckBox chkRight;

        // Token: 0x04000115 RID: 277
        private global::System.Windows.Forms.CheckBox chkLeft;

        // Token: 0x04000116 RID: 278
        private global::System.Windows.Forms.CheckBox chkDown;

        // Token: 0x04000117 RID: 279
        private global::System.Windows.Forms.CheckBox chkUp;

        // Token: 0x04000118 RID: 280
        private global::System.Windows.Forms.NumericUpDown numFrame;

        // Token: 0x04000119 RID: 281
        private global::System.Windows.Forms.Label label9;

        // Token: 0x0400011A RID: 282
        private global::System.Windows.Forms.Label lblSS;

        // Token: 0x0400011B RID: 283
        private global::System.Windows.Forms.NumericUpDown numNextLast;

        // Token: 0x0400011C RID: 284
        private global::System.Windows.Forms.RadioButton rdoNext;

        // Token: 0x0400011D RID: 285
        private global::System.Windows.Forms.RadioButton rdoLast;

        // Token: 0x0400011E RID: 286
        private global::System.Windows.Forms.Button btnSetNextTo;

        // Token: 0x0400011F RID: 287
        private global::System.Windows.Forms.Label lblFrames;

        // Token: 0x04000120 RID: 288
        private global::System.Windows.Forms.CheckBox chkLoadSS;

        // Token: 0x04000121 RID: 289
        private global::System.Windows.Forms.Button btnLoadRec;

        // Token: 0x04000122 RID: 290
        private global::System.Windows.Forms.Button btnSaveRec;

        // Token: 0x04000123 RID: 291
        private global::System.Windows.Forms.Button btnPlayRec;

        // Token: 0x04000124 RID: 292
        private global::System.Windows.Forms.NumericUpDown numJump;

        // Token: 0x04000125 RID: 293
        private global::System.Windows.Forms.NumericUpDown numAccel;

        // Token: 0x04000126 RID: 294
        private global::System.Windows.Forms.NumericUpDown numSpeed;

        // Token: 0x04000127 RID: 295
        private global::System.Windows.Forms.Button btnSetStats;

        // Token: 0x04000128 RID: 296
        private global::System.Windows.Forms.Button btnSetRecSS;

        // Token: 0x04000129 RID: 297
        private global::System.Windows.Forms.Label lblPause;

        // Token: 0x0400012A RID: 298
        private global::System.Windows.Forms.Button btnCurrentFrame;

        // Token: 0x0400012B RID: 299
        private global::System.Windows.Forms.Button btnInsertFrame;

        // Token: 0x0400012C RID: 300
        private global::System.Windows.Forms.Button btnDeleteFrame;

        // Token: 0x0400012D RID: 301
        private global::System.Windows.Forms.CheckBox chkx10;

        // Token: 0x0400012E RID: 302
        private global::System.Windows.Forms.CheckBox chkCopy;

        // Token: 0x0400012F RID: 303
        private global::System.Windows.Forms.Label lblTotalStats;

        // Token: 0x04000130 RID: 304
        private global::System.Windows.Forms.Label lblVelX;

        // Token: 0x04000131 RID: 305
        private global::System.Windows.Forms.Label lblVelY;

        // Token: 0x04000132 RID: 306
        private global::System.Windows.Forms.Label lblPosX;

        // Token: 0x04000133 RID: 307
        private global::System.Windows.Forms.Label lblPosY;

        // Token: 0x04000134 RID: 308
        private global::System.Windows.Forms.Label lblTVel;

        // Token: 0x04000135 RID: 309
        private global::System.Windows.Forms.Label lblSJump;

        // Token: 0x04000136 RID: 310
        private global::System.Windows.Forms.Label lblHurt;

        // Token: 0x04000137 RID: 311
        private global::System.Windows.Forms.Label lblMode;

        // Token: 0x04000138 RID: 312
        private global::System.Windows.Forms.Button btnPartial;

        // Token: 0x04000139 RID: 313
        private global::System.Windows.Forms.Button button1;

        // Token: 0x0400013A RID: 314
        private global::System.Windows.Forms.CheckBox chkProp;

        // Token: 0x0400013B RID: 315
        private global::System.Windows.Forms.CheckBox chkCrown;

        // Token: 0x0400013C RID: 316
        private global::System.Windows.Forms.CheckBox chkCowboy;

        // Token: 0x0400013D RID: 317
        private global::System.Windows.Forms.CheckBox chkSanta;

        // Token: 0x0400013E RID: 318
        private global::System.Windows.Forms.CheckBox chkTop;

        // Token: 0x0400013F RID: 319
        private global::System.Windows.Forms.CheckBox chkJump;

        // Token: 0x04000140 RID: 320
        private global::System.Windows.Forms.Label lblPlayers;

        // Token: 0x04000141 RID: 321
        private global::System.Windows.Forms.Button btnAddPlayer;

        // Token: 0x04000142 RID: 322
        private global::System.Windows.Forms.Label label10;

        // Token: 0x04000143 RID: 323
        private global::System.Windows.Forms.NumericUpDown numSelectedPlayer;

        // Token: 0x04000144 RID: 324
        private global::System.Windows.Forms.Label lblRecStatus;

        // Token: 0x04000145 RID: 325
        private global::System.Windows.Forms.CheckBox ascBox;

        // Token: 0x04000146 RID: 326
        private global::System.Windows.Forms.ComboBox orderBox;

        // Token: 0x04000147 RID: 327
        private global::System.Windows.Forms.ComboBox modeBox;

        // Token: 0x04000148 RID: 328
        private global::System.Windows.Forms.NumericUpDown pageNum;

        // Token: 0x04000149 RID: 329
        private global::System.Windows.Forms.Label label12;

        // Token: 0x0400014A RID: 330
        private global::System.Windows.Forms.Label label11;

        // Token: 0x0400014B RID: 331
        private global::System.Windows.Forms.TextBox searchBox;

        // Token: 0x0400014C RID: 332
        private global::System.Windows.Forms.Button myLevelsButton;

        // Token: 0x0400014D RID: 333
        private global::System.Windows.Forms.Button searchBtn;

        // Token: 0x0400014E RID: 334
        private global::System.Windows.Forms.ListBox levelsList;

        // Token: 0x0400014F RID: 335
        private global::System.Windows.Forms.Label userLbl;

        // Token: 0x04000150 RID: 336
        private global::System.Windows.Forms.RichTextBox noteBox;

        // Token: 0x04000151 RID: 337
        private global::System.Windows.Forms.Label label13;

        // Token: 0x04000152 RID: 338
        private global::System.Windows.Forms.Label ratingLbl;

        // Token: 0x04000153 RID: 339
        private global::System.Windows.Forms.Label versionLbl;

        // Token: 0x04000154 RID: 340
        private global::System.Windows.Forms.Label typeLbl;

        // Token: 0x04000155 RID: 341
        private global::System.Windows.Forms.Label minRankLbl;

        // Token: 0x04000156 RID: 342
        private global::System.Windows.Forms.Label playsLbl;

        // Token: 0x04000157 RID: 343
        private global::System.Windows.Forms.Label hasPassLbl;

        // Token: 0x04000158 RID: 344
        private global::System.Windows.Forms.Label levelIDLbl;

        // Token: 0x04000159 RID: 345
        private global::System.Windows.Forms.Button tokenBtn;

        // Token: 0x0400015A RID: 346
        private global::System.Windows.Forms.Button loadLevelBtn;

        // Token: 0x0400015B RID: 347
        private global::System.Windows.Forms.Label label14;

        // Token: 0x0400015C RID: 348
        private global::System.Windows.Forms.NumericUpDown fpsNum;

        // Token: 0x0400015D RID: 349
        private global::System.Windows.Forms.Button ghostBtn;

        // Token: 0x0400015E RID: 350
        private global::System.Windows.Forms.Button removeGhostsBtn;

        // Token: 0x0400015F RID: 351
        private global::System.Windows.Forms.Label currentFPSLbl;

        // Token: 0x04000160 RID: 352
        private global::System.Windows.Forms.Label tournamentBth;

        // Token: 0x04000161 RID: 353
        private global::System.Windows.Forms.Button uploadBtn;

        // Token: 0x04000162 RID: 354
        private global::System.Windows.Forms.CheckBox chkLive;

        // Token: 0x04000163 RID: 355
        private global::System.Windows.Forms.TabPage tabLE;

        // Token: 0x04000164 RID: 356
        private global::System.Windows.Forms.ListView listViewBlocks;

        // Token: 0x04000165 RID: 357
        private global::System.Windows.Forms.ColumnHeader colHdrBlock;

        // Token: 0x04000166 RID: 358
        private global::System.Windows.Forms.ImageList imageListBlocks;

        // Token: 0x04000167 RID: 359
        private global::System.Windows.Forms.LinkLabel linkLabelToggleItems;

        // Token: 0x04000168 RID: 360
        private global::System.Windows.Forms.CheckBox chkJigg;

        // Token: 0x04000169 RID: 361
        private global::System.Windows.Forms.CheckBox chkArti;

        // Token: 0x0400016A RID: 362
        private global::System.Windows.Forms.Label lblState;

        // Token: 0x0400016B RID: 363
        private global::System.Windows.Forms.Button buttonSaveToFile;

        // Token: 0x0400016C RID: 364
        private global::System.Windows.Forms.Button buttonLoadRace;

        // Token: 0x0400016D RID: 365
        private global::System.Windows.Forms.TabPage tabSimple;

        // Token: 0x0400016E RID: 366
        private global::System.Windows.Forms.NumericUpDown numJump2;

        // Token: 0x0400016F RID: 367
        private global::System.Windows.Forms.NumericUpDown numAccel2;

        // Token: 0x04000170 RID: 368
        private global::System.Windows.Forms.NumericUpDown numSpeed2;

        // Token: 0x04000171 RID: 369
        private global::System.Windows.Forms.Button btnSetStats2;

        // Token: 0x04000172 RID: 370
        private global::System.Windows.Forms.Label lblSS2;

        // Token: 0x04000173 RID: 371
        private global::System.Windows.Forms.Button btnRetart;

        private global::System.Windows.Forms.Label label24;


        // Token: 0x04000174 RID: 372
        private global::System.Windows.Forms.Label label23;

        // Token: 0x04000175 RID: 373
        private global::System.Windows.Forms.Label label22;

        // Token: 0x04000176 RID: 374
        private global::System.Windows.Forms.Label label20;

        // Token: 0x04000177 RID: 375
        private global::System.Windows.Forms.Label label19;

        // Token: 0x04000178 RID: 376
        private global::System.Windows.Forms.Label label18;

        // Token: 0x04000179 RID: 377
        private global::System.Windows.Forms.Label label17;

        // Token: 0x0400017A RID: 378
        private global::System.Windows.Forms.Label label16;

        // Token: 0x0400017B RID: 379
        private global::System.Windows.Forms.Label label15;

        // Token: 0x0400017C RID: 380
        private global::System.Windows.Forms.Button button2;
    }
}
