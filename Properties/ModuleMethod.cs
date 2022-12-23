using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace WindowsFormsProject.Properties
{
    internal static class ModuleMethod
    {
        public static double CalculateFunc(double x, string myfunc)
        {
            Function mx_function = new Function($"f(x) = {myfunc}");
            Expression mx_expression = new Expression($"f({x})", mx_function);
            return mx_expression.calculate();
        }

        public static void CheckDot(string str)
        {
            if (str.Contains(','))
            {
                MessageBox.Show("Используйте точку");
            }
        }
        public static double BisectionMethod(double epsilon, double A, double B, string function)
        {
            double answer = 0;
            if (CalculateFunc(A, function) * CalculateFunc(B, function) < 0)
            {
                while ((B - A) > epsilon)
                {
                    double D = (A + B) / 2.0;
                    double func_d = CalculateFunc(D, function);
                    double func_a = CalculateFunc(A, function);
                    if (func_d == 0)
                    {
                        answer = D;
                        break;
                    }
                    else if (func_d * func_a > 0)
                    {
                        A = D;
                    }
                    else
                    {
                        B = D;
                    }
                    answer = D;
                }
            }
            else
            {
                MessageBox.Show("На границах промежутка функция имеет одинаковые знаки");
            }
            return answer;
        }

    }
}
