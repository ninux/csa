using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace TestConsole
{
    public partial class Form1 : Form
    {
        RobotConsole rc;
        public Form1()
        {
            InitializeComponent();

            rc = new RobotConsole();
            consoleView1.RobotConsole = rc;
            /*rc[Switches.Switch1].SwitchStateChanged += SwitchStateChanged;
            rc[Switches.Switch2].SwitchStateChanged += SwitchStateChanged;
            rc[Switches.Switch3].SwitchStateChanged += SwitchStateChanged;
            rc[Switches.Switch4].SwitchStateChanged += SwitchStateChanged;*/
            (rc[Switches.Switch1]).SwitchStateChanged += (o, e) => (rc[Leds.Led1]).LedEnabled = (rc[Switches.Switch1]).SwitchEnabled;
            (rc[Switches.Switch2]).SwitchStateChanged += (o, e) => (rc[Leds.Led2]).LedEnabled = (rc[Switches.Switch2]).SwitchEnabled;
            (rc[Switches.Switch3]).SwitchStateChanged += (o, e) => (rc[Leds.Led3]).LedEnabled = (rc[Switches.Switch3]).SwitchEnabled;
            (rc[Switches.Switch4]).SwitchStateChanged += (o, e) => (rc[Leds.Led4]).LedEnabled = (rc[Switches.Switch4]).SwitchEnabled;

        }
    }
}
