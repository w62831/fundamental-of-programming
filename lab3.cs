using System;
using System.Collections.Generic;

namespace lab_3
{
    class Program
    {
        static void ex1()
        {
            //Write a C# program that prompts the user to input three integer values and find the greatest and lowest of the three values.
            int a, b, c;
            Console.WriteLine("Enter 3 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The maximum number is {0}", Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("The minimum number is {0}", Math.Min(a, Math.Min(b, c)));
        }
        static void ex2()
        {
            //Write a C# program that determines a student’s grade.
            int a, b = 0;
            Console.WriteLine("Enter the percentage ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 50)
            {
                b = 2;
            }
            else if (a < 75)
            {
                b = 3;
            }
            else if (a < 90)
            {
                b = 4;
            }
            else if (a >= 90)
            {
                b = 5;
            }
            Console.WriteLine("The grade is {0}", b);
        }
        static void ex3()
        {
            //Write a C# program to check whether a number is negative, positive or zero.
            int a;
            Console.WriteLine("Enter the number ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("The number is negative ");
            }
            else if (a == 0)
            {
                Console.WriteLine("It is 0");
            }
            else
            {
                Console.WriteLine("The number is positive");
            }
        }
        static void ex4()
        {
            //Write a C# program to check whether a number is even or odd.
            int a;
            Console.WriteLine("Enter the number ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("The number is even ");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
        static void ex5()
        {
            //Write a C# program to check whether a character is alphabet or not.
            char a;
            a = Convert.ToChar(Console.ReadLine());
            if (Char.IsLetter(a))
            {
                Console.WriteLine("the character is a letter");
            }
            else
            {
                Console.WriteLine("the character is not a letter");
            }
        }
        static void ex6()
        {
            //Write a C# program to input month number and print number of days in that month.
            int a;
            Console.WriteLine("Enter the month number ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 1)
            {
                if (a <= 7)
                {
                    Console.WriteLine("31 days");
                }
                else
                {
                    Console.WriteLine("30 days");
                }
            }
            else
            {
                if (a == 2)
                {
                    Console.WriteLine("28 or 29 days");
                }
                else if (a <= 6)
                {
                    Console.WriteLine("30 days");
                }
                else
                {
                    Console.WriteLine("31 days");
                }
            }
        }
        static void ex7()
        {
            //Write a C# program to detect key presses (If the user pressed number keys( from 0 to 9), the program will display the number that is pressed, otherwise the program will show "Not allowed").
            char key;
            Console.Write("Press a number key:");
            key = Convert.ToChar(Console.Read());
            switch (key)
            {
                case '0': Console.WriteLine("You pressed 0"); break;
                case '1': Console.WriteLine("You pressed 1"); break;
                case '2': Console.WriteLine("You pressed 2"); break;
                case '3': Console.WriteLine("You pressed 3"); break;
                case '4': Console.WriteLine("You pressed 4"); break;
                case '5': Console.WriteLine("You pressed 5"); break;
                case '6': Console.WriteLine("You pressed 6"); break;
                case '7': Console.WriteLine("You pressed 7"); break;
                case '8': Console.WriteLine("You pressed 8"); break;
                case '9': Console.WriteLine("You pressed 9"); break;
                default: Console.WriteLine("Not allowed!"); break;
            }
        }
        static void ex8()
        {
            //Write a C# Sharp program to create Simple Calculator using switch case.
            Console.WriteLine("Enter the math action ");
            var m = Console.ReadLine();
            double a, b;
            Console.WriteLine("Enter the 2 numbers");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            switch (m)
            {
                case "+":
                    Console.WriteLine(a + b);
                    return;
                case "-":
                    Console.WriteLine(a - b);
                    return;
                case "*":
                    Console.WriteLine(a * b);
                    return;
                case "/":
                    Console.WriteLine(a / b);
                    return;
                default:
                    Console.WriteLine("The input is wrong");
                    break;
            }
        }
        static void ex9()
        {
            //Write a C#  program to convert Binary to Hexadecimal number system.
            Console.WriteLine("Enter num in bin");
            var a = Console.ReadLine();
            var h = Convert.ToInt32(a, 2).ToString("X");
            Console.WriteLine("From binary to hexadecimal {0}", h);
        }
        static void ex10()
        {
            //Write a C# program to check whether a number is Perfect number or not.
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            double i = 1;
            while (i > 0)
            {
                double n = Math.Pow(2, i) * (Math.Pow(2, i + 1) - 1);
                if (a == n)
                {
                    Console.WriteLine("The number is perfect");
                    i = 0;
                }
                else if (a > n)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Number is not perfect");
                    i = 0;
                }
            }
        }
        static void ex11()
        {
            //Write a C# program to find all prime factors of a number.
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int n1 = n;
            List<int> p = new List<int>();
            int i = 2;
            while (n1 > 1)
            {
                while (n1 % i == 0)
                {
                    n1 = n1 / i;
                    p.Add(i);
                }
                i++;
            }
            foreach (int k in p)
            {
                Console.Write("{0}*", k);
            }

        }
        //static void Main(string[] args)
        //{}
    }
}
