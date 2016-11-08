using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class LedView : UserControl
    {

        private bool State
        {
            get
            {
                return State;
            }
            set
            {
                State = value;
                pictureBox1.Image = (State ? Resource1.LedOn : Resource1.LedOff);
            }
        }

        private Led light
        {
            get
            {
                
            }
            set
            {
                light.LedStateChanged += Light_LedStateChanged;                
            }
        }

        private void Light_LedStateChanged(object sender, LedEventArgs e)
        {
            State = e.LedEnabled;
        }

        public LedView()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}