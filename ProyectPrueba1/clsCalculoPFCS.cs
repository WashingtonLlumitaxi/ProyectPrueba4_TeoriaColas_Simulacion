using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectPrueba1
{
    class clsCalculoPFCS
    {
        private double lambda, mu, M, n, Cte = 0, Cts = 0, Ctse = 0, Cs = 0;
        private int h;

        public clsCalculoPFCS(double lambda, double mu, double M, double n)
        {
            this.lambda = lambda;
            this.mu = mu;
            this.M = M;
            this.n = n;
        }

        public clsCalculoPFCS(double lambda, double mu, double M, double n, double Cte, double Cts, double Ctse, double Cs, int h)
        {
            this.lambda = lambda;
            this.mu = mu;
            this.M = M;
            this.n = n;
            this.Cte = Cte;
            this.Cts = Cts;
            this.Ctse = Ctse;
            this.Cs = Cs;
            this.h = h;
        }

        public double factorial(int a)
        {
            double b = 1;
            for (int num = a; num >= 1; num--)
            {
                b *= num;
            }
            return b;
        }

        public double calcularPo()
        {
            double sumatoria = 0;
            for (int nf = 0; nf <= M; nf++)
            {
                double resp = (factorial((int)M) / factorial((int)(M - nf))) * Math.Pow(lambda / mu, nf);
                sumatoria += resp;
            }
            double resP0 = 1 / sumatoria;
            return Math.Round(resP0, 4);
        }

        public double calcularPE()
        {
            double resPE = 1 - calcularPo();
            return Math.Round(resPE, 4);
        }

        public double calcularPn()
        {
            double resPn = (factorial((int)M) / factorial((int)(M - n))) * Math.Pow(Convert.ToDouble(lambda / mu), (int)n) * calcularPo();
            return Math.Round(resPn, 4);
        }
        

        public double calcularL()
        {
            double resL = M - (mu / lambda) * (1 - calcularPo());
            return Math.Round(resL, 4);
        }

        public double calcularLq()
        {
            double resLq = M - ((lambda + mu) / lambda) * (1 - calcularPo());
            return Math.Round(resLq, 4);
        }

        public double calcularLn()
        {
            double resLn = calcularLq() / calcularPE();
            return Math.Round(resLn, 4);
        }
       

        public double calcularW()
        {
            double respW = calcularWq() + (1 / mu);
            return Math.Round(respW, 4);
        }

        public double calcularWq()
        {
            double respWq = calcularLq() / ((M - calcularL()) * lambda);
            return Math.Round(respWq, 4);
        }

        public double calcularWn()
        {
            double respWn = calcularWq() / calcularPE();
            return Math.Round(respWn, 4);
        }
  

        public double calcularCTte()
        {
            double respCTte = lambda * h * calcularWq() * Cte;
            return Math.Round(respCTte, 4);
        }

        public double calcularCTts()
        {
            Console.WriteLine($"{lambda} + {mu} + {h} + {Cte}");
            double respCTts = lambda * h * calcularW() * Cts;
            return Math.Round(respCTts, 4);
        }

        public double calcularCTtse()
        {
            double respCTtse = lambda * h * (1 / mu) * Ctse;
            return Math.Round(respCTtse, 4);
        }

        public double calcularCTs()
        {
            double respCTs = 1 * Cs;
            return Math.Round(respCTs, 4);
        }

        public double calcularCT()
        {
            double respCT = calcularCTte() + calcularCTts() + calcularCTtse() + calcularCTs();
            return Math.Round(respCT, 4);
        }
    
    }
}
