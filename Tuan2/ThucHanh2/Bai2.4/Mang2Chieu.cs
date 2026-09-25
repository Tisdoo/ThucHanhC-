using System;
using System.Collections.Generic;

// Xây dựng lớp Mảng 2 chiều (Ma trận)
class Mang2Chieu
{
    // Dữ liệu thành viên: mảng 2 chiều và kích thước n (dòng), m (cột)
    private int[,] data;
    private int n; // Số dòng
    private int m; // Số cột

   
    // a. CÁC LOẠI CONSTRUCTOR
   
    
    // 1. Constructor mặc định (Tạo mảng rỗng 0x0)
    public Mang2Chieu()
    {
        n = 0;
        m = 0;
        data = new int[0, 0];
    }

    // 2. Constructor tạo mảng với kích thước n x m cho trước
    public Mang2Chieu(int rows, int cols)
    {
        n = rows;
        m = cols;
        data = new int[n, m];
    }

    // 3. Constructor sao chép từ một mảng 2 chiều có sẵn
    public Mang2Chieu(int[,] mangCoSan)
    {
        n = mangCoSan.GetLength(0); // Lấy số dòng
        m = mangCoSan.GetLength(1); // Lấy số cột
        data = new int[n, m];
        Array.Copy(mangCoSan, data, mangCoSan.Length);
    }

    
    // b. Truy cập phần tử tại (i, j)
   
    public int this[int i, int j]
    {
        get
        {
            if (i >= 0 && i < n && j >= 0 && j < m)
                return data[i, j];
            throw new IndexOutOfRangeException("Lỗi: Chỉ số (i, j) vượt quá giới hạn của mảng.");
        }
        set
        {
            if (i >= 0 && i < n && j >= 0 && j < m)
                data[i, j] = value;
            else
                throw new IndexOutOfRangeException("Lỗi: Chỉ số (i, j) vượt quá giới hạn của mảng.");
        }
    }

    // Thuộc tính phụ để lấy số dòng và số cột
    public int Rows => n;
    public int Cols => m;

    
    // c. NHẬP / XUẤT MẢNG
    
    public void Nhap()
    {
        Console.Write("Nhập số dòng (n): ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Nhập số cột (m): ");
        m = int.Parse(Console.ReadLine());

        // Khởi tạo lại bộ nhớ theo kích thước mới
        data = new int[n, m];

        Console.WriteLine("--- NHẬP CÁC PHẦN TỬ ---");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Nhập phần tử [{i},{j}]: ");
                data[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void Xuat()
    {
        if (n == 0 || m == 0)
        {
            Console.WriteLine("Mảng hiện đang rỗng.");
            return;
        }

        Console.WriteLine("\n--- NỘI DUNG MẢNG 2 CHIỀU ---");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                // In định dạng căn lề phải 5 ký tự để ma trận hiện ngay ngắn
                Console.Write($"{data[i, j], 5}"); 
            }
            Console.WriteLine();
        }
    }

    // d. TÌM CÁC SỐ NGUYÊN TỐ
    
    //  kiểm tra 1 số có phải số nguyên tố không
    private bool KiemTraNguyenTo(int so)
    {
        if (so < 2) return false;
        for (int i = 2; i <= Math.Sqrt(so); i++)
        {
            if (so % i == 0) return false;
        }
        return true;
    }

    //  Lọc ra các số nguyên tố trong mảng
    public List<int> TimSoNguyenTo()
    {
        List<int> ketQua = new List<int>();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (KiemTraNguyenTo(data[i, j]))
                {
                    ketQua.Add(data[i, j]);
                }
            }
        }
        return ketQua;
    }
}

