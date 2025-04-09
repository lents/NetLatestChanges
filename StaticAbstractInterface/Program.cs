public interface IShape
{
    static abstract IShape Create(double parameter);
    double CalculateArea();
}

public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public static IShape Create(double radius) => new Circle(radius);

    public double CalculateArea()
    {
        throw new NotImplementedException();
    }
    // ...
}

public class Square : IShape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public static IShape Create(double side) => new Square(side);

    public double CalculateArea()
    {
        throw new NotImplementedException();
    }
    // ...
}
