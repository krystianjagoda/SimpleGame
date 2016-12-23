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

        public int zeroX = 100;  // Initial Position
        public int zeroY = 100;  // Initial Position

        public float positionX = 0;
        public float positionY = 0;
          
        public float Xabs;
        public float Yabs;

        public double Angle;

        public float velocityX = 0;
        public float velocityY = 0;

        public float speedX = 2;
        public float speedY = 2;



        public void Initialize(int _zeroX, int _zeroY, int length, int heigh)
        {
            zeroX = _zeroX - length/2;
            zeroY = _zeroY - heigh /2;
            Position(0, 0);
        }

        public void Position(float _positionX, float _positionY)
        {
            positionX = _positionX;
            positionY = _positionY;

            Xabs = positionX + length/2+ zeroX;
            Yabs = positionY + heigh/2 + zeroY;
    }


        public void drawShip(Graphics g)
        {
            g.FillRectangle(myBrush, Xabs-length/2, Yabs-heigh/2, length, heigh);
        }

    }



    class Bullet
    {

        Pen myPen = new Pen(Color.Yellow);
        Brush myBrush = new SolidBrush(Color.Yellow);

        Color color = Color.Yellow;

        public bool Visible = false;

        public float X = 400;
        public float Y = 400;

        public float Xstart = 20;
        public float Ystart = 20;

        public float Xstop = 30;
        public float Ystop = 30;

        public float speedX = 1;
        public float speedY = 1;

        public float dX;
        public float dY;


        int speed = 20;

        int size = 8;

        public void shoot()
        {
            X = Xstart;
            Y = Ystart;

            float a = Math.Abs(Xstop - Ystart);
            float b = Math.Abs(Ystop - Ystart);

            float step = (float)Math.Sqrt(a * a + b * b)/speed;

            dX = (Xstop - Xstart) / step;
            dY = (Ystop - Ystart) / step;
            Visible = true;
        }

        public void refresh()
        {
            if (Visible)
            {
                if (X - Xstop > 2 || X - Xstop < -2 || Y - Ystop > 2 || Y -Ystop < -2)
                {
                    X = X + dX;
                    Y = Y + dY;
                }
            }
        }



        public void drawBullet(Graphics g)
        {
            if (Visible)
            {
                g.FillEllipse(myBrush, X + size / 2, Y + size / 2, size, size);
            }
        }

    }



    public class Bullets : IEquatable<Bullets>
    {

        public UInt32 Number { get; set; }
        public object Bullet { get; set; }
        

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Bullet objAsPart = obj as Bullet;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public override string ToString()
        {
            return "Uzupelnij sobie to";
        }

        public override int GetHashCode()
        {
            return (int)Number;
        }


        public bool Equals(Bullets other)
        {
            if (other == null) return false;
            return (this.Number.Equals(other.Number));
        }
        // Should also override == and != operators.

    }


}
