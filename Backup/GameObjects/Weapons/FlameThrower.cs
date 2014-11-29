using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sharpshooter_Fk
{
    public class FlameThrower:Weapon
    {
        //Constructor Method
        public FlameThrower(PointF location)
            : base("Images/FlameThrower.png", location)
        {
            this.bulletSpeed = 2f;
            this.bulletStartDistance = 15f;
            this.fireDelay = 50;
            this.weaponType = 4;
        }

        public override Bullet CreateBullet(Soldier personFiring)
        {
            MainForm.sound.playSound("Sounds/Fireball.wav", this.location);
            Bullet b = new Bullet("Images/fireball.png", personFiring, new PointF());
            b.life = 0.7f;
            b.damage = 1;
            return b;
        }
        }
    }


