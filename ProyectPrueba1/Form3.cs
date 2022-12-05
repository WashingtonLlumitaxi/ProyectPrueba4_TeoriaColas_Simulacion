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
    public partial class FrmPICM : Form
    {
        int n, k;
        double lamnda;
        double mu, t;
        double cte, cts, ctse, cs;
        public FrmPICM()
        {
            InitializeComponent();
        }

        private void BtnCalcular1_Click(object sender, EventArgs e)
        {
            try
            {
                lamnda = double.Parse(txtLambda.Text); // Int32.Parse(txtLambd);
                mu = double.Parse(txtMu.Text);
                n = int.Parse(txtN.Text);
                k = int.Parse(txtK.Text);
                t = double.Parse(txtHora.Text);

                cte = double.Parse(txtCTE.Text);
                cts = double.Parse(txtCTS.Text);
                ctse = double.Parse(txtCTSE.Text);
                cs = double.Parse(txtCS.Text);

                if (lamnda > 0 && lamnda < 100 && mu > 0 && mu < 100 && k >= 0 && k < 1000 && n >= 0 && n < 100)
                {


                    clsCalculoPICM objM = new clsCalculoPICM(lamnda, mu, n, k, t, cte, cts, ctse, cs);


                    lblPo.Text = objM.calPo().ToString();
                    lblPk.Text = objM.calPk().ToString();
                    lblPne.Text = objM.calPne().ToString();
                    lblPn.Text = objM.calPn().ToString();
                    lblL.Text = objM.calL().ToString();
                    lblLq.Text = objM.calLq().ToString();
                    lblLn.Text = objM.calLn().ToString();
                    lblW.Text = objM.calW().ToString();
                    lblWq.Text = objM.calWq().ToString();
                    lblWn.Text = objM.calWn().ToString();

                    lblCTTE.Text = objM.calCTTE().ToString();
                    lblCTTS.Text = objM.calCTTS().ToString();
                    lblCTTSE.Text = objM.calCTTSE().ToString();
                    lblCTS.Text = objM.calCTS().ToString();
                    lblCT.Text = objM.calCT().ToString();

                }
                else
                {
                    MessageBox.Show("Solo se permiten números positivos menor a 100", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLambda.Clear();
                    txtMu.Clear();
                    txtK.Clear();
                    txtN.Clear();
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
                txtLambda.Clear();
                txtMu.Clear();
                txtK.Clear();
                txtN.Clear();
                txtCS.Clear();
                txtCTE.Clear();
                txtCTS.Clear();
                txtCTSE.Clear();
                txtHora.Clear();
            }


        }
    }
}
