using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneGeometryCalculator
{
    public partial class F_AreaTriangulo : Form
    {
        public F_AreaTriangulo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double Base = Convert.ToDouble(txtB_Base.Text);
            double altura = Convert.ToDouble(txtB_Altura.Text);
            Calcula c = new Calcula();
            c.ATriangulo(Base, altura);
            txtB_Resultado.Text = Convert.ToString(Calcula.area);
        }

        private void txtB_Resultado_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
