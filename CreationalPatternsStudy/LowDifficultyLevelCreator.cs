namespace CreationalPatternsStudy
{
    internal class LowDifficultyLevelCreator : LevelCreator
    {
        public override int EnemiesCount { get; protected set; } = 10;

        public override Level CreateLevel()
        {
            Random random = new Random();
            return new Level(EnemiesCount, 0, 0);
        }
    }
}
