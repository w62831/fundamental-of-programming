using System;

namespace lab_2
{
    class Program
    {
        static void Ex1()
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
        static void Ex2()
        {
            //Write a C# Sharp program that takes a number as input and print its multiplication table.
            Console.WriteLine("Enter the number ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The multiplication table");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0}*{1}={2}", i, a, a * i);
            }
        }
        static void Ex3()
        {
            //Write a C# program to check two given integers and return true if one is negative and one is positive.
            Console.WriteLine("Enter 2 numbers ");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a < 0 || b < 0)
            {
                if (a >= 0 || b >= 0)
                {
                    Console.WriteLine("TRUE ");
                }
                else { Console.WriteLine("FALSE "); }
            }
            else { Console.WriteLine("FALSE "); }
        }
        static void Ex4()
        {
            //Write a C# program to check if an given integer is within 20 of 100. 
            Console.WriteLine("Enter the number ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 20 && a <= 100)
            {
                Console.WriteLine("It is between 20 and 100 ");
            }
            else { Console.WriteLine("It is less than 20 or bigger than 100 "); }
        }
        static void Ex5()
        {
            //Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
            Console.WriteLine("Odd numbers from 1 to 99 ");
            for (int i = 1; i <= 99; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
        static void ex6()
        {
            //Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.
            Console.WriteLine("Enter positive number ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0 || a % 7 == 0)
            {
                Console.WriteLine("{0} is a multiple of 3 or 7", a);
            }
            else { Console.WriteLine("{0} is not a multiple of 3 nor 7", a); }
        }
        static void ex7()
        {
            //Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10
            Console.WriteLine("Enter the numbers ");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if ((a >= -10 && a <= 10) || (b >= -10 && b <= 10))
            {
                Console.WriteLine("One/both of the numbers is/are in the range from -10 to 10 ");
            }
            else { Console.WriteLine("They are not in the range "); }
        }
        static void ex8()
        {
            //Write a C# program to check two given numbers where one is less than 100 and other is greater than 200
            Console.WriteLine("Enter the numbers ");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if ((a <= 100 && b >= 200))
            {
                Console.WriteLine("One is greater than 200 and other less than 100 ");
            }
            else if ((b <= 100 && a >= 200))
            {
                Console.WriteLine("One is greater than 200 and other less than 100 ");
            }
            else { Console.WriteLine("They are not in the range "); }
        }
        static void ex9()
        {
            //Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle
            Console.WriteLine("Enter the radius ");
            double r;
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The perimeter is {0} and the area is {1} of the circle ", 2 * 3.14 * r, 3.14 * r * r);
        }
        static void ex10()
        {
            //Write a C# Sharp program that takes distance and time as input and displays the speed in kilometers per hour and miles per hour
            Console.WriteLine("Enter the distance in km (if unknown - 0)");
            double km, mil, sec;
            km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the distance in miles (if unknown - 0)");
            mil = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time in hours");
            sec = Convert.ToDouble(Console.ReadLine());

            if (km == 0 && mil > 0)
            {
                km = mil * 0.621;
            }
            else if (mil == 0 && km > 0)
            {
                mil = km * 1.609;
            }
            else if (km == 0 && mil == 0) { Console.WriteLine("ERROR"); }
            if (sec == 0) { Console.WriteLine("ERROR"); }

            Console.WriteLine("The speed is {0} km/h or {1} miles/h ", km / sec, mil / sec);
        }
        static void ex11()
        {
            //Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface and volume of the sphere
            double r;
            const double p = 3.14;
            Console.WriteLine("Enter the radius ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Surface of the sphere is {0} ", 4 * p * r * r);
            Console.WriteLine("Volume of the sphere is {0} ", 4 * p * r * r * r / 3);
        }
        static void ex12()
        {
            //Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd
            int a, b;
            Console.WriteLine("Enter numbers ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                if (b % 2 == 0)
                {
                    Console.WriteLine("TRUE");
                }
                else
                {
                    Console.WriteLine("Different");
                }
            }
            else
                if (b % 2 != 0)
            {
                Console.WriteLine("FALSE");
            }
            else
            {
                Console.WriteLine("Different");
            }
        }

        //static void Main(string[] args)
        //{  Console.WriteLine("Hello World!");}
    }
}
