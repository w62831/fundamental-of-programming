using System;

namespace lab_6
{
    class ex1
    {
        //Write any C# program to create a simple class and object
        string hey = "hello";
        
    }
    class ex2
    {
        //Write a class having two private variables and one member function which will return the area of the rectangle.
        private int a = 5, b = 6;
         int area()
        {
            return a * b;
        }

    }
    //Read and print details of a student (name, student id number, marks obtained in each subject, 
    //total marks, and final grade using class program in C#
    class ex3
    {
        string name;
        int stIDnum, math, prog, phys, c, lang, final; //only 5 subjects
        int[] totmarks = new int[5];
        static void hello(string[] args)
        {
            Console.WriteLine("enter the number of students");
            int n = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}
