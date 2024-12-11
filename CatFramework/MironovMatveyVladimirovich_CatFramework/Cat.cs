public abstract class Cat
{
    protected abstract int Fluffines { get; }

    public abstract string FluffinesCheck();

    public override string ToString()
    {
        return $"A cat with flaffiness {Fluffines}";
    }
}
