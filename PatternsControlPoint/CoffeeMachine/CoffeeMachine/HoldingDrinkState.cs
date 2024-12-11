using System;

namespace CoffeeMachine
{
    internal class HoldingDrinkState : ICoffeeMachineState
    {
        public event Action OnStateCompleted;

        public void EnterState()
        {
            Console.WriteLine("Machine finishes dispensing your drink and now asks you to take it");
        }

        public void InsertCoin()
        {
            Console.WriteLine("The coin falls out of the machine because you've already payed");
        }

        public void SelectDrink(int index)
        {
            Console.WriteLine("Machine doesn't react. You should take your drink first");
        }

        public void DispenseDrink()
        {
            Console.WriteLine("Machine doesn't react. The drink is already dispensed");
        }

        public void TakeDrink()
        {
            Console.WriteLine("You take your drink. Machine is ready for the next request");
            OnStateCompleted?.Invoke();
        }
    }
}
