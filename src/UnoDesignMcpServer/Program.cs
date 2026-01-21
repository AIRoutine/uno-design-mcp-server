using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ModelContextProtocol.Server;
using UnoDesignMcpServer.Services;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<ContentLoaderService>();
builder.Services.AddMcpServer()
    .WithStdioServerTransport()
    .WithToolsFromAssembly();

var app = builder.Build();
await app.RunAsync();
