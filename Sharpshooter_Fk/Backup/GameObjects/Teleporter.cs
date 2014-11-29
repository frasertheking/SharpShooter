using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sharpshooter_Fk
{
    public class Teleporter
    {
        public Picture pic;
        public PointF location;
        public bool active = true;
        public int radius;
        public int pointTo;
        public int teleportCd;
        public int timeSinceLastTp;

        //Constructor Method
        public Teleporter(PointF location, int p)
        {
            pic = new Picture("Images/WeaponPickupHighlight.png", location, 1, 1);
            this.location = location;
            radius = pic.bitmap.Width / 2;
            pointTo = p;
            MainForm.teleportList.Add(this);
            this.teleportCd = 1000;
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
            if (this.active == true && this.isTouching() == true)
            {
                timeSinceLastTp += time;

                if (timeSinceLastTp > teleportCd)
                {
                    MainForm.player1.location = MainForm.teleportList[this.pointTo].location;
                    MainForm.sound.playSound("Sounds/WeaponGet.wav", this.location);

                    timeSinceLastTp = 0;
                }
            }
        }

        //isTouching function
        public bool isTouching()
        {
            double distance = Math.Sqrt((MainForm.player1.location.X - this.location.X) * (MainForm.player1.location.X - this.location.X) +
                (MainForm.player1.location.Y - this.location.Y) * (MainForm.player1.location.Y - this.location.Y));

            return distance < (this.radius + MainForm.player1.radius);
        }     
    }
}
