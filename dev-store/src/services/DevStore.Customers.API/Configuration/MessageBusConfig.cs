using DevStore.Core.Utils;
using DevStore.Customers.API.Services;
using DevStore.MessageBus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevStore.Customers.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
           /*
            * services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"))
                .AddHostedService<NewCustomerIntegrationHandler>();
           */
        }
    }
}