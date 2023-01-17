using AutoMapper;
using UpSchoolCapstoneProject.DTOLayer.DTOs.ItemDTOs;
using UpSchoolCapstoneProject.EntityLayer.Concrete;

namespace UpSchoolCapstoneProject.UILayer.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //Burada kaynak ve hedef parametrelerini alır. 
            //Hedef bir durumda DTO iken diğerinde entity olabilir. 
            //Eğer ekleme işlemi yapılacaksa veritabanını kullandığım için
            //kaynak entity olur. Diğer durumda ekleme işlemi için değilde
            //mesela UI tarafında o modeli kullanmam gerekiyorsa bu
            //kez hedef DTO olur. O yüzden iki taraflı tanımlarız
      

            CreateMap<ItemAllInformationsListDTO, Item>();
            CreateMap<Item, ItemAllInformationsListDTO>();

          


        }
    }
}
