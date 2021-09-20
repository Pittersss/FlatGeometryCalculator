namespace PlaneGeometryCalculator
{
    partial class F_AreaTrapezio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AreaTrapezio));
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_radius = new System.Windows.Forms.Label();
            this.txtB_bMaior = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_resultado = new System.Windows.Forms.TextBox();
            this.txtB_heigth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB_bMenor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(52, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(363, 26);
            this.lb_title.TabIndex = 3;
            this.lb_title.Text = "Escreva Os Dados Do Seu Trapézio";
            // 
            // lb_radius
            // 
            this.lb_radius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_radius.Location = new System.Drawing.Point(84, 46);
            this.lb_radius.Name = "lb_radius";
            this.lb_radius.Size = new System.Drawing.Size(57, 17);
            this.lb_radius.TabIndex = 4;
            this.lb_radius.Text = "B Maior";
            this.lb_radius.Click += new System.EventHandler(this.lb_radius_Click);
            // 
            // txtB_bMaior
            // 
            this.txtB_bMaior.Location = new System.Drawing.Point(62, 66);
            this.txtB_bMaior.Name = "txtB_bMaior";
            this.txtB_bMaior.Size = new System.Drawing.Size(100, 20);
            this.txtB_bMaior.TabIndex = 6;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(192, 118);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 50);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Resultado";
            // 
            // txtB_resultado
            // 
            this.txtB_resultado.Location = new System.Drawing.Point(124, 231);
            this.txtB_resultado.Multiline = true;
            this.txtB_resultado.Name = "txtB_resultado";
            this.txtB_resultado.Size = new System.Drawing.Size(204, 109);
            this.txtB_resultado.TabIndex = 10;
            this.txtB_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB_heigth
            // 
            this.txtB_heigth.Location = new System.Drawing.Point(305, 66);
            this.txtB_heigth.Name = "txtB_heigth";
            this.txtB_heigth.Size = new System.Drawing.Size(100, 20);
            this.txtB_heigth.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Altura";
            // 
            // txtB_bMenor
            // 
            this.txtB_bMenor.Location = new System.Drawing.Point(183, 66);
            this.txtB_bMenor.Name = "txtB_bMenor";
            this.txtB_bMenor.Size = new System.Drawing.Size(100, 20);
            this.txtB_bMenor.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "B Menor";
            // 
            // F_AreaTrapezio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB_bMenor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtB_heigth);
            this.Controls.Add(this.txtB_resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txtB_bMaior);
            this.Controls.Add(this.lb_radius);
            this.Controls.Add(this.lb_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_AreaTrapezio";
            this.Text = "Área do Trapézio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_radius;
        private System.Windows.Forms.TextBox txtB_bMaior;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_resultado;
        private System.Windows.Forms.TextBox txtB_heigth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB_bMenor;
        private System.Windows.Forms.Label label1;
    }
}