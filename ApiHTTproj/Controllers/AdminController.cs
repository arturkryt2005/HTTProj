using ApiHTTProj.Controllers;
using HTTProj.Application;
using Microsoft.AspNetCore.Mvc;

namespace ApiHTTproj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AdminController : BaseController<Admin>
    {
        public AdminController(AppDbContext dbConnectionContext) : base(dbConnectionContext)
        {

        }

    }

}
