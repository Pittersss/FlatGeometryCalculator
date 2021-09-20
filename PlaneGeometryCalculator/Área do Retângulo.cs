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
    public partial class F_AreaRetângulo : Form
    {
        public F_AreaRetângulo()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double heigth = Convert.ToDouble(txtB_altura);
            double Base = Convert.ToDouble(txtB_base);
            Calcula c = new Calcula();
            c.ARetangulo(Base, heigth);
            txtB_resultado.Text = Convert.ToString(Calcula.area);
        }
    }
}
