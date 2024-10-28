namespace CreationalPatternsStudy
{
    internal abstract class LevelCreator
    {
        public abstract int EnemiesCount { get; protected set; }

        public abstract Level CreateLevel();
    }
}
