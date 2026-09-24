using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so nguyen x: ");
        int x=int.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen y: ");
        int y=int.Parse(Console.ReadLine());
        Console.Write("Ket qua {0} mu {1} la: {2}", x ,y, Math.Pow(x,y));
    }
}