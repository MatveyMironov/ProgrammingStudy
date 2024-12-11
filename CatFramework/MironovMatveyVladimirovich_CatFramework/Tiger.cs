public class Tiger : Cat
{
    protected double Weight { get; }
    protected override int Fluffines { get; }

    public Tiger(double weight, int fluffines = 50)
    {
        if (weight <= 75.0 || 140.0 <= weight)
        {
            if (fluffines <= 0 || 100 <= fluffines)
            {
                throw new CatException($"Unable tocreate a tiger with weight: {weight} and flufines: {fluffines}");
            }
            else
            {
                throw new CatException($"Unable to create a tiger with weight: {weight}");
            }
        }
        if (fluffines <= 0 || 100 <= fluffines)
        {
            throw new CatException($"Unable to create a tiger with flufines: {fluffines}");
        }

        Weight = weight;
        Fluffines = fluffines;
    }

    public override string FluffinesCheck()
    {
        return "Kycb!";
    }

    public override string ToString()
    {
        return $"A tiger with weight: {Weight} fluffines: {Fluffines}";
    }
}
