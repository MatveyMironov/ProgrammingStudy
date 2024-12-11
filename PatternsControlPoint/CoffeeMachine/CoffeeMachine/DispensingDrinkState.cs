using System;

namespace CoffeeMachine
{
    internal class DispensingDrinkState : ICoffeeMachineState
    {
        public event Action OnStateCompleted;

        public void EnterState()
        {
            Console.WriteLine("Text on screen: Please confirm");
        }

        public void InsertCoin()
        {
            Console.WriteLine("The coin falls out of the machine because you've already payed");
        }

        public void SelectDrink(int index)
        {
            Console.WriteLine("Machine doesn't react. You already selected a drink");
        }

        public void DispenseDrink()
        {
            Console.WriteLine("Machine starts to dispense your drink");
            OnStateCompleted?.Invoke();
        }

        public void TakeDrink()
        {
            Console.WriteLine("Machine is empty, nothing to take");
        }
    }
}
