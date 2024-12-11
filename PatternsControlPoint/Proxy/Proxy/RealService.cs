using System.Threading;

namespace Proxy
{
    internal class RealService : IService
    {
        public string GetData()
        {
            Thread.Sleep(3000);
            return "Some Data";
        }
    }
}
