using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MatchFlix_Frontend
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            await LoadAppSettingsAsync(builder);
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            builder.Services.AddAntDesign();
            await builder.Build().RunAsync();
        }
        /// <summary>
        /// Load appsettings.json from the  wwwroot folder
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        private static async Task LoadAppSettingsAsync(WebAssemblyHostBuilder builder)
        {
            // read JSON file as a stream for configuration
            var client = new HttpClient() { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
            // the appsettings file must be in 'wwwroot'
            using var response = await client.GetAsync("appsettings.json");
            using var stream = await response.Content.ReadAsStreamAsync();
            builder.Configuration.AddJsonStream(stream);
        }
    }
}
