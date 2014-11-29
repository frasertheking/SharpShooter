using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Sharpshooter_Fk
{
    public class EnemySoldier:Soldier
    {
        //int directionChangeCount = 0;
        //int nextDirectionChange = 0;
        int aggroDistance = 250;


        //Player Constructor
        public EnemySoldier(PointF location):base("Images/Enemy1.png", location)
        {
            // Add this Enemy to the enemyList
            MainForm.enemyList.Add(this);
            isFiring = false;
            moveSpeed = 2;
            walkDirc = 1;

            this.currentWeapon = new EnemyPistol(this.location);

            //Random r = new Random((int)location.X);
            //nextDirectionChange = r.Next(500) + 2000;
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
                this.currentWeapon.fireDelay = 300;
                this.currentWeapon.bulletSpeed = 15;
               
                //this.currentWeapon.
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
                this.currentWeapon.fireDelay = 700;
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

            //this.facingAngle = (float)Math.Acos((a / h) / (180f * Math.PI));
            //this.facingAngle = (float)(this.facingAngle );
            //this.facingAngle = (float)this.inverseSin(a / h);
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
                this.turnTo();
            }
            else
            {
                this.isFiring = false;
            }
        }

        public void turnTo()
        {
            if(!(facingAngle % Math.PI >= 45))
            {
                this.facingAngle += 1;
            }
        }

        public void follow()
        {
            this.getShootingAngle();

            if (this.location.X < MainForm.player1.location.X)
            {
                this.location.X += 1;

            }
            else
            {
                this.location.X -= 1;
            }
            if (this.location.Y < MainForm.player1.location.Y)
            {
                this.location.Y += 1;
            }
            else
            {
                this.location.Y -= 1;
            }

            if (MainForm.player1.location.X - this.location.X >= 0 && MainForm.player1.location.Y - this.location.Y >= 0)
            {
                //bottom right
                if (this.facingAngle % 360 > 315)
                {
                    this.facingAngle += 3;
                }
                else
                {
                    this.facingAngle -= 3;
                }

            }
            else if (MainForm.player1.location.X - this.location.X > 0 && -MainForm.player1.location.Y + this.location.Y > 0)
            {
                //top right
                if (this.facingAngle % 360 > 45)
                {
                    this.facingAngle += 3;
                }
                else
                {
                    this.facingAngle -= 3;
                }
            }
            else if (-MainForm.player1.location.X + this.location.X > 0 && MainForm.player1.location.Y - this.location.Y > 0)
            {
                //bottom left
                if (MainForm.player1.facingAngle % 360 > 225)
                {
                    this.facingAngle += 3;
                }
                else
                {
                    this.facingAngle -= 3;
                }
            }
            else
            {
                //top left
                if (MainForm.player1.facingAngle % 360 > 135)
                {
                    this.facingAngle += 3;
                }
                else
                {
                    this.facingAngle -= 3;
                }
            }
        }

        //// checks to see if the enemy is still touching the wall
        //public bool isStillTouchingWall(Wall w)
        //{
        //    float sLeft = this.location.X - this.radius;
        //    float sTop = this.location.Y - this.radius;
        //    float sRight = this.pic.bitmap.Width + sLeft;
        //    float sBottom = this.pic.bitmap.Height + sTop;

        //    float wLeft = w.left;
        //    float wTop = w.top + 220;
        //    float wRight = w.left + w.width;
        //    float wBottom = w.height + w.top;

        //    if (sTop < wBottom && sRight > wLeft && sLeft < wRight && sBottom > wTop)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        public override void Update(int time)
        {
            if (this.HP <= 0)
            {
                MainForm.enemyList.Remove(this);
            }

            //foreach (Wall w in MainForm.wallList)
            //{
            //    if (this.isStillTouchingWall(w))
            //    {
            //        //this.turnDirc += 0.06f;
            //    }
            //    else
            //    {
            //        //this.turnDirc = 0.0f;
            //    }
            //}

            this.isNear();

            base.Update(time);

            //directionChangeCount += time;

            //if (directionChangeCount >= nextDirectionChange)
            //{
            //    Random r = new Random((int)location.X);
            //    facingAngle = r.Next(360);
            //    directionChangeCount = 0;

            //    nextDirectionChange = r.Next(500) + 2000;
            //}
        }
    }
}
