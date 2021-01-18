using System;

namespace lab_4
{
    class Program
    {
        static void ex1()
        {
            //Write a C# program to answer about the statistical information such as arithmetic mean, median, mode, and standard deviation of an integer data set. The data points are input by the user from keyboard.
            Console.WriteLine("enter the amount of numbers ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            double mean = 0, median = 0, mode = 0, stdev = 0;
            Console.WriteLine("enter the numbers");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                mean = mean + arr[i];
            }
            mean = mean / n;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int t = arr[i];
                    if (arr[j] < arr[i])
                    {
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            if (n % 2 == 0)
            {
                median = (arr[n / 2] + arr[(n / 2) - 1]) / 2;
            }
            else
            {
                median = arr[n / 2];
            }
            int m = arr[n - 1];
            int[] marr = new int[m];
            for (int i = 0; i < m; i++)
            {
                marr[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i == arr[j])
                    {
                        marr[i]++;
                    }
                }
            }
            for (int i = 0; i < m - 1; i++)
            {
                if (marr[i] < marr[i + 1])
                {
                    mode = i + 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                stdev = stdev + (arr[i] - mean) * (arr[i] - mean);
            }
            stdev = stdev / n;
            stdev = Math.Sqrt(stdev);
            if (mode > 0)
            { Console.WriteLine("the mean is {0}, mode = {1}, median = {2}, standard deviation = {3} ", mean, mode, median, stdev); }
            else
            {
                Console.WriteLine("the mean is {0}, median = {2}, standard deviation = {3} and there is no mode ", mean, median, stdev);
            }
        }
        static void ex2()
        {
            //Write a program in C# Sharp to read n number of values in an array and display it in reverse order.
            int n;
            Console.WriteLine("enter the size of array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("enter the numbers");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n / 2; i++)
            {
                int t = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = t;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}   ", arr[i]);
            }
        }
        static void ex3()
        {
            //Write a program in C# Sharp to count a total number of duplicate elements in an array
            int n;
            Console.WriteLine("enter the size of array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("enter the numbers");
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] > m)
                { m = arr[i]; }
            }
            int[] marr = new int[m];
            for (int i = 0; i < m; i++)
            {
                marr[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i == arr[j])
                    {
                        marr[i]++;
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                if (marr[i] > 1)
                { count++; }
            }
            Console.WriteLine("number of duplicated elements {0}", count);
        }
        static void ex4()
        {
            //Write a program in C# Sharp for multiplication of two square Matrices
            Console.WriteLine("enter number of colums and rows for first matrix");
            int c1 = Convert.ToInt32(Console.ReadLine());
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number of colums and rows for second matrix");
            int c2 = Convert.ToInt32(Console.ReadLine());
            int r2 = Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int[c1, r1];
            int[,] arr2 = new int[c2, r2];
            int[,] arr3 = new int[c1, r2];
            Console.WriteLine("enter the numbers for 1st matrix");
            for (int i = 0; i < c1; i++)
            {
                for (int j = 0; j < r1; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < c2; i++)
            {
                for (int j = 0; j < r2; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    arr3[i, j] = 0;
                }
            }
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < c1; k++)
                    {
                        sum = sum + arr1[i, k] * arr2[k, j];
                    }
                    arr3[i, j] = sum;
                }
            }
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write("{0}   ", arr3[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void ex5()
        {
            //Write a program in C# Sharp to find transpose of a given matrix
            Console.WriteLine("enter the number of colums and rows");
            int c = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int[c, r];
            int[,] arr2 = new int[r, c];
            Console.WriteLine("enter the elements of matrix");
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    arr2[j, i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("the original matrix");
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write("{0}", arr1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("the transpose of matrix");
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write("{0}", arr2[i, j]);
                }
                Console.WriteLine();
            }

        }
        static void ex6()
        {
            //Write a program in C# Sharp to calculate determinant of a 3 x 3 matrix
            int[,] arr = new int[3, 3];
            int det = 0;
            Console.WriteLine("enter the numbers ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            { det = det + (arr[0, i] * (arr[1, (i + 1) % 3] * arr[2, (i + 2) % 3] - arr[1, (i + 2) % 3] * arr[2, (i + 1) % 3])); }

            Console.WriteLine("The Determinant of the matrix is: {0}", det);
        }
        static void ex7(string str)
        {
            //Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
            string str1;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                {
                    count++;
                }
            }
            Console.WriteLine("number of spaces {0}", count);
        }
        static void ex8(int a, int b)
        {
            //Write a program in C# Sharp to create a function to swap the values of two integer numbers
            int t = a;
            a = b;
            b = t;
        }
        static void ex9(int n)
        {
            //Write a program in C# Sharp to create a function to check whether a number is prime or not.
            int k = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    k++;
            }
            if (k == 0)
            {
                Console.WriteLine("the number is prime");
            }
            else
            {
                Console.WriteLine("the number is not prime");
            }
        }
        static void ex10(int n)
        {
            //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
            int l = 0;
            do
            {
                l = l + n % 10;
                n = n / 10;
            }
            while (n > 0);

        }
        static void ex11(int n)
        {
            //Write a program in C# Sharp to create a function to find the factorial of a given number.
            int fact = 1;
            if (n == 0)
            {
                fact = 1;
            }
            else
            {
                for (int i = 1; i < n + 1; i++)
                {
                    fact = fact * i;
                }
            }
        }
        
    }
}
