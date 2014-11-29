using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Media;

namespace Sharpshooter_Fk
{
    public class SuperBallLauncher:Weapon
    {
        //Constructor Method
        public SuperBallLauncher(PointF location)
            : base("Images/SuperBallLauncher.png", location)
        {
            this.bulletSpeed = 6f;
            this.bulletStartDistance = 15f;
            this.fireDelay = 1000;
            this.weaponType = 3;
        }

        public override Bullet CreateBullet(Soldier personFiring)
        {
            //MainForm.sound.playSound("Sounds/GunShot3.wav", this.location);
            var player4 = new WMPLib.WindowsMediaPlayer();
            player4.URL = @"Sounds\GunShot3.wav";
            Bullet b = new Bullet("Images/SuperBall.png", personFiring, new PointF());

            if (personFiring == MainForm.player1)
            {
                b.life = 1.5f;
                b.damage = 34;
            }
            else
            {
                b.life = 1f;
                b.damage = 34;
            }
            
            return b;
        }
        }
}
