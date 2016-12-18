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

        Graphics g = null;
        GameWindow gameWindow = new GameWindow();

        Ship ship = new Ship();
        
        

        public SimpleGame()
        {
            InitializeComponent();

            g = canvas.CreateGraphics();

            canvas.Size = new Size(600, 600);
            gameWindow.SetSize(600, 600);

            ship.Initialize(gameWindow.centerX, gameWindow.centerY, gameWindow.UnitLength, gameWindow.UnitHeight);


            RefreshView();

            timerRefresh.Enabled = true;   // Start Refresh
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                ship.positionX = ship.positionX - gameWindow.UnitLength;
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                ship.positionX = ship.positionX + gameWindow.UnitLength;
                return true;
            }

            if (keyData == Keys.Up)
            {
                ship.positionY = ship.positionY - gameWindow.UnitHeight;
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Down)
            {
                ship.positionY = ship.positionY + gameWindow.UnitHeight;
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
            ship.drawShip(g);           
        }

        public void RefreshView()
        {

            if(DebugMode == true)
            {
                debugBox.Visible = true;
                labelPositionRel.Text = (ship.positionX).ToString() + "," + (ship.positionY).ToString();
                labelSize.Text = (SimpleGame.ActiveForm.Size.Width).ToString() + "," + (SimpleGame.ActiveForm.Size.Height).ToString();
            }


            canvas.Refresh();
        }

    }
}
