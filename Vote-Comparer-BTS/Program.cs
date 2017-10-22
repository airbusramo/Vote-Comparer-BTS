﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vote_Comparer_BTS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("BTS's old amount of votes:");
            string BTS_Old_Input = Console.ReadLine();

            Console.Write("BTS's new amount of votes:");
            string BTS_New_Input = Console.ReadLine();

            Console.Write("Competitor's old amount of votes:");
            string Competitor_Old_Input = Console.ReadLine();

            Console.Write("Competitor's new amount of votes:");
            string Competitor_New_Input = Console.ReadLine();

            Console.Write("Time difference (in minutes):");
            string Time_Difference_Input = Console.ReadLine();

            Console.WriteLine(Environment.NewLine);

            int BTS_Old_Int;
            int BTS_New_Int;
            int Competitor_Old_Int;
            int Competitor_New_Int;
            decimal Time_Difference_Decimal;

            //Converting from string input to int.
            Int32.TryParse(BTS_Old_Input, out BTS_Old_Int);
            Int32.TryParse(BTS_New_Input, out BTS_New_Int);
            Int32.TryParse(Competitor_Old_Input, out Competitor_Old_Int);
            Int32.TryParse(Competitor_New_Input, out Competitor_New_Int);
            decimal.TryParse(Time_Difference_Input, out Time_Difference_Decimal);

            decimal BTS_Change = BTS_New_Int - BTS_Old_Int;
            decimal Competitor_Change = Competitor_New_Int - Competitor_Old_Int;
            decimal BTS_VPM = BTS_Change / Time_Difference_Decimal;
            decimal Competitor_VPM = Competitor_Change / Time_Difference_Decimal;

            Console.WriteLine("BTS change is " + BTS_Change + ".");
            Console.WriteLine("Competitor change is " + Competitor_Change + ".");
            Console.WriteLine("BTS VPM:" + BTS_VPM);
            Console.WriteLine("Competitor VPM:" + Competitor_VPM);

            Console.WriteLine(Environment.NewLine);

            if (BTS_New_Int > Competitor_New_Int)
            {
                Console.WriteLine("BTS is currently ahead.");
            }
            else if (BTS_New_Int < Competitor_New_Int)
            {
                Console.WriteLine("BTS is currently behind.");
            }
            else
            {
                Console.WriteLine("BTS and the competitor are currently tied.");
            }
        }
    }
}
