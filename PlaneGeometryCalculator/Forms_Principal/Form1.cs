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
    public partial class F_main : Form
    {
        public F_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lb_title_Click(object sender, EventArgs e)
        {

        }

        private void btn_showArea_Click(object sender, EventArgs e)
        {
            F_Area f_Area = new F_Area();
            f_Area.ShowDialog();
        }

        private void btn_showPerimetro_Click(object sender, EventArgs e)
        {
            F_Perimetro f_Perimetro = new F_Perimetro();
            f_Perimetro.ShowDialog();
           
        }
    }
}
