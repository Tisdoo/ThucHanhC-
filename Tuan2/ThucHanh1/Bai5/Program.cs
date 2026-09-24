using System;
class Program
{
    static void Main(string[] args)
    {
        double x=0;
        double y=0;
        int luachon;

 do
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1.Nhap hai gia tri so thuc x vaf y: ");
            Console.WriteLine("2. Tinh x^y");
            Console.WriteLine("3.Tinh can bac 2 cua x va y");
            Console.WriteLine("4. Thoat");
            Console.Write("Nhap lua chon cua ban: ");
            if(int.TryParse(Console.ReadLine(), out luachon))
            {
                switch(luachon)
                {
                    case 1:
                        Console.Write("Nhap so thuc x: ");
                        x=double.Parse(Console.ReadLine());
                        Console.Write("Nhap so thuc y: ");
                        y=double.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Ket qua {0} mu {1} la: {2}", x ,y, Math.Pow(x,y));
                        break;
                    case 3:
                        Console.WriteLine("Can bac 2 cua {0} la: {1}", x, Math.Sqrt(x));
                        Console.WriteLine("Can bac 2 cua {0} la: {1}", y, Math.Sqrt(y));
                        break;
                    case 4:
                        Console.WriteLine("Thoat chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                luachon = 0; // Reset luachon
            }

        }while(luachon!=4);

    }
    }