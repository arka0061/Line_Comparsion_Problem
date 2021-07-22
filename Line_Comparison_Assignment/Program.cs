using System;

namespace Line_Comparison_Assignment
{
    class Program
    {

        

        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem!");
            Line obj1 = new Line(9, 17, 7, 12);
            double length_Of_line1 = obj1.Line_Length();
            Line obj2 = new Line(8, 15, 6, 9);
            double length_Of_line2 = obj2.Line_Length();
            Console.WriteLine("Length of Line 1 is :" + length_Of_line1);
            Console.WriteLine("Length of Line 2 is :" + length_Of_line2);
            if (length_Of_line1 > length_Of_line2)
            {
                Console.WriteLine("Length of Line 1 is grater than Line 2 ");
            }
            if (length_Of_line1 == length_Of_line2)
            {
                Console.WriteLine("Length of Line 1 equal to Line 2 ");
            }
            else
            {
                Console.WriteLine("Length of Line 2 is grater than Line 1 ");
            }




        }

    }
}