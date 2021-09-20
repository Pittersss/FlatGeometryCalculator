namespace PlaneGeometryCalculator
{
    partial class F_PerimetroRetangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_PerimetroRetangulo));
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_base = new System.Windows.Forms.Label();
            this.txtB_base = new System.Windows.Forms.TextBox();
            this.lb_heigth = new System.Windows.Forms.Label();
            this.txtB_altura = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(44, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(379, 26);
            this.lb_title.TabIndex = 3;
            this.lb_title.Text = "Escreva Os Dados Do Seu Retângulo";
            // 
            // lb_base
            // 
            this.lb_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_base.Location = new System.Drawing.Point(113, 35);
            this.lb_base.Name = "lb_base";
            this.lb_base.Size = new System.Drawing.Size(40, 17);
            this.lb_base.TabIndex = 5;
            this.lb_base.Text = "Base";
            // 
            // txtB_base
            // 
            this.txtB_base.Location = new System.Drawing.Point(87, 55);
            this.txtB_base.Name = "txtB_base";
            this.txtB_base.Size = new System.Drawing.Size(100, 20);
            this.txtB_base.TabIndex = 9;
            // 
            // lb_heigth
            // 
            this.lb_heigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_heigth.Location = new System.Drawing.Point(307, 35);
            this.lb_heigth.Name = "lb_heigth";
            this.lb_heigth.Size = new System.Drawing.Size(46, 17);
            this.lb_heigth.TabIndex = 10;
            this.lb_heigth.Text = "Altura";
            // 
            // txtB_altura
            // 
            this.txtB_altura.Location = new System.Drawing.Point(279, 55);
            this.txtB_altura.Name = "txtB_altura";
            this.txtB_altura.Size = new System.Drawing.Size(100, 20);
            this.txtB_altura.TabIndex = 11;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(195, 93);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 50);
            this.btn_Calcular.TabIndex = 12;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Resultado";
            // 
            // txtB_resultado
            // 
            this.txtB_resultado.Location = new System.Drawing.Point(133, 214);
            this.txtB_resultado.Multiline = true;
            this.txtB_resultado.Name = "txtB_resultado";
            this.txtB_resultado.Size = new System.Drawing.Size(204, 109);
            this.txtB_resultado.TabIndex = 14;
            this.txtB_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // F_PerimetroRetangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtB_resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txtB_altura);
            this.Controls.Add(this.lb_heigth);
            this.Controls.Add(this.txtB_base);
            this.Controls.Add(this.lb_base);
            this.Controls.Add(this.lb_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_PerimetroRetangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perímetro do Retângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_base;
        private System.Windows.Forms.TextBox txtB_base;
        private System.Windows.Forms.Label lb_heigth;
        private System.Windows.Forms.TextBox txtB_altura;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_resultado;
    }
}