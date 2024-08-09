using HTTProj.Application;
using HTTProj.Data;
using Microsoft.AspNetCore.Mvc;

namespace ApiHTTProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : BaseController<Categories>
    {
        public CategoriesController(AppDbContext dbConnectionContext) : base(dbConnectionContext)
        {
        }
    }
}
