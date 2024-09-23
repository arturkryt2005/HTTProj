using ApiHTTProj.Controllers;
using HTTProj.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiHTTproj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : BaseController<Reviews>
    {
        public ReviewsController(AppDbContext dbConnectionContext) : base(dbConnectionContext)
        {

        }

    }
}
