using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_CS_Project.CS_Frist_Program.DistanceConverter
{
    public class FeetConverter
    {
        public static double FromMeter(double meter)
        {
            return meter / 0.3048;
        }

        public static double ToMeter(double feet)
        {
            return feet * 0.3048;
        }
    }
}
