using System;
class NhanVien
{
    public string HoTen;
    public double MucLuong;
   
    public int NgayVang;
public void Nhap()
    {
        Console.Write("Nhap ho ten nhan vien: ");
        HoTen=Console.ReadLine();
        Console.Write("Nhap vao Muc Luong: ");
        MucLuong=double.Parse(Console.ReadLine());
        Console.Write("Nhap vao so ngay vang: ");
        NgayVang=int.Parse(Console.ReadLine());

    }
public double TinhLuong(double luong,int vang)
    {
       double TienTru=100000*NgayVang;
       double ThucLanh=luong-TienTru;
       if(luong<TienTru)
        {
            return 0;
        }return ThucLanh;
    }
}
class Program
{
    public static void Main(String [] args)
    {
        NhanVien nv=new NhanVien();
        nv.Nhap();
        Console.Write("Luong thuc lanh cua nhan vien {0} là {1}",nv.HoTen,nv.TinhLuong(nv.MucLuong,nv.NgayVang));
    }
}