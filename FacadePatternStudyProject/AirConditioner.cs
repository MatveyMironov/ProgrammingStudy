namespace FacadePatternStudyProject
{
    internal class AirConditioner
    {
        public bool IsTurnedOn { get; private set; }

        public int Temperature { get; private set; }

        public void Switch()
        {
            IsTurnedOn = !IsTurnedOn;
        }

        public void SetTemperature(int newTemperature)
        {
            Temperature = newTemperature;
        }

        public override string ToString()
        {
            return $"Is Turnd On: {IsTurnedOn}, Temperature: {Temperature}";
        }
    }
}
