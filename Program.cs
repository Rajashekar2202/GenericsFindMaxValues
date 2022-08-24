namespace Generics
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("The Maximum Values Are \n");
            int[] intArray = { 112, 344, 432, 555, 678 };
            MaxInArrayGeneric<int> generic = new MaxInArrayGeneric<int>(intArray);
            generic.PrintMaxValue();
            float[] floatArray = { 11.2f, 34.4f, 4.32f, 55.5f, 6.78f };
            MaxInArrayGeneric<float> genericFloat = new MaxInArrayGeneric<float>(floatArray);
            genericFloat.PrintMaxValue();
            string[] stringArray = { "Red", "Blue", "Orange", "Green", "Yellow" };
            MaxInArrayGeneric<string> genericString = new MaxInArrayGeneric<string>(stringArray);
            genericString.PrintMaxValue();
        }
    }
}