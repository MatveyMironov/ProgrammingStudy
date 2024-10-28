namespace CreationalPatternsStudy
{
    internal class MediumDifficultyLevelCreator : LevelCreator
    {
        public override int EnemiesCount { get; protected set; } = 15;

        public override Level CreateLevel()
        {
            Random random = new Random();

            int spawnedBees = random.Next(1, EnemiesCount - 1);
            int spawnedWolfs = EnemiesCount - spawnedBees;

            return new Level(spawnedBees, spawnedWolfs, 0);
        }
    }
}
