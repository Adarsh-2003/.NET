using System;
namespace prac1d
{
    class prac1d
    {
        public void fibo(int n)
        {
            int no = 0;
            int no1 = 1;
            Console.WriteLine(no + "\n" + no1);
            for (int i = 3; i <= n; i++)
            {
                int no3 = no + no1;
                Console.WriteLine(no3);
                no = no1;
                no1 = no3;
            }
        }
        public bool prime(int n)
        {
            bool val = true;
            for(int i=2; i<n/2; i++){
                if (n % i == 0)
                {
                    val = false;

                    break;
                }
            }
            return val;
        }
        public bool vowel(char c)
        {
            bool val = false;
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                val = true;
            }
            return val;
        }
        public void array(int[] arr)
        {
            foreach(int x in arr){
                Console.WriteLine(x);
            }
        }
        public int reverse(int n)
        {
            int rev=0 ,rem=0;
            while(n>0){
                rem = n % 10;
                rev = rev*10 + rem;
                n=n/10;
            }
            return rev;
        }
        public int sum(int n)
        {
            int sum = 0, rem = 0;
            while(n>0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            prac1d p1 = new prac1d();  
            Console.WriteLine(" 1 Fibo  ");
            Console.WriteLine(" 2 Prime No  ");
            Console.WriteLine(" 3 Vowels ");
            Console.WriteLine(" 4 ForEach");
            Console.WriteLine(" 5 Reverse No ");
            Console.WriteLine(" 6 Sum of No ");
            Console.Write(" Enter choice ( 1 - 6 ) ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("How many numbers for fibo series ");
                    int n = int.Parse(Console.ReadLine());
                    p1.fibo(n);
                    break;

                case 2:
                    Console.Write("Enter the number ");
                    n = int.Parse(Console.ReadLine());
                    bool ans = p1.prime(n);
                    if (ans == false)
                    {
                        Console.WriteLine("Not a prime number");
                    }
                    else
                    {
                        Console.WriteLine("It is a prime number");
                    }
                    break;
                case 3:
                    Console.Write("Enter a character ");
                    char c = (Console.ReadKey().KeyChar);
                    Console.WriteLine(" ");
                    if (p1.vowel(c) == true)
                    {
                        Console.WriteLine("It is a vowel");
                    }
                    else
                    {
                        Console.WriteLine("Aint a vowel nigga");
                    }
                    break;
                case 4:
                    int[] arr = new int[] { 1, 2, 3, 4 };
                    p1.array(arr);
                    break;
                case 5:
                    Console.Write("Enter a number to reverse ");
                    int x = int.Parse(Console.ReadLine());
                    int y = p1.reverse(x);
                    Console.WriteLine("Reversed number " + y);
                    break;
                case 6:
                    Console.Write("Enter number ");
                    int x1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sum of digits " + p1.sum(x1));
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
