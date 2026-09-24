using System;
using System.Text.RegularExpressions;
class HoanVi
{
    public  void Hoanvi(ref float a, ref float b)
    {
        float tmp = a;
        a = b;
        b = tmp;

    }

}
class Program
{
    static void Main( String [] args)
    { float a=0;
     float b=0;
        Console.Write("Nhap vao so thuc a: ");
        a=float.Parse(Console.ReadLine());
        Console.Write(" Nhap vao so thuc b: ");
        b=float.Parse(Console.ReadLine());
        HoanVi hv= new HoanVi();
        hv.Hoanvi(ref a, ref b);
        Console.Write(" hai so a và b sau khi hoan vi lan luot la: "+ a +"  "+b);


    }

}