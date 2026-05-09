using CleanArchitectureCQRS.Application.Interfaces;
using Microsoft.Extensions.Caching.Distributed;


namespace CleanArchitectureCQRS.Services
{
    public class RedisService : IRedisService
    {
        private readonly IDistributedCache cache;
        private readonly DistributedCacheEntryOptions _options;

        public RedisService(IDistributedCache cache)
        {

            this.cache = cache;
            _options = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(3600),
                SlidingExpiration = TimeSpan.FromSeconds(1200),
            };
        }
        public async Task<string> GetCachedDataAsync(string key)
        {
            // Try to get data from cache
            return await cache.GetStringAsync(key);
        }
        public async Task SetCacheDataAsync(string key, string value)
        {
            await cache.SetStringAsync(key, value, _options);
        }
        public async Task RemoveCacheDataAsync(string key)
        {
            // SetRemoveAsync: Remove um membro do Set
            await cache.RemoveAsync(key);

        }
    }
}
