using System;
class Lop
{
    public string InHoa(string input)
    {
        return input.ToUpper();

    }
       public string ChuThuong(string input)
    {
        return input.ToLower();
        
    }
       public int Dem(string input)
    {
        string[] word = input.Split(new char []{' ' , '\t','\n'}, StringSplitOptions.RemoveEmptyEntries);
        return word.Length;
        
    }
}
class Program
{
    public static void Main( String [] args)
    {
        Lop l=new Lop();
        Console.Write(" Nhap vao chuoi: ");
    string input=Console.ReadLine();
    Console.WriteLine("Doi thanh chuoi in hoa: "+ l.InHoa(input) );
    Console.WriteLine("Doi chuoi thanh in thuong "+l.ChuThuong(input));
    Console.WriteLine("Dem chuoi: "+l.Dem(input));

    }
}