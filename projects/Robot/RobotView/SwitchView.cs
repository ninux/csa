using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class SwitchView : UserControl
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
                pictureBox1.Image = (State ? Resource1.SwitchOn : Resource1.SwitchOff);
            }
        }

        public SwitchView()
        {
            InitializeComponent();
        }

        private void SwitchView_Click(object sender, EventArgs e)
        {

        }
    }
}