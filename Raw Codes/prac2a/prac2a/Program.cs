using System;

namespace prac2a
{
    class myutility
    {
        public int fact(int x)
        {
            int f = 1;
            for (int i = 2; i <= x; i++)
            {
                f = f * i;
            }
            return f;
        }

        public float d2r(float d)
        {
            return d * 83.24f;
        }

        public float r2d(float r)
        {
            return r / 83.24f;
        }

        public float c2f(float n)
        {
            return (n * 9) / 5 + 32;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            myutility m1 = new myutility();
            
            Console.WriteLine("1. factorial");
            Console.WriteLine("2. $ to inr");
            Console.WriteLine("3. inr to $");
            Console.WriteLine("4. celsius to fahrenheit");
            Console.WriteLine("5. fahrenheit to celsius ");
            Console.Write("Enter choice ");
            int c = int.Parse(Console.ReadLine());

            switch(c){
                case 1:
                    Console.WriteLine("Enter a number ");
                    int b = int.Parse(Console.ReadLine());
                    int ans = m1.fact(b);
                    Console.WriteLine("Fac
                default:
                    Console.WriteLine("ok");
                    break;
            }
            Console.ReadKey();
        }
    }
}
