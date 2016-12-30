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
        Pen WhitePen = new Pen(Color.White, 2);
        Brush RedBrush = new SolidBrush(Color.Firebrick);
        Brush GreenBrush = new SolidBrush(Color.GreenYellow);
        Brush PinkBrush = new SolidBrush(Color.DeepPink);
        Brush BrushYellow = new SolidBrush(Color.Yellow);

        public char Type = 'A';

        public int Ammo;
        public int Ultimate;
        public int HP;
        public int Fuel;
        public int Damage;

        public int heigh = 15;
        public int length = 15;
         
        public float Xabs = 0;
        public float Yabs = 0;

        public float Xb = 0;
        public float Yb = 0;

        public double Angle;

        public float velocityX = 0;
        public float velocityY = 0;

        public float speed;

        public double slowdown = 0.98;


        public void Reset()
        {
            if(this.Type == 'A')    // Ship A Settings
            {
                this.Ammo = 30;
                this.Ultimate = 10;
                this.HP = 100;
                this.Fuel = 220;
                this.speed = 2;
                this.Damage = 15;
            }
            else if(this.Type == 'B')   // Ship B Settings
            {
                this.Ammo = 60;
                this.Ultimate = 10;
                this.HP = 120;
                this.Fuel = 300;
                this.speed = 1;
                this.Damage = 20;
            }
            else if (this.Type == 'C')  // Ship C Settings
            {
                this.Ammo = 40;
                this.Ultimate = 10;
                this.HP = 60;
                this.Fuel = 180;
                this.speed = 3;
                this.Damage = 17;
            }

        }

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
            Position(this.Xabs + this.velocityX * this.speed, this.Yabs + this.velocityY * this.speed);
            if (this.velocityX > 0) this.velocityX = this.velocityX * (float)slowdown;
            if (this.velocityX < 0) this.velocityX = this.velocityX * (float)slowdown;
            if (this.velocityY > 0) this.velocityY = this.velocityY * (float)slowdown;
            if (this.velocityY < 0) this.velocityY = this.velocityY * (float)slowdown;
        }

        public void calcAngle(float Xstop, float Ystop)
        {
            float A = Xstop - this.Xabs;
            float B = Ystop - this.Yabs;
            this.Angle = (float)(Math.Atan2(A, B) / Math.PI);
        }

        public void drawShip(Graphics g)
        {

            if(this.Type == 'A')
            {
                int Ax = (int)(Xabs + heigh * 2 * (float)Math.Sin(this.Angle * Math.PI));
                int Ay = (int)(Yabs + heigh * 2 * (float)Math.Cos(this.Angle * Math.PI));

                int Bx = (int)(Xabs + heigh / 2 * (float)Math.Sin(this.Angle * Math.PI));
                int By = (int)(Yabs + heigh / 2 * (float)Math.Cos(this.Angle * Math.PI));

                int Cy = (int)(Yabs + length * (float)Math.Sin(this.Angle * Math.PI));
                int Cx = (int)(Xabs - length * (float)Math.Cos(this.Angle * Math.PI));

                int Dy = (int)(Yabs - length * (float)Math.Sin(this.Angle * Math.PI));
                int Dx = (int)(Xabs + length * (float)Math.Cos(this.Angle * Math.PI));

                this.Xb = Bx;   // Bullets starting pos
                this.Yb = By;   // Bullets starting pos

                Point[] points = { new Point(Ax, Ay), new Point(Cx, Cy), new Point(Bx, By), new Point(Dx, Dy), };
                g.FillPolygon(RedBrush, points);
                g.DrawPolygon(WhitePen, points);
            }
            else if(this.Type == 'B')
            {
                int Ax = (int)(Xabs + heigh * (float)Math.Sin(this.Angle * Math.PI));
                int Ay = (int)(Yabs + heigh * (float)Math.Cos(this.Angle * Math.PI));

                int Bx = (int)(Xabs + heigh / 3 * (float)Math.Sin(this.Angle * Math.PI));
                int By = (int)(Yabs + heigh / 3 * (float)Math.Cos(this.Angle * Math.PI));

                int Cy = (int)(Yabs + length * 1.7 * (float)Math.Sin(this.Angle * Math.PI));
                int Cx = (int)(Xabs - length * 1.7 * (float)Math.Cos(this.Angle * Math.PI));

                int Dy = (int)(Yabs - length * 1.7 * (float)Math.Sin(this.Angle * Math.PI));
                int Dx = (int)(Xabs + length * 1.7 * (float)Math.Cos(this.Angle * Math.PI));

                this.Xb = Bx;   // Bullets starting pos
                this.Yb = By;   // Bullets starting pos

                Point[] points = { new Point(Ax, Ay), new Point(Cx, Cy), new Point(Bx, By), new Point(Dx, Dy), };
                g.FillPolygon(GreenBrush, points);
                g.DrawPolygon(WhitePen, points);
            }

            else if (this.Type == 'C')
            {

                int Ax = (int)(Xabs + heigh * 1.5 * (float)Math.Sin(this.Angle * Math.PI));
                int Ay = (int)(Yabs + heigh * 1.5 * (float)Math.Cos(this.Angle * Math.PI));

                int Bx = (int)(Xabs - heigh  * (float)Math.Sin(this.Angle * Math.PI));
                int By = (int)(Yabs - heigh  * (float)Math.Cos(this.Angle * Math.PI));

                int Cy = (int)(Yabs + length * 1.2 * (float)Math.Sin(this.Angle * Math.PI));
                int Cx = (int)(Xabs - length * 1.2 * (float)Math.Cos(this.Angle * Math.PI));

                int Dy = (int)(Yabs - length * 1.2 * (float)Math.Sin(this.Angle * Math.PI));
                int Dx = (int)(Xabs + length * 1.2 * (float)Math.Cos(this.Angle * Math.PI));

                int Ey = (int)(Yabs + length * 0.6 * (float)Math.Sin(this.Angle * Math.PI));
                int Ex = (int)(Xabs - length * 0.6 * (float)Math.Cos(this.Angle * Math.PI));

                int Fy = (int)(Yabs - length * 0.6 * (float)Math.Sin(this.Angle * Math.PI));
                int Fx = (int)(Xabs + length * 0.6 * (float)Math.Cos(this.Angle * Math.PI));

                this.Xb = Bx;   // Bullets starting pos
                this.Yb = By;   // Bullets starting pos


                Point[] points = { new Point(Ax, Ay), new Point(Ex, Ey),  new Point(Cx, Cy), new Point(Bx, By), new Point(Dx, Dy), new Point(Fx, Fy), };
                g.FillPolygon(PinkBrush, points);
                g.DrawPolygon(WhitePen, points);
            }


        }

    }

    public class Asteroid
    {

        List<Brush> brushes = new List<Brush> {
            new SolidBrush(Color.AntiqueWhite),
            new SolidBrush(Color.Gainsboro),
            new SolidBrush(Color.LightGray),
            new SolidBrush(Color.Silver),
            new SolidBrush(Color.DarkGray),
            new SolidBrush(Color.LightGreen),
            new SolidBrush(Color.LightSkyBlue),
            new SolidBrush(Color.LightSteelBlue),
            new SolidBrush(Color.Tan),
            new SolidBrush(Color.BurlyWood),
            new SolidBrush(Color.LightPink),
        };

        Pen myWhitePen = new Pen(Color.White, 2);

        public int Colore = 0;

        public float size = 50;
        public float HP = 50;

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


        public void Spawn(float X, float Y, float Xspeed, float Yspeed, float Size, int Colo)
        {
            this.size = Size;
            this.Colore = Colo;

            this.HP = Size;

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
            this.size = this.HP;
        }

        public bool isInRange(float X1, float Y1, float X2, float Y2)
        {
            if (this.X < X1 || this.X > X2 || this.Y < Y1 || this.Y > Y2)
            {
                return false;
            }
            else return true;
        }

        public virtual void draw(Graphics g)
        {
            if (Visible)
            {
                g.FillEllipse(brushes[Colore], X - size / 2, Y - size / 2, size, size);
                g.DrawEllipse(myWhitePen, X - size / 2, Y - size / 2, size, size);          
            }
        }

    }


    public class BonusAmmo : Asteroid
    {
        
        Brush myGreenBrush = new SolidBrush(Color.Green);
        Brush myYellowBrush = new SolidBrush(Color.Yellow);
        Pen myYellowPen = new Pen(Color.Yellow);

        public override void draw(Graphics g)
        {
            g.FillRectangle(myGreenBrush, X - 10, Y - 10, 20, 20);
            g.FillEllipse(myYellowBrush, X - 4, Y - 4, 8, 8);
            g.DrawRectangle(myYellowPen, X - 10, Y - 10, 20, 20);
        }

    }


    public class BonusHP : Asteroid
    {

        Brush myRedBrush = new SolidBrush(Color.Red);
        Brush myWhiteBrush = new SolidBrush(Color.White);
        Pen myWhitePen = new Pen(Color.White);

        public override void draw(Graphics g)
        {
            g.FillRectangle(myRedBrush, X - 10, Y - 10, 20, 20);

            g.FillRectangle(myWhiteBrush, X - 2,  Y-10,  5, 20);
            g.FillRectangle(myWhiteBrush, X - 10, Y-2 , 20, 5);

            g.DrawRectangle(myWhitePen, X - 10, Y - 10, 20, 20);
        }

    }


    public class BonusFuel : Asteroid
    {

        Brush myGreenBrush = new SolidBrush(Color.Green);
        Brush myWhiteBrush = new SolidBrush(Color.White);
        Pen myGreenPen = new Pen(Color.Green);

        public override void draw(Graphics g)
        {
            g.FillRectangle(myWhiteBrush, X - 10, Y - 10, 20, 20);
            g.FillEllipse(myGreenBrush, X - 8, Y - 8, 16, 16);
            g.DrawRectangle(myGreenPen, X - 10, Y - 10, 20, 20);
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
