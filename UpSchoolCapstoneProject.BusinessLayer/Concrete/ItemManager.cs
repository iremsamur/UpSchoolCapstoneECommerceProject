using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchoolCapstoneProject.BusinessLayer.Abstract;
using UpSchoolCapstoneProject.DataAccessLayer.Abstract;
using UpSchoolCapstoneProject.EntityLayer.Concrete;

namespace UpSchoolCapstoneProject.BusinessLayer.Concrete
{
    public class ItemManager : IItemService
    {
        private readonly IItemDal _itemDal;
        private readonly IMediator _mediator;

        public ItemManager(IItemDal itemDal, IMediator mediator)
        {
            _itemDal = itemDal;
            _mediator = mediator;
        }

        public void TDelete(Item t)
        {
            _itemDal.Delete(t);
        }

        public Item TGetByID(int id)
        {
            return _itemDal.GetByID(id);
        }

        public List<Item> TGetItemWithImage()
        {
            return _itemDal.GetItemWithImage();
        }

        public List<Item> TGetItemWithImageAndCategoryAndDetail()
        {
            return _itemDal.GetItemWithImageAndCategoryAndDetail();
        }

        public Item TGetItemWithImageAndCategoryByCategory(int CategoryID)
        {
            return _itemDal.GetItemWithImageAndCategoryByCategory(CategoryID);
        }

        public List<Item> TGetList()
        {
            return _itemDal.GetList();
        }

        public void TInsert(Item t)
        {
            _itemDal.Insert(t);
        }

        public void TUpdate(Item t)
        {
            _itemDal.Update(t);
        }
        
        public ItemRatingsSpModel TGetMostLikedItemAllDetails(int CategoryID)
        {
            return _itemDal.GetMostLikedItemAllDetails(CategoryID);
        }

        public ItemDiscountScoresSpModel TGetMostDiscountedItemAllDetails(int CategoryID)
        {
            return _itemDal.GetMostDiscountedItemAllDetails(CategoryID);
        }
        
    }
}
