using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Media;

namespace Sharpshooter_Fk
{
    public class ShotGun : Weapon
    {
        //Constructor Method
        public ShotGun(PointF location)
            : base("Images/ShotGun.png", location)
        {
            this.bulletSpeed = 15f;
            this.bulletStartDistance = 15f;
            this.fireDelay = 600;
            this.weaponType = 5;
        }

        public override Bullet CreateBullet(Soldier personFiring)
        {
            //MainForm.sound.playSound("Sounds/ShotGun.wav", this.location);
            var player14 = new WMPLib.WindowsMediaPlayer();
            player14.URL = @"Sounds\ShotGun.wav";
            Bullet b = new Bullet("Images/ShotBullet.png", personFiring, new PointF());

            if (personFiring == MainForm.player1)
            {
                b.life = .15f;
                b.damage = 35;
            }
            else
            {
                b.life = .15f;
                b.damage = 35;
            }

            return b;
        }
    }
}