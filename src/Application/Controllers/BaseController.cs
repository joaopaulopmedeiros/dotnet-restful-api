using Microsoft.AspNetCore.Mvc;
using Presentation.Commom.Messages;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected new ActionResult Response(IResponse response)
        {
            if (response == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(new
                {
                    success = true,
                    data = response.Objects
                });
            }
        }

        protected new ActionResult Response(int Id, IResponse response)
        {
            if (response == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(new
                {
                    success = true,
                    data = response.Object
                });
            }
        }
    }
}
