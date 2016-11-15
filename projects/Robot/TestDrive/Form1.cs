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
            //radarView1.Radar = robot.Radar;
            consoleView1.RobotConsole = robot.RobotConsole;

            commonRunParameters1.AccelerationChanged += AccelerationChanged;
            commonRunParameters1.SpeedChanged += SpeedChanged;

            SpeedChanged(null, EventArgs.Empty); // Default Wert setzen
            AccelerationChanged(null, EventArgs.Empty); // Default Wert setzen
        }
        #endregion
        
        #region methods
        private void SpeedChanged(object sender, EventArgs e)
        {
        }
        private void AccelerationChanged(object sender, EventArgs e)
        {
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void commonRunParameters1_Click(object sender, EventArgs e)
        {

        }
    }
}
