using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectPrueba1
{
    class clsCalculoPICS
    {
        int n;
        double lambda;
        double mu;
        double tiempo;
        double cte, cts, ctse, cs;

        public clsCalculoPICS(double lab, double mu, int n, double t, double ctte, double ctts, double cttse, double cts)
        {
            this.lambda = lab;
            this.mu = mu;
            this.n = n;
            this.tiempo = t;
            this.cte = ctte;
            this.cts = ctts;
            this.ctse = cttse;
            this.cs = cts;

        }

       

        public double cal_Ro()
        {
            double res = 0;
            res = (lambda / mu);
            return Math.Round(res, 4); 
        }

        public double cal_Po()
        {
            double res = 0;
            res = 1 - cal_Ro();
            return Math.Round(res, 4);

        }

        public double cal_Pn()
        {
            double res;
            double ro_1 = cal_Ro();
            res = cal_Po() * Math.Pow(ro_1, n);
            return Math.Round(res, 4);

        }

        public double cal_L()
        {
            double res;
            double denomindor = (mu - lambda);
            res = (lambda / denomindor);
            return Math.Round(res, 4);
        }

        public double cal_Lq()
        {
            double res = 0;
            double numerador = Math.Pow(lambda, 2);
            double diferencia = mu - lambda;
            double denominador = mu * diferencia;
            res = numerador / denominador;

            return Math.Round(res, 4);
        }


        public double cal_Ln()
        {
            double diferencia = (mu - lambda);
       
            return Math.Round((lambda / diferencia), 4);
        }


        public double cal_W()
        {
            double diferencia = (mu - lambda);
            return Math.Round((1 / diferencia), 4);
        }


        public double cal_Wq()
        {
            double diferencia = (mu - lambda);
            double denominador = (mu * diferencia);
            return Math.Round((lambda / denominador), 4);
        }

        public double cal_Wn()
        {
            double diferencia = (mu - lambda);
            return Math.Round((1 / diferencia), 4);
        }

        public double cal_CTTE()
        {
            return Math.Round((lambda * tiempo * cal_Wq() * cte), 4);
        }

        public double cal_CTTS()
        {
            return (Math.Round((lambda * tiempo * cal_W() * cts), 4));
        }


        public double cal_CTTSE()
        {
            double der = 1 / mu;
            return Math.Round((lambda * tiempo * Math.Round(der, 2) * ctse), 4);
        }


        public double cal_CTS()
        {
            return Math.Round(cs, 4);
        }

        public double cal_CT()
        {
            return Math.Round((cal_CTTE() + cal_CTTSE() + cal_CTTS() + cal_CTS()), 4);
        }
    }



    
}
