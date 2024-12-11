using System;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IService realService = new RealService();
            IService proxyService = new ProxyService(realService);

            while (true)
            {
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine(proxyService.GetData());
                }
            }
        }
    }
}
