using Confluent.Kafka;

namespace KafkaDemoLib;

public static class KafkaDemoEnv
{
    public static readonly string DemoTopic = "minieai-commit";
    public static readonly ProducerConfig ProducerConf = new ProducerConfig
    {
        BootstrapServers = "localhost:9092"
    };
    public static readonly ConsumerConfig ConsumerConf = new ConsumerConfig
    {
        BootstrapServers = "localhost:9092",
        AutoOffsetReset = AutoOffsetReset.Earliest,
        GroupId = "my-group"
    };
}