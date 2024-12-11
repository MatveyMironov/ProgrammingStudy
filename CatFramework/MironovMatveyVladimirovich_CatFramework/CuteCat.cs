public class CuteCat : Cat
{
    protected override int Fluffines { get; }

    public CuteCat(int fluffines = 50)
    {
        if (fluffines <= 0 || 140 <= fluffines)
        {
            throw new CatException($"Unable to create a cute cat with flufines: {fluffines}");
        }

        Fluffines = fluffines;
    }

    public override string FluffinesCheck()
    {
        switch (Fluffines)
        {
            case int x when x == 0:
                return "Sphynx";

            case int x when 1 <= x && x <= 20:
                return "Slightly";

            case int x when 21 <= x && x <= 50:
                return "Medium";

            case int x when 51 <= x && x <= 75:
                return "Heavy";

            case int x when 75 <= x:
                return "OwO";

            default:
                return "?";
        }
    }

    public override string ToString()
    {
        return $"A cute cat with fluffines: {Fluffines}";
    }
}
