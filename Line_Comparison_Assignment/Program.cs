using System;

namespace Line_Comparison_Assignment
{
    class Program
    {
        public static int pointer1, pointer2, pointer3, pointer4;//Line 1
        public static int pointer5, pointer6, pointer7, pointer8;//Line 2
        double lenght_Of_Line1;
        double lenght_Of_Line2;
        public static void Main(String[] args)
        {
            Program obj1 = new Program();
            Console.WriteLine("Welcome to Line Comparison Problem!");
            Console.WriteLine("Please Enter the Co-od of Lines");
            pointer1 = Convert.ToInt32(Console.ReadLine());
            pointer2 = Convert.ToInt32(Console.ReadLine());
            pointer3 = Convert.ToInt32(Console.ReadLine());
            pointer4 = Convert.ToInt32(Console.ReadLine());
            pointer5 = Convert.ToInt32(Console.ReadLine());
            pointer6 = Convert.ToInt32(Console.ReadLine());
            pointer7 = Convert.ToInt32(Console.ReadLine());
            pointer8 = Convert.ToInt32(Console.ReadLine());
            Constructor obj = new Constructor(pointer1,pointer2,pointer3,pointer4,pointer5,pointer6,pointer7,pointer8);
            Console.WriteLine("value of pointer1 is : " + obj.pointer1);
            Console.WriteLine("value of pointer2 is : "+ obj.pointer2);
            Console.WriteLine("value of pointer3 is : " + obj.pointer3);
            Console.WriteLine("value of pointer4 is : " + obj.pointer4);
            Console.WriteLine("Enter Second Line Values");
            Console.WriteLine("value of pointer5 is : " + obj.pointer5);
            Console.WriteLine("value of pointer6 is : " + obj.pointer6);
            Console.WriteLine("value of pointer7 is : " + obj.pointer7);
            Console.WriteLine("value of pointer8 is : " + obj.pointer8);

            obj1.lenght_Of_Line();
            obj1.equality_Of_Two_Lines();
            obj1.equalityCheck2();
            

        }
        public void lenght_Of_Line()
        {
            lenght_Of_Line1 = (Math.Sqrt((pointer2 - pointer1))) - (Math.Sqrt(pointer4 - pointer3));
            Console.WriteLine("The Length of the line 1  is :" + lenght_Of_Line1);

            lenght_Of_Line2 = (Math.Sqrt((pointer6 - pointer5))) - (Math.Sqrt(pointer8 - pointer7));
            Console.WriteLine("The Length of the line 2 is :" + lenght_Of_Line2);

        }
        public void equality_Of_Two_Lines()
        {
            if (lenght_Of_Line1==lenght_Of_Line2)
            {
                Console.WriteLine("The Lines Are Equal in Length!");
            }
            else
            {
                Console.WriteLine("The Lines Are Not Equal in Length!");

            }

        }
        public void equalityCheck2()
        {
            if (lenght_Of_Line1 >lenght_Of_Line2)
            
                Console.WriteLine("Line 1 is grater than Line 2 in Length!");
            
            if (lenght_Of_Line1 < lenght_Of_Line2)
            
                Console.WriteLine("Line 2 is grater than Line 1 in Length!");

            
            if (lenght_Of_Line1 == lenght_Of_Line2)
            
                Console.WriteLine("The Lines Are Equal in Length!");
            
            else
            
                Console.WriteLine("The Lines Are Not Equal in Length!");

            


        }
       
    }
}
