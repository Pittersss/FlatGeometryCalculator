namespace PlaneGeometryCalculator
{
    partial class F_AreaTrianguloEquilatero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AreaTrianguloEquilatero));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Base = new System.Windows.Forms.Label();
            this.txtB_lado = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.txtB_Resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Escreva os dados do seu Triângulo Equilátero";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Base
            // 
            this.lb_Base.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Base.Location = new System.Drawing.Point(265, 73);
            this.lb_Base.Name = "lb_Base";
            this.lb_Base.Size = new System.Drawing.Size(40, 18);
            this.lb_Base.TabIndex = 24;
            this.lb_Base.Text = "Lado";
            this.lb_Base.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtB_lado
            // 
            this.txtB_lado.Location = new System.Drawing.Point(235, 94);
            this.txtB_lado.Name = "txtB_lado";
            this.txtB_lado.Size = new System.Drawing.Size(100, 20);
            this.txtB_lado.TabIndex = 25;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(222, 144);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(124, 38);
            this.btn_Calcular.TabIndex = 26;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Resultado.Location = new System.Drawing.Point(222, 211);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(124, 18);
            this.lb_Resultado.TabIndex = 27;
            this.lb_Resultado.Text = "Resultado";
            this.lb_Resultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtB_Resultado
            // 
            this.txtB_Resultado.Location = new System.Drawing.Point(186, 232);
            this.txtB_Resultado.Multiline = true;
            this.txtB_Resultado.Name = "txtB_Resultado";
            this.txtB_Resultado.Size = new System.Drawing.Size(199, 95);
            this.txtB_Resultado.TabIndex = 28;
            this.txtB_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // F_AreaTrianguloEquilatero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 339);
            this.Controls.Add(this.txtB_Resultado);
            this.Controls.Add(this.lb_Resultado);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txtB_lado);
            this.Controls.Add(this.lb_Base);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_AreaTrianguloEquilatero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área do Triângulo Equilátero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Base;
        private System.Windows.Forms.TextBox txtB_lado;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lb_Resultado;
        private System.Windows.Forms.TextBox txtB_Resultado;
    }
}