using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Sharpshooter_Fk
{
    public class Floor
    {
        public int left;
        public int top;
        public int width;
        public int height;

        Bitmap image;

        public Floor(int left, int top, int width, int height)
        {
            image = new Bitmap("Images/floor.png");
            this.left = left;
            this.top = top;
            this.width = width;
            this.height = height;

            MainForm.floorList.Add(this);
        }

        public void Draw(Graphics g)
        {
            g.Transform = new Matrix();
            g.DrawImage(image, new RectangleF(left - MainForm.viewOffset.X, top - MainForm.viewOffset.Y,
                width, height));
        }
    }
}
