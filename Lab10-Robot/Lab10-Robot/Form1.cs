using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_Robot
{
    public partial class Form1 : Form
    {
        public Form1()        {
            InitializeComponent();
        }

        private Robot currentRobot = new Robot();

        private const string EAST = "";
        private const string WEST = "";
        private const string NORTH = "";
        private const string SOUTH = "";
        

        private void btnExit_Click(object sender, EventArgs e)        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)        {
            robot.Font = new Font("Wingdings",8);
            robot.Text = NORTH;
            robot.Location = new Point(100,100);
            labelPosition.Text = "{X="+currentRobot.CurrentPoint.X+",Y="+ currentRobot.CurrentPoint.Y+"}";
        }

        private void btnNorth_Click(object sender, EventArgs e)        {
            currentRobot.CurrentDirection = "N";
            robot.Text = NORTH;
        }

        private void btnSouth_Click(object sender, EventArgs e)        {
            currentRobot.CurrentDirection = "S";
            robot.Text = SOUTH;
        }

        private void btnEast_Click(object sender, EventArgs e)        {
            currentRobot.CurrentDirection = "E";
            robot.Text = EAST;
        }

        private void btnWest_Click(object sender, EventArgs e)        {
            currentRobot.CurrentDirection = "W";
            robot.Text = WEST;
        }

        private void btnGo1_Click(object sender, EventArgs e) {

            Point newPosition;
            switch (currentRobot.CurrentDirection) {

                case "N":
                    newPosition = new Point(
                        currentRobot.CurrentPoint.X,
                        currentRobot.CurrentPoint.Y+1
                        );

                    currentRobot.moveRobot(newPosition);
                    moveArrow(0,-1);
                    break;

                case "S":
                    newPosition = new Point(
                        currentRobot.CurrentPoint.X,
                        currentRobot.CurrentPoint.Y - 1
                        );

                    currentRobot.moveRobot(newPosition);
                    moveArrow(0,1);
                    break;

                case "W":
                    newPosition = new Point(
                        currentRobot.CurrentPoint.X - 1,
                        currentRobot.CurrentPoint.Y
                        );

                    currentRobot.moveRobot(newPosition);

                    moveArrow(-1,0);
                    break;

                case "E":
                    newPosition = new Point(
                        currentRobot.CurrentPoint.X + 1,
                        currentRobot.CurrentPoint.Y
                        );

                    currentRobot.moveRobot(newPosition);

                    moveArrow(1,0);
                    break;
            }
            
        }

        private void btnGo10_Click(object sender, EventArgs e) {
            
            Point newPosition;
            switch (currentRobot.CurrentDirection) {

                case "N":
                    newPosition = new Point(
                        currentRobot.CurrentPoint.X,
                        currentRobot.CurrentPoint.Y+10
                        );

                    currentRobot.moveRobot(newPosition);
                    moveArrow(0,-10);
                    break;

                case "S":
                    newPosition = new Point(
                        currentRobot.CurrentPoint.X,
                        currentRobot.CurrentPoint.Y - 10
                        );

                    currentRobot.moveRobot(newPosition);
                    moveArrow(0,10);
                    break;

                case "W":
                    newPosition = new Point(
                        currentRobot.CurrentPoint.X - 10,
                        currentRobot.CurrentPoint.Y
                        );

                    currentRobot.moveRobot(newPosition);

                    moveArrow(-10,0);
                    break;

                case "E":
                    newPosition = new Point(
                        currentRobot.CurrentPoint.X + 10,
                        currentRobot.CurrentPoint.Y
                        );

                    currentRobot.moveRobot(newPosition);

                    moveArrow(10,0);
                    break;
            }
            
        }

        private void moveArrow(int x, int y) {

            if ((robot.Location.X+x) <= 201 && (robot.Location.X + x) >= -2) {
                robot.Location = new Point(
                    (robot.Location.X + x),
                    (robot.Location.Y)
                );
            }

            if ( (robot.Location.Y+y) <= 201 && (robot.Location.Y + y) >= -2) {
                robot.Location = new Point(
                    (robot.Location.X),
                    (robot.Location.Y+y)
                );
            }

            labelPosition.Text = "{X=" + currentRobot.CurrentPoint.X + ",Y=" + currentRobot.CurrentPoint.Y + "}";

        }
    }
}
