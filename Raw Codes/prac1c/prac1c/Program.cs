using System;

namespace prac1c
{
    class Program
    {
        struct Student
        {
            public string name,cname;
            public int sid,dd,mm,yy;
            public void display()
            {
                Console.WriteLine("Student id " +sid);
                Console.WriteLine("Student name " +name);
                Console.WriteLine("Student course name " + cname);
                Console.WriteLine("Student dob {0}/{1}/{2} " ,dd,mm,yy);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students to be entered ");
            int n = int.Parse(Console.ReadLine());
            Student[] s = new Student[n];
            for(int i=0; i<n; i++){
                s[i]= new Student();
                Console.Write("Enter student id ");
                s[i].sid = int.Parse(Console.ReadLine());
                Console.Write("Enter student name ");
                s[i].name = Console.ReadLine();
                Console.Write("Enter student course name ");
                s[i].cname = Console.ReadLine();
                Console.Write("Enter date ");
                s[i].dd = int.Parse(Console.ReadLine());
                Console.Write("Enter date ");
                s[i].mm = int.Parse(Console.ReadLine());
                Console.Write("Enter date ");
                s[i].yy = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("------------ Accepted Student info ------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("-----------------");
                s[i].display();
                Console.WriteLine("-----------------");
            }
            Console.ReadKey();
        }
    }
}
