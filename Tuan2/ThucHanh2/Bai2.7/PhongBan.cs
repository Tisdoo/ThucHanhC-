using System;
//LỚP PHÒNG BAN
class PhongBan
{
    private NhanVien[] dsNhanVien; // Mảng lưu trữ nhân viên
    private int n;                 // Số lượng nhân viên

    // Hàm nhập danh sách nhân viên của phòng ban
    public void Nhap()
    {
        Console.Write("Nhập số lượng nhân viên của phòng ban (n): ");
        n = int.Parse(Console.ReadLine());

        // Khởi tạo mảng với n phần tử
        dsNhanVien = new NhanVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhập thông tin nhân viên thứ {i + 1} ---");
            dsNhanVien[i] = new NhanVien(); //  khởi tạo đối tượng 
            dsNhanVien[i].Nhap();
        }
    }

    // Hàm xuất danh sách nhân viên
    public void Xuat()
    {
        if (n == 0)
        {
            Console.WriteLine("Phòng ban chưa có nhân viên nào.");
            return;
        }

        Console.WriteLine("\n================= DANH SÁCH NHÂN VIÊN PHÒNG BAN =================");
        for (int i = 0; i < n; i++)
        {
            dsNhanVien[i].Xuat();
        }
        Console.WriteLine("=================================================================");
    }

    // Hàm TÍNH TỔNG LƯƠNG của cả phòng ban
    public double TinhTongLuong()
    {
        double tongLuong = 0;
        
        for (int i = 0; i < n; i++)
        {
            // Cộng dồn lương thực lãnh của từng nhân viên
            tongLuong += dsNhanVien[i].TinhLuong();
        }
        
        return tongLuong;
    }
}
