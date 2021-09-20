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
    public partial class F_AreaLosango : Form
    {
        public F_AreaLosango()
        {
            InitializeComponent();
        }

        private void F_AreaLosango_Load(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double dMaior = Convert.ToDouble(txtB_Dmaior);
            double dMenor = Convert.ToDouble(txtB_Dmenor);
            Calcula c = new Calcula();
            c.ALosango(dMaior, dMenor);
            txtB_resultado.Text = Convert.ToString(Calcula.area);
        }
    }
}
