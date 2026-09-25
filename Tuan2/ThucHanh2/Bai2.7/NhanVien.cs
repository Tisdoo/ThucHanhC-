using System;

// LỚP NHÂN VIÊN

class NhanVien
{
    public string HoTen { get; set; }
    public double MucLuong { get; set; }
    public int SoNgayVang { get; set; }

    // Hàm nhập thông tin 1 nhân viên
    public void Nhap()
    {
        Console.Write("  Nhập họ tên: ");
        HoTen = Console.ReadLine();
        
        Console.Write("  Nhập mức lương cơ bản (VNĐ): ");
        MucLuong = double.Parse(Console.ReadLine());
        
        Console.Write("  Nhập số ngày vắng: ");
        SoNgayVang = int.Parse(Console.ReadLine());
    }

    // Hàm tính lương cho 1 nhân viên
    public double TinhLuong()
    {
        // 1 ngày vắng trừ 100.000 VNĐ
        double tienTru = SoNgayVang * 100000;
        double luongThucLanh = MucLuong - tienTru;

        // Đảm bảo lương không bị âm nếu vắng quá nhiều
        return (luongThucLanh > 0) ? luongThucLanh : 0;
    }

    // Hàm xuất thông tin 1 nhân viên
    public void Xuat()
    {
        Console.WriteLine($"  - {HoTen,-20} | Lương CB: {MucLuong,12:N0} | Vắng: {SoNgayVang,2} | Thực lãnh: {TinhLuong(),12:N0} VNĐ");
    }
}



