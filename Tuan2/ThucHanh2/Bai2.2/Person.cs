using System;

// Định nghĩa lớp Person
class Person
{
    // Các Trường dữ liệu (Fields)
    private string id;
    private string name;
    private int yob; // Năm sinh
    private int yod; // Năm mất

    // 1. Khởi tạo mặc định
    public Person()
    {
        id = "";
        name = "";
        yob = 0;
        yod = 0;
    }

    // 2. Copy Constructor 
   
    public Person(Person other)
    {
        this.id = other.id;
        this.name = other.name;
        this.yob = other.yob;
        this.yod = other.yod;
    }

    // 3. Phương thức Input()
    public void Input()
    {
        Console.Write("Nhập ID: ");
        id = Console.ReadLine();
        
        Console.Write("Nhập họ tên: ");
        name = Console.ReadLine();
        
        Console.Write("Nhập năm sinh (yob): ");
        yob = int.Parse(Console.ReadLine());
        
        Console.Write("Nhập năm mất (yod) - Nhập 0 nếu còn sống: ");
        yod = int.Parse(Console.ReadLine());
    }

    // 4. Phương thức IsLiving()
    public bool IsLiving()
    {
        // Trả về true nếu yod bằng 0 (còn sống), ngược lại trả về false (đã mất)
        return yod == 0;
    }

    // 5. Phương thức Output()
    public void Output()
    {
        string trangThai = IsLiving() ? "Còn sống" : yod.ToString();
        
        Console.WriteLine($"ID: {id} | Họ tên: {name} | Năm sinh: {yob} | Năm mất: {trangThai}");
    }
}

