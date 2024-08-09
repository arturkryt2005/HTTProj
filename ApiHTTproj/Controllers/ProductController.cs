using HTTProj.Application;
using HTTProj.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiHTTProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController<Product>
    {
        protected readonly AppDbContext _context;        

        public ProductController(AppDbContext dbConnectionContext) : base(dbConnectionContext)
        {
        }
    }
}
