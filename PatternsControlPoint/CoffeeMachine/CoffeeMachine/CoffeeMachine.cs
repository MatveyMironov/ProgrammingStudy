using System;

namespace CoffeeMachine
{
    internal class CoffeeMachine
    {
        private readonly AwaitingCoinState _awaitingCoinState;
        private readonly SelectingDrinkState _selectingDrinkState;
        private readonly DispensingDrinkState _dispensingDrinkState;
        private readonly HoldingDrinkState _holdingDrinkState;

        private ICoffeeMachineState _currentState;

        public CoffeeMachine()
        {
            string[] drinks = { "espresso", "americano", "capuchino" };

            _awaitingCoinState = new AwaitingCoinState();
            _selectingDrinkState = new SelectingDrinkState(drinks);
            _dispensingDrinkState = new DispensingDrinkState();
            _holdingDrinkState = new HoldingDrinkState();

            _awaitingCoinState.OnStateCompleted += () => Transit(_selectingDrinkState);
            _selectingDrinkState.OnStateCompleted += () => Transit(_dispensingDrinkState);
            _dispensingDrinkState.OnStateCompleted += () => Transit(_holdingDrinkState);
            _holdingDrinkState.OnStateCompleted += () => Transit(_awaitingCoinState);

            Transit(_awaitingCoinState);
        }

        public void InsertCoin()
        {
            _currentState.InsertCoin();
        }

        public void SelectDrink(int index)
        {
            _currentState.SelectDrink(index);
        }

        public void DispenseDrink()
        {
            _currentState.DispenseDrink();
        }

        public void TakeDrink()
        {
            _currentState.TakeDrink();
        }

        private void Transit(ICoffeeMachineState newState)
        {
            _currentState = newState;
            _currentState.EnterState();
        }
    }
}
