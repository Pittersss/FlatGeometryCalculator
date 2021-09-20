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
    public partial class F_PerimetroTrianguloEq : Form
    {
        public F_PerimetroTrianguloEq()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double side = Convert.ToDouble(txtB_side1.Text);
            Calcula c = new Calcula();
            c.PTrianguloEquilatero(side);
            txtB_resultado.Text = Convert.ToString(Calcula.perimetro);
        }
    }
}
