using System;

namespace FoodDelivery
{
    internal class ExpressDeliveryOrder : ExtendedOrder
    {
        public ExpressDeliveryOrder(IOrder order) : base(order)
        {

        }

        public override string GetDescription()
        {
            return _order.GetDescription() + " express delievery";
        }

        public override int GetPrice()
        {
            return _order.GetPrice() + 300;
        }
    }
}
