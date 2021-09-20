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
    public partial class F_PerimetroTrapezio : Form
    {
        public F_PerimetroTrapezio()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double[] sides = new double[4];
            sides[0] = Convert.ToDouble(txtB_side1);
            sides[1] = Convert.ToDouble(txtB_side2);
            sides[2] = Convert.ToDouble(txtB_side3);
            sides[3] = Convert.ToDouble(txtB_side4);
            Calcula c = new Calcula();
            c.PTrapezio(sides[0], sides[1], sides[2], sides[3]);
            txtB_resultado.Text = Convert.ToString(Calcula.perimetro);
        }
    }
}
