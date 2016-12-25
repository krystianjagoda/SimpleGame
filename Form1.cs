using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGame
{
    public partial class SimpleGame : Form
    {
        public bool DebugMode = true;


        Brush myBrush = new SolidBrush(Color.Firebrick);
        Brush whiteBrush = new SolidBrush(Color.White);



        GameWindow gameWindow = new GameWindow();

        Ship ship = new Ship();
        Bullet bullet1 = new Bullet();

        List<Bullet> bullets = new List<Bullet>
        {
        //     new Bullet(){Name = "bulletA", X = 200, Y = 200, Visible = true },
        //     new Bullet(){Name = "bulletB", X = 100, Y = 100, Visible = true },
        };

        List<Asteroid> asteroids = new List<Asteroid>
        {
          //       new Asteroid(){Name = "bulletA", X = 200, Y = 200, Visible = true },
            //     new Bullet(){Name = "bulletB", X = 100, Y = 100, Visible = true },
        };



        int MouseX = 50;
        int MouseY = 50;

        public SimpleGame()
        {
            InitializeComponent();

            canvas.Size = new Size(600, 600);
            gameWindow.SetSize(600, 600);
           

            ship.Initialize(gameWindow.centerX, gameWindow.centerY);


            Random random1 = new Random();


            for (int i = 0; i < gameWindow.SetAsteroidsNumber; i++)
            {
                int Xrand = random1.Next(0, 600);
                int Yrand = random1.Next(0, 600);
                int VXrand = random1.Next(-50, 50);
                int VYrand = random1.Next(-50, 50);
                int Srand = random1.Next(20, 100);

                asteroids.Add(new Asteroid()
                {
                    Visible = true,
                });

                gameWindow.NumberOfAsteroids = asteroids.Count();
                asteroids[gameWindow.NumberOfAsteroids - 1].Spawn(Xrand, Yrand, VXrand, VYrand, Srand);

            }

            RefreshView();

            timerRefresh.Enabled = true;   // Start Refresh
            timerGameTick.Enabled = true;   // Start Game Timer
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
            // Space Pressed = Game Stop
            if (keyData == Keys.Space)
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

            Pen myPen = new Pen(whiteBrush, 1);
            g.DrawLine(myPen, ship.Xabs, ship.Yabs, MouseX, MouseY);

            
            ship.drawShip(g);

            bullet1.drawBullet(g);

            foreach (Asteroid a in asteroids)
            {
                a.draw(g);
            }

            foreach (Bullet b in bullets)
            {
                b.drawBullet(g);
            }




        }

        public void RefreshView()
        {
            if (DebugMode == true)
            {
                gameWindow.NumberOfBullets = bullets.Count();
                gameWindow.NumberOfAsteroids = asteroids.Count();
                debugBox.Visible = true;
                labelBullets.Text = gameWindow.NumberOfBullets.ToString();
                labelAsteroids.Text = gameWindow.NumberOfAsteroids.ToString();
                labelPositionAbs.Text = (ship.Xabs).ToString() + "," + ship.Yabs.ToString();
                labelSpeed.Text = (ship.velocityX).ToString() + "," + (ship.velocityY).ToString();
                labelSize.Text = (canvas.Size.Height).ToString() + "," + (canvas.Size.Width).ToString();
                labelAngle.Text = ship.Angle.ToString();
            }

            labelScore.Text = gameWindow.Score.ToString();
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

                bullet1.refresh();

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
                    Asteroid temp = asteroids[0];
                    bool needremove = false;

                    a.refresh();

                    if (a.X > gameWindow.XSize)     a.X = 0;
                    if (a.X < 0)                    a.X = gameWindow.XSize;
                    if (a.Y > gameWindow.YSize)     a.Y = 0;
                    if (a.Y < 0)                    a.Y = gameWindow.YSize;

                    foreach (Bullet b in bullets)
                    {
                        if (((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y)) - ((a.size/2)*(a.size/2)) < 10)
                        {
                            temp = a;
                            needremove = true;
                        }
                    }
                    if (needremove)
                    {
                        asteroids.Remove(temp);
                        gameWindow.Score++;
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
                bullet1.shoot(ship.Xabs, ship.Yabs, MouseX, MouseY);

                bullets.Add(new Bullet(){
                    Visible = true,                                   
                });

                gameWindow.NumberOfBullets = bullets.Count();

                bullets[gameWindow.NumberOfBullets - 1].shoot(ship.Xabs, ship.Yabs, MouseX, MouseY);

            }

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                float A = MouseX - ship.Xabs;
                float B = MouseY - ship.Yabs;
                ship.Angle = (float)(Math.Atan2(A, B) / Math.PI);

                ship.velocityX = ship.velocityX + (float)Math.Sin(ship.Angle * Math.PI);
                ship.velocityY = ship.velocityY + (float)Math.Cos(ship.Angle * Math.PI);
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
    }
}
