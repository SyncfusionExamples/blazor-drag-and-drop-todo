using DragDrop;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzA4NDIzMUAzMjM0MmUzMDJlMzBDazZwNldXQ0dzWlhyL0x4VkZib0Urd3ZUcmJTN29WSlhMNlpEUWk0UnlJPQ==");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor();

await builder.Build().RunAsync();
