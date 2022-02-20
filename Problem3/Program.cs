using System;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter M & N");
            var MNValuesString = Console.ReadLine();
            var MnValues = MNValuesString.ToCharArray();
            char[] mtValues = new char[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter mi & ti");
                var MTValuesString = Console.ReadLine();
                 mtValues = MTValuesString.ToCharArray();
            }
            char[] xyValues = new char[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter mi & ti");
                var XYValuesString = Console.ReadLine();
                xyValues = XYValuesString.ToCharArray();
            }

        }
    }
}
