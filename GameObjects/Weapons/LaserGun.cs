using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Media;

namespace Sharpshooter_Fk
{
    public class LaserGun:Weapon
    {
        //Constructor Method
        public LaserGun(PointF location)
            : base("Images/laserGun.png", location)
        {
            this.bulletSpeed = 20f;
            this.bulletStartDistance = 15f;
            this.fireDelay = 0;
            this.weaponType = 6;
        }

        public override Bullet CreateBullet(Soldier personFiring)
        {
            //MainForm.sound.playSound("Sounds/GunShot1.wav", this.location);
            var player13 = new WMPLib.WindowsMediaPlayer();
            player13.URL = @"Sounds\GunShot1.wav";
            Bullet b = new Bullet("Images/laser.png", personFiring, new PointF());

            if (personFiring == MainForm.player1)
            {
                b.life = 0.2f;
                b.damage = 6;
            }
            else
            {
                b.life = 0.2f;
                b.damage = 6;
            }

            return b;
        }
    }
}
