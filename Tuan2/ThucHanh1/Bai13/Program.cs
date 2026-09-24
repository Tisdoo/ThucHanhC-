using System;

// Xây dựng lớp SinhVien
class SinhVien
{
    // Các thuộc tính của sinh viên
    public string MaSV;
    public string HoTen;
    public string DiaChi;
    public int NamHoc;

    // Hàm nhập thông tin
    public void Nhap()
    {
        Console.WriteLine("--- NHAP THONG TIN SINH VIEN ---");
        Console.Write("Nhap ma sinh vien: ");
        MaSV = Console.ReadLine();
        
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();
        
        Console.Write("Nhap dia chi: ");
        DiaChi = Console.ReadLine();
        
        Console.Write("Sinh vien nam thu may: ");
        NamHoc = int.Parse(Console.ReadLine());
    }

    // Hàm xuất thông tin
    public void Xuat()
    {
        Console.WriteLine("\n--- THONG TIN SINH VIEN VUA NHAP ---");
        Console.WriteLine($"Ma sinh vien : {MaSV}");
        Console.WriteLine($"Ho va ten    : {HoTen}");
        Console.WriteLine($"Dia chi      : {DiaChi}");
        Console.WriteLine($"Sinh vien nam: {NamHoc}");
    }
}

class Program13
{
    static void Main()
    {
        SinhVien sv = new SinhVien();
        sv.Nhap();
        sv.Xuat();
    }
}