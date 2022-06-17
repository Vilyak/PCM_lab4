using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class MHK
    {
        public int n = 6;

        // Входные данные
        public double[] x;
        public double[] y;

        // Неизвестные в уравнениях ф-й
        public double a;
        public double b;
        public double c;

        // Норма отклонения
        public double r;

        // Промежуточные вычисляемые данные
        public double[] x2;
        public double[] x3;
        public double[] x4;

        public double[] xy;
        public double[] x2y;

        public double[] lnx;
        public double[] lnx2;
        public double[] ylnx;

        public MHK(double[] x, double[] y)
        {
            this.x = x;
            this.y = y;

            x2 = new double[n];
            x3 = new double[n];
            x4 = new double[n];

            xy = new double[n];
            x2y = new double[n];

            lnx = new double[n];
            lnx2 = new double[n];
            ylnx = new double[n];

            Initialize();
        }

        private void Initialize()
        {
            for (int i = 0; i < n; i++)
            {
                x2[i] = Math.Pow(x[i], 2);
                x3[i] = Math.Pow(x[i], 3);
                x4[i] = Math.Pow(x[i], 4);
                
                xy[i] = y[i] * x[i];
                x2y[i] = x2[i] * y[i];

                if (x[i] == 0)
                {
                    lnx[i] = 0;
                    lnx2[i] = 0;
                }          
                else
                {
                    lnx[i] = Math.Log(x[i]);
                    lnx2[i] = Math.Pow(Math.Log(x[i]), 2);
                }
                                   
                ylnx[i] = y[i] * lnx[i];
            }
        }
        
        public double Sum(double[] mas)
        {
            double sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];    
            }

            return sum;
        }

        // y = ax+b
        public double LinearFunc(double x)
        {
            return a * x + b;
        }

        // y = ax^2+bx+c
        public double QuadraticFunc(double x)
        {
            return a * Math.Pow(x, 2) + b * x + c;
        }

        // y = a lnx + b
        public double LogarifmFunc(double x)
        {
            return a * Math.Log(x) + b;
        }

        public double R (Func<double, double> func)
        {
            double res = 0;
            for (int i = 0; i < n; i++)
            {
                res += Math.Pow((func(x[i]) - y[i]), 2);     
            }

            return res;
        }
    
        public void LinearApproximation()
        {
            double sumXY = Sum(xy);
            double sumX = Sum(x);
            double sumY = Sum(y);
            double sumX2 = Sum(x2);

            // Составим СЛАУ для нахождения неизвестных a,b и решим ее методом Крамера.
            Matrix matrix = new Matrix(2, 2);
            matrix[0, 0] = sumX2;
            matrix[0, 1] = sumX;
            matrix[1, 0] = sumX;
            matrix[1, 1] = n;

            double det = matrix.CalculateDeterminant();

            matrix[0, 0] = sumXY;
            matrix[1, 0] = sumY;

            double det1 = matrix.CalculateDeterminant();

            matrix[0, 0] = sumX2;
            matrix[1, 0] = sumX;
            matrix[0, 1] = sumXY;
            matrix[1, 1] = sumY;

            double det2 = matrix.CalculateDeterminant();

            a = det1 / det;
            b = det2 / det;
            r = R(LinearFunc);
        }
  
        public void QuadraticApproximation()
        {
            double sumX = Sum(x);
            double sumY = Sum(y);
            
            double sumXY = Sum(xy);
            double sumX2Y = Sum(x2y);

            double sumX2 = Sum(x2);
            double sumX3 = Sum(x3);
            double sumX4 = Sum(x4);

            // Составим СЛАУ для нахождения неизвестных a,b,c и решим ее методом Крамера.
            Matrix matrix = new Matrix(3, 3);
            matrix[0, 0] = sumX4;
            matrix[0, 1] = sumX3;
            matrix[0, 2] = sumX2;
            matrix[1, 0] = sumX3;
            matrix[1, 1] = sumX2;
            matrix[1, 2] = sumX;
            matrix[2, 0] = sumX2;
            matrix[2, 1] = sumX;
            matrix[2, 2] = n;

            double det = matrix.CalculateDeterminant();

            matrix[0, 0] = sumX2Y;
            matrix[1, 0] = sumXY;
            matrix[2, 0] = sumY;

            double det1 = matrix.CalculateDeterminant();

            matrix[0, 0] = sumX4;
            matrix[1, 0] = sumX3;
            matrix[2, 0] = sumX2;
            matrix[0, 1] = sumX2Y;
            matrix[1, 1] = sumXY;
            matrix[2, 1] = sumY;

            double det2 = matrix.CalculateDeterminant();

            matrix[0, 1] = sumX3;
            matrix[1, 1] = sumX2;
            matrix[2, 1] = sumX;
            matrix[0, 2] = sumX2Y;
            matrix[1, 2] = sumXY;
            matrix[2, 2] = sumY;

            double det3 = matrix.CalculateDeterminant();

            a = det1 / det;
            b = det2 / det;
            c = det3 / det;
            r = R(QuadraticFunc);
        }
           
        public void LogarifmApproximation()
        {
            double sumY = Sum(y);
            double sumlnx = Sum(lnx);
            double sumlnx2 = Sum(lnx2);
            double sumylnx = Sum(ylnx);

            // Составим СЛАУ для нахождения неизвестных a,b и решим ее методом Крамера.
            Matrix matrix = new Matrix(2, 2);
            matrix[0, 0] = sumlnx2;
            matrix[0, 1] = sumlnx;
            matrix[1, 0] = sumlnx;
            matrix[1, 1] = n;

            double det = matrix.CalculateDeterminant();

            matrix[0, 0] = sumylnx;
            matrix[1, 0] = sumY;

            double det1 = matrix.CalculateDeterminant();

            matrix[0, 0] = sumlnx2;
            matrix[1, 0] = sumlnx;
            matrix[0, 1] = sumylnx;
            matrix[1, 1] = sumY;

            double det2 = matrix.CalculateDeterminant();

            a = det1 / det;
            b = det2 / det;
            r = R(LogarifmFunc);
        }
    }
}
