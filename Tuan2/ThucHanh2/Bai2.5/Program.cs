class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // 1. Test Khởi tạo và Nhập Xuất
        Console.WriteLine("--- TẠO VÀ NHẬP ĐA THỨC ---");
        DaThuc P = new DaThuc();
        P.Nhap();
        
        Console.WriteLine("\n--- ĐA THỨC VỪA NHẬP ---");
        P.Xuat();

        // 2. Test Tính giá trị với x nhập từ bàn phím
        Console.WriteLine("\n--- TÍNH GIÁ TRỊ ĐA THỨC ---");
        Console.Write("Nhập giá trị của x: ");
        double x = double.Parse(Console.ReadLine());
        
        double ketQua = P.TinhGiaTri(x);
        Console.WriteLine($"=> Giá trị của P({x}) = {ketQua}");

        // 3. Test Indexer (Truy cập và sửa đổi Đơn thức thứ i)
        Console.WriteLine("\n--- KIỂM TRA INDEXER ---");
        Console.WriteLine($"Hệ số của đơn thức bậc 1 (x^1) hiện tại là: {P[1].a}");
        
        Console.WriteLine("Đổi hệ số của x^1 thành 99...");
        P[1] = new DonThuc(99, 1);
        P.Xuat();
    }
}