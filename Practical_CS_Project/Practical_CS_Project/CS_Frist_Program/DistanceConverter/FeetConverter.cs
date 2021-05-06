using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_CS_Project.CS_Frist_Program.DistanceConverter
{
    public class FeetConverter
    {
        public double FromMeter(double meter)
        {
            return meter / 0.3048;
        }

        public double ToMeter(double feet)
        {
            return feet * 0.3048;
        }
    }
}
