using WebStore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;
using WebStore.ViewModels;

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
            return webStoreRepository.GetAllClothes();
        }

        public List<string> GetClothesNames()
        {
            return webStoreRepository.GetNameOfClothes();
        }

        public List<string> GetClothesSizes()
        {
            return webStoreRepository.GetSizeOfClothes();
        }

        public WebStoreViewModel GetViewModel()
        {
            WebStoreViewModel viewmodel = new WebStoreViewModel
            {
                ClothesNames = GetClothesNames(),
                ClothesSizes = GetClothesSizes(),
                Clothes = GetClothesList()
            };

            return viewmodel;
        }
    }
}
