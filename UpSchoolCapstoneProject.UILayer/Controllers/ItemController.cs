using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UpSchoolCapstoneProject.DTOLayer.DTOs.ItemDTOs;
using UpSchoolCapstoneProject.EntityLayer.Concrete;

namespace UpSchoolCapstoneProject.UILayer.Controllers
{
    public class ItemController : Controller
    {

        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:7033/api/Item/GetAllItemList");
           
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ItemAllInformationsListDTO>>(jsonString);//burada deserializeobject kullanıyoruz.
            //Bazılarında serialize bazılarında deserialize olur. Buraya Benmi employee'daki propertylerimi
            //karşılamak için verileri tutacağım geçici bir Class1 sınıfını veriyorum.

            return View(values);
        }
        public async Task<IActionResult> GetItemsWithShowcaseImage()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:7033/api/Item/GetItemsInTheShowcaseWithImage");

            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ItemAllInformationsListDTO>>(jsonString);//burada deserializeobject kullanıyoruz.
            //Bazılarında serialize bazılarında deserialize olur. Buraya Benmi employee'daki propertylerimi
            //karşılamak için verileri tutacağım geçici bir Class1 sınıfını veriyorum.

            return View(values);
        }

    }
}
