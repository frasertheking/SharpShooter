using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Sharpshooter_Fk
{
    public partial class MainForm : Form
    {
        public static Player player1;
        public static int lifeBarValue;
        public static Radar radar;
        public static List<Bullet> bulletList;
        public static List<Teleporter> teleportList;
        public static List<Switch> switchList;
        public static List<Soldier> enemyList;
        public static List<Wall> wallList;
        public static List<Floor> floorList;
        public static List<Explosion> explosionList;
        public static List<HealthPack> healthList;
        public static Point viewOffset;
        public static List<Weapon> weaponList;
        //public static SoundEngine sound;
        public static List<Weapon> playerWeaponList;
        public static bool godMode = false;
        public static Picture ground;
        public static Picture fogOfWar;
        public static Picture helpTerminal;
        public static Picture helpTerminal2;
        public static Picture helpTerminal3;
        public static List<Boss> bossList;
        public static int level = 2;
        public static bool hasTeleported = false;
        public static bool teleportunlocked = false;
        public static bool power = false;
        public static bool playOnce = true;
        public static bool helpMe = true;
        public static bool helpMe2 = false;
        public static bool helpMe3 = false;

        public Picture lifeBar1;
        public Picture lifeBar2;
        public Picture lifeBar3;
        public Picture lifeBar4;
        public Picture lifeBar5;
        public Picture lifeBar6;
        public Picture lifeBar7;
        public Picture lifeBar8;
        public Picture lifeBar9;
        public Picture lifeBar10;
        public Picture lifeBar11;
        public Picture lifeBar12;
        public Picture lifeBar13;
        public Picture underMinimap;

        Graphics windowsGraphics;
        Graphics onScreenGraphics;
        Bitmap screen;

        public Picture gameOverScreen;
        public Picture victoryScreen;
        public Picture uberSecretZombieLevel;
        public Picture gameHud;

        // MainForm Constructor
        public MainForm()
        {
            InitializeComponent();
            
            windowsGraphics = this.CreateGraphics();
            screen = new Bitmap(this.Width, this.Height);
            onScreenGraphics = Graphics.FromImage(screen);
            //sound = new SoundEngine(this);

            // Set our Drawmethod to be called when the window repaints
            this.Paint += new PaintEventHandler(DrawGame);

            Init();
        }
       
        //Initalizing gamecode
        void Init()
        {
            if (level == 1)
            {
                Level.createLevel();
            }
            else if (level == 2)
            {
                Level2.createLevel();
                continueLabel.Visible = false;
            }  

            Soldier.alreadyExploding = false;

            gameOverScreen = new Picture("Images/GameOver.png", new PointF(this.Width / 2,
                this.Height / 3), 1, 1);
            victoryScreen = new Picture("Images/Victory.png", new PointF(this.Width / 2,
                this.Height / 3), 1, 1);
            uberSecretZombieLevel = new Picture("Images/uberSecretZombieLevel.png", new PointF(this.Width / 2,
                this.Height / 3), 1, 1);

            gameHud = new Picture("Images/hud2.png", new PointF(400,550), 1, 1);
            helpTerminal = new Picture("Images/terminal.png", new PointF(125, 125), 1, 1);
            helpTerminal2 = new Picture("Images/terminal2.png", new PointF(125, 125), 1, 1);
            helpTerminal3 = new Picture("Images/terminal3.png", new PointF(125, 125), 1, 1);
            fogOfWar = new Picture("Images/fogofwar.png", new PointF(0, 0), 1, 1);
            underMinimap = new Picture("Images/underMinimap.png", new PointF(715, 105), 1, 1);

            lifeBar1 = new Picture("Images/lifeLabel1.png", new PointF(685, 562), 1, 1);
            lifeBar2 = new Picture("Images/lifeLabel2.png", new PointF(685, 562), 1, 1);
            lifeBar3 = new Picture("Images/lifeLabel3.png", new PointF(685, 562), 1, 1);
            lifeBar4 = new Picture("Images/lifeLabel4.png", new PointF(685, 562), 1, 1);
            lifeBar5 = new Picture("Images/lifeLabel5.png", new PointF(685, 562), 1, 1);
            lifeBar6 = new Picture("Images/lifeLabel6.png", new PointF(685, 562), 1, 1);
            lifeBar7 = new Picture("Images/lifeLabel7.png", new PointF(685, 562), 1, 1);
            lifeBar8 = new Picture("Images/lifeLabel8.png", new PointF(685, 562), 1, 1);
            lifeBar9 = new Picture("Images/lifeLabel9.png", new PointF(685, 562), 1, 1);
            lifeBar10 = new Picture("Images/lifeLabel10.png", new PointF(685, 562), 1, 1);
            lifeBar11 = new Picture("Images/lifeLabel11.png", new PointF(685, 562), 1, 1);
            lifeBar12 = new Picture("Images/lifeLabel12.png", new PointF(685, 562), 1, 1);
            lifeBar13 = new Picture("Images/lifeLabel13.png", new PointF(685, 562), 1, 1);

            //Set input on player
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(player1.KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(player1.KeyUp);
            this.MouseDown += new MouseEventHandler(player1.MouseDown);
            this.MouseUp += new MouseEventHandler(player1.MouseUp);

            //var player = new WMPLib.WindowsMediaPlayer();
            //player.URL = @"Sounds\ShadowRock.wav";
        }

        //Draws Game
        public void DrawGame(Object sender, PaintEventArgs e)
        {   
            // This refreashes the background screen each on repaint
            onScreenGraphics.Clear(Color.Black);

            ////this draws the background
            //onScreenGraphics.DrawImage(background, new Rectangle(-1224 - viewOffset.X, -1224 - viewOffset.Y, 1224, 1224));
            //onScreenGraphics.DrawImage(background, new Rectangle(-1224 - viewOffset.X, -viewOffset.Y, 1224, 1224));
            //onScreenGraphics.DrawImage(background, new Rectangle(-viewOffset.X, -1224 - viewOffset.Y, 1224, 1224));
            //onScreenGraphics.DrawImage(background, new Rectangle(-viewOffset.X, -viewOffset.Y, 1224, 1224));
            ground.location.X = player1.location.X - MainForm.viewOffset.X;
            ground.location.Y = player1.location.Y - MainForm.viewOffset.Y;
            ground.Draw(onScreenGraphics);

            //This draws the floor
            /*foreach (Floor fl in floorList)
            {
                fl.Draw(onScreenGraphics);
            }*/

            // This draws the teleporters
            foreach (Teleporter t in teleportList)
            {
                t.Draw(onScreenGraphics);
            }

            if (MainForm.level == 2)
            {
                // This draws the switches
                foreach (Switch s in switchList)
                {
                    s.Draw(onScreenGraphics);
                }
            }

            player1.Draw(onScreenGraphics);

            // This draws the bullets
            foreach (Bullet b in bulletList)
            {
                b.Draw(onScreenGraphics);
            }

            //This draws the enemys
            foreach (Soldier es in enemyList)
            {
                es.Draw(onScreenGraphics);
            }

            //This draws the tank
            foreach (Boss b in bossList)
            {
                b.Draw(onScreenGraphics);
            }         

            //This draws the walls
            foreach (Wall w in wallList)
            {
                w.Draw(onScreenGraphics);
            }

            //this draws the weaponz
            foreach (Weapon wn in weaponList)
            {
                wn.Draw(onScreenGraphics);
            }

            //this draws the healthpacks
            foreach (HealthPack hp in healthList)
            {
                hp.Draw(onScreenGraphics);
            }

            if (MainForm.level == 1)
            {
                if (helpMe3)
                {
                    helpTerminal3.Draw(onScreenGraphics);
                }  
            }

            if (MainForm.level == 2)
            {
                if (Switch.powerLevel == 0)
                {
                    if (power)
                    {
                        fogOfWar.location.X = player1.location.X - MainForm.viewOffset.X;
                        fogOfWar.location.Y = player1.location.Y - MainForm.viewOffset.Y;
                        fogOfWar.Draw(onScreenGraphics);

                        if (helpMe)
                        {
                            helpTerminal.Draw(onScreenGraphics);
                        }                        
                    }
                }
                if (Switch.powerLevel == 1)
                {
                    if (helpMe2)
                    {
                        helpTerminal2.Draw(onScreenGraphics);
                    }
                }
            }

            //This draws the explosion
            foreach (Explosion ex in explosionList)
            {
                ex.Draw(onScreenGraphics);
            }

            underMinimap.Draw(onScreenGraphics);
            //this draws the radar
            radar.Draw(onScreenGraphics);

            //This draws the gameover screen
            if (player1.killed == true)
            {
                gameOverScreen.Draw(onScreenGraphics);
            }

            //This draws the victory screen
            if (bossList.Count == 0 && level == 2)
            {
                victoryScreen.Draw(onScreenGraphics);
            }

            //This draws the victory screen
            if (bossList.Count == 0 && level == 1)
            {
                uberSecretZombieLevel.Draw(onScreenGraphics);
                continueLabel.Visible = true;
            }           

            gameHud.Draw(onScreenGraphics);

            if (player1.HP >= 100)
            {
                lifeBar13.Draw(onScreenGraphics);
            }
            else if (player1.HP >= 92)
            {
                lifeBar12.Draw(onScreenGraphics);
            }
            else if (player1.HP >= 84)
            {
                lifeBar11.Draw(onScreenGraphics);
            }
            else if (player1.HP >= 76)
            {
                lifeBar10.Draw(onScreenGraphics);
            }
            else if (player1.HP >= 68)
            {
                lifeBar9.Draw(onScreenGraphics);
            }
            else if (player1.HP >= 60)
            {
                lifeBar8.Draw(onScreenGraphics);
            }
            else if (player1.HP >= 52)
            {
                lifeBar7.Draw(onScreenGraphics);
            }
            else if (player1.HP >= 44)
            {
                lifeBar6.Draw(onScreenGraphics);
            }
            else if (player1.HP >= 36)
            {
                lifeBar5.Draw(onScreenGraphics);
            }
            else if (player1.HP >= 28)
            {
                lifeBar4.Draw(onScreenGraphics);
            }
            else if (player1.HP >= 20)
            {
                lifeBar3.Draw(onScreenGraphics);
            }
            else if (player1.HP >= 1)
            {
                lifeBar2.Draw(onScreenGraphics);
            }
            else if (player1.HP <= 0)
            {
                lifeBar1.Draw(onScreenGraphics);
            }
            windowsGraphics.DrawImage(screen, new Point(0, 0));
        }

        //Timer runs the timer for the program
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //foreach (Wall w in wallList)
            //{
            //    player1.isStillTouchingWall(w);
            //    hittingWallLabel.Text = player1.inAWall.ToString();
            //}

            player1.Update(GameTimer.Interval);

            //teleports to boss level
            /*if (enemyList.Count == 0 && hasTeleported == false)
            {
                MainForm.player1.location = new PointF(500, -500);
                hasTeleported = true;
            }*/

            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].Update(GameTimer.Interval);
            }
            
            for (int i = 0; i < teleportList.Count; i++)
            {
                teleportList[i].Update(GameTimer.Interval);
            }

            if (MainForm.level == 2)
            {
                for (int i = 0; i < switchList.Count; i++)
                {
                    switchList[i].Update(GameTimer.Interval);
                }
            }

            for (int i = 0; i < bulletList.Count; i++)
            {
                bulletList[i].Update(GameTimer.Interval);
            }

            for (int i = 0; i < explosionList.Count; i++)
            {
                explosionList[i].Update(GameTimer.Interval);
            }

            for (int i = 0; i < bossList.Count; i++)
            {
                bossList[i].Update(GameTimer.Interval);
            }

            for (int i = 0; i < weaponList.Count; i++)
            {
                weaponList[i].Update(GameTimer.Interval);
            }

            for (int i = 0; i < healthList.Count; i++)
            {
                if (healthList[i].onground)
                {
                    healthList[i].Update(GameTimer.Interval);
                }
                else
                {
                    healthList.RemoveAt(i);
                }
            }

            radar.Update(GameTimer.Interval);
            
            // This draws the Gun Labels
                foreach (Weapon wn in playerWeaponList)
                {
                   if (wn.weaponType == 1)
                   {
                       RapidGunLabel.Visible = true;
                   }
                   else if (wn.weaponType == 2)
                   {
                       sniperGunLabel.Visible = true;
                   }
                   else if (wn.weaponType == 3)
                   {
                       SuperBallLauncherLabel.Visible = true;
                   }
                   else if (wn.weaponType == 4)
                   {
                       FlameThrowerLabel.Visible = true;
                   }
                   else if (wn.weaponType == 5)
                    {
                        ShotGunLabel.Visible = true;
                    }
                }

            viewOffset.X = (int)player1.location.X - this.Width / 2;
            viewOffset.Y = (int)player1.location.Y - this.Height / 2;

            coordLabel.Text = player1.location.X + ", " + player1.location.Y;
            //HpAmountLabel.Text = player1.HP.ToString();

            if (MainForm.level == 1)
            {
                if (player1.location.X > -250 && player1.location.X < 0)
                {
                    if (player1.location.Y < 800 && player1.location.Y > 500)
                    {
                        helpMe3 = true;
                    }
                    else
                    {
                        helpMe3 = false;
                    }
                }
            }

            if (MainForm.level == 2)
            {
                if (player1.location.Y < 350)
                {
                    power = true;
                    if (playOnce)
                    {
                        var player15 = new WMPLib.WindowsMediaPlayer();
                        player15.URL = @"Sounds\powerDown.wav";
                        playOnce = false;
                    }
                }

                if (player1.location.Y < 100)
                {
                    helpMe = false;
                }

                if (Switch.powerLevel == 1)
                {
                    if (MainForm.player1.location.X < -150)
                    {
                        if (MainForm.player1.location.Y > -450 && MainForm.player1.location.Y < -275)
                        {
                            helpMe2 = true;
                        }
                    }
                    else if (MainForm.player1.location.X > 1530)
                    {
                        helpMe2 = true;
                    }
                    if (MainForm.player1.location.X > -150 && MainForm.player1.location.X < 1530)
                    {
                        helpMe2 = false;
                    }
                    else if (MainForm.player1.location.X < 1530 && MainForm.player1.location.X > -150)
                    {
                        helpMe2 = false;
                    }
                }
            }

            OnPaint(
                new PaintEventArgs (windowsGraphics,
                new Rectangle(0,0, this.Width, this.Height)));

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Init();
                SuperBallLauncherLabel.Visible = false;
                sniperGunLabel.Visible = false;
                RapidGunLabel.Visible = false;
                FlameThrowerLabel.Visible = false;
                ShotGunLabel.Visible = false;
                playOnce = true;
                power = false;
        }

        private void RapidGunLabel_Click(object sender, EventArgs e)
        {
            foreach (Weapon wn in playerWeaponList)
            {
                if (wn.weaponType == 1)
                {
                    MainForm.player1.currentWeapon = wn;
                }
                
            }
        }

        private void sniperGunLabel_Click(object sender, EventArgs e)
        {
            foreach (Weapon wn in playerWeaponList)
            {
                if (wn.weaponType == 2)
                {
                    MainForm.player1.currentWeapon = wn;
                }

            }
        }

        private void pistolLabel_Click(object sender, EventArgs e)
        {
            foreach (Weapon wn in playerWeaponList)
            {
                if (wn.weaponType == 0)
                {
                    MainForm.player1.currentWeapon = wn;
                }

            }
        }

        private void SuperBallLauncherLabel_Click(object sender, EventArgs e)
        {
            foreach (Weapon wn in playerWeaponList)
            {
                if (wn.weaponType == 3)
                {
                    MainForm.player1.currentWeapon = wn;
                }

            }
        }

        private void FlameThrowerLabel_Click(object sender, EventArgs e)
        {
            foreach (Weapon wn in playerWeaponList)
            {
                if (wn.weaponType == 4)
                {
                    MainForm.player1.currentWeapon = wn;
                }

            }
        }

        private void ShotGunLabel_Click(object sender, EventArgs e)
        {
            foreach (Weapon wn in playerWeaponList)
            {
                if (wn.weaponType == 5)
                {
                    MainForm.player1.currentWeapon = wn;
                }
            }
        }

        private void godModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (godMode == true)
            {
                godMode = false;
            }
            else if (godMode == false)
            {
                godMode = true;
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            title.Hide();
            TitleLabel.Hide();
            PlayLabel.Hide();
            this.Init();
            GameTimer.Enabled = true;
        }

        private void changeAngle45ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.facingAngle += 45;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            title.Hide();
            TitleLabel.Hide();
            PlayLabel.Hide();
            this.Init();
            GameTimer.Enabled = true;
        }

        private void pauseLabel_Click(object sender, EventArgs e)
        {
            GameTimer.Enabled = false;
            //sound.stopBGM();
            pauseScreen.Visible = true;
            pauseLabel.Visible = false;
            unpauseLabel.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MainForm.level == 1)
            {
                level = 2;
                this.Init();
                SuperBallLauncherLabel.Visible = false;
                sniperGunLabel.Visible = false;
                RapidGunLabel.Visible = false;
                FlameThrowerLabel.Visible = false;
                ShotGunLabel.Visible = false;
                playOnce = true;
            }
        }

        private void unpauseLabel_Click_1(object sender, EventArgs e)
        {
            GameTimer.Enabled = true;
            pauseScreen.Visible = false;
            unpauseLabel.Visible = false;
            pauseLabel.Visible = true;
            //sound.playBGM("Sounds/ShadowRock.mp3");
        }
    }
}