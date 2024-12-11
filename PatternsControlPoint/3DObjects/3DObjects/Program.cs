using System;

namespace _3DObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sphere sphere = new Sphere(1);
            Sphere sphere1 = sphere.Clone();
            sphere1.Radius = 5;

            Console.WriteLine(sphere.Radius);
            Console.WriteLine(sphere1.Radius);

            Console.ReadLine();
        }
    }
}
