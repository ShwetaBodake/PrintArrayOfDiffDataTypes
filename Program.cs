// See https://aka.ms/new-console-template for more information
//
namespace PrintArrayDiffDataTypes
{
    public class Program
    {


        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-------------------------------------");

        }

     

        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 45, 67, 44, 77, 88 };
            double[] doubleArray = { 11.22, 44.55, 44.11, 66.2 };
            char[] charArray = { 'a', 'd', 'f', 'g' };

            Program.toPrint(intArray);
            Program.toPrint(doubleArray);
            Program.toPrint(charArray);
        }
    }
}
