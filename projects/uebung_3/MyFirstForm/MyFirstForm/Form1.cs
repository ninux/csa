using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Text = (numericUpDown1.Value * (-1)).ToString();
            }
            else
            {
                textBox1.Text = (numericUpDown1.Value * (+1)).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            numericUpDown1.Value = 0;
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }

    }
}
