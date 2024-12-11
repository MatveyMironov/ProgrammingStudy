namespace _3DObjects
{
    internal class Cube : ICloneable<Cube>
    {
        public float EdgeLength;

        public Cube(float edgeLength)
        {
            EdgeLength = edgeLength;
        }

        public Cube Clone()
        {
            return new Cube(EdgeLength);
        }
    }
}
