using ECommerce.Business.Category;
using ECommerce.DTO.Category;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryBLL _categoryBLL;
        public CategoryController(ICategoryBLL categoryBLL) 
        {
            _categoryBLL = categoryBLL;
        }
        [HttpGet("GetVIPCategories")]
        public async Task<GenericResponse<List<VIPCategoryDTO>>> Get()
        {
            return new GenericResponse<List<VIPCategoryDTO>> 
            { 
                Message = new MessageResponse
                {
                    Code = 0,
                    Message = "Data Loaded Successfully"
                },
                Result = await _categoryBLL.GetVIPCategories()
            };
        }
    }
}
