using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SimpleGame
{
    public partial class SimpleGame : Form
    {

        public string Info = "SimpleGame v0.07 29-12-2016";

        public bool DebugMode = false;

        SoundPlayer soundShoot = new SoundPlayer(Properties.Resources.ulti);
        SoundPlayer soundUlti = new SoundPlayer(Properties.Resources.shoot);
        SoundPlayer soundEmpty = new SoundPlayer(Properties.Resources.empty);
        SoundPlayer soundHit = new SoundPlayer(Properties.Resources.hit);
        SoundPlayer soundHit2 = new SoundPlayer(Properties.Resources.hit2);


        Brush myBrush = new SolidBrush(Color.Firebrick);
        Brush whiteBrush = new SolidBrush(Color.White);
        



        GameWindow gameWindow = new GameWindow();

        Ship ship = new Ship();
        Bullet bullet1 = new Bullet();

        List<Bullet> bullets = new List<Bullet>
        {
        //     new Bullet(){Name = "bulletA", X = 200, Y = 200, Visible = true },
        };

        List<Asteroid> asteroids = new List<Asteroid>
        {
          //       new Asteroid(){Name = "bulletA", X = 200, Y = 200, Visible = true },
        };

        List<Asteroid> bonuses = new List<Asteroid> {
                   new BonusAmmo(){Name = "AmmoA", X = 200, Y = 200},
                   new BonusHP(){Name = "HPA", X = 250, Y = 200},
                   new BonusFuel(){Name = "HPA", X = 300, Y = 200},
        };


        Random random1 = new Random();

        int MouseX = 50;
        int MouseY = 50;

        public SimpleGame()
        {
            InitializeComponent();

            tabControl.Location = new Point(-7, -24);
            canvas.Size = new Size(600, 600);
            gameWindow.SetSize(600, 600);
            timerGameTick.Enabled = false;
            timerRefresh.Enabled = true;
        }


        public void ResetGame()
        {
            ship.Reset();
            gameWindow.Score = 0;
            gameWindow.GameLevel = 1;           
        }

        public void Ultimate()
        {
                if (ship.Ultimate > 0)
                {
                    ship.Ultimate--;

                    for(int i = 0; i<8; i++)
                    {
                        bullets.Add(new Bullet() { Visible = true, });
                    }


                    gameWindow.NumberOfBullets = bullets.Count();

                    bullets[gameWindow.NumberOfBullets - 1].shoot(ship.Xabs, ship.Yabs, ship.Xabs + 0, ship.Yabs + 20);
                    bullets[gameWindow.NumberOfBullets - 2].shoot(ship.Xabs, ship.Yabs, ship.Xabs + 20, ship.Yabs + 20);
                    bullets[gameWindow.NumberOfBullets - 3].shoot(ship.Xabs, ship.Yabs, ship.Xabs + 20, ship.Yabs + 0);
                    bullets[gameWindow.NumberOfBullets - 4].shoot(ship.Xabs, ship.Yabs, ship.Xabs + 20, ship.Yabs  - 20);
                    bullets[gameWindow.NumberOfBullets - 5].shoot(ship.Xabs, ship.Yabs, ship.Xabs + 0, ship.Yabs - 20);
                    bullets[gameWindow.NumberOfBullets - 6].shoot(ship.Xabs, ship.Yabs, ship.Xabs - 20, ship.Yabs - 20);
                    bullets[gameWindow.NumberOfBullets - 7].shoot(ship.Xabs, ship.Yabs, ship.Xabs - 20, ship.Yabs + 0);
                    bullets[gameWindow.NumberOfBullets - 8].shoot(ship.Xabs, ship.Yabs, ship.Xabs - 20, ship.Yabs + 20);


                soundUlti.Play();
                }
                else
                {
                    soundEmpty.Play();
                }
        }


        public void StopGame()
        {
            gameWindow.GameStop = true;
        }

        public void StartNewLevel(int level)
        {
            gameWindow.GameStop = true;
            labelPopUp.Text = "Level " + gameWindow.GameLevel;
            labelPopUp.Visible = true;
            timerPopUp.Enabled = true;

            gameWindow.GameLevel = level;

            int asteroids = 2 + gameWindow.GameLevel;



            for (int i = 0; i < asteroids; i++)
            {
                Respawn_Asteroid();
            }

            ship.velocityX = 0;
            ship.velocityY = 0;
            ship.Initialize(gameWindow.centerX, gameWindow.centerY);

            RefreshView();

            timerRefresh.Enabled = true;   // Start Refresh
            timerGameTick.Enabled = true;   // Start Game Timer
        }


        public void Respawn_Asteroid()
        {
            int Xrand = random1.Next(0, 600);
            int Yrand = random1.Next(0, 600);
            int VXrand = random1.Next(-10 -gameWindow.GameLevel, 10 + gameWindow.GameLevel);
            int VYrand = random1.Next(-10 - -gameWindow.GameLevel, 10 + gameWindow.GameLevel);
            int Srand = random1.Next(20 + gameWindow.GameLevel * 5, 100+ gameWindow.GameLevel*5);
            int Crand = random1.Next(0, 10);

            if(Xrand > 250 && Xrand < 350)
            {
                Xrand = random1.Next(0, 600);
            }

            if (Yrand > 250 && Yrand < 350)
            {
                Yrand = random1.Next(0, 600);
            }

            asteroids.Add(new Asteroid()
            {
                Visible = true,
            });

            gameWindow.NumberOfAsteroids = asteroids.Count();
            asteroids[gameWindow.NumberOfAsteroids - 1].Spawn(Xrand, Yrand, VXrand, VYrand, Srand, Crand);

        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                //    ship.positionX = ship.positionX - gameWindow.UnitLength;
                ship.velocityX = ship.velocityX - 3;
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                //    ship.positionX = ship.positionX + gameWindow.UnitLength;
                ship.velocityX = ship.velocityX + 3;
                return true;
            }

            //capture up arrow key
            if (keyData == Keys.Up)
            {
                //   ship.positionY = ship.positionY - gameWindow.UnitHeight;
                ship.velocityY = ship.velocityY - 3;
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                ship.velocityY = ship.velocityY + 3;
                //     ship.positionY = ship.positionY + gameWindow.UnitHeight;
                return true;
            }
            //capture down ctrl key
            if (keyData == Keys.X)
            {
                Ultimate();
                return true;
            }
            // Space Pressed = Game Stop
            if (keyData == Keys.P)
            {
                gameWindow.GameStop = !gameWindow.GameStop;
                if (gameWindow.GameStop == true)
                {
                    buttonStopGame.Text = "Start";
                    buttonStopGame.BackColor = System.Drawing.Color.LimeGreen;
                }
                else if (gameWindow.GameStop == false)
                {
                    buttonStopGame.Text = "Stop";
                    buttonStopGame.BackColor = System.Drawing.Color.Firebrick;
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            RefreshView();
        }




        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = canvas.CreateGraphics();

            Pen whitePen = new Pen(whiteBrush, 1);
            g.DrawLine(whitePen, ship.Xabs, ship.Yabs, MouseX, MouseY);

            
            

            foreach (Asteroid a in asteroids)
            {
                a.draw(g);
            }

            foreach (Bullet b in bullets)
            {
                b.drawBullet(g);
            }


            bonuses[0].draw(g);
            bonuses[1].draw(g);
            bonuses[2].draw(g);

            ship.drawShip(g);

        }

        public void RefreshView()
        {
            if (DebugMode == true)
            {
                debugBox.Visible = true;
                gameWindow.NumberOfBullets = bullets.Count();
                gameWindow.NumberOfAsteroids = asteroids.Count();
                labelBullets.Text = gameWindow.NumberOfBullets.ToString();
                labelAsteroids.Text = gameWindow.NumberOfAsteroids.ToString();
                labelPositionAbs.Text = (ship.Xabs).ToString("F") + "," + ship.Yabs.ToString("F");
                labelSpeed.Text = (ship.velocityX).ToString("F") + "," + (ship.velocityY).ToString("F");
                labelSize.Text = (canvas.Size.Height).ToString() + "," + (canvas.Size.Width).ToString();
                labelAngle.Text = ship.Angle.ToString("F");
            }
            else
            {
                debugBox.Visible = false;
            }

            labelScore.Text = gameWindow.Score.ToString();
            labelLevel.Text = gameWindow.GameLevel.ToString();
            labelAmmo.Text = ship.Ammo.ToString();
            labelUltimate.Text = ship.Ultimate.ToString();
            labelHP.Text = ship.HP.ToString() + " / 100";
            labelFuel.Text = ship.Fuel.ToString() + " / 200";


            canvas.Refresh();
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            MouseX = e.Location.X;
            MouseY = e.Location.Y;
        }

        private void canvas_Click(object sender, EventArgs e)
        {

        }

        private void timerGameTick_Tick(object sender, EventArgs e)
        {
            gameWindow.NumberOfAsteroids = asteroids.Count();
            if (gameWindow.NumberOfAsteroids == 0)
            {
                gameWindow.GameLevel++;
                ship.Reset();
                StartNewLevel(gameWindow.GameLevel);

            }


            if (gameWindow.GameStop == false)
            {
                ship.refresh();

                if(gameWindow.StopOnWalls == true) // Not Working Good - need to fix this
                {
                    if (ship.Xabs > (gameWindow.XSize - ship.length / 2)) ship.Xabs = (gameWindow.XSize - ship.length / 2);
                    if (ship.Xabs <= (0 + ship.length/2)) ship.Xabs = (0 + ship.length / 2);
                    if (ship.Yabs > (gameWindow.YSize - ship.heigh / 2)) ship.Yabs = (gameWindow.YSize - ship.heigh / 2);
                    if (ship.Yabs <= (0 + ship.heigh/2)) ship.Yabs = (0 + ship.heigh / 2);
                }
                else if(gameWindow.StopOnWalls == false)
                {
                    if (ship.Xabs > gameWindow.XSize) ship.Xabs = (0 + ship.length / 2);
                    if (ship.Xabs <= 0) ship.Xabs = (gameWindow.XSize - ship.length / 2);
                    if (ship.Yabs > gameWindow.YSize) ship.Yabs = (0 + ship.heigh / 2);
                    if (ship.Yabs <= 0) ship.Yabs = (gameWindow.YSize - ship.heigh / 2);
                }

                foreach (Bullet b in bullets)
                {
                    b.refresh();
                }

                foreach (Bullet b in bullets)
                {
                    
                    if (b.isInRange(0, 0, gameWindow.XSize, gameWindow.YSize) == false)
                    {
                        bullets.Remove(b);
                        break;
                    }
                }

                foreach (Asteroid a in asteroids)
                {
                    Asteroid tempA = asteroids[0];
                    Bullet tempB = bullet1;
                    bool AsteroidtoRemove = false;
                    bool BullettoRemove = false;

                    a.refresh();

                    if (a.X > gameWindow.XSize)     a.X = 0;
                    if (a.X < 0)                    a.X = gameWindow.XSize;
                    if (a.Y > gameWindow.YSize)     a.Y = 0;
                    if (a.Y < 0)                    a.Y = gameWindow.YSize;

                    if (((a.X - ship.Xabs) * (a.X - ship.Xabs) + (a.Y - ship.Yabs) * (a.Y - ship.Yabs)) - ((a.size / 2) * (a.size / 2)) < 10)
                    {
                        ship.HP = ship.HP - 3;                        
                        if(ship.HP < 0)
                        {
                            ship.HP = 0;
                            labelScoreFinall.Text = "Score: " + gameWindow.Score.ToString();
                            labelLevelFinall.Text = "Level: " + gameWindow.GameLevel.ToString();
                            tabControl.SelectedIndex = 4;   // Go to Score;
                            soundHit.Play();
                            break;
                        }

                    }

                        foreach (Bullet b in bullets)
                    {
                        if (((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y)) - ((a.size/2)*(a.size/2)) < 10)
                        {
                            a.HP = a.HP - 15;
                            tempB = b;
                            BullettoRemove = true;
                            if (a.HP <= 15)
                            {
                                tempA = a;
                                AsteroidtoRemove = true;
                            }
                        }
                    }
                    if (AsteroidtoRemove)
                    {
                        asteroids.Remove(tempA);
                        gameWindow.Score++;
                        break;
                    }
                    if (BullettoRemove)
                    {
                        bullets.Remove(tempB);
                        break;
                    }

                }

            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (gameWindow.GameStop == false)
                {
                    if (ship.Ammo > 0)
                    {
                        ship.Ammo--;

                        bullets.Add(new Bullet()
                        {
                            Visible = true,
                        });

                        gameWindow.NumberOfBullets = bullets.Count();

                        bullets[gameWindow.NumberOfBullets - 1].shoot(ship.Xabs, ship.Yabs, MouseX, MouseY);
                        soundShoot.Play();
                    }

                    else
                    {
                        soundEmpty.Play();
                    }
                }
            }


            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (gameWindow.GameStop == false)
                {
                    float A = MouseX - ship.Xabs;
                    float B = MouseY - ship.Yabs;
                    ship.Angle = (float)(Math.Atan2(A, B) / Math.PI);

                    if (ship.Fuel > 0)
                    {
                        ship.velocityX = ship.velocityX + (float)Math.Sin(ship.Angle * Math.PI);
                        ship.velocityY = ship.velocityY + (float)Math.Cos(ship.Angle * Math.PI);
                    }


                    ship.Fuel = ship.Fuel - 10;
                    if (ship.Fuel < 0) ship.Fuel = 0;
                }
            }

         }
        

        private void buttonStopGame_Click(object sender, EventArgs e)
        {
            gameWindow.GameStop = !gameWindow.GameStop;

            if(gameWindow.GameStop == true)
            {
                buttonStopGame.Text = "Start";
                buttonStopGame.BackColor = System.Drawing.Color.LimeGreen;
            }
            else if(gameWindow.GameStop == false)
            {
                buttonStopGame.Text = "Stop";
                buttonStopGame.BackColor = System.Drawing.Color.Firebrick;
            }
        }

        private void debugBox_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timerGameTick.Enabled = false;
            timerGameTick.Interval = (int)(numericUpDown1.Value);
            timerGameTick.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartNewLevel(gameWindow.GameLevel);
            gameWindow.GameLevel++;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DebugMode = !DebugMode;
            if(DebugMode == true)
            {
                checkBox1.Checked = true;
            }
            else if(DebugMode == false)
            {
                checkBox1.Checked = false;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();    // Exit the game
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            ResetGame();
            tabControl.SelectedIndex = 1; // Go to ShipSelection
            soundHit.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
            soundHit.Play();
            ResetGame();
            StartNewLevel(1);
        }

        private void buttonBack3_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;  // Move back to MainMenu
            soundHit.Play();
        }

        private void buttonBack1_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;   // Move back to MainMenu
            soundHit.Play();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 6;   // Go to Info
            soundHit.Play();
            labelInfo.Text = Info;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 5;   // Go to Settings
            soundHit.Play();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;   // Go to How to Play
            soundHit.Play();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;   // Start New Game
            soundHit.Play();
            StartNewLevel(1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;   // Move back to ShipSelection
            soundHit.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;   // Move back to MainMenu
            soundHit.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;   // Move back to MainMenu
            soundHit.Play();
        }

        private void timerPopUp_Tick(object sender, EventArgs e)
        {
            labelPopUp.Visible = false;
            timerPopUp.Enabled = false;
            gameWindow.GameStop = false;
        }
    }
}
