using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sharpshooter_Fk
{
    public class Bullet
    {
        public PointF location;
        public PointF velocity;
        public Picture pic;
        public float life = 1.0f;
        public int damage = 1; //default damage is 1

        // A reference to the Soldier that fired us.
        Soldier parent;

        public int radius;

        public Bullet(string image, Soldier s, PointF location)
        {
            parent = s;
            pic = new Picture(image, location, 4, 25);
            velocity = new PointF();
            this.location = location;

            radius = pic.bitmap.Width / 2;

            MainForm.bulletList.Add(this);
        }

        public virtual void Draw(Graphics g)
        {
            pic.location.X = location.X - MainForm.viewOffset.X;
            pic.location.Y = location.Y - MainForm.viewOffset.Y;


            pic.Draw(g);
        }

        public void Update(int time)
        {
            Move();
            pic.Update(time);

            life -= (float)time / 1000f;

            if (life <= 0)
            {
                MainForm.bulletList.Remove(this);
            }


            foreach (Wall w in MainForm.wallList)
            {
                if (this.isTouchingWall(w))
                {
                    this.backUpPosition();

                    PointF normal = w.normalAtNearestPoint(this.location);
                    this.bounceFrom(normal);

                }
            }


            if (parent == MainForm.player1)
            {

                for (int i = 0; i < MainForm.enemyList.Count; i++)
                {

                    if (this.isTouching(MainForm.enemyList[i]))
                    {
                        MainForm.enemyList[i].TakeDamage(this.damage);
                        MainForm.bulletList.Remove(this);

                    }
                }

                for (int i = 0; i < MainForm.bossList.Count; i++)
                {

                    if (this.isTouching(MainForm.bossList[i]))
                    {
                        MainForm.bossList[i].TakeDamage(this.damage);
                        MainForm.bulletList.Remove(this);

                    }
                }

            }

            // All bullets can hit the player, unless the player is dead.
            if (this.isTouching(MainForm.player1) && !MainForm.player1.killed && MainForm.godMode == false && parent != MainForm.player1)
            {
                MainForm.player1.TakeDamage(this.damage);
                MainForm.bulletList.Remove(this);
            }

        }

        public virtual void Move()
        {
            location.X += velocity.X;
            location.Y += velocity.Y;

        }

        public bool isTouching(Soldier s)
        {
            double distance = Math.Sqrt((s.location.X - this.location.X) * (s.location.X - this.location.X) +
                (s.location.Y - this.location.Y) * (s.location.Y - this.location.Y));

            return distance < (this.radius + s.radius);
        }

        public bool isTouchingWall(Wall w)
        {
            // First we need the nearest point on the wall, which
            // takes some work, so we have a seperate function for it.
            PointF nearestPoint = w.pointNearestTo(this.location);

            // Now see if the nearestPoint is touching the wall using Pythagorean Theorem
            // Just like in the Touching function in the Bullet class
            float distance = (float)Math.Sqrt(
                (nearestPoint.X - location.X) * (nearestPoint.X - location.X)
                + (nearestPoint.Y - location.Y) * (nearestPoint.Y - location.Y));


            if (distance < this.radius)
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        public void backUpPosition()
        {

            this.location.X -= this.velocity.X;
            this.location.Y -= this.velocity.Y;
        }

        //Reflects along a normal vector (see included PDF for theory)
        public void bounceFrom(PointF normal)
        {
            //Create a new PointF vector called R for the equation R = I - 2b.
            PointF R;

            //Applying the Dot Product to create the "b" in the equation R = I - 2b
            float b = (velocity.X * normal.X + velocity.Y * normal.Y);

            //Create the "2b" in the equation R = I - 2b
            b *= 2;

            //Create the new reflection vector.  R = new velocity vector and I = old velocity vector
            //We multiply bouncefactor by normal in order to turn bouncefactor into a vector.
            R = new PointF(
                 this.velocity.X - normal.X * b,
                 this.velocity.Y - normal.Y * b
                 );

            //Finally, set this bullet's new reflected velocity equal to R
            this.velocity.X = R.X;
            this.velocity.Y = R.Y;



        }


    }
}