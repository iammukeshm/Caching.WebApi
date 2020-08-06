using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Caching.WebApi.Data;
using Caching.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace Caching.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMemoryCache memoryCache;
        private readonly ApplicationDbContext context;

        public CustomerController(IMemoryCache memoryCache, ApplicationDbContext context)
        {
            this.memoryCache = memoryCache;
            this.context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cacheKey = "customerList";
            if(!memoryCache.TryGetValue(cacheKey, out List<Customer> customerList))
            {
                customerList = await context.Customers.ToListAsync();
                var cacheExpiryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(5),
                    Priority = CacheItemPriority.High,
                    SlidingExpiration = TimeSpan.FromMinutes(2)
                };
                memoryCache.Set(cacheKey, customerList, cacheExpiryOptions);
            }
            return Ok(customerList);
        }
    }
}