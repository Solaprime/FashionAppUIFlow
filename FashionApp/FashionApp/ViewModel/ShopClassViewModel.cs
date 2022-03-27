using System;
using System.Collections.Generic;
using System.Text;
using FashionApp.Models;
using FashionApp.Services;

namespace FashionApp.ViewModel
{
   public class ShopClassViewModel
    {
        public List<Product> Collections { get; set; }
        public List<Product> NewTrends { get; set; }
        //public List<Carousel> Carousels { get; set; }
        public IEnumerable<Carousel> Carousels { get; set; }
     
        public ShopClassViewModel()
        {
            var productServices = new ShopServices();
            Collections = productServices.GetCollections();
            NewTrends = productServices.GetNewTrends();
            Carousels = productServices.GetCarousel();
           
        }
    }
}
