using Microsoft.Extensions.DependencyInjection;
using Panviva.Sdk.Services.Core.Handlers.V3;
using Panviva.Sdk.Services.Core.Services;
using Panviva.Sdk.Services.Core.Utilities;
using Panviva.Sdk.Services.Core.Utilities.V3;

namespace Panviva.Sdk.Services.Core.Extensions.V3
{
    public static class ApiServiceCollection
    {
        public static void AddPanvivaApis(this IServiceCollection services)
        {
            services.AddSingleton<InputValidator>();
            services.AddSingleton<RequestUrlConstructor>();
            services.AddSingleton<ApiConfigHelper>();
            services.AddSingleton<IQueryHandler, QueryHandler>();
            services.AddSingleton<ICommandHandler, CommandHandler>();
            services.AddHttpClient<IPanvivaClient, PanvivaClient>();
        }
    }
}