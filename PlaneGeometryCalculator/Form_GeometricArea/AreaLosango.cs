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

        private void AreaLosango_Load(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double Dmaior =  Convert.ToDouble(txtB_Dmaior.Text);
            double Dmenor =  Convert.ToDouble(txtB_Dmenor.Text);
            Calcula c = new Calcula();
            c.ALosango(Dmaior, Dmenor);
            txtB_Resultado.Text = Convert.ToString(Calcula.area);
        }

        private void txtB_Base_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_Altura_Click(object sender, EventArgs e)
        {

        }
    }
}
