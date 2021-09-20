namespace PlaneGeometryCalculator
{
    partial class F_AreaLosango
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AreaLosango));
            this.label1 = new System.Windows.Forms.Label();
            this.txtB_Dmaior = new System.Windows.Forms.TextBox();
            this.lb_Dmaior = new System.Windows.Forms.Label();
            this.txtB_Dmenor = new System.Windows.Forms.TextBox();
            this.lb_Dmenor = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txtB_Resultado = new System.Windows.Forms.TextBox();
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Escreva os dados do seu Losango";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtB_Dmaior
            // 
            this.txtB_Dmaior.Location = new System.Drawing.Point(97, 112);
            this.txtB_Dmaior.Name = "txtB_Dmaior";
            this.txtB_Dmaior.Size = new System.Drawing.Size(100, 20);
            this.txtB_Dmaior.TabIndex = 24;
            this.txtB_Dmaior.TextChanged += new System.EventHandler(this.txtB_Base_TextChanged);
            // 
            // lb_Dmaior
            // 
            this.lb_Dmaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Dmaior.Location = new System.Drawing.Point(108, 91);
            this.lb_Dmaior.Name = "lb_Dmaior";
            this.lb_Dmaior.Size = new System.Drawing.Size(70, 18);
            this.lb_Dmaior.TabIndex = 25;
            this.lb_Dmaior.Text = "D maior ";
            this.lb_Dmaior.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtB_Dmenor
            // 
            this.txtB_Dmenor.Location = new System.Drawing.Point(365, 112);
            this.txtB_Dmenor.Name = "txtB_Dmenor";
            this.txtB_Dmenor.Size = new System.Drawing.Size(100, 20);
            this.txtB_Dmenor.TabIndex = 26;
            // 
            // lb_Dmenor
            // 
            this.lb_Dmenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Dmenor.Location = new System.Drawing.Point(375, 91);
            this.lb_Dmenor.Name = "lb_Dmenor";
            this.lb_Dmenor.Size = new System.Drawing.Size(76, 18);
            this.lb_Dmenor.TabIndex = 27;
            this.lb_Dmenor.Text = "D menor";
            this.lb_Dmenor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_Dmenor.Click += new System.EventHandler(this.lb_Altura_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(217, 151);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(124, 38);
            this.btn_Calcular.TabIndex = 28;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txtB_Resultado
            // 
            this.txtB_Resultado.Location = new System.Drawing.Point(179, 232);
            this.txtB_Resultado.Multiline = true;
            this.txtB_Resultado.Name = "txtB_Resultado";
            this.txtB_Resultado.Size = new System.Drawing.Size(199, 95);
            this.txtB_Resultado.TabIndex = 29;
            this.txtB_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Resultado.Location = new System.Drawing.Point(217, 211);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(124, 18);
            this.lb_Resultado.TabIndex = 30;
            this.lb_Resultado.Text = "Resultado";
            this.lb_Resultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // F_AreaLosango
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 339);
            this.Controls.Add(this.lb_Resultado);
            this.Controls.Add(this.txtB_Resultado);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lb_Dmenor);
            this.Controls.Add(this.txtB_Dmenor);
            this.Controls.Add(this.lb_Dmaior);
            this.Controls.Add(this.txtB_Dmaior);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_AreaLosango";
            this.Text = "Área do Losango";
            this.Load += new System.EventHandler(this.AreaLosango_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB_Dmaior;
        private System.Windows.Forms.Label lb_Dmaior;
        private System.Windows.Forms.TextBox txtB_Dmenor;
        private System.Windows.Forms.Label lb_Dmenor;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txtB_Resultado;
        private System.Windows.Forms.Label lb_Resultado;
    }
}