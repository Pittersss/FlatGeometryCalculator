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
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_side = new System.Windows.Forms.Label();
            this.txtB_Dmaior = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_resultado = new System.Windows.Forms.TextBox();
            this.txtB_Dmenor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(60, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(363, 26);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "Escreva Os Dados Do Seu Losango";
            // 
            // lb_side
            // 
            this.lb_side.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_side.Location = new System.Drawing.Point(122, 60);
            this.lb_side.Name = "lb_side";
            this.lb_side.Size = new System.Drawing.Size(59, 17);
            this.lb_side.TabIndex = 3;
            this.lb_side.Text = "D Maior";
            // 
            // txtB_Dmaior
            // 
            this.txtB_Dmaior.Location = new System.Drawing.Point(99, 80);
            this.txtB_Dmaior.Name = "txtB_Dmaior";
            this.txtB_Dmaior.Size = new System.Drawing.Size(100, 20);
            this.txtB_Dmaior.TabIndex = 5;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(189, 127);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 50);
            this.btn_Calcular.TabIndex = 7;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resultado";
            // 
            // txtB_resultado
            // 
            this.txtB_resultado.Location = new System.Drawing.Point(125, 224);
            this.txtB_resultado.Multiline = true;
            this.txtB_resultado.Name = "txtB_resultado";
            this.txtB_resultado.Size = new System.Drawing.Size(204, 109);
            this.txtB_resultado.TabIndex = 9;
            this.txtB_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB_Dmenor
            // 
            this.txtB_Dmenor.Location = new System.Drawing.Point(284, 80);
            this.txtB_Dmenor.Name = "txtB_Dmenor";
            this.txtB_Dmenor.Size = new System.Drawing.Size(100, 20);
            this.txtB_Dmenor.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "D menor";
            // 
            // F_AreaLosango
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB_Dmenor);
            this.Controls.Add(this.txtB_resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txtB_Dmaior);
            this.Controls.Add(this.lb_side);
            this.Controls.Add(this.lb_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_AreaLosango";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área do Losango";
            this.Load += new System.EventHandler(this.F_AreaLosango_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_side;
        private System.Windows.Forms.TextBox txtB_Dmaior;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_resultado;
        private System.Windows.Forms.TextBox txtB_Dmenor;
        private System.Windows.Forms.Label label1;
    }
}