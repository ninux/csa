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
        MicroCPU cpu;
        #endregion

        #region constructor & destructor
        public NumericKeyboard()
        {
            InitializeComponent();
            cpu = new MicroCPU();
        }

        public NumericKeyboard(int initial)
        {
            InitializeComponent();

        }
        #endregion

        #region properties
        #endregion

        #region methods

        #endregion methods

        private void btn_nk_zero_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_zero.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_zero;
            }
        }

        private void btn_nk_one_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_one.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_one;
            }
        }

        private void btn_nk_two_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_two.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_two;
            }
        }

        private void btn_nk_three_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_three.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_three;
            }
        }

        private void btn_nk_four_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_four.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_four;
            }
        }

        private void btn_nk_five_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_five.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_five;
            }
        }

        private void btn_nk_six_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_six.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_six;
            }
        }

        private void btn_nk_seven_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_seven.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_seven;
            }
        }

        private void btn_nk_eight_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_eight.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_eight;
            }
        }

        private void btn_nk_nine_Click(object sender, EventArgs e)
        {
            if (tb_nk_number.Equals("0"))
            {
                tb_nk_number.Text = btn_nk_nine.Text;
            }
            else
            {
                tb_nk_number.Text += btn_nk_nine;
            }
        }

        private void btn_nk_dot_Click(object sender, EventArgs e)
        {
            tb_nk_number.Text += btn_nk_dot;
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
                tb_nk_number.Text.Remove(tb_nk_number.Text.Length - 1, 1);
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
            tb_nk_number.Text(tmp.ToString());
        }

        private void btn_nk_cancel_Click(object sender, EventArgs e)
        {
            // exit
        }

        private void btn_nk_ok_Click(object sender, EventArgs e)
        {
            // send parameter value
            // exit
        }

        private void btn_nk_help_Click(object sender, EventArgs e)
        {
            // open read only text box
        }
    }
}