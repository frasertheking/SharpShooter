using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Media;

namespace Sharpshooter_Fk
{
    public class EnemyPistol:Weapon
    {

        //Constructor Method
        public EnemyPistol(PointF location)
            : base("Images/Pistol.png", location)
        {
            this.bulletSpeed = 22f;
            this.bulletStartDistance = 10f;
            this.fireDelay = 500;
            this.weaponType = 0;
        }

        public override Bullet CreateBullet(Soldier personFiring)
        {
            //MainForm.sound.playSound("Sounds/GunShot4.wav", this.location);
            var player12 = new WMPLib.WindowsMediaPlayer();
            player12.URL = @"Sounds\GunShot4.wav";
            return new Bullet("Images/Bullet1.png", personFiring, new PointF());
        }
    }
}
