using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HTTProj.Application.Interfaces;
using HTTProj.Data;

namespace ApiHTTProj.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BaseController<TEntity> : ControllerBase where TEntity : class, IHaveId, new()
    {
        private readonly AppDbContext _dbConnectionContext;

        public BaseController(AppDbContext dbConnectionContext)
        {
            _dbConnectionContext = dbConnectionContext;
        }

        [HttpGet]
        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var entities = await _dbConnectionContext.Set<TEntity>().ToListAsync();
            return entities;
        }

        [HttpPost]
        public async Task Add([FromBody] TEntity entity)
        {
            await _dbConnectionContext.Set<TEntity>().AddAsync(entity);
            await _dbConnectionContext.SaveChangesAsync();
        }

        [HttpPut]
        public async Task Update([FromBody] TEntity entity)
        {
            _dbConnectionContext.Set<TEntity>().Update(entity);
            await _dbConnectionContext.SaveChangesAsync();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = new TEntity { Id = id };

            _dbConnectionContext.Set<TEntity>().Remove(entity);
            await _dbConnectionContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
