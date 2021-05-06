using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_CS_Project.CS_Frist_Program.DistanceConverter
{
    public static class FeetConverter
    {
        //private const double ratio = 0.3048;
        public static readonly double Ratio = 0.3048;

        public static double FromMeter(double meter)
        {
            return meter / ratio;
        }

        public static double ToMeter(double feet)
        {
            return feet * ratio;
        }
    }
}
