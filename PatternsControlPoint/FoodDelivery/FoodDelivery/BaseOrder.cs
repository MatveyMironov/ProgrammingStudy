using System;

namespace FoodDelivery
{
    internal class BaseOrder : IOrder
    {
        public int BasePrice { get; } = 500;
        public string BaseDescription { get; } = "Base Order";

        public int GetPrice()
        {
            return BasePrice;
        }

        public string GetDescription()
        {
            return BaseDescription;
        }
    }
}
