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
    /// Diese Klasse dient zur Visualisierung eines Schalters des Roboters
    /// </summary>
    public partial class SwitchView : UserControl
    {
        #region members
        private Switch swi;
        private bool state;
        #endregion

        #region constructor & destructor
        public SwitchView()
        {
            InitializeComponent();

            State = false;
        }
        #endregion

        #region properties
        /// <summary>
        /// Gibt das Switch-Objekt zurück bzw. setzt es. LedView wird beim Model registriert und mit
        /// Events über Änderungen informiert.
        /// </summary>
        public Switch Switch
        {
            get { return swi; }
            set
            {
                // Falls bereits ein Eventhandler registriert war, diesen zuerst beim alten Switch-Objekt entfernen
                if (swi != null) swi.SwitchStateChanged -= SwitchStateChanged;

                // Handler beim Switch-Objekt (Model) registrieren
                swi = value;
                if (swi != null) this.swi.SwitchStateChanged += SwitchStateChanged;
            }
        }

        /// <summary>
        /// Setzt den Zustand des Schalters (true => ein, false => aus)
        /// </summary>
        public bool State
        {
            get { return state; }
            set
            {
                state = value;
                pictureBox1.Image = (value ? Resource1.SwitchOn : Resource1.SwitchOff);
            }
        }
        #endregion

        #region methods
        /// <summary>
        /// Der Eventhandler wird aufgerufen, wenn sich der Zustand des Schalters verändert hat.
        /// So kann die View den aktuellen Zustand anzeigen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchStateChanged(object sender, SwitchEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<SwitchEventArgs>(SwitchStateChanged), sender, e);
            }
        }
        #endregion
    }
}