interface IShape
{
    double CalculatePerimeter(); //Метод для вычисления периметра объекта
    double CalculateArea(); //Метод для вычисления площади объекта
}

//Прямоугольник
class Rectangle : IShape
{
    //Свойства: ширина и высота прямоугольника
    public double Width { get; set; }
    public double Height { get; set; }

    //Вычисляем площадь прямоугольника
    public double CalculateArea()
    {
        return Width * Height;
    }

    //Вычисляем периметр прямоугольника
    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

//Круг
class Circle : IShape
{
    //Свойства: радиус круга
    public double Radius { get; set; }

    //Вычисляем площадь круга
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    //Вычисляем периметр круга
    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

//Треугольник
class Triangle : IShape
{
    //Свойства: 3 стороны треугольника
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    //Вычисляем площадь треугольника
    public double CalculateArea()
    {
        double p = (Side1 + Side2 + Side3) / 2; // Полупериметр
        return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3)); // Формула Герона

    }

    //Вычисляем периметр треугольника
    public double CalculatePerimeter()
    {
        return Side1 + Side2 + Side3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Создаем экземляры классов прямоугольник, круг, треугольник
        Rectangle rectangle = new Rectangle { Width = 5, Height = 3 };
        Circle circle = new Circle { Radius = 5 };
        Triangle triangle = new Triangle { Side1 = 3, Side2 = 4, Side3 = 5 };

        Console.WriteLine("Прямоугольник:");
        Console.WriteLine($"Периметр: {rectangle.CalculatePerimeter()}");
        Console.WriteLine($"Площадь: {rectangle.CalculateArea()}\n");

        Console.WriteLine("Круг:");
        Console.WriteLine($"Длина окружности: {circle.CalculatePerimeter()}");
        Console.WriteLine($"Площадь: {circle.CalculateArea()}\n");

        Console.WriteLine("Треугольник:");
        Console.WriteLine($"Периметр: {triangle.CalculatePerimeter()}");
        Console.WriteLine($"Площадь: {triangle.CalculateArea()}\n");
    }
}
