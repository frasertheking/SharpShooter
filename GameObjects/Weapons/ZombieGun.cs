using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Media;

namespace Sharpshooter_Fk
{
    public class ZombieGun : Weapon
    {
        //Constructor Method
        public ZombieGun(PointF location)
            : base("Images/ZombieGun.png", location)
        {
            this.bulletSpeed = 15f;
            this.bulletStartDistance = 10f;
            this.fireDelay = 1000;
            this.weaponType = 6;
        }

        public override Bullet CreateBullet(Soldier personFiring)
        {
            //MainForm.sound.playSound("Sounds/Vomiting.wav", this.location);
            var player8 = new WMPLib.WindowsMediaPlayer();
            player8.URL = @"Sounds\Vomiting.wav";
            Bullet b = new Bullet("Images/ZombieBullet.png", personFiring, new PointF());

            if (personFiring == MainForm.player1)
            {
                b.life = 1f;
                b.damage = 999;
            }
            else
            {
                b.life = 0.9f;
                b.damage = 15;
            }

            return b;
        }
    }
}
