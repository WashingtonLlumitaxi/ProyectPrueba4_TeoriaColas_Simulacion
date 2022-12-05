using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectPrueba1
{
    class clsCalculoPFCM
    {
        private double lambda;
        private double mu;
        private double k;
        private double M;
        private double n;
        private double horas;
        private double cte;
        private double cts;
        private double ctse;
        private double cs;



        public clsCalculoPFCM(double lambda, double mu, double k, double M, double n)
        {
            this.lambda = lambda;
            this.mu = mu;
            this.k = k;
            this.M = M;
            this.n = n;
        }
        public clsCalculoPFCM(double lambda, double mu, double k, double M, double n, double horas, double cte, double cts, double ctse, double cs)
        {
            this.lambda = lambda;
            this.mu = mu;
            this.k = k;
            this.M = M;
            this.n = n;
            this.horas = horas;
            this.cte = cte;
            this.cts = cts;
            this.ctse = ctse;
            this.cs = cs;
        }


        public double CalcularPo()
        {
            double sumatoria = 0, sumatoria1 = 0;

            double f = n;
            for (f = 0; f <= (k - 1); f++)
            {
                double respuesta1 = (Factorial((int)M) / (Factorial((int)(M - f)) * Factorial((int)f))) * (Math.Pow((lambda / mu), f));
                sumatoria = sumatoria + respuesta1;


            }
            for (f = k; f <= M; f++)
            {
                double respuesta2 = (Factorial((int)M) / (Factorial((int)(M - f)) * Factorial((int)k) * Math.Pow(k, (f - k)))) * (Math.Pow((lambda / mu), f));
                sumatoria1 = sumatoria1 + respuesta2;
            }


            double respuestaPo = 1 / (sumatoria + sumatoria1);
            respuestaPo = Math.Round(respuestaPo * 10000);
            respuestaPo = respuestaPo / 10000;

            return respuestaPo;
        }

        public double Factorial(int a)
        {
            double b = 1;

            for (int num = a; num >= 1; num--)
            {
                b *= num;
            }
            return b;
        }

        public double CalcularPn()
        {
            double respuestaPn = 0;
            double Po = CalcularPo();
            double numerador = Factorial((int)M);
            double denominador = (Factorial((int)(M - n)) * Factorial((int)n));
            double lambdamu = Math.Pow((lambda / mu), n);
            double denominador1 = (Factorial((int)(M - n)) * Factorial((int)k) * Math.Pow(k, (n - k)));
            if (n >= 0 && n <= k)
            {
                respuestaPn = Po * (numerador / denominador) * lambdamu;

            }
            else if (n >= k && n <= M)
            {
                respuestaPn = Po * (numerador / denominador1) * lambdamu;
            }
            respuestaPn = Math.Round(respuestaPn, 4);
            return respuestaPn;
        }


        public double CalcularPe()
        {
            double sumatoria = 0;
            double j = n;

            for (j = k; j <= M; j++)
            {
                double respuesta = CalcularPo() * (Factorial((int)M) / (Factorial((int)(M - j)) * Factorial((int)k) * (Math.Pow(k, (j - k))))) * Math.Pow((lambda / mu), j);
                sumatoria = sumatoria + respuesta;
            }
            double respuestaPe = sumatoria;
            respuestaPe = Math.Round(respuestaPe * 10000);
            respuestaPe = respuestaPe / 10000;
            return respuestaPe;
        }
        public double CalcularPne()
        {
            double respuestaPne;
            respuestaPne = 1 - CalcularPe();
            return respuestaPne;
        }
        public double CalcularL()
        {
            double sumatoria = 0, sumatoria1 = 0, sumatoria2 = 0;
            double a = n;
            for (a = 0; a <= k - 1; a++)
            {

                double PnL1 = CalcularPo() * (Factorial((int)M) / (Factorial((int)(M - a)) * Factorial((int)n))) * Math.Pow((lambda / mu), a);
                double respuesta1 = a * PnL1;
                sumatoria = sumatoria + respuesta1;
            }

            for (a = k; a <= M; a++)
            {
                double PnL2 = CalcularPo() * (Factorial((int)M) / (Factorial((int)(M - a)) * Factorial((int)k) * (Math.Pow(k, (a - k))))) * Math.Pow((lambda / mu), a);
                double respuesta2 = (a - k) * PnL2;
                sumatoria1 = sumatoria1 + respuesta2;
            }

            for (a = 0; a <= k - 1; a++)
            {
                double PnL3 = CalcularPo() * ((Factorial((int)M) / ((Factorial((int)(M - a)) * Factorial((int)a))) * Math.Pow((lambda / mu), a)));
                sumatoria2 = sumatoria2 + PnL3;
            }

            double respuestaL = sumatoria + sumatoria1 + (k * (1 - sumatoria2));
            respuestaL = Math.Round(respuestaL * 10000);
            respuestaL = respuestaL / 10000;
            return respuestaL;
        }
        public double CalcularLq()
        {
            double sumatoria = 0;
            double b = n;
            for (b = k; b <= M; b++)
            {
                double PnL2 = CalcularPo() * (Factorial((int)M) / (Factorial((int)(M - b)) * Factorial((int)k) * (Math.Pow(k, (b - k))))) * Math.Pow((lambda / mu), b);
                double respuesta = (b - k) * PnL2;
                sumatoria = sumatoria + respuesta;
            }
            double respuestaLq = sumatoria;
            respuestaLq = Math.Round(respuestaLq * 10000);
            respuestaLq = respuestaLq / 10000;
            return respuestaLq;
        }
        public double CalcularLn()
        {
            double respuestaLn = CalcularLq() / CalcularPe();
            respuestaLn = Math.Round(respuestaLn * 10000);
            respuestaLn = respuestaLn / 10000;
            return respuestaLn;
        }
        public double CalcularWq()
        {

            double Lq = CalcularLq();
            double L = CalcularL();
            double lam = ((float)lambda);
            double respuestaWq = Lq / ((M - L) * lam);
            respuestaWq = Math.Round(respuestaWq * 10000);
            respuestaWq = respuestaWq / 10000;
            return respuestaWq;
        }
        public double CalcularW()
        {
            double respuestaW = CalcularWq() + (1 / mu);
            respuestaW = Math.Round(respuestaW * 10000);
            respuestaW = respuestaW / 10000;
            return respuestaW;
        }
        public double CalcularWn()
        {
            double respuestaWn = CalcularWq() / CalcularPe();
            respuestaWn = Math.Round(respuestaWn * 10000);
            respuestaWn = respuestaWn / 10000;
            return respuestaWn;
        }
        public double CalcularCTTE()
        {

            double respuestaCtte = (lambda * horas * CalcularWq() * cte);
            respuestaCtte = Math.Round(respuestaCtte * 10000);
            respuestaCtte = respuestaCtte / 10000;
            return respuestaCtte;
        }
        public double CalcularCTTS()
        {
            double respuestaCtts = (lambda * horas * CalcularW() * cts);
            respuestaCtts = Math.Round(respuestaCtts * 10000);
            respuestaCtts = respuestaCtts / 10000;
            return respuestaCtts;
        }
        public double CalcularCTTSE()
        {
            double respuestaCttse = (lambda * horas * (1 / mu) * ctse);
            respuestaCttse = Math.Round(respuestaCttse * 10000);
            respuestaCttse = respuestaCttse / 10000;
            return respuestaCttse;
        }
        public double CalcularCTS()
        {
            double respuestaCts = k * cs;
            return respuestaCts;
        }
        public double CalcularCT()
        {
            double respuestaCt = CalcularCTTE() + CalcularCTTS() + CalcularCTTSE() + CalcularCTS();
            respuestaCt = Math.Round(respuestaCt * 10000);
            respuestaCt = respuestaCt / 10000;
            return respuestaCt;
        }
    }
}
