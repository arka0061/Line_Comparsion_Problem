using System;

namespace Line_Comparison_Assignment
{
    class Program
    {

        double lenght_Of_Line1;

        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem!");
            Line obj1 = new Line(9, 17, 7, 12);
            double length_Of_line1 = obj1.Line_Length();
            Line obj2 = new Line(8, 15, 6, 9);
            double length_Of_line2 = obj2.Line_Length();
            Console.WriteLine("Length of Line 1 is :" + length_Of_line1);
            Console.WriteLine("Length of Line 2 is :" + length_Of_line2);
           
        }

    }
}