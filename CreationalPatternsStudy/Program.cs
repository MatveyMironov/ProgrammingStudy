namespace CreationalPatternsStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LevelCreator LevelCreator = new LowDifficultyLevelCreator();

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == string.Empty)
                {
                    Console.WriteLine("Your input is empty");

                    continue;
                }
                else
                {
                    if (int.Parse(input) == 1)
                    {
                        LevelCreator = new LowDifficultyLevelCreator();
                    }
                    else if (int.Parse(input) == 2)
                    {
                        LevelCreator = new MediumDifficultyLevelCreator();
                    }
                    else if (int.Parse(input) == 3)
                    {
                        LevelCreator = new HighDifficultyLevelCreator();
                    }
                    else
                    {
                        Console.WriteLine("Your input is invalid");

                        continue;
                    }
                }

                Level level = LevelCreator.CreateLevel();
                Console.WriteLine(level.ToString());
            }
        }
    }
}
