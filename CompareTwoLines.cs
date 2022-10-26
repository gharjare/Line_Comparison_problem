using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LineComparism
{
    public class CompareTwoLines
    {
        public static void CheckLines()
        {
            int x1 = 5;
            int x2 = 4;
            int y1 = 3;
            int y2 = 8;
            int x3 = 5;
            int x4 = 4;
            int y3 = 3;
            int y4 = 8;

            double lengthOfLine1 = Math.Sqrt(((x2 - x1) ^ 2) + ((y2 - y1) ^ 2));
            double lengthOfLine2 = Math.Sqrt(((x4 - x3) ^ 2) + ((y4 - y3) ^ 2));
            BigInteger obj1 = new BigInteger((int)lengthOfLine1);
            BigInteger obj2 = new BigInteger((int)lengthOfLine2);
            Console.WriteLine("The points x1= " + x1);
            Console.WriteLine("The points x2= " + x2);
            Console.WriteLine("The points y1= " + y1);
            Console.WriteLine("The points y2= " + y2);
            Console.WriteLine("The points x3=" + x3);
            Console.WriteLine("The points x4=" + x4);
            Console.WriteLine("The points y3=" + y3);
            Console.WriteLine("The points y4=" + y4);
            Console.WriteLine("Length of Line1 = " + lengthOfLine1);
            Console.WriteLine("Length of Line2 =" + lengthOfLine2);
            Console.WriteLine("Line1 and line2 are Equal : " + obj1.Equals(obj2));
        }
    }
}
