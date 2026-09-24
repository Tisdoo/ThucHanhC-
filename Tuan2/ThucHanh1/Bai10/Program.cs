using System;
using System.Security.Cryptography;
class XulyChuoi
{
    public bool Ktra(String n)
    {
        string tmp= n.Replace(" ","").ToLower();
        int left=0;
        int right=tmp.Length-1;
      while(left<right)
        {if(tmp[left]!=tmp[right])
            {
                return false;
                break;
            }
            left++;
            right--;

        }return true;
    }

}
class Program
{
    public static void Main(String [] args)
    {
        Console.Write("Moi ban nhap chuoi: ");
        string n=Console.ReadLine();
        XulyChuoi xl= new XulyChuoi();
        if(xl.Ktra(n))
        Console.Write("Chuoi " + n + " la chuoi doi xung ");
        else
         Console.Write("Chuoi" + n + " khong la chuoi doi xung ");

    }
}