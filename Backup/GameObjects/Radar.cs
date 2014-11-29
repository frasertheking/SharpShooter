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
            this.pic = new Picture("Images/animatedRadar.png", new PointF(720, 95), 67, 60);
            this.pPic = new Picture("Images/Playericon.png", new PointF(720, 95), 1, 1);
            this.ePicList = new List<Picture>();
        }

        //Draw Method
        public void Draw(Graphics g)
        {
            pic.Draw(g);
            // This draws the radar points
            foreach (Picture p in ePicList)
            {
                p.Draw(g);
            }
            pPic.Draw(g);
        }

        //Update Method
        public void Update(int time)
        {
            ePicList.Clear();

            foreach (EnemySoldier es in MainForm.enemyList)
            {
                if (es.location.X > (MainForm.player1.location.X - 800))
                {
                    if (es.location.X < (MainForm.player1.location.X + 800))
                    {
                        if (es.location.Y > (MainForm.player1.location.Y - 800))
                        {
                            if (es.location.Y < (MainForm.player1.location.Y + 800))
                            {
                                eOffset.X = (-MainForm.viewOffset.X + es.location.X) / 20;
                                eOffset.Y = (-MainForm.viewOffset.Y + es.location.Y) / 20;

                                ePic = new Picture("Images/EnemyIcon.png", new PointF(this.picOffset.X + eOffset.X, this.picOffset.Y + eOffset.Y), 1, 1);
                                ePicList.Add(ePic);
                            }
                        }
                    }
                }
            }
            foreach (Boss es in MainForm.bossList)
            {
                if (es.location.X > (MainForm.player1.location.X - 800))
                {
                    if (es.location.X < (MainForm.player1.location.X + 800))
                    {
                        if (es.location.Y > (MainForm.player1.location.Y - 800))
                        {
                            if (es.location.Y < (MainForm.player1.location.Y + 800))
                            {
                                eOffset.X = (-MainForm.viewOffset.X + es.location.X) / 20;
                                eOffset.Y = (-MainForm.viewOffset.Y + es.location.Y) / 20;

                                ePic = new Picture("Images/tyrael2radar.png", new PointF(this.picOffset.X + eOffset.X, this.picOffset.Y + eOffset.Y), 15, 40);
                                ePicList.Add(ePic);
                            }
                        }
                    }
                }

            }

            pic.Update(time);
            ePic.Update(time);
        }
    }
}
