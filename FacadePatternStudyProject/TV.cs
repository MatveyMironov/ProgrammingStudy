namespace FacadePatternStudyProject
{
    internal class TV
    {
        public TV()
        {
            ActiveProgram = "";
        }

        public bool IsTurnedOn { get; private set; }

        public string ActiveProgram { get; private set; }

        public void SwitchTV()
        {
            IsTurnedOn = !IsTurnedOn;
        }

        public void TurnOnProgram(string program)
        {
            ActiveProgram = program;
        }

        public override string ToString()
        {
            return $"Is Turnd On: {IsTurnedOn}, Active Program: {ActiveProgram}";
        }
    }
}
