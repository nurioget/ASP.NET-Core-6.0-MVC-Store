using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Store.Components
{
    public class UserSummaryViewComponent :ViewComponent
    {
        private readonly IServiceManager _manager;

        public UserSummaryViewComponent(IServiceManager services)
        {
            _manager = services;
        }

        public string Invoke()
        {
            return _manager
                .AuthService
                .GetAllUsers()
                .Count()
                .ToString();
        }
    }
}
