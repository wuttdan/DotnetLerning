using Application.Common.Core;
using Application.Common.Interfaces;
using Domain.Entities.Minieai;
using LazyCache;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class CacheValidateRepository : CacheRepo, ICacheValidateRepository
{
    private readonly IPrimaryDbContext _primDb;
    public CacheValidateRepository(IPrimaryDbContext primDb)
    {
        _key = "LIST_OF_VALIDATE";
        _primDb = primDb;
    }

    public async Task<List<FbbTblMappingValidate>?> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var list = await _cache.GetAsync<List<FbbTblMappingValidate>>(_key);
        if (list == null)
        {
            list = await _primDb.FbbTblMappingValidates.ToListAsync(cancellationToken);
            _cache.Add(_key, list, SlidingExpire);
        }
        return list!;
    }

    public async Task<List<FbbTblMappingValidate>?> GetByKeyAsync(string itemKey, string activeFlag = "Y", CancellationToken cancellationToken = default)
    {
        var list = await GetAllAsync(cancellationToken);
        var results = list?.Where(x => x.TypeEvent == itemKey && x.ActiveFlag == activeFlag).ToList();
        return results;
    }

    public async Task<List<FbbTblMappingValidate>?> GetFilterAsync(Func<FbbTblMappingValidate, bool> predicate, CancellationToken cancellationToken = default)
    {
        var list = await GetAllAsync(cancellationToken);
        var results = list?.Where(predicate).ToList();
        return results;
    }
}
