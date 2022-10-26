using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparism
{
    public class LineAndComparisom
    {
        public static void CheckLength()
        {
            int x1 = 2;
            int x2 = 3;
            int y1 = 5;
            int y2 = 7;


            double lengthOfLine1 = Math.Sqrt(((x2 - x1) ^ 2) + ((y2 - y1) ^ 2));
           Console.WriteLine ("The points x1 = " + x1);
            Console.WriteLine("The points x2 = " + x2);
            Console.WriteLine("The points y1 = " + y1);
            Console.WriteLine("The points y2 = " + y2);
            Console.WriteLine("Length of Line = " + lengthOfLine1);
        }
    }
}
