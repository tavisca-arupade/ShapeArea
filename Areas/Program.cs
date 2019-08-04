using System;

namespace Areas
{

    class Program
    {

        static void Main(string[] args)
        {

            Square square = new Square(2);
            square.CalculateArea();

            Rectangle rectangle = new Rectangle(10, 2);
            rectangle.CalculateArea();

            Trianlge trianlge = new Trianlge(10, 5);
            trianlge.CalculateArea();

            Circle circle = new Circle(10);
            circle.CalculateArea();

            Console.ReadKey();
            
        }
    }
}
