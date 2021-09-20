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
    public partial class F_PerimetroQuadrado : Form
    {
        public F_PerimetroQuadrado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double side = Convert.ToDouble(txtB_side.Text);
            Calcula calcula = new Calcula();
            calcula.PQuadrado(side);
            txtB_resultado.Text = Convert.ToString(Calcula.perimetro);
        }
    }
}
