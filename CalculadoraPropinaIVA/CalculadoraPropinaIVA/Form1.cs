using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPropinaIVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cuenta = int.Parse(totalCuenta.Text);
            int iva = int.Parse(totalVA.Text);
            int propina = int.Parse(totalPropina.Text);

            double totalConPropina = cuenta + ((cuenta * propina)/100);
            double totalConIVA = cuenta + ((cuenta * iva)/100);


            resultadoIVA.Text = totalConPropina.ToString();
            resultadoPropina.Text = totalConIVA.ToString(); 

        }
    }
}
