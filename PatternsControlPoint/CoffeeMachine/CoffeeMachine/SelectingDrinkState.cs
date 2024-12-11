using System;

namespace CoffeeMachine
{
    internal class SelectingDrinkState : ICoffeeMachineState
    {
        private string[] _drinks;

        public SelectingDrinkState(string[] drinks)
        {
            _drinks = drinks;
        }

        public event Action OnStateCompleted;

        public void EnterState()
        {
            Console.WriteLine("Text on screen: Please select yor drink");
        }

        public void InsertCoin()
        {
            Console.WriteLine("The coin falls out of the machine because you've already payed");
        }

        public void SelectDrink(int index)
        {
            if (index < 0 || index >= _drinks.Length)
            {
                Console.WriteLine("Text on screen: No such drink");
                return;
            }

            Console.WriteLine($"Text on screen: You selected {_drinks[index]}");
            OnStateCompleted?.Invoke();
        }

        public void DispenseDrink()
        {
            Console.WriteLine("Machine doesn't react. You should select drink first");
        }

        public void TakeDrink()
        {
            Console.WriteLine("Machine is empty, nothing to take");
        }
    }
}
