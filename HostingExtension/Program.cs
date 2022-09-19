using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args).Build();

IConfiguration configuration = host.Services.GetRequiredService<IConfiguration>();

Console.WriteLine("Name: " +  configuration.GetValue<string>("Settings:Name"));

