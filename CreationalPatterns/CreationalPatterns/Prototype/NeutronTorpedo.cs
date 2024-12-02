using System;

namespace CreationalPatterns.Prototype
{
    public class NeutronTorpedo : Torpedo
    {
        public NeutronTorpedo(float detonationEnergy) : base(detonationEnergy)
        {
        }

        public override Torpedo Clone()
        {
            return new NeutronTorpedo(_detonationEnergy);
        }

        public override void Detonate()
        {
            Console.WriteLine($"Torpedo explodes, irradiating surrounding space with fast neutrons, which combined energy is {_detonationEnergy} terajoules. ");
        }
    }
}
