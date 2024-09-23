using HTTProj.Application;
using Microsoft.AspNetCore.Mvc;

namespace ApiHTTProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController<Product>
    {

        public ProductController(AppDbContext dbConnectionContext) : base(dbConnectionContext)
        {
        }
    }
}
