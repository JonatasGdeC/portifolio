using System.Globalization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using Portifolio.Web;
using Portifolio.Web.Layout;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args: args);

builder.Services.AddLocalization();
builder.Services.AddScoped<SiteUiState>();
builder.RootComponents.Add<App>(selector: "#app");
builder.RootComponents.Add<HeadOutlet>(selector: "head::after");

builder.Services.AddScoped(implementationFactory: sp => new HttpClient { BaseAddress = new Uri(uriString: builder.HostEnvironment.BaseAddress) });

WebAssemblyHost host = builder.Build();

string? selectedCulture = await host.Services.GetRequiredService<IJSRuntime>()
    .InvokeAsync<string?>(identifier: "localStorage.getItem", args: "culture");

string[] supportedCultures = ["pt", "en", "es"];
string cultureName = supportedCultures.Contains(value: selectedCulture) ? selectedCulture! : supportedCultures[0];
CultureInfo culture = new(name: cultureName);
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

await host.RunAsync();
