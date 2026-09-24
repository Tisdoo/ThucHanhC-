using System;
public class Daochuoi
{
    // Hàm đảo chuỗi dùng vòng lặp
    public  string Xuly(string input)
    {
      
        string Chuoi = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Chuoi += input[i];
        }
        return Chuoi;
    }
}


class Program
{
    static void Main()
    {
        Console.Write("Nhap vao chuoi: ");
        string input = Console.ReadLine();

     Daochuoi dc=new Daochuoi();
        string Ketqua = dc.Xuly(input);
       
        Console.WriteLine("Chuoi sau khi dao la: "+ Ketqua);
    }
}