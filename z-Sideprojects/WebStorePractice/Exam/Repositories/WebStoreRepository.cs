using WebStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Repositories
{
    public class WebStoreRepository
    {
        private WebStoreContext webStoreContext;

        public WebStoreRepository(WebStoreContext webStoreContext)
        {
            this.webStoreContext = webStoreContext;
        }

        public List<Dress> GetAllClothes()
        {
            return webStoreContext.Dresses.ToList();
        }

        public List<string> GetNameOfClothes()
        {
            return webStoreContext.Dresses.Select(c => c.ItemName).OrderBy(c => c).Distinct().ToList();
        }

        public List<string> GetSizeOfClothes()
        {
            return webStoreContext.Dresses.Select(c => c.Size).OrderBy(c => c).Distinct().ToList();
        }

        public SummarizedItem GetSummarizedItem(int amount, string unitname, string unitsize)
        {
            SummarizedItem summarizedItem = new SummarizedItem(amount, unitname, unitsize);

            List<Dress> dresslist = GetAllClothes();

            foreach (var unit in dresslist)
            {
                if (unit.ItemName.Equals(summarizedItem.UnitName))
                {
                    summarizedItem.UnitCategory = unit.Category;
                    summarizedItem.UnitManufacturer = unit.Manufacturer;
                    summarizedItem.UnitPrice = unit.UnitPrice;
                }
            }

            summarizedItem.Subtotal = summarizedItem.UnitPrice * summarizedItem.Amount;

            return summarizedItem;
        }
            

    }
}
