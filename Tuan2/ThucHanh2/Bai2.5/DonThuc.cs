using System;


// LỚP ĐƠN THỨC (Thành phần cấu tạo nên Đa thức)

class DonThuc
{
    public double a { get; set; } // Hệ số
    public int n { get; set; }    // Số mũ

    public DonThuc(double heSo, int soMu)
    {
        a = heSo;
        n = soMu;
    }

    public double TinhGiaTri(double x)
    {
        return a * Math.Pow(x, n);
    }
}