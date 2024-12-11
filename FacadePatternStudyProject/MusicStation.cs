namespace FacadePatternStudyProject
{
    internal class MusicStation
    {
        public MusicStation()
        {
            Music = "";
        }

        public bool IsTurnedOn { get; private set; }

        public string Music { get; private set; }

        public void Switch()
        {
            IsTurnedOn = !IsTurnedOn;
        }

        public void SetMusic(string newMusic)
        {
            Music = newMusic;
        }

        public override string ToString()
        {
            return $"Is Turnd On: {IsTurnedOn}, Music: {Music}";
        }
    }
}
