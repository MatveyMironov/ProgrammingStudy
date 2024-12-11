using System.Drawing;

namespace FacadePatternStudyProject
{
    internal class Light
    {
        public bool IsTurnedOn { get; private set; }
        public int Brightness { get; private set; }
        public Color Color { get; private set; }

        public void SwitchLight()
        {
            IsTurnedOn = !IsTurnedOn;
        }

        public void ChangeBrightness(int newBrightness)
        {
            if (newBrightness < 0)
            {
                newBrightness = 0;
            }

            Brightness = newBrightness;
        }

        public void ChangeColor(Color newColor)
        {
            Color = newColor;
        }

        public override string ToString()
        {
            return $"Is Turned On: {IsTurnedOn}, Brightness: {Brightness}, Color: {Color}";
        }
    }
}
