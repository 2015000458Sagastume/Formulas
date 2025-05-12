using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedIndex == 0) {
            // label5.Hide();
            //textBox2.Hide();
            // label8.Hide();
            // }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                double v, d, t;
                d = Convert.ToDouble(textBox3.Text);
                t = Convert.ToDouble(textBox4.Text);
                v = d / t;

                textBox1.Text = v.ToString() + "m/s";

            }
            if (comboBox1.SelectedIndex == 1)
            {
                double v, d, t;
                v = Convert.ToDouble(textBox2.Text);
                t = Convert.ToDouble(textBox4.Text);
                d = v * t;

                textBox1.Text = d.ToString() + "m";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                double v, d, t;
                d = Convert.ToDouble(textBox3.Text);
                v = Convert.ToDouble(textBox2.Text);

                t = d / v;
                textBox1.Text = t.ToString() + "s";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
