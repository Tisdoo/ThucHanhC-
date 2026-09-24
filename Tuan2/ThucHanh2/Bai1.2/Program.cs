using System;

//Hàm main chạy lệnh Chương trình
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; //Để in chữ tiếng việt

        // 1. Nhập tọa độ 2 điểm
        Point A = new Point();
        Point B = new Point();

        Console.WriteLine("Nhập tọa độ điểm A:");
        A.Input();
        
        Console.WriteLine("Nhập tọa độ điểm B:");
        B.Input();

        // 2. Xuất điểm và test Override ToString()
        Console.WriteLine("Thông tin điểm A và B");
        Console.Write("Điểm A: "); A.Output();
        Console.Write("Điểm B: "); B.Output();

        // 3. Test toán tử (+, -, âm)
        Console.WriteLine("Toán tử");
        Point C = A + B;
        Console.WriteLine($"A + B = {C}");
        
        Point D = A - B;
        Console.WriteLine($"A - B = {D}");
        
        Point AmA = -A;
        Console.WriteLine($"Điểm đối xứng của A (-A) = {AmA}");

        // 4. Test Khoảng cách (Cách a)
        Console.WriteLine("Khoảng cách của A và B");
        Console.WriteLine($"Dùng phương thức thành viên: {A.Distance(B):F2}");
        Console.WriteLine($"Dùng phương thức tĩnh      : {Point.Distance(A, B):F2}");

        // 5. Test Trung điểm (Cách b)
        Console.WriteLine("Trung điểm A và B");
        Console.WriteLine($"Dùng phương thức thành viên: {A.Midpoint(B)}");
        Console.WriteLine($"Dùng phương thức tĩnh      : {Point.Midpoint(A, B)}");
    }
}