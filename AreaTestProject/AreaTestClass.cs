using System;
using Xunit;
using Areas;

namespace AreaTestProject
{
    public class AreaTestClass
    {
        [Fact]
        public void TestTOCalculateSquareArea()
        {
            Square square = new Square(10);

            Assert.Equal(100, square.CalculateArea());
        }

        [Fact]
        public void TestWhenCalculateSquareAeraWithNegativeParameter()
        {
            Square square = new Square(-10);

            Assert.Equal(0, square.CalculateArea());
        }

        [Fact]
        public void TestTOCalculateTriangleArea()
        {
            Trianlge triangle = new Trianlge(10,5);

            Assert.Equal(25, triangle.CalculateArea());
        }

        [Fact]
        public void TestTOCalculateCircleArea()
        {
            Circle circle = new Circle(5);

            Assert.Equal(78.5, circle.CalculateArea());
        }

        [Fact]
        public void TestTOCalculateRectangleArea()
        {
            Rectangle rectangle = new Rectangle(10,5);

            Assert.Equal(50, rectangle.CalculateArea());
        }

    }
}
