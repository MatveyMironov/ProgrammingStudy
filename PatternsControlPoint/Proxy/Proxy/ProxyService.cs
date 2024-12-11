using System;
using System.Threading.Tasks;

namespace Proxy
{
    internal class ProxyService : IService
    {
        private IService _service;

        private string _dataCash;

        public ProxyService(IService service)
        {
            _service = service;
        }

        public string GetData()
        {
            if (_dataCash == null)
            {
                Console.WriteLine("Get data from service");
                _dataCash = _service.GetData();
                Task deleteCashTask = DeleteCashAfterDelay();
            }
            
            return _dataCash;
        }

        private async Task DeleteCashAfterDelay()
        {
            await Task.Delay(5000);
            _dataCash = null;
        }
    }
}
