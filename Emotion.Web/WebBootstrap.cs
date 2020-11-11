#region Using

using System.Threading.Tasks;
using Emotion.Web.RazorTemplates;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

#endregion

namespace Emotion.Web
{
    public class WebBootstrap
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSingleton(services => (IJSInProcessRuntime) services.GetRequiredService<IJSRuntime>());
            await builder.Build().RunAsync();
        }
    }
}