using Bogus;
using Confluent.Kafka;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography;
using static Confluent.Kafka.ConfigPropertyNames;

namespace KafkaDemoLib;

public class KafkaProducerHostedService : IHostedService
{
    private readonly ILogger<KafkaProducerHostedService> _logger;
    private IProducer<Null, string> _producer;
    private Faker _faker = new Faker("en");

    public KafkaProducerHostedService(ILogger<KafkaProducerHostedService> logger)
    {
        _logger = logger;
        _producer = new ProducerBuilder<Null, string>(KafkaDemoEnv.ProducerConf).Build();
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        try
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                var words = $"{DateTime.Now.ToString()}-{string.Join(' ', _faker.Lorem.Words(5))}";
                _logger.LogInformation("produce: {words}", words);
                await _producer.ProduceAsync(KafkaDemoEnv.DemoTopic, new Message<Null, string>
                {
                    Value = words
                }, cancellationToken);
                _producer.Flush(cancellationToken);
                await Task.Delay(TimeSpan.FromSeconds(RandomNumberGenerator.GetInt32(1, 5)), cancellationToken);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error occurred at {GetType().Name}.StartAsync");
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _producer.Dispose();
        return Task.CompletedTask;
    }
}
