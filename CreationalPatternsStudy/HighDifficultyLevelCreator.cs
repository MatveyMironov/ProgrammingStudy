namespace CreationalPatternsStudy
{
    internal class HighDifficultyLevelCreator : LevelCreator
    {
        public override int EnemiesCount { get; protected set; } = 20;

        public override Level CreateLevel()
        {
            Random random = new Random();

            int spawnedBees = random.Next(1, EnemiesCount - 2);
            int spawnedWolfs = random.Next(1, EnemiesCount - spawnedBees);
            int spawnedBears = EnemiesCount - spawnedBees - spawnedWolfs;

            return new Level(spawnedBees, spawnedWolfs, spawnedBears);
        }
    }
}
