using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Sharpshooter_Fk
{
    public class Picture
    {
        public Bitmap bitmap;
        public PointF location;
        public float angle = 0f;
        public PointF offset;
        public int animationCounter = 0;

        //the current frame
        public int frame = 0;
        //the total number of frames.
        public int frameCount;
        //the number of "ticks" per frame.
        public int timePerFrame;

        //constructor method for picture class
        public Picture(string fileName, PointF location, int frames, int flipTime)
        {
            this.frameCount = frames;
            this.timePerFrame = flipTime;

            bitmap = new Bitmap(fileName);
            this.location = location;
            offset = new PointF(bitmap.Width / 2f, bitmap.Height/frameCount / 2f);
        }

        //Draw method for picture
        public void Draw(Graphics g)
        {
            // Centers our pictures
            Point drawLocation = new Point((int)(location.X - offset.X),
                (int)(location.Y - offset.Y));

            Matrix m = new Matrix();
            //Rotate by the given angle around the center location of the picture.
            m.RotateAt(-angle, location);
            // Set the drawing transform to this rotation matrix
            g.Transform = m;
            g.DrawImage(bitmap, new Rectangle(drawLocation.X, drawLocation.Y,
                bitmap.Width, bitmap.Height/this.frameCount),
                new Rectangle(0, this.frame*bitmap.Height/this.frameCount, bitmap.Width, 
                bitmap.Height/this.frameCount), GraphicsUnit.Pixel);
        }

        //Leaving this empty for now
        public void Update(int time)
        {
            animationCounter += time;

            if (animationCounter >= this.timePerFrame)
            {
                this.frame++;
                if (this.frame >= frameCount)
                {
                    this.frame = 0;
                }
                animationCounter = 0;
            }
        }
    }
}
