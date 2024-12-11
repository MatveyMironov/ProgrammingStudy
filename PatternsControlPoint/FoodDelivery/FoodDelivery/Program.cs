using System;

namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOrder order = new BaseOrder();

            Console.WriteLine(order.GetDescription());
            Console.WriteLine(order.GetPrice());

            order = new ExpressDeliveryOrder(order);

            Console.WriteLine(order.GetDescription());
            Console.WriteLine(order.GetPrice());

            order = new NicePackagingOrder(order);

            Console.WriteLine(order.GetDescription());
            Console.WriteLine(order.GetPrice());

            Console.ReadLine();
        }
    }
}
