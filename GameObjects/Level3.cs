using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sharpshooter_Fk
{
    public class Level3
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
            Wall borderTop = new Wall("Green", topX - 80, topY - 80, width + 80, 80);
            Wall borderLeft = new Wall("Green", topX - 80, topY, 80, height + 80);
            Wall borderBottom = new Wall("Green", topX, topY + height, width + 80, 80);
            Wall borderRight = new Wall("Green", topX + width, topY - 80, 80, width + 80);
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
            Wall wall1 = new Wall("Orange", 342, 100, 218, 30);
            Wall wall2 = new Wall("Blue", 650, 100, 30, 180);
            Wall wall3 = new Wall("Orange", 650, 100, 350, 30);
            Wall wall5 = new Wall("Blue", 550, 100, 30, 350);
            Wall wall6 = new Wall("Orange", 675, 250, 200, 30);
            Wall wall7 = new Wall("Blue", 875, 250, 30, 350);
            Wall wall11 = new Wall("Blue", 875, 595, 30, 350);
            Wall wall8 = new Wall("Orange", 575, 915, 300, 30);
            Wall wall9 = new Wall("Orange", 300, 915, 300, 30);
            Wall wall10 = new Wall("Orange", 75, 915, 300, 30);
            Wall wall111 = new Wall("Blue", -25, 650, 30, 350);
            Wall wall15 = new Wall("Orange", -25, 650, 300, 30);
            Wall wall12 = new Wall("Blue", 480, 450, 100, 120);
            Wall wall156 = new Wall("Orange", 200, 600, 100, 120);
            Wall wall13 = new Wall("Blue", 400, 275, 100, 120);
            Wall wall14 = new Wall("Blue", 290, 343, 20, 15);
            Wall wall16 = new Wall("Blue", 100, 200, 100, 120);
            Wall wall99 = new Wall("Orange", 175, 425, 100, 115);
            Wall wall100 = new Wall("Orange", -75, 200, 100, 115);
            Wall wall101 = new Wall("Orange", -150, 100, 500, 30);
            Wall wall102 = new Wall("Orange", -350, 100, 250, 30);
            Wall wall103 = new Wall("Blue", -350, 100, 30, 350);
            Wall wall104 = new Wall("Blue", -350, 425, 30, 200);
            Wall wall105 = new Wall("Orange", -327, 727, 300, 30);
            Wall wall106 = new Wall("Blue", 260, 185, 90, 90);
            Wall wall107 = new Wall("Orange", -225, 450, 300, 120);
            Wall wall108 = new Wall("Orange", -223, 250, 100, 120);
            Wall wall112 = new Wall("Orange", -1000, -100, 2000, 30);
            Wall wall113 = new Wall("Orange", -623, 727, 300, 30);
            Wall wall114 = new Wall("Blue", -654, 410, 30, 350);
            Wall wall115 = new Wall("Orange", -650, 300, 300, 30);
            Wall wall116 = new Wall("Orange", -1000, 300, 375, 30);
            Wall wall117 = new Wall("Green", -72, -400, 120, 15);
            Wall wall118 = new Wall("Green", -72, -625, 120, 15);
            Wall wall119 = new Wall("Green", -72, -625, 15, 230);
            Wall wall120 = new Wall("Green", 33, -620, 15, 233);
        }

        public static void createPortals()
        {
            //Creat teleport machines
            Teleporter t1 = new Teleporter(new PointF(45, 720),1);
            
            Teleporter t2 = new Teleporter(new PointF(50, 50),0);

            Teleporter t3 = new Teleporter(new PointF(-150, 888), 3);

            Teleporter t4 = new Teleporter(new PointF(-10, -550), 1);

            Teleporter t5 = new Teleporter(new PointF(-967, -967), 5);

            Teleporter t6 = new Teleporter(new PointF(-2000, -100), 4);
        }

        public static void createEnemies()
        {
            //spawn some mobs
            EnemySoldier e1 = new EnemySoldier(new PointF(650, 100));
            e1.changeWeapon(2);
            EnemySoldier e2 = new EnemySoldier(new PointF(200, 300));
            e2.changeWeapon(1);
            EnemySoldier e3 = new EnemySoldier(new PointF(500, 200));
            e3.changeWeapon(3);
            EnemySoldier e4 = new EnemySoldier(new PointF(200, 100));
            e4.changeWeapon(4);
            EnemySoldier e5 = new EnemySoldier(new PointF(700, 800));
            e5.changeWeapon(2);
            EnemySoldier e6 = new EnemySoldier(new PointF(790, 360));
            e6.changeWeapon(1);
            EnemySoldier e7 = new EnemySoldier(new PointF(-115, 600));
            e7.changeWeapon(3);
            EnemySoldier e8 = new EnemySoldier(new PointF(9, 390));
            e8.changeWeapon(4);
            EnemySoldier e9 = new EnemySoldier(new PointF(-850, 53));
            e9.changeWeapon(1);
            EnemySoldier e10 = new EnemySoldier(new PointF(944, 204));
            e10.changeWeapon(1);
            EnemySoldier e11 = new EnemySoldier(new PointF(-867, 534));
            e11.changeWeapon(2);
            EnemySoldier e12 = new EnemySoldier(new PointF(-400, 813));
            e12.changeWeapon(1);
            EnemySoldier e13 = new EnemySoldier(new PointF(-417, 939));
            e13.changeWeapon(1);
        }

        public static void createFloor()
        {
            Floor floor1 = new Floor("wide", -400, -575, 1000, 1000);
        }

        public static void createLevel()
        {
            initalizeLists();
            MainForm.ground = new Picture("Images/Ground.png", new PointF(0, 0), 1, 1);
            MainForm.player1 = new Player(new PointF(380, 545));
            MainForm.player1.HP = 100;
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
            RapidGun gun2 = new RapidGun(new PointF(-900, 50));
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
            MainForm.weaponList.Add(gun7);

        }

    }
}
