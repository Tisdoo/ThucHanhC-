class DanhSachPhanSo
{
    private PhanSo[] ds; // Mảng lưu trữ n phân số
    private int n;       // Số lượng phân số

    // Hàm nhập mảng phân số
    public void Nhap()
    {
        Console.Write("Nhập số lượng phân số (n): ");
        n = int.Parse(Console.ReadLine());
        ds = new PhanSo[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"--- Nhập phân số thứ {i + 1} ---");
            Console.Write("  Tử số: ");
            int tu = int.Parse(Console.ReadLine());
            
            Console.Write("  Mẫu số: ");
            int mau = int.Parse(Console.ReadLine());
            
            // Khởi tạo và lưu phân số vào mảng
            ds[i] = new PhanSo(tu, mau);
        }
    }

    // Hàm xuất mảng phân số
    public void Xuat()
    {
        if (n == 0)
        {
            Console.WriteLine("Danh sách rỗng.");
            return;
        }

        Console.Write("Các phân số trong danh sách: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(ds[i] + (i < n - 1 ? " ; " : ""));
        }
        Console.WriteLine();
    }

    // Hàm TÍNH TỔNG của n phân số
    public PhanSo TinhTong()
    {
        // Khởi tạo tổng ban đầu bằng 0 (tức là 0/1)
        PhanSo tong = new PhanSo(0, 1);

        for (int i = 0; i < n; i++)
        {
            // do đã nạp chồng nên có thể sử dụng toán tử cộng
            tong = tong + ds[i];
        }

        return tong;
    }
}