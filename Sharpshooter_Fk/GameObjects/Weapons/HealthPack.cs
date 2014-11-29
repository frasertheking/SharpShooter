using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Sharpshooter_Fk
{
    public class HealthPack
    {
        public Picture pic;
        public PointF location;
        public bool onground = false;
        public int radius;


        public HealthPack(string image, PointF location)
        {
            this.pic = new Picture(image, location, 1, 1);
            this.radius = pic.bitmap.Width / 2;
            this.location = location;
        }

        public void Draw(Graphics g)
        {
            pic.location.X = location.X - MainForm.viewOffset.X;
            pic.location.Y = location.Y - MainForm.viewOffset.Y;
            pic.Draw(g);
        }

        public void Update(int time)
        {
            if (this.onground && this.isTouching(MainForm.player1))
            {
                this.onground = false;
                MainForm.player1.HP += 5;
                MainForm.sound.playSound("Sounds/WeaponGet.wav", this.location);
            }
        }

        public bool isTouching(Soldier s)
        {
            double distance = Math.Sqrt((s.location.X - this.location.X) * (s.location.X - this.location.X) + (s.location.Y - this.location.Y) * (s.location.Y - this.location.Y));
            return distance < this.radius + s.radius;
        }
    }
}

    
