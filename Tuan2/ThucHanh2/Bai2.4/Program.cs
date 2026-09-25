class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // 1. Khởi tạo và Nhập / Xuất mảng 2 chiều
        Mang2Chieu matrix = new Mang2Chieu();
        matrix.Nhap();
        matrix.Xuat();

        // 2. Test Indexer (i, j)
        Console.WriteLine("\n--- KIỂM TRA INDEXER ---");
        if (matrix.Rows > 0 && matrix.Cols > 0)
        {
            Console.WriteLine($"Phần tử ở góc trên bên trái [0, 0] là: {matrix[0, 0]}");
            
            Console.WriteLine("Đổi giá trị phần tử [0, 0] thành 999...");
            matrix[0, 0] = 999; 
            matrix.Xuat();
        }

        // 3. Test Tìm các số nguyên tố
        Console.WriteLine("\n--- TÌM SỐ NGUYÊN TỐ ---");
        List<int> danhSachNT = matrix.TimSoNguyenTo();

        if (danhSachNT.Count > 0)
        {
            Console.Write("Các số nguyên tố có trong mảng là: ");
            foreach (int so in danhSachNT)
            {
                Console.Write(so + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Không tìm thấy số nguyên tố nào trong mảng.");
        }
    }
}