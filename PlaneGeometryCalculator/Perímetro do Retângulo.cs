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
    public partial class F_PerimetroRetangulo : Form
    {
        public F_PerimetroRetangulo()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double Base = Convert.ToDouble(txtB_base.Text);
            double height = Convert.ToDouble(txtB_altura.Text);
            Calcula C = new Calcula();
            C.PRetangulo(Base, height);
            txtB_resultado.Text = Convert.ToString(Calcula.perimetro);
        }
    }
}
