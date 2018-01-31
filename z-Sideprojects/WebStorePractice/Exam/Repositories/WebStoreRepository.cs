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

        public List<Dress> GetClothes()
        {
            return webStoreContext.Dresses.ToList();
        }
    }
}
