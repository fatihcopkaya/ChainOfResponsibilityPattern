using ChainOfResponsibilityPattern.Abstracts;
using ChainOfResponsibilityPattern.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace ChainOfResponsibilityPattern
{
    public static class IOC
    {
        public static IServiceCollection ServiceRegistration(this IServiceCollection services)
        {
            services.AddKeyedTransient<IHandler, BankAdapterControlHandler>("bankAdapterConrolHandler");
            services.AddKeyedTransient<IHandler, CommissionControlHandler>("commissionControlHandler");
            services.AddKeyedTransient<IHandler, DealerControlHandler>("dealerControlHandler");
            services.AddKeyedTransient<IHandler, PaymentControlHandler>("paymentControlHandler");
            return services;
        }
    }
}
