using GNN_DAL.Entities;
using GNN_DAL.Shared;
using GNN_Logic.Services;
using Microsoft.AspNetCore.Mvc;

namespace GNN_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly CategoryService _categoryService;

        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]    
        public async Task<ActionResult<PaginatedResult<Category>>> GetCategoriesAsync(int pageNumber = 1, int pageSize = 10)
        {
            try
            {
                var categories = await _categoryService.GetCategoriesAsync(pageNumber, pageSize);
                return Ok(categories);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
    }
}
