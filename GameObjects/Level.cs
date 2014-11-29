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
            EnemySoldier e1 = new EnemySoldier(new PointF(650, 100));
            e1.changeWeapon(1);
            EnemySoldier e2 = new EnemySoldier(new PointF(-150, 500));
            e2.changeWeapon(2);
            EnemySoldier e3 = new EnemySoldier(new PointF(-215, 0));
            e3.changeWeapon(1);
            EnemySoldier e4 = new EnemySoldier(new PointF(-100, 100));
            e4.changeWeapon(3);
            EnemySoldier e5 = new EnemySoldier(new PointF(-175, 70));
            e5.changeWeapon(1);
            EnemySoldier e6 = new EnemySoldier(new PointF(-143, -139));
            e6.changeWeapon(3);
            EnemySoldier e7 = new EnemySoldier(new PointF(-120, -500));
            e7.changeWeapon(2);
            EnemySoldier e8 = new EnemySoldier(new PointF(-55, -435));
            e8.changeWeapon(4);
            EnemySoldier e9 = new EnemySoldier(new PointF(-222, -344));
            e9.changeWeapon(2);
            EnemySoldier e10 = new EnemySoldier(new PointF(500, 120));
            e10.changeWeapon(5);
            EnemySoldier e11 = new EnemySoldier(new PointF(500, 150));
            e11.changeWeapon(4);
        }

        public static void createLevel()
        {
            initalizeLists();
            MainForm.ground = new Picture("Images/Ground.png", new PointF(0, 0), 1, 1);
            MainForm.player1 = new Player(new PointF(-150, 900));
            MainForm.player1.HP = 100;
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
        }

    }
}
