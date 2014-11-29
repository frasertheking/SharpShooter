using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Media;

namespace Sharpshooter_Fk
{
    public class RapidGun:Weapon
    {
        //Constructor Method
        public RapidGun(PointF location)
            : base("Images/RapidGun.png", location)
        {
            this.bulletSpeed = 15f;
            this.bulletStartDistance = 10f;
            this.fireDelay = 150;
            this.weaponType = 1;
        }

        public override Bullet CreateBullet(Soldier personFiring)
        {
            //MainForm.sound.playSound("Sounds/GunShot1.wav", this.location);
            var player2 = new WMPLib.WindowsMediaPlayer();
            player2.URL = @"Sounds\GunShot1.wav";
            Bullet b = new Bullet("Images/Bullet3.png", personFiring, new PointF());

            if (personFiring == MainForm.player1)
            {
                b.life = 1f;
                b.damage = 6;
            }
            else
            {
                b.life = 1f;
                b.damage = 6;
            }

            return b;
        }
    }
}
