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
        public Ship()   //Constructor
        {
            positionX = initialPositionX;
            positionY = initialPositionY;
        }

        Pen myPen = new Pen(Color.Red);
        Brush myBrush = new SolidBrush(Color.Red);

        Color color = Color.Red;



        public int initialPositionX = 140;  // Initial Position
        public int initialPositionY = 140;  // Initial Position

        public int positionX = 0;
        public int positionY = 0;


        public void drawShip(Graphics g)
        {
            g.FillRectangle(myBrush, positionX, positionY, 20, 20);
        }

    }
}
