using Confluent.Kafka;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace KafkaDemoLib;

public class KafkaConsumerHostedService : IHostedService
{
    private readonly ILogger<KafkaConsumerHostedService> _logger;
    private readonly IConsumer<Ignore, string> _consumer;

    public KafkaConsumerHostedService(ILogger<KafkaConsumerHostedService> logger)
    {
        _logger = logger;
        _consumer = new ConsumerBuilder<Ignore, string>(KafkaDemoEnv.ConsumerConf).Build();
    }
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _consumer.Subscribe(KafkaDemoEnv.DemoTopic);
        try
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                var cr = _consumer.Consume(cancellationToken);
                _logger.LogInformation($"Recieved: {cr.TopicPartitionOffset} {cr.Message.Key} > {cr.Message.Value}");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error occurred at {GetType().Name}.StartAsync");
        }
        finally
        {
            _consumer.Close();
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _consumer.Dispose();
        return Task.CompletedTask;
    }
}