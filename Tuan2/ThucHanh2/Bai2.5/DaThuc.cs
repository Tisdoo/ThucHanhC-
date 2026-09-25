using System;


// LỚP ĐA THỨC: P(x) = a0*x^0 + a1*x^1 + ... + an*x^n

class DaThuc
{
    private DonThuc[] dsDonThuc; // Mảng chứa n+1 đơn thức
    private int bac;             // Bậc của đa thức (n)

    // a. CÁC LOẠI CONSTRUCTOR

    // 1. Constructor mặc định (Đa thức bậc 0: P(x) = 0)
    public DaThuc()
    {
        bac = 0;
        dsDonThuc = new DonThuc[1];
        dsDonThuc[0] = new DonThuc(0, 0);
    }

    // 2. Constructor khởi tạo Đa thức bậc n (các hệ số ban đầu = 0)
    public DaThuc(int n)
    {
        if (n < 0) throw new ArgumentException("Bậc của đa thức phải >= 0");

        bac = n;
        dsDonThuc = new DonThuc[bac + 1];

        // Khởi tạo sẵn n+1 đơn thức với hệ số = 0
        for (int i = 0; i <= bac; i++)
        {
            dsDonThuc[i] = new DonThuc(0, i);
        }
    }


    // b. INDEXER: Truy cập Đơn thức thứ i (ứng với x^i)

    public DonThuc this[int i]
    {
        get
        {
            if (i >= 0 && i <= bac)
                return dsDonThuc[i];
            throw new IndexOutOfRangeException("Lỗi: Bậc i không tồn tại trong đa thức.");
        }
        set
        {
            if (i >= 0 && i <= bac)
            {
                // Đảm bảo số mũ của đơn thức truyền vào khớp với vị trí i
                value.n = i;
                dsDonThuc[i] = value;
            }
            else
                throw new IndexOutOfRangeException("Lỗi: Bậc i không tồn tại trong đa thức.");
        }
    }


    // c. NHẬP / XUẤT ĐA THỨC

    public void Nhap()
    {
        Console.Write("Nhập bậc của đa thức (n): ");
        bac = int.Parse(Console.ReadLine());

        dsDonThuc = new DonThuc[bac + 1];

        Console.WriteLine($"Nhập các hệ số cho đa thức bậc {bac}:");
        for (int i = 0; i <= bac; i++)
        {
            Console.Write($"  - Nhập hệ số a{i} (cho x^{i}): ");
            double heSo = double.Parse(Console.ReadLine());
            dsDonThuc[i] = new DonThuc(heSo, i);
        }
    }

    public void Xuat()
    {
        Console.Write("P(x) = ");
        bool isFirst = true;
        bool isAllZero = true;

        // In từ bậc cao nhất (n) xuống bậc thấp nhất (0) cho thuận mắt toán học
        for (int i = bac; i >= 0; i--)
        {
            double heSo = dsDonThuc[i].a;
            if (heSo == 0) continue; // Bỏ qua các hạng tử có hệ số = 0

            isAllZero = false;

            // Xử lý dấu cộng/trừ
            if (heSo > 0 && !isFirst) Console.Write(" + ");
            if (heSo < 0) Console.Write(isFirst ? "-" : " - ");

            double absHeSo = Math.Abs(heSo);

            // In hệ số (không in số 1 nếu có biến x, trừ trường hợp bậc 0)
            if (absHeSo != 1 || i == 0)
                Console.Write(absHeSo);

            // In biến x và mũ
            if (i == 1) Console.Write("x");
            else if (i > 1) Console.Write($"x^{i}");

            isFirst = false;
        }

        if (isAllZero) Console.Write("0");
        Console.WriteLine();
    }

    // d. TÍNH GIÁ TRỊ ĐA THỨC TẠI x

    public double TinhGiaTri(double x)
    {
        double tong = 0;
        for (int i = 0; i <= bac; i++)
        {
            // Tận dụng hàm TinhGiaTri của lớp DonThuc
            tong += dsDonThuc[i].TinhGiaTri(x);
        }
        return tong;
    }
}