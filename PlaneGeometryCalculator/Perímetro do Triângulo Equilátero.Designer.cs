namespace PlaneGeometryCalculator
{
    partial class F_PerimetroTrianguloEq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_PerimetroTrianguloEq));
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_radius = new System.Windows.Forms.Label();
            this.txtB_side1 = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB_resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(51, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(369, 26);
            this.lb_title.TabIndex = 8;
            this.lb_title.Text = "Escreva Os Dados Do Seu Triângulo";
            // 
            // lb_radius
            // 
            this.lb_radius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_radius.Location = new System.Drawing.Point(212, 56);
            this.lb_radius.Name = "lb_radius";
            this.lb_radius.Size = new System.Drawing.Size(41, 17);
            this.lb_radius.TabIndex = 9;
            this.lb_radius.Text = "Lado";
            // 
            // txtB_side1
            // 
            this.txtB_side1.Location = new System.Drawing.Point(180, 76);
            this.txtB_side1.Name = "txtB_side1";
            this.txtB_side1.Size = new System.Drawing.Size(100, 20);
            this.txtB_side1.TabIndex = 10;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(193, 128);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 50);
            this.btn_Calcular.TabIndex = 20;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Resultado";
            // 
            // txtB_resultado
            // 
            this.txtB_resultado.Location = new System.Drawing.Point(127, 228);
            this.txtB_resultado.Multiline = true;
            this.txtB_resultado.Name = "txtB_resultado";
            this.txtB_resultado.Size = new System.Drawing.Size(204, 109);
            this.txtB_resultado.TabIndex = 22;
            this.txtB_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // F_PerimetroTrianguloEq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtB_resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txtB_side1);
            this.Controls.Add(this.lb_radius);
            this.Controls.Add(this.lb_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_PerimetroTrianguloEq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perímetro do Triângulo Equilátero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_radius;
        private System.Windows.Forms.TextBox txtB_side1;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB_resultado;
    }
}