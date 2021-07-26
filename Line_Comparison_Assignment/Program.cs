using System;

namespace Line_Comparison_Assignment
{
    class Program
    {

        

        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem!");
            Line obj1 = new Line(1, 1, 1, 1);
            double length_Of_line1 = obj1.Line_Length();
            Line obj2 = new Line(1, 1, 1, 1);
            double length_Of_line2 = obj2.Line_Length();
            Console.WriteLine("Length of Line 1 is :" + length_Of_line1);
            Console.WriteLine("Length of Line 2 is :" + length_Of_line2);
            int compare = length_Of_line1.CompareTo(length_Of_line2);
            if (compare >0)
            {
                Console.WriteLine("Length of Line 1 is grater than Line 2 ");
            }
            else if(compare <0 )
            {
                Console.WriteLine("Length of Line 2 is grater than line 1");
            }
            if (length_Of_line1.Equals(length_Of_line2) | compare == 0)   //just to show .Equals keyword
            {
                Console.WriteLine("Length of Line 1 equal to Line 2 ");
            }
        }

    }
}