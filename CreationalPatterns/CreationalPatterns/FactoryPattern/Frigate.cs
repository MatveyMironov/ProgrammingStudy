namespace CreationalPatterns.FactoryPattern
{
    public class Frigate : SpaceWarShip
    {
        private float _mainAcceleratorLength;

        public Frigate(string name,
                       int dryMass,
                       int fueledMass,
                       int enginePowerOutput,
                       float maxDryAcceleration,
                       float maxFueledAcceleration,
                       float mainAcceleratorLength) : base(name,
                                                           dryMass,
                                                           fueledMass,
                                                           enginePowerOutput,
                                                           maxDryAcceleration,
                                                           maxFueledAcceleration)
        {
            _mainAcceleratorLength = mainAcceleratorLength;
        }

        protected override string GetShipInfo()
        {
            string shipInfo = base.GetShipInfo();
            shipInfo += $"It has combat particle accelerator {_mainAcceleratorLength} meters in length. \n";

            return shipInfo;
        }
    }
}
