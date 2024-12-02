namespace CreationalPatterns.FactoryPattern
{
    internal class DestroyerBuilder : SpaceWarShipBuilder
    {
        private int _torpedoLaunchers;

        public DestroyerBuilder(int dryMass, int fueledMass, int enginePowerOutput, float maxDryAcceleration, float maxFueledAcceleration, int torpedoLaunchers) : base(dryMass, fueledMass, enginePowerOutput, maxDryAcceleration, maxFueledAcceleration)
        {
            _torpedoLaunchers = torpedoLaunchers;
        }

        public override SpaceWarShip BuildWarship(string name)
        {
            return new Destoyer(name, _dryMass, _fueledMass, _enginePowerOutput, _maxDryAcceleration, _maxFueledAcceleration, _torpedoLaunchers);
        }
    }
}
