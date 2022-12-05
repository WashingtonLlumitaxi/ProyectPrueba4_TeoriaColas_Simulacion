using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectPrueba1
{
    class clsCalculoPICM
    {


        int n = 0, k;
        double lambda;
        double mu;
        double tiempo;
        double cte, cts, ctse, cs;

        public clsCalculoPICM(double lab, double mu, int n, int k, double t, double cte, double cts, double ctse, double cs)
        {
            this.lambda = lab;
            this.mu = mu;
            this.n = n;
            this.k = k;
            this.tiempo = t;
            this.cte = cte;
            this.cts = cts;
            this.ctse = ctse;
            this.cs = cs;

        }

        public double cFactorial(int x)
        {
            double fac = 1;
            for (int i = x; i >= 1; i--)
            {
                fac *= i;
            }

            return fac;
        }



        public double calPo()
        {

            double sumatoria = 0;

            for (int ni = 0; ni <= (k - 1); ni++)
            {
                double factor = 1 / cFactorial(ni);
                double elevado = Math.Pow((lambda / mu), ni);

                double respuesta = factor * elevado;
                sumatoria = sumatoria + respuesta;
            }

            double segundaparte = 0;
            segundaparte = (1 / cFactorial((int)k)) * (Math.Pow((lambda / mu), (k)) * ((k * mu) / ((k * mu) - lambda)));
            double respuestaPo = (1 / (sumatoria + segundaparte));//Respuesta Po


            return Math.Round(respuestaPo, 4);
        }


        public double calPk()
        {

            double parteUno = (1 / cFactorial(k));

            double parteDos = Math.Pow((lambda / mu), k);

            double parteTres = (k * mu) / ((k * mu) - lambda);

            double respuestaPk = parteUno * parteDos * parteTres * calPo();//Respuesta Pk



            return Math.Round(respuestaPk, 4);

        }

        public double calPne()
        {
            double respuesta = (1 - calPk());

            return Math.Round(respuesta, 4);
        }

        public double calPn()
        {
            double respPn = 0;
            if (n <= k)
            {
                respPn = ((calPo() / cFactorial(n)) * (Math.Pow((lambda / mu), n)));

            }
            else
            {
                respPn = ((1 / (cFactorial(k) * (Math.Pow(k, (n - k))))) * (Math.Pow((lambda / mu), n)));

            }

            return Math.Round(respPn, 4);
        }


        public double calL()
        {
            double cal1 = ((lambda * mu) * Math.Pow((lambda / mu), k));
            double cal2 = (cFactorial(k - 1) * (Math.Pow(((k * mu) - lambda), 2)));
            double cal3 = (lambda / mu);

            double res = ((cal1 / cal2) * calPo() + cal3);

            return Math.Round(res, 4);
        }



        public double calLq()
        {
            double cal1 = ((lambda * mu) * (Math.Pow((lambda / mu), k)) * calPo());
            double cal2 = ((cFactorial(k - 1)) * (Math.Pow(((k * mu) - lambda), 2)));

            double resp = (cal1 / cal2);

            return Math.Round(resp, 4);
        }


        public double calLn()
        {
            double resp = (calLq() / calPk());

            return Math.Round(resp, 4);
        }



        public double calW()
        {
            double cal1 = (mu * (Math.Pow((lambda / mu), k)) * calPo());
            double cal2 = ((cFactorial(k - 1)) * (Math.Pow(((k * mu) - lambda), 2)));
            double cal3 = (1 / mu);
            double resp = ((cal1 / cal2) + cal3);

            return Math.Round(resp, 4);

        }


        public double calWq()
        {
            double cal1 = (mu * (Math.Pow((lambda / mu), k)) * calPo());
            double cal2 = ((cFactorial(k - 1)) * (Math.Pow(((k * mu) - lambda), 2)));
            double resp = (cal1 / cal2);

            return Math.Round(resp, 4);
        }


        public double calWn()
        {
            double resp = (calWq() / calPk());

            return Math.Round(resp, 4);
        }

        public double calCTTE()
        {
            return Math.Round((lambda * tiempo * calWq() * cte), 4);
        }

        public double calCTTS()
        {
            return ((Math.Round((lambda * tiempo * calW() * cts), 4)) * 100) / 100;
        }


        public double calCTTSE()
        {
            double der = 1 / mu;
            return Math.Round((lambda * tiempo * Math.Round(der, 2) * ctse), 4);

        }


        public double calCTS()
        {
            return Math.Round((cs * k), 4);
        }

        public double calCT()
        {
            return Math.Round((calCTTE() + calCTTSE() + calCTTS() + calCTS()), 4);


        }
    }






}
