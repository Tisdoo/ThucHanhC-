using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // 1. Khởi tạo đối tượng Phòng ban và nhập dữ liệu
        PhongBan pbIT = new PhongBan();
        pbIT.Nhap();

        // 2. Xuất danh sách để xem lại
        pbIT.Xuat();

        // 3. Tính và in ra tổng lương của phòng ban
        double tongChiPhi = pbIT.TinhTongLuong();
        
        Console.WriteLine($"\n=> TỔNG LƯƠNG PHÒNG BAN PHẢI CHI TRẢ LÀ: {tongChiPhi:N0} VNĐ");
        
        Console.ReadLine(); // Dừng màn hình để xem kết quả
    }
}