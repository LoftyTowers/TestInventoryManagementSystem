using Microsoft.AspNetCore.Mvc;
using TestInventoryApi.Models;


namespace TestInventoryApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly List<ProductModel> Products = new List<ProductModel>
        {
            new ProductModel { Id = 1, Name = "Keyboard", Description = "A keyord", Price = 20.00, StockQuantity = 100, CreateDate = DateTime.Now },
            new ProductModel { Id = 2, Name = "Mouse", Description = "A Mouse", Price = 10.00, StockQuantity = 170, CreateDate = DateTime.Now },
            new ProductModel { Id = 3, Name = "Monitor", Description = "A Monitor", Price = 100.00, StockQuantity = 50, CreateDate = DateTime.Now }
        };

        [HttpGet]
        public IEnumerable<ProductModel> GetProducts()
        {
            return Products;
        }

        [HttpGet("{productId}")]
        public ActionResult<ProductModel> GetProductById(int productId)
        {
            var product = Products.FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product newProduct)
        {
            // Add logic to add the new product to the Products array
            return CreatedAtAction(nameof(GetProductById), new { productId = newProduct.Id }, newProduct);
        }

        [HttpPut("{productId}")]
        public IActionResult UpdateProduct(int productId, [FromBody] Product updatedProduct)
        {
            var product = Products.FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                return NotFound();
            }
            // Update logic here
            return NoContent();
        }

        [HttpDelete("{productId}")]
        public IActionResult DeleteProduct(int productId)
        {
            var product = Products.FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                return NotFound();
            }
            // Delete logic here
            return NoContent();
        }
    }
}