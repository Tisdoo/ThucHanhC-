using System;
class SinhVien
{
    private string HoTen;
    private int NamSinh;
    public void TinhTuoi(int NamSinh,string HoTen)
    {
        
        int tuoi=DateTime.Now.Year-NamSinh;
Console.Write(" Tuoi cua sinh viên "+ HoTen+" là: "+tuoi);

    }

}class Program
{
    static void Main()
    {
        // 1. Khởi tạo đối tượng SinhVien
        SinhVien sv = new SinhVien();

        // 2. Nhập dữ liệu từ người dùng
        Console.Write("Nhap ho ten sinh vien: ");
        string ten = Console.ReadLine();

        Console.Write("Nhap nam sinh: ");
        int nam = int.Parse(Console.ReadLine());

        // 3. Gọi hàm TinhTuoi và truyền dữ liệu vừa nhập vào
        sv.TinhTuoi(nam, ten);
    }
}