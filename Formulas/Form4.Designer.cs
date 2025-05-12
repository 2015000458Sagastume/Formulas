namespace Formulas
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            button2 = new Button();
            textBox5 = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 34);
            label1.Name = "label1";
            label1.Size = new Size(261, 25);
            label1.TabIndex = 0;
            label1.Text = "Calculo de Periodo y Frecuencia";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Frecuencia (f)", "Periodo (T)" });
            comboBox1.Location = new Point(76, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 122);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 2;
            label2.Text = "=";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 128);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 4;
            label3.Text = "(Hz)";
            // 
            // button1
            // 
            button1.Location = new Point(76, 170);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 214);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 6;
            label4.Text = "Periodo (T) =";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 220);
            label5.Name = "label5";
            label5.Size = new Size(30, 25);
            label5.TabIndex = 8;
            label5.Text = "(s)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(294, 280);
            label6.Name = "label6";
            label6.Size = new Size(164, 25);
            label6.TabIndex = 9;
            label6.Text = "Cálculo de Acústica";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Intensidad (I)", "Potencia (P)", "Área (A)" });
            comboBox2.Location = new Point(76, 319);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 368);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 11;
            label7.Text = "Área (A) =";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 365);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(332, 370);
            label8.Name = "label8";
            label8.Size = new Size(48, 25);
            label8.TabIndex = 13;
            label8.Text = "(m2)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(401, 370);
            label9.Name = "label9";
            label9.Size = new Size(120, 25);
            label9.TabIndex = 14;
            label9.Text = "Potencia (P) =";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(527, 370);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(683, 373);
            label10.Name = "label10";
            label10.Size = new Size(39, 25);
            label10.TabIndex = 16;
            label10.Text = "(W)";
            // 
            // button2
            // 
            button2.Location = new Point(76, 420);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 17;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(76, 476);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(232, 482);
            label11.Name = "label11";
            label11.Size = new Size(72, 25);
            label11.TabIndex = 19;
            label11.Text = "(W/m2)";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 568);
            Controls.Add(label11);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private ComboBox comboBox2;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private Label label9;
        private TextBox textBox4;
        private Label label10;
        private Button button2;
        private TextBox textBox5;
        private Label label11;
    }
}