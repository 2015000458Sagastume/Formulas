﻿namespace Formulas
{
    partial class Form6
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
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 32);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "Ley de Ohm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 85);
            label2.Name = "label2";
            label2.Size = new Size(274, 25);
            label2.TabIndex = 1;
            label2.Text = "Selecciona lo que quieres calcular";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Voltaje", "Corriente", "Resistencia" });
            comboBox1.Location = new Point(388, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 163);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 3;
            label3.Text = "Voltaje =";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(441, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(760, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 163);
            label4.Name = "label4";
            label4.Size = new Size(23, 25);
            label4.TabIndex = 7;
            label4.Text = "V";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 166);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 8;
            label5.Text = "Corriente =";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(597, 169);
            label6.Name = "label6";
            label6.Size = new Size(24, 25);
            label6.TabIndex = 9;
            label6.Text = "A";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(640, 169);
            label7.Name = "label7";
            label7.Size = new Size(114, 25);
            label7.TabIndex = 10;
            label7.Text = "Resistencia =";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(916, 172);
            label8.Name = "label8";
            label8.Size = new Size(26, 25);
            label8.TabIndex = 11;
            label8.Text = "Ω";
            // 
            // button1
            // 
            button1.Location = new Point(458, 238);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 12;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(441, 293);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 13;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 432);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private TextBox textBox4;
    }
}