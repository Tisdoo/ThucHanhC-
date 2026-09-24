using System;

// Thiết kế lớp Point
class Point
{
    // 1. Field
    private double x;
    private double y;

    // 2. Property
    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    // 3. Constructor
    // Default constructor khởi tạo x, y = 0
    public Point()
    {
        x = 0;
        y = 0;
    }

    //Constructor có tham số 
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // 4. Method: Input và Output
    public void Input()
    {
        Console.Write("  Nhập x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("  Nhập y: ");
        y = double.Parse(Console.ReadLine());
    }

    public void Output()
    {
        Console.WriteLine(this.ToString());
    }

    // 5. Override hàm ToString()
    public override string ToString()
    {
        return $"({x}, {y})";
    }

    // 6. Phép cộng 2 điểm (+)
   
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }

    // Phép trừ 2 điểm (-)
    public static Point operator -(Point a, Point b)
    {
        return new Point(a.X - b.X, a.Y - b.Y);
    }

    // Phép lấy âm (-)
    public static Point operator -(Point a)
    {
        return new Point(-a.X, -a.Y);
    }

    // (a) Khoảng cách giữa 2 điểm
    
    public double Distance(Point other)
    {
        return Math.Sqrt(Math.Pow(this.x - other.x, 2) + Math.Pow(this.y - other.y, 2));
    }

    // Phương thức tĩnh
    public static double Distance(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
    }

    // (b) Trung điểm của 2 điểm
   
    public Point Midpoint(Point other)
    {
        return new Point((this.x + other.x) / 2, (this.y + other.y) / 2);
    }

    // Phương thức tĩnh
    public static Point Midpoint(Point p1, Point p2)
    {
        return new Point((p1.x + p2.x) / 2, (p1.y + p2.y) / 2);
    }
}


