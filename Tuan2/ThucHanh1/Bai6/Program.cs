using System;

class XuLySo
{
    public int TimMax(int a , int b , int c)
    {
        int max=a;
        if(b>max)
        max=b;
        if(c>max)
        max=c;
        return max;
    }
}
class Program
{
    static void Main(string[] args)
    {
        XuLySo xuly = new XuLySo();
        Console.Write("Nhap so nguyen x: ");
        int x=int.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen y: ");
        int y=int.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen z: ");
        int z=int.Parse(Console.ReadLine());
        int max=xuly.TimMax(x,y,z);
        Console.Write(" So lon nhat trong 3 chu so la "+ max);
        
    }
}