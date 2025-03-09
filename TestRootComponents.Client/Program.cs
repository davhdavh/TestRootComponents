using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TestRootComponents.Client.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.RegisterForJavaScript<MyRootComponent>("test-wasm");

await builder.Build().RunAsync();
