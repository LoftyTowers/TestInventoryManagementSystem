using Microsoft.AspNetCore.Mvc;

namespace TestInventoryApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private static readonly string[] Items = new[]
        {
            "Laptop", "Monitor", "Keyboard", "Mouse", "Printer"
        };

        [HttpGet]
        public IEnumerable<string> GetItems()
        {
            return Items;
        }
    }
}