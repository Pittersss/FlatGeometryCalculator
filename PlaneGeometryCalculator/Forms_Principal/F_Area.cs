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
    public partial class F_Area : Form
    {
        public F_Area()
        {
            InitializeComponent();
        }

        private void F_Area_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            F_AreaCirculo f = new F_AreaCirculo();
            f.ShowDialog();
        }

        public void btn_Atriangulo_Click(object sender, EventArgs e)
        {
            F_AreaTriangulo _AreaTriangulo = new F_AreaTriangulo();
            _AreaTriangulo.ShowDialog();
        }

        private void btn_Aquadrado_Click(object sender, EventArgs e)
        {
            F_AreaQuadrado f_AreaQuadrado = new F_AreaQuadrado();
            f_AreaQuadrado.ShowDialog();
        }

        private void btn_Aretangulo_Click(object sender, EventArgs e)
        {
            F_AreaRetângulo f = new F_AreaRetângulo();
            f.ShowDialog();

        }

        private void btn_Alosango_Click(object sender, EventArgs e)
        {
            F_AreaLosango f = new F_AreaLosango();
            f.ShowDialog();
        }

        private void btn_AtrianguloEq_Click(object sender, EventArgs e)
        {
            F_AreaTrianguloEquilatero f_ = new F_AreaTrianguloEquilatero();
            f_.ShowDialog();
        }

        private void btn_ATrapezio_Click(object sender, EventArgs e)
        {
            F_AreaTrapezio f = new F_AreaTrapezio();
            f.ShowDialog();
        }
    }
}
