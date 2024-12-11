namespace _3DObjects
{
    internal class Sphere : ICloneable<Sphere>
    {
        public float Radius;

        public Sphere(float radius)
        {
            Radius = radius;
        }

        public Sphere Clone()
        {
            return new Sphere(Radius);
        }
    }
}
