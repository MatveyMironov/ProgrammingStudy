namespace FoodDelivery
{
    internal abstract class ExtendedOrder : IOrder
    {
        protected IOrder _order;

        protected ExtendedOrder(IOrder order)
        {
            _order = order;
        }

        public abstract string GetDescription();

        public abstract int GetPrice();
    }
}
