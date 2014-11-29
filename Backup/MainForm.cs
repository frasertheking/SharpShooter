using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sharpshooter_Fk
{
    public partial class MainForm : Form
    {
        public static Player player1;
        public static Radar radar;
        public static List<Bullet> bulletList;
        public static List<Teleporter> teleportList;
        public static List<Soldier> enemyList;
        public static List<Wall> wallList;
        public static List<Floor> floorList;
        public static List<Explosion> explosionList;
        public static List<HealthPack> healthList;
        public static Point viewOffset;
        public static List<Weapon> weaponList;
        public static SoundEngine sound;
        public static List<Weapon> playerWeaponList;
        public static bool godMode = false;
        public Bitmap background = new Bitmap("Images/Ground.png");
        public static Picture ground;
        public static List<Boss> bossList;
        public static int level = 1;
        public static bool hasTeleported = false;

        Graphics windowsGraphics;
        Graphics onScreenGraphics;
        Bitmap screen;

        public Picture gameOverScreen;
        public Picture victoryScreen;
        public Picture uberSecretZombieLevel;

        // MainForm Constructor
        public MainForm()
        {
            InitializeComponent();
            
            windowsGraphics = this.CreateGraphics();
            screen = new Bitmap(this.Width, this.Height);
            onScreenGraphics = Graphics.FromImage(screen);
            sound = new SoundEngine(this);

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

            //Set input on player
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(player1.KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(player1.KeyUp);
            this.MouseDown += new MouseEventHandler(player1.MouseDown);
            this.MouseUp += new MouseEventHandler(player1.MouseUp);

            //sound.playBGM("Sounds/ShadowRock.mp3");
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
            foreach (Floor fl in floorList)
            {
                fl.Draw(onScreenGraphics);
            }

            // This draws the teleporters
            foreach (Teleporter t in teleportList)
            {
                t.Draw(onScreenGraphics);
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
            
            //This draws the explosion
            foreach (Explosion ex in explosionList)
            {
                ex.Draw(onScreenGraphics);
            }

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
            if (enemyList.Count == 0 && hasTeleported == false && level == 1)
            {
                MainForm.player1.location = new PointF(500, -500);
                hasTeleported = true;
            }

            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].Update(GameTimer.Interval);
            }
            
            for (int i = 0; i < teleportList.Count; i++)
            {
                teleportList[i].Update(GameTimer.Interval);
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

            //coordLabel.Text = player1.location.X + ", " + player1.location.Y;
            HpAmountLabel.Text = player1.HP.ToString();

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
            if (GameTimer.Enabled == true)
            {
                GameTimer.Enabled = false;
                sound.stopBGM();
                pauseScreen.Visible = true;
            }
            else if (GameTimer.Enabled == false)
            {
                GameTimer.Enabled = true;
                pauseScreen.Visible = false;
                //sound.playBGM("Sounds/ShadowRock.mp3");
            }
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
            }
        }
    }
}