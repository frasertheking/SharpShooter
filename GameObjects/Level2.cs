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
            MainForm.floorList = new List<Floor>();
            MainForm.explosionList = new List<Explosion>();
            MainForm.weaponList = new List<Weapon>();
            MainForm.playerWeaponList = new List<Weapon>();
            MainForm.teleportList = new List<Teleporter>();
            MainForm.switchList = new List<Switch>();
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
            Boss tank1 = new Boss(new PointF(415, -1500));
            tank1.currentWeapon.fireDelay = 300;
            tank1.currentWeapon.bulletSpeed = 15;

        }

        public static void createWalls()
        {
            // x, y, width, height
            Wall wall1 = new Wall("Orange", 100, 650, 218, 30);
            Wall wall2 = new Wall("Orange", 450, 650, 218, 30);
            Wall wall3 = new Wall("Orange", 450, 650, 15, 114);
            Wall wall4 = new Wall("Orange", 303, 650, 15, 114);
            Wall wall5 = new Wall("Blue", 318, 754, 133, 10);
            Wall wall6 = new Wall("Orange", 100, 257, 30, 400);
            Wall wall7 = new Wall("Orange", 637, 257, 30, 400);
            Wall wall8 = new Wall("Orange", 100, 250, 218, 30);
            Wall wall9 = new Wall("Orange", 450, 250, 218, 30);
            Wall wall10 = new Wall("Orange", 287, 102, 30, 150);
            Wall wall11 = new Wall("Orange", 450, 102, 30, 150);
            Wall wall12 = new Wall("Orange", 70, -35, 626, 30);
            Wall wall13 = new Wall("Orange", -133, 102, 450, 30);
            Wall wall14 = new Wall("Orange", 450, 102, 450, 30);
            Wall wall15 = new Wall("Orange", -133, -300, 30, 425);
            Wall wall16 = new Wall("Orange", 866, -300, 30, 425);
            Wall wall17 = new Wall("Orange", 69, -275, 30, 250);
            Wall wall18 = new Wall("Orange", 664, -275, 30, 270);////
            Wall wall19 = new Wall("Orange", 866, -300, 350, 30);
            Wall wall20 = new Wall("Orange", 866, -450, 525, 30);
            Wall wall21 = new Wall("Orange", 1211, -300, 30, 300);
            Wall wall22 = new Wall("Orange", 1375, -450, 30, 300);
            Wall wall23 = new Wall("Orange", 1211, -13, 325, 30);
            Wall wall24 = new Wall("Orange", 1375, -162, 161, 30);
            Wall wall25 = new Wall("Orange", 1533, -245, 15, 114);
            Wall wall26 = new Wall("Orange", 1532, -12, 15, 114);
            Wall wall27 = new Wall("Orange", 1546, -245, 450, 30);
            Wall wall28 = new Wall("Orange", 1546, 72, 470, 30);
            Wall wall29 = new Wall("Orange", 1990, -245, 30, 348);
            Wall wall30 = new Wall("Orange", 1625, -50, 80, 60);
            Wall wall31 = new Wall("Orange", 1625, -150, 80, 60);
            Wall wall32 = new Wall("Orange", 1800, -50, 80, 60);
            Wall wall33 = new Wall("Orange", 1800, -150, 80, 60);
            Wall wall34 = new Wall("Orange", 550, -450, 400, 30);
            Wall wall35 = new Wall("Orange", 377, -300, 318, 30);
            Wall wall36 = new Wall("Orange", 357, -567, 30, 300);
            Wall wall37 = new Wall("Orange", 550, -567, 30, 130);
            Wall wall38 = new Wall("Orange", 500, -567, 50, 15);
            Wall wall39 = new Wall("Orange", 385, -567, 50, 15);
            Wall wall40 = new Wall("Blue", 435, -567, 65, 15);
            Wall wall41 = new Wall("Orange", 69, -820, 30, 555);
            Wall wall42 = new Wall("Orange", -325, -820, 410, 30);
            Wall wall43 = new Wall("Orange", -325, -820, 30, 175);
            Wall wall44 = new Wall("Orange", -325, -660, 200, 30);
            Wall wall45 = new Wall("Orange", -130, -660, 30, 200);
            Wall wall46 = new Wall("Orange", -595, -462, 496, 30);
            Wall wall47 = new Wall("Orange", -595, -300, 490, 30);
            Wall wall48 = new Wall("Orange", -595, -462, 30, 170);
            Wall wall49 = new Wall("Orange", -495, -432, 30, 65);
            Wall wall50 = new Wall("Orange", -295, -432, 30, 65);
            Wall wall51 = new Wall("Orange", -395, -365, 30, 65);
            Wall wall52 = new Wall("Orange", -195, -365, 30, 65);
            Wall wall53 = new Wall("Orange", 357, -1060, 30, 500);
            Wall wall54 = new Wall("Orange", 550, -1060, 30, 500);
            Wall wall55 = new Wall("Green", 579, -1060, 500, 50);
            Wall wall56 = new Wall("Green", -139, -1060, 500, 50);
            Wall wall57 = new Wall("Green", 1060, -1810, 50, 800);
            Wall wall58 = new Wall("Green", -150, -1810, 50, 800);
            Wall wall59 = new Wall("Green", -150, -1810, 1225, 50);
        }

        public static void createPortals()
        {
            //Creat teleport machines
            Teleporter t1 = new Teleporter(new PointF(469, -485), 1);
            Teleporter t2 = new Teleporter(new PointF(469, -635), 1);
        }

        public static void createSwitches()
        {
            //Creat switches
            Switch s1 = new Switch(new PointF(-529, -393),1);
            Switch s2 = new Switch(new PointF(1950, -73), 1);
        }

        public static void createEnemies()
        {
            //spawn some mobs
            EnemySoldier e1 = new EnemySoldier(new PointF(650, 100));
            e1.changeWeapon(1);
            EnemySoldier e2 = new EnemySoldier(new PointF(-25, 42));
            e2.changeWeapon(1);
            EnemySoldier e3 = new EnemySoldier(new PointF(-524, -343));
            e3.changeWeapon(4);
            EnemySoldier e4 = new EnemySoldier(new PointF(-10, -720));
            e4.changeWeapon(3);
            EnemySoldier e5 = new EnemySoldier(new PointF(775, -140));
            e5.changeWeapon(4);
            EnemySoldier e6 = new EnemySoldier(new PointF(436, -515));
            e6.changeWeapon(5);
            EnemySoldier e7 = new EnemySoldier(new PointF(1751, -181));
            e7.changeWeapon(4);
            EnemySoldier e8 = new EnemySoldier(new PointF(1751, 39));
            e8.changeWeapon(4);            
            EnemySoldier e9 = new EnemySoldier(new PointF(1319, -233));
            e9.changeWeapon(2);
            EnemySoldier e10 = new EnemySoldier(new PointF(-34, -357));
            e10.changeWeapon(4);
        }

        public static void createFloor()
        {
            /*Floor floor1 = new Floor("square", 100, 255, 565, 400);
            Floor floor2 = new Floor("square", 315, 645, 150, 120);
            Floor floor3 = new Floor("square", 315, 110, 160, 155);
            Floor floor4 = new Floor("wide", -133, -35, 1008, 150);
            Floor floor5 = new Floor("tall", -130, -435, 204, 407);
            Floor floor6 = new Floor("tall", 675, -435, 200, 407);
            Floor floor7 = new Floor("wide", 860, -425, 525, 145);
            Floor floor8 = new Floor("tall", 1240, -300, 150, 305);
            Floor floor9 = new Floor("wide", 1375, -145, 173, 135);
            Floor floor10 = new Floor("square", 1545, -220, 450, 300);
            Floor floor11 = new Floor("wide", 375, -425, 305, 155);
            Floor floor12 = new Floor("square", 385, -555, 170, 135);
            Floor floor13 = new Floor("wide", -595, -462, 475, 175);
            Floor floor14 = new Floor("tall", -110, -820, 185, 400);
            Floor floor15 = new Floor("square", -300, -820, 200, 180);*/
        }

        public static void createLevel()
        {
            initalizeLists();
            MainForm.ground = new Picture("Images/Ground.png", new PointF(0, 0), 1, 1);
            MainForm.player1 = new Player(new PointF(380, 675));
            MainForm.player1.HP = 100;
            MainForm.lifeBarValue = 100;
            MainForm.player1.moveSpeed = 6;
            
            createBorders(-1000, -1000, 2000, 2000);
            createWalls();
            createFloor();
            createEnemies();
            createWeapons();
            createPortals();
            createSwitches();
            createBosses();

            MainForm.bossList[0].HP = 660;
            MainForm.bossList[0].moveSpeed = 7;

            MainForm.radar = new Radar();
        }
        public static void createWeapons()
        {
            RapidGun gun2 = new RapidGun(new PointF(220, 450));
            gun2.onGround = true;
            SuperBallLauncher gun3 = new SuperBallLauncher(new PointF(1750, -70));
            gun3.onGround = true;
            SniperRifle gun4 = new SniperRifle(new PointF(422, -333));
            gun4.onGround = true;
            FlameThrower gun5 = new FlameThrower(new PointF(-252, -752));
            gun5.onGround = true;            
            ShotGun gun6 = new ShotGun(new PointF(470, -870));
            gun6.onGround = true;

            //LaserGun gun7 = new LaserGun(new PointF(833, 680));
            //gun7.onGround = true;

            HealthPack health1 = new HealthPack("Images/HealthPack.png", new PointF(-252, -700));
            health1.onground = true;
            MainForm.healthList.Add(health1);
            HealthPack health2 = new HealthPack("Images/HealthPack.png", new PointF(1950, 33));
            health2.onground = true;
            MainForm.healthList.Add(health2);
            //HealthPack health3 = new HealthPack("Images/HealthPack.png", new PointF(-8, -682));
            //health3.onground = true;
            //MainForm.healthList.Add(health3);

            MainForm.weaponList.Add(gun2);
            MainForm.weaponList.Add(gun3);
            MainForm.weaponList.Add(gun4);
            MainForm.weaponList.Add(gun5);
            //MainForm.weaponList.Add(gun6);
            //MainForm.weaponList.Add(gun7);

        }

    }
}
