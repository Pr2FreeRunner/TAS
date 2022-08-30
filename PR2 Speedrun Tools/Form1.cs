using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PR2_Speedrun_Tools
{
    // Token: 0x0200000B RID: 11
    public partial class Form1 : Form
    {
        // Token: 0x1700000D RID: 13
        // (get) Token: 0x06000098 RID: 152 RVA: 0x00009EEB File Offset: 0x000080EB
        // (set) Token: 0x06000099 RID: 153 RVA: 0x00009EF7 File Offset: 0x000080F7
        private string RecordingsPath
        {
            get
            {
                return General.Settings.RecordingsPath;
            }
            set
            {
                General.Settings.RecordingsPath = value;
                General.Settings.Save();
            }
        }

        // Token: 0x1700000E RID: 14
        // (get) Token: 0x0600009A RID: 154 RVA: 0x00009F0E File Offset: 0x0000810E
        // (set) Token: 0x0600009B RID: 155 RVA: 0x00009F1A File Offset: 0x0000811A
        private string LevelsPath
        {
            get
            {
                return General.Settings.LevelsPath;
            }
            set
            {
                General.Settings.LevelsPath = value;
                General.Settings.Save();
            }
        }

        // Token: 0x1700000F RID: 15
        // (get) Token: 0x0600009C RID: 156 RVA: 0x00009F31 File Offset: 0x00008131
        // (set) Token: 0x0600009D RID: 157 RVA: 0x00009F3D File Offset: 0x0000813D
        private string SavestatesPath
        {
            get
            {
                return General.Settings.SavestatesPath;
            }
            set
            {
                General.Settings.SavestatesPath = value;
                General.Settings.Save();
            }
        }

        // Token: 0x0600009E RID: 158 RVA: 0x00009F54 File Offset: 0x00008154
        public Form1()
        {
            this.InitializeComponent();
            SetIcon();
        }

        private void SetIcon()
        {
            try
            {
                var folder   = Directory.GetCurrentDirectory();
                var filepath = Path.Combine(folder, "Resources", "MyIcon.ico");

                if (File.Exists(filepath)) 
                    this.Icon = Icon.ExtractAssociatedIcon(filepath);
            }
            catch { } //ignore as its not important
        }
        // Token: 0x0600009F RID: 159 RVA: 0x00009F8A File Offset: 0x0000818A
        private void ResetPaths()
        {
            this.RecordingsPath = "";
            this.LevelsPath = "";
        }

        // Token: 0x17000010 RID: 16
        // (get) Token: 0x060000A0 RID: 160 RVA: 0x00009FA2 File Offset: 0x000081A2
        // (set) Token: 0x060000A1 RID: 161 RVA: 0x00009FAF File Offset: 0x000081AF
        private Map theMap
        {
            get
            {
                return this.game.map;
            }
            set
            {
                this.game.map = value;
            }
        }

        // Token: 0x17000011 RID: 17
        // (get) Token: 0x060000A2 RID: 162 RVA: 0x00009FBD File Offset: 0x000081BD
        // (set) Token: 0x060000A3 RID: 163 RVA: 0x00009FD5 File Offset: 0x000081D5
        private LocalCharacter You
        {
            get
            {
                return this.game.Players[this.SelectedPlayer];
            }
            set
            {
                this.game.Players[this.SelectedPlayer] = value;
            }
        }

        // Token: 0x060000A4 RID: 164 RVA: 0x00009FF0 File Offset: 0x000081F0
        private void ToggleView(bool simpleView)
        {
            InputArgs.SimpleView = simpleView;
            if (simpleView)
            {
                this.tabControl1.TabPages.Remove(this.tabLevels);
                this.tabControl1.TabPages.Remove(this.tabLevelData);
                this.tabControl1.TabPages.Remove(this.tabGameControls);
                this.tabControl1.TabPages.Remove(this.tabLE);
                this.tabControl1.TabPages.Remove(this.tabSimple);
                this.tabControl1.TabPages.Add(this.tabSimple);
            }
            else
            {
                this.tabControl1.TabPages.Remove(this.tabLE);
                this.tabControl1.TabPages.Remove(this.tabLevels);
                this.tabControl1.TabPages.Remove(this.tabLevelData);
                this.tabControl1.TabPages.Remove(this.tabGameControls);
                this.tabControl1.TabPages.Remove(this.tabSimple);
                this.tabControl1.TabPages.Add(this.tabLevels);
                this.tabControl1.TabPages.Add(this.tabLevelData);
                this.tabControl1.TabPages.Add(this.tabLE);
                this.tabControl1.TabPages.Add(this.tabGameControls);
            }
            this.label14.Visible = !this.label14.Visible;
            this.lblPause.Visible = !this.lblPause.Visible;
            this.fpsNum.Visible = !this.fpsNum.Visible;
            this.currentFPSLbl.Visible = !this.currentFPSLbl.Visible;
            this.button1.Visible = !this.button1.Visible;
            this.ghostBtn.Visible = !this.ghostBtn.Visible;
            this.removeGhostsBtn.Visible = !this.removeGhostsBtn.Visible;
            this.tabSimple.Visible = !this.tabSimple.Visible;
        }

        // Token: 0x060000A5 RID: 165 RVA: 0x0000A220 File Offset: 0x00008420
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.ToggleView(InputArgs.SimpleView);
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                General.FormRef = this;
                this.game = new Game_ART(this.pnlGame.Width, this.pnlGame.Height);
                if (General.Settings.SelectedUser == -1)
                {
                    this.You.Name = "Player";
                }
                else
                {
                    this.You.Name = General.Settings.Users[General.Settings.SelectedUser];
                    this.theMap.userName = this.You.Name;
                    this.username = this.You.Name;
                    this.login_token = General.Settings.Tokens[General.Settings.SelectedUser];
                }
                this.pnlGame.BackgroundImage = this.game.img.Bit;
                this.game.FinishDrawing += this.drawGame;
                this.game.endFrame += this.endOfFrame;
                this.chkItems = new CheckBox[]
                {
                this.chkLaserGun,
                this.chkMine,
                this.chkLightning,
                this.chkTeleport,
                this.chkSuperJump,
                this.chkJetPack,
                this.chkSpeedy,
                this.chkSword,
                this.chkFreezeRay
                };
                this.chkHats = new CheckBox[]
                {
                null,
                null,
                null,
                null,
                this.chkProp,
                this.chkCowboy,
                this.chkCrown,
                this.chkSanta,
                null,
                this.chkTop,
                this.chkJump,
                null,
                null,
                this.chkJigg,
                this.chkArti
                };
                for (int i = 0; i < this.chkItems.Length; i++)
                {
                    this.chkItems[i].Tag = i + 1;
                }
                this.chkInput = new CheckBox[]
                {
                this.chkSpace,
                this.chkLeft,
                this.chkRight,
                this.chkUp,
                this.chkDown
                };
                for (int j = 0; j < this.chkInput.Length; j++)
                {
                    this.chkInput[j].Tag = j;
                }
                for (int k = 0; k < this.chkHats.Length; k++)
                {
                    if (this.chkHats[k] != null)
                    {
                        this.chkHats[k].Tag = k;
                    }
                }
                this.orderBox.SelectedIndex = 0;
                this.modeBox.SelectedIndex = 0;
                this.loaded = true;
                if (!string.IsNullOrWhiteSpace(InputArgs.LevelFilepath))
                {
                    this.LoadLevel(InputArgs.LevelFilepath);
                    this.btnSetStats_Click(null, null);
                    this.btnPlay_Click(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Token: 0x060000A6 RID: 166 RVA: 0x0000A4FD File Offset: 0x000086FD
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.game.Dispose();
        }

        // Token: 0x060000A7 RID: 167 RVA: 0x0000A50C File Offset: 0x0000870C
        private void pnlGame_Resize(object sender, EventArgs e)
        {
            if (!this.loaded || this.pnlGame.Width == 0)
            {
                return;
            }
            this.game.Resize(this.pnlGame.Width, this.pnlGame.Height);
            this.pnlGame.BackgroundImage = this.game.img.Bit;
        }

        // Token: 0x060000A8 RID: 168 RVA: 0x0000A56B File Offset: 0x0000876B
        private void drawGame()
        {
            this.pnlGame.SuspendLayout();
            this.pnlGame.CreateGraphics().DrawImage(this.pnlGame.BackgroundImage, 0, 0);
            this.pnlGame.ResumeLayout();
        }

        // Token: 0x060000A9 RID: 169 RVA: 0x0000A5A0 File Offset: 0x000087A0
        private void endOfFrame()
        {
            if (this.cChannel.Frames != 0)
            {
                if (this.numFrame.Value > this.cChannel.Frames - 1)
                {
                    this.numFrame.Value = this.cChannel.Frames - 1;
                }
                this.numFrame.Maximum = this.cChannel.Frames - 1;
            }
            this.DisplayInfos();
            if (this.recordingVideo)
            {
                this.recordingFrame++;
                this.game.img.Bit.Save(this.recordingPath + "\\img" + this.recordingFrame.ToString().PadLeft(5, '0') + ".png");
            }
        }

        // Token: 0x060000AA RID: 170 RVA: 0x0000A674 File Offset: 0x00008874
        private void DisplayInfos()
        {
            this.lblVelX.Text = "VelX: " + General.FormatNumber(Math.Round(this.You.velX, 2), 2, 0);
            this.lblVelY.Text = "VelY: " + General.FormatNumber(Math.Round(this.You.velY, 2), 2, 0);
            double num = Math.Round(this.You.X, 2);
            num -= Math.Floor(num / 30.0) * 30.0;
            double num2 = Math.Round(this.You.Y, 2);
            num2 -= Math.Floor(num2 / 30.0) * 30.0;
            this.lblPosX.Text = "PosX: " + General.FormatNumber(Math.Round(num, 2), 2, 0);
            this.lblPosY.Text = "PosY: " + General.FormatNumber(Math.Round(num2, 2), 2, 0);
            this.lblTVel.Text = "TVel: " + General.FormatNumber(Math.Round(this.You.TargetVel, 2), 2, 0);
            this.lblSJump.Text = "SJump: " + General.FormatNumber((double)this.You.SuperJumpVel, 0, 0);
            this.lblHurt.Text = "Hurt: " + General.FormatNumber((double)this.You.HurtTimer, 0, 0);
            this.lblMode.Text = "Mode: " + this.You.Mode;
            this.lblState.Text = "State: " + this.You.State;
            this.numSpeed.Value = this.You.SpStat;
            this.numAccel.Value = this.You.AccStat;
            this.numJump.Value = this.You.JumpStat;
            this.numSpeed2.Value = this.You.SpStat;
            this.numAccel2.Value = this.You.AccStat;
            this.numJump2.Value = this.You.JumpStat;
            this.lblFrames.Text = this.cChannel.Frames.ToString();
            this.currentFPSLbl.Text = General.FormatNumber(Math.Round(this.game.currentFPS, 2), 2, 0);
        }

        // Token: 0x060000AB RID: 171 RVA: 0x0000A91F File Offset: 0x00008B1F
        private void LoadLevel(string filepath)
        {
            this.theMap.enterLE();
            this.theMap.LoadLevel(File.ReadAllText(filepath));
            this.UpdateLevelInfo();
            this.LevelsPath = Directory.GetParent(filepath).FullName;
        }

        // Token: 0x060000AC RID: 172 RVA: 0x0000A954 File Offset: 0x00008B54
        private void btnLoadLevel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = this.LevelsPath;
                if (openFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    this.LoadLevel(openFileDialog.FileName);
                }
            }
        }

        // Token: 0x060000AD RID: 173 RVA: 0x0000A9A8 File Offset: 0x00008BA8
        private void UpdateLevelInfo()
        {
            this.manual = false;
            this.txtTitle.Text = this.theMap.Title;
            this.txtNote.Text = this.theMap.note;
            this.txtCredits.Text = this.theMap.credits;
            this.numGravity.Value = (decimal)this.theMap.Gravity;
            this.numCowboyChance.Value = this.theMap.cowboyChance;
            this.cmbMusic.SelectedIndex = this.theMap.song;
            this.cmbGameMode.Text = this.theMap.gameMode;
            for (int i = 0; i < this.chkItems.Length; i++)
            {
                this.chkItems[i].Checked = this.theMap.avItems.Contains(i + 1);
            }
            if (this.theMap.live == 1)
            {
                this.chkLive.CheckState = CheckState.Checked;
            }
            else if (this.theMap.hasPass)
            {
                this.chkLive.CheckState = CheckState.Indeterminate;
            }
            else
            {
                this.chkLive.CheckState = CheckState.Unchecked;
            }
            this.manual = true;
        }

        // Token: 0x17000012 RID: 18
        // (get) Token: 0x060000AE RID: 174 RVA: 0x0000AADD File Offset: 0x00008CDD
        private RecordedChannel cChannel
        {
            get
            {
                return this.game.recording.channels[this.SelectedPlayer];
            }
        }

        // Token: 0x060000AF RID: 175 RVA: 0x0000AAFC File Offset: 0x00008CFC
        private void btnLoadRec_Click(object sender, EventArgs e)
        {
            this.PauseGame();
            this.lblPause.Text = "Paused for Rec";
            if (this.game.isPlayingRec)
            {
                this.btnPlayRec_Click(null, null);
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = this.RecordingsPath;
                if (openFileDialog.ShowDialog() == DialogResult.Cancel || openFileDialog.FileName == "")
                {
                    return;
                }
                this.game.recording = new Recording(openFileDialog.FileName);
                this.RecordingsPath = Directory.GetParent(openFileDialog.FileName).FullName;
                string text = this.RecordingsPath + "\\States\\" + openFileDialog.SafeFileName;
                if (File.Exists(text))
                {
                    this.game.recording.SS = new SaveState(text, false);
                }
                this.lblRecStatus.Text = "Loaded: " + openFileDialog.SafeFileName;
            }
            this.numFrame.Maximum = this.cChannel.Frames - 1;
        }

        // Token: 0x060000B0 RID: 176 RVA: 0x0000AC1C File Offset: 0x00008E1C
        private void btnSaveRec_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = this.RecordingsPath;
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel || saveFileDialog.FileName == "")
                {
                    return;
                }
                this.game.recording.Save(saveFileDialog.FileName);
                DirectoryInfo directoryInfo = new DirectoryInfo(saveFileDialog.FileName);
                this.RecordingsPath = directoryInfo.Parent.FullName;
                if (this.game.recording.SS != null)
                {
                    this.game.recording.SS.Save(directoryInfo.Parent.FullName + "\\States\\" + directoryInfo.Name);
                }
            }
            this.lblRecStatus.Text = "Saved Recording";
        }

        // Token: 0x060000B1 RID: 177 RVA: 0x0000ACFC File Offset: 0x00008EFC
        private void btnSetRecSS_Click(object sender, EventArgs e)
        {
            this.game.recording.SS = new SaveState(this.game);
            this.lblRecStatus.Text = "SS Set";
        }

        // Token: 0x060000B2 RID: 178 RVA: 0x0000AD2C File Offset: 0x00008F2C
        private void btnPlayRec_Click(object sender, EventArgs e)
        {
            if (this.game.isPlayingRec)
            {
                this.game.StopPlayback();
                this.btnPlayRec.Text = "Play Rec";
                this.lblRecStatus.Text = "Recording Input";
                return;
            }
            this.game.PlayRecording(this.chkLoadSS.Checked);
            this.btnPlayRec.Text = "Stop Rec";
            this.lblRecStatus.Text = "Playing Recording";
        }

        // Token: 0x060000B3 RID: 179 RVA: 0x0000ADA8 File Offset: 0x00008FA8
        private void btnCurrentFrame_Click(object sender, EventArgs e)
        {
            int value = this.game.RecFrame;
            if (value > this.numFrame.Maximum)
            {
                value = (int)this.numFrame.Maximum;
            }
            this.numFrame.Value = value;
            this.numFrame_ValueChanged(this.numFrame, e);
            this.txtNoSelect.Select();
        }

        // Token: 0x060000B4 RID: 180 RVA: 0x0000AE14 File Offset: 0x00009014
        private void btnDeleteFrame_Click(object sender, EventArgs e)
        {
            if (this.chkx10.Checked)
            {
                if (this.numFrame.Value >= this.cChannel.Frames - 10)
                {
                    MessageBox.Show("There are not 10 frames to delete.");
                    return;
                }
                this.cChannel._Keys.RemoveRange((int)this.numFrame.Value, 10);
            }
            else
            {
                this.cChannel._Keys.RemoveAt((int)this.numFrame.Value);
            }
            if (this.numFrame.Value >= this.cChannel.Frames)
            {
                this.numFrame.Value = this.cChannel.Frames - 1;
            }
            this.numFrame.Maximum = this.cChannel.Frames - 1;
            this.lblFrames.Text = this.cChannel.Frames.ToString();
            this.numFrame_ValueChanged(this.numFrame, e);
            this.txtNoSelect.Select();
        }

        // Token: 0x060000B5 RID: 181 RVA: 0x0000AF38 File Offset: 0x00009138
        private void btnInsertFrame_Click(object sender, EventArgs e)
        {
            byte item = 0;
            if (this.chkCopy.Checked)
            {
                item = this.cChannel._Keys[(int)this.numFrame.Value];
            }
            this.cChannel._Keys.Insert((int)this.numFrame.Value, item);
            if (this.chkx10.Checked)
            {
                for (int i = 0; i < 9; i++)
                {
                    this.cChannel._Keys.Insert((int)this.numFrame.Value, item);
                }
            }
            this.lblFrames.Text = this.cChannel.Frames.ToString();
            this.numFrame_ValueChanged(this.numFrame, e);
            this.txtNoSelect.Select();
        }

        // Token: 0x060000B6 RID: 182 RVA: 0x0000B008 File Offset: 0x00009208
        private void btnSetNextTo_Click(object sender, EventArgs e)
        {
            RecordedFrame frame = this.cChannel.GetFrame((int)this.numFrame.Value);
            int num = (int)this.numFrame.Value;
            int num2 = (int)this.numFrame.Value;
            if (this.rdoNext.Checked)
            {
                num2 += (int)this.numNextLast.Value + 1;
            }
            else
            {
                num -= (int)this.numNextLast.Value;
            }
            if (num < 0)
            {
                num = 0;
            }
            if (num2 >= this.cChannel.Frames)
            {
                num2 = this.cChannel.Frames - 1;
            }
            for (int i = num; i < num2; i++)
            {
                for (byte b = 0; b < 5; b += 1)
                {
                    if (this.chkInput[(int)b].ForeColor.R == 0)
                    {
                        RecordedFrame frame2 = this.cChannel.GetFrame(i);
                        frame2.SetButton(b, frame.GetButton(b));
                        this.cChannel.SetFrame(frame2, i);
                    }
                }
            }
            this.txtNoSelect.Select();
        }

        // Token: 0x060000B7 RID: 183 RVA: 0x0000B11C File Offset: 0x0000931C
        private void chkInput_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.manual)
            {
                return;
            }
            RecordedFrame frame = this.cChannel.GetFrame((int)this.numFrame.Value);
            frame.up = this.chkUp.Checked;
            frame.down = this.chkDown.Checked;
            frame.left = this.chkLeft.Checked;
            frame.right = this.chkRight.Checked;
            frame.space = this.chkSpace.Checked;
            this.cChannel._Keys[(int)this.numFrame.Value] = frame.kValue;
            this.txtNoSelect.Select();
        }

        // Token: 0x060000B8 RID: 184 RVA: 0x0000B1D4 File Offset: 0x000093D4
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (this.theMap.inLE)
            {
                this.theMap.exitLE(true);
                this.game.ReDraw();
                this.game.BeginRecording();
                this.DisplayInfos();
                this.btnPlay.Text = "Stop Level";
                this.PauseGame();
            }
            else
            {
                this.theMap.enterLE();
                this.btnPlay.Text = "Play Level";
                this.PlayGame();
                this.lblPause.Text = "Game Paused";
            }
            this.txtNoSelect.Select();
        }

        // Token: 0x060000B9 RID: 185 RVA: 0x0000B26C File Offset: 0x0000946C
        private void PauseGame()
        {
            this.game.paused = true;
            this.lblPause.Text = "Game Paused";
            this.btnSetStats2.Enabled = true;
            this.numSpeed2.Enabled = true;
            this.numAccel2.Enabled = true;
            this.numJump2.Enabled = true;
        }

        // Token: 0x060000BA RID: 186 RVA: 0x0000B2C8 File Offset: 0x000094C8
        private void PlayGame()
        {
            this.game.paused = false;
            this.lblPause.Text = "Game Running";
            this.btnSetStats2.Enabled = false;
            this.numSpeed2.Enabled = false;
            this.numAccel2.Enabled = false;
            this.numJump2.Enabled = false;
        }

        // Token: 0x060000BB RID: 187 RVA: 0x0000B321 File Offset: 0x00009521
        public void TogglePlayPause()
        {
            if (this.game.paused)
            {
                this.PlayGame();
                return;
            }
            this.PauseGame();
        }

        // Token: 0x060000BC RID: 188 RVA: 0x0000B340 File Offset: 0x00009540
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.txtNoSelect.Select();
                e.SuppressKeyPress = true;
            }
            if (base.ActiveControl != this.pnlGame && base.ActiveControl != this.txtNoSelect)
            {
                return;
            }
            if (e.KeyCode == Keys.A)
            {
                this.TogglePlayPause();
            }
            else if(e.KeyCode == Keys.R)
            {
                btnRetart_Click(null, null);
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.D)
            {
                this.PauseGame();
                this.game.FrameForward();
                this.lblPause.Text = "Frame Forward";
            }
            else if (e.KeyCode == Keys.Z)
            {
                this.theMap.CamX = (int)(this.You.X - (double)this.theMap.Image.Width * 0.5);
                this.theMap.CamY = (int)(this.You.Y - (double)this.theMap.Image.Height * 0.5);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                this.game.targetFPS = 9999.0;
            }
            else if (e.KeyCode >= Keys.D1 && e.KeyCode <= Keys.D9)
            {
                this.curSS = e.KeyCode - Keys.D0;
                this.lblSS.Text = (this.lblSS2.Text = "SS " + this.curSS.ToString() + " selected");
            }
            else if (e.KeyCode == Keys.D0)
            {
                this.curSS = 0;
                this.lblSS.Text = (this.lblSS2.Text = "No SS selected");
            }
            if (this.curSS != 0)
            {
                if (e.KeyCode == Keys.U)
                {
                    new SaveState(this.game).Save(this.SavestatesPath + "\\" + this.curSS.ToString());
                    this.lblSS.Text = (this.lblSS2.Text = "Saved to slot " + this.curSS.ToString());
                }
                else if (e.KeyCode == Keys.P)
                {
                    if (File.Exists(this.SavestatesPath + "\\" + this.curSS.ToString()))
                    {
                        new SaveState(this.SavestatesPath + "\\" + this.curSS.ToString(), false).Use(this.game);
                        this.numSelectedPlayer.Maximum = this.game.Players.Count;
                        this.lblPlayers.Text = this.game.Players.Count.ToString();
                        this.endOfFrame();
                        this.lblSS.Text = (this.lblSS2.Text = "Loaded from slot " + this.curSS.ToString());
                        this.game.DrawFrame();
                        this.UpdateLevelInfo();
                    }
                    else
                    {
                        this.lblSS.Text = (this.lblSS2.Text = "Slot " + this.curSS.ToString() + " is empty.");
                    }
                }
            }
            if (this.theMap.inLE && base.ActiveControl == this.txtNoSelect)
            {
                if (e.KeyCode == Keys.Left)
                {
                    this.theMap.CamX -= 30;
                    return;
                }
                if (e.KeyCode == Keys.Right)
                {
                    this.theMap.CamX += 30;
                    return;
                }
                if (e.KeyCode == Keys.Up)
                {
                    this.theMap.CamY -= 30;
                    return;
                }
                if (e.KeyCode == Keys.Down)
                {
                    this.theMap.CamY += 30;
                    return;
                }
            }
            else
            {
                RecordedFrame recordedFrame = new RecordedFrame(this.You.nextInput.kValue);
                if (e.KeyCode == Keys.Left)
                {
                    recordedFrame.left = true;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    recordedFrame.right = true;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    recordedFrame.up = true;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    recordedFrame.down = true;
                }
                else if (e.KeyCode == Keys.Space)
                {
                    recordedFrame.space = true;
                }
                if (recordedFrame.kValue != this.You.nextInput.kValue)
                {
                    this.game.SetInput(recordedFrame, this.SelectedPlayer);
                }
            }
        }

        // Token: 0x060000BD RID: 189 RVA: 0x0000B7BC File Offset: 0x000099BC
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                this.game.targetFPS = (double)this.fpsNum.Value;
            }
            RecordedFrame recordedFrame = new RecordedFrame(this.You.nextInput.kValue);
            if (e.KeyCode == Keys.Left)
            {
                recordedFrame.left = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                recordedFrame.right = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                recordedFrame.up = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                recordedFrame.down = false;
            }
            else if (e.KeyCode == Keys.Space)
            {
                recordedFrame.space = false;
            }
            if (recordedFrame.kValue != this.You.nextInput.kValue)
            {
                this.game.SetInput(recordedFrame, this.SelectedPlayer);
            }
        }

        // Token: 0x060000BE RID: 190 RVA: 0x0000B88C File Offset: 0x00009A8C
        private void chkInput_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks != 2)
            {
                return;
            }
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.ForeColor.R == 0)
            {
                checkBox.ForeColor = Color.Red;
                return;
            }
            checkBox.ForeColor = Color.Black;
        }

        // Token: 0x060000BF RID: 191 RVA: 0x0000B8D4 File Offset: 0x00009AD4
        private void numFrame_ValueChanged(object sender, EventArgs e)
        {
            this.manual = false;
            RecordedFrame frameInput = this.game.GetFrameInput(this.SelectedPlayer, (int)this.numFrame.Value);
            byte b = 0;
            while ((int)b < this.chkInput.Length)
            {
                this.chkInput[(int)b].Checked = frameInput.GetButton(b);
                b += 1;
            }
            this.manual = true;
        }

        // Token: 0x060000C0 RID: 192 RVA: 0x00004279 File Offset: 0x00002479
        private void chkPlayRec_CheckedChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x060000C1 RID: 193 RVA: 0x0000B939 File Offset: 0x00009B39
        private void chkx10_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkx10.Checked)
            {
                this.chkx10.ForeColor = Color.Red;
                return;
            }
            this.chkx10.ForeColor = Color.Black;
        }

        // Token: 0x060000C2 RID: 194 RVA: 0x0000B96C File Offset: 0x00009B6C
        private void btnPartial_Click(object sender, EventArgs e)
        {
            using (PartialsForm partialsForm = new PartialsForm())
            {
                partialsForm.mov = this.cChannel;
                partialsForm.Show();
            }
        }

        // Token: 0x060000C3 RID: 195 RVA: 0x0000B9B0 File Offset: 0x00009BB0
        private void btnSetStats_Click(object sender, EventArgs e)
        {
            bool flag = this.You.Accel == 1.86 || this.You.Speed != (double)this.You.SpStat / 10.0 + 2.0;
            if (InputArgs.SimpleView)
            {
                this.You.SpStat = (int)this.numSpeed2.Value;
                this.You.AccStat = (int)this.numAccel2.Value;
                this.You.JumpStat = (int)this.numJump2.Value;
            }
            else
            {
                this.You.SpStat = (int)this.numSpeed.Value;
                this.You.AccStat = (int)this.numAccel.Value;
                this.You.JumpStat = (int)this.numJump.Value;
            }
            if (flag)
            {
                this.You.SetHats();
            }
            else
            {
                this.You.SetStats();
            }
            this.txtNoSelect.Select();
            this.game.DrawFrame();
        }

        // Token: 0x060000C4 RID: 196 RVA: 0x0000BAE4 File Offset: 0x00009CE4
        private void numStat_ValueChanged(object sender, EventArgs e)
        {
            if (InputArgs.SimpleView)
            {
                this.lblTotalStats.Text = "(" + (this.numSpeed2.Value + this.numAccel2.Value + this.numJump2.Value).ToString() + ")";
                return;
            }
            this.lblTotalStats.Text = "(" + (this.numSpeed.Value + this.numAccel.Value + this.numJump.Value).ToString() + ")";
        }

        // Token: 0x060000C5 RID: 197 RVA: 0x0000BB93 File Offset: 0x00009D93
        private void tournamentBth_Click(object sender, EventArgs e)
        {
            this.numSpeed.Value = 65m;
            this.numAccel.Value = 65m;
            this.numJump.Value = 65m;
            this.btnSetStats_Click(null, null);
        }

        // Token: 0x060000C6 RID: 198 RVA: 0x0000BBD4 File Offset: 0x00009DD4
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.recordingVideo)
            {
                this.button1.Text = "Record Vid";
                this.recordingVideo = false;
                return;
            }
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyVideos;
                folderBrowserDialog.SelectedPath = Environment.SpecialFolder.MyVideos.ToString() + "\\ImgSeq";
                folderBrowserDialog.ShowDialog();
                this.recordingPath = folderBrowserDialog.SelectedPath;
                this.recordingFrame = 0;
                this.button1.Text = "Recording.";
                this.recordingVideo = true;
            }
        }

        // Token: 0x060000C7 RID: 199 RVA: 0x0000BC7C File Offset: 0x00009E7C
        private void pnlGame_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtNoSelect.Select();
            if (Control.ModifierKeys == Keys.Shift)
            {
                this.You.X = (double)(this.theMap.CamX + e.X);
                this.You.Y = (double)(this.theMap.CamY + e.Y);
                return;
            }
            if (Control.ModifierKeys == Keys.Control)
            {
                this.You.course.MakeHat(this.theMap.CamX + e.X, this.theMap.CamY + e.Y, 3, Color.White, 1, 0);
                return;
            }
            if (this.tabControl1.SelectedTab == this.tabLE && this.theMap.inLE)
            {
                this.LE_Action(e);
            }
        }

        // Token: 0x060000C8 RID: 200 RVA: 0x0000BD4D File Offset: 0x00009F4D
        private void pnlGame_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.tabControl1.SelectedTab == this.tabLE && this.theMap.inLE)
            {
                this.LE_Action(e);
            }
        }

        // Token: 0x060000C9 RID: 201 RVA: 0x0000BD78 File Offset: 0x00009F78
        private void ScreenToWorld(ref int x, ref int y, int rot)
        {
            x += this.theMap.CamX;
            y += this.theMap.CamY;
            General.RotatePoint(ref x, ref y, rot);
            x = (int)Math.Floor((double)x / 30.0);
            y = (int)Math.Floor((double)y / 30.0);
        }

        // Token: 0x060000CA RID: 202 RVA: 0x0000BDD8 File Offset: 0x00009FD8
        private void LE_Action(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            this.ScreenToWorld(ref x, ref y, -this.You.Rotation);
            if (e.Button == MouseButtons.Left && this.listViewBlocks.SelectedIndices.Count != 0)
            {
                int num = this.listViewBlocks.SelectedIndices[0];
                if (this.theMap.getBlock(x, y, 0, false).T == 99)
                {
                    this.theMap.AddBlock(x, y, num);
                    return;
                }
                if (this.theMap.getBlock(x, y, 0, false).T != num)
                {
                    this.theMap.DeleteBlock(x, y);
                    this.theMap.AddBlock(x, y, num);
                    return;
                }
            }
            else if (e.Button == MouseButtons.Right && this.theMap.getBlock(x, y, 0, false).T != 99)
            {
                this.theMap.DeleteBlock(x, y);
            }
        }

        // Token: 0x060000CB RID: 203 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
        private void chkHats_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.manual)
            {
                return;
            }
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                this.You.GiveHat(new Hat((int)checkBox.Tag));
            }
            else
            {
                for (int i = 0; i < this.You.Hats.Length; i++)
                {
                    if (this.You.Hats[i].ID == (int)checkBox.Tag)
                    {
                        for (int j = i + 1; j < this.You.Hats.Length; j++)
                        {
                            this.You.Hats[j - 1] = this.You.Hats[j];
                        }
                        Array.Resize<Hat>(ref this.You.Hats, this.You.Hats.Length - 1);
                        break;
                    }
                }
                this.You.SetHatPowers();
            }
            this.txtNoSelect.Select();
        }

        // Token: 0x060000CC RID: 204 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
        private void chkItem_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.manual)
            {
                return;
            }
            Array.Resize<int>(ref this.theMap.avItems, 9);
            int num = 0;
            for (int i = 0; i < 9; i++)
            {
                if (this.chkItems[i].Checked)
                {
                    this.theMap.avItems[num] = i + 1;
                    num++;
                }
            }
            Array.Resize<int>(ref this.theMap.avItems, num);
        }

        // Token: 0x17000013 RID: 19
        // (get) Token: 0x060000CD RID: 205 RVA: 0x0000C01F File Offset: 0x0000A21F
        private int SelectedPlayer
        {
            get
            {
                return (int)this.numSelectedPlayer.Value - 1;
            }
        }

        // Token: 0x060000CE RID: 206 RVA: 0x0000C034 File Offset: 0x0000A234
        private void numSelectedPlayer_ValueChanged(object sender, EventArgs e)
        {
            this.manual = false;
            this.chkCowboy.Checked = this.You.CowboyHat;
            this.chkCrown.Checked = this.You.CrownHat;
            this.chkProp.Checked = this.You.PropellerHat;
            this.chkSanta.Checked = this.You.SantaHat;
            this.chkTop.Checked = this.You.TopHat;
            this.chkJump.Checked = this.You.JumpHat;
            this.lblFrames.Text = this.cChannel.Frames.ToString();
            this.numFrame.Maximum = this.cChannel.Frames;
            this.DisplayInfos();
            this.theMap.FollowChar = this.You;
            this.theMap.MainChar = this.You;
            this.game.currentChannel = this.SelectedPlayer;
            this.game.DrawFrame();
        }

        // Token: 0x060000CF RID: 207 RVA: 0x0000C149 File Offset: 0x0000A349
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            this.AddPlayer();
        }

        // Token: 0x060000D0 RID: 208 RVA: 0x0000C154 File Offset: 0x0000A354
        private void AddPlayer()
        {
            this.game.AddPlayer(false);
            this.game.Players.Last<LocalCharacter>().Name = "Player " + this.game.Players.Count.ToString();
            this.numSelectedPlayer.Maximum = this.game.Players.Count;
            this.lblPlayers.Text = "/ " + this.game.Players.Count.ToString();
            this.game.recording.channels.Add(new RecordedChannel());
        }

        // Token: 0x060000D1 RID: 209 RVA: 0x0000C20C File Offset: 0x0000A40C
        private void ghostBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = this.RecordingsPath;
                if (openFileDialog.ShowDialog() != DialogResult.Cancel && !(openFileDialog.FileName == ""))
                {
                    Recording recording = new Recording(openFileDialog.FileName);
                    string text = Directory.GetParent(openFileDialog.FileName).FullName + "\\States\\" + openFileDialog.SafeFileName;
                    if (File.Exists(text))
                    {
                        recording.SS = new SaveState(text, false);
                        this.game.AddGhost(recording);
                        this.lblRecStatus.Text = "Loaded Ghost: " + openFileDialog.SafeFileName;
                    }
                    else
                    {
                        MessageBox.Show("Ghost recordings must have a savestate.");
                    }
                }
            }
        }

        // Token: 0x060000D2 RID: 210 RVA: 0x0000C2E0 File Offset: 0x0000A4E0
        private void removeGhostsBtn_Click(object sender, EventArgs e)
        {
            this.game.ClearGhosts();
        }

        // Token: 0x060000D3 RID: 211 RVA: 0x0000C2F0 File Offset: 0x0000A4F0
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string postData = string.Concat(new string[]
            {
                "search_str=",
                this.searchBox.Text,
                "&mode=",
                (this.modeBox.Text == "Level Title") ? "title" : "user",
                "&order=",
                this.orderBox.Text.ToLower(),
                "&dir=",
                this.ascBox.Checked ? "asc" : "desc",
                "&page=",
                this.pageNum.Value.ToString()
            });
            string link = "http://pr2hub.com/search_levels.php?";
            string str = this.PostLoad(link, postData);
            this.DisplayLevels(str);
        }

        // Token: 0x060000D4 RID: 212 RVA: 0x0000C3C4 File Offset: 0x0000A5C4
        private void myLevelsButton_Click(object sender, EventArgs e)
        {
            string link = "http://pr2hub.com/levels_get.php?random_num=0.1932&token=" + General.Settings.Tokens[General.Settings.SelectedUser] + "&count=9999";
            string text = this.LoadURL(link);
            if (text.StartsWith("error"))
            {
                this.noteBox.Text = text;
                return;
            }
            this.DisplayLevels(text);
        }

        // Token: 0x060000D5 RID: 213 RVA: 0x0000C423 File Offset: 0x0000A623
        private string LoadURL(string Link)
        {
            return new StreamReader(WebRequest.Create(Link).GetResponse().GetResponseStream()).ReadToEnd();
        }

        // Token: 0x060000D6 RID: 214 RVA: 0x0000C440 File Offset: 0x0000A640
        private void DisplayLevels(string str)
        {
            this.Levels.Clear();
            bool flag = true;
            try
            {
                this.Levels = JsonConvert.DeserializeObject<SearchLevelsModel>(str).Levels.ToList<LevelInfo>();
            }
            catch
            {
                flag = false;
            }
            this.levelsList.Items.Clear();
            if (this.Levels.Count != 0)
            {
                for (int i = 0; i < this.Levels.Count; i++)
                {
                    this.levelsList.Items.Add(this.Levels[i].Title);
                }
                return;
            }
            if (flag)
            {
                this.levelsList.Items.Add("NO LEVELS");
                this.levelsList.Items.Add("if loading your levels, verify your token");
                return;
            }
            this.levelsList.Items.Add("Error fetching levels");
        }

        // Token: 0x060000D7 RID: 215 RVA: 0x0000C524 File Offset: 0x0000A724
        private void levelsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.levelsList.SelectedIndex == -1)
            {
                return;
            }
            int selectedIndex = this.levelsList.SelectedIndex;
            this.userLbl.Text = "Username: " + this.Levels[selectedIndex].UserName;
            this.noteBox.Text = this.Levels[selectedIndex].Note;
            this.typeLbl.Text = "Type: " + this.Levels[selectedIndex].Type;
            this.versionLbl.Text = "Version: " + this.Levels[selectedIndex].Version.ToString();
            this.ratingLbl.Text = "Rating: " + this.Levels[selectedIndex].Rating.ToString();
            this.playsLbl.Text = "Plays: " + this.Levels[selectedIndex].PlayCount.ToString();
            this.minRankLbl.Text = "Min Rank: " + this.Levels[selectedIndex].MinLevel.ToString();
            this.levelIDLbl.Text = "Level ID: " + this.Levels[selectedIndex].LevelId.ToString();
            this.hasPassLbl.Visible = this.Levels[selectedIndex].Pass;
            this.loadLevelBtn.Text = "Load Level";
        }

        // Token: 0x060000D8 RID: 216 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
        private void loadLevelBtn_Click(object sender, EventArgs e)
        {
            if (this.levelsList.SelectedIndex == -1)
            {
                return;
            }
            if (this.loadLevelBtn.Text.StartsWith("S"))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.InitialDirectory = this.LevelsPath;
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.Cancel || saveFileDialog.FileName == "")
                    {
                        return;
                    }
                    File.WriteAllText(saveFileDialog.FileName, this.data);
                    return;
                }
            }
            this.theMap.enterLE();
            this.data = this.LoadURL("http://pr2hub.com/levels/" + this.Levels[this.levelsList.SelectedIndex].LevelId.ToString() + ".txt?version=" + this.Levels[this.levelsList.SelectedIndex].Version.ToString());
            this.theMap.LoadLevel(this.data);
            this.UpdateLevelInfo();
            this.PlayGame();
            this.loadLevelBtn.Text = "Save Level";
        }

        // Token: 0x060000D9 RID: 217 RVA: 0x0000C804 File Offset: 0x0000AA04
        private void tokenBtn_Click(object sender, EventArgs e)
        {
            new TokenManagerForm().ShowDialog();
            if (General.Settings.SelectedUser == -1)
            {
                this.You.Name = "Player";
                return;
            }
            this.You.Name = General.Settings.Users[General.Settings.SelectedUser];
            this.theMap.userName = this.You.Name;
            this.username = this.You.Name;
            this.login_token = General.Settings.Tokens[General.Settings.SelectedUser];
        }

        // Token: 0x060000DA RID: 218 RVA: 0x0000C8A4 File Offset: 0x0000AAA4
        private void fpsNum_ValueChanged(object sender, EventArgs e)
        {
            this.game.targetFPS = (double)this.fpsNum.Value;
        }

        // Token: 0x060000DB RID: 219 RVA: 0x0000C8C2 File Offset: 0x0000AAC2
        private void Random_Events(object sender, EventArgs e)
        {
            this.txtNoSelect.Select();
        }

        // Token: 0x060000DC RID: 220 RVA: 0x0000C8CF File Offset: 0x0000AACF
        private void txtNoSelect_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }

        // Token: 0x060000DD RID: 221 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
        private void spliceBtn_Click(object sender, EventArgs e)
        {
            this.PauseGame();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = this.RecordingsPath;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel || openFileDialog.FileName == "")
            {
                return;
            }
            Recording recording = new Recording(openFileDialog.FileName);
            string filePath = this.RecordingsPath + "\\States\\" + openFileDialog.SafeFileName;
            recording.SS = new SaveState(filePath, false);
            if (openFileDialog.ShowDialog() == DialogResult.Cancel || openFileDialog.FileName == "")
            {
                return;
            }
            Recording recording2 = new Recording(openFileDialog.FileName);
            filePath = this.RecordingsPath + "\\States\\" + openFileDialog.SafeFileName;
            recording2.SS = new SaveState(filePath, false);
            new RunSplicer().Splice(recording, recording2);
        }

        // Token: 0x060000DE RID: 222 RVA: 0x0000C9AE File Offset: 0x0000ABAE
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.UploadLevel());
        }

        // Token: 0x060000DF RID: 223 RVA: 0x0000C9BC File Offset: 0x0000ABBC
        public string GetSaveData()
        {
            return this.theMap.GetUploadData(true, true);
        }

        // Token: 0x060000E0 RID: 224 RVA: 0x0000C9CC File Offset: 0x0000ABCC
        private string UploadHash(string title, string name, string data)
        {
            string s = title + this.username.ToLower() + data + "84ge5tnr";
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(bytes)).Replace("-", "").ToLower();
        }

        // Token: 0x060000E1 RID: 225 RVA: 0x0000CA24 File Offset: 0x0000AC24
        private string PassHash(string pass)
        {
            string s = pass + "WGZSL3JWcUE9L3Q4YipZIQ==";
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(bytes)).Replace("-", "").ToLower();
        }

        // Token: 0x060000E2 RID: 226 RVA: 0x0000CA70 File Offset: 0x0000AC70
        public string UploadLevel()
        {
            string postData = this.GetSaveData() + "&token=" + this.login_token;
            return this.PostLoad("http://pr2hub.com/upload_level.php", postData);
        }

        // Token: 0x060000E3 RID: 227 RVA: 0x0000CAA0 File Offset: 0x0000ACA0
        private string PostLoad(string Link, string postData)
        {
            WebRequest webRequest = WebRequest.Create(Link);
            webRequest.Method = "POST";
            byte[] bytes = Encoding.UTF8.GetBytes(postData);
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ContentLength = (long)bytes.Length;
            Stream requestStream = webRequest.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            WebResponse webResponse = null;
            try
            {
                webResponse = webRequest.GetResponse();
            }
            catch (Exception)
            {
            }
            Stream responseStream = webResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(responseStream);
            string result = streamReader.ReadToEnd();
            streamReader.Close();
            responseStream.Close();
            webResponse.Close();
            return result;
        }

        // Token: 0x060000E4 RID: 228 RVA: 0x0000CB38 File Offset: 0x0000AD38
        public void SaveLevel(string path)
        {
            string saveData = this.GetSaveData();
            File.WriteAllText(path, saveData);
        }

        // Token: 0x060000E5 RID: 229 RVA: 0x0000CB53 File Offset: 0x0000AD53
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (base.ActiveControl == this.txtNoSelect)
            {
                e.IsInputKey = true;
            }
        }

        // Token: 0x060000E6 RID: 230 RVA: 0x0000CB6A File Offset: 0x0000AD6A
        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            this.theMap.note = this.txtNote.Text;
        }

        // Token: 0x060000E7 RID: 231 RVA: 0x0000CB82 File Offset: 0x0000AD82
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            this.theMap.Title = this.txtTitle.Text;
        }

        // Token: 0x060000E8 RID: 232 RVA: 0x0000CB9A File Offset: 0x0000AD9A
        private void txtCredits_TextChanged(object sender, EventArgs e)
        {
            this.theMap.credits = this.txtCredits.Text;
        }

        // Token: 0x060000E9 RID: 233 RVA: 0x0000CBB2 File Offset: 0x0000ADB2
        private void numGravity_ValueChanged(object sender, EventArgs e)
        {
            this.theMap.Gravity = (double)this.numGravity.Value;
        }

        // Token: 0x060000EA RID: 234 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
        private void cmbMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.theMap.song = this.cmbMusic.SelectedIndex;
        }

        // Token: 0x060000EB RID: 235 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
        private void numMinLevel_ValueChanged(object sender, EventArgs e)
        {
            this.theMap.min_level = (sbyte)this.numMinLevel.Value;
        }

        // Token: 0x060000EC RID: 236 RVA: 0x0000CC05 File Offset: 0x0000AE05
        private void cmbGameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.theMap.gameMode = this.cmbGameMode.Text.ToLower();
        }

        // Token: 0x060000ED RID: 237 RVA: 0x0000CC22 File Offset: 0x0000AE22
        private void numCowboyChance_ValueChanged(object sender, EventArgs e)
        {
            this.theMap.cowboyChance = (int)this.numCowboyChance.Value;
        }

        // Token: 0x060000EE RID: 238 RVA: 0x0000CC40 File Offset: 0x0000AE40
        private void chkLive_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.chkLive.CheckState == CheckState.Indeterminate)
            {
                this.theMap.live = 0;
                this.theMap.hasPass = true;
                this.theMap.password = "";
                this.theMap.passImpossible = false;
                return;
            }
            if (this.chkLive.CheckState == CheckState.Checked)
            {
                this.theMap.live = 1;
                this.theMap.hasPass = false;
                return;
            }
            this.theMap.live = 0;
            this.theMap.hasPass = false;
        }

        // Token: 0x060000EF RID: 239 RVA: 0x0000CCCF File Offset: 0x0000AECF
        private void levelsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.levelsList.SelectedIndex == -1)
            {
                return;
            }
            this.loadLevelBtn_Click(null, null);
        }

        // Token: 0x060000F0 RID: 240 RVA: 0x0000CCE8 File Offset: 0x0000AEE8
        private void linkLabelToggleItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool flag = false;
            CheckBox[] array = this.chkItems;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Checked)
                {
                    flag = true;
                }
            }
            array = this.chkItems;
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Checked = !flag;
            }
        }

        // Token: 0x060000F1 RID: 241 RVA: 0x0000CD3C File Offset: 0x0000AF3C
        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = ".txt";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, this.theMap.GetUploadData(false, true));
                }
            }
        }

        // Token: 0x060000F2 RID: 242 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
        private void buttonLoadRace_Click(object sender, EventArgs e)
        {
            string fileName;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                fileName = openFileDialog.FileName;
            }
            string[] lines = File.ReadAllLines(fileName);
            this.game.PlayReplay(new Replay(lines, true));
        }

        // Token: 0x060000F3 RID: 243 RVA: 0x0000CE0C File Offset: 0x0000B00C
        private void button2_Click(object sender, EventArgs e)
        {
            this.ToggleView(false);
        }

        // Token: 0x060000F4 RID: 244 RVA: 0x0000CE15 File Offset: 0x0000B015
        private void btnRetart_Click(object sender, EventArgs e)
        {
            this.btnPlay_Click(this, new EventArgs());
            this.btnPlay_Click(this, new EventArgs());
        }

        // Token: 0x040000E2 RID: 226
        private Game_ART game;

        // Token: 0x040000E3 RID: 227
        private CheckBox[] chkItems;

        // Token: 0x040000E4 RID: 228
        private CheckBox[] chkInput;

        // Token: 0x040000E5 RID: 229
        private CheckBox[] chkHats;

        // Token: 0x040000E6 RID: 230
        private bool loaded;

        // Token: 0x040000E7 RID: 231
        private bool manual = true;

        // Token: 0x040000E8 RID: 232
        private int curSS;

        // Token: 0x040000E9 RID: 233
        private bool recordingVideo;

        // Token: 0x040000EA RID: 234
        private string recordingPath;

        // Token: 0x040000EB RID: 235
        private int recordingFrame;

        // Token: 0x040000EC RID: 236
        private List<LevelInfo> Levels = new List<LevelInfo>();

        // Token: 0x040000ED RID: 237
        private string data;

        // Token: 0x040000EE RID: 238
        public string login_token = "";

        // Token: 0x040000EF RID: 239
        public string username = "";
    }
}
