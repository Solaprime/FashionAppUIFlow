using System;
using System.Collections.Generic;
using System.Text;
using FashionApp.Models;

namespace FashionApp.Services
{
    public class ExplorePageServices
    {
       public List<Explore> GetExplores()
        {
            return new List<Explore>() {
                new Explore { ImageUrl = "summerCol.png", SubTag = "SUMMER", Tag = "COLLECTION", Description = "what a short description" },
                new Explore { ImageUrl = "womenCol.png", SubTag = "WOMEN", Tag = "COLLECTION", Description = "what a short description" },
                new Explore { ImageUrl = "SummerCol.png", SubTag = "SUMMER", Tag = "COLLECTION", Description = "what a short description" },
                new Explore { ImageUrl = "SummerCol.png", SubTag = "SUMMER", Tag = "COLLECTION", Description = "what a short description" },
                new Explore { ImageUrl = "womenCol.png", SubTag = "Women", Tag = "COLLECTION", Description = "what a short description" },

            };
        }
    }
}
