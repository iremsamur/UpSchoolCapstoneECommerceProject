using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UpSchoolCapstoneProject.BusinessLayer.Abstract;
using UpSchoolCapstoneProject.DataAccessLayer.Concrete;
using UpSchoolCapstoneProject.DTOLayer.DTOs.ItemDTOs;
using UpSchoolCapstoneProject.EntityLayer.Concrete;

namespace UpSchoolCapstoneProject.APILayer.Controllers
{
    [Route("api/[controller]/[action]")]
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
        [HttpGet]
        public IActionResult GetItemsInTheShowcaseWithImage()
        {
            //sadece 3 veri gelsin
            List<Item> items = new List<Item>();
            var values = _itemService.TGetList();//TGetItemWithImage'deki hatanın sebebini bulunacak
            var count = values.Count();
            for (int i = 0;i < count;i++)
            {

                if (i < 3)
                {
                    items.Add(values[i]);

                }
                else
                {
                    break;
                }
            }

            return Ok(items);
        }



    }
}
