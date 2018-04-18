using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taylor
{
    class fce
    {
        public double pres;

        public double sine(double x, int i, double last)
        {
            double result;
            double act;

            int power = i + (i - 1);

            act = Math.Pow(x, power);
            double fact = factorial_recursion(power);
            act = act / fact;

            if (Math.Abs(act) > pres)
            {
                if (i % 2 == 0)
                {
                    result = last - act;
                }
                else
                {
                    result = last + act;
                }
                return result;
            }
            else return 0;

        }

        public double cos(double x, int i, double last)
        {
            double result;
            double act;

            int power = i + (i - 2);

            act = Math.Pow(x, power);
            double fact = factorial_recursion(power);
            act = act / fact;

            if (Math.Abs(act) > pres)
            {
                if (i % 2 == 0)
                {
                    result = last - act;
                }
                else
                {
                    result = last + act;
                }
                return result;
            }
            else return 0;

        }

        public double euler(double x, int i, double last)
        {
            double result;
            double act;

            act = Math.Pow(i, x);
            act = act / factorial_recursion(i);

            if (Math.Abs(act) > pres)
            {

                result = last + act;

                return result;
            }
            else return 0;
        }


        public double factorial_recursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial_recursion(number - 1);
        }

        public double DegToRad(double deg)
        {
            double result;

            result = deg * (Math.PI / 180);

            return result;
        }
    }
}
