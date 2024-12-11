namespace FoodDelivery
{
    internal class NicePackagingOrder : ExtendedOrder
    {
        public NicePackagingOrder(IOrder order) : base(order)
        {
        }

        public override string GetDescription()
        {
            return _order.GetDescription() + " with nice packaging";
        }

        public override int GetPrice()
        {
            return _order.GetPrice() + 150;
        }
    }
}
