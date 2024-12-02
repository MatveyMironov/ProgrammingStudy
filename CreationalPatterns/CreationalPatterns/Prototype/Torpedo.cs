namespace CreationalPatterns.Prototype
{
    public abstract class Torpedo
    {
        protected float _detonationEnergy;

        public Torpedo(float detonationEnergy)
        {
            _detonationEnergy = detonationEnergy;
        }

        public abstract Torpedo Clone();

        public abstract void Detonate();
    }
}
