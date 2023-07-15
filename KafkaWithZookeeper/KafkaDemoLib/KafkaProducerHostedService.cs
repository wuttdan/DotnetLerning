using Confluent.Kafka;
using KafkaDemoLib.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography;

namespace KafkaDemoLib;

public class KafkaProducerHostedService : IHostedService
{
    private readonly ILogger<KafkaProducerHostedService> _logger;
    private readonly IProducer<Null, string> _producer;

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
                var item = SimpleModelFactory.New();
                _logger.LogInformation("produce: {words}", item.ToJson());
                await _producer.ProduceAsync(KafkaDemoEnv.DemoTopic,
                    new Message<Null, string>
                    {
                        Value = item.ToJson()
                    },
                    cancellationToken);
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
