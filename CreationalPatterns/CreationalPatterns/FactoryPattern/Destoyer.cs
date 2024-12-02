namespace CreationalPatterns.FactoryPattern
{
    public class Destoyer : SpaceWarShip
    {
        private int _torpedoLaunchers;

        public Destoyer(string name,
                        int dryMass,
                        int fueledMass,
                        int enginePowerOutput,
                        float maxDryAcceleration,
                        float maxFueledAcceleration,
                        int torpedoLaunchers) : base(name,
                                                     dryMass,
                                                     fueledMass,
                                                     enginePowerOutput,
                                                     maxDryAcceleration,
                                                     maxFueledAcceleration)
        {
            _torpedoLaunchers = torpedoLaunchers;
        }

        protected override string GetShipInfo()
        {
            string shipInfo = base.GetShipInfo();
            shipInfo += $"It has {_torpedoLaunchers} laser torpedo launchers. \n";

            return shipInfo;
        }
    }
}
