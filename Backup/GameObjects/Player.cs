using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Sharpshooter_Fk
{
    public class Player:Soldier
    {
       
        //Player Constructor
        public Player(PointF location):base("Images/Player.png", location)
        {
            this.currentWeapon = new EnemyPistol(this.location);
            MainForm.playerWeaponList.Add(this.currentWeapon);
        }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isFiring = true;
            }

        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isFiring = false;
            }
        }

        //Checks what keys are being pressed
        public void KeyDown(Object sender, KeyEventArgs key)
        {
            //Pressing Left
            if (key.KeyCode == Keys.Left)
            {
                turnDirc = 0.3f;
            }
            //Pressing Right
            if (key.KeyCode == Keys.Right)
            {
                turnDirc = -0.3f;
            }
            //Pressing Up
            if (key.KeyCode == Keys.Up)
            {
                walkDirc = 1;
            }
            //Pressing Down
            if (key.KeyCode == Keys.Down)
            {
                walkDirc = -1;
            }

            //Pressing Left
            if (key.KeyCode == Keys.A)
            {
                turnDirc = 0.3f;
            }
            //Pressing Right
            if (key.KeyCode == Keys.D)
            {
                turnDirc = -0.3f;
            }
            //Pressing Up
            if (key.KeyCode == Keys.W)
            {
                walkDirc = 1;
            }
            //Pressing Down
            if (key.KeyCode == Keys.S)
            {
                walkDirc = -1;
            }

            //Pressing Space
            if (key.KeyCode == Keys.Space)
            {
                isFiring = true;
            }
        }
        //Checks what keys are being pressed
        public void KeyUp(Object sender, KeyEventArgs key)
        {
            //Pressing Left
            if (key.KeyCode == Keys.Left)
            {
                turnDirc = 0;
            }
            //Pressing Right
            if (key.KeyCode == Keys.Right)
            {
                turnDirc = 0;
            }
            //Pressing Up
            if (key.KeyCode == Keys.Up)
            {
                walkDirc = 0;
            }
            //Pressing Down
            if (key.KeyCode == Keys.Down)
            {
                walkDirc = 0;
            }

            if (key.KeyCode == Keys.A)
            {
                turnDirc = 0;
            }
            //Pressing Right
            if (key.KeyCode == Keys.D)
            {
                turnDirc = 0;
            }
            //Pressing Up
            if (key.KeyCode == Keys.W)
            {
                walkDirc = 0;
            }
            //Pressing Down
            if (key.KeyCode == Keys.S)
            {
                walkDirc = 0;
            }

            //Pressing Space
            if (key.KeyCode == Keys.Space)
            {
                isFiring = false;
            }
        }

    }
}
