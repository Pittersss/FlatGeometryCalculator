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
    public partial class F_AreaQuadrado : Form
    {
        public F_AreaQuadrado()
        {
            InitializeComponent();
        }

        private void lb_radius_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double side = Convert.ToDouble(txtB_side.Text);
            Calcula c = new Calcula();
            c.AQuadrado(side);
            txtB_resultado.Text = Convert.ToString(Calcula.area);
        }
    }
}
