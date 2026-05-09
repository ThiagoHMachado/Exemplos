using CleanArchitectureCQRS.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureCQRS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RedisController : Controller
    {
        private readonly IRedisService service;

        // GET: RedisController
        public RedisController(IRedisService service)
        {
            this.service = service;
        }
        [HttpGet("{key}")]
        public async Task<IActionResult> Get(string key)
        {
            var resul = await service.GetCachedDataAsync(key);
            return Ok(resul);
        }



        // POST: RedisController/Create
        [HttpPost("{key}/{value}")]

        public async Task<IActionResult> Set(string key, string value)
        {
            await service.SetCacheDataAsync(key, value);
            return Ok();
        }
        [HttpDelete("{key}")]

        public async Task<IActionResult> Delete(string key)
        {
            await service.RemoveCacheDataAsync(key);
            return Ok();
        }




    }
}
