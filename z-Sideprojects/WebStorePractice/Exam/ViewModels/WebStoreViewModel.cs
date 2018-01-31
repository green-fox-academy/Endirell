using System.Collections.Generic;
using WebStore.Models;
using WebStore.Repositories;

namespace WebStore.ViewModels
{
    public class WebStoreViewModel
    {
        public List<string> ClothesNames { get; set; }
        public List<string> ClothesSizes { get; set; }
        public List<Dress> Clothes { get; set; }
    }
}
