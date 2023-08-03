using Application.Common.Core;
using Application.Common.Interfaces;
using Domain.Entities.Minieai;
using LazyCache;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories;

public class CacheLovRepository : CacheRepo, ICacheLovRepository
{
    private readonly IPrimaryDbContext _primDb;
    public CacheLovRepository(IPrimaryDbContext primDb)
    {
        _key = "LIST_OF_VALUE";
        _primDb = primDb;
    }

    public async Task<FbbTblListOfValue> GetByNameAsync(string lovName, CancellationToken cancellationToken = default)
    {
        var list = await _cache.GetAsync<List<FbbTblListOfValue>>(_key);
        if (list == null)
        {
            list = await _primDb.FbbTblListOfValues.ToListAsync(cancellationToken);
            _cache.Add(_key, list, SlidingExpire);
        }
        var item = list.FirstOrDefault(x => x.LovName == lovName);
        return item!;
    }
}
