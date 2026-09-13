using System;
namespace Bai1;

class KhoangClass
{
    static void Main(String[] args)
    {
        Console.Write("Nhap vao toa do x diem A: ");
        double Xa = double.Parse(Console.ReadLine());
        Console.Write("Nhap vao toa do y diem A: ");
        double Ya = double.Parse(Console.ReadLine());
        Console.Write("Nhap vao toa do x diem B: ");
        double Xb = double.Parse(Console.ReadLine());

        Console.Write("Nhap vao toa do y diem B: ");
        double Yb = double.Parse(Console.ReadLine());
        double khoangCach = Math.Sqrt(Math.Pow(Xb - Xa,2)  + Math.Pow(Yb - Ya,2));
        Console.WriteLine("Khoang cach giua hai diem A va B la: {0}", khoangCach);
    }
}