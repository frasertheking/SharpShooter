using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Sharpshooter_Fk
{
    public class Wall
    {
        public int left;
        public int top;
        public int width;
        public int height;

        Bitmap image;

        public Wall(String colour, int left, int top, int width, int height)
        {
            image = new Bitmap("Images/" + colour + "Box.png");
            this.left = left;
            this.top = top;
            this.width = width;
            this.height = height;

            MainForm.wallList.Add(this);
        }

        public void Draw(Graphics g)
        {
            g.Transform = new Matrix();
            g.DrawImage(image, new RectangleF(left - MainForm.viewOffset.X, top - MainForm.viewOffset.Y,
                width, height));
        }

        public PointF pointNearestTo(PointF p)
        {
            // Initialize a new PointF called nearestPoint.
            PointF nearestPoint = new PointF();

            //Check IF the left edge of this wall is to the right of the point "p"
            //if it is, then the nearestPoint's X coordinate must be the left edge of this wall
            if (this.left > p.X) // it's to the left
            {
                nearestPoint.X = this.left;
            }
            //Else IF the right edge of this wall is to the left of the point "p"
            //the nearestPoint's X coordinatre must be the right edge of this wall
            else if (this.left + this.width < p.X)
            {
                nearestPoint.X = this.left + this.width;
            }
            //If it's not to the left, and it's not to the right, it MUST be inside the wall.
            //So we'll set the nearestPoint's X coordinate equal to p's X coordinate
            else
            {
                nearestPoint.X = p.X;
            }
            if (this.top > p.Y)
            {
                nearestPoint.Y = this.top;
            }
            else if (this.top + this.height < p.Y)
            {
                nearestPoint.Y = this.top + this.height;
            }
            else
            {
                nearestPoint.Y = p.Y;
            }
            return nearestPoint;
        }


        /// For reflections, we need to find the NORMAL at the nearest point on the box.
        /// This is the line from the nearest point to the given point, only with the
        /// length adjusted to 1.
        public PointF normalAtNearestPoint(PointF p)
        {

            //Create a PointF called nearestPoint and set it equal to the point on this wall nearest to p.
            PointF nearestPoint = this.pointNearestTo(p);

            //Create a PointF vector called normal and set its direction pointing from nearestPoint to p.
            PointF normal = new PointF();
            normal.X = p.X - nearestPoint.X;
            normal.Y = p.Y - nearestPoint.Y;

            //Now that we have the normal vector, make sure it's length is set to 1.
            //If the length of normal is zero, we can't resize it, so just return normal and leave.
            if (normal.X == 0 && normal.Y == 0)
            {
                return normal;
            }

            //Create a float called factor and set it equal to the INVERSE of normal's LENGTH (Pythagorean Theorem).
            float factor = 1f / (float)Math.Sqrt(normal.X * normal.X + normal.Y * normal.Y);

            //Multiplying normal by that factor gives normal a length of 1.
            normal.X *= factor;
            normal.Y *= factor;

            //Finally, return the normal.
            return normal;
        }


    }
}
