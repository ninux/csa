using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testat
{
    public partial class Form1 : Form
    {
        private float actualNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "button_zero":
                    this.actualNumber *= 10;
                    break;
                case "button_one":
                    this.actualNumber = this.actualNumber * 10 + 1;
                    break;
                case "button_two":
                    this.actualNumber = this.actualNumber * 10 + 2;
                    break;
                case "button_three":
                    this.actualNumber = this.actualNumber * 10 + 3;
                    break;
                case "button_four":
                    this.actualNumber = this.actualNumber * 10 + 4;
                    break;
                case "button_five":
                    this.actualNumber = this.actualNumber * 10 + 5;
                    break;
                case "button_six":
                    this.actualNumber = this.actualNumber * 10 + 6;
                    break;
                case "button_seven":
                    this.actualNumber = this.actualNumber * 10 + 7;
                    break;
                case "button_eight":
                    this.actualNumber = this.actualNumber * 10 + 8;
                    break;
                case "button_nine":
                    this.actualNumber = this.actualNumber * 10 + 9;
                    break;
                case "button_add_one":
                    this.actualNumber = this.actualNumber + 1;
                    break;
                case "button_add_ten":
                    this.actualNumber = this.actualNumber + 10;
                    break;
                case "button_add_hundred":
                    this.actualNumber = this.actualNumber + 100;
                    break;
                case "button_sub_one":
                    this.actualNumber = this.actualNumber - 1;
                    break;
                case "button_sub_ten":
                    this.actualNumber = this.actualNumber - 10;
                    break;
                case "button_sub_hundred":
                    this.actualNumber = this.actualNumber - 100;
                    break;
                case "button_sign":
                    this.actualNumber = this.actualNumber * -1;
                    break;
                case "button_delete":
                    this.actualNumber = (int)this.actualNumber / 10;
                    break;
                case "button_clear":
                    this.actualNumber = 0;
                    break;
                default:
                    this.actualNumber = 0;
                    break;
            }
            this.textBox_number.Text = this.actualNumber.ToString();
        }
    }
}
