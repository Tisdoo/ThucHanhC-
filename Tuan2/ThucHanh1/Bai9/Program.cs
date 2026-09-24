using System;
using System.ComponentModel.DataAnnotations;
class Xuly
{
    public float Min(float a, float b, float c, out float min)
    {
        min = a;

        if (b < min)
            min = b;
        if (c < min)
            min = c;


        return min;
    }
    public float Max(float a, float b, float c, out float max)
    {
        max = a;

        if (b > max)
            max = b;
        if (c > max)
            max = c;


        return max;
    }

}class Program{
public static void Main()
    {float min,max;
        Console.Write("Nhap vao so thuc a: ");
        float a=float.Parse(Console.ReadLine());
        Console.Write("Nhap vao so thuc b: ");
        float b=float.Parse(Console.ReadLine());
        Console.Write("Nhap vao so thuc c: ");
        float c=float.Parse(Console.ReadLine());
Xuly xl= new Xuly();
Console.WriteLine("So thuc co gia tri lon nhat la: "+ xl.Max(a,b,c,out max));
Console.WriteLine("So thuc co gia tri nho nhat la: "+ xl.Min(a,b,c,out min));

    }
}