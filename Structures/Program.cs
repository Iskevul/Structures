using System;

namespace Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var arr1 = new DynArray();
            var arr2 = new DynArray();

            arr1.FillRandom(2, 5);
            arr2.FillRandom(4, 7);

            arr1.Print();
            arr2.Print();
        }
    }
}
