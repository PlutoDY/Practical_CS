﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_CS_Project.CS_Frist_Program.DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-tom")
            {
                PrintFeetToMeterList(1, 10);
            }
            else
            {
                PrintMeterToFeetList(1, 10);
            }
        }

        static void PrintFeetToMeterList(int start, int stop)
        {
            FeetConverter converter = new FeetConverter();
            for(int feet = start; feet <= stop; feet++)
            {
                double meter = converter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }

        static void PrintMeterToFeetList(int start,int stop)
        {
            FeetConverter converter = new FeetConverter();
            for(int meter = start; meter <= stop; meter++)
            {
                double feet = converter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }
    }

}
