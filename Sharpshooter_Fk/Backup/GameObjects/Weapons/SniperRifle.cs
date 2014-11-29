using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sharpshooter_Fk
{
    public class SniperRifle:Weapon
    {
        //Constructor Method
        public SniperRifle(PointF location)
            : base("Images/SniperGun.png", location)
        {
            this.bulletSpeed = 20f;
            this.bulletStartDistance = 10f;
            this.fireDelay = 2000;
            this.weaponType = 2;
        }

        public override Bullet CreateBullet(Soldier personFiring)
        {
            MainForm.sound.playSound("Sounds/GunShot2.wav", this.location);
            Bullet b = new Bullet("Images/SniperBullet.png", personFiring, new PointF());

            if (personFiring == MainForm.player1)
            {
                b.life = 2f;
                b.damage = 5;
            }
            else
            {
                b.life = 2f;
                b.damage = 5;
            }
            
            return b;
        }
    }
}
