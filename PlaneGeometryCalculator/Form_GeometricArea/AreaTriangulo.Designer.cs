namespace PlaneGeometryCalculator
{
    partial class F_AreaTriangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AreaTriangulo));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Base = new System.Windows.Forms.Label();
            this.lb_Altura = new System.Windows.Forms.Label();
            this.txtB_Base = new System.Windows.Forms.TextBox();
            this.txtB_Altura = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txtB_Resultado = new System.Windows.Forms.TextBox();
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Escreva os dados do seu Triângulo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_Base
            // 
            this.lb_Base.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Base.Location = new System.Drawing.Point(102, 62);
            this.lb_Base.Name = "lb_Base";
            this.lb_Base.Size = new System.Drawing.Size(40, 18);
            this.lb_Base.TabIndex = 17;
            this.lb_Base.Text = "Base";
            this.lb_Base.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_Base.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_Altura
            // 
            this.lb_Altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Altura.Location = new System.Drawing.Point(408, 62);
            this.lb_Altura.Name = "lb_Altura";
            this.lb_Altura.Size = new System.Drawing.Size(46, 18);
            this.lb_Altura.TabIndex = 18;
            this.lb_Altura.Text = "Altura";
            this.lb_Altura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtB_Base
            // 
            this.txtB_Base.Location = new System.Drawing.Point(72, 83);
            this.txtB_Base.Name = "txtB_Base";
            this.txtB_Base.Size = new System.Drawing.Size(100, 20);
            this.txtB_Base.TabIndex = 19;
            this.txtB_Base.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtB_Altura
            // 
            this.txtB_Altura.Location = new System.Drawing.Point(382, 83);
            this.txtB_Altura.Name = "txtB_Altura";
            this.txtB_Altura.Size = new System.Drawing.Size(100, 20);
            this.txtB_Altura.TabIndex = 20;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(221, 131);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(124, 38);
            this.btn_Calcular.TabIndex = 21;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txtB_Resultado
            // 
            this.txtB_Resultado.Location = new System.Drawing.Point(183, 232);
            this.txtB_Resultado.Multiline = true;
            this.txtB_Resultado.Name = "txtB_Resultado";
            this.txtB_Resultado.Size = new System.Drawing.Size(199, 95);
            this.txtB_Resultado.TabIndex = 22;
            this.txtB_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB_Resultado.TextChanged += new System.EventHandler(this.txtB_Resultado_TextChanged);
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Resultado.Location = new System.Drawing.Point(221, 211);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(124, 18);
            this.lb_Resultado.TabIndex = 23;
            this.lb_Resultado.Text = "Resultado";
            this.lb_Resultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // F_AreaTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 339);
            this.Controls.Add(this.lb_Resultado);
            this.Controls.Add(this.txtB_Resultado);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txtB_Altura);
            this.Controls.Add(this.txtB_Base);
            this.Controls.Add(this.lb_Altura);
            this.Controls.Add(this.lb_Base);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_AreaTriangulo";
            this.Text = "Área do Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Base;
        private System.Windows.Forms.Label lb_Altura;
        private System.Windows.Forms.TextBox txtB_Base;
        private System.Windows.Forms.TextBox txtB_Altura;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txtB_Resultado;
        private System.Windows.Forms.Label lb_Resultado;
    }
}