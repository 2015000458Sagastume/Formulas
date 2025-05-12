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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                double frecuencia, periodo;
                frecuencia = Convert.ToDouble(textBox1.Text);
                periodo = 1 / frecuencia;
                textBox2.Text = periodo.ToString();
            }
            if (comboBox2.SelectedIndex == 1)
            {
                double frecuencia, periodo;
                frecuencia = Convert.ToDouble(textBox1.Text);
                frecuencia = 1 / frecuencia;
                textBox2.Text = frecuencia.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label3.Text = "(Hz)";
                label5.Text = "(s)";
                label4.Text = "Periodo (T) =";
                textBox1.Text = "";
                textBox2.Text = "";
            }
            if (comboBox2.SelectedIndex == 1)
            {
                label3.Text = "(s)";
                label5.Text = "(Hz)";
                label4.Text = "Frecuencia (f) =";
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                double intensidad, area, potencia;
                potencia = Convert.ToDouble(textBox4.Text);
                area = Convert.ToDouble(textBox3.Text);
                intensidad = potencia / area;
                textBox5.Text = intensidad.ToString();
            }
            if (comboBox2.SelectedIndex == 1)
            {
                double intensidad, area, potencia;
                intensidad = Convert.ToDouble(textBox4.Text);
                area = Convert.ToDouble(textBox3.Text);
                potencia = intensidad * area;
                textBox5.Text = potencia.ToString();
            }
            if (comboBox2.SelectedIndex == 2)
            {
                double intensidad, area, potencia;
                potencia = Convert.ToDouble(textBox4.Text);
                intensidad = Convert.ToDouble(textBox3.Text);
                area = potencia / intensidad;
                textBox5.Text = area.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0) {
                label7.Text = "Área (A)";
                label9.Text = "Potencia (P)";
                label8.Text = "(m2)";
                label10.Text = "(W)";
                label11.Text = "(W/m2)";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            if (comboBox2.SelectedIndex == 1)
            {
                label7.Text = "Área (A)";
                label9.Text = "Intensidad (I)";
                label8.Text = "(m2)";
                label10.Text = "(W/m2)";
                label11.Text = "(W)";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            if (comboBox2.SelectedIndex == 2) {
                label7.Text = "Intensidad (I)";
                label9.Text = "Potencia (P)";
                label8.Text = "(W/m2)";
                label10.Text = "(W)";
                label11.Text = "(m2)";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
          
        }
    }
}
