using System.Numerics;

namespace Generics_Boxing_Unboxing;

public class Circle<T> : Figure
{
    public Circle(Vector2 center, T radius) : base(center)
    {
        Radius = radius;
    }

    public T Radius { get; private set; }
    public double Area { get { return Convert.ToDouble(Radius) * Convert.ToDouble(Radius) * Math.PI; } }

    public override Vector2 MinPoint { get { return new Vector2(Center.X - (float)(Convert.ToDouble(Radius) * Math.Cos(45)), Center.Y + (float)(Convert.ToDouble(Radius) * Math.Sin(45))); } }
    public override Vector2 MaxPoint { get { return new Vector2(Center.X + (float)(Convert.ToDouble(Radius) * Math.Cos(45)), Center.Y - (float)(Convert.ToDouble(Radius) * Math.Sin(45))); } }

    public void SetRadius(T radius)
    {
        Radius = radius;
    }
}
