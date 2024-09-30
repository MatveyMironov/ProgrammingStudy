namespace Generics_Boxing_Unboxing;

using System.Diagnostics;
using System.Numerics;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 1");

        List<object> floatsAndInts = new();
        FillTheList(floatsAndInts, 10);
        Console.WriteLine(SumList(floatsAndInts));

        Console.WriteLine();

        Console.WriteLine("Task 2");

        Book<string> book1 = new("Исчерпывающая история развития цветочных горшков", 1246, "Профессор Аманда Гарденер", "A123");
        Book<int> book2 = new("Люди против жуков", 214, "Исаак Сайфаенков", 452);
        Book<Guid> book3 = new("Ласковый взор 7", 416, "Валерия Анлавд", Guid.NewGuid());

        Console.WriteLine(book1.ToString());
        Console.WriteLine(book2.ToString());
        Console.WriteLine(book3.ToString());

        Console.WriteLine();

        Console.WriteLine("Task 3");

        GenericClass<int> generic1 = new(45);
        GenericClass<Book<string>> generic2 = new(book1);

        Console.WriteLine(generic1.Value);
        Console.WriteLine(generic2.Value);

        generic1.Reset();
        generic2.Reset();

        Console.WriteLine(generic1.Value);
        Console.WriteLine(generic2.Value);

        Console.WriteLine();

        Console.WriteLine("Task 4");

        Circle<int> circle1 = new(Vector2.Zero, 5);
        Circle<string> circle2 = new(Vector2.Zero, "7");
        Circle<double> circle3 = new(Vector2.Zero, 3.2);
        Circle<float> circle4 = new(Vector2.Zero, 2.4f);

        circle1.SetRadius(1);
        circle2.SetRadius("2");
        circle3.SetRadius(3.1);
        circle4.SetRadius(4.2f);

        Console.WriteLine($"{circle1.Radius} {circle1.Area}");
        Console.WriteLine($"{circle2.Radius} {circle2.Area}");
        Console.WriteLine($"{circle3.Radius} {circle3.Area}");
        Console.WriteLine($"{circle4.Radius} {circle4.Area}");

        Console.WriteLine();

        Console.WriteLine("Task 5");

        Rectangle<string, int> rectangle1 = new(new Vector2(0f, 0f), "4", 2);
        Rectangle<float, double> rectangle2 = new(new Vector2(1.5f, 2.5f), 2.5f, 3.3);
        Rectangle<string, float> rectangle3 = new(new Vector2(-2.0f, -3.0f), "3", 4.2f);

        Console.WriteLine($"{rectangle1.MinPoint} {rectangle1.MaxPoint}");
        Console.WriteLine($"{rectangle2.MinPoint} {rectangle2.MaxPoint}");
        Console.WriteLine($"{rectangle3.MinPoint} {rectangle3.MaxPoint}");
    }

    public static void FillTheList(List<object> list, int count)
    {
        object value = 0;
        Random random = new();

        for (int i = 0; i < count; i++)
        {
            int chance = random.Next(2);
            if (chance == 0)
            {
                value = random.Next(100);
            }
            if (chance == 1)
            {
                value = (float)random.NextDouble();
            }
            list.Add(value);
        }
    }

    public static float SumList(List<object> list)
    {
        float sum = 0;
        foreach (object item in list)
        {
            Console.WriteLine(item);
            sum += (float)Convert.ToDouble(item);
        }
        return sum;
    }
}
