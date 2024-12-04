public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many cats do you want to create?");
        uint catCount = uint.Parse(Console.ReadLine());

        Console.WriteLine();
        Cat[] cats = GenerateRandomCats(catCount);

        Console.WriteLine();
        DisplayCatInfo(cats, "1");
    }

    private static Cat[] GenerateRandomCats(uint count)
    {
        Cat[] cats = new Cat[count];

        Random rnd = new Random();

        for (int i = 0; i < count; i++)
        {
            Cat cat;
            bool successfull = false;

            while (!successfull)
            {
                successfull = true;

                int fluffines = rnd.Next(-20, 140);

                int a = rnd.Next(2);
                if (a == 0)
                {
                    double weight = rnd.Next(50, 160);

                    try
                    {
                        cat = new Tiger(weight, fluffines);
                        cats[i] = cat;
                    }
                    catch (CatException exception)
                    {
                        Console.WriteLine(exception.Message);
                        successfull = false;
                    }

                }
                else
                {
                    try
                    {
                        cat = new CuteCat(fluffines);
                        cats[i] = cat;
                    }
                    catch (CatException exception)
                    {
                        Console.WriteLine(exception.Message);
                        successfull = false;
                    }
                }
            }
        }

        return cats;
    }

    private static void DisplayCatInfo(Cat[] catsArr, string path)
    {
        foreach (Cat cat in catsArr)
        {
            string catInfo = $"{cat.FluffinesCheck()} {cat.ToString()}";

            Console.WriteLine(catInfo);
        }
    }
}