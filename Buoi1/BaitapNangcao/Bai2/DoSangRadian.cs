using System;
class DoSangRadian
{
    static void Main(String[] args)
    {
        Console.Write("Nhap vao do: ");
        double doGoc = double.Parse(Console.ReadLine());
        double radian = (double)(doGoc * Math.PI / 180);
        Console.WriteLine("{0} do ung voi {1} radian", doGoc, radian);
    }
}