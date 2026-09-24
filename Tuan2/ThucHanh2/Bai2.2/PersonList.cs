
class PersonList

{
    // Dữ liệu thành viên: Sử dụng List động để lưu trữ không giới hạn số người
    private List<Person> danhSach;

    // 1. Default Constructor: Khởi tạo danh sách rỗng
    public PersonList()
    {
        danhSach = new List<Person>();
    }

    // 2. Copy Constructor: Sao chép sâu (Deep Copy) toàn bộ danh sách
    public PersonList(PersonList other)
    {
        danhSach = new List<Person>();
        foreach (Person p in other.danhSach)
        {
            // Tận dụng Copy Constructor của lớp Person
            this.danhSach.Add(new Person(p));
        }
    }

    // 3. Phương thức Add(): Thêm 1 người vào danh sách
    public void Add(Person x)
    {
        danhSach.Add(x);
    }

    // 4. Phương thức Input(): Nhập danh sách nhiều người
    public void Input()
    {
        Console.Write("Nhập số lượng nhân khẩu muốn thêm: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhập thông tin người thứ {i + 1} ---");
            Person p = new Person();
            p.Input();
            this.Add(p); // Gọi phương thức Add() để đưa vào danh sách
        }
    }

    // 5. Phương thức Output(): Xuất toàn bộ danh sách
    public void Output()
    {
        if (danhSach.Count == 0)
        {
            Console.WriteLine("Danh sách hiện đang trống.");
            return;
        }

        for (int i = 0; i < danhSach.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            danhSach[i].Output();
        }
    }

    // 6. Phương thức LivingPeople(): Trả về danh sách những người còn sống
    public PersonList LivingPeople()
    {
        PersonList listConSong = new PersonList();
        
        foreach (Person p in this.danhSach)
        {
            if (p.IsLiving())
            {
                listConSong.Add(p);
            }
        }
        
        return listConSong;
    }
}