using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    // public partial class NumericKeyboard : UserControl
    public partial class NumericKeyboard : Form
    {
        #region members
        private MicroCPU cpu;
        private int number;
        #endregion

        #region constructor & destructor
        public NumericKeyboard()
        {
            InitializeComponent();
            // cpu = new MicroCPU();
            number = 0;
            tb_nk_number.Text = number.ToString();
        }

        public NumericKeyboard(int initial)
        {
            InitializeComponent();
            // cpu = new MicroCPU(initial);
            number = initial;
            tb_nk_number.Text = number.ToString();
        }
        #endregion

        #region properties
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        #endregion

        #region methods

        #endregion methods

        private void btn_nk_zero_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Text.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_zero.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_zero.Text;
            }
        }

        private void btn_nk_one_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Text.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_one.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_one.Text;
            }
        }

        private void btn_nk_two_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Text.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_two.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_two.Text;
            }
        }

        private void btn_nk_three_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Text.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_three.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_three.Text;
            }
        }

        private void btn_nk_four_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Text.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_four.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_four.Text;
            }
        }

        private void btn_nk_five_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Text.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_five.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_five.Text;
            }
        }

        private void btn_nk_six_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Text.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_six.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_six.Text;
            }
        }

        private void btn_nk_seven_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Text.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_seven.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_seven.Text;
            }
        }

        private void btn_nk_eight_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Text.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_eight.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_eight.Text;
            }
        }

        private void btn_nk_nine_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Text.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_nine.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_nine.Text;
            }
        }

        private void btn_nk_dot_Click(object sender, EventArgs e)
        {
            // NOT IMPLEMENTED YET - TODO
            //tb_nk_number.Text += btn_nk_dot.Text;
        }

        private void btn_nk_add_one_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(tb_nk_number.Text);
            a += 1;
            tb_nk_number.Text = a.ToString();
        }

        private void btn_nk_add_ten_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(tb_nk_number.Text);
            a += 10;
            tb_nk_number.Text = a.ToString();
        }

        private void btn_nk_add_hundred_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(tb_nk_number.Text);
            a += 100;
            tb_nk_number.Text = a.ToString();
        }

        private void btn_nk_sub_one_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(tb_nk_number.Text);
            a -= 1;
            tb_nk_number.Text = a.ToString();
        }

        private void btn_nk_sub_ten_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(tb_nk_number.Text);
            a -= 10;
            tb_nk_number.Text = a.ToString();
        }

        private void btn_nk_sub_hundred_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(tb_nk_number.Text);
            a -= 100;
            tb_nk_number.Text = a.ToString();
        }

        private void btn_nk_return_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Text.Length == 1)
            {
                tb_nk_number.Text = "0";
            }
            else
            {
                tb_nk_number.Text = tb_nk_number.Text.Remove(tb_nk_number.Text.Length -1, 1);
            }
        }

        private void btn_nk_clear_Click(object sender, EventArgs e)
        {
            tb_nk_number.Text = "0";
        }

        private void btn_nk_negate_Click(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(tb_nk_number.Text);
            tmp *= -1;
            tb_nk_number.Text = tmp.ToString();
        }

        private void btn_nk_cancel_Click(object sender, EventArgs e)
        {
            // exit
        }

        private void btn_nk_ok_Click(object sender, EventArgs e)
        {
            // send parameter value
            Number = Int32.Parse(tb_nk_number.Text);
            // exit
        }

        private void btn_nk_help_Click(object sender, EventArgs e)
        {
            // open read only text box
        }
    }
}