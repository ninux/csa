using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestDrive
{
    public partial class Form1 : Form
    {
        #region members
        private Robot robot;
        #endregion
        
        #region constructor & destructor
        public Form1()
        {
            InitializeComponent();

            robot = new Robot();        // neuen Roboter erstellen
            robot.Drive.Power = true;   // Stromversorgung der Motoren (im DriveCtrl) einschalten

            driveView1.Drive = robot.Drive; // DriveView benötigt Drive-Objekt zur Visualisierung
            radarView1.Radar = robot.Radar;
            consoleView1.RobotConsole = robot.RobotConsole;

            runLine1.Drive = robot.Drive;
            runArc1.Drive = robot.Drive;
            runTurn1.Drive = robot.Drive;

            commonRunParameters1.AccelerationChanged += AccelerationChanged;
            commonRunParameters1.SpeedChanged += SpeedChanged;

            SpeedChanged(null, EventArgs.Empty); // Default Wert setzen
            AccelerationChanged(null, EventArgs.Empty); // Default Wert setzen
        }
        #endregion
        
        #region methods
        private void SpeedChanged(object sender, EventArgs e)
        {
            runLine1.Speed = commonRunParameters1.Speed;
            runArc1.Speed = commonRunParameters1.Speed;
            runTurn1.Speed = commonRunParameters1.Speed;
        }
        private void AccelerationChanged(object sender, EventArgs e)
        {
            runLine1.Acceleration = commonRunParameters1.Acceleration;
            runArc1.Acceleration = commonRunParameters1.Acceleration;
            runTurn1.Acceleration = commonRunParameters1.Acceleration;
        }


        private void buttonStop_Click(object sender, EventArgs e)
        {
            robot.Drive.Stop();
        }

        private void buttonHalt_Click(object sender, EventArgs e)
        {
            robot.Drive.Halt();
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (robot.Radar.Distance < 0.3f) robot.Drive.Stop();
        }
    }
}
