using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

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
            MainForm.sound.playSound("Sounds/GunShot1.wav", this.location);
            Bullet b = new Bullet("Images/Bullet3.png", personFiring, new PointF());

            if (personFiring == MainForm.player1)
            {
                b.life = 1f;
                b.damage = 1;
            }
            else
            {
                b.life = 1f;
                b.damage = 1;
            }

            return b;
        }
    }
}
