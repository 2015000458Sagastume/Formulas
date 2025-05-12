namespace Formulas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fórmulasFísicasToolStripMenuItem = new ToolStripMenuItem();
            movimientoRectilíneoUniformeMRUToolStripMenuItem = new ToolStripMenuItem();
            fuerzaFToolStripMenuItem = new ToolStripMenuItem();
            peridoFrecuenciaYAcústicaToolStripMenuItem = new ToolStripMenuItem();
            acústicaToolStripMenuItem = new ToolStripMenuItem();
            pesoMasaYGravedadToolStripMenuItem = new ToolStripMenuItem();
            densidadMasaYVolumenToolStripMenuItem = new ToolStripMenuItem();
            leyDeOhmToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fórmulasFísicasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fórmulasFísicasToolStripMenuItem
            // 
            fórmulasFísicasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { movimientoRectilíneoUniformeMRUToolStripMenuItem, fuerzaFToolStripMenuItem, peridoFrecuenciaYAcústicaToolStripMenuItem, acústicaToolStripMenuItem, pesoMasaYGravedadToolStripMenuItem, densidadMasaYVolumenToolStripMenuItem, leyDeOhmToolStripMenuItem });
            fórmulasFísicasToolStripMenuItem.Name = "fórmulasFísicasToolStripMenuItem";
            fórmulasFísicasToolStripMenuItem.Size = new Size(156, 29);
            fórmulasFísicasToolStripMenuItem.Text = "Fórmulas Físicas";
            // 
            // movimientoRectilíneoUniformeMRUToolStripMenuItem
            // 
            movimientoRectilíneoUniformeMRUToolStripMenuItem.Name = "movimientoRectilíneoUniformeMRUToolStripMenuItem";
            movimientoRectilíneoUniformeMRUToolStripMenuItem.Size = new Size(423, 34);
            movimientoRectilíneoUniformeMRUToolStripMenuItem.Text = "Movimiento Rectilíneo Uniforme (MRU)";
            movimientoRectilíneoUniformeMRUToolStripMenuItem.Click += movimientoRectilíneoUniformeMRUToolStripMenuItem_Click;
            // 
            // fuerzaFToolStripMenuItem
            // 
            fuerzaFToolStripMenuItem.Name = "fuerzaFToolStripMenuItem";
            fuerzaFToolStripMenuItem.Size = new Size(423, 34);
            fuerzaFToolStripMenuItem.Text = "Fuerza (F)";
            fuerzaFToolStripMenuItem.Click += fuerzaFToolStripMenuItem_Click;
            // 
            // peridoFrecuenciaYAcústicaToolStripMenuItem
            // 
            peridoFrecuenciaYAcústicaToolStripMenuItem.Name = "peridoFrecuenciaYAcústicaToolStripMenuItem";
            peridoFrecuenciaYAcústicaToolStripMenuItem.Size = new Size(423, 34);
            peridoFrecuenciaYAcústicaToolStripMenuItem.Text = "Perido y Frecuencia";
            peridoFrecuenciaYAcústicaToolStripMenuItem.Click += peridoFrecuenciaYAcústicaToolStripMenuItem_Click;
            // 
            // acústicaToolStripMenuItem
            // 
            acústicaToolStripMenuItem.Name = "acústicaToolStripMenuItem";
            acústicaToolStripMenuItem.Size = new Size(423, 34);
            acústicaToolStripMenuItem.Text = "Acústica";
            acústicaToolStripMenuItem.Click += acústicaToolStripMenuItem_Click;
            // 
            // pesoMasaYGravedadToolStripMenuItem
            // 
            pesoMasaYGravedadToolStripMenuItem.Name = "pesoMasaYGravedadToolStripMenuItem";
            pesoMasaYGravedadToolStripMenuItem.Size = new Size(423, 34);
            pesoMasaYGravedadToolStripMenuItem.Text = "Peso, Masa y Gravedad";
            pesoMasaYGravedadToolStripMenuItem.Click += pesoMasaYGravedadToolStripMenuItem_Click;
            // 
            // densidadMasaYVolumenToolStripMenuItem
            // 
            densidadMasaYVolumenToolStripMenuItem.Name = "densidadMasaYVolumenToolStripMenuItem";
            densidadMasaYVolumenToolStripMenuItem.Size = new Size(423, 34);
            densidadMasaYVolumenToolStripMenuItem.Text = "Densidad, Masa y Volumen";
            densidadMasaYVolumenToolStripMenuItem.Click += densidadMasaYVolumenToolStripMenuItem_Click;
            // 
            // leyDeOhmToolStripMenuItem
            // 
            leyDeOhmToolStripMenuItem.Name = "leyDeOhmToolStripMenuItem";
            leyDeOhmToolStripMenuItem.Size = new Size(423, 34);
            leyDeOhmToolStripMenuItem.Text = "Ley de Ohm";
            leyDeOhmToolStripMenuItem.Click += leyDeOhmToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold);
            label1.Location = new Point(248, 91);
            label1.Name = "label1";
            label1.Size = new Size(292, 42);
            label1.TabIndex = 1;
            label1.Text = "Proyecto II Unidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold);
            label2.Location = new Point(282, 133);
            label2.Name = "label2";
            label2.Size = new Size(226, 42);
            label2.TabIndex = 2;
            label2.Text = "Programación";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 217);
            label3.Name = "label3";
            label3.Size = new Size(161, 25);
            label3.TabIndex = 3;
            label3.Text = "Andrés Sagastume";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fórmulasFísicasToolStripMenuItem;
        private ToolStripMenuItem movimientoRectilíneoUniformeMRUToolStripMenuItem;
        private ToolStripMenuItem fuerzaFToolStripMenuItem;
        private ToolStripMenuItem peridoFrecuenciaYAcústicaToolStripMenuItem;
        private ToolStripMenuItem acústicaToolStripMenuItem;
        private ToolStripMenuItem pesoMasaYGravedadToolStripMenuItem;
        private ToolStripMenuItem densidadMasaYVolumenToolStripMenuItem;
        private ToolStripMenuItem leyDeOhmToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
