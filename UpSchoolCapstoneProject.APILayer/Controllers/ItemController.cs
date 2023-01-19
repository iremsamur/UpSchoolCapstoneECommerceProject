using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UpSchoolCapstoneProject.BusinessLayer.Abstract;
using UpSchoolCapstoneProject.DataAccessLayer.Concrete;

namespace UpSchoolCapstoneProject.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        //listeleme işlemi
        [HttpGet]//metodun üstüne türünün ne olduğunu belirtiyorum
        //bu bir ekleme mi, silme mi ne ise yazıyorum.
        //listeleme için HttpGet verdim.
        public IActionResult GetAllItemList()
        {
            var values = _itemService.TGetList();
            return Ok(values);

        }
        
    }
}
