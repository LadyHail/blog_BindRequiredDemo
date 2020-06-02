using BindRequiredAttributeDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace BindRequiredAttributeDemo.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("/")]
        public IActionResult Create([FromQuery]Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(product);
        }
    }
}