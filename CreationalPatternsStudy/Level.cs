namespace CreationalPatternsStudy
{
    internal class Level
    {
        public Level(int spawnedBees, int spawnedWolfs, int spawnedBears)
        {
            SpawnedBees = spawnedBees;
            SpawnedWolfs = spawnedWolfs;
            SpawnedBears = spawnedBears;
        }

        public int SpawnedBees { get; private set; }
        public int SpawnedWolfs { get; private set; }
        public int SpawnedBears { get; private set; }

        public override string ToString()
        {
            string levelInfo = string.Empty;

            if (SpawnedBees > 0)
            {
                levelInfo += $"Bees: {SpawnedBees} \r\n";
            }
            if (SpawnedWolfs > 0)
            {
                levelInfo += $"Wolfs: {SpawnedWolfs} \r\n";
            }
            if (SpawnedBears > 0)
            {
                levelInfo += $"Bears: {SpawnedBears} \r\n";
            }

            return levelInfo;
        }
    }
}
