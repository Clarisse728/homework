using System;

// 定义形状接口
public interface IShape
{
    double GetArea();
}

// 定义圆形类
public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// 定义矩形类
public class Rectangle : IShape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double GetArea()
    {
        return width * height;
    }
}

// 定义三角形类
public class Triangle : IShape
{
    private double baseLength;
    private double height;

    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public double GetArea()
    {
        return 0.5 * baseLength * height;
    }
}

// 简单工厂类
public class ShapeFactory
{
    public static IShape CreateShape(string shapeType)
    {
        Random random = new Random();
        switch (shapeType)
        {
            case "Circle":
                return new Circle(random.NextDouble() * 10); // 随机半径，最大为10
            case "Rectangle":
                return new Rectangle(random.NextDouble() * 10, random.NextDouble() * 10); // 随机宽高，最大为10
            case "Triangle":
                return new Triangle(random.NextDouble() * 10, random.NextDouble() * 10); // 随机底和高，最大为10
            default:
                throw new ArgumentException("Unknown shape type");
        }
    }
}

// 主程序
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string[] shapeTypes = { "Circle", "Rectangle", "Triangle" };
        double totalArea = 0.0;

        for (int i = 0; i < 10; i++)
        {
            string randomShapeType = shapeTypes[random.Next(shapeTypes.Length)];
            IShape shape = ShapeFactory.CreateShape(randomShapeType);
            totalArea += shape.GetArea();
            Console.WriteLine($"Shape {i + 1}: {randomShapeType}, Area: {shape.GetArea():F2}");
        }

        Console.WriteLine($"Total Area: {totalArea:F2}");
    }
}