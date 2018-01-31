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
        
        public WebStoreViewModel GetViewModel()
        {
            WebStoreViewModel viewmodel = new WebStoreViewModel
            {
                ClothesNames = webStoreRepository.GetNameOfClothes(),
                ClothesSizes = webStoreRepository.GetSizeOfClothes(),
                Clothes = webStoreRepository.GetAllClothes()
            };

            return viewmodel;
        }
        
        public SummarizedItem GetSummary(int amount, string unitname, string unitsize)
        {
            return webStoreRepository.GetSummarizedItem(amount, unitname, unitsize);
        }

        public List<Dress> ListByPrice(int price, string type)
        {
            List<Dress> forJson = new List<Dress>();

            if (type.Equals("higher"))
            {
                forJson = webStoreRepository.GetAllClothes().Where(j => j.UnitPrice > price).ToList();
            }

            if (type.Equals("lower"))
            {
                forJson = webStoreRepository.GetAllClothes().Where(j => j.UnitPrice < price).ToList();
            }

            if (type.Equals("equal"))
            {
                forJson = webStoreRepository.GetAllClothes().Where(j => j.UnitPrice == price).ToList();
            }

            return forJson;

        }
    }
}
