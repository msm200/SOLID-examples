public class InterfaceSegregation
{
    public interface Shape
    {
        public double getArea();
        public double getCircumference();
    }
    public class Square implements Shape
    {
        private double sideLength;
        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }
        public double getArea()
        {
            return sideLength * sideLength;
        }
        public double getCircumference()
        {
            throw new InvalidOperationException("Cannot get circumference of square");
        }
    }
    public class Circle implements Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double getArea()
        {
            return radius * radius * 3.14
        }
        public double getCircumference()
        {
            return 2 * 3.14 * radius;
        }
    }
}