using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sharpshooter_Fk
{
    public class Radar
    {
        public Picture pic;
        public Picture pPic;
        public List<Picture> ePicList;
        public PointF picOffset;
        public PointF eOffset;
        public Picture ePic;

        //Constructor Method
        public Radar()
        {
            this.picOffset = new PointF(700, 80);
            //this.pic = new Picture("Images/WeaponPickUpHighlight.png", this.picOffset, 1, 1);
            //this.pPic = new Picture("Images/SniperBullet.png", this.picOffset, 1, 1);
            this.pic = new Picture("Images/WeaponPickUpHighlight.png", new PointF(720,95), 1, 1);
            this.pPic = new Picture("Images/SniperBullet.png", new PointF(720, 95), 1, 1);
            this.ePicList = new List<Picture>();
        }

        //Draw Method
        public void Draw(Graphics g)
        {
            pic.Draw(g);
            pPic.Draw(g);
            // This draws the radar points
            foreach (Picture p in ePicList)
            {
                p.Draw(g);
            }
        }

        //Update Method
        public void Update(int time)
        {   
            ePicList.Clear();

            foreach (EnemySoldier es in MainForm.enemyList)
            {
                eOffset.X = (-MainForm.viewOffset.X + es.location.X) /20;
                eOffset.Y = (-MainForm.viewOffset.Y + es.location.Y) / 20;

                ePic = new Picture("Images/Bullet_1.png", new PointF(this.picOffset.X + eOffset.X,this.picOffset.Y + eOffset.Y), 1, 1);
                //ePic = new Picture("Images/Bullet_1.png", new PointF(eOffset.X + MainForm.viewOffset.X, eOffset.Y + MainForm.viewOffset.Y), 1, 1);
                ePicList.Add(ePic);
            }
            foreach (Boss es in MainForm.bossList)
            {
                eOffset.X = (-MainForm.viewOffset.X + es.location.X) / 20;
                eOffset.Y = (-MainForm.viewOffset.Y + es.location.Y) / 20;

                ePic = new Picture("Images/tank2.png", new PointF(this.picOffset.X + eOffset.X, this.picOffset.Y + eOffset.Y), 1, 1);
                //ePic = new Picture("Images/Bullet_1.png", new PointF(eOffset.X + MainForm.viewOffset.X, eOffset.Y + MainForm.viewOffset.Y), 1, 1);
                ePicList.Add(ePic);
            }
        }
    }
}
