using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgilentPO
{
    public class MEASPOINT
    {
        double frequency, reflectivity;
        public MEASPOINT(double freq, double reflect)
        {
            frequency = freq;
            reflectivity = reflect;
        }
        public double Frequency()
        {
            return frequency;
        }
        public double Reflectivity()
        {
            return reflectivity;
        }
    }
}
