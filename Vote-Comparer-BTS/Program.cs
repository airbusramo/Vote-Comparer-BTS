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

            int BTS_Old_Int;
            int BTS_New_Int;

            Int32.TryParse(BTS_Old_Input, out BTS_Old_Int);
            Int32.TryParse(BTS_New_Input, out BTS_New_Int);

            int BTS_Change = BTS_New_Int - BTS_Old_Int;

            Console.WriteLine(BTS_Change);
        }
    }
}
