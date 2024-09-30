using System.Numerics;

namespace Generics_Boxing_Unboxing;

internal class Square<T> : Figure
{
    private T side;

    public Square(Vector2 center, T side) : base(center)
    {
        this.side = side;
    }

    public override Vector2 MinPoint { get { return new Vector2(Center.X - (float)Convert.ToDouble(side) / 2, Center.Y + (float)Convert.ToDouble(side) / 2); } }
    public override Vector2 MaxPoint { get { return new Vector2(Center.X + (float)Convert.ToDouble(side) / 2, Center.Y - (float)Convert.ToDouble(side) / 2); } }
}
