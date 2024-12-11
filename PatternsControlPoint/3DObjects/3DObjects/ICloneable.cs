namespace _3DObjects
{
    internal interface ICloneable<T> where T : ICloneable<T>
    {
        T Clone();
    }
}
