
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Khởi tạo đối tượng ArrayPoint
        ArrayPoint tapHopDiem = new ArrayPoint();

        // Thêm một số điểm vào danh sách
        tapHopDiem.Add(new Point(1, 2));
        tapHopDiem.Add(new Point(3, 4));
        tapHopDiem.Add(new Point(5, 6));

        // TEST 1: Sử dụng Indexer để lấy ra Point thứ i (khối 'get' hoạt động)
        Console.WriteLine("--- TRUY CẬP BẰNG INDEXER [i] ---");
        Console.WriteLine($"Điểm ở vị trí [0]: {tapHopDiem[0]}");
        Console.WriteLine($"Điểm ở vị trí [1]: {tapHopDiem[1]}");

        // TEST 2: Sử dụng Indexer để sửa Point thứ i (khối 'set' hoạt động)
        Console.WriteLine("\n--- THAY ĐỔI GIÁ TRỊ BẰNG INDEXER [i] ---");
        tapHopDiem[2] = new Point(99, 99); // Thay điểm (5,6) thành (99,99)
        Console.WriteLine($"Điểm ở vị trí [2] sau khi sửa: {tapHopDiem[2]}");

        // TEST 3: Dùng vòng lặp for kết hợp Indexer để in toàn bộ
        Console.WriteLine("\n--- IN TOÀN BỘ DANH SÁCH ---");
        for (int i = 0; i < tapHopDiem.Count; i++)
        {
            Console.WriteLine($"Điểm [{i}]: {tapHopDiem[i]}");
        }
    }
}