using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopPage : ContentPage
    {
        // check the carousel view timer in the vifeo
        public ShopPage()
        {
            InitializeComponent();
            this.BindingContext = this;
          //  CollectionListStaackLayout.BindingContext = CollectionList;

        }
        public List<Banner> Banners { get => GetBanners(); }

    
        public List<Product> CollectionList { get => GetCollections(); }
        public List<Product> TrendList { get => GetTrends(); }


       

        private List<Banner> GetBanners()
        {
            var bannerList = new List<Banner>();
            bannerList.Add(new Banner
            {
                Heading = "Summer",
                Message = "Message", Caption = "Vibes",
                Image = "classic.png"
            });
                 bannerList.Add(new Banner
                 {
                     Heading = "Summer",
                     Message = "Message", Caption = "Vibes",
                     Image = "classic.png"
                 });
            return bannerList;
        }

        private List<Product> GetCollections()
        {
            var trendList = new List<Product>();
            trendList.Add(new Product { Image = "floral.png,", Name = "FloralBag", Price = "125.50" });
            trendList.Add(new Product { Image = "floral.png,", Name = "FloralBag", Price = "125.50" });
            return trendList;
        }


        private List<Product> GetTrends()
        {
            var trendList = new List<Product>();
            trendList.Add(new Product { Image = "heeled.png,", Name = "FloralBag", Price = "125.50" });
            trendList.Add(new Product { Image = "floral.png,", Name = "FloralBag", Price = "125.50" });
            return trendList;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
    public class Banner
    {
        public string Heading { get; set; }
        public string Message { get; set; }
        public string Caption { get; set; }
        public string Image { get; set; }
    }



    public class Product
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
}