using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Core;

public abstract class BaseDbContext : DbContext, IBaseDbContext
{
    public BaseDbContext(DbContextOptions options) : base(options)
    {
    }
    public int DefaultCommandTimeout => 120;
    public DatabaseFacade Db => Database;
    public DbContext Context => this;
    public DbConnection DbConnection => Db.GetDbConnection();
    public DbProviderFactory? DbFactory => DbProviderFactories.GetFactory(DbConnection);

    public bool CanConnect
    {
        get => Db.CanConnect();
    }

    public DbConnection GetDbConnection()
    {
        var connection = Db.GetDbConnection();
        if (connection.State != ConnectionState.Open)
        {
            connection.Open();
        }
        return connection;
    }

    public DbCommand CreateTextCommand(string text)
    {
        var connection = GetDbConnection();
        var cmd = connection.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = text;
        return cmd;
    }

    public DbCommand CreateProcedureCommand(string text)
    {
        var connection = GetDbConnection();
        var cmd = connection.CreateCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = text;
        return cmd;
    }
}
