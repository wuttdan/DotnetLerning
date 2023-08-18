using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data.Common;

namespace Application.Common.Interfaces;

public interface IBaseDbContext : ICanConnect
{
    int DefaultCommandTimeout { get; }
    DatabaseFacade Db { get; }
    DbContext Context { get; }
    DbProviderFactory? DbFactory { get; }
    DbConnection GetDbConnection();
    DbCommand CreateTextCommand(string text);
    DbCommand CreateProcedureCommand(string text);
    int SaveChanges();
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);


}
