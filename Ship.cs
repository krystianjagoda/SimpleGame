using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleGame
{
    class Ship
    {
        Pen myPen = new Pen(Color.Firebrick);
        Brush myBrush = new SolidBrush(Color.Firebrick);

        Color color = Color.Firebrick;

        public int heigh = 20;
        public int length = 20;
         
        public float Xabs = 0;
        public float Yabs = 0;

        public double Angle;

        public float velocityX = 0;
        public float velocityY = 0;

        public float speedX = 2;
        public float speedY = 2;

        public double slowdown = 0.98;



        public void Initialize(float Xinit, float Yinit)
        {
            Position(Xinit, Yinit);
        }

        public void Position(float positionX, float positionY)
        {
            this.Xabs = positionX;
            this.Yabs = positionY;
        }

        public void refresh()
        {
            Position(this.Xabs + this.velocityX * this.speedX, this.Yabs + this.velocityY * this.speedY);
            if (this.velocityX > 0) this.velocityX = this.velocityX * (float)slowdown;
            if (this.velocityX < 0) this.velocityX = this.velocityX * (float)slowdown;
            if (this.velocityY > 0) this.velocityY = this.velocityY * (float)slowdown;
            if (this.velocityY < 0) this.velocityY = this.velocityY * (float)slowdown;
        }


        public void drawShip(Graphics g)
        {
            g.FillRectangle(myBrush, Xabs-length/2, Yabs-heigh/2, length, heigh);
        }

    }

    class Asteroid
    {

        Pen myPen = new Pen(Color.White);
        Brush myBrush = new SolidBrush(Color.White);

        public float size = 50;

        public string Name = "asteroidX";

        public bool Visible = false;

        public float X = 300;
        public float Y = 300;

        public double Angle;

        public float velocityX = 0;
        public float velocityY = 0;

        public float speedX = 0.1F;
        public float speedY = 0.1F;



        public void shoot(float Xstart, float Ystart, float Xstop, float Ystop)
        {
            this.X = Xstart;
            this.Y = Ystart;

            float A = Xstop - Xstart;
            float B = Ystop - Ystart;
            this.Angle = (float)(Math.Atan2(A, B) / Math.PI);

            this.velocityX = (float)Math.Sin(this.Angle * Math.PI);
            this.velocityY = (float)Math.Cos(this.Angle * Math.PI);

            Visible = true;
        }


        public void Spawn(float X, float Y, float Xspeed, float Yspeed, float Size)
        {
            this.size = Size;

            this.X = X;
            this.Y = Y;

            this.velocityX = Xspeed;
            this.velocityY = Yspeed;

            Visible = true;
        }

        public void Position(float positionX, float positionY)
        {
            this.X = positionX;
            this.Y = positionY;
        }


        public void refresh()
        {
            Position(this.X + this.velocityX * this.speedX, this.Y + this.velocityY * this.speedY);
        }

        public bool isInRange(float X1, float Y1, float X2, float Y2)
        {
            if (this.X < X1 || this.X > X2 || this.Y < Y1 || this.Y > Y2)
            {
                return false;
            }
            else return true;
        }

        public void draw(Graphics g)
        {
            if (Visible)
            {
                g.FillEllipse(myBrush, X - size / 2, Y - size / 2, size, size);
            }
        }

    }




    class Bullet
    {

        Pen myPen = new Pen(Color.Yellow);
        Brush myBrush = new SolidBrush(Color.Yellow);

        int size = 8;

        public string Name = "bulletX";

        public bool Visible = false;

        public float X = 300;
        public float Y = 300;

        public double Angle;

        public float velocityX = 0;
        public float velocityY = 0;

        public float speedX = 20;
        public float speedY = 20;



        public void shoot(float Xstart, float Ystart, float Xstop, float Ystop)
        {
            this.X = Xstart;
            this.Y = Ystart;

            float A = Xstop - Xstart;
            float B = Ystop - Ystart;
            this.Angle = (float)(Math.Atan2(A, B) / Math.PI);

            this.velocityX = (float)Math.Sin(this.Angle * Math.PI);
            this.velocityY = (float)Math.Cos(this.Angle * Math.PI);

            Visible = true;
        }

        public void Position(float positionX, float positionY)
        {
            this.X = positionX;
            this.Y = positionY;
        }


        public void refresh()
        {
            Position(this.X + this.velocityX * this.speedX, this.Y + this.velocityY * this.speedY);
        }

        public bool isInRange(float X1, float Y1, float X2, float Y2)
        {
            if (this.X < X1 || this.X > X2 || this.Y < Y1 || this.Y > Y2)
            {
                return false;
            }
            else return true;
        }

        public void drawBullet(Graphics g)
        {
            if (Visible)
            {
                g.FillEllipse(myBrush, X - size / 2, Y - size / 2, size, size);
            }
        }

    }
}
