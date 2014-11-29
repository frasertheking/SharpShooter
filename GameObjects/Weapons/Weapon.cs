using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Media;

namespace Sharpshooter_Fk
{
    public abstract class Weapon
    {
        public Picture pic;
        public PointF location;
        public float bulletSpeed;
        public int fireDelay;
        public float bulletStartDistance;
        public float facingAngle;
        public int timeSinceLastShot = 0;
        public bool onGround = false;
        public int radius;
        public int weaponType;

        //Constructor Method
        public Weapon(string image, PointF location)
        {
            pic = new Picture(image, location, 1, 1);
            this.location = location;
            radius = pic.bitmap.Width / 2;
        }
        
        //Draw Method
        public void Draw(Graphics g)
        {
            pic.angle = facingAngle;
            pic.location.X = location.X - MainForm.viewOffset.X;
            pic.location.Y = location.Y - MainForm.viewOffset.Y;

            pic.Draw(g);
        }

        // Firing Method
        public void Fire(Soldier personFiring)
        {
            //Time and Shots
            if (timeSinceLastShot < fireDelay)
            {
                return;
            }

            //Reset timer
            timeSinceLastShot = 0;

            float xComponent = (float)Math.Cos(facingAngle / 180f * Math.PI);
            float yComponent = -(float)Math.Sin(facingAngle / 180f * Math.PI);

            //Change the spawning distance from the gun
            Bullet bullet = CreateBullet(personFiring);

            bullet.location.X = this.location.X + xComponent * bulletStartDistance;
            bullet.location.Y = this.location.Y + yComponent * bulletStartDistance;

            //Bullet velocity = Direction of player
            bullet.velocity.X = xComponent * bulletSpeed;
            bullet.velocity.Y = yComponent * bulletSpeed;
        }

        //Update Method
        public void Update(int time)
        {
            timeSinceLastShot += time;

            if (this.onGround == true && this.isTouching(MainForm.player1) == true)
            {
                this.onGround = false;
                MainForm.weaponList.Remove(this);
                MainForm.player1.currentWeapon = this;
                MainForm.playerWeaponList.Add(this);
               // MainForm.sound.playSound("Sounds/WeaponGet.wav", this.location);
                var player5 = new WMPLib.WindowsMediaPlayer();
                player5.URL = @"Sounds\WeaponGet.wav";
            }
        }

        //isTouching function
        public bool isTouching(Soldier s)
        {
            double distance = Math.Sqrt((s.location.X - this.location.X) * (s.location.X - this.location.X) +
                (s.location.Y - this.location.Y) * (s.location.Y - this.location.Y));

            return distance < (this.radius + s.radius);
        }

        public abstract Bullet CreateBullet(Soldier personFiring);
        
    }
}
