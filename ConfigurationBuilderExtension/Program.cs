using Microsoft.Extensions.Configuration;
using ConfigurationBuilderExtension;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .Build();

Settings settings = config.GetSection("Settings").Get<Settings>();

Console.WriteLine("Name: " + config.GetSection("Settings").GetValue<string>("Name"));
Console.WriteLine("Topic: " + config.GetSection("Settings").GetValue<string>("Topic"));
Console.WriteLine("Session: " + config.GetValue<string>("Settings:Session"));


Console.WriteLine("Name: " + settings.Name);
Console.WriteLine("Topic: " +  settings.Topic);
Console.WriteLine("Session: " + settings.Session);


