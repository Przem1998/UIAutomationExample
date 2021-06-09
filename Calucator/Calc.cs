using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calucator
{
    class Calc
    {
        public Calc(double a_param, double b_param)
        {
            A_param = a_param;
            B_param = b_param;
        }

        public double A_param { get; set; }

        public double B_param { get; set; }

        public double AddNumber() => A_param + B_param;

        public double SuspensionNumber() => A_param - B_param;

        public double DevideNumber() => A_param / B_param;

        public double MultpileNumber() => A_param * B_param;

    }
}
