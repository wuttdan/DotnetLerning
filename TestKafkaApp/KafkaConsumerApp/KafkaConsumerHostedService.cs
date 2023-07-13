using Confluent.Kafka;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Confluent.Kafka.ConfigPropertyNames;

namespace KafkaDemoApp;

public class KafkaConsumerHostedService : IHostedService
{
    private readonly string DemoTopic = "demo";
    private readonly ILogger<KafkaConsumerHostedService> _logger;
    private IConsumer<Ignore, String> _consumer;

    public KafkaConsumerHostedService(ILogger<KafkaConsumerHostedService> logger)
    {
        _logger = logger;
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            AutoOffsetReset = AutoOffsetReset.Earliest,
            GroupId = "my-group"
        };
        _consumer = new ConsumerBuilder<Ignore, string>(config).Build();
    }
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _consumer.Subscribe(DemoTopic);
        try
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                var cr = _consumer.Consume(cancellationToken);
                if (!string.IsNullOrEmpty(cr.Message.Value))
                {
                    _logger.LogInformation($"Recieved: {cr.Message.Value}");
                }
                await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
            }
        }
        catch (OperationCanceledException)
        {
            // Ctrl-C was pressed.
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