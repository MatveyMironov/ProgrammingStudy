using System;

namespace CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine machine = new CoffeeMachine();

            machine.InsertCoin();
            machine.SelectDrink(4);
            machine.SelectDrink(2);
            machine.DispenseDrink();
            machine.TakeDrink();

            Console.ReadLine();
        }
    }
}
