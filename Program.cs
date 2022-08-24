namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("The Maximum Values Are");
            int[] intArr = { 112, 344, 432, 555, 678 };
            int intMax = MaxInArray.MaximumInteger(intArr);
            Console.WriteLine(intMax);
            float[] floatArr = { 11.2f, 34.4f, 4.32f, 55.5f, 6.78f };
            float floatMax = MaxInArray.MaximumFloat(floatArr);
            Console.WriteLine(floatMax);
            List<string> stringArr = new List<string> { "Red", "Blue", "Orange", "Green", "Yellow" };
            string stringMax = MaxInArray.MaximumString(stringArr);
            Console.WriteLine(stringMax);
        }
    }
}