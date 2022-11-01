using Blazored.LocalStorage;
using Blazored.Toast;
using DistEquipment.Client;
using DistEquipment.Client.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IDataProduct, DataProduct>();
builder.Services.AddScoped<IDataCategory, DataCategory>();
builder.Services.AddScoped<IDataCart, DataCart>();
builder.Services.AddScoped<IDataState, DataState>();
builder.Services.AddScoped<IDataSolvent, DataSolvent>();
builder.Services.AddScoped<ICalculator, Calculator>();
builder.Services.AddScoped<IDataWork, DataWork>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredToast();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, AuthentificationProvider>();



await builder.Build().RunAsync();
