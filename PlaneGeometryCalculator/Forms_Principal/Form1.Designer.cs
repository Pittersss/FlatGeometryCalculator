namespace PlaneGeometryCalculator
{
    partial class F_main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_main));
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_subtitle = new System.Windows.Forms.Label();
            this.btn_showArea = new System.Windows.Forms.Button();
            this.btn_showPerimetro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(83, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(274, 26);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "Plane Geometry Calculator";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_title.Click += new System.EventHandler(this.lb_title_Click);
            // 
            // lb_subtitle
            // 
            this.lb_subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subtitle.Location = new System.Drawing.Point(136, 35);
            this.lb_subtitle.Name = "lb_subtitle";
            this.lb_subtitle.Size = new System.Drawing.Size(180, 26);
            this.lb_subtitle.TabIndex = 2;
            this.lb_subtitle.Text = "O que você vai calcular?";
            this.lb_subtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_showArea
            // 
            this.btn_showArea.Location = new System.Drawing.Point(304, 113);
            this.btn_showArea.Name = "btn_showArea";
            this.btn_showArea.Size = new System.Drawing.Size(107, 41);
            this.btn_showArea.TabIndex = 3;
            this.btn_showArea.Text = "Área";
            this.btn_showArea.UseVisualStyleBackColor = true;
            this.btn_showArea.Click += new System.EventHandler(this.btn_showArea_Click);
            // 
            // btn_showPerimetro
            // 
            this.btn_showPerimetro.Location = new System.Drawing.Point(59, 113);
            this.btn_showPerimetro.Name = "btn_showPerimetro";
            this.btn_showPerimetro.Size = new System.Drawing.Size(107, 41);
            this.btn_showPerimetro.TabIndex = 4;
            this.btn_showPerimetro.Text = "Perímetro";
            this.btn_showPerimetro.UseVisualStyleBackColor = true;
            this.btn_showPerimetro.Click += new System.EventHandler(this.btn_showPerimetro_Click);
            // 
            // F_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 231);
            this.Controls.Add(this.btn_showPerimetro);
            this.Controls.Add(this.btn_showArea);
            this.Controls.Add(this.lb_subtitle);
            this.Controls.Add(this.lb_title);
            this.Font = new System.Drawing.Font("Nirmala UI Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "F_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geometry Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_subtitle;
        private System.Windows.Forms.Button btn_showArea;
        private System.Windows.Forms.Button btn_showPerimetro;
    }
}

