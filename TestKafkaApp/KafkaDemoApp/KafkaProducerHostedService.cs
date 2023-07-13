using Bogus;
using Confluent.Kafka;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace KafkaDemoApp;

public class KafkaProducerHostedService : IHostedService
{
    private readonly ILogger<KafkaProducerHostedService> _logger;
    private IProducer<Null, String> _producer;
    private Faker _faker = new Faker("en");

    public KafkaProducerHostedService(ILogger<KafkaProducerHostedService> logger)
    {
        _logger = logger;
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };
        _producer = new ProducerBuilder<Null, string>(config).Build();
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        for (int i = 0; i < 100; i++)
        {
            var words = $"{i}-"+string.Join(' ', _faker.Lorem.Words(5));
            _logger.LogInformation("produce: {words}", words);
            await _producer.ProduceAsync(KafkaDemoEnv.DemoTopic, new Message<Null, string>
            {
                Value = words
            }, cancellationToken);
        }
        _producer.Flush(TimeSpan.FromSeconds(10));
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _producer.Dispose();
        return Task.CompletedTask;
    }
}
