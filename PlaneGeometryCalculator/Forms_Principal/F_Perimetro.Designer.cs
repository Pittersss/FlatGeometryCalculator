namespace PlaneGeometryCalculator
{
    partial class F_Perimetro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Perimetro));
            this.btn_Ptriangulo = new System.Windows.Forms.Button();
            this.btn_Pquadrado = new System.Windows.Forms.Button();
            this.btn_Pretangulo = new System.Windows.Forms.Button();
            this.btn_PtrianguloEq = new System.Windows.Forms.Button();
            this.btn_Pcirculo = new System.Windows.Forms.Button();
            this.btn_Plosango = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_PTrapezio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ptriangulo
            // 
            this.btn_Ptriangulo.Location = new System.Drawing.Point(69, 98);
            this.btn_Ptriangulo.Name = "btn_Ptriangulo";
            this.btn_Ptriangulo.Size = new System.Drawing.Size(107, 41);
            this.btn_Ptriangulo.TabIndex = 5;
            this.btn_Ptriangulo.Text = "Triângulo";
            this.btn_Ptriangulo.UseVisualStyleBackColor = true;
            this.btn_Ptriangulo.Click += new System.EventHandler(this.btn_Atriangulo_Click);
            // 
            // btn_Pquadrado
            // 
            this.btn_Pquadrado.Location = new System.Drawing.Point(69, 173);
            this.btn_Pquadrado.Name = "btn_Pquadrado";
            this.btn_Pquadrado.Size = new System.Drawing.Size(107, 41);
            this.btn_Pquadrado.TabIndex = 6;
            this.btn_Pquadrado.Text = "Quadrado";
            this.btn_Pquadrado.UseVisualStyleBackColor = true;
            this.btn_Pquadrado.Click += new System.EventHandler(this.btn_Pquadrado_Click);
            // 
            // btn_Pretangulo
            // 
            this.btn_Pretangulo.Location = new System.Drawing.Point(69, 242);
            this.btn_Pretangulo.Name = "btn_Pretangulo";
            this.btn_Pretangulo.Size = new System.Drawing.Size(107, 41);
            this.btn_Pretangulo.TabIndex = 8;
            this.btn_Pretangulo.Text = "Retângulo";
            this.btn_Pretangulo.UseVisualStyleBackColor = true;
            this.btn_Pretangulo.Click += new System.EventHandler(this.btn_Pretangulo_Click);
            // 
            // btn_PtrianguloEq
            // 
            this.btn_PtrianguloEq.Location = new System.Drawing.Point(368, 98);
            this.btn_PtrianguloEq.Name = "btn_PtrianguloEq";
            this.btn_PtrianguloEq.Size = new System.Drawing.Size(107, 41);
            this.btn_PtrianguloEq.TabIndex = 9;
            this.btn_PtrianguloEq.Text = "Triângulo Equilátero";
            this.btn_PtrianguloEq.UseVisualStyleBackColor = true;
            this.btn_PtrianguloEq.Click += new System.EventHandler(this.btn_PtrianguloEq_Click);
            // 
            // btn_Pcirculo
            // 
            this.btn_Pcirculo.Location = new System.Drawing.Point(368, 173);
            this.btn_Pcirculo.Name = "btn_Pcirculo";
            this.btn_Pcirculo.Size = new System.Drawing.Size(107, 41);
            this.btn_Pcirculo.TabIndex = 10;
            this.btn_Pcirculo.Text = "Círculo";
            this.btn_Pcirculo.UseVisualStyleBackColor = true;
            this.btn_Pcirculo.Click += new System.EventHandler(this.btn_Pcirculo_Click);
            // 
            // btn_Plosango
            // 
            this.btn_Plosango.Location = new System.Drawing.Point(368, 242);
            this.btn_Plosango.Name = "btn_Plosango";
            this.btn_Plosango.Size = new System.Drawing.Size(107, 41);
            this.btn_Plosango.TabIndex = 11;
            this.btn_Plosango.Text = "Losango";
            this.btn_Plosango.UseVisualStyleBackColor = true;
            this.btn_Plosango.Click += new System.EventHandler(this.btn_Alosango_Click);
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(30, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(537, 26);
            this.lb_title.TabIndex = 12;
            this.lb_title.Text = "Qual figura geometrica você quer saber o perímetro?";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_PTrapezio
            // 
            this.btn_PTrapezio.Location = new System.Drawing.Point(218, 173);
            this.btn_PTrapezio.Name = "btn_PTrapezio";
            this.btn_PTrapezio.Size = new System.Drawing.Size(107, 41);
            this.btn_PTrapezio.TabIndex = 13;
            this.btn_PTrapezio.Text = "Trapézio";
            this.btn_PTrapezio.UseVisualStyleBackColor = true;
            this.btn_PTrapezio.Click += new System.EventHandler(this.btn_PTrapezio_Click);
            // 
            // F_Perimetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 339);
            this.Controls.Add(this.btn_PTrapezio);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.btn_Plosango);
            this.Controls.Add(this.btn_Pcirculo);
            this.Controls.Add(this.btn_PtrianguloEq);
            this.Controls.Add(this.btn_Pretangulo);
            this.Controls.Add(this.btn_Pquadrado);
            this.Controls.Add(this.btn_Ptriangulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(333, 232);
            this.Name = "F_Perimetro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perímetro";
            this.Load += new System.EventHandler(this.F_Perimetro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Ptriangulo;
        private System.Windows.Forms.Button btn_Pquadrado;
        private System.Windows.Forms.Button btn_Pretangulo;
        private System.Windows.Forms.Button btn_PtrianguloEq;
        private System.Windows.Forms.Button btn_Pcirculo;
        private System.Windows.Forms.Button btn_Plosango;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button btn_PTrapezio;
    }
}