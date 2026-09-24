class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Test 1: Tạo đối tượng bằng Default Constructor và gọi Input()
        Console.WriteLine("Nhập thông tin người 1");
        Person p1 = new Person();
        p1.Input();

        // Test 2: Tạo đối tượng bằng Copy Constructor (Sao chép từ p1)
        Console.WriteLine("Nhập thông tin người 2");
        Person p2 = new Person(p1);

        // Xuất thông tin để kiểm tra
        Console.WriteLine("Kết quả test");
        Console.Write("Người 1: "); 
        p1.Output();
        
        Console.Write("Người 2 (Bản sao): "); 
        p2.Output();
    }
}