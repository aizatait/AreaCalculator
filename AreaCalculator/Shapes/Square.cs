using AreaCalculator.Abstractions;

namespace AreaCalculator.Shapes
{
    public class Square : IShape
    {
        private readonly double _side;

        public Square(double side)
        {
            _side = side;
        }

        public double CalculateArea()
        {
            return Math.Pow(_side, 2);
        }
    }
}
