using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sharpshooter_Fk
{
    public class Level2
    {
        public static void initalizeLists()
        {
            MainForm.bulletList = new List<Bullet>();
            MainForm.enemyList = new List<Soldier>();
            MainForm.wallList = new List<Wall>();
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
            Boss tank1 = new Boss(new PointF(-679, -168));

        }
        public static void createWalls()
        {

            Wall wall1 = new Wall("Green", -300, -1000, 45, 2000);
            Wall wall2 = new Wall("Green", 0, -1000, 45, 2000);
            Wall wall3 = new Wall("Blue", 400, -585, 200, 20);
            Wall wall5 = new Wall("Blue", 590, -585, 20, 1400);
            Wall wall6 = new Wall("Blue", 385, -585, 20, 1600);
            Wall wall7 = new Wall("Blue", 590, 790, 200, 20);
            Wall wall11 = new Wall("Blue", 730, 616, 275, 20);
            Wall wall8 = new Wall("Blue", 610, 328, 390, 20);
            Wall wall9 = new Wall("Green", -685, 910, 10, 75);
            Wall wall10 = new Wall("Green", -615, 910, 10, 75);
            //Wall wall111 = new Wall("Blue", -25, 650, 30, 350);
            //Wall wall15 = new Wall("Orange", -25, 650, 300, 30);
            //Wall wall12 = new Wall("Blue", 480, 450, 100, 120);
            //Wall wall156 = new Wall("Orange", 200, 600, 100, 120);
            //Wall wall13 = new Wall("Blue", 400, 275, 100, 120);
            //Wall wall14 = new Wall("Blue", 290, 343, 20, 15);
            //Wall wall16 = new Wall("Blue", 100, 200, 100, 120);
            //Wall wall99 = new Wall("Orange", 175, 425, 100, 115);
            //Wall wall100 = new Wall("Orange", -75, 200, 100, 115);
            //Wall wall101 = new Wall("Orange", -150, 100, 500, 30);
            //Wall wall102 = new Wall("Orange", -350, 100, 250, 30);
            //Wall wall103 = new Wall("Blue", -350, 100, 30, 350);
            //Wall wall104 = new Wall("Blue", -350, 425, 30, 200);
            //Wall wall105 = new Wall("Orange", -327, 727, 300, 30);
            //Wall wall106 = new Wall("Blue", 260, 185, 90, 90);
            //Wall wall107 = new Wall("Orange", -225, 450, 300, 120);
            //Wall wall108 = new Wall("Orange", -223, 250, 100, 120);
            //Wall wall112 = new Wall("Orange", -1000, -100, 2000, 30);
            //Wall wall113 = new Wall("Orange", -623, 727, 300, 30);
            //Wall wall114 = new Wall("Blue", -654, 410, 30, 350);
            //Wall wall115 = new Wall("Orange", -650, 300, 300, 30);
            //Wall wall116 = new Wall("Orange", -1000, 300, 375, 30);
            //Wall wall117 = new Wall("Green", -72, -400, 120, 15);
            //Wall wall118 = new Wall("Green", -72, -625, 120, 15);
            //Wall wall119 = new Wall("Green", -72, -625, 15, 230);
            //Wall wall120 = new Wall("Green", 33, -620, 15, 233);

          
        }
        public static void createPortals()
        {
            //Create teleport machines
            Teleporter t1 = new Teleporter(new PointF(-130, -927), 1);

            Teleporter t2 = new Teleporter(new PointF(500, -500), 1);

            Teleporter t3 = new Teleporter(new PointF(967, 381), 3);

            Teleporter t4 = new Teleporter(new PointF(-967, -967), 3);
        }

        public static void createEnemies()
        {
            //spawn some mobs
            EnemySoldier e2 = new EnemySoldier(new PointF(-150, 500));
            e2.changeWeapon(6);
            e2.pic = new Picture("Images/zombie1.png", e2.location, 1, 1);
            EnemySoldier e3 = new EnemySoldier(new PointF(-215, 0));
            e3.changeWeapon(6);
            e3.pic = new Picture("Images/zombie1.png", e3.location, 1, 1);
            //EnemySoldier e4 = new EnemySoldier(new PointF(-100, 100));
            //e4.changeWeapon(6);
            //EnemySoldier e5 = new EnemySoldier(new PointF(-75, 200));
            //e5.changeWeapon(6);
            //EnemySoldier e6 = new EnemySoldier(new PointF(-90, 360));
            //e6.changeWeapon(6);
            //EnemySoldier e7 = new EnemySoldier(new PointF(-115, -400));
            //e7.changeWeapon(6);
            //EnemySoldier e8 = new EnemySoldier(new PointF(-88, -300));
            //e8.changeWeapon(6);
            //EnemySoldier e9 = new EnemySoldier(new PointF(-175, -53));
            //e9.changeWeapon(6);
            //EnemySoldier e10 = new EnemySoldier(new PointF(-122, -204));
            //e10.changeWeapon(6);
            //EnemySoldier e11 = new EnemySoldier(new PointF(-50, 134));
            //e11.changeWeapon(6);
            //EnemySoldier e12 = new EnemySoldier(new PointF(-37, -413));
            //e12.changeWeapon(6);
            //EnemySoldier e13 = new EnemySoldier(new PointF(-143, -139));
            //e13.changeWeapon(6);
            //EnemySoldier e14 = new EnemySoldier(new PointF(-120, -500));
            //e14.changeWeapon(6);
            //EnemySoldier e15 = new EnemySoldier(new PointF(-55, -435));
            //e15.changeWeapon(6);
            //EnemySoldier e16 = new EnemySoldier(new PointF(-222, -344));
            //e16.changeWeapon(6);
            EnemySoldier e17 = new EnemySoldier(new PointF(-66, -274));
            e17.changeWeapon(6);
            e17.pic = new Picture("Images/zombie1.png", e17.location, 1, 1);
            EnemySoldier e18 = new EnemySoldier(new PointF(-39, -236));
            e18.changeWeapon(6);
            e18.pic = new Picture("Images/zombie1.png", e18.location, 1, 1);
            EnemySoldier e19 = new EnemySoldier(new PointF(-45, -299));
            e19.changeWeapon(6);
            e19.pic = new Picture("Images/zombie1.png", e19.location, 1, 1);
            EnemySoldier e20 = new EnemySoldier(new PointF(-105, -196));
            e20.changeWeapon(6);
            e20.pic = new Picture("Images/zombie1.png", e20.location, 1, 1);
            EnemySoldier e21 = new EnemySoldier(new PointF(-110, -214));
            e21.changeWeapon(6);
            e21.pic = new Picture("Images/zombie1.png", e21.location, 1, 1);
            EnemySoldier e22 = new EnemySoldier(new PointF(-130, -160));
            e22.changeWeapon(6);
            e22.pic = new Picture("Images/zombie1.png", e22.location, 1, 1);
            EnemySoldier e23 = new EnemySoldier(new PointF(-140, -76));
            e23.changeWeapon(6);
            e23.pic = new Picture("Images/zombie1.png", e23.location, 1, 1);
            EnemySoldier e24 = new EnemySoldier(new PointF(-170, -44));
            e24.changeWeapon(6);
            e24.pic = new Picture("Images/zombie1.png", e24.location, 1, 1);
            EnemySoldier e25 = new EnemySoldier(new PointF(-182, -12));
            e25.changeWeapon(6);
            e25.pic = new Picture("Images/zombie1.png", e25.location, 1, 1);
            EnemySoldier e26 = new EnemySoldier(new PointF(-188, 44));
            e26.changeWeapon(6);
            e26.pic = new Picture("Images/zombie1.png", e26.location, 1, 1);
            EnemySoldier e27 = new EnemySoldier(new PointF(-200, 532));
            e27.changeWeapon(6);
            e27.pic = new Picture("Images/zombie1.png", e27.location, 1, 1);
            EnemySoldier e28 = new EnemySoldier(new PointF(-113, 154));
            e28.changeWeapon(6);
            e28.pic = new Picture("Images/zombie1.png", e28.location, 1, 1);
            EnemySoldier e29 = new EnemySoldier(new PointF(-73, 188));
            e29.changeWeapon(6);
            e29.pic = new Picture("Images/zombie1.png", e29.location, 1, 1);
            EnemySoldier e30 = new EnemySoldier(new PointF(-99, 246));
            e30.changeWeapon(6);
            e30.pic = new Picture("Images/zombie1.png", e30.location, 1, 1);
            EnemySoldier e31 = new EnemySoldier(new PointF(-92, 333));
            e31.changeWeapon(6);
            e31.pic = new Picture("Images/zombie1.png", e31.location, 1, 1);
            EnemySoldier e32 = new EnemySoldier(new PointF(-61, 444));
            e32.changeWeapon(6);
            e32.pic = new Picture("Images/zombie1.png", e32.location, 1, 1);
            EnemySoldier e33 = new EnemySoldier(new PointF(-33, 467));
            e33.changeWeapon(6);
            e33.pic = new Picture("Images/zombie1.png", e33.location, 1, 1);
            EnemySoldier e34 = new EnemySoldier(new PointF(-199, 345));
            e34.changeWeapon(6);
            e34.pic = new Picture("Images/zombie1.png", e34.location, 1, 1);
            EnemySoldier e35 = new EnemySoldier(new PointF(-204, 321));
            e35.changeWeapon(6);
            e35.pic = new Picture("Images/zombie1.png", e35.location, 1, 1);
            EnemySoldier e36 = new EnemySoldier(new PointF(-214, 167));
            e36.changeWeapon(6);
            e36.pic = new Picture("Images/zombie1.png", e36.location, 1, 1);
            EnemySoldier e37 = new EnemySoldier(new PointF(-177, 95));
            e37.changeWeapon(6);
            e37.pic = new Picture("Images/zombie1.png", e37.location, 1, 1);
            EnemySoldier e38 = new EnemySoldier(new PointF(-188, -622));
            e38.changeWeapon(6);
            e38.pic = new Picture("Images/zombie1.png", e38.location, 1, 1);
            EnemySoldier e39 = new EnemySoldier(new PointF(-212, -650));
            e39.changeWeapon(6);
            e39.pic = new Picture("Images/zombie1.png", e39.location, 1, 1);
            EnemySoldier e40 = new EnemySoldier(new PointF(-65, -455));
            e40.changeWeapon(6);
            e40.pic = new Picture("Images/zombie1.png", e40.location, 1, 1);
            EnemySoldier e41 = new EnemySoldier(new PointF(500, -122));
            e41.changeWeapon(6);
            e41.pic = new Picture("Images/zombie1.png", e41.location, 1, 1);
            EnemySoldier e42 = new EnemySoldier(new PointF(494, 45));
            e42.changeWeapon(6);
            e42.pic = new Picture("Images/zombie1.png", e42.location, 1, 1);
            EnemySoldier e43 = new EnemySoldier(new PointF(503, -94));
            e43.changeWeapon(6);
            e43.pic = new Picture("Images/zombie1.png", e43.location, 1, 1);
            EnemySoldier e44 = new EnemySoldier(new PointF(506, 124));
            e44.changeWeapon(6);
            e44.pic = new Picture("Images/zombie1.png", e44.location, 1, 1);
            EnemySoldier e45 = new EnemySoldier(new PointF(499, 340));
            e45.changeWeapon(6);
            e45.pic = new Picture("Images/zombie1.png", e45.location, 1, 1);
            EnemySoldier e46 = new EnemySoldier(new PointF(502, 638));
            e46.changeWeapon(6);
            e46.pic = new Picture("Images/zombie1.png", e46.location, 1, 1);
            EnemySoldier e47 = new EnemySoldier(new PointF(509, 922));
            e47.changeWeapon(6);
            e47.pic = new Picture("Images/zombie1.png", e47.location, 1, 1);
            EnemySoldier e48 = new EnemySoldier(new PointF(950, 704));
            e48.changeWeapon(6);
            e48.pic = new Picture("Images/zombie1.png", e48.location, 1, 1);
        }

        public static void createLevel()
        {
            initalizeLists();
            MainForm.ground = new Picture("Images/Ground.png", new PointF(0, 0), 1, 1);
            MainForm.player1 = new Player(new PointF(-125, 900));
            MainForm.player1.HP = 15;
            MainForm.player1.moveSpeed = 6;
            
            createBorders(-1000, -1000, 2000, 2000);
            createWalls();
            createEnemies();
            createWeapons();
            createPortals();
            createBosses();

            MainForm.bossList[0].HP = 300;
            MainForm.bossList[0].moveSpeed = 6;
            MainForm.bossList[0].pic = new Picture("Images/zombie1.png", MainForm.bossList[0].location, 1, 1);
            MainForm.bossList[0].currentWeapon = new RapidGun(MainForm.bossList[0].location);
            MainForm.bossList[0].currentWeapon.fireDelay = 10;
            MainForm.bossList[0].currentWeapon.bulletSpeed = 20;
            MainForm.bossList[0].turnDirc = 2;

            MainForm.radar = new Radar();
        }
        public static void createWeapons()
        {
            RapidGun gun2 = new RapidGun(new PointF(870, 381));
            gun2.onGround = true;
            SuperBallLauncher gun3 = new SuperBallLauncher(new PointF(967, 583));
            gun3.onGround = true;
            SniperRifle gun4 = new SniperRifle(new PointF(665, 381));
            gun4.onGround = true;
            FlameThrower gun5 = new FlameThrower(new PointF(781, 381));
            gun5.onGround = true;
            ShotGun gun6 = new ShotGun(new PointF(-150, 750));
            gun6.onGround = true;
            ZombieGun gun7 = new ZombieGun(new PointF(-630, 970));
            gun7.onGround = true;
            HealthPack health1 = new HealthPack("Images/HealthPack.png", new PointF(800, 465));
            health1.onground = true;
            MainForm.healthList.Add(health1);
            HealthPack health2 = new HealthPack("Images/HealthPack.png", new PointF(780, 465));
            health2.onground = true;
            MainForm.healthList.Add(health2);
            HealthPack health3 = new HealthPack("Images/HealthPack.png", new PointF(820, 465));
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
