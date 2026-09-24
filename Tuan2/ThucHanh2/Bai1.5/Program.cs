class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Khởi tạo đơn thức P(x) = 3x^4
        DonThuc P = new DonThuc(3, 4);
        
        Console.WriteLine($"Đơn thức P(x) = {P}");

        // (a) Tính giá trị P(x) tại x = 2
        double x = 2;
        double giaTri = P.TinhGiaTri(x);
        Console.WriteLine($"-> Giá trị của P({x}) = 3 * ({x})^4 = {giaTri}");

        // (b) Đạo hàm của P(x)
        DonThuc Q = P.DaoHam();
        Console.WriteLine($"-> Đạo hàm P'(x) = Q(x) = {Q}");

        // Test thêm đạo hàm bậc 2 (Đạo hàm của Q)
        DonThuc H = Q.DaoHam();
        Console.WriteLine($"-> Đạo hàm bậc 2 P''(x) = {H}");

        // Test với một hằng số P(x) = 5
        DonThuc HangSo = new DonThuc(5, 0);
        Console.WriteLine($"\nĐơn thức hằng: P(x) = {HangSo}");
        Console.WriteLine($"-> Đạo hàm: P'(x) = {HangSo.DaoHam()}");
    }
}