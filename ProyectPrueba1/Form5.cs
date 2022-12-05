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
    public partial class FrmPFCM : Form
    {
        public FrmPFCM()
        {
            InitializeComponent();
        }

        private void BtnCalcular1_Click(object sender, EventArgs e)
        {

            try
            {
                double lambda = double.Parse(txtLambda.Text);
                double mu = double.Parse(txtMu.Text);
                double k = double.Parse(txtK.Text);
                double M = double.Parse(txtM.Text);
                double n = double.Parse(txtN.Text);


                if (lambda > 0 && lambda < 100 && mu > 0 && mu < 100 && k > 0 && k < 100 && M >= 0 && M < 1000 && n >= 0 && n < 100)
                {
                    clsCalculoPFCM oPFCM = new clsCalculoPFCM(lambda, mu, k, M, n);
                    lblPo.Text = oPFCM.CalcularPo().ToString();
                    lblPn.Text = oPFCM.CalcularPn().ToString();
                    lblPE.Text = oPFCM.CalcularPe().ToString();
                    lblPNE.Text = oPFCM.CalcularPne().ToString();
                    lblL.Text = oPFCM.CalcularL().ToString();
                    lblLq.Text = oPFCM.CalcularLq().ToString();
                    lblLn.Text = oPFCM.CalcularLn().ToString();
                    lblWq.Text = oPFCM.CalcularWq().ToString();
                    lblW.Text = oPFCM.CalcularW().ToString();
                    lblWn.Text = oPFCM.CalcularWn().ToString();

                }
                else
                {
                    MessageBox.Show("Solo se permiten números positivos menor a 100", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLambda.Clear();
                    txtMu.Clear();
                    txtM.Clear();
                    txtK.Clear();
                    txtN.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Solo ingresar números positivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLambda.Clear();
                txtMu.Clear();
                txtM.Clear();
                txtK.Clear();
                txtN.Clear();
            }
        }

        private void btnCalCost_Click(object sender, EventArgs e)
        {

            try
            {
                double lambda = double.Parse(txtLambda.Text);
                double mu = double.Parse(txtMu.Text);
                double k = double.Parse(txtK.Text);
                double M = double.Parse(txtM.Text);
                double n = double.Parse(txtN.Text);
                double horas = double.Parse(txtHora.Text);
                double cte = double.Parse(txtCTE.Text);
                double cts = double.Parse(txtCTS.Text);
                double ctse = double.Parse(txtCTSE.Text);
                double cs = double.Parse(txtCS.Text);

                if (horas > 0 && horas < 24 && cte >= 0 && cte < 1000 && cts >= 0 && cts < 1000 && ctse >= 0 && ctse < 1000 && cs >= 0 && cs < 1000)
                {
                    clsCalculoPFCM oPFCMc = new clsCalculoPFCM(lambda, mu, k, M, n, horas, cte, cts, ctse, cs);
                    lblCTTE.Text = oPFCMc.CalcularCTTE().ToString();
                    lblCTTS.Text = oPFCMc.CalcularCTTS().ToString();
                    lblCTTSE.Text = oPFCMc.CalcularCTTSE().ToString();
                    lblCTS.Text = oPFCMc.CalcularCTS().ToString();
                    lblCT.Text = oPFCMc.CalcularCT().ToString();

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
                MessageBox.Show("Solo ingresar números positivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCS.Clear();
                txtCTE.Clear();
                txtCTS.Clear();
                txtCTSE.Clear();
                txtHora.Clear();
            }
        }
    }
}
