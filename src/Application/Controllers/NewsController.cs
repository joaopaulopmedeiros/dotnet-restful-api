using Microsoft.AspNetCore.Mvc;
using Presentation.Interfaces;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [Route("news")]
    [ApiController]
    public class NewsController : BaseController
    {
        private INewsFacade _facade;

        public NewsController(INewsFacade facade)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _facade.FindAllAsync();
            return Response(result);
        }

        [HttpGet("globo")]
        public async Task<IActionResult> GetFromGlobo()
        {
            var result = await _facade.ScrapAsync();
            return Response(result);
        }
    }
}
