using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static BookStoreServer.WebApi.Controllers.BooksController;

namespace BookStoreServer.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    [HttpGet]
    public IActionResult getAll()
    {
        return Ok(SeedData.Categories);
    }
}
