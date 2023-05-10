using AreaCalculator.Shapes;

namespace AreaCalculator.Extension
{
    public static class TriangleExtensions
    {
        public static bool IsRightTriangle(this Triangle triangle, double hypotenuse)
        {
            double c = Math.Sqrt(Math.Pow(triangle._triangleBase, 2) + Math.Pow(triangle._height, 2));

            return hypotenuse == c;
        }
    }
}
