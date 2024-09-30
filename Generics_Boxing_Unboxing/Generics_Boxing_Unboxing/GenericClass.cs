namespace Generics_Boxing_Unboxing;

internal class GenericClass <T>
{
    public GenericClass(T value)
    {
        Value = value;
    }

    public T? Value { get; private set; }

    public void Reset()
    {
        Value = default;
    }
}
