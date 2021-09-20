namespace PlaneGeometryCalculator
{
    partial class F_AreaCirculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AreaCirculo));
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_radius = new System.Windows.Forms.Label();
            this.txtB_radius = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txtB_resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(65, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(349, 26);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "Escreva Os Dados Do Seu Círculo";
            this.lb_title.Click += new System.EventHandler(this.lb_title_Click);
            // 
            // lb_radius
            // 
            this.lb_radius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_radius.Location = new System.Drawing.Point(175, 73);
            this.lb_radius.Name = "lb_radius";
            this.lb_radius.Size = new System.Drawing.Size(102, 17);
            this.lb_radius.TabIndex = 2;
            this.lb_radius.Text = "Raio do círculo";
            // 
            // txtB_radius
            // 
            this.txtB_radius.Location = new System.Drawing.Point(177, 93);
            this.txtB_radius.Name = "txtB_radius";
            this.txtB_radius.Size = new System.Drawing.Size(100, 20);
            this.txtB_radius.TabIndex = 3;
            this.txtB_radius.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(188, 151);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 50);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txtB_resultado
            // 
            this.txtB_resultado.Location = new System.Drawing.Point(130, 232);
            this.txtB_resultado.Multiline = true;
            this.txtB_resultado.Name = "txtB_resultado";
            this.txtB_resultado.Size = new System.Drawing.Size(204, 109);
            this.txtB_resultado.TabIndex = 5;
            this.txtB_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultado";
            // 
            // F_AreaCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB_resultado);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txtB_radius);
            this.Controls.Add(this.lb_radius);
            this.Controls.Add(this.lb_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_AreaCirculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área do Círculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_radius;
        private System.Windows.Forms.TextBox txtB_radius;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txtB_resultado;
        private System.Windows.Forms.Label label1;
    }
}