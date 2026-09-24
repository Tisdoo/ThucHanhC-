class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // 1. Kiểm tra khởi tạo (Constructor)
        PhanSo p1 = new PhanSo(1, 2);      // Tạo p1 = 1/2
        PhanSo p2 = new PhanSo(4, -6);     // Tạo p2 = 4/-6 => Tự động rút gọn thành -2/3
        PhanSo p3 = new PhanSo();          // default = 0
        PhanSo p4 = new PhanSo(p1);        // Sao chép từ p1 = 1/2

        Console.WriteLine($"Phân số p1: {p1}");
        Console.WriteLine($"Phân số p2: {p2}");
        Console.WriteLine($"Phân số p3 (Mặc nhiên): {p3}");
        Console.WriteLine($"Phân số p4 (Sao chép p1): {p4}\n");

        // 2. Toán tử 1 ngôi
        Console.WriteLine($"Toán tử một ngôi (+p1): {+p1}");
        Console.WriteLine($"Toán tử một ngôi (-p1): {-p1}\n");

        // 3. Toán tử 2 ngôi
        Console.WriteLine($"Cộng: {p1} + {p2} = {p1 + p2}");
        Console.WriteLine($"Trừ : {p1} - {p2} = {p1 - p2}");
        Console.WriteLine($"Nhân: {p1} * {p2} = {p1 * p2}");
        Console.WriteLine($"Chia: {p1} / {p2} = {p1 / p2}\n");

        // 4. Toán tử so sánh
        Console.WriteLine($"So sánh {p1} > {p2}  : {p1 > p2}");
        Console.WriteLine($"So sánh {p1} < {p2}  : {p1 < p2}");
        Console.WriteLine($"So sánh {p1} == {p4} : {p1 == p4}");
        Console.WriteLine($"So sánh {p1} != {p2} : {p1 != p2}");
    }
}