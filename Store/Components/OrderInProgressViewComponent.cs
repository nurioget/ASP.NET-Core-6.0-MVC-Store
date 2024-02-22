using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Store.Components
{
    public class OrderInProgressViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public OrderInProgressViewComponent(IServiceManager services)
        {
            _manager = services;
        }

        public string Invoke()
        {
            return _manager
                .OrderService
                .NumberOfInProcess
                .ToString();
        }
    }
}
