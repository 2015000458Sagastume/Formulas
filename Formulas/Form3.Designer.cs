namespace Formulas
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(358, 69);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 3;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(230, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 152);
            label3.Name = "label3";
            label3.Size = new Size(271, 25);
            label3.TabIndex = 4;
            label3.Text = "Seleccione la magnitud a calcular";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Fuerza (F)", "Masa (m)", "Acelaración (a)" });
            comboBox1.Location = new Point(337, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(525, 152);
            label4.Name = "label4";
            label4.Size = new Size(24, 25);
            label4.TabIndex = 6;
            label4.Text = "=";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Honeydew;
            textBox1.Location = new Point(555, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 221);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 8;
            label5.Text = "Ingrese la Fuerza";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 272);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 9;
            label6.Text = "Ingrese la Masa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 323);
            label7.Name = "label7";
            label7.Size = new Size(183, 25);
            label7.TabIndex = 10;
            label7.Text = "Ingrese la Aceleración";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 31);
            textBox2.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(555, 221);
            button1.Name = "button1";
            button1.Size = new Size(130, 34);
            button1.TabIndex = 12;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(266, 320);
            button2.Name = "button2";
            button2.Size = new Size(0, 0);
            button2.TabIndex = 13;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(264, 266);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 31);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(264, 317);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(130, 31);
            textBox4.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(250, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(406, 218);
            label8.Name = "label8";
            label8.Size = new Size(25, 25);
            label8.TabIndex = 17;
            label8.Text = "N";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(406, 266);
            label9.Name = "label9";
            label9.Size = new Size(33, 25);
            label9.TabIndex = 18;
            label9.Text = "Kg";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(406, 323);
            label10.Name = "label10";
            label10.Size = new Size(50, 25);
            label10.TabIndex = 19;
            label10.Text = "m/s²";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(219, 9);
            label11.Name = "label11";
            label11.Size = new Size(350, 30);
            label11.TabIndex = 20;
            label11.Text = "Segunda Ley de Newton Fuerza";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}