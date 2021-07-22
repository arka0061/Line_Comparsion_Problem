using System;

public class Line
{
    double pointer1, pointer2, pointer3, pointer4;
    double lenght_Of_Line;
    public Line(double x1, double x2, double y1, double y2)
    {
        this.pointer1 = x1;
        this.pointer2 = x2;
        this.pointer3 = y1;
        this.pointer4 = y2;
    }
    public double Line_Length()
    {

        lenght_Of_Line = Math.Sqrt(Math.Pow((pointer2 - pointer1),2)) - (Math.Sqrt(Math.Pow((pointer4 - pointer3),2)));
        Console.WriteLine("The Length of the line 1 is :" + lenght_Of_Line);
        return lenght_Of_Line;
    }
   
}
