using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sharpshooter_Fk
{
    public class Boss:Soldier
    {
        int aggroDistance = 300;


        //Player Constructor
        public Boss(PointF location):base("Images/RedBossTank.png", location)
        {
            // Add this Enemy to the enemyList
            MainForm.bossList.Add(this);
            isFiring = false;
            moveSpeed = 4;
            walkDirc = 1;

            this.currentWeapon = new SuperBallLauncher(this.location);
        }

        //Gives the enemy soldier a weapon based on the weapon type
        public void changeWeapon(int wn)
        {
            MainForm.weaponList.Remove(this.currentWeapon);
            
            if (wn == 0)
            {
                this.currentWeapon = new EnemyPistol(this.location);
            }
            else if (wn == 1)
            {
                this.currentWeapon = new RapidGun(this.location);
                this.currentWeapon.fireDelay = 500;
                this.currentWeapon.bulletSpeed = 5;
            }
            else if (wn == 2)
            {
                this.currentWeapon = new SuperBallLauncher(this.location);
                this.currentWeapon.fireDelay = 1750;
            }
            else if (wn == 3)
            {
                this.currentWeapon = new SniperRifle(this.location);
            }
            else if (wn == 4)
            {
                this.currentWeapon = new FlameThrower(this.location);
            }

            MainForm.weaponList.Add(this.currentWeapon);
        }

        public void getShootingAngle()
        {
            double a;
            double b;

            if (this.location.X > MainForm.player1.location.X)
            {
                a = -MainForm.player1.location.X + this.location.X;
            }
            else
            {
                a = MainForm.player1.location.X - this.location.X;
            }

            if (this.location.Y > MainForm.player1.location.Y)
            {
                b = -MainForm.player1.location.X + this.location.X;
            }
            else
            {
                b = MainForm.player1.location.X - this.location.X;
            }

            double h = Math.Sqrt(a * a + b * b);
        }

        //public double inverseSin(double x)
        //{
        //    return Math.Atan(x / Math.Sqrt(-x * x + 1));
        //}

        public void isNear()
        {
            //distance between 2 objects
            double distance = Math.Sqrt((MainForm.player1.location.X - this.location.X) * (MainForm.player1.location.X - this.location.X) +
                (MainForm.player1.location.Y - this.location.Y) * (MainForm.player1.location.Y - this.location.Y));

            if (distance < this.aggroDistance)
            {
                this.isFiring = true;
                this.follow();
            }
            else
            {
                this.isFiring = false;
            }
        }

        public void follow()
        {
            this.getShootingAngle();

            if (this.location.X < MainForm.player1.location.X)
            {
                this.location.X += 2;
            }
            else
            {
                this.location.X -= 2;
            }
            if (this.location.Y < MainForm.player1.location.Y)
            {
                this.location.Y += 2;
            }
            else
            {
                this.location.Y -= 2;
            }
        }

        public override void Update(int time)
        {
            if (this.HP <= 0)
            {
                MainForm.bossList.Remove(this);
            }

            this.isNear();

            base.Update(time);
        }

    }
}
