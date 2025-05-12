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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                double peso, masa, gravedad;
                masa = Convert.ToDouble(textBox1.Text);
                gravedad = Convert.ToDouble(textBox2.Text);
                peso = masa * gravedad;
                textBox4.Text = peso.ToString() + " N";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                double peso, masa, gravedad;
                peso = Convert.ToDouble(textBox3.Text);
                gravedad = Convert.ToDouble(textBox2.Text);
                masa = peso / gravedad;
                textBox4.Text = masa.ToString() + " Kg";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                double peso, masa, gravedad;
                masa = Convert.ToDouble(textBox1.Text);
                peso = Convert.ToDouble(textBox3.Text);
                gravedad = peso / masa;
                textBox4.Text = peso.ToString() + " m/s2";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            if (comboBox1.SelectedIndex == 1)
            {
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                double densidad, masa, volumen;
                masa = Convert.ToDouble(textBox8.Text);
                volumen = Convert.ToDouble(textBox7.Text);
                densidad = masa / volumen;
                textBox5.Text = densidad.ToString() + " kg/m";
            }
            if (comboBox2.SelectedIndex == 1)
            {
                double densidad, masa, volumen;
                densidad = Convert.ToDouble(textBox6.Text);
                volumen = Convert.ToDouble(textBox7.Text);
                masa = densidad * volumen;
                textBox5.Text = masa.ToString() + " kg";
            }
            if (comboBox2.SelectedIndex == 2)
            {
                double densidad, masa, volumen;
                masa = Convert.ToDouble(textBox8.Text);
                densidad = Convert.ToDouble(textBox7.Text);
                volumen = masa / densidad;
                textBox5.Text = volumen.ToString() + " m";
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0) {
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }
            if (comboBox2.SelectedIndex == 1)
            {
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }
            if (comboBox2.SelectedIndex == 2) {
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }
        }
    }
}
