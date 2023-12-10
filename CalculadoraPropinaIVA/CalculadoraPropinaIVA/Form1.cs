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

        private double calculaPorcentaje(int total, int porcentaje)
        {
            double resultado = 0;
            resultado = ( total + ((total * porcentaje)/100));
            return resultado;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cuenta = int.Parse(totalCuenta.Text);
            int iva = int.Parse(totalVA.Text);
            int propina = int.Parse(totalPropina.Text);

            double totalConPropina = calculaPorcentaje(cuenta, propina);
            double totalConIVA = calculaPorcentaje(cuenta, iva);

            resultadoIVA.Text = totalConIVA.ToString();
            resultadoPropina.Text = totalConPropina.ToString(); 

        }

    }
}
