using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sharpshooter_Fk
{
    public class EnemyPistol:Weapon
    {

        //Constructor Method
        public EnemyPistol(PointF location)
            : base("Images/Pistol.png", location)
        {
            this.bulletSpeed = 15f;
            this.bulletStartDistance = 10f;
            this.fireDelay = 600;
            this.weaponType = 0;
        }

        public override Bullet CreateBullet(Soldier personFiring)
        {
            MainForm.sound.playSound("Sounds/GunShot4.wav", this.location);
            return new Bullet("Images/Bullet1.png", personFiring, new PointF());
        }
    }
}
