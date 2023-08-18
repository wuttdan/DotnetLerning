using Application.Common.Interfaces;
using LazyCache;
using LazyCache.Providers;
using Microsoft.Extensions.Caching.Memory;

namespace Application.Common.Core;

public abstract class CacheRepo : ICacheRepo
{
    protected const int ExpireMinutes = 30;
    protected string _key = string.Empty;
    protected IAppCache _cache = new CachingService();
    public IAppCache AppCache { get => _cache; }
    public TimeSpan SlidingExpire { get => TimeSpan.FromMinutes(ExpireMinutes); }

    public void ClearCache()
    {
        _cache!.CacheProvider.Dispose();
        var provider = new MemoryCacheProvider(new MemoryCache(new MemoryCacheOptions()));
        _cache = new CachingService(provider);
    }
}
