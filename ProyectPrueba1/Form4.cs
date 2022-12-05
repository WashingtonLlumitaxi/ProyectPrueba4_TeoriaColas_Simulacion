using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectPrueba1
{
    public partial class FrmPFCS : Form
    {
        public FrmPFCS()
        {
            InitializeComponent();
        }

        private void BtnCalcular1_Click(object sender, EventArgs e)
        {
            try
            {
                double lambda = double.Parse(txtLambda.Text);
                double miu = double.Parse(txtMu.Text);
                double M = double.Parse(txtM.Text);
                double n = double.Parse(txtN.Text);

                if (lambda > 0 && lambda < 100 && miu > 0 && miu < 100 && M >= 0 && M < 1000 && n >= 0 && n < 100)
                {
                    clsCalculoPFCS oPFCS = new clsCalculoPFCS(lambda, miu, M, n);
                    lblPo.Text = oPFCS.calcularPo().ToString();
                    lblPn.Text = oPFCS.calcularPn().ToString();
                    lblPE.Text = oPFCS.calcularPE().ToString();
                    lblL.Text = oPFCS.calcularL().ToString();
                    lblLq.Text = oPFCS.calcularLq().ToString();
                    lblLn.Text = oPFCS.calcularLn().ToString();
                    lblW.Text = oPFCS.calcularW().ToString();
                    lblWn.Text = oPFCS.calcularWn().ToString();
                    lblWq.Text = oPFCS.calcularWq().ToString();
                }
                else
                {
                    MessageBox.Show("Solo se permiten números positivos menor a 100", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLambda.Clear();
                    txtMu.Clear();
                    txtM.Clear();
                    txtN.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Verfique el tipo de estrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLambda.Clear();
                txtMu.Clear();
                txtM.Clear();
                txtN.Clear();
            }
        }

        private void btnCalCost_Click(object sender, EventArgs e)
        {
            try
            {
                double lambda = double.Parse(txtLambda.Text);
                double miu = double.Parse(txtMu.Text);
                double M = double.Parse(txtM.Text);
                double n = double.Parse(txtN.Text);
                double cte = double.Parse(txtCTE.Text);
                double cts = double.Parse(txtCTS.Text);
                double ctse = double.Parse(txtCTSE.Text);
                double cs = double.Parse(txtCS.Text);
                int h = int.Parse(txtHora.Text);

                if (cte >= 0 && cte < 100 && cts >= 0 && cts < 100 && ctse >= 0 && ctse < 1000 && cs >= 0 && cs < 100 && h >= 0 && h <= 24)
                {
                    clsCalculoPFCS oPFCS = new clsCalculoPFCS(lambda, miu, M, n, cte, cts, ctse, cs, h);
                    lblCTTE.Text = oPFCS.calcularCTte().ToString();
                    lblCTTS.Text = oPFCS.calcularCTts().ToString();
                    lblCTTSE.Text = oPFCS.calcularCTtse().ToString();
                    lblCTS.Text = oPFCS.calcularCTs().ToString();
                    lblCT.Text = oPFCS.calcularCT().ToString();
                }
                else
                {
                    MessageBox.Show("Solo se permiten números positivos menor a 100", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCS.Clear();
                    txtCTE.Clear();
                    txtCTS.Clear();
                    txtCTSE.Clear();
                    txtHora.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Verifique el tipo de entrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCS.Clear();
                txtCTE.Clear();
                txtCTS.Clear();
                txtCTSE.Clear();
                txtHora.Clear();
            }
        }
    }
}
