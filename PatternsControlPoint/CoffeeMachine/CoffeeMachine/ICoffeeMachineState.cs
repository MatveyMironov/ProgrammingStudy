using System;

namespace CoffeeMachine
{
    internal interface ICoffeeMachineState
    {
        void EnterState();
        void InsertCoin();
        void SelectDrink(int index);
        void DispenseDrink();
        void TakeDrink();

        event Action OnStateCompleted;
    }
}
