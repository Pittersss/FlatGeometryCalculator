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
    public partial class F_AreaTriangulo : Form
    {
        public F_AreaTriangulo()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double Base = Convert.ToDouble(txtB_base.Text);
            double height = Convert.ToDouble(txtB_heigth.Text);
            Calcula c = new Calcula();
            c.ATriangulo(Base, height);
            txtB_resultado.Text = Convert.ToString(Calcula.area);
        }
    }
}
