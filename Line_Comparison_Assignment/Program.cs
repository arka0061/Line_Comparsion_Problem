using System;

namespace Line_Comparison_Assignment
{
    class Program
    {
        public static int pointer1, pointer2, pointer3, pointer4;
        public static void Main(String[] args)
        {
            Program obj1 = new Program();
            Console.WriteLine("Welcome to Line Comparison Problem!");
            Console.WriteLine("Please Enter the Co-od of Lines");
            pointer1 = Convert.ToInt32(Console.ReadLine());
            pointer2 = Convert.ToInt32(Console.ReadLine());
            pointer3 = Convert.ToInt32(Console.ReadLine());
            pointer4 = Convert.ToInt32(Console.ReadLine());
            Constructor obj = new Constructor(pointer1,pointer2,pointer3,pointer4);
            Console.WriteLine("value of pointer1 is : " + obj.pointer1);
            Console.WriteLine("value of pointer2 is : "+ obj.pointer2);
            Console.WriteLine("value of pointer3 is : " + obj.pointer3);
            Console.WriteLine("value of pointer4 is : " + obj.pointer4);
            obj1.lenght_Of_Line();
            

        }
        public void lenght_Of_Line()
        {
            double lenght_Of_Line = (Math.Sqrt((pointer2 - pointer1))) - (Math.Sqrt(pointer4 - pointer3));
            Console.WriteLine("The Length of the line is :" + lenght_Of_Line);

        }
    }
}
