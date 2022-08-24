using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class TestCode
    {
        public static void TestCase1Integer()
        {
            int result = MaxInt.MaximumInteger(10, 5, 6);
            Console.WriteLine("\nMaximum value is " + result);
        }

        //test case 2: max value at second position
        public static void TestCase2Integer()
        {
            int result = MaxInt.MaximumInteger(10, 15, 6);
            Console.WriteLine("\nMaximum value is " + result);
        }

        //test case 3: max value at third position
        public static void TestCase3Integer()
        {
            int result = MaxInt.MaximumInteger(10, 5, 16);
            Console.WriteLine("\nMaximum value is " + result);
        }
    }
}
