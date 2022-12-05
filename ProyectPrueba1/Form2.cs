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
    public partial class FrmPICS : Form
    {
        

        public FrmPICS()
        {
            InitializeComponent();
        }

        private void BtnCalcular1_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                double lambda;
                double mu, t;
                double cte, cts, ctse, cs;

                lambda = double.Parse(txtLambda.Text); // Int32.Parse(txtLambd);
                mu = double.Parse(txtMu.Text);
                n = int.Parse(txtN.Text);
                t = double.Parse(txtHora.Text);

                cte = double.Parse(txtCTE.Text);
                cts = double.Parse(txtCTS.Text);
                ctse = double.Parse(txtCTSE.Text);
                cs = double.Parse(txtCS.Text);

                if(lambda > 0 && lambda < 100 && mu > 0 && mu < 100 && n >= 0 && n < 100)
                {
                    clsCalculoPICS objCal = new clsCalculoPICS(lambda, mu, n, t, cte, cts, ctse, cs);

                    lblRo.Text = objCal.cal_Ro().ToString();
                    lblPo.Text = objCal.cal_Po().ToString();
                    lblPn.Text = objCal.cal_Pn().ToString();
                    lblL.Text = objCal.cal_L().ToString();
                    lblLq.Text = objCal.cal_Lq().ToString();
                    lblLn.Text = objCal.cal_Ln().ToString();
                    lblW.Text = objCal.cal_W().ToString();
                    lblWq.Text = objCal.cal_Wq().ToString();
                    lblWn.Text = objCal.cal_Wn().ToString();

                    lblCTTE.Text = objCal.cal_CTTE().ToString();
                    lblCTTS.Text = objCal.cal_CTTS().ToString();
                    lblCTTSE.Text = objCal.cal_CTTSE().ToString();
                    lblCTS.Text = objCal.cal_CTS().ToString();
                    lblCT.Text = objCal.cal_CT().ToString();

                }
                else
                {
                    MessageBox.Show("Erro!!!, Ingrese solo números positivos menores a 100", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Erro!!!, Ingrese solo números positivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLambda.Clear();
                txtMu.Clear();

            }
            


           
        }
    }
}
