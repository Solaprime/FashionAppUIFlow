using System;
using System.Collections.Generic;
using System.Text;

using FashionApp.Models;

namespace FashionApp.Services
{
   public  class ShopServices
    {
        public List<Product> GetCollections()
        {
            return new List<Product>() { 
                 new Product{ImageUrl ="floral.png", Price = 124.5m, ProdcutName= "FloralBag + Hat"},
                 new Product{ImageUrl ="floral.png", Price = 124.5m, ProdcutName= "FloralBag + Hat"},
                 new Product{ImageUrl ="floral.png", Price = 124.5m, ProdcutName= "FloralBag + Hat"},
                 new Product{ImageUrl ="floral.png", Price = 124.5m, ProdcutName= "FloralBag + Hat"},
                 new Product{ImageUrl ="floral.png", Price = 124.5m, ProdcutName= "FloralBag + Hat"},
            };
        }

        public List<Product> GetNewTrends()
        {
            return new List<Product>() {
           new Product{ImageUrl="heeledShoe.png", ProdcutName = "Biege Heeled Shoe", Price= 234.6m},
           new Product{ImageUrl="heeledShoe.png", ProdcutName = "Biege Heeled Shoe", Price= 234.6m},
           new Product{ImageUrl="heeledShoe.png", ProdcutName = "Biege Heeled Shoe", Price= 234.6m},
           new Product{ImageUrl="heeledShoe.png", ProdcutName = "Biege Heeled Shoe", Price= 234.6m}

           };
        }

        public IEnumerable<Carousel> GetCarousel() {
            return new List<Carousel>() {
             new Carousel{ImageUrl ="classic.png", SmallText="our collection", LargeText="40% Discount", MediumText="Best discount season" },
             new Carousel{ImageUrl ="classic.png", SmallText="our collection", LargeText="40% Discount", MediumText="Best discount season" },
             new Carousel{ImageUrl ="classic.png", SmallText="our collection", LargeText="40% Discount", MediumText="Best discount season" },
             new Carousel{ImageUrl ="classic.png", SmallText="our collection", LargeText="40% Discount", MediumText="Best discount season" },
             new Carousel{ImageUrl ="classic.png", SmallText="our collection", LargeText="40% Discount", MediumText="Best discount season" },
           };
        }
    }
}
