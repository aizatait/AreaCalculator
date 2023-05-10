using AreaCalculator.Abstractions;

namespace AreaCalculator.Shapes
{
    public class Triangle : IShape
    {
        internal readonly double _triangleBase;
        internal readonly double _height;

        public Triangle(double triangleBase, double height)
        {
            _triangleBase = triangleBase;
            _height = height;
        }

        public double CalculateArea()
        {
            return 0.5 * _triangleBase * _height;
        }
    }
}
