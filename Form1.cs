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
        Graphics g = null;
        GameWindow gameWindow = new GameWindow();

        Ship ship = new Ship();
        
        

        public SimpleGame()
        {
            InitializeComponent();

            gameWindow.SetSize(400, 400);
            canvas.Size = gameWindow.ScaleWindow();
            g = canvas.CreateGraphics();




            RefreshView();
            timerRefresh.Enabled = true;   // Start Refresh
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                ship.positionX = ship.positionX -20;
                if (ship.positionX < -140) ship.positionX = -140;
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                ship.positionX = ship.positionX + 20;
                if (ship.positionX > 140) ship.positionX = 140;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            RefreshView();
        }


        public void RefreshView()
        {            
            labelPosition.Text = (ship.positionX).ToString();

            canvas.Refresh();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {                       
            ship.drawShip(g);           
        }
    }
}
