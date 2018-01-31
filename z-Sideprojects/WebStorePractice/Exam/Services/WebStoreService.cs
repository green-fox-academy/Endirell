using WebStore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Services
{
    public class WebStoreService
    {
        private WebStoreRepository webStoreRepository;

        public WebStoreService(WebStoreRepository webStoreRepository)
        {
            this.webStoreRepository = webStoreRepository;
        }

        public List<Dress> GetClothesList()
        {
            return webStoreRepository.GetClothes();
        }
    }
}
