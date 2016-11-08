using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestConsole
{
    public partial class Form1 : Form
    {

        #region members
        private RobotConsole rc;
        private int pos;
        #endregion

        public Form1()
        {
            InitializeComponent();

            rc = new RobotConsole();
            consoleView1.RobotConsole = rc;
            consoleView2.RobotConsole = rc;
            rc[Switches.Switch1].SwitchStateChanged += SwitchStateChanged;
            rc[Switches.Switch2].SwitchStateChanged += SwitchStateChanged;
            rc[Switches.Switch3].SwitchStateChanged += SwitchStateChanged;
            rc[Switches.Switch4].SwitchStateChanged += SwitchStateChanged;
        }

        #region methods
        void SwitchStateChanged(object sender, SwitchEventArgs e)
        {
            rc[(Leds)(int)e.Swi].LedEnabled = e.SwitchEnabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            rc[(Leds)pos].LedEnabled = false;
            pos = (pos + 1) % 4;
            rc[(Leds)pos].LedEnabled = true;
        }
        #endregion


    }
}
