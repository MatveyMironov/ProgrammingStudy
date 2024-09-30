using System.Numerics;

namespace Generics_Boxing_Unboxing;

public class Figure
{
    protected Vector2 Center;

    public Figure(Vector2 center)
    {
        Center = center;
    }

    public virtual Vector2 MinPoint { get; }
    public virtual Vector2 MaxPoint { get; }
}
