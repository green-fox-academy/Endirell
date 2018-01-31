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
    }
}
