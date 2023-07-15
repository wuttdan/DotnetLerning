using Bogus;

namespace KafkaDemoLib.Models;

public static class SimpleModelFactory
{
    private static readonly Faker _faker = new Faker("en");
    public static SimpleModel New()
    {
        return new SimpleModel()
        {
            words = string.Join(' ', _faker.Lorem.Words(5))
        };
    }
}