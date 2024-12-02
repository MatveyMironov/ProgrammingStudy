using System.Collections.Generic;

namespace CreationalPatterns.Prototype
{
    public class TorpedoLauncher
    {
        private List<Torpedo> loadedTorpedoes;

        public TorpedoLauncher()
        {
            loadedTorpedoes = new List<Torpedo>();
        }

        public void LoadNeutronTorpedoes(int count)
        {
            Torpedo torpedo = new NeutronTorpedo(100);

            for (int i=0; i<count; i++)
            {
                loadedTorpedoes.Add(torpedo.Clone());
            }
        }

        public void LoadPlasmaTorpedoes(int count)
        {
            Torpedo torpedo = new PlasmaTorpedo(250);

            for (int i = 0; i < count; i++)
            {
                loadedTorpedoes.Add(torpedo.Clone());
            }
        }

        public void LaunchTorpedoes()
        {
            foreach (Torpedo torpedo in loadedTorpedoes)
            {
                torpedo.Detonate();
            }
        }
    }
}
