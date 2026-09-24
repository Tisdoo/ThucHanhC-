using System;

// Lớp đại diện cho Đơn thức P(x) = a * x^n
class DonThuc
{
    // Hệ số a (số thực)
    public double a { get; set; }

    // Số mũ n (số nguyên không âm)
    private int _n;
    public int n
    {
        get { return _n; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Lỗi: Số mũ n phải là số nguyên không âm (n >= 0).");
            _n = value;
        }
    }

    // Constructor mặc định
    public DonThuc()
    {
        a = 0;
        n = 0;
    }

    // Constructor có tham số
    public DonThuc(double heSo, int soMu)
    {
        a = heSo;
        n = soMu; // tự động gọi khối set để kiểm tra điều kiện >= 0
    }

    // (a) Tính giá trị đơn thức với x cho trước
   
    public double TinhGiaTri(double x)
    {
        return a * Math.Pow(x, n);
    }

    
    // (b) Đạo hàm đơn thức P'(x) = a * n * x^(n-1)
    
    public DonThuc DaoHam()
    {
        // Đạo hàm của hằng số (n = 0) luôn bằng 0
        if (n == 0)
        {
            return new DonThuc(0, 0); 
        }

        // Q(x) = (a * n) * x^(n - 1)
        return new DonThuc(a * n, n - 1);
    }
    // Override ToString để xuất đơn thức đẹp mắt
    public override string ToString()
    {
        if (a == 0) return "0";
        if (n == 0) return a.ToString(); // Hằng số

        // Xử lý hệ số (không in số 1 hoặc -1 đứng trước x)
        string heSoStr = (a == 1) ? "" : (a == -1) ? "-" : a.ToString();
        
        // Xử lý số mũ (không in mũ 1)
        string xStr = (n == 1) ? "x" : $"x^{n}";

        return $"{heSoStr}{xStr}";
    }
}