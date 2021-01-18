using System;

namespace lab_1
{
    class lab1
    {
        static void Ex1()
        {
            //Write a C# Sharp program to print Hello and your name in a separate line.
            Console.WriteLine("Hello");
            Console.WriteLine("Kissikova Yasmin");
        }
       
        static void Ex2()
        {
            //Write a C# Sharp program to print the sum of two numbers. 
            int a = 5, b = 8;
            Console.WriteLine(a + b);
        }
        static void Ex3()
        {
            //Write a C# Sharp program to print the result of dividing two numbers.
            int a = 6, b = 2;
            Console.WriteLine(a/b);
        }
        static void Ex4()
        {
            //Write a C# Sharp program to print the result of the specified operations. 
            Console.WriteLine(" -1 + 4 * 6= {0}", -1 + 4 * 6);
            Console.WriteLine(" (35 + 5) % 7= {0}", (35 + 5) % 7);
            Console.WriteLine(" 14 + -4 * 6 / 11= {0}", 14 + -4 * 6 / 11);
            Console.WriteLine(" 2 + 15 / 6 * 1 - 7 % 2= {0}", 2 + 15 / 6 * 1 - 7 % 2);
        }
        static void Ex5()
        {
            //Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user 
            int a, b, c;
            Console.WriteLine("Enter 3 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}*{1}*{2}={3}", a, b, c, a * b * c);
        }
        static void Ex6()
        {
            //Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user
            double a, b;
            Console.WriteLine("Enter 2 numbers");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
        }
        static void Ex7()
        {
            //Write a C# Sharp program that takes four numbers as input to calculate and print the average
            double a, b, c, d;
            Console.WriteLine("Enter 4 numbers");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The average is {0}", (a + b + c + d) / 4);
        }
        static void Ex8()
        {
            //Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y
            double x, y, z;
            Console.WriteLine("Enter 3 numbers");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("(x+y)/z={0}", (x + y) / z);
            Console.WriteLine("x/y={0}", x / y);
        }
        static void Ex9()
        {
            //Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit
            double ct;
            Console.WriteLine("Enter the temperature in Celsius : ");
            ct = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The temperature in Kelvin {0}", ct * 9 / 5 + 32);
            Console.WriteLine("The temperature in Fahrenheit {0}", ct + 273, 15);
        }
        static void Ex10()
        {
            //Write a C# program to convert a hexadecimal number to decimal number.
            Console.WriteLine("Enter the number in hexadecimal ");
            string h;
            h = Console.ReadLine();
            int a = Convert.ToInt32(h, 16);

            Console.WriteLine("The number in decimal is {0}", a);
        }
    }
}
