using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Media;

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
            // MainForm.sound.playSound("Sounds/GunShot2.wav", this.location);
            var player11 = new WMPLib.WindowsMediaPlayer();
            player11.URL = @"Sounds\GunShot2.wav";
            Bullet b = new Bullet("Images/SniperBullet.png", personFiring, new PointF());

            if (personFiring == MainForm.player1)
            {
                b.life = 2f;
                b.damage = 30;
            }
            else
            {
                b.life = 2f;
                b.damage = 30;
            }
            
            return b;
        }
    }
}
