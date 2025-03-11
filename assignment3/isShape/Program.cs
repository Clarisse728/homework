using System;

// 抽象基类
public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract bool IsValid { get; }
}

// 长方形类
public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public double Length
    {
        get => _length;
        set => _length = value > 0 ? value :
            throw new ArgumentException("长度必须大于0");
    }

    public double Width
    {
        get => _width;
        set => _width = value > 0 ?
            value : throw new ArgumentException("宽度必须大于0");
    }

    public override double CalculateArea() => Length * Width;

    public override bool IsValid =>
        Length > 0 && Width > 0; // 实际已通过属性保证
}

// 正方形类（继承自长方形）
public class Square : Rectangle
{
    public double Side
    {
        get => base.Length;
        set
        {
            if (value <= 0)
                throw new ArgumentException("边长必须大于0");
            base.Length = base.Width = value;
        }
    }

    // 隐藏父类的长宽单独设置
    public new double Length
    {
        get => Side;
        set => Side = value;
    }

    public new double Width
    {
        get => Side;
        set => Side = value;
    }
}

// 三角形类
public class Triangle : Shape
{
    private double _a, _b, _c;

    public double A
    {
        get => _a;
        set => _a = ValidateSide(value);
    }

    public double B
    {
        get => _b;
        set => _b = ValidateSide(value);
    }

    public double C
    {
        get => _c;
        set => _c = ValidateSide(value);
    }

    private static double ValidateSide(double value) =>
        value > 0 ? value : throw new ArgumentException("边長必须大于0");

    public override bool IsValid
    {
        get
        {
            // 三角形不等式定理
            return A + B > C &&
                   A + C > B &&
                   B + C > A;
        }
    }

    public override double CalculateArea()
    {
        if (!IsValid)
            throw new InvalidOperationException("无效的三角形");

        // 海伦公式
        double s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }
}

// 使用示例
class Program
{
    static void Main()
    {
        // 长方形
        var rect = new Rectangle { Length = 5, Width = 3 };
        Console.WriteLine($"长方形面积: {rect.CalculateArea()}");

        // 正方形
        var square = new Square { Side = 4 };
        Console.WriteLine($"正方形面积: {square.CalculateArea()}");

        // 三角形
        var triangle = new Triangle { A = 3, B = 4, C = 5 };
        Console.WriteLine($"三角形面积: {triangle.CalculateArea()}");
    }
}
