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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                double F, m, a;
                m = Convert.ToDouble(textBox3.Text);
                a = Convert.ToDouble(textBox4.Text);

                F = m * a;

                textBox1.Text = F.ToString() + "N";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                double F, m, a;
                F = Convert.ToDouble(textBox2.Text);
                a = Convert.ToDouble(textBox4.Text);

                m = F / a;

                textBox1.Text = m.ToString() + "Kg";
            }
            if(comboBox1.SelectedIndex == 2)
            {
                double F, m, a;
                F = Convert.ToDouble(textBox3.Text);
                m = Convert.ToDouble(textBox4.Text);

                a = F / m;

                textBox1.Text = a.ToString() + "m/s²";
            }
        }
    }
}
