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
        Size windowSize = new Size();

        public int Scale = 20;
        public int XSize = 100;
        public int YSize = 100;


        public void SetSize(int X, int Y)
        {
            XSize = X;
            YSize = Y;
        }

        public Size ScaleWindow()
        {
            windowSize.Height = YSize;
            windowSize.Width = XSize;
            return windowSize;
        }
        
        
    }
}
