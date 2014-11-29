

namespace Sharpshooter_Fk
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.godModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAngle45ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weaponBarLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.HpAmountLabel = new System.Windows.Forms.Label();
            this.hittingWallLabel = new System.Windows.Forms.Label();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.PlayLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.PictureBox();
            this.continueLabel = new System.Windows.Forms.Label();
            this.ShotGunLabel = new System.Windows.Forms.Label();
            this.pauseScreen = new System.Windows.Forms.Label();
            this.FlameThrowerLabel = new System.Windows.Forms.Label();
            this.sniperGunLabel = new System.Windows.Forms.Label();
            this.SuperBallLauncherLabel = new System.Windows.Forms.Label();
            this.RapidGunLabel = new System.Windows.Forms.Label();
            this.pistolLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.PictureBox();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 25;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(792, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.godModeToolStripMenuItem,
            this.changeAngle45ToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // godModeToolStripMenuItem
            // 
            this.godModeToolStripMenuItem.Name = "godModeToolStripMenuItem";
            this.godModeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.godModeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.godModeToolStripMenuItem.Text = "God Mode";
            this.godModeToolStripMenuItem.Click += new System.EventHandler(this.godModeToolStripMenuItem_Click);
            // 
            // changeAngle45ToolStripMenuItem
            // 
            this.changeAngle45ToolStripMenuItem.Name = "changeAngle45ToolStripMenuItem";
            this.changeAngle45ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.changeAngle45ToolStripMenuItem.Text = "Change Angle 45";
            this.changeAngle45ToolStripMenuItem.Click += new System.EventHandler(this.changeAngle45ToolStripMenuItem_Click);
            // 
            // weaponBarLabel
            // 
            this.weaponBarLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weaponBarLabel.Location = new System.Drawing.Point(0, 535);
            this.weaponBarLabel.Name = "weaponBarLabel";
            this.weaponBarLabel.Size = new System.Drawing.Size(792, 52);
            this.weaponBarLabel.TabIndex = 9;
            this.weaponBarLabel.Text = "label1";
            // 
            // healthLabel
            // 
            this.healthLabel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.Color.Red;
            this.healthLabel.Location = new System.Drawing.Point(620, 545);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(39, 23);
            this.healthLabel.TabIndex = 10;
            this.healthLabel.Text = "Life";
            // 
            // HpAmountLabel
            // 
            this.HpAmountLabel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HpAmountLabel.ForeColor = System.Drawing.Color.Red;
            this.HpAmountLabel.Location = new System.Drawing.Point(665, 545);
            this.HpAmountLabel.Name = "HpAmountLabel";
            this.HpAmountLabel.Size = new System.Drawing.Size(115, 32);
            this.HpAmountLabel.TabIndex = 12;
            // 
            // hittingWallLabel
            // 
            this.hittingWallLabel.AutoSize = true;
            this.hittingWallLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hittingWallLabel.Location = new System.Drawing.Point(132, 217);
            this.hittingWallLabel.Name = "hittingWallLabel";
            this.hittingWallLabel.Size = new System.Drawing.Size(0, 13);
            this.hittingWallLabel.TabIndex = 13;
            // 
            // pauseLabel
            // 
            this.pauseLabel.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseLabel.ForeColor = System.Drawing.Color.Red;
            this.pauseLabel.Location = new System.Drawing.Point(452, 545);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(149, 32);
            this.pauseLabel.TabIndex = 16;
            this.pauseLabel.Text = "Pause";
            this.pauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pauseLabel.Click += new System.EventHandler(this.pauseLabel_Click);
            // 
            // PlayLabel
            // 
            this.PlayLabel.BackColor = System.Drawing.Color.Black;
            this.PlayLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.PlayLabel.Image = global::Sharpshooter_Fk.Properties.Resources.begin;
            this.PlayLabel.Location = new System.Drawing.Point(256, 283);
            this.PlayLabel.Name = "PlayLabel";
            this.PlayLabel.Size = new System.Drawing.Size(275, 51);
            this.PlayLabel.TabIndex = 15;
            this.PlayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayLabel.Click += new System.EventHandler(this.Play_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Image = global::Sharpshooter_Fk.Properties.Resources.Title;
            this.TitleLabel.Location = new System.Drawing.Point(-1, 25);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(801, 567);
            this.TitleLabel.TabIndex = 14;
            this.TitleLabel.TabStop = false;
            // 
            // continueLabel
            // 
            this.continueLabel.BackColor = System.Drawing.Color.Black;
            this.continueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueLabel.ForeColor = System.Drawing.Color.Red;
            this.continueLabel.Image = global::Sharpshooter_Fk.Properties.Resources._continue;
            this.continueLabel.Location = new System.Drawing.Point(344, 349);
            this.continueLabel.Name = "continueLabel";
            this.continueLabel.Size = new System.Drawing.Size(84, 25);
            this.continueLabel.TabIndex = 19;
            this.continueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.continueLabel.Visible = false;
            this.continueLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShotGunLabel
            // 
            this.ShotGunLabel.Image = global::Sharpshooter_Fk.Properties.Resources.ShotGun;
            this.ShotGunLabel.Location = new System.Drawing.Point(377, 545);
            this.ShotGunLabel.Name = "ShotGunLabel";
            this.ShotGunLabel.Size = new System.Drawing.Size(60, 29);
            this.ShotGunLabel.TabIndex = 18;
            this.ShotGunLabel.Visible = false;
            this.ShotGunLabel.Click += new System.EventHandler(this.ShotGunLabel_Click);
            // 
            // pauseScreen
            // 
            this.pauseScreen.Image = global::Sharpshooter_Fk.Properties.Resources.pauseScreen;
            this.pauseScreen.Location = new System.Drawing.Point(216, 198);
            this.pauseScreen.Name = "pauseScreen";
            this.pauseScreen.Size = new System.Drawing.Size(328, 108);
            this.pauseScreen.TabIndex = 17;
            this.pauseScreen.Visible = false;
            // 
            // FlameThrowerLabel
            // 
            this.FlameThrowerLabel.Image = global::Sharpshooter_Fk.Properties.Resources.FlameThrower;
            this.FlameThrowerLabel.Location = new System.Drawing.Point(319, 547);
            this.FlameThrowerLabel.Name = "FlameThrowerLabel";
            this.FlameThrowerLabel.Size = new System.Drawing.Size(69, 27);
            this.FlameThrowerLabel.TabIndex = 8;
            this.FlameThrowerLabel.Visible = false;
            this.FlameThrowerLabel.Click += new System.EventHandler(this.FlameThrowerLabel_Click);
            // 
            // sniperGunLabel
            // 
            this.sniperGunLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.sniperGunLabel.Image = global::Sharpshooter_Fk.Properties.Resources.SniperGun;
            this.sniperGunLabel.Location = new System.Drawing.Point(236, 545);
            this.sniperGunLabel.Name = "sniperGunLabel";
            this.sniperGunLabel.Size = new System.Drawing.Size(77, 32);
            this.sniperGunLabel.TabIndex = 6;
            this.sniperGunLabel.Visible = false;
            this.sniperGunLabel.Click += new System.EventHandler(this.sniperGunLabel_Click);
            // 
            // SuperBallLauncherLabel
            // 
            this.SuperBallLauncherLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SuperBallLauncherLabel.Image = global::Sharpshooter_Fk.Properties.Resources.SuperBallLauncher;
            this.SuperBallLauncherLabel.Location = new System.Drawing.Point(172, 545);
            this.SuperBallLauncherLabel.Name = "SuperBallLauncherLabel";
            this.SuperBallLauncherLabel.Size = new System.Drawing.Size(69, 32);
            this.SuperBallLauncherLabel.TabIndex = 5;
            this.SuperBallLauncherLabel.Visible = false;
            this.SuperBallLauncherLabel.Click += new System.EventHandler(this.SuperBallLauncherLabel_Click);
            // 
            // RapidGunLabel
            // 
            this.RapidGunLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RapidGunLabel.Image = global::Sharpshooter_Fk.Properties.Resources.RapidGun;
            this.RapidGunLabel.Location = new System.Drawing.Point(110, 545);
            this.RapidGunLabel.Name = "RapidGunLabel";
            this.RapidGunLabel.Size = new System.Drawing.Size(55, 32);
            this.RapidGunLabel.TabIndex = 4;
            this.RapidGunLabel.Visible = false;
            this.RapidGunLabel.Click += new System.EventHandler(this.RapidGunLabel_Click);
            // 
            // pistolLabel
            // 
            this.pistolLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pistolLabel.Image = global::Sharpshooter_Fk.Properties.Resources.Pistol;
            this.pistolLabel.Location = new System.Drawing.Point(49, 545);
            this.pistolLabel.Name = "pistolLabel";
            this.pistolLabel.Size = new System.Drawing.Size(55, 32);
            this.pistolLabel.TabIndex = 3;
            this.pistolLabel.Click += new System.EventHandler(this.pistolLabel_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(0, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(800, 620);
            this.title.TabIndex = 1;
            this.title.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(792, 586);
            this.Controls.Add(this.PlayLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.continueLabel);
            this.Controls.Add(this.ShotGunLabel);
            this.Controls.Add(this.pauseScreen);
            this.Controls.Add(this.pauseLabel);
            this.Controls.Add(this.hittingWallLabel);
            this.Controls.Add(this.HpAmountLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.FlameThrowerLabel);
            this.Controls.Add(this.sniperGunLabel);
            this.Controls.Add(this.SuperBallLauncherLabel);
            this.Controls.Add(this.RapidGunLabel);
            this.Controls.Add(this.pistolLabel);
            this.Controls.Add(this.weaponBarLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "SharpShooter";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.PictureBox title;
        public System.Windows.Forms.Label pistolLabel;
        public System.Windows.Forms.Label RapidGunLabel;
        public System.Windows.Forms.Label SuperBallLauncherLabel;
        public System.Windows.Forms.Label sniperGunLabel;
        private System.Windows.Forms.Label FlameThrowerLabel;
        private System.Windows.Forms.ToolStripMenuItem godModeToolStripMenuItem;
        private System.Windows.Forms.Label weaponBarLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Label HpAmountLabel;
        private System.Windows.Forms.Label hittingWallLabel;
        private System.Windows.Forms.ToolStripMenuItem changeAngle45ToolStripMenuItem;
        private System.Windows.Forms.PictureBox TitleLabel;
        private System.Windows.Forms.Label PlayLabel;
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.Label pauseScreen;
        private System.Windows.Forms.Label ShotGunLabel;
        private System.Windows.Forms.Label continueLabel;
    }
}

