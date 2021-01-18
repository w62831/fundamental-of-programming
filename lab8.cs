using System;

namespace lab_8
{
    //Write a program in C# to Sum n odd natural numbers by using the Constructor (1)
    public class Sum
    {
        public int sum = 1;
        public Sum(int number)
        {
            sum = number * number;
        }
    }

    //pyramid pattern (2)
    public class Pyramid
    {
        public const string V = " ";
        private const string V1 = "*";
        public string[,] arr = new string[50, 50];

        public Pyramid(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1 - i; j++)
                {
                    arr[i, j] = V;
                    arr[i, size + j + i] = V;
                }

                for (int j = size - 1 - i; j <= size - 1 + i; j++)
                {
                    arr[i, j] = V1;
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size * 2 - 1; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

    //A.P. consructor and destructor
    public class Ap
    {
        public int[] arr = new int[50];

        public Ap(int size, int difference)
        {
            arr[0] = 1;
            for (int i = 1; i < size; i++)
            {
                arr[i] = arr[i - 1] + difference;
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        ~Ap()
        {
            Console.Beep();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Destractor used here");
        }
    }

    //Floyd cons and dest
    public class Floyd
    {
        public int[,] arr = new int[50, 50];

        public Floyd(int size)
        {
            int k = 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    arr[i, j] = k;
                    k++;
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        ~Floyd()
        {
            Console.Beep();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Destractor used here");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Sum n = new Sum(5);
            //Console.WriteLine(n.sum);

            //Pyramid mn = new Pyramid(10);

            //Ap ap = new Ap(15, 7);

            //Floyd floyd = new Floyd(15);
        }
    }
}
