namespace Abstraction_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //var shape = new IShape();
            var circle = new Circle { Radius = 5 };
            Console.WriteLine(circle.CalculateArea());


            var rectangle = new Rectangle { Length = 10, Width = 5 };
            Console.WriteLine(rectangle.CalculateArea());
        }
    }

    public interface IShape
    {
        double CalculateArea();
    }

    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            return Length * Width;
        }

    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
