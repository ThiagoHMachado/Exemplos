
namespace CleanArchitectureCQRS.Application.Interfaces
{
    public interface IRedisService
    {
        Task<string> GetCachedDataAsync(string key);
        Task RemoveCacheDataAsync(string key);
        Task SetCacheDataAsync(string key, string value);
    }
}