using System;
using System.Collections.Generic;
using System.Text;
using FashionApp.Models;
using FashionApp.Services;

namespace FashionApp.ViewModel
{
   public class ExplorePageViewModel
    {
        public List<Explore> Explores { get; set; }
        public ExplorePageViewModel()
        {
            var exploreServices = new ExplorePageServices();
            Explores = exploreServices.GetExplores();
        }
    }
}
