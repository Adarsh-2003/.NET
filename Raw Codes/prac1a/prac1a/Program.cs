using System;

namespace prac1a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            Console.Write("Enter 1st number ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2st number ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Enter 3rd number ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Enter 4th number ");
            n4 = int.Parse(Console.ReadLine());
            Console.Write("Product " + (n1+n2+n3+n4));
            Console.ReadKey();
        }
    }
}
