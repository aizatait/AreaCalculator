using AreaCalculator.Abstractions;
using AreaCalculator.Extension;
using AreaCalculator.Shapes;

IShape[] shapes = {
                new Circle(5),
                new Triangle(4, 3),
                new Triangle(5, 2),
                new Rectangle(5, 3),
                new Square(4)
            };

foreach (IShape shape in shapes)
{
    if (shape is Triangle triangle)
    {
        Console.WriteLine("Area of Triangle is: " + triangle.CalculateArea());
        Console.WriteLine("Is right triangle? " + triangle.IsRightTriangle(5));
    }
    else
    {
        Console.WriteLine("Area of " + shape.GetType().Name + " is: " + shape.CalculateArea());
    }
}