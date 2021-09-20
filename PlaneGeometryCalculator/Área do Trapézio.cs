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
    public partial class F_AreaTrapezio : Form
    {
        public F_AreaTrapezio()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double bMaior = Convert.ToDouble(txtB_bMaior.Text);
            double bMenor = Convert.ToDouble(txtB_bMenor.Text);
            double height = Convert.ToDouble(txtB_heigth.Text);
            Calcula c = new Calcula();
            c.ATrapezio(bMaior, bMenor, height);
            txtB_resultado.Text = Convert.ToString(Calcula.area);
        }

        private void lb_radius_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
