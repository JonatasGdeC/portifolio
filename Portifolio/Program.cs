using Portifolio.Components;
using Portifolio.Components.Layout;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args: args);

// Add services to the container.
builder.Services.AddLocalization();
builder.Services.AddScoped<SiteUiState>();
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

builder.Services.AddControllers(); 

builder.Configuration.AddEnvironmentVariables();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler(errorHandlingPath: "/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

string[] supportedCultures = ["pt", "en", "es"];
RequestLocalizationOptions localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(defaultCulture: supportedCultures[0])
    .AddSupportedCultures(cultures: supportedCultures)
    .AddSupportedUICultures(uiCultures: supportedCultures);

app.UseRequestLocalization(options: localizationOptions);

app.UseStatusCodePagesWithReExecute(pathFormat: "/not-found", createScopeForStatusCodePages: true);

app.UseAntiforgery();

app.MapStaticAssets();
app.MapControllers();
app.UseStaticFiles();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

if (!app.Environment.IsDevelopment())
{
    string port = Environment.GetEnvironmentVariable(variable: "PORT") ?? "5000";
    app.Urls.Add(item: $"http://*:{port}");
}

app.Run();
