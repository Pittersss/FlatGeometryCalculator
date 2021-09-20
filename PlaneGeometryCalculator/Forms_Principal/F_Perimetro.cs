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
    public partial class F_Perimetro : Form
    {
        public F_Perimetro()
        {
            InitializeComponent();
        }

        private void btn_Atriangulo_Click(object sender, EventArgs e)
        {
            F_PerimetroTriangulo f = new F_PerimetroTriangulo();
            f.ShowDialog();
        }

        private void F_Perimetro_Load(object sender, EventArgs e)
        {

        }

        private void btn_Alosango_Click(object sender, EventArgs e)
        {
            F_PerimetroLosango f = new F_PerimetroLosango();
            f.ShowDialog();
        }

        private void btn_Pquadrado_Click(object sender, EventArgs e)
        {
            F_PerimetroQuadrado f = new F_PerimetroQuadrado();
            f.ShowDialog();
        }

        private void btn_Pretangulo_Click(object sender, EventArgs e)
        {
            F_PerimetroRetangulo f = new F_PerimetroRetangulo();
            f.ShowDialog();
        }

        private void btn_PTrapezio_Click(object sender, EventArgs e)
        {
            F_PerimetroTrapezio f = new F_PerimetroTrapezio();
            f.ShowDialog();
        }

        private void btn_PtrianguloEq_Click(object sender, EventArgs e)
        {
            F_PerimetroTrianguloEq f = new F_PerimetroTrianguloEq();
            f.ShowDialog();
        }

        private void btn_Pcirculo_Click(object sender, EventArgs e)
        {
            F_PerimetroCirculo f = new F_PerimetroCirculo();
            f.ShowDialog();
        }
    }
}
