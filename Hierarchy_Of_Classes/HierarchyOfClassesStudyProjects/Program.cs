using HierarchyOfClasses;

Property[] properties = new Property[10];

properties[0] = new Appartment(1000000, 10);
properties[1] = new Appartment(60000000, 120);
properties[2] = new Appartment(170000000, 400);
properties[3] = new Car(200000, 50);
properties[4] = new Car(1300000, 100);
properties[5] = new Car(5000000, 200);
properties[6] = new Boat(150000, 30);
properties[7] = new Boat(3000000, 170);
properties[8] = new CountryHouse(4000000, 80);
properties[9] = new CountryHouse(150000000, 440);

foreach (var property in properties)
{
    Console.WriteLine(property.ToString());
}