using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Media;

namespace Sharpshooter_Fk
{
    public class Switch
    {
        public Picture pic;
        public PointF location;
        public bool active = true;
        public int radius;
        public int pointTo;
        public static int powerLevel = 0;
        public static int side;

        //Constructor Method
        public Switch(PointF location, int p)
        {
            pic = new Picture("Images/shipPowerOff.png", location, 1, 1);
            this.location = location;
            radius = pic.bitmap.Width / 2;
            pointTo = p;
            MainForm.switchList.Add(this);
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
            if (powerLevel == 0)
            {
                if (this.active == true && this.isTouching() == true)
                {
                    this.active = false;
                    var player10 = new WMPLib.WindowsMediaPlayer();
                    player10.URL = @"Sounds\WeaponGet.wav";
                    powerLevel++;
                    pic = new Picture("Images/shipPowerOn.png", location, 1, 1);
                }
            }
            
            if (powerLevel == 1)
            {
                if (this.active == true && this.isTouching() == true)
                {
                    this.active = false;
                    MainForm.teleportunlocked = true;
                    var player22 = new WMPLib.WindowsMediaPlayer();
                    player22.URL = @"Sounds\WeaponGet.wav";
                    pic = new Picture("Images/shipPowerOn.png", location, 1, 1);
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
