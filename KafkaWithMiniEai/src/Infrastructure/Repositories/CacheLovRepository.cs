using Application.Common.Core;
using Application.Common.Interfaces;
using Domain.Entities.Minieai;
using LazyCache;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories;

public class CacheLovRepository : CacheRepo, ICacheLovRepository
{
    private readonly IPrimaryDbContext _primDb;
    public CacheLovRepository(IPrimaryDbContext primDb)
    {
        _key = "LIST_OF_VALUE";
        _primDb = primDb;
    }

    public async Task<List<FbbTblListOfValue>?> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var list = await _cache.GetAsync<List<FbbTblListOfValue>>(_key);
        if (list == null)
        {
            list = await _primDb.FbbTblListOfValues.ToListAsync(cancellationToken);
            _cache.Add(_key, list, SlidingExpire);
        }
        return list!;
    }

    public async Task<List<FbbTblListOfValue>?> GetByNameAsync(string lovName, CancellationToken cancellationToken = default)
    {
        var list = await GetAllAsync(cancellationToken);
        var results = list?.Where(x => x.LovName == lovName).ToList();
        return results;
    }

    public async Task<List<FbbTblListOfValue>?> GetFilterAsync(Func<FbbTblListOfValue, bool> predicate, CancellationToken cancellationToken = default)
    {
        var list = await GetAllAsync(cancellationToken);
        var results = list?.Where(predicate).ToList();
        return results;
    }
}
