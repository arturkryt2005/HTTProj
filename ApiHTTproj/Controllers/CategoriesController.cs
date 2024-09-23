using HTTProj.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



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