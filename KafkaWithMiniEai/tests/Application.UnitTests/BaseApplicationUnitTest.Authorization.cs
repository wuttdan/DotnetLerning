using Application.Common.Models.Authorization;
using Application.Query.Authorization;
using Application.Query.Microsite;
using Application.Query.SendCheckInLate;
using Bogus;
using System.Data;

namespace Application.UnitTests;

public abstract partial class BaseApplicationUnitTest
{
    private static Faker faker = new Faker("en");
    protected CommitAuthorizationRequestModel GetTempAuthorizationInsert()
    {
        var req = new CommitAuthorizationRequestModel
        {
            Header = GetAuthorizationHeader(),
            ACTION = "A",
            USERS = new()
            {
                GenUser(),
                GenUser()
            }
        };
        req.USERS[0].rolePast = "";
        req.USERS[1].rolePast = "";
        return req;
    }

    protected CommitAuthorizationRequestModel GetTempAuthorizationUpdate()
    {
        var req = new CommitAuthorizationRequestModel
        {
            Header = GetAuthorizationHeader(),
            ACTION = "A",
            USERS = new()
            {
                GenUser(),
                GenUser()
            }
        };
        req.USERS[0].rolePast = $"{faker.Lorem.Word().ToUpper()}";
        req.USERS[1].rolePast = $"{faker.Lorem.Word().ToUpper()}";
        return req;
    }

    protected CommitAuthorizationRequestModel GetTempAuthorizationDelete()
    {
        return new()
        {
            Header = GetAuthorizationHeader(),
            USERS = new()
            {
                new()
                {
                    username = $"{faker.Lorem.Word()}",
                    role = $"{faker.Lorem.Word().ToUpper()}"
                },
                new()
                {
                    username = $"{faker.Lorem.Word()}",
                    role = $"{faker.Lorem.Word().ToUpper()}"
                }
            }
        };
    }

    protected AcimRequestUser GenUser()
    {
        return new()
        {
            username = $"{faker.Lorem.Word()}",
            firstName = $"{faker.Lorem.Word()}",
            lastName = $"{faker.Lorem.Word()}",
            email = $"{faker.Lorem.Word().ToLower()}@ais.co.th",
            role = $"{faker.Lorem.Word().ToUpper()}",
            rolePast = "",
            period = $"{faker.Lorem.Word().ToUpper()}",
            startDate = $"{faker.Date.PastDateOnly()}",
            endDate = $"{faker.Date.FutureDateOnly()}",
            locationCode = "",
            locationName = ""
        };
    }
}