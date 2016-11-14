using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class NumericKeyboard : UserControl
    {
        #region members
        private int accumulator;
        private int input_number;
        private String input_string;
        #endregion

        #region constructor & destructor
        public NumericKeyboard()
        {
            InitializeComponent();
            input_number = 0;
            accumulator = input_number;
            input_string = "0";
        }

        public NumericKeyboard(int initial)
        {
            InitializeComponent();
            input_number = initial;
            input_string = input_number.ToString();
            tb_nk_number.Text = input_string;
        }
        #endregion

        #region properties
        #endregion

        #region methods
        
        #endregion methods
    }
}