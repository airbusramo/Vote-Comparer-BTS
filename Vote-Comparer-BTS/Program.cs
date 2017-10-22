using System;
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

            int BTS_Old_Int;
            int BTS_New_Int;
            int Competitor_Old_Int;
            int Competitor_New_Int;
            int Time_Difference_Int;

            //Converting from string input to int.
            Int32.TryParse(BTS_Old_Input, out BTS_Old_Int);
            Int32.TryParse(BTS_New_Input, out BTS_New_Int);
            Int32.TryParse(Competitor_Old_Input, out Competitor_Old_Int);
            Int32.TryParse(Competitor_New_Input, out Competitor_New_Int);
            Int32.TryParse(Time_Difference_Input, out Time_Difference_Int);

            int BTS_Change = BTS_New_Int - BTS_Old_Int;
            int Competitor_Change = Competitor_New_Int - Competitor_Old_Int;

            Console.WriteLine("BTS change is " + BTS_Change);
            Console.WriteLine("Competitor change is " + Competitor_Change);
            Console.WriteLine(Time_Difference_Int);
        }
    }
}
