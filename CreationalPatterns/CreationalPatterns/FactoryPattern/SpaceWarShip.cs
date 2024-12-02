namespace CreationalPatterns.FactoryPattern
{
    public abstract class SpaceWarShip
    {
        private string _name;

        private int _dryMass;
        private int _fueledMass;
        private int _enginePowerOutput;
        private float _maxDryAcceleration;
        private float _maxFueledAcceleration;

        public SpaceWarShip(string name,
                            int dryMass,
                            int fueledMass,
                            int enginePowerOutput,
                            float maxDryAcceleration,
                            float maxFueledAcceleration)
        {
            _name = name;

            _dryMass = dryMass;
            _fueledMass = fueledMass;
            _enginePowerOutput = enginePowerOutput;
            _maxDryAcceleration = maxDryAcceleration;
            _maxFueledAcceleration = maxFueledAcceleration;
        }

        public override string ToString()
        {
            return GetShipInfo();
        }

        protected virtual string GetShipInfo()
        {
            string shipInfo = $"{_name} has dry mass of {_dryMass} tons and {_fueledMass} tons when fully fueled. \n";
            shipInfo += $"It's main engine has {_enginePowerOutput} megawatts of power \n";
            shipInfo += $"which can accelerate the ship at the rate of {_maxDryAcceleration} meters per second per second when most of the fuel is gone, \n";
            shipInfo += $"or {_maxFueledAcceleration} meters per second per second when fully fueled. \n";

            return shipInfo;
        }
    }
}
