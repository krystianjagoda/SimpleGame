using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleGame
{
    class GameWindow
    {

        public int Score = 0;
        public int GameLevel = 1;

        public int NumberOfBullets;
        public int NumberOfAsteroids;

        public int SetAsteroidsNumber = 5;

        public bool GameStop = false;
        public bool StopOnWalls = true;

        private int Scale = 30;

        public int UnitHeight = 20;
        public int UnitLength = 20;

        public int XSize = 200;
        public int YSize = 200;

        public int centerX = 0;
        public int centerY = 0;


        public void SetSize(int X, int Y)
        {
            XSize = X;
            YSize = Y;

            centerX = XSize / 2;
            centerY = YSize / 2;

            UnitLength = XSize / Scale;
            UnitHeight = YSize / Scale;

        }
        
        
    }
}
