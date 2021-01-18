using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class Converting        //1st task
    {
        public string bin;

        public Converting(int decimal_value)
        {
            bin = Convert.ToString(decimal_value, 2);
        }
    }

    class Cube                                 //task2 
    {
        public int cubic;

        public Cube(int number)
        {
            cubic = (int)Math.Pow(number, 3);
        }
    }

    class Diamond                           //task 3
    {
        public const string V = " ";
        public int n;
        public string[,] arr = new string[10, 10];

        public Diamond(int size)
        {
            n = size * 2 - 1;
            //string[,] arr = new string[n, n];

            for (int i = 0; i <= n / 2; i++)
            {
                for (int j = 0; j < n / 2 - i; j++)
                {
                    arr[i, j] = V;
                    arr[i, n - j - 1] = V;
                    arr[n - i - 1, j] = V;
                    arr[n - i - 1, n - j - 1] = V;
                }

                for (int j = n / 2 - i; j <= n / 2 + i; j++)
                {
                    arr[i, j] = "*";
                    arr[n - i - 1, j] = "*";
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

    class Reverse                   //tasks 4-5
    {
        public int reverse;

        public Reverse(int number)
        {
            while (number != 0)
            {
                int r = number % 10;
                reverse = reverse * 10 + r;
                number = number / 10;
            }
        }
    }


    class Test
    {
        static void Main(string[] args)
        {
            //Converting first = new Converting(12);
            //Console.WriteLine($"{first.bin}");

            //Cube num = new Cube(4);
            //Console.WriteLine(num.cubic);

            //Diamond big = new Diamond(5);

            //Reverse num = new Reverse(234576543);
            //Console.WriteLine(num.reverse);

        }
    }
}
