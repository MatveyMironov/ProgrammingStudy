using System.Numerics;

namespace Generics_Boxing_Unboxing;

public class Rectangle<T1, T2> : Figure
{
    private T1 width;
    private T2 height;

    public Rectangle(Vector2 center, T1 width, T2 height) : base(center)
    {
        this.width = width;
        this.height = height;
    }

    public override Vector2 MinPoint { get { return new Vector2(Center.X - (float)Convert.ToDouble(width) / 2, Center.Y + (float)Convert.ToDouble(height) / 2); } }
    public override Vector2 MaxPoint { get { return new Vector2(Center.X + (float)Convert.ToDouble(width) / 2, Center.Y - (float)Convert.ToDouble(height) / 2); } }
}
