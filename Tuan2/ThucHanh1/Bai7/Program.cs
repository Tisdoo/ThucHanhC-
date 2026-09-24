using System;
class Ktra
{
    public bool SoNT(int n)
    {
        for(int i=2; i<(n-1);i++)
        {
            if(n%i==0)
            {
                return false;
                break;
            }

        }return true;
    }
}
class Program
{
    public static void Main(String [] args)
    {
       
        Console.Write( " Nhap vao so nguyen n: ");
        int n=int.Parse(Console.ReadLine());
        Ktra kt= new Ktra(); 
        if(kt.SoNT(n) && n>1)
        Console.WriteLine(n+ " La so nguyen to");
        else
        {
            Console.WriteLine (n + " Khong phai la so nguyen to ");
        };
        


    }
}