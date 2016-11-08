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
    /// <summary>
    /// Diese Klasse dient zur Visualisierung einer LED des Roboters
    /// </summary>

    public partial class LedView : UserControl
    {
        #region members
        private Led led;
        private bool state;
        #endregion

        #region constructor & destructor
        public LedView()
        {
            InitializeComponent();

            State = false;
        }
        #endregion

        #region properties
        /// <summary>
        /// Gibt das LED-Objekt zurück bzw. setzt es. LedView wird beim Model registriert und mit
        /// Events über Änderungen informiert.
        /// </summary>
        public Led Led
        {
            get { return led; }
            set
            {
                // Falls bereits ein Eventhandler registriert war, diesen zuerst beim alten Led-Objekt entfernen
                if (led != null) led.LedStateChanged -= LedStateChanged;

                // Handler beim Led-Objekt (Model) registrieren
                led = value;
                if (led != null) this.led.LedStateChanged += LedStateChanged;
            }
        }

        /// <summary>
        /// Setzt den Zustand der LED (true => ein, false => aus)
        /// </summary>
        public bool State
        {
            get { return state; }
            set
            {
                state = value;
                pictureBox1.Image = (value ? Resource1.LedOn : Resource1.LedOff);
            }
        }
        #endregion

        #region methods
        /// <summary>
        /// Der Eventhandler wird aufgerufen, wenn sich der Zustand der LED (Model) verändert hat.
        /// So kann die View den aktuellen Zustand anzeigen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LedStateChanged(object sender, LedEventArgs e)
        {
            if (InvokeRequired)  // liefert true, wenn synchronisiert werden muss
            {
                Invoke(new EventHandler<LedEventArgs>(LedStateChanged), sender, e);
            }
            else
            {
                State = e.LedEnabled;
                //oder State = led.LedEnabled;
            }
        }
        #endregion


    }
}