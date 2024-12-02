using System;

namespace CreationalPatterns.Prototype
{
    public class PlasmaTorpedo : Torpedo
    {
        public PlasmaTorpedo(float detonationEnergy) : base(detonationEnergy)
        {
        }

        public override Torpedo Clone()
        {
            return new PlasmaTorpedo(_detonationEnergy);
        }

        public override void Detonate()
        {
            Console.WriteLine($"Torpedo explodes and produces cloud of hypervelocity plasma, carying {_detonationEnergy} terajoules of energy; ");
        }
    }
}
