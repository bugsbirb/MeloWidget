using DotNetEnv;
using Melon.Services;
using Melon.Tasks;
using NetCord.Hosting.Gateway;
using NetCord.Hosting.Services;
using NetCord.Hosting.Services.ApplicationCommands;

Env.Load();
await new Sqlite().CreateTable();

var builder = Host.CreateApplicationBuilder(args);
builder.Services
    .AddDiscordGateway(options =>
    {
        options.Token = Env.GetString("TOKEN");
    })
    .AddApplicationCommands();

builder.Services.AddSingleton<Sqlite>();
builder.Services.AddSingleton<Discord>();
builder.Services.AddSingleton<Melonly>();

builder.Services.AddHostedService<Refresh>();

var host = builder.Build();
host.AddModules(typeof(Program).Assembly);
await host.RunAsync();
