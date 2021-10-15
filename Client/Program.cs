using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Home2Med.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Home2Med.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder
                .Services
                .AddScoped(sp =>
                    new HttpClient {
                        BaseAddress =
                            new Uri(builder.HostEnvironment.BaseAddress)
                    });
            ConfigureServices(builder.Services);
            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IServiceDoctor, ServiceDoctor>();
            services.AddScoped<IServiceNurse, ServiceNurse>();
            services.AddScoped<IServicePatient, ServicePatient>();
            services.AddScoped<IServiceRelative, ServiceRelative>();
            services.AddScoped<IErrorMessage, ErrorMessage>();
        }
    }
}
