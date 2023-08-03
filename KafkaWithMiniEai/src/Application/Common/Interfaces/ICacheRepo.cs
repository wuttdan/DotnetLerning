using LazyCache;

namespace Application.Common.Interfaces;

public interface ICacheRepo
{
    IAppCache? AppCache { get; }
    TimeSpan SlidingExpire { get; }
    void ClearCache();
}
