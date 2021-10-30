public class InterfaceSegregation
{
    public interface Shape
    {
        public double getArea();
    }
    public interface Square extends Shape
    {
        public double getSideLength();
    }
    public interface Circle extends Shape
    {
        public double getCircumference();
    }
    public class SquareImpl implements Square
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
        public double getSideLength()
        {
            return sideLength;
        }
    }
    public class CircleImpl implements Circle
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