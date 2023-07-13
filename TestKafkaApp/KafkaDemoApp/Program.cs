// See https://aka.ms/new-console-template for more information
using KafkaDemoApp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, Kafka!");

CreateHostBuilder(args).Build().Run();

static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddHostedService<KafkaConsumerHostedService>();
        services.AddHostedService<KafkaProducerHostedService>();
    });