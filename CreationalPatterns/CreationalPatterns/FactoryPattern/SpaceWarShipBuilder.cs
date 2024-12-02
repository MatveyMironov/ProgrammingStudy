namespace CreationalPatterns.FactoryPattern
{
    public abstract class SpaceWarShipBuilder
    {
        protected int _dryMass;
        protected int _fueledMass;
        protected int _enginePowerOutput;
        protected float _maxDryAcceleration;
        protected float _maxFueledAcceleration;

        protected SpaceWarShipBuilder(int dryMass, int fueledMass, int enginePowerOutput, float maxDryAcceleration, float maxFueledAcceleration)
        {
            _dryMass = dryMass;
            _fueledMass = fueledMass;
            _enginePowerOutput = enginePowerOutput;
            _maxDryAcceleration = maxDryAcceleration;
            _maxFueledAcceleration = maxFueledAcceleration;
        }

        public abstract SpaceWarShip BuildWarship(string name);
    }
}
