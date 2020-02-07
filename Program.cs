using System;

namespace GreetingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What score out of 100 do you expect to get in ISM 4300?");
            Console.WriteLine("Enter an integer value.");
            string grade;
            grade = Console.ReadLine();
 
            int myNum = Int32.Parse(grade);
            if (myNum < 60)
            {
                Console.WriteLine("F");
            }
            else if (myNum >= 60 && myNum <= 61)
            {
                Console.WriteLine("D-");
            }
            else if (myNum >= 62 && myNum <= 67)
            {
                Console.WriteLine("D");
            }
            else if (myNum >= 68 && myNum <= 69)
            {
                Console.WriteLine("D+");
            }
            else if (myNum >= 70 && myNum <= 71)
            {
                Console.WriteLine("C-");
            }
            else if (myNum >= 72 && myNum <= 77)
            {
                Console.WriteLine("C");
            }
            else if (myNum >= 78 && myNum <= 79)
            {
                Console.WriteLine("C+");
            }
            else if (myNum >= 80 && myNum <= 81)
            {
                Console.WriteLine("B-");
            }
            else if (myNum >= 82 && myNum <= 87)
            {
                Console.WriteLine("B");
            }
            else if (myNum >= 88 && myNum <= 89)
            {
                Console.WriteLine("B+");
            }
            else if (myNum >= 90 && myNum <= 91)
            {
                Console.WriteLine("A-");
            }
            else if (myNum >= 92 && myNum <= 97)
            {
                Console.WriteLine("A");
            }
            else if (myNum >= 98 && myNum <= 100)
            {
                Console.WriteLine("A+");
            }
        }
    }
}
