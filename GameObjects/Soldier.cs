using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Sharpshooter_Fk
{
    public class Soldier
    {
        public Picture pic;
        public PointF location;
        public float facingAngle = 0;
        public float turnDirc = 0;
        public float walkDirc = 0;
        public PointF velocity;
        public int moveSpeed = 5;
        public bool isFiring = false;
        public int radius;
        public int HP = 35;
        public bool killed = false;
        public bool hitFlicker = false;
        public static bool alreadyExploding = false;
        public int hitFlickerCount = 0;
        public Weapon currentWeapon;
        public int canHeSurvive;

        //Constructor Method for player
        public Soldier(String image, PointF location)
        {
            pic = new Picture(image, location, 4, 60);
            this.location = location;
            velocity = new PointF();

            radius = pic.bitmap.Width / 2;

            // Makes them pick random directions
            Random r = new Random((int)location.X);
            facingAngle = r.Next(360);
        }

        //This allows the player to move
        public void Move()
        {
            location.X += velocity.X;
            location.Y += velocity.Y;
        }

        //Draw Method for player
        public void Draw(Graphics g)
        {
            if (!this.killed)
            {
                pic.angle = facingAngle;
                if (!hitFlicker)
                {
                    pic.location.X = location.X - MainForm.viewOffset.X;
                    pic.location.Y = location.Y - MainForm.viewOffset.Y;
                    pic.Draw(g);
                    currentWeapon.Draw(g);
                }
            }
        }

        //Update Method
        public virtual void Update(int time)
        {
            if (HP <= 0)
            {
                //We're dead.
                killed = true;
                Explosion e = new Explosion(this.location);
                if (alreadyExploding == false)
                {
                    //MainForm.sound.playSound("Sounds/Explosion.wav", this.location);
                    var player9 = new WMPLib.WindowsMediaPlayer();
                    player9.URL = @"Sounds\Explosion.wav";
                    alreadyExploding = true;
                }
                MainForm.weaponList.Remove(this.currentWeapon);
                return;
            }

            //soldier fires his weapon
            if (isFiring)
            {
                currentWeapon.Fire(this);
            }

            //Flicker effect
            if (hitFlickerCount > 0)
            {
                hitFlickerCount--;
                hitFlicker = !hitFlicker;
            }
            else
            {
                hitFlicker = false;
            }

            foreach (Wall w in MainForm.wallList)
            {
                PointF touchPoint = new PointF();
                if (this.isTouchingWall(w, ref touchPoint))
                {
                    PushFrom(touchPoint);

                    if (this != MainForm.player1)
                    {
                        this.facingAngle += 3f;
                    }
                }
            }
                       
            //Rotate based on the turning direction.
            facingAngle += ((float)(time)) * turnDirc;
            //Determining the forward velocity from the angle being faced
            velocity.X = (float)Math.Cos(facingAngle / 180f * Math.PI) * walkDirc * moveSpeed;
            velocity.Y = -(float)Math.Sin(facingAngle / 180f * Math.PI) * walkDirc * moveSpeed;

            Move();
            if (velocity.X != 0 || velocity.Y != 0)
            {
                pic.Update(time);
            }

            this.UpdateWeapon(time);
        }

        //Updates weapon
         public void UpdateWeapon(int time)
        {
            float xOffset = (float)Math.Cos(this.facingAngle / 180f * Math.PI) * 32f;
            float yOffset = -(float)Math.Sin(this.facingAngle / 180f * Math.PI) * 32f;

          
            currentWeapon.location.X = location.X + xOffset;
            currentWeapon.location.Y = location.Y + yOffset;
            currentWeapon.facingAngle = this.facingAngle;
            currentWeapon.Update(time);
        }


        //this method takes away HP from damage
        public void TakeDamage(int damage)
        {
            HP -= damage;
            //MainForm.lifeBarValue -= damage;
            var player6 = new WMPLib.WindowsMediaPlayer();
            player6.URL = @"Sounds\Hurt.wav";
            hitFlickerCount = 4;
        }

        //is touching wall method
        public bool isTouchingWall(Wall w, ref PointF touchPoint)
        {
            PointF nearestPoint = w.pointNearestTo(this.location);
            float distance = (float)Math.Sqrt(
                (nearestPoint.X - location.X) * (nearestPoint.X - location.X)
            + (nearestPoint.Y - location.Y) * (nearestPoint.Y - location.Y));

            if (distance < this.radius)
            {
                touchPoint = nearestPoint;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PushFrom(PointF p)
        {
            float actualDistance = (float)Math.Sqrt((p.X - this.location.X) * (p.X - 
            this.location.X) + (p.Y - this.location.Y) * (p.Y - this.location.Y));

            if (actualDistance == 0)
            {
                return;
            }

            float desiredDistance = this.radius + 1;
            float proportion = desiredDistance / actualDistance;

            PointF move = new PointF(this.location.X - p.X, this.location.Y - p.Y);
            move.X *= proportion;
            move.Y *= proportion;

            this.location.X = p.X + move.X;
            this.location.Y = p.Y + move.Y;

        }

    }
}