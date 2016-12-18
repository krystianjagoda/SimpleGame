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

        public int initialPositionX = 100;  // Initial Position
        public int initialPositionY = 100;  // Initial Position

        public int positionX = 0;
        public int positionY = 0;

        public void Initialize(int initX, int initY, int len, int hei)
        {
            heigh = hei;
            length = len;

            positionX = initX;
            positionY = initY;
        }




        public void drawShip(Graphics g)
        {
            g.FillRectangle(myBrush, positionX, positionY, length, heigh);
        }

    }
}
