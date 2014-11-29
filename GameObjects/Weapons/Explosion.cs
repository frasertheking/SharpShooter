using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sharpshooter_Fk
{
    public class Explosion
    {
        public int life = 240;
        public Picture pic;
        public PointF location;

        //Constructor Method
        public Explosion(PointF location)
        {
            MainForm.explosionList.Add(this);
            pic = new Picture("Images/Explode.png", location, 6, 40);
            this.location = location;
        }

        //Draw Method
        public void Draw(Graphics g)
        {
            pic.location.X = location.X - MainForm.viewOffset.X;
            pic.location.Y = location.Y - MainForm.viewOffset.Y;
            pic.Draw(g);
        }

        //Update Method
        public void Update(int time)
        {
            life -= time;

            if (life <= 0)
            {
                MainForm.explosionList.Remove(this);
            }
            pic.Update(time);
        }
    }
}
