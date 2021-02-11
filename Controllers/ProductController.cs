using System.Collections.Generic;
using System.Threading.Tasks;
using Exemple.Entities;
using Exemple.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exemple.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        public async Task Post([FromBody] Product product,
        [FromServices] IProductRepository productRepository)
        {
            await productRepository.AddAssync(product);
            await productRepository.SaveAsync();
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get([FromServices] IProductRepository productRepository)
        {
            return await productRepository.GetAsync();
        }
    }
}