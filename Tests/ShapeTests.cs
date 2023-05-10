using AreaCalculator.Extension;
using AreaCalculator.Shapes;

namespace Tests
{
    public class ShapeTests
    {
        [Theory]
        [InlineData(5, 78.53981633974483)]
        [InlineData(12, 452.3893421169302)]
        public void CircleAreaTest(double radius, double expectedArea)
        {
            // Arrange
            Circle circle = new(radius);

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Theory]
        [InlineData(4, 16)]
        [InlineData(2, 4)]
        public void SquareAreaTest(double side, double expectedArea)
        {
            // Arrange
            Square square = new(side);

            // Act
            double actualArea = square.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(2, 4, 8)]
        public void RectangleAreaTest(double width, double height, double expectedArea)
        {
            // Arrange
            Rectangle rectangle = new(width, height);

            // Act
            double actualArea = rectangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Theory]
        [InlineData(4, 3, 5, 6, true)]
        [InlineData(2, 4, 3, 4, false)]
        public void TriangleAreaTest(double triangleBase, double height, double hypotenuse, double expectedArea, bool expectedIsRightTriangle)
        {
            // Arrange
            Triangle triangle = new(triangleBase, height);

            // Act
            double actualArea = triangle.CalculateArea();
            bool actualIsRightTriangle = triangle.IsRightTriangle(hypotenuse);

            // Assert
            Assert.Equal(expectedArea, actualArea);
            Assert.Equal(expectedIsRightTriangle, actualIsRightTriangle);
        }
    }
}
