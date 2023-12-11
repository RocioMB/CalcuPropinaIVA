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
            double resultado;
            resultado = ( total + ((total / porcentaje)));
            return resultado;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cuentaRMB2324 = int.Parse(totalCuenta.Text);
            int ivaRMB2324 = int.Parse(totalVA.Text);
            int propina = int.Parse(totalPropina.Text);

            double totalConPropina = calculaPorcentaje(cuentaRMB2324, ivaRMB2324);
            double totalConIVA = calculaPorcentaje(cuentaRMB2324, propina);

            resultadoIVA.Text = totalConIVA.ToString();
            resultadoPropina.Text = totalConPropina.ToString(); 

        }

    }
}
