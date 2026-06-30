using DotNetEnv;
using NetCord.Hosting.Gateway;
using NetCord.Hosting.Services;
using NetCord.Hosting.Services.ApplicationCommands;

Env.Load();
var builder = Host.CreateApplicationBuilder(args);
builder.Services
    .AddDiscordGateway(options =>
    {
        options.Token = Env.GetString("TOKEN");
    })
    .AddApplicationCommands(); 
var host = builder.Build();
host.AddModules(typeof(Program).Assembly);
await host.RunAsync();