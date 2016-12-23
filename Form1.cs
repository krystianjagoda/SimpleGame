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
        public List<Bullets> Bullets = new List<Bullets>();


        int MouseX = 50;
        int MouseY = 50;

        public SimpleGame()
        {
            InitializeComponent();

            canvas.Size = new Size(600, 600);
            gameWindow.SetSize(600, 600);
           

            ship.Initialize(gameWindow.centerX, gameWindow.centerY, gameWindow.UnitLength, gameWindow.UnitHeight);

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
        }

        public void RefreshView()
        {
            if (DebugMode == true)
            {
                debugBox.Visible = true;
                labelPositionRel.Text = (ship.positionX).ToString() + "," + (ship.positionY).ToString();
                labelPositionAbs.Text = (ship.Xabs).ToString() + "," + ship.Yabs.ToString();
                labelSpeed.Text = (ship.velocityX).ToString() + "," + (ship.velocityY).ToString();
                labelSize.Text = (canvas.Size.Height).ToString() + "," + (canvas.Size.Width).ToString();
                labelAngle.Text = ship.Angle.ToString();
            }

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

            float A = MouseX - ship.Xabs;
            float B = MouseY - ship.Yabs;
            ship.Angle = (float)(Math.Atan2(A, B)  / Math.PI);


            if (gameWindow.GameStop == false)
            {
                ship.Position(ship.positionX + ship.velocityX*ship.speedX, ship.positionY + ship.velocityY * ship.speedY);

                if (ship.positionX > (gameWindow.XSize / 2) - ship.length) ship.positionX = (gameWindow.XSize / 2 - ship.length);
                if (ship.positionX < (-gameWindow.XSize / 2)) ship.positionX = -(gameWindow.XSize / 2);
                if (ship.positionY > (gameWindow.YSize / 2) - ship.heigh) ship.positionY = (gameWindow.YSize / 2 - ship.heigh);
                if (ship.positionY < (-gameWindow.YSize / 2)) ship.positionY = -(gameWindow.YSize / 2);


                if (ship.velocityX > 0) ship.velocityX = ship.velocityX * (float)0.98;
                if (ship.velocityX < 0) ship.velocityX = ship.velocityX * (float)0.98;
                if (ship.positionY > 0) ship.positionY = ship.positionY * (float)0.98;
                if (ship.positionY < 0) ship.positionY = ship.positionY * (float)0.98;


                foreach (Bullets bullet in Bullets)
                {
                }

                bullet1.refresh();
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                    Bullets.Add(new Bullets()
                    { Number = 1, Bullet = new Bullet() });


                bullet1.Xstart = ship.Xabs;
                bullet1.Ystart = ship.Yabs;
                bullet1.Xstop = e.Location.X;
                bullet1.Ystop = e.Location.Y;
                bullet1.shoot();           
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {

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
