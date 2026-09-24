class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // 1. Khởi tạo danh sách và nhập dữ liệu
        PersonList quanLyNhanKhau = new PersonList();
        quanLyNhanKhau.Input();

        // 2. In ra toàn bộ danh sách vừa nhập
        Console.WriteLine("\n==================================");
        Console.WriteLine("DANH SÁCH NHÂN KHẨU VỪA NHẬP:");
        quanLyNhanKhau.Output();

        // 3. Lọc và in ra những người còn sống
        Console.WriteLine("\n==================================");
        Console.WriteLine("DANH SÁCH NHỮNG NGƯỜI CÒN SỐNG:");
        
        PersonList chiNhungNguoiConSong = quanLyNhanKhau.LivingPeople();
        chiNhungNguoiConSong.Output();
    }
}