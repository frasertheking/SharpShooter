using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

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
            MainForm.sound.playSound("Sounds/GunShot1.wav", this.location);
            Bullet b = new Bullet("Images/laser.png", personFiring, new PointF());

            if (personFiring == MainForm.player1)
            {
                b.life = 0.2f;
                b.damage = 1;
            }
            else
            {
                b.life = 0.2f;
                b.damage = 1;
            }

            return b;
        }
    }
}
