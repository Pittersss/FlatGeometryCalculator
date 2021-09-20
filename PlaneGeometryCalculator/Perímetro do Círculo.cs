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
    public partial class F_PerimetroCirculo : Form
    {
        public F_PerimetroCirculo()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtB_radius.Text);
            Calcula c = new Calcula();
            c.PCirculo(radius);
            txtB_resultado.Text = Convert.ToString(Calcula.perimetro);

        }
    }
}
