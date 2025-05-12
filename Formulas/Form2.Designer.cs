namespace Formulas
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(215, 9);
            label1.Name = "label1";
            label1.Size = new Size(348, 30);
            label1.TabIndex = 0;
            label1.Text = "Movimiento Rectílineo Uniforme";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(357, 39);
            label2.Name = "label2";
            label2.Size = new Size(64, 30);
            label2.TabIndex = 1;
            label2.Text = "MRU";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Velocidad (v)", "Distancia (d)", "Tiempo (t)" });
            comboBox1.Location = new Point(358, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 174);
            label3.Name = "label3";
            label3.Size = new Size(271, 25);
            label3.TabIndex = 3;
            label3.Text = "Seleccione la magnitud a calcular";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(546, 174);
            label4.Name = "label4";
            label4.Size = new Size(24, 25);
            label4.TabIndex = 4;
            label4.Text = "=";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Honeydew;
            textBox1.Location = new Point(576, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 239);
            label5.Name = "label5";
            label5.Size = new Size(170, 25);
            label5.TabIndex = 6;
            label5.Text = "Ingrese la Velocidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 300);
            label6.Name = "label6";
            label6.Size = new Size(164, 25);
            label6.TabIndex = 7;
            label6.Text = "Ingrese la Distancia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(73, 362);
            label7.Name = "label7";
            label7.Size = new Size(153, 25);
            label7.TabIndex = 8;
            label7.Text = "Ingrese el Tiempo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(255, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 31);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(255, 294);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 31);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(255, 356);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(130, 31);
            textBox4.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(258, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(347, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(455, 90);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(579, 234);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 15;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(391, 239);
            label8.Name = "label8";
            label8.Size = new Size(43, 25);
            label8.TabIndex = 16;
            label8.Text = "m/s";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(391, 297);
            label9.Name = "label9";
            label9.Size = new Size(28, 25);
            label9.TabIndex = 17;
            label9.Text = "m";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(391, 362);
            label10.Name = "label10";
            label10.Size = new Size(20, 25);
            label10.TabIndex = 18;
            label10.Text = "s";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}