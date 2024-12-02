namespace CreationalPatterns.FactoryPattern
{
    internal class FrigateBuilder : SpaceWarShipBuilder
    {
        private float _mainAcceleratorLength;

        public FrigateBuilder(int dryMass, int fueledMass, int enginePowerOutput, float maxDryAcceleration, float maxFueledAcceleration, float mainAcceleratorLength) : base(dryMass, fueledMass, enginePowerOutput, maxDryAcceleration, maxFueledAcceleration)
        {
            _mainAcceleratorLength = mainAcceleratorLength;
        }

        public override SpaceWarShip BuildWarship(string name)
        {
            return new Frigate(name, _dryMass, _fueledMass, _enginePowerOutput, _maxDryAcceleration, _maxFueledAcceleration, _mainAcceleratorLength);
        }
    }
}
