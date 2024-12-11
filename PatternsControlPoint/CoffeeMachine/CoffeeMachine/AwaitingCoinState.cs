using System;

namespace CoffeeMachine
{
    internal class AwaitingCoinState : ICoffeeMachineState
    {
        public event Action OnStateCompleted;

        public void EnterState()
        {
            Console.WriteLine("Text on screen: Please insert a coin");
        }

        public void InsertCoin()
        {
            Console.WriteLine("Text on screen: Thanks!");
            OnStateCompleted?.Invoke();
        }

        public void SelectDrink(int index)
        {
            Console.WriteLine("Machine doesn't react. You should insert coin first");
        }

        public void DispenseDrink()
        {
            Console.WriteLine("Machine doesn't react. You should insert coin first");
        }

        public void TakeDrink()
        {
            Console.WriteLine("Machine is empty, nothing to take");
        }
    }
}
