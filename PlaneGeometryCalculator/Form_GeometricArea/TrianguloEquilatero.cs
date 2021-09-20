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
    public partial class F_AreaTrianguloEquilatero : Form
    {
        public F_AreaTrianguloEquilatero()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double side = Convert.ToDouble(txtB_lado.Text);
            Calcula c = new Calcula();
            c.ATrianguloEquilatero(side);
            txtB_Resultado.Text = Convert.ToString(Calcula.area);
        }
    }
}
