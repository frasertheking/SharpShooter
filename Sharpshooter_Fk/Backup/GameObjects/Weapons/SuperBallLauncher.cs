using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sharpshooter_Fk
{
    public class SuperBallLauncher:Weapon
    {
        //Constructor Method
        public SuperBallLauncher(PointF location)
            : base("Images/SuperBallLauncher.png", location)
        {
            this.bulletSpeed = 8f;
            this.bulletStartDistance = 15f;
            this.fireDelay = 1000;
            this.weaponType = 3;
        }

        public override Bullet CreateBullet(Soldier personFiring)
        {
            MainForm.sound.playSound("Sounds/GunShot3.wav", this.location);
            Bullet b = new Bullet("Images/SuperBall.png", personFiring, new PointF());

            if (personFiring == MainForm.player1)
            {
                b.life = 2f;
                b.damage = 20;
            }
            else
            {
                b.life = 2f;
                b.damage = 20;
            }
            
            return b;
        }
        }
}
