using System;

public class PhanSo
{
    private int tuSo;
    private int mauSo;
// Hàm tìm UCLN
    private static int TimUCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
//Ham rút gọn
    private void RutGon()
    {
        if (mauSo == 0)
            throw new Exception("Lỗi: Mẫu số không thể bằng 0.");

        int ucln = TimUCLN(tuSo, mauSo);
        tuSo /= ucln;
        mauSo /= ucln;

        // Chuẩn hóa dấu: Nếu mẫu âm thì chuyển dấu trừ lên tử số
        if (mauSo < 0)
        {
            tuSo = -tuSo;
            mauSo = -mauSo;
        }
    }

    // 1. CONSTRUCTOR    
    // Constructor default
    public PhanSo()
    {
        tuSo = 0;
        mauSo = 1;
    }

    // Constructor nhận cả tử và mẫu
    public PhanSo(int tu, int mau)
    {
        tuSo = tu;
        mauSo = mau;
        RutGon(); // Rút gọn ngay khi khởi tạo
    }

    // Constructor nhận 1 số nguyên (tạo phân số n/1)
    public PhanSo(int tu)
    {
        tuSo = tu;
        mauSo = 1;
    }

    // Constructor sao chép (Copy Constructor)
    public PhanSo(PhanSo p)
    {
        this.tuSo = p.tuSo;
        this.mauSo = p.mauSo;
    }
    // 2. OVERRIDE TOSTRING()
   
    public override string ToString()
    {
        if (tuSo == 0) return "0";
        if (mauSo == 1) return tuSo.ToString();
        return $"{tuSo}/{mauSo}";
    }

 // 3. OVERLOAD CÁC TOÁN TỬ (OPERATOR OVERLOADING)
    

    // --- Toán tử một ngôi ---
    public static PhanSo operator +(PhanSo a) => new PhanSo(a.tuSo, a.mauSo);
    public static PhanSo operator -(PhanSo a) => new PhanSo(-a.tuSo, a.mauSo);

    // --- Toán tử hai ngôi ---
    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        return new PhanSo(a.tuSo * b.mauSo + b.tuSo * a.mauSo, a.mauSo * b.mauSo);
    }

    public static PhanSo operator -(PhanSo a, PhanSo b)
    {
        return new PhanSo(a.tuSo * b.mauSo - b.tuSo * a.mauSo, a.mauSo * b.mauSo);
    }

    public static PhanSo operator *(PhanSo a, PhanSo b)
    {
        return new PhanSo(a.tuSo * b.tuSo, a.mauSo * b.mauSo);
    }

    public static PhanSo operator /(PhanSo a, PhanSo b)
    {
        return new PhanSo(a.tuSo * b.mauSo, a.mauSo * b.tuSo);
    }

    // --- Toán tử so sánh ---
    
       
    public static bool operator ==(PhanSo a, PhanSo b) => (a.tuSo * b.mauSo == b.tuSo * a.mauSo);
    
    public static bool operator !=(PhanSo a, PhanSo b) => !(a == b);
    
    public static bool operator >(PhanSo a, PhanSo b) => (a.tuSo * b.mauSo > b.tuSo * a.mauSo);
    
    public static bool operator <(PhanSo a, PhanSo b) => (a.tuSo * b.mauSo < b.tuSo * a.mauSo);
    
    public static bool operator >=(PhanSo a, PhanSo b) => (a.tuSo * b.mauSo >= b.tuSo * a.mauSo);
    
    public static bool operator <=(PhanSo a, PhanSo b) => (a.tuSo * b.mauSo <= b.tuSo * a.mauSo);

    // *Khi overload toán tử == và != trong C#, bắt buộc phải override Equals và GetHashCode để tránh cảnh báo
    public override bool Equals(object obj)
    {
        if (obj is PhanSo p) return this == p;
        return false;
    }

    public override int GetHashCode()
    {
        return tuSo.GetHashCode() ^ mauSo.GetHashCode();
    }
}

