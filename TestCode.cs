using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class TestCode
    {
        public static void TestCase1Float()
        {
            float result = MaxFloat.MaximumFloat(23.4f, 7.8f, 16.4f);
            Console.WriteLine("Maximum value is " + result);
        }       
        public static void TestCase2Float()
        {
            float result = MaxFloat.MaximumFloat(3.4f, 17.4f, 2.5f);
            Console.WriteLine("Maximum value is " + result);
        }
        public static void TestCase3Float()
        {
            float result = MaxFloat.MaximumFloat(3.6f, 7.5f, 21.8f);
            Console.WriteLine("Maximum value is " + result);
        }
    }
}
