using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sharpshooter_Fk
{
    public class Level
    {
        public static void initalizeLists()
        {
            MainForm.bulletList = new List<Bullet>();
            MainForm.enemyList = new List<Soldier>();
            MainForm.wallList = new List<Wall>();
            MainForm.floorList = new List<Floor>();
            MainForm.explosionList = new List<Explosion>();
            MainForm.weaponList = new List<Weapon>();
            MainForm.playerWeaponList = new List<Weapon>();
            MainForm.teleportList = new List<Teleporter>();
            MainForm.bossList = new List<Boss>();
            MainForm.healthList = new List<HealthPack>();
        }
        public static void createBorders(int topX, int topY, int width, int height)
        {
            //Spawn some walls
            //Wall borderTop = new Wall("Green", topX - 80, topY - 80, width + 80, 80);
            //Wall borderLeft = new Wall("Green", topX - 80, topY, 80, height + 80);
            //Wall borderBottom = new Wall("Green", topX, topY + height, width + 80, 80);
            //Wall borderRight = new Wall("Green", topX + width, topY - 80, 80, width + 80);
        }

        public static void createBosses()
        {
            //This creates the bosses
            Boss tank1 = new Boss(new PointF(600, -500));
            tank1.currentWeapon.fireDelay = 300;
            tank1.currentWeapon.bulletSpeed = 13;

        }

        public static void createWalls()
        {
            Wall wall1 = new Wall("Orange", 100, 650, 218, 30);
            Wall wall2 = new Wall("Orange", 450, 650, 218, 30);
            Wall wall3 = new Wall("Orange", 450, 650, 15, 114);
            Wall wall4 = new Wall("Orange", 303, 650, 15, 114);
            Wall wall5 = new Wall("Blue", 318, 754, 133, 10);
            Wall wall6 = new Wall("Orange", 100, 257, 30, 400);
            Wall wall7 = new Wall("Orange", 637, 257, 30, 400);
        }

        public static void createPortals()
        {
            //Creat teleport machines
            //Teleporter t1 = new Teleporter(new PointF(45, 720),1);
        }

        public static void createEnemies()
        {
            //spawn some mobs
            EnemySoldier e1 = new EnemySoldier(new PointF(650, 100));
            e1.changeWeapon(2);
        }

        public static void createFloor()
        {
            Floor floor1 = new Floor(100, 255, 565, 400);
            Floor floor2 = new Floor(315, 650, 150, 115);
        }

        public static void createLevel()
        {
            initalizeLists();
            MainForm.ground = new Picture("Images/Ground.png", new PointF(0, 0), 1, 1);
            MainForm.player1 = new Player(new PointF(380, 545));
            MainForm.player1.HP = 15;
            MainForm.player1.moveSpeed = 6;
            
            createBorders(-1000, -1000, 2000, 2000);
            createWalls();
            createFloor();
            createEnemies();
            createWeapons();
            createPortals();
            createBosses();

            MainForm.bossList[0].HP = 100;
            MainForm.bossList[0].moveSpeed = 7;

            MainForm.radar = new Radar();
        }
        public static void createWeapons()
        {
            /*RapidGun gun2 = new RapidGun(new PointF(-900, 50));
            gun2.onGround = true;
            SuperBallLauncher gun3 = new SuperBallLauncher(new PointF(0, -450));
            gun3.onGround = true;
            SniperRifle gun4 = new SniperRifle(new PointF(800, 200));
            gun4.onGround = true;
            FlameThrower gun5 = new FlameThrower(new PointF(831, 870));
            gun5.onGround = true;
            ShotGun gun6 = new ShotGun(new PointF(-2100, -100));
            gun6.onGround = true;
            LaserGun gun7 = new LaserGun(new PointF(833, 680));
            gun7.onGround = true;
            HealthPack health1 = new HealthPack("Images/HealthPack.png", new PointF(974, 960));
            health1.onground = true;
            MainForm.healthList.Add(health1);
            HealthPack health2 = new HealthPack("Images/HealthPack.png", new PointF(-267, 175));
            health2.onground = true;
            MainForm.healthList.Add(health2);
            HealthPack health3 = new HealthPack("Images/HealthPack.png", new PointF(-8, -682));
            health3.onground = true;
            MainForm.healthList.Add(health3);

            MainForm.weaponList.Add(gun2);
            MainForm.weaponList.Add(gun3);
            MainForm.weaponList.Add(gun4);
            MainForm.weaponList.Add(gun5);
            MainForm.weaponList.Add(gun6);
            MainForm.weaponList.Add(gun7);*/

        }

    }
}
