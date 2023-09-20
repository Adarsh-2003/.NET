using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Uppercase " + str1.ToUpper());
            Console.WriteLine("Lowercase " + str1.ToLower());
            Console.WriteLine("Contains 2003 ? " + str1.Contains("2003"));
            Console.WriteLine("Length " + str1.Length);
            Console.ReadKey();
        }
    }
}
