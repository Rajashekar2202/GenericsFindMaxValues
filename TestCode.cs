using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class TestCode
    {
        public static void TestCase1String()
        {
            String result = MaxString.MaximumString("Pomagranet", "Apple", "Banana");
            Console.WriteLine("Maximum value is " + result);
        }
        
        public static void TestCase2String()
        {
            String result = MaxString.MaximumString("Lion", "Tiger", "Elephant");
            Console.WriteLine("Maximum value is " + result);
        }
        
        public static void TestCase3String()
        {
            String result = MaxString.MaximumString("Pink", "Green", "Yellow");
            Console.WriteLine("Maximum value is " + result);
        }

    }
}
