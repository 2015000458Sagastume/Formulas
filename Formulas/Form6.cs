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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                double voltaje, corriente, resistencia;
                corriente = Convert.ToDouble(textBox2.Text);
                resistencia = Convert.ToDouble(textBox3.Text);
                voltaje = corriente * resistencia;
                textBox4.Text = voltaje.ToString() + " V";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                double voltaje, corriente, resistencia;
                voltaje = Convert.ToDouble(textBox1.Text);
                resistencia = Convert.ToDouble(textBox3.Text);
                corriente = voltaje / resistencia;
                textBox4.Text = corriente.ToString() + " A";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                double voltaje, corriente, resistencia;
                corriente = Convert.ToDouble(textBox2.Text);
                voltaje = Convert.ToDouble(textBox1.Text);
                resistencia = voltaje / corriente;
                textBox4.Text = resistencia.ToString() + " Ω";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            if (comboBox1.SelectedIndex == 1) {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
    }
}
