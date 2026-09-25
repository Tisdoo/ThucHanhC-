using System;

// 1. LỚP PHÂN SỐ 
class PhanSo
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    public PhanSo(int tu, int mau)
    {
        if (mau == 0) throw new Exception("Mẫu số không được bằng 0!");
        TuSo = tu;
        MauSo = mau;
        RutGon();
    }

    // Hàm tìm Ước chung lớn nhất để rút gọn
    private int TimUCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a == 0 ? 1 : a;
    }

    // Hàm rút gọn phân số
    private void RutGon()
    {
        int ucln = TimUCLN(TuSo, MauSo);
        TuSo /= ucln;
        MauSo /= ucln;

        // Đẩy dấu trừ lên tử số nếu mẫu âm
        if (MauSo < 0)
        {
            TuSo = -TuSo;
            MauSo = -MauSo;
        }
    }

    // Nạp chồng toán tử CỘNG (+) 2 phân số
    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        int tuMoi = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
        int mauMoi = a.MauSo * b.MauSo;
        return new PhanSo(tuMoi, mauMoi);
    }

    // Xuất chuỗi phân số
    public override string ToString()
    {
        if (TuSo == 0) return "0";
        if (MauSo == 1) return TuSo.ToString();
        return $"{TuSo}/{MauSo}";
    }
}