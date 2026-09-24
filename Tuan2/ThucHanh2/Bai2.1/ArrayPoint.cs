using System;
class ArrayPoint
{
    // 1. Field: Một ArrayList lưu trữ các Point
    private ArrayList danhSach;

    // Constructor khởi tạo ArrayList
    public ArrayPoint()
    {
        danhSach = new ArrayList();
    }

    // Phương thức phụ: Thêm Point vào danh sách (Cần có để test)
    public void Add(Point p)
    {
        danhSach.Add(p);
    }

    // Thuộc tính phụ: Lấy số lượng phần tử đang có
    public int Count
    {
        get { return danhSach.Count; }
    }

   
    public Point this[int i]
    {
        get
        {
            // ArrayList lưu dữ liệu dưới dạng 'object' chung chung,
            // nên khi lấy ra (get) bắt buộc phải ép kiểu về (Point)
            return (Point)danhSach[i];
        }
        set
        {
            // Ghi đè hoặc gán giá trị mới tại vị trí thứ i
            danhSach[i] = value;
        }
    }
}